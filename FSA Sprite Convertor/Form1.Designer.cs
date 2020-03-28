namespace FSA_Sprite_Convertor
{
    partial class Form1
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
            this.textBoxSpriteSheet = new System.Windows.Forms.TextBox();
            this.buttonSpriteSheet = new System.Windows.Forms.Button();
            this.textBoxPalette = new System.Windows.Forms.TextBox();
            this.buttonPalette = new System.Windows.Forms.Button();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.labelWidth = new System.Windows.Forms.Label();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.labelHeight = new System.Windows.Forms.Label();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.pictureBoxSprites = new System.Windows.Forms.PictureBox();
            this.textBoxPaletteNum = new System.Windows.Forms.TextBox();
            this.labelPaletteNum = new System.Windows.Forms.Label();
            this.checkBoxSave = new System.Windows.Forms.CheckBox();
            this.textBoxTexOffset = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownPalette = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSprites)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPalette)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSpriteSheet
            // 
            this.textBoxSpriteSheet.Location = new System.Drawing.Point(13, 13);
            this.textBoxSpriteSheet.Name = "textBoxSpriteSheet";
            this.textBoxSpriteSheet.ReadOnly = true;
            this.textBoxSpriteSheet.Size = new System.Drawing.Size(372, 20);
            this.textBoxSpriteSheet.TabIndex = 0;
            // 
            // buttonSpriteSheet
            // 
            this.buttonSpriteSheet.Location = new System.Drawing.Point(391, 11);
            this.buttonSpriteSheet.Name = "buttonSpriteSheet";
            this.buttonSpriteSheet.Size = new System.Drawing.Size(87, 23);
            this.buttonSpriteSheet.TabIndex = 1;
            this.buttonSpriteSheet.Text = "SpriteSheet...";
            this.buttonSpriteSheet.UseVisualStyleBackColor = true;
            this.buttonSpriteSheet.Click += new System.EventHandler(this.buttonSpriteSheet_Click);
            // 
            // textBoxPalette
            // 
            this.textBoxPalette.Location = new System.Drawing.Point(13, 39);
            this.textBoxPalette.Name = "textBoxPalette";
            this.textBoxPalette.ReadOnly = true;
            this.textBoxPalette.Size = new System.Drawing.Size(372, 20);
            this.textBoxPalette.TabIndex = 0;
            // 
            // buttonPalette
            // 
            this.buttonPalette.Location = new System.Drawing.Point(391, 37);
            this.buttonPalette.Name = "buttonPalette";
            this.buttonPalette.Size = new System.Drawing.Size(87, 23);
            this.buttonPalette.TabIndex = 1;
            this.buttonPalette.Text = "Palette...";
            this.buttonPalette.UseVisualStyleBackColor = true;
            this.buttonPalette.Click += new System.EventHandler(this.buttonPalette_Click);
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(51, 65);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(52, 20);
            this.textBoxWidth.TabIndex = 2;
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(12, 68);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(38, 13);
            this.labelWidth.TabIndex = 3;
            this.labelWidth.Text = "Width:";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Enabled = false;
            this.textBoxHeight.Location = new System.Drawing.Point(150, 65);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(52, 20);
            this.textBoxHeight.TabIndex = 2;
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(109, 68);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(41, 13);
            this.labelHeight.TabIndex = 3;
            this.labelHeight.Text = "Height:";
            // 
            // buttonConvert
            // 
            this.buttonConvert.Enabled = false;
            this.buttonConvert.Location = new System.Drawing.Point(392, 63);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(87, 23);
            this.buttonConvert.TabIndex = 4;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // pictureBoxSprites
            // 
            this.pictureBoxSprites.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxSprites.Location = new System.Drawing.Point(13, 130);
            this.pictureBoxSprites.Name = "pictureBoxSprites";
            this.pictureBoxSprites.Size = new System.Drawing.Size(465, 323);
            this.pictureBoxSprites.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSprites.TabIndex = 5;
            this.pictureBoxSprites.TabStop = false;
            // 
            // textBoxPaletteNum
            // 
            this.textBoxPaletteNum.Location = new System.Drawing.Point(256, 91);
            this.textBoxPaletteNum.Name = "textBoxPaletteNum";
            this.textBoxPaletteNum.Size = new System.Drawing.Size(52, 20);
            this.textBoxPaletteNum.TabIndex = 2;
            // 
            // labelPaletteNum
            // 
            this.labelPaletteNum.AutoSize = true;
            this.labelPaletteNum.Location = new System.Drawing.Point(207, 68);
            this.labelPaletteNum.Name = "labelPaletteNum";
            this.labelPaletteNum.Size = new System.Drawing.Size(43, 13);
            this.labelPaletteNum.TabIndex = 3;
            this.labelPaletteNum.Text = "Palette:";
            // 
            // checkBoxSave
            // 
            this.checkBoxSave.AutoSize = true;
            this.checkBoxSave.Location = new System.Drawing.Point(328, 67);
            this.checkBoxSave.Name = "checkBoxSave";
            this.checkBoxSave.Size = new System.Drawing.Size(57, 17);
            this.checkBoxSave.TabIndex = 6;
            this.checkBoxSave.Text = "Save?";
            this.checkBoxSave.UseVisualStyleBackColor = true;
            // 
            // textBoxTexOffset
            // 
            this.textBoxTexOffset.Location = new System.Drawing.Point(80, 91);
            this.textBoxTexOffset.Name = "textBoxTexOffset";
            this.textBoxTexOffset.Size = new System.Drawing.Size(52, 20);
            this.textBoxTexOffset.TabIndex = 2;
            this.textBoxTexOffset.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tex Offset:";
            // 
            // numericUpDownPalette
            // 
            this.numericUpDownPalette.Location = new System.Drawing.Point(256, 65);
            this.numericUpDownPalette.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownPalette.Name = "numericUpDownPalette";
            this.numericUpDownPalette.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownPalette.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pal Offset:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 465);
            this.Controls.Add(this.numericUpDownPalette);
            this.Controls.Add(this.checkBoxSave);
            this.Controls.Add(this.pictureBoxSprites);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.labelPaletteNum);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.textBoxPaletteNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.textBoxTexOffset);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.buttonPalette);
            this.Controls.Add(this.buttonSpriteSheet);
            this.Controls.Add(this.textBoxPalette);
            this.Controls.Add(this.textBoxSpriteSheet);
            this.MinimumSize = new System.Drawing.Size(499, 499);
            this.Name = "Form1";
            this.Text = "FSA Sprite Convertor by jaytheham@gmail.com";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSprites)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPalette)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSpriteSheet;
        private System.Windows.Forms.Button buttonSpriteSheet;
        private System.Windows.Forms.TextBox textBoxPalette;
        private System.Windows.Forms.Button buttonPalette;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.PictureBox pictureBoxSprites;
        private System.Windows.Forms.TextBox textBoxPaletteNum;
        private System.Windows.Forms.Label labelPaletteNum;
        private System.Windows.Forms.CheckBox checkBoxSave;
        private System.Windows.Forms.TextBox textBoxTexOffset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownPalette;
        private System.Windows.Forms.Label label2;
    }
}

