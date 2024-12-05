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

namespace OO_Turtle
{
    public partial class Form1 : Form
    {
        int startX;
        int startY;
        int endX; 
        int endY;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            startX = e.X; 
            startY = e.Y;
            startX -= ClientSize.Width / 2;
            startY = ClientSize.Height / 2 - startY;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void initButton_Click(object sender, EventArgs e)
        {
            Turtle.Reset();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            endX = e.X;
            endY = e.Y;
            endX -= ClientSize.Width / 2;
            endY = ClientSize.Height / 2 - endY;

            if (lineRadioButton.Checked)
            {
                Line line1 = new Line(startX, startY, endX, endY);
                line1.DrawLine();
            }
            else
            {
                Rectangle rect1 = new Rectangle(startX, startY, endX, endY);
                rect1.DrawLine();
            }
        }
    }

    abstract class Figure
    {
        public int X1;
        public int Y1;
        public int X2;
        public int Y2;

        abstract public void DrawLine();
    }

    class Line : Figure
    {
        public Line(int x1, int y1, int x2, int y2)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }

        public override void DrawLine()
        {
            Turtle.PenUp();
            Turtle.MoveTo(X1, Y1);

            Turtle.PenColor = Color.Red;
            Turtle.PenDown();
            Turtle.MoveTo(X2, Y2);
        }
    }

    class Rectangle : Figure
    {
        public Rectangle(int x1, int y1, int x2, int y2)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }

        public override void DrawLine()
        {
            Turtle.PenUp();
            Turtle.MoveTo(X1, Y1);

            Turtle.PenColor = Color.Green;
            Turtle.PenDown();
            Turtle.MoveTo(X1, Y2);
            Turtle.MoveTo(X2, Y2);
            Turtle.MoveTo(X2, Y1);
            Turtle.MoveTo(X1, Y1);
        }
    }
}
