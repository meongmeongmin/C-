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

namespace TurtleGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            int swidth = 600;
            int sheight = 600;
            Text = "거북이 로또 추첨";
            ClientSize = new Size(swidth, sheight);
            Turtle.Delay = 50;

            int[] lotto = new int[6];
            GetLotto(lotto);
            Array.Sort(lotto, 0, 6);

            string lottoText = "";
            foreach (var n in lotto)
                lottoText += n.ToString() + " ";
            
            inputTextBox.Text = lottoText;

            Turtle.PenSize = 5;
            for (int i = 0; i < 45; i++)
            {
                Turtle.PenColor = Color.Gray;
                Turtle.PenUp();
                Turtle.MoveTo(0, 0);
                Turtle.PenDown();
                Turtle.RotateTo(i * 8);
                Turtle.Forward(150);
            }

            Turtle.PenSize = 10;
            for (int i = 0; i < lotto.Length; i++)
            {
                int R = _random.Next(0, 256);
                int G = _random.Next(0, 256);
                int B = _random.Next(0, 256);

                Turtle.PenColor = Color.FromArgb(R, G, B);
                Turtle.PenUp();
                Turtle.MoveTo(0, 0);
                Turtle.PenDown();
                Turtle.RotateTo(lotto[i] * 8);
                Turtle.Forward(170);
            }
        }

        private void initButton_Click(object sender, EventArgs e)
        {
            Turtle.Init();
        }

        static bool IsNumInArray(int[] ary, int num)
        {
            bool dupYN = false;

            for (int i = 0; i < ary.Length; i++)
            {
                if (ary[i] == num)
                    dupYN = true;
            }

            return dupYN;
        }

        static Random _random = new Random();
        static void GetLotto(int[] ary)
        {
            int idx = 0;
            int pickNum;

            while (true)
            {
                pickNum = _random.Next(1, 45);
                if (IsNumInArray(ary, pickNum))
                    continue;
                
                ary[idx] = pickNum;
                
                if (idx >= 5)
                    break;
                
                idx++;
            }
        }
    }
}
