using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Mechanika.Drawing
{
    public unsafe abstract class Quantizer
    {

        /// <summary>
        /// Flag used to indicate whether a single pass or two passes are needed for quantization.
        /// </summary>
        private bool singlePass;

        /// <summary>
        /// Struct that defines a 32 bpp colour
        /// </summary>
        /// <remarks>
        /// This struct is used to read data from a 32 bits per pixel image
        /// in memory, and is ordered in this manner as this is the way that
        /// the data is layed out in memory
        /// </remarks>
        [StructLayout(LayoutKind.Explicit)]
        public struct Color32
        {
            /// <summary>
            /// Holds the blue component of the colour
            /// </summary>
            [FieldOffset(0)]
            public byte Blue;
            /// <summary>
            /// Holds the green component of the colour
            /// </summary>
            [FieldOffset(1)]
            public byte Green;
            /// <summary>
            /// Holds the red component of the colour
            /// </summary>
            [FieldOffset(2)]
            public byte Red;
            /// <summary>
            /// Holds the alpha component of the colour
            /// </summary>
            [FieldOffset(3)]
            public byte Alpha;

            /// <summary>
            /// Permits the color32 to be treated as an int32
            /// </summary>
            [FieldOffset(0)]
            public int ARGB;

            /// <summary>
            /// Return the color for this Color32 object
            /// </summary>
            public Color Color
            {
                get { return Color.FromArgb(Alpha, Red, Green, Blue); }
            }
        }

        protected Quantizer(bool singlePass)
        {
            this.singlePass = singlePass;
        }

        /*
        protected void AdjustNeighborSource(int offsetX, int offsetY, int deltaR, int deltaG, int deltaB, int deltaA)
        {
            if (this.bitmapData_0 == null)
            {
                return;
            }
            int int1 = this.int_1 + offsetX;
            int int2 = this.int_2 + offsetY;
            if (int1 < 0 || int1 >= this.bitmapData_0.Width)
            {
                return;
            }
            if (int2 < 0 || int2 >= this.bitmapData_0.Height)
            {
                return;
            }
            IntPtr scan0 = (IntPtr)((long)this.bitmapData_0.Scan0 + (long)int2 * (long)this.bitmapData_0.Stride + (long)(Marshal.SizeOf(typeof(ArgbColor)) * int1));
            ArgbColor argbColor = new ArgbColor(scan0);
            argbColor.R = this.ToByte((int)argbColor.R + deltaR);
            argbColor.G = this.ToByte((int)argbColor.G + deltaG);
            argbColor.B = this.ToByte((int)argbColor.B + deltaB);
            argbColor.A = this.ToByte((int)argbColor.A + deltaA);
            Marshal.StructureToPtr(argbColor, scan0, true);
        }
        */

        /// <summary>
        /// Quantize an image and return the resulting output bitmap
        /// </summary>
        /// <param name="source">The image to quantize</param>
        /// <returns>A quantized version of the image</returns>
        public Bitmap Quantize(Image source)
        {
            // Get the size of the source image
            int height = source.Height;
            int width = source.Width;

            Rectangle bounds = new Rectangle(0, 0, width, height);

            // Construct a 8bpp version
            Bitmap output = new Bitmap(width, height, PixelFormat.Format8bppIndexed);

            using (Bitmap copy = new Bitmap(width, height, PixelFormat.Format32bppArgb))
            {
                // Lock the bitmap into memory
                using (Graphics graphic = Graphics.FromImage(copy))
                {
                    graphic.PageUnit = GraphicsUnit.Pixel;
                    
                    // Draw the source image onto the copy bitmap,
                    // which will effect a widening as appro
                    graphic.DrawImageUnscaled(source, bounds);
                }

                // Define a pointer to the bitmap data
                BitmapData sourceData = null;

                try
                {
                    // Get the source image bits and lock into memory
                    sourceData = copy.LockBits(bounds, ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

                    // Call the FirstPass function if not a single pass algorithm.
                    // For something like an octree quantizer, this will run through
                    // all image pixels, build a data structure, and create a palette.
                    if (!this.singlePass)
                    {
                        this.FirstPass(sourceData, width, height);
                    }

                    // Then set the color palette on the output bitmap. I'm passing in the current palette 
                    // as there's no way to construct a new, empty palette.
                    output.Palette = this.GetPalette(output.Palette);

                    // Then call the second pass which actually does the conversion
                    this.SecondPass(sourceData, output, width, height, bounds);
                }
                finally
                {
                    // Ensure that the bits are unlocked
                    copy.UnlockBits(sourceData);
                }
            }
            return output;
        }

        /// <summary>
        /// Execute the first pass through the pixels in the image.
        /// </summary>
        /// <param name="sourceData">The source data.</param>
        /// <param name="width">The width in pixels of the image.</param>
        /// <param name="height">The height in pixels of the image.</param>
        protected virtual void FirstPass(BitmapData sourceData, int width, int height)
        {
            // Define the source data pointers. The source row is a byte to
            // keep addition of the stride value easier (as this is in bytes).
            byte* pSourceRow = (byte*)sourceData.Scan0.ToPointer();
            Int32* pSourcePixel;
            
            // Loop through each row
            for (int row = 0; row < height; row++)
            {
                // Set the source pixel to the first pixel in this row
                pSourcePixel = (Int32*)pSourceRow;

                // Now loop through each column
                for (int col = 0; col < width; col++)
                {
                    InitialQuantizePixel((Color32*)pSourcePixel);
                }
                // Add the stride to the source row
                pSourceRow += sourceData.Stride;
            }
        }

        /// <summary>
        /// Execute a second pass through the bitmap
        /// </summary>
        /// <param name="sourceData">The source bitmap, locked into memory</param>
        /// <param name="output">The output bitmap</param>
        /// <param name="width">The width in pixels of the image</param>
        /// <param name="height">The height in pixels of the image</param>
        /// <param name="bounds">The bounding rectangle</param>
        protected virtual void SecondPass(BitmapData sourceData, Bitmap output, int width, int height, Rectangle bounds)
        {
            BitmapData outputData = null;
            try
            {
                // Lock the output bitmap into memory
                outputData = output.LockBits(bounds, ImageLockMode.WriteOnly, PixelFormat.Format8bppIndexed);
                
                // Define the source data pointers. The source row is a byte to
                // keep addition of the stride value easier (as this is in bytes).
                byte* pSourceRow = (byte*)sourceData.Scan0.ToPointer();
                Int32* pSourcePixel = (Int32*)pSourceRow;
                Int32* pPreviousPixel = pSourcePixel;

                // Now define the destination data pointers
                byte* pDestinationRow = (byte*)outputData.Scan0.ToPointer();
                byte* pDestinationPixel = pDestinationRow;

                // Convert the first pixel, so that we have values going into the loop
                byte pixelValue = QuantizePixel((Color32*)pSourcePixel);

                // Assign the value of the first pixel
                *pDestinationPixel = pixelValue;
        
                // Loop through each row
                for (int row = 0; row < height; row++)
                {
                    // Set the source pixel to the first pixel in this row
                    pSourcePixel = (Int32*)pSourceRow;
                    
                    // Set the destination pixel pointer to the first pixel in the row
                    pDestinationPixel = pDestinationRow;

                    // Loop through each pixel on thsi scan line
                    for (int col = 0; col < width; col++, pSourcePixel++, pDestinationPixel++)
                    {
                        // Check if this is the same as the last pixel. If so use that value
                        // rather than calculating it again. This is an inexpensive optimization.
                        if (*pPreviousPixel != *pSourcePixel)
                        {
                            // Quantize the pixel
                            pixelValue = QuantizePixel((Color32*)pSourcePixel);
                            pPreviousPixel = pSourcePixel;
                        }
                        // Set the pixel in the output
                        *pDestinationPixel = pixelValue;
                    }
                    // Add the stride to the source and destination row
                    pSourceRow += sourceData.Stride;
                    pDestinationRow += outputData.Stride;
                }
            }
            finally
            {
                // Ensure that we unlock the output bits
                output.UnlockBits(outputData);
            }
        }

        /// <summary>
        /// Override this to process the pixel in the first pass of the algorithm
        /// </summary>
        /// <param name="pixel">The pixel to quantize.</param>
        protected virtual void InitialQuantizePixel(Color32* pixel)
        {
        }

        /// <summary>
        /// Override this to process the pixel in the second pass of the algorithm
        /// </summary>
        /// <param name="pixel">The pixel to quanitize.</param>
        /// <returns>The quantized value</returns>
        protected abstract byte QuantizePixel(Color32* pixel);

        /// <summary>
        /// Retrieve the palette for the quantized image.
        /// </summary>
        /// <param name="original">The old palette, this is overwritten.</param>
        /// <returns>The new color palette</returns>
        protected abstract ColorPalette GetPalette(ColorPalette original);
        
        protected byte ToByte(int i)
        {
            if (i < 0)
            {
                return (byte)0;
            }
            if (i > 255)
            {
                return (byte)255;
            }
            return (byte)i;
        }
    }
}
