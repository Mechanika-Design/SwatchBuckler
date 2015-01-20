using System;
using System.Windows.Forms;

namespace SwatchBuckler.Demo
{
    // Swatch Buckler palette library
    // Copyright © 2014-2015 Mechanika Design.
    // http://www.mechanikadesign.com/swatchbuckler

    // Licensed under the MIT License. See swatchbuckler-license.txt for the full text.

    // If you use this code in your application, acknowledgment is kindly appreciated

  internal partial class MainForm : AboutDialog
  {
    #region Public Constructors

    public MainForm()
    {
      InitializeComponent();
    }

    #endregion

    #region Overridden Methods

    protected override void OnLoad(EventArgs e)
    {
      TabPage demoPage;

      base.OnLoad(e);

      demoPage = new TabPage
                 {
                   UseVisualStyleBackColor = true,
                   Padding = new Padding(9),
                   Text = "Demonstrations"
                 };

      groupBox1.Dock = DockStyle.Fill;
      demoPage.Controls.Add(groupBox1);

      this.TabControl.TabPages.Insert(0, demoPage);
      this.TabControl.SelectedTab = demoPage;

      this.Text = "Swatch Buckler Demonstration";
    }

    #endregion

    #region Private Members

    private void aboutButton_Click(object sender, EventArgs e)
    {
      using (Form dialog = new AboutDialog())
      {
        dialog.ShowDialog(this);
      }
    }

    private void exitButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    #endregion

    #region Event Handlers

    private void colorGridDemoButton_Click(object sender, EventArgs e)
    {
      using (Form dialog = new ColorGridDemoForm())
      {
        dialog.ShowDialog(this);
      }
    }

    #endregion

    private void imagePaletteDemoButton_Click(object sender, EventArgs e)
    {
        /* using (Form dialog = new PaletteFromImage())
        {
            dialog.ShowDialog(this);
        }
        */
    }

    private void MainForm_Load(object sender, EventArgs e)
    {

    }

    private void colorMatchDemoButton_Click(object sender, EventArgs e)
    {

    }
  }
}
