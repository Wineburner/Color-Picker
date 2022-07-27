
namespace color
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SliderRed = new System.Windows.Forms.TrackBar();
            this.SliderGreen = new System.Windows.Forms.TrackBar();
            this.SliderBlue = new System.Windows.Forms.TrackBar();
            this.ColorBox = new System.Windows.Forms.Button();
            this.labelRed = new System.Windows.Forms.Label();
            this.labelGreen = new System.Windows.Forms.Label();
            this.labelBlue = new System.Windows.Forms.Label();
            this.TextBoxHex = new System.Windows.Forms.TextBox();
            this.LabelHex = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SliderRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // SliderRed
            // 
            this.SliderRed.Location = new System.Drawing.Point(248, 249);
            this.SliderRed.Maximum = 255;
            this.SliderRed.Name = "SliderRed";
            this.SliderRed.Size = new System.Drawing.Size(522, 45);
            this.SliderRed.TabIndex = 0;
            this.SliderRed.Scroll += new System.EventHandler(this.SliderRed_Scroll);
            // 
            // SliderGreen
            // 
            this.SliderGreen.Location = new System.Drawing.Point(248, 300);
            this.SliderGreen.Maximum = 255;
            this.SliderGreen.Name = "SliderGreen";
            this.SliderGreen.Size = new System.Drawing.Size(522, 45);
            this.SliderGreen.TabIndex = 1;
            this.SliderGreen.Scroll += new System.EventHandler(this.SliderGreen_Scroll);
            // 
            // SliderBlue
            // 
            this.SliderBlue.Location = new System.Drawing.Point(248, 351);
            this.SliderBlue.Maximum = 255;
            this.SliderBlue.Name = "SliderBlue";
            this.SliderBlue.Size = new System.Drawing.Size(522, 45);
            this.SliderBlue.TabIndex = 2;
            this.SliderBlue.Scroll += new System.EventHandler(this.SliderBlue_Scroll);
            // 
            // ColorBox
            // 
            this.ColorBox.Location = new System.Drawing.Point(47, 249);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(122, 117);
            this.ColorBox.TabIndex = 3;
            this.ColorBox.UseVisualStyleBackColor = true;
            // 
            // labelRed
            // 
            this.labelRed.AutoSize = true;
            this.labelRed.Location = new System.Drawing.Point(212, 249);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(30, 15);
            this.labelRed.TabIndex = 4;
            this.labelRed.Text = "Red:";
            // 
            // labelGreen
            // 
            this.labelGreen.AutoSize = true;
            this.labelGreen.Location = new System.Drawing.Point(201, 300);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(41, 15);
            this.labelGreen.TabIndex = 5;
            this.labelGreen.Text = "Green:";
            // 
            // labelBlue
            // 
            this.labelBlue.AutoSize = true;
            this.labelBlue.Location = new System.Drawing.Point(209, 351);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(33, 15);
            this.labelBlue.TabIndex = 6;
            this.labelBlue.Text = "Blue:";
            // 
            // TextBoxHex
            // 
            this.TextBoxHex.Location = new System.Drawing.Point(69, 372);
            this.TextBoxHex.Name = "TextBoxHex";
            this.TextBoxHex.Size = new System.Drawing.Size(100, 23);
            this.TextBoxHex.TabIndex = 7;
            this.TextBoxHex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxHex_KeyPress);
            this.TextBoxHex.Leave += new System.EventHandler(this.TextBoxHex_Leave);
            // 
            // LabelHex
            // 
            this.LabelHex.AutoSize = true;
            this.LabelHex.Location = new System.Drawing.Point(32, 375);
            this.LabelHex.Name = "LabelHex";
            this.LabelHex.Size = new System.Drawing.Size(31, 15);
            this.LabelHex.TabIndex = 8;
            this.LabelHex.Text = "Hex:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelHex);
            this.Controls.Add(this.TextBoxHex);
            this.Controls.Add(this.labelBlue);
            this.Controls.Add(this.labelGreen);
            this.Controls.Add(this.labelRed);
            this.Controls.Add(this.ColorBox);
            this.Controls.Add(this.SliderBlue);
            this.Controls.Add(this.SliderGreen);
            this.Controls.Add(this.SliderRed);
            this.Name = "MainForm";
            this.Text = "Color Picker";
            ((System.ComponentModel.ISupportInitialize)(this.SliderRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar SliderRed;
        private System.Windows.Forms.TrackBar SliderGreen;
        private System.Windows.Forms.TrackBar SliderBlue;
        private System.Windows.Forms.Button ColorBox;
        private System.Windows.Forms.Label labelRed;
        private System.Windows.Forms.Label labelGreen;
        private System.Windows.Forms.Label labelBlue;
        private System.Windows.Forms.TextBox TextBoxHex;
        private System.Windows.Forms.Label LabelHex;
    }
}

