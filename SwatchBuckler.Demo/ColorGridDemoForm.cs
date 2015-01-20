using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SwatchBuckler;

namespace SwatchBuckler.Demo
{
    internal sealed partial class ColorGridDemoForm : Form
    {

        #region Constants

        private const int DefaultX = 6;

        private const int DefaultY = 6;

        private const int Spacing = 6;

        private const int CellSize = 24;

        #endregion

        #region Instance Fields

        private ColorCollection m_loadedPalette;
        private IPalette m_serializer;

        #endregion

        public ColorGridDemoForm()
        {
            InitializeComponent();
        }

        private void loadPaletteButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.RestoreDirectory = true;
            fileDialog.Filter = "All Supported Palettes (*.aco;*.gpl;*.bbm;*.lbm;*.pal;*.txt)|*.aco;*.gpl;*.bbm;*.lbm;*.pal;*.txt|Adobe Photoshop Color Swatch Files (*.aco)|*.aco|GIMP Palette Files (*.gpl)|*.gpl|Interleaved Bitmap Palette Files (*.bbm;*.lbm)|*.bbm;*.lbm|JASC Palette Files (*.pal)|*.pal|Paint.NET Palette Files (*.txt)|*.txt|Raw Palette Files (*.pal)|*.pal|All Files (*.*)|*.*";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (fileDialog.OpenFile() != null)
                    {

                        m_serializer = Palette.GetSerializer(fileDialog.FileName);
                        using (Stream stream = File.OpenRead(fileDialog.FileName))
                        {
                            m_loadedPalette = m_serializer.Deserialize(stream);
                            colorGrid.Colors = m_loadedPalette;
                        }

                        infoLabel.Text = string.Format("Filename: {0}\nFormat: {1}", Path.GetFileName(fileDialog.FileName), m_serializer.Name);
                    }
                }
                catch (Exception ex)
                {
                    m_loadedPalette = null;
                    this.Text = Application.ProductName;
                    MessageBox.Show("Could not read file from disk. Error: " + ex.Message);
                }
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void grayScaleButton_Click(object sender, EventArgs e)
        {
            colorGrid.Colors = new ColorCollection(Enumerable.Range(0, 254).Select(i => Color.FromArgb(i, i, i)));
        }

        private void hexagonPaletteButton_Click(object sender, EventArgs e)
        {
            // NOTE: Predefined palettes can now be set via the Palette property
            colorGrid.Colors = ColorPalettes.HexagonPalette;
        }

        private void standardColorsButton_Click(object sender, EventArgs e)
        {
            // NOTE: Predefined palettes can now be set via the Palette property
            colorGrid.Colors = ColorPalettes.NamedColors;
        }

        private void office2010Button_Click(object sender, EventArgs e)
        {
            // NOTE: Predefined palettes can now be set via the Palette property (this does not affect other properties such as Columns below though!)
            colorGrid.Colors = ColorPalettes.Office2010Standard;
            colorGrid.Columns = 10;
        }

        private void paintNetPaletteButton_Click(object sender, EventArgs e)
        {
            // NOTE: Predefined palettes can now be set via the Palette property
            colorGrid.Colors = ColorPalettes.PaintPalette;
        }

        private void shadesOfGreenButton_Click(object sender, EventArgs e)
        {
            colorGrid.Colors = new ColorCollection(Enumerable.Range(0, 254).Select(i => Color.FromArgb(0, i, 0)));
        }

        private void shadesOfRedButton_Click(object sender, EventArgs e)
        {
            colorGrid.Colors = new ColorCollection(Enumerable.Range(0, 254).Select(i => Color.FromArgb(i, 0, 0)));
        }

        private void shadesOfBlueButton_Click(object sender, EventArgs e)
        {
            colorGrid.Colors = new ColorCollection(Enumerable.Range(0, 254).Select(i => Color.FromArgb(0, 0, i)));
        }
    }
}
