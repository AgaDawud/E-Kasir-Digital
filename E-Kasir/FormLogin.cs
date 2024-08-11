using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kasir_D_COMP
{
    public partial class FormLogin : Form
    {
        private string connect = "Server=localhost; Database=db_kasir; Trusted_Connection=True;";
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = username.Text;
            string pass = password.Text;

            if(!string.IsNullOrEmpty(user) && !string.IsNullOrEmpty(pass)){
                Login(user, pass);
            } else {
                MessageBox.Show("Masukkan Password dan Username");
            }

        }

        private void Login(string user, string pass)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string query = "select count(1) from tbl_users where username = @username AND password = @password";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", user);
                    cmd.Parameters.AddWithValue("@password", pass);

                    try
                    {
                        conn.Open();
                        int benar = Convert.ToInt32(cmd.ExecuteScalar());

                        if (benar == 1)
                        {
                            HalamanKasir kasir = new HalamanKasir();
                            kasir.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Username atau password salah");
                            this.Close();
                        }
                    } catch (Exception ex)
                    {
                        MessageBox.Show("err: " + ex.Message)
;                    }
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
