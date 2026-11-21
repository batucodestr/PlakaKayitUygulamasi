using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace PlakaKayıtUygulamasi
{
    public partial class Form1 : Form
    {
        private readonly SqlConnection baglanti = new SqlConnection(
    @"Data Source=(LocalDB)\MSSQLLocalDB;
    AttachDbFilename=C:\Users\Batu\source\repos\PlakaKayıtUygulamasi\PlakaKayıtUygulamasi\Database1.mdf;
    Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            try
            {
                using SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT * FROM Sehirler", baglanti);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvSehirler.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Veritabanı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSehir.Text))
            {
                MessageBox.Show("Şehir adı boş bırakılamaz!",
                    "Geçersiz Giriş",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtPlaka.Text, out int plaka) || plaka <= 0 || string.IsNullOrWhiteSpace(txtPlaka.Text))
            {
                MessageBox.Show("Lütfen 1 ile 81 arasında geçerli bir plaka kodu giriniz!",
                "Geçersiz Giriş",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }

            try
            {
                baglanti.Open();

                SqlCommand query = new SqlCommand(
                    "INSERT INTO Sehirler (Sehir, Plaka) VALUES (@Sehir, @Plaka)", baglanti);

                query.Parameters.AddWithValue("@Sehir", txtSehir.Text);
                query.Parameters.AddWithValue("@Plaka", txtPlaka.Text);

                MessageBox.Show("Kayıt başarıyla eklendi!",
                    "Başarılı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                query.ExecuteNonQuery();
                baglanti.Close();

                txtSehir.Clear();
                txtPlaka.Clear();

                btnListele.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Veritabanı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPlaka.Text, out int plaka) || plaka <= 0 || string.IsNullOrWhiteSpace(txtPlaka.Text))
            {
                MessageBox.Show("Lütfen 1 ile 81 arasında geçerli bir plaka kodu giriniz!",
                "Geçersiz Giriş",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }

            try
            {
                baglanti.Open();
                SqlCommand query = new SqlCommand(
                    "DELETE FROM Sehirler WHERE Plaka = @Plaka", baglanti);
                query.Parameters.AddWithValue("@Plaka", txtPlaka.Text);
                int rowsAffected = query.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Kayıt başarıyla silindi!",
                        "Başarılı",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Silinecek kayıt bulunamadı!",
                        "Bilgi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                baglanti.Close();
                txtSehir.Clear();
                txtPlaka.Clear();
                btnListele.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Veritabanı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSehir.Text))
            {
                MessageBox.Show("Lütfen güncellenecek şehir adını giriniz!",
                                "Eksik Bilgi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtPlaka.Text, out int plaka) || plaka < 1 || plaka > 81)
            {
                MessageBox.Show("Lütfen 1 ile 81 arasında geçerli bir plaka kodu giriniz!",
                                "Geçersiz Plaka",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            try
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand(
                    "UPDATE Sehirler SET Sehir = @Sehir WHERE Plaka = @Plaka",
                    baglanti);

                komut.Parameters.AddWithValue("@Sehir", txtSehir.Text);
                komut.Parameters.AddWithValue("@Plaka", plaka);

                int sonuc = komut.ExecuteNonQuery();

                if (sonuc > 0)
                {
                    MessageBox.Show("Şehir kaydı başarıyla güncellendi!",
                                    "Başarılı",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Girilen plakaya ait kayıt bulunamadı!",
                                    "Kayıt Bulunamadı",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }

                btnListele.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Güncelleme Hatası");
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnListele.PerformClick();
        }
    }
}
