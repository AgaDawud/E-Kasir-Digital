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
    public partial class TambahBarang : Form
    {
        private string connect = "Server=localhost; Database=db_kasir; Trusted_Connection=True;";
        public TambahBarang()
        {
            InitializeComponent();
        }

        private void TambahBarang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nama_brg = n_brg.Text;
            int harga_brg;
            if(!int.TryParse(h_brg.Text, out harga_brg))
            {
                MessageBox.Show("Harus Input berupa angka!");
                return;
            }
            string k_brg = kode_brg.Text;
            if (!string.IsNullOrEmpty(nama_brg) && harga_brg > 0 && !string.IsNullOrEmpty(k_brg))
            {
                Input(nama_brg, harga_brg, k_brg);
                n_brg.Clear();
                h_brg.Clear();
                kode_brg.Clear();

            }
            else
            {
                MessageBox.Show("Inputkan terlebih dahulu");
            }
        }

        private void Input(string nama_brg, int h_brg, string kode_brg)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string insert = "INSERT INTO tbl_barang (nama_barang, kode_barang, harga_barang) VALUES (@nama_brg, @kode_brg, @h_brg)";

                using (SqlCommand cmd = new SqlCommand(insert, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@nama_brg", nama_brg);
                    cmd.Parameters.AddWithValue("@h_brg", h_brg);
                    cmd.Parameters.AddWithValue("@kode_brg", kode_brg);
                    cmd.ExecuteNonQuery();
                }
                        
            }
            LoadData();
        }

        private void LoadData()
        {
            using(SqlConnection conn = new SqlConnection(connect))
            {
                string query = "select * from tbl_barang";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                kode_brg.Text = row.Cells["kode_barang"].Value.ToString();
                n_brg.Text = row.Cells["nama_barang"].Value.ToString();
                h_brg.Text = row.Cells["harga_barang"].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete from tbl_barang where nama_barang = @nama_brg", conn);
                cmd.Parameters.AddWithValue("@nama_brg", n_brg.Text);
                cmd.ExecuteNonQuery();
            }
            LoadData();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
