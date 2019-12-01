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

namespace last_suicide
{
    public partial class Registration : Form
    {
        public Registration()
        {

            InitializeComponent();
        }

        private void buttOK_Click(object sender, EventArgs e)
        {
            if (textB1.Text.Length == 0 || textB2.Text.Length == 0 || textB3.Text.Length == 0 || textB4.Text.Length == 0)
            {
                MessageBox.Show("Заполните все строки");
                return;
            }
            if (lblPassWarn.Visible == true) return;
            try
            {
                using (SqlConnection sqlc = new SqlConnection(UserInfo.connStr))
                {
                    sqlc.Open();
                    try
                    {
                        using (var comm= new SqlCommand($@"INSERT into users VALUES ('{textB1.Text}','{textB2.Text}',
                        '{textB3.Text}','{textB4.Text}')", sqlc))
                        {
                            comm.ExecuteNonQuery();
                            MessageBox.Show("Все от души");
                            UserInfo.Login = textB3.Text;
                            UserInfo.Password = textB4.Text;
                            this.Close();
                        }
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Введены неверные данные");
                    }
                }
            }
            catch(SqlException)
            {
                MessageBox.Show("Не удалось подключиться к базе данных");
            }
        }

        private void textB4_TextChanged(object sender, EventArgs e)
        {
            lblPassWarn.Visible = textB4.Text.Length > 15 ? true : false;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
