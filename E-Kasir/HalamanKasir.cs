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
    public partial class HalamanKasir : Form
    {
        private string connect = "Server=localhost; Database=db_kasir; Trusted_Connection=True;";
        private int Subtotal_1 = 0;
        private int Diskon_1 = 0;
        private int Pajak_1 = 0;
        private int Total_1 = 0;
        public HalamanKasir()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void Diskon_b_1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Pajak_b_1_TextChanged(object sender, EventArgs e)
        {
        }

        private void InitializeDataGridView()
        {
            dataGridView1.Columns.Add("kode", "Kode");
            dataGridView1.Columns.Add("nama_brg", "Nama Barang");
            dataGridView1.Columns.Add("h_brg", "Harga Barang");
            dataGridView1.Columns.Add("jml", "Jumlah");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TambahBarang tbrg = new TambahBarang();
            tbrg.Show();
        }

        private void HalamanKasir_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kode = kode_b.Text;
            int jml;
            if (!int.TryParse(jml_b.Text, out jml))
            {
                MessageBox.Show("Harus input berupa angka!");
                return;
            }
            int pajak;
            if (!int.TryParse(pajak_b.Text, out pajak))
            {
                MessageBox.Show("Harus input berupa angka!");
                return;
            }
            int diskon;
            if (!int.TryParse(diskon_b.Text, out diskon))
            {
                MessageBox.Show("Harus input berupa angka!");
            }

            if (!string.IsNullOrEmpty(kode) && jml > 0 && pajak >= 0 && diskon >= 0)
            {
                using (SqlConnection conn = new SqlConnection(connect))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select * from tbl_barang where kode_barang = @kode_barang", conn);
                    cmd.Parameters.AddWithValue("@kode_barang", kode);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string nama_brg = reader["nama_barang"].ToString();
                        int h_brg = Convert.ToInt32(reader["harga_barang"]);

                        int subtotal = h_brg * jml;
                        int total = subtotal + pajak - diskon;

                        dataGridView1.Rows.Add(kode, nama_brg, h_brg, jml);

                        Subtotal_1 += subtotal;
                        Diskon_1 += diskon;
                        Pajak_1 += pajak;
                        Total_1 = Subtotal_1 + Pajak_1 - Diskon_1;
                        
                        Subtotal_b.Text = Subtotal_1.ToString("N2");
                        Diskon_b_1.Text = Diskon_1.ToString("N2");
                        Pajak_b_1.Text = Pajak_1.ToString("N2");
                        Total_b_1.Text = Total_1.ToString("N2");

                        kode_b.Clear();
                        jml_b.Clear();
                        diskon_b.Clear();
                        pajak_b.Clear();
                    }
                    else
                    {
                        MessageBox.Show("data tidak ada");
                    }
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                string query = "select * from tbl_barang";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete from tbl_barang where kode_barang = @kode_brg", conn);
                cmd.Parameters.AddWithValue("@kode_brg", kode_b.Text);
                cmd.ExecuteNonQuery();
            }
            LoadData();
        }

        private void Subtotal_b_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
