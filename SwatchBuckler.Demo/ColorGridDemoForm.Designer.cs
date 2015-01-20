namespace SwatchBuckler.Demo
{
    partial class ColorGridDemoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorGridDemoForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.colorGrid = new SwatchBuckler.ColorGrid();
            this.groupBox3 = new SwatchBuckler.Demo.GroupBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.loadPaletteButton = new System.Windows.Forms.Button();
            this.savePaletteButton = new System.Windows.Forms.Button();
            this.groupBox2 = new SwatchBuckler.Demo.GroupBox();
            this.shadesOfGreenButton = new System.Windows.Forms.Button();
            this.shadesOfRedButton = new System.Windows.Forms.Button();
            this.shadesOfBlueButton = new System.Windows.Forms.Button();
            this.grayScaleButton = new System.Windows.Forms.Button();
            this.groupBox1 = new SwatchBuckler.Demo.GroupBox();
            this.paintNetPaletteButton = new System.Windows.Forms.Button();
            this.hexagonPaletteButton = new System.Windows.Forms.Button();
            this.standardColorsButton = new System.Windows.Forms.Button();
            this.office2010Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.colorGrid);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(776, 397);
            this.splitContainer1.SplitterDistance = 386;
            this.splitContainer1.TabIndex = 4;
            // 
            // colorGrid
            // 
            this.colorGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorGrid.CellSize = new System.Drawing.Size(20, 20);
            this.colorGrid.Color = System.Drawing.Color.Transparent;
            this.colorGrid.Location = new System.Drawing.Point(3, 3);
            this.colorGrid.Name = "colorGrid";
            this.colorGrid.ShowCustomColors = false;
            this.colorGrid.Size = new System.Drawing.Size(375, 214);
            this.colorGrid.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.infoLabel);
            this.groupBox3.Controls.Add(this.loadPaletteButton);
            this.groupBox3.Controls.Add(this.savePaletteButton);
            this.groupBox3.Location = new System.Drawing.Point(5, 299);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(381, 95);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "External Palette Files";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(16, 29);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(28, 13);
            this.infoLabel.TabIndex = 5;
            this.infoLabel.Text = "Info:";
            // 
            // loadPaletteButton
            // 
            this.loadPaletteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.loadPaletteButton.Image = ((System.Drawing.Image)(resources.GetObject("loadPaletteButton.Image")));
            this.loadPaletteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loadPaletteButton.Location = new System.Drawing.Point(300, 18);
            this.loadPaletteButton.Name = "loadPaletteButton";
            this.loadPaletteButton.Size = new System.Drawing.Size(75, 28);
            this.loadPaletteButton.TabIndex = 4;
            this.loadPaletteButton.Text = "Load";
            this.loadPaletteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.loadPaletteButton.UseVisualStyleBackColor = true;
            this.loadPaletteButton.Click += new System.EventHandler(this.loadPaletteButton_Click);
            // 
            // savePaletteButton
            // 
            this.savePaletteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.savePaletteButton.Image = ((System.Drawing.Image)(resources.GetObject("savePaletteButton.Image")));
            this.savePaletteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.savePaletteButton.Location = new System.Drawing.Point(300, 52);
            this.savePaletteButton.Name = "savePaletteButton";
            this.savePaletteButton.Size = new System.Drawing.Size(75, 27);
            this.savePaletteButton.TabIndex = 3;
            this.savePaletteButton.Text = "Save As";
            this.savePaletteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.savePaletteButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.shadesOfGreenButton);
            this.groupBox2.Controls.Add(this.shadesOfRedButton);
            this.groupBox2.Controls.Add(this.shadesOfBlueButton);
            this.groupBox2.Controls.Add(this.grayScaleButton);
            this.groupBox2.Location = new System.Drawing.Point(3, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 101);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dynamically Generated Color Palettes";
            // 
            // shadesOfGreenButton
            // 
            this.shadesOfGreenButton.Location = new System.Drawing.Point(19, 24);
            this.shadesOfGreenButton.Name = "shadesOfGreenButton";
            this.shadesOfGreenButton.Size = new System.Drawing.Size(138, 27);
            this.shadesOfGreenButton.TabIndex = 4;
            this.shadesOfGreenButton.Text = "Shades of Green";
            this.shadesOfGreenButton.UseVisualStyleBackColor = true;
            this.shadesOfGreenButton.Click += new System.EventHandler(this.shadesOfGreenButton_Click);
            // 
            // shadesOfRedButton
            // 
            this.shadesOfRedButton.Location = new System.Drawing.Point(164, 24);
            this.shadesOfRedButton.Name = "shadesOfRedButton";
            this.shadesOfRedButton.Size = new System.Drawing.Size(138, 27);
            this.shadesOfRedButton.TabIndex = 5;
            this.shadesOfRedButton.Text = "Shades of Red";
            this.shadesOfRedButton.UseVisualStyleBackColor = true;
            this.shadesOfRedButton.Click += new System.EventHandler(this.shadesOfRedButton_Click);
            // 
            // shadesOfBlueButton
            // 
            this.shadesOfBlueButton.Location = new System.Drawing.Point(19, 57);
            this.shadesOfBlueButton.Name = "shadesOfBlueButton";
            this.shadesOfBlueButton.Size = new System.Drawing.Size(138, 27);
            this.shadesOfBlueButton.TabIndex = 6;
            this.shadesOfBlueButton.Text = "Shades of Blue";
            this.shadesOfBlueButton.UseVisualStyleBackColor = true;
            this.shadesOfBlueButton.Click += new System.EventHandler(this.shadesOfBlueButton_Click);
            // 
            // grayScaleButton
            // 
            this.grayScaleButton.Location = new System.Drawing.Point(164, 57);
            this.grayScaleButton.Name = "grayScaleButton";
            this.grayScaleButton.Size = new System.Drawing.Size(138, 27);
            this.grayScaleButton.TabIndex = 7;
            this.grayScaleButton.Text = "Grayscale";
            this.grayScaleButton.UseVisualStyleBackColor = true;
            this.grayScaleButton.Click += new System.EventHandler(this.grayScaleButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.paintNetPaletteButton);
            this.groupBox1.Controls.Add(this.hexagonPaletteButton);
            this.groupBox1.Controls.Add(this.standardColorsButton);
            this.groupBox1.Controls.Add(this.office2010Button);
            this.groupBox1.Location = new System.Drawing.Point(5, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pre-defined Color Palettes";
            // 
            // paintNetPaletteButton
            // 
            this.paintNetPaletteButton.Location = new System.Drawing.Point(163, 57);
            this.paintNetPaletteButton.Name = "paintNetPaletteButton";
            this.paintNetPaletteButton.Size = new System.Drawing.Size(138, 27);
            this.paintNetPaletteButton.TabIndex = 11;
            this.paintNetPaletteButton.Text = "Paint.NET";
            this.paintNetPaletteButton.UseVisualStyleBackColor = true;
            this.paintNetPaletteButton.Click += new System.EventHandler(this.paintNetPaletteButton_Click);
            // 
            // hexagonPaletteButton
            // 
            this.hexagonPaletteButton.Location = new System.Drawing.Point(18, 57);
            this.hexagonPaletteButton.Name = "hexagonPaletteButton";
            this.hexagonPaletteButton.Size = new System.Drawing.Size(138, 27);
            this.hexagonPaletteButton.TabIndex = 10;
            this.hexagonPaletteButton.Text = "Hexagon";
            this.hexagonPaletteButton.UseVisualStyleBackColor = true;
            this.hexagonPaletteButton.Click += new System.EventHandler(this.hexagonPaletteButton_Click);
            // 
            // standardColorsButton
            // 
            this.standardColorsButton.Location = new System.Drawing.Point(18, 24);
            this.standardColorsButton.Name = "standardColorsButton";
            this.standardColorsButton.Size = new System.Drawing.Size(138, 27);
            this.standardColorsButton.TabIndex = 8;
            this.standardColorsButton.Text = "Standard Colors";
            this.standardColorsButton.UseVisualStyleBackColor = true;
            this.standardColorsButton.Click += new System.EventHandler(this.standardColorsButton_Click);
            // 
            // office2010Button
            // 
            this.office2010Button.Location = new System.Drawing.Point(163, 24);
            this.office2010Button.Name = "office2010Button";
            this.office2010Button.Size = new System.Drawing.Size(138, 27);
            this.office2010Button.TabIndex = 9;
            this.office2010Button.Text = "Office 2010";
            this.office2010Button.UseVisualStyleBackColor = true;
            this.office2010Button.Click += new System.EventHandler(this.office2010Button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 397);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "Swatch Buckler Demonstration";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private GroupBox groupBox3;
        private System.Windows.Forms.Button savePaletteButton;
        private GroupBox groupBox2;
        private System.Windows.Forms.Button shadesOfGreenButton;
        private System.Windows.Forms.Button shadesOfRedButton;
        private System.Windows.Forms.Button shadesOfBlueButton;
        private System.Windows.Forms.Button grayScaleButton;
        private GroupBox groupBox1;
        private System.Windows.Forms.Button paintNetPaletteButton;
        private System.Windows.Forms.Button hexagonPaletteButton;
        private System.Windows.Forms.Button standardColorsButton;
        private System.Windows.Forms.Button office2010Button;
        private System.Windows.Forms.Button loadPaletteButton;
        private System.Windows.Forms.Label infoLabel;
        private ColorGrid colorGrid;
    }
}

