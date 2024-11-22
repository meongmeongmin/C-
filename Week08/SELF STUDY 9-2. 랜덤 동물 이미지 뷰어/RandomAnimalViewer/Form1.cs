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

namespace RandomAnimalViewer
{
    public partial class Form1 : Form
    {
        List<string> _hollowKnight;

        public Form1()
        {
            InitializeComponent();
        }

        private void drawRandomAnimalButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int idx = random.Next(0, _hollowKnight.Count);

            string basePath = Path.Combine(Environment.CurrentDirectory, "Images");
            string imageFile = Path.Combine(basePath, $"{_hollowKnight[idx]}.png");
            animalPictureBox.Image = Image.FromFile(imageFile);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            animalPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            _hollowKnight = new List<string>()
            {
                "Knight",
                "Hornet",
                "Quirrel",
            };
        }
    }
}
