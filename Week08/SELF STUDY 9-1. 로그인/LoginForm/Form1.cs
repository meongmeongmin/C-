using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text == "" || passwordTextBox.Text == "")
                MessageBox.Show("아이디와 비밀번호를 입력하세요.");
            else if (idTextBox.Text == "hanbit" && passwordTextBox.Text == "css")
            {
                MessageBox.Show($"{idTextBox.Text}님 어서오세요~ 지금 창을 닫습니다.");
                Close();
            }
            else
            {
                idTextBox.Text = "";
                passwordTextBox.Text = ""; 
                MessageBox.Show("아이디와 비밀번호를 다시 확인하세요.");
            }
        }
    }
}
