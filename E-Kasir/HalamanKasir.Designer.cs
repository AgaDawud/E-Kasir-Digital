namespace Kasir_D_COMP
{
    partial class HalamanKasir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HalamanKasir));
            this.label2 = new System.Windows.Forms.Label();
            this.kode_b = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jml_b = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.diskon_b = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pajak_b = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Subtotal_b = new System.Windows.Forms.TextBox();
            this.Diskon_b_1 = new System.Windows.Forms.TextBox();
            this.Total_b_1 = new System.Windows.Forms.TextBox();
            this.Pajak_b_1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(308, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kode ";
            // 
            // kode_b
            // 
            this.kode_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.kode_b.Location = new System.Drawing.Point(308, 38);
            this.kode_b.Margin = new System.Windows.Forms.Padding(5);
            this.kode_b.Multiline = true;
            this.kode_b.Name = "kode_b";
            this.kode_b.Size = new System.Drawing.Size(217, 30);
            this.kode_b.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(308, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Jumlah";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(19, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 35);
            this.button2.TabIndex = 10;
            this.button2.Text = "Tambah Barang";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(308, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(462, 168);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // jml_b
            // 
            this.jml_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.jml_b.Location = new System.Drawing.Point(308, 107);
            this.jml_b.Margin = new System.Windows.Forms.Padding(5);
            this.jml_b.Multiline = true;
            this.jml_b.Name = "jml_b";
            this.jml_b.Size = new System.Drawing.Size(217, 30);
            this.jml_b.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(158, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 35);
            this.button1.TabIndex = 32;
            this.button1.Text = "Input Kode";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button4.Location = new System.Drawing.Point(19, 329);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(272, 35);
            this.button4.TabIndex = 34;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // diskon_b
            // 
            this.diskon_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.diskon_b.Location = new System.Drawing.Point(535, 38);
            this.diskon_b.Margin = new System.Windows.Forms.Padding(5);
            this.diskon_b.Multiline = true;
            this.diskon_b.Name = "diskon_b";
            this.diskon_b.Size = new System.Drawing.Size(235, 30);
            this.diskon_b.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(535, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Diskon";
            // 
            // pajak_b
            // 
            this.pajak_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pajak_b.Location = new System.Drawing.Point(535, 107);
            this.pajak_b.Margin = new System.Windows.Forms.Padding(5);
            this.pajak_b.Multiline = true;
            this.pajak_b.Name = "pajak_b";
            this.pajak_b.Size = new System.Drawing.Size(235, 30);
            this.pajak_b.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(535, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Pajak";
            // 
            // Subtotal_b
            // 
            this.Subtotal_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Subtotal_b.Location = new System.Drawing.Point(378, 341);
            this.Subtotal_b.Margin = new System.Windows.Forms.Padding(5);
            this.Subtotal_b.Multiline = true;
            this.Subtotal_b.Name = "Subtotal_b";
            this.Subtotal_b.Size = new System.Drawing.Size(147, 30);
            this.Subtotal_b.TabIndex = 43;
            this.Subtotal_b.TextChanged += new System.EventHandler(this.Subtotal_b_TextChanged);
            // 
            // Diskon_b_1
            // 
            this.Diskon_b_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Diskon_b_1.Location = new System.Drawing.Point(623, 341);
            this.Diskon_b_1.Margin = new System.Windows.Forms.Padding(5);
            this.Diskon_b_1.Multiline = true;
            this.Diskon_b_1.Name = "Diskon_b_1";
            this.Diskon_b_1.Size = new System.Drawing.Size(147, 30);
            this.Diskon_b_1.TabIndex = 44;
            this.Diskon_b_1.TextChanged += new System.EventHandler(this.Diskon_b_1_TextChanged);
            // 
            // Total_b_1
            // 
            this.Total_b_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Total_b_1.Location = new System.Drawing.Point(378, 381);
            this.Total_b_1.Margin = new System.Windows.Forms.Padding(5);
            this.Total_b_1.Multiline = true;
            this.Total_b_1.Name = "Total_b_1";
            this.Total_b_1.Size = new System.Drawing.Size(147, 30);
            this.Total_b_1.TabIndex = 46;
            // 
            // Pajak_b_1
            // 
            this.Pajak_b_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Pajak_b_1.Location = new System.Drawing.Point(623, 381);
            this.Pajak_b_1.Margin = new System.Windows.Forms.Padding(5);
            this.Pajak_b_1.Multiline = true;
            this.Pajak_b_1.Name = "Pajak_b_1";
            this.Pajak_b_1.Size = new System.Drawing.Size(147, 30);
            this.Pajak_b_1.TabIndex = 45;
            this.Pajak_b_1.TextChanged += new System.EventHandler(this.Pajak_b_1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(304, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 47;
            this.label5.Text = "Subtotal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(557, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 49;
            this.label7.Text = "Diskon";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(567, 381);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 50;
            this.label8.Text = "Pajak";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(324, 381);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 51;
            this.label9.Text = "Total";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(56, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 250);
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            // 
            // HalamanKasir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 424);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Total_b_1);
            this.Controls.Add(this.Pajak_b_1);
            this.Controls.Add(this.Diskon_b_1);
            this.Controls.Add(this.Subtotal_b);
            this.Controls.Add(this.pajak_b);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.diskon_b);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.jml_b);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kode_b);
            this.Controls.Add(this.label2);
            this.Name = "HalamanKasir";
            this.Text = "E-Kasir ( Halaman Kasir )";
            this.Load += new System.EventHandler(this.HalamanKasir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kode_b;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox jml_b;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox diskon_b;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pajak_b;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Subtotal_b;
        private System.Windows.Forms.TextBox Diskon_b_1;
        private System.Windows.Forms.TextBox Total_b_1;
        private System.Windows.Forms.TextBox Pajak_b_1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}