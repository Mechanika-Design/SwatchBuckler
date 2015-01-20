using System.Drawing;

namespace SwatchBuckler
{
    // Swatch Buckler palette library
    // Copyright © 2014-2015 Mechanika Design.
    // http://www.mechanikadesign.com/swatchbuckler

    // Licensed under the MIT License. See swatchbuckler-license.txt for the full text.

    // If you use this code in your application, acknowledgment is kindly appreciated

    public class ColorHitTestInfo
    {
        #region Public Properties

        public Color Color { get; set; }

        public int Index { get; set; }

        public ColorSource Source { get; set; }

        #endregion
    }
}
