using System;
using System.Drawing;
using System.Windows.Forms;
using color.Builders;

namespace color
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            

            InitializeComponent();

            SliderRed.Value = 123;
            SliderGreen.Value = 123;
            SliderBlue.Value = 123;

            ColorBoxChange();  
        }

        public void ColorBoxChange() 
        {
            ColorBox.BackColor = Color.FromArgb(255, SliderRed.Value, SliderGreen.Value, SliderBlue.Value);
            var HexBuilder = new HexBuilder();
            TextBoxHex.Text = HexBuilder.ConvertSlideToHex(SliderRed.Value, SliderGreen.Value, SliderBlue.Value);
        }


        private void SliderRed_Scroll(object sender, EventArgs e)
        {
            ColorBoxChange();
        }

        private void SliderGreen_Scroll(object sender, EventArgs e)
        {
            ColorBoxChange();
        }

        private void SliderBlue_Scroll(object sender, EventArgs e)
        {
            ColorBoxChange();
        }

        private void TextBoxHex_Leave(object sender, EventArgs e)
        {
            HexChange();
        }

        private void TextBoxHex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return) 
            {
                HexChange();
            }
        }

        private void HexChange() 
        {
            try
            {
                var RGBBuilder = new RGBBuilder();
                int[] valueAr = RGBBuilder.ConvertHexToRGB(TextBoxHex.Text.ToUpper());
                SliderRed.Value = valueAr[0];
                SliderGreen.Value = valueAr[1];
                SliderBlue.Value = valueAr[2];
                ColorBoxChange();
            }

            catch 
            {
                MessageBox.Show("Invalid Input");
            }
        }
    }
}
