using System;
using System.Drawing;
using System.Windows.Forms;
using color.Builders;

namespace color
{

    public partial class MainForm : Form
    {

        private const int DEFAULT_VALUE = 123;
        private const int PERCENT_MULTIPLIER = 100;
        private double[] CMYK = { 0, 0, 0, 0 };
        private readonly RGBToHexBuilder _rGBToHexBuilder;
        private readonly RGBToCMYKBuilder _rGBToCMYKBuiler;
        private readonly HexToRGBBuilder _hexToRGBBuilder;

        public MainForm(RGBToHexBuilder rGBToHexBuilder, RGBToCMYKBuilder rGBToCMYKBuilder, HexToRGBBuilder hexToRGBBuilder) 
        {
            InitializeComponent();

            _rGBToHexBuilder = rGBToHexBuilder;
            _rGBToCMYKBuiler = rGBToCMYKBuilder;
            _hexToRGBBuilder = hexToRGBBuilder;

            SliderRed.Value = DEFAULT_VALUE;
            SliderGreen.Value = DEFAULT_VALUE;
            SliderBlue.Value = DEFAULT_VALUE;

            ColorBoxChange();
        }

        public void ColorBoxChange()
        {
            ColorBox.BackColor = Color.FromArgb(255, SliderRed.Value, SliderGreen.Value, SliderBlue.Value);
            TextBoxHex.Text = _rGBToHexBuilder.ConvertSlideToHex(SliderRed.Value, SliderGreen.Value, SliderBlue.Value);
            CMYK = _rGBToCMYKBuiler.ConvertRGBToCMYK(SliderRed.Value, SliderGreen.Value, SliderBlue.Value);
            TextBoxCyan.Text = CMYKToPercent(CMYK[0]);
            TextBoxMagenta.Text = CMYKToPercent(CMYK[1]);
            TextBoxYellow.Text = CMYKToPercent(CMYK[2]);
            TextBoxKey.Text = CMYKToPercent(CMYK[3]);
            UpdateSliderNumbers();
        }


        private void SliderRed_Scroll(object sender, EventArgs e)
        {
            UpdateSliderNumbers();
            ColorBoxChange();
        }

        private void SliderGreen_Scroll(object sender, EventArgs e)
        {
            UpdateSliderNumbers();
            ColorBoxChange();
        }

        private void SliderBlue_Scroll(object sender, EventArgs e)
        {
            UpdateSliderNumbers();
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
                int[] valueAr = _hexToRGBBuilder.ConvertHexToRGB(TextBoxHex.Text.ToUpper());
                SliderRed.Value = valueAr[0];
                SliderGreen.Value = valueAr[1];
                SliderBlue.Value = valueAr[2];
                ColorBoxChange();
        }

        private void UpdateSliderNumbers()
        {
            OutputValueRed.Text = SliderRed.Value.ToString();
            OutputValueGreen.Text = SliderGreen.Value.ToString();
            OutputValueBlue.Text = SliderBlue.Value.ToString();
        }

        private string CMYKToPercent(double percent) 
        {
            if (percent > 0)
            {
                return (percent * PERCENT_MULTIPLIER).ToString("N0");
            }

            else 
            {
                return "0";
            }
        }

        private void CMYKChange() 
        {
            var CMYKBuilder = new CMYKToRGBBuilder();
            int[] valueAr = CMYKBuilder.ConvertCYMKToRGB(CMYK[0], CMYK[1], CMYK[2], CMYK[3]);
            SliderRed.Value = valueAr[0];
            SliderGreen.Value = valueAr[1];
            SliderBlue.Value = valueAr[2];
            ColorBoxChange();

        }
        private void CMYKUpdate(int color)
        {
            double colorPercent = 0;

            if (color == 0)
            {
                double.TryParse(TextBoxCyan.Text, out colorPercent);
                CMYK[color] = (colorPercent / PERCENT_MULTIPLIER);
            }

            else if (color == 1)
            {
                double.TryParse(TextBoxMagenta.Text, out colorPercent);
                CMYK[color] = (colorPercent / PERCENT_MULTIPLIER);
            }

            else if (color == 2)
            {
                double.TryParse(TextBoxYellow.Text, out colorPercent);
                CMYK[color] = (colorPercent / PERCENT_MULTIPLIER);
            }

            else if (color == 3)
            {
                double.TryParse(TextBoxKey.Text, out colorPercent);
                CMYK[color] = (colorPercent / PERCENT_MULTIPLIER);
            }

        }

        private void TextBoxCyan_Leave(object sender, EventArgs e)
        {
            CMYKUpdate(0);
            CMYKChange();
        }

        private void TextBoxCyan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                CMYKUpdate(0);
                CMYKChange();
            }
        }

        private void TextBoxMagenta_Leave(object sender, EventArgs e)
        {
            CMYKUpdate(1);
            CMYKChange();
        }

        private void TextBoxMagenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                CMYKUpdate(1);
                CMYKChange();
            }
        }

        private void TextBoxYellow_Leave(object sender, EventArgs e)
        {
            CMYKUpdate(2);
            CMYKChange();
        }

        private void TextBoxYellow_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                CMYKUpdate(2);
                CMYKChange();
            }
        }

        private void TextBoxKey_Leave(object sender, EventArgs e)
        {
            CMYKUpdate(3);
            CMYKChange();
        }

        private void TextBoxKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                CMYKUpdate(3);
                CMYKChange();
            }
        }
    }
}
