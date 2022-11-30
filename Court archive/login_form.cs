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

namespace Court_archive
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string login = login_field.Text;
            string password = password_field.Text;
            if (login.Length>0 && password.Length > 0)
            {
                Connect.connect();

                SqlCommand cmd = new SqlCommand("SELECT * FROM workers WHERE user_login='" + login + "'", Connect.connect());
                SqlDataReader reader = cmd.ExecuteReader();
                
                if (reader.HasRows)
                {
                    password.Trim();
                    while (reader.Read()) {
                        if (reader.GetValue(1).ToString() == login && reader.GetValue(2).ToString() == password)
                        {
                            Connect.user_id = reader;
                            main_form mainform = new main_form();
                            mainform.Show();
                            this.Hide();
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Такого пользователя нет", "Сообщение", MessageBoxButtons.OK);
                }
            }
             else if (login.Length==0||password.Length==0||(login.Length == 0 && password.Length == 0))
             {
                MessageBox.Show("Не заполнены все поля", "Ошибка", MessageBoxButtons.OK);
             }   
            
        }
        public void TimeIvent()
        {

        }
    }
}
