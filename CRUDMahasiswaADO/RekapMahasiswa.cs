using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

// KUNCI UTAMA: Namespace harus sama persis dengan nama project Anda yaitu CRUDMahasiswaADO
namespace CRUDMahasiswaADO
{
    public partial class RekapMahasiswa : Form
    {
        DAL dbLogic = new DAL();
        // 1. Deklarasi koneksi database (Sesuaikan Data Source dengan nama server SQL Server Anda)
        static string connectionString = "Data Source=LAPTOP-RB8DQ53H\\ZIZEE;Initial Catalog=DBAkademikADO;User ID=sa;Password=AZi700306";

        SqlConnection conn = new SqlConnection(connectionString);
        SqlDataAdapter da;
        DataTable dtMahasiswa;
        DataTable dtProdi;

        public RekapMahasiswa()
        {
            InitializeComponent();
            LoadDataProdi();
        }

        // METHOD BARU KHUSUS UNTUK LOAD PRODI
        private void LoadDataProdi()
        {
            // Atur format DateTimePicker agar hanya menampilkan format Tahun (yyyy)
            dtpTanggalMasuk.Format = DateTimePickerFormat.Custom;
            dtpTanggalMasuk.CustomFormat = "yyyy";
            dtpTanggalMasuk.ShowUpDown = true;
            dtpTanggalMasuk.MinDate = new DateTime(2000, 1, 1);
            dtpTanggalMasuk.MaxDate = DateTime.Now;

            cmbProdi.DropDownStyle = ComboBoxStyle.DropDownList;
            btnCetak.Enabled = false;

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                // Load program studi untuk dimasukkan ke ComboBox
                SqlCommand cmd = new SqlCommand("SELECT namaprodi FROM programstudi", conn);
                cmd.CommandType = CommandType.Text;

                dtProdi = new DataTable();
                da = new SqlDataAdapter(cmd);
                da.Fill(dtProdi);

                // Pastikan hasil query ada isinya sebelum dimasukkan ke ComboBox
                if (dtProdi.Rows.Count > 0)
                {
                    cmbProdi.DataSource = dtProdi;
                    cmbProdi.DisplayMember = "namaprodi";
                    cmbProdi.ValueMember = "namaprodi";
                }
                else
                {
                    MessageBox.Show("Tabel programstudi di database kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load data prodi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Tutup koneksi setelah mengambil data prodi
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        // 2. Event saat Form di-Load pertama kali (Biarkan kosong karena sudah dipindah ke LoadDataProdi)
        private void RekapMahasiswa_Load(object sender, EventArgs e)
        {

        }

        // 3. Event ketika tombol "Load" diklik (Event lama yang kosong)
        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        // 4. Event ketika tombol "Cetak" diklik
        private void btnCetak_Click(object sender, EventArgs e)
        {
            // Membuka Form Cetak / Report (Form2) dengan mengirimkan parameter Prodi dan Tahun
            Report frm2 = new Report(cmbProdi.SelectedValue.ToString(), dtpTanggalMasuk.Value);
            frm2.Show();
            this.Hide(); // Menyembunyikan form pencarian saat laporan dibuka
        }

        private void RekapMahasiswa_Load_1(object sender, EventArgs e)
        {

        }

        // 5. EVENT LOAD UTAMA (Yang dieksekusi saat tombol Load ditekan)
        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            // VALIDASI: Cegah eksekusi jika combobox Prodi masih kosong atau belum dipilih
            if (cmbProdi.SelectedValue == null || string.IsNullOrWhiteSpace(cmbProdi.Text))
            {
                MessageBox.Show("Silakan pilih Program Studi (Prodi) terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Hentikan proses eksekusi kode di bawahnya
            }

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                // Eksekusi Stored Procedure sp_Report
                SqlCommand cmd = new SqlCommand("sp_Report", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                // PERBAIKAN: Tambahkan parameter dan pastikan SelectedValue dikonversi ke String
                cmd.Parameters.Add("@inProdi", SqlDbType.VarChar, 50).Value = cmbProdi.SelectedValue.ToString();
                cmd.Parameters.Add("@inTglMsuk", SqlDbType.VarChar, 4).Value = dtpTanggalMasuk.Value.Year.ToString();

                da = new SqlDataAdapter(cmd);
                dtMahasiswa = new DataTable();
                da.Fill(dtMahasiswa);

                // Tampilkan hasil pencarian ke DataGridView
                dataGridView1.DataSource = dtMahasiswa;

                // Validasi tombol Cetak
                if (dtMahasiswa.Rows.Count > 0)
                {
                    btnCetak.Enabled = true;
                }
                else
                {
                    btnCetak.Enabled = false;
                    MessageBox.Show("Data tidak ditemukan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load data mahasiswa: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Tutup koneksi agar tidak memberatkan memori
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCetak_Click_1(object sender, EventArgs e)
        {
            // Membuka Form Cetak / Report (Form2) dengan mengirimkan parameter Prodi dan Tahun
            Report frm2 = new Report(cmbProdi.SelectedValue.ToString(), dtpTanggalMasuk.Value);
            frm2.Show();
            this.Hide(); // Menyembunyikan form pencarian saat laporan dibuka
        }
    }
}