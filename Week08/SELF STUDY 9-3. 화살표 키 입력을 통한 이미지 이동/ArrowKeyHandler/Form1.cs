using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrowKeyHandler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Point point;

            switch (e.KeyCode)
            {
                case Keys.Up:
                    point = new Point(pictureBox.Location.X, pictureBox.Location.Y - 10);
                    break;
                case Keys.Down:
                    point = new Point(pictureBox.Location.X, pictureBox.Location.Y + 10);
                    break;
                case Keys.Left:
                    point = new Point(pictureBox.Location.X - 10, pictureBox.Location.Y);
                    break;
                case Keys.Right:
                    point = new Point(pictureBox.Location.X + 10, pictureBox.Location.Y);
                    break;
                default:
                    return;
            }

            pictureBox.Location = point;
        }
    }
}
