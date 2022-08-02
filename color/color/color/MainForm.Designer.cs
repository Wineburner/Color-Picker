
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
            this.OutputValueRed = new System.Windows.Forms.Label();
            this.OutputValueGreen = new System.Windows.Forms.Label();
            this.OutputValueBlue = new System.Windows.Forms.Label();
            this.GroupBoxCMYK = new System.Windows.Forms.GroupBox();
            this.LabelKey = new System.Windows.Forms.Label();
            this.TextBoxKey = new System.Windows.Forms.TextBox();
            this.LabelYellow = new System.Windows.Forms.Label();
            this.TextBoxYellow = new System.Windows.Forms.TextBox();
            this.LabelMagenta = new System.Windows.Forms.Label();
            this.TextBoxMagenta = new System.Windows.Forms.TextBox();
            this.labelCyan = new System.Windows.Forms.Label();
            this.TextBoxCyan = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SliderRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderBlue)).BeginInit();
            this.GroupBoxCMYK.SuspendLayout();
            this.SuspendLayout();
            // 
            // SliderRed
            // 
            this.SliderRed.Location = new System.Drawing.Point(225, 12);
            this.SliderRed.Maximum = 255;
            this.SliderRed.Name = "SliderRed";
            this.SliderRed.Size = new System.Drawing.Size(522, 45);
            this.SliderRed.TabIndex = 0;
            this.SliderRed.Scroll += new System.EventHandler(this.SliderRed_Scroll);
            // 
            // SliderGreen
            // 
            this.SliderGreen.Location = new System.Drawing.Point(225, 63);
            this.SliderGreen.Maximum = 255;
            this.SliderGreen.Name = "SliderGreen";
            this.SliderGreen.Size = new System.Drawing.Size(522, 45);
            this.SliderGreen.TabIndex = 1;
            this.SliderGreen.Scroll += new System.EventHandler(this.SliderGreen_Scroll);
            // 
            // SliderBlue
            // 
            this.SliderBlue.Location = new System.Drawing.Point(225, 114);
            this.SliderBlue.Maximum = 255;
            this.SliderBlue.Name = "SliderBlue";
            this.SliderBlue.Size = new System.Drawing.Size(522, 45);
            this.SliderBlue.TabIndex = 2;
            this.SliderBlue.Scroll += new System.EventHandler(this.SliderBlue_Scroll);
            // 
            // ColorBox
            // 
            this.ColorBox.Location = new System.Drawing.Point(24, 12);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(122, 117);
            this.ColorBox.TabIndex = 3;
            this.ColorBox.UseVisualStyleBackColor = true;
            // 
            // labelRed
            // 
            this.labelRed.AutoSize = true;
            this.labelRed.Location = new System.Drawing.Point(189, 12);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(30, 15);
            this.labelRed.TabIndex = 4;
            this.labelRed.Text = "Red:";
            // 
            // labelGreen
            // 
            this.labelGreen.AutoSize = true;
            this.labelGreen.Location = new System.Drawing.Point(178, 63);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(41, 15);
            this.labelGreen.TabIndex = 5;
            this.labelGreen.Text = "Green:";
            // 
            // labelBlue
            // 
            this.labelBlue.AutoSize = true;
            this.labelBlue.Location = new System.Drawing.Point(186, 114);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(33, 15);
            this.labelBlue.TabIndex = 6;
            this.labelBlue.Text = "Blue:";
            // 
            // TextBoxHex
            // 
            this.TextBoxHex.Location = new System.Drawing.Point(46, 135);
            this.TextBoxHex.Name = "TextBoxHex";
            this.TextBoxHex.Size = new System.Drawing.Size(100, 23);
            this.TextBoxHex.TabIndex = 7;
            this.TextBoxHex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxHex_KeyPress);
            this.TextBoxHex.Leave += new System.EventHandler(this.TextBoxHex_Leave);
            // 
            // LabelHex
            // 
            this.LabelHex.AutoSize = true;
            this.LabelHex.Location = new System.Drawing.Point(9, 138);
            this.LabelHex.Name = "LabelHex";
            this.LabelHex.Size = new System.Drawing.Size(31, 15);
            this.LabelHex.TabIndex = 8;
            this.LabelHex.Text = "Hex:";
            // 
            // OutputValueRed
            // 
            this.OutputValueRed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OutputValueRed.Location = new System.Drawing.Point(753, 12);
            this.OutputValueRed.Name = "OutputValueRed";
            this.OutputValueRed.Size = new System.Drawing.Size(33, 23);
            this.OutputValueRed.TabIndex = 9;
            this.OutputValueRed.Text = "255";
            this.OutputValueRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OutputValueGreen
            // 
            this.OutputValueGreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OutputValueGreen.Location = new System.Drawing.Point(753, 59);
            this.OutputValueGreen.Name = "OutputValueGreen";
            this.OutputValueGreen.Size = new System.Drawing.Size(33, 23);
            this.OutputValueGreen.TabIndex = 10;
            this.OutputValueGreen.Text = "255";
            this.OutputValueGreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OutputValueBlue
            // 
            this.OutputValueBlue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OutputValueBlue.Location = new System.Drawing.Point(753, 110);
            this.OutputValueBlue.Name = "OutputValueBlue";
            this.OutputValueBlue.Size = new System.Drawing.Size(33, 23);
            this.OutputValueBlue.TabIndex = 11;
            this.OutputValueBlue.Text = "255";
            this.OutputValueBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupBoxCMYK
            // 
            this.GroupBoxCMYK.Controls.Add(this.LabelKey);
            this.GroupBoxCMYK.Controls.Add(this.TextBoxKey);
            this.GroupBoxCMYK.Controls.Add(this.LabelYellow);
            this.GroupBoxCMYK.Controls.Add(this.TextBoxYellow);
            this.GroupBoxCMYK.Controls.Add(this.LabelMagenta);
            this.GroupBoxCMYK.Controls.Add(this.TextBoxMagenta);
            this.GroupBoxCMYK.Controls.Add(this.labelCyan);
            this.GroupBoxCMYK.Controls.Add(this.TextBoxCyan);
            this.GroupBoxCMYK.Location = new System.Drawing.Point(9, 165);
            this.GroupBoxCMYK.Name = "GroupBoxCMYK";
            this.GroupBoxCMYK.Size = new System.Drawing.Size(137, 138);
            this.GroupBoxCMYK.TabIndex = 12;
            this.GroupBoxCMYK.TabStop = false;
            this.GroupBoxCMYK.Text = "CMYK";
            // 
            // LabelKey
            // 
            this.LabelKey.AutoSize = true;
            this.LabelKey.Location = new System.Drawing.Point(10, 107);
            this.LabelKey.Name = "LabelKey";
            this.LabelKey.Size = new System.Drawing.Size(68, 15);
            this.LabelKey.TabIndex = 13;
            this.LabelKey.Text = "Key (Black):";
            // 
            // TextBoxKey
            // 
            this.TextBoxKey.Location = new System.Drawing.Point(84, 104);
            this.TextBoxKey.Name = "TextBoxKey";
            this.TextBoxKey.Size = new System.Drawing.Size(42, 23);
            this.TextBoxKey.TabIndex = 14;
            this.TextBoxKey.Text = "100%";
            this.TextBoxKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKey_KeyPress);
            this.TextBoxKey.Leave += new System.EventHandler(this.TextBoxKey_Leave);
            // 
            // LabelYellow
            // 
            this.LabelYellow.AutoSize = true;
            this.LabelYellow.Location = new System.Drawing.Point(34, 78);
            this.LabelYellow.Name = "LabelYellow";
            this.LabelYellow.Size = new System.Drawing.Size(44, 15);
            this.LabelYellow.TabIndex = 13;
            this.LabelYellow.Text = "Yellow:";
            // 
            // TextBoxYellow
            // 
            this.TextBoxYellow.Location = new System.Drawing.Point(84, 75);
            this.TextBoxYellow.Name = "TextBoxYellow";
            this.TextBoxYellow.Size = new System.Drawing.Size(42, 23);
            this.TextBoxYellow.TabIndex = 4;
            this.TextBoxYellow.Text = "100%";
            this.TextBoxYellow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxYellow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxYellow_KeyPress);
            this.TextBoxYellow.Leave += new System.EventHandler(this.TextBoxYellow_Leave);
            // 
            // LabelMagenta
            // 
            this.LabelMagenta.AutoSize = true;
            this.LabelMagenta.Location = new System.Drawing.Point(21, 49);
            this.LabelMagenta.Name = "LabelMagenta";
            this.LabelMagenta.Size = new System.Drawing.Size(57, 15);
            this.LabelMagenta.TabIndex = 3;
            this.LabelMagenta.Text = "Magenta:";
            // 
            // TextBoxMagenta
            // 
            this.TextBoxMagenta.Location = new System.Drawing.Point(84, 46);
            this.TextBoxMagenta.Name = "TextBoxMagenta";
            this.TextBoxMagenta.Size = new System.Drawing.Size(42, 23);
            this.TextBoxMagenta.TabIndex = 2;
            this.TextBoxMagenta.Text = "100%";
            this.TextBoxMagenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxMagenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxMagenta_KeyPress);
            this.TextBoxMagenta.Leave += new System.EventHandler(this.TextBoxMagenta_Leave);
            // 
            // labelCyan
            // 
            this.labelCyan.AutoSize = true;
            this.labelCyan.Location = new System.Drawing.Point(41, 20);
            this.labelCyan.Name = "labelCyan";
            this.labelCyan.Size = new System.Drawing.Size(37, 15);
            this.labelCyan.TabIndex = 1;
            this.labelCyan.Text = "Cyan:";
            // 
            // TextBoxCyan
            // 
            this.TextBoxCyan.Location = new System.Drawing.Point(84, 17);
            this.TextBoxCyan.Name = "TextBoxCyan";
            this.TextBoxCyan.Size = new System.Drawing.Size(42, 23);
            this.TextBoxCyan.TabIndex = 0;
            this.TextBoxCyan.Text = "100%";
            this.TextBoxCyan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxCyan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxCyan_KeyPress);
            this.TextBoxCyan.Leave += new System.EventHandler(this.TextBoxCyan_Leave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 314);
            this.Controls.Add(this.GroupBoxCMYK);
            this.Controls.Add(this.OutputValueBlue);
            this.Controls.Add(this.OutputValueGreen);
            this.Controls.Add(this.OutputValueRed);
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
            this.GroupBoxCMYK.ResumeLayout(false);
            this.GroupBoxCMYK.PerformLayout();
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
        private System.Windows.Forms.Label OutputValueRed;
        private System.Windows.Forms.Label OutputValueGreen;
        private System.Windows.Forms.Label OutputValueBlue;
        private System.Windows.Forms.GroupBox GroupBoxCMYK;
        private System.Windows.Forms.Label LabelKey;
        private System.Windows.Forms.TextBox TextBoxKey;
        private System.Windows.Forms.Label LabelYellow;
        private System.Windows.Forms.TextBox TextBoxYellow;
        private System.Windows.Forms.Label LabelMagenta;
        private System.Windows.Forms.TextBox TextBoxMagenta;
        private System.Windows.Forms.Label labelCyan;
        private System.Windows.Forms.TextBox TextBoxCyan;
    }
}

