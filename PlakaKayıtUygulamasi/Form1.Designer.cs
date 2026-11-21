namespace PlakaKayıtUygulamasi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtPlaka = new TextBox();
            txtSehir = new TextBox();
            btnEkle = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnListele = new Button();
            label3 = new Label();
            dgvSehirler = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSehirler).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(23, 23);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 0;
            label1.Text = "Plaka:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(23, 102);
            label2.Name = "label2";
            label2.Size = new Size(54, 21);
            label2.TabIndex = 1;
            label2.Text = "Şehir:";
            // 
            // txtPlaka
            // 
            txtPlaka.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtPlaka.Location = new Point(25, 47);
            txtPlaka.Multiline = true;
            txtPlaka.Name = "txtPlaka";
            txtPlaka.PlaceholderText = "34";
            txtPlaka.Size = new Size(342, 39);
            txtPlaka.TabIndex = 2;
            // 
            // txtSehir
            // 
            txtSehir.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtSehir.Location = new Point(25, 126);
            txtSehir.Multiline = true;
            txtSehir.Name = "txtSehir";
            txtSehir.PlaceholderText = "İstanbul";
            txtSehir.Size = new Size(342, 39);
            txtSehir.TabIndex = 3;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.Lime;
            btnEkle.FlatAppearance.BorderSize = 0;
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnEkle.Location = new Point(25, 189);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(123, 43);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Red;
            btnSil.FlatAppearance.BorderSize = 0;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSil.Location = new Point(154, 189);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(123, 43);
            btnSil.TabIndex = 5;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.FromArgb(128, 128, 255);
            btnGuncelle.FlatAppearance.BorderSize = 0;
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGuncelle.Location = new Point(25, 238);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(123, 43);
            btnGuncelle.TabIndex = 6;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnListele
            // 
            btnListele.BackColor = Color.Silver;
            btnListele.FlatAppearance.BorderSize = 0;
            btnListele.FlatStyle = FlatStyle.Flat;
            btnListele.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnListele.Location = new Point(154, 238);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(123, 43);
            btnListele.TabIndex = 7;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = false;
            btnListele.Click += btnListele_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(25, 293);
            label3.Name = "label3";
            label3.Size = new Size(74, 21);
            label3.TabIndex = 8;
            label3.Text = "Kayıtlar:";
            // 
            // dgvSehirler
            // 
            dgvSehirler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSehirler.Location = new Point(25, 322);
            dgvSehirler.Name = "dgvSehirler";
            dgvSehirler.Size = new Size(342, 150);
            dgvSehirler.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 484);
            Controls.Add(dgvSehirler);
            Controls.Add(label3);
            Controls.Add(btnListele);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(txtSehir);
            Controls.Add(txtPlaka);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Plaka - Şehir Kayıt Uygulaması";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSehirler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPlaka;
        private TextBox txtSehir;
        private Button btnEkle;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnListele;
        private Label label3;
        private DataGridView dgvSehirler;
    }
}
