namespace SwatchBuckler.Demo
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.colorGridDemoButton = new System.Windows.Forms.Button();
            this.groupBox1 = new SwatchBuckler.Demo.GroupBox();
            this.imagePaletteDemoButton = new System.Windows.Forms.Button();
            this.colorMatchDemoButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorGridDemoButton
            // 
            this.colorGridDemoButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorGridDemoButton.Location = new System.Drawing.Point(6, 22);
            this.colorGridDemoButton.Name = "colorGridDemoButton";
            this.colorGridDemoButton.Size = new System.Drawing.Size(574, 27);
            this.colorGridDemoButton.TabIndex = 0;
            this.colorGridDemoButton.Text = "Palette Control Demonstration";
            this.colorGridDemoButton.UseVisualStyleBackColor = true;
            this.colorGridDemoButton.Click += new System.EventHandler(this.colorGridDemoButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.imagePaletteDemoButton);
            this.groupBox1.Controls.Add(this.colorMatchDemoButton);
            this.groupBox1.Controls.Add(this.colorGridDemoButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 326);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Available Demonstrations";
            // 
            // imagePaletteDemoButton
            // 
            this.imagePaletteDemoButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imagePaletteDemoButton.Location = new System.Drawing.Point(7, 55);
            this.imagePaletteDemoButton.Name = "imagePaletteDemoButton";
            this.imagePaletteDemoButton.Size = new System.Drawing.Size(574, 27);
            this.imagePaletteDemoButton.TabIndex = 2;
            this.imagePaletteDemoButton.Text = "Palette From Image Demonstration  (coming soon)";
            this.imagePaletteDemoButton.UseVisualStyleBackColor = true;
            this.imagePaletteDemoButton.Click += new System.EventHandler(this.imagePaletteDemoButton_Click);
            // 
            // colorMatchDemoButton
            // 
            this.colorMatchDemoButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorMatchDemoButton.Location = new System.Drawing.Point(6, 88);
            this.colorMatchDemoButton.Name = "colorMatchDemoButton";
            this.colorMatchDemoButton.Size = new System.Drawing.Size(574, 27);
            this.colorMatchDemoButton.TabIndex = 1;
            this.colorMatchDemoButton.Text = "Color &Matching Demonstration (coming soon)";
            this.colorMatchDemoButton.UseVisualStyleBackColor = true;
            this.colorMatchDemoButton.Click += new System.EventHandler(this.colorMatchDemoButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = null;
            this.ClientSize = new System.Drawing.Size(615, 495);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.ShowIcon = true;
            this.ShowInTaskbar = true;
            this.Text = "Swatch Buckler Demonstration";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button colorGridDemoButton;
    private GroupBox groupBox1;
    private System.Windows.Forms.Button colorMatchDemoButton;
    private System.Windows.Forms.Button imagePaletteDemoButton;



  }
}

