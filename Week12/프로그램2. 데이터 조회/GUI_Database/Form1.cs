using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Database
{
    public partial class Form1 : Form
    {
        string _connStr;
        SqlConnection _conn;
        SqlCommand _cmd;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _connStr = "연결 문자열";    // 연결 문자열을 만들거나 복사해서 직접 붙여넣을 것.
            _conn = new SqlConnection(_connStr);
            _conn.Open();

            _cmd = new SqlCommand();
            _cmd.Connection = _conn;

            resultListView.View = View.Details;
            resultListView.GridLines = true;
            int listWidth = resultListView.Width;
            resultListView.Columns.Add("아이디", (int)(listWidth * 0.2));
            resultListView.Columns.Add("이름", (int)(listWidth * 0.3));
            resultListView.Columns.Add("이메일", (int)(listWidth * 0.3));
            resultListView.Columns.Add("출생연도", (int)(listWidth * 0.2));

        }
        
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            _conn.Close();
            MessageBox.Show("DB 연결을 종료합니다~");
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            string sql = $"insert into userTable values('{idTextBox.Text}', '{nameTextBox.Text}', '{emailTextBox.Text}', '{birthYearTextBox.Text}')";
            _cmd.CommandText = sql;
            _cmd.ExecuteNonQuery();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            _cmd.CommandText = "select * from userTable";
            SqlDataReader reader = _cmd.ExecuteReader();

            resultListView.Items.Clear();
            ListViewItem item;
            while (reader.Read())
            {
                item = new ListViewItem(reader.GetString(0));   // 아이디
                item.SubItems.Add(reader.GetString(1)); // 이름
                item.SubItems.Add(reader.GetString(2)); // 이메일
                item.SubItems.Add(reader.GetInt32(3).ToString());  // 출생연도

                resultListView.Items.Add(item);
            }

            reader.Close();
        }
    }
}
