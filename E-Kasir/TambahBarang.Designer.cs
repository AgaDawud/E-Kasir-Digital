namespace Kasir_D_COMP
{
    partial class TambahBarang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TambahBarang));
            this.h_brg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.n_brg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kode_brg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.delete = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // h_brg
            // 
            this.h_brg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.h_brg.Location = new System.Drawing.Point(226, 130);
            this.h_brg.Margin = new System.Windows.Forms.Padding(5);
            this.h_brg.Multiline = true;
            this.h_brg.Name = "h_brg";
            this.h_brg.Size = new System.Drawing.Size(227, 30);
            this.h_brg.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(222, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Harga Barang";
            // 
            // n_brg
            // 
            this.n_brg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.n_brg.Location = new System.Drawing.Point(226, 57);
            this.n_brg.Margin = new System.Windows.Forms.Padding(5);
            this.n_brg.Multiline = true;
            this.n_brg.Name = "n_brg";
            this.n_brg.Size = new System.Drawing.Size(227, 30);
            this.n_brg.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(222, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nama Barang";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // kode_brg
            // 
            this.kode_brg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.kode_brg.Location = new System.Drawing.Point(228, 205);
            this.kode_brg.Margin = new System.Windows.Forms.Padding(5);
            this.kode_brg.Multiline = true;
            this.kode_brg.Name = "kode_brg";
            this.kode_brg.Size = new System.Drawing.Size(225, 30);
            this.kode_brg.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(224, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Kode Barang";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(33, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 35);
            this.button1.TabIndex = 34;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button5.Location = new System.Drawing.Point(33, 343);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(398, 35);
            this.button5.TabIndex = 36;
            this.button5.Text = "Kembali";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(475, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(385, 366);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Red;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.delete.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.delete.Location = new System.Drawing.Point(240, 302);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(191, 35);
            this.delete.TabIndex = 38;
            this.delete.Text = "Hapus";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 250);
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // TambahBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 398);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kode_brg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.h_brg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.n_brg);
            this.Controls.Add(this.label2);
            this.Name = "TambahBarang";
            this.Text = "E-Kasir ( Tambah Barang )";
            this.Load += new System.EventHandler(this.TambahBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox h_brg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox n_brg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kode_brg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}