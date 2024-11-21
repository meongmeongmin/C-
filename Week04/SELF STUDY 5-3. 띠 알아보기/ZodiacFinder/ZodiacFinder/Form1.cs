using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZodiacFinder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void zodiacFinderButton_Click(object sender, EventArgs e)
        {
            this.Text = "띠 알아보기";
            int year = Convert.ToInt32(zodiacTextBox.Text);
            string imageFile = "{주소}\\ZodiacFinder\\Images\\";

            switch (year % 12)
            {
                case 0: imageFile += "원숭이.png"; break;
                case 1: imageFile += "닭.png"; break;
                case 2: imageFile += "개.png"; break;
                case 3: imageFile += "돼지.png"; break;
                case 4: imageFile += "쥐.png"; break;
                case 5: imageFile += "소.png"; break;
                case 6: imageFile += "호랑이.png"; break;
                case 7: imageFile += "토끼.png"; break;
                case 8: imageFile += "용.png"; break;
                case 9: imageFile += "뱀.png"; break;
                case 10: imageFile += "말.png"; break;
                case 11: imageFile += "양.png"; break;
            }

            zodiacPictureBox.Image = Image.FromFile(imageFile);
            zodiacPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void zodiacTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void zodiacPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
