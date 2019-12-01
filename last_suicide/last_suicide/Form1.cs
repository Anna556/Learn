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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UserInfo.connStr = @"Data Source=DESKTOP-VN4DGP6\SQLEXPRESS;Initial Catalog = student; Integrated Security = True";
            using (var sqlAd = new SqlDataAdapter("SELECT * FROM Users", UserInfo.connStr))
            {
                var dt = new DataTable();
                sqlAd.Fill(dt);
                BindingSource bs = new BindingSource();
                bs.DataSource = dt;
                dataGV.DataSource = bs;
            }
        }

        private void buttOK_Click(object sender, EventArgs e)
        {
            this.OpenForm(new Registration());
            if (UserInfo.Login != null || UserInfo.Password != null) logIn(UserInfo.Login, UserInfo.Password);
        }

        private void buttLog_Click(object sender, EventArgs e)
        {
            logIn(tbLog.Text, tbPass.Text);
        }

        private void logIn(string login, string pass)
        {
            if (login.Length == 0 || pass.Length == 0)
            {
                MessageBox.Show("Заполните все поля для входа");
                return;
            }
            try
            {
                using (SqlConnection sqlc = new SqlConnection(UserInfo.connStr))
                {
                    sqlc.Open();
                    try
                    {
                        using (var comm = new SqlCommand($@"SELECT Login, Password FROM Users WHERE Login = '{login}' 
                           AND Password = '{pass}'", sqlc))
                        {
                            comm.ExecuteNonQuery();
                            MessageBox.Show("Вы вошли");

                            UserInfo.Login = login;
                            UserInfo.Password = pass;

                            if (UserInfo.Login == "Anna") MessageBox.Show("Как бог");
                        }

                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Пользователя не существует");
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Не удалось подключиться к БД");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
