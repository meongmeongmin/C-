using Nakov.TurtleGraphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week02_BinaryTurtleGraphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitButton_Click(object sender, EventArgs e)
        {
            Turtle.Init();
            Turtle.MoveTo(0, 0);
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            int swidth = 800;
            int sheight = 800;

            Text = "거북이 쇼";
            ClientSize = new Size(sheight, swidth);

            Turtle.Delay = 10;

            Random random = new Random();
            int size = random.Next(50, 100);
            int[,] ary = new int[size, 6];

            for (int i = 0; i < size; i++)
            {
                ary[i, 0] = random.Next(-swidth / 2, swidth / 2);
                ary[i, 1] = random.Next(-sheight / 2, sheight / 2);
                ary[i, 2] = random.Next(1, 20);
                ary[i, 3] = random.Next(0, 256);
                ary[i, 4] = random.Next(0, 256);
                ary[i, 5] = random.Next(0, 256);
            }

            for (int i = 0; i < size; i++)
            {
                Turtle.PenSize = ary[i, 2];
                Turtle.PenColor = Color.FromArgb(ary[i, 3], ary[i, 4], ary[i, 5]);
                Turtle.PenUp();
                Turtle.MoveTo(0, 0);
                Turtle.PenDown();
                Turtle.MoveTo(ary[i, 0], ary[i, 1]);

                int angle = (int)(Math.Atan2(ary[i, 0], ary[i, 1]) * 180 / Math.PI);
                Turtle.RotateTo(angle - 90);
                for (int k = 0; k < 9; k++)
                {
                    Turtle.Forward(ary[i, 2]);
                    Turtle.Rotate(40);
                }
            }
        }
    }
}
