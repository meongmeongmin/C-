using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = Convert.ToString(num1NumericUpDown.Value + num2NumericUpDown.Value);
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = Convert.ToString(num1NumericUpDown.Value - num2NumericUpDown.Value);
        }

        private void mulButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = Convert.ToString(num1NumericUpDown.Value * num2NumericUpDown.Value);
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            if (num1NumericUpDown.Value <= 0 || num2NumericUpDown.Value <= 0)
                return;

            resultTextBox.Text = Convert.ToString(num1NumericUpDown.Value / num2NumericUpDown.Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            num1NumericUpDown.Maximum = num2NumericUpDown.Maximum = Int32.MaxValue;
            num1NumericUpDown.Minimum = num2NumericUpDown.Minimum = Int32.MinValue;
        }
    }
}
