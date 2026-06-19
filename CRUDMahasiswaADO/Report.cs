using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRUDMahasiswaADO
{
    public partial class Report : Form
    {
        DAL dbLogic = new DAL();
        // 1. Pastikan connectionString sama persis dengan yang ada di RekapMahasiswa.cs
        // Menggunakan User ID dan Password yang sudah terbukti berhasil
        static string connectionString = "Data Source=LAPTOP-RB8DQ53H\\ZIZEE;Initial Catalog=DBAkademikADO;User ID=sa;Password=AZi700306";

        SqlConnection conn = new SqlConnection(connectionString);
        SqlDataAdapter da;
        DataTable dtMahasiswa;

        // 2. Deklarasikan file Crystal Report (.rpt) Anda
        CrystalReport3 listMahasiswa = new CrystalReport3();

        string prodi { get; set; }
        DateTime tglmasuk { get; set; }

        public Report(string Prodi, DateTime TglMasuk)
        {
            InitializeComponent();

            prodi = Prodi;
            tglmasuk = TglMasuk;

            try
            {
                DataTable dtMahasiswa = dbLogic.getDataRekap(prodi, tglmasuk);

                listMahasiswa.SetDataSource(dtMahasiswa);
                crystalReportViewer1.ReportSource = listMahasiswa;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                //simpanLog(ex.Message);
                MessageBox.Show("Gagal load data: " + ex.Message);
            }
        }
    }
}