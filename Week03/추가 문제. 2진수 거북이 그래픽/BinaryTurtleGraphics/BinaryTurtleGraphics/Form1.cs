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

namespace BinaryTurtleGraphics
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
            if (InputBox.Text == "")
                return;

            string numStr = Convert.ToString(Convert.ToInt32(InputBox.Text), 2);
            Turtle.Delay = 100;

            for (int i = 0; i < numStr.Length; i++)
            {
                Turtle.PenUp();
                Turtle.MoveTo(Turtle.X + 20, 0);
                Turtle.PenDown();

                if (numStr[i] == '1')
                {
                    Turtle.PenSize = 10;
                    Turtle.PenColor = Color.Red;
                    Turtle.Forward(80);
                }
                else
                {
                    Turtle.PenSize = 5;
                    Turtle.PenColor = Color.Blue;
                    Turtle.Forward(40);
                }
            }
        }

        private void InputBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
