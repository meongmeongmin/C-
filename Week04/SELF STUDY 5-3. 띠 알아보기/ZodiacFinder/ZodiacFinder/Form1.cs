using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            Text = "띠 알아보기";
            int year = Convert.ToInt32(zodiacTextBox.Text);
            
            string basePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");    // 상대 경로
            string imageFile = "";

            switch (year % 12)
            {
                case 0: imageFile = Path.Combine(basePath, "원숭이.png"); break;
                case 1: imageFile = Path.Combine(basePath, "닭.png"); break;
                case 2: imageFile = Path.Combine(basePath, "개.png"); break;
                case 3: imageFile = Path.Combine(basePath, "돼지.png"); break;
                case 4: imageFile = Path.Combine(basePath, "쥐.png"); break;
                case 5: imageFile = Path.Combine(basePath, "소.png"); break;
                case 6: imageFile = Path.Combine(basePath, "호랑이.png"); break;
                case 7: imageFile = Path.Combine(basePath, "토끼.png"); break;
                case 8: imageFile = Path.Combine(basePath, "용.png"); break;
                case 9: imageFile = Path.Combine(basePath, "뱀.png"); break;
                case 10: imageFile = Path.Combine(basePath, "말.png"); break;
                case 11: imageFile = Path.Combine(basePath, "양.png"); break;
            }
            
            zodiacPictureBox.Image = Image.FromFile(imageFile);
            zodiacPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
