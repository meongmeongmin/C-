using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageBrightnessAdjuster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox.Image);
            int R, G, B;
            Color color;

            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    color = bmp.GetPixel(j, i);
                    R = color.R + trackBar.Value;
                    G = color.G + trackBar.Value;
                    B = color.B + trackBar.Value;

                    if (R > 255)
                        R = 255;
                    else if (R < 0)
                        R = 0;

                    if (G > 255)
                        G = 255;
                    else if (G < 0)
                        G = 0;

                    if (B > 255)
                        B = 255;
                    else if (B < 0)
                        B = 0;

                    color = Color.FromArgb(R, G, B);
                    bmp.SetPixel(j, i, color);
                }
            }

            pictureBox.Image = bmp;
        }
    }
}