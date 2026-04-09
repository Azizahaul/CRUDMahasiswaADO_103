using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRUDMahasiswaADO
{
    public partial class Form1 : Form
    {
        private readonly SqlConnection conn;
        private readonly string connectionString =
            "Data Source=LAPTOP-RB8DQ53H\\ZIZEE;Initial Catalog=DBAkademikADO;Integrated Security=True";
        public Form1()

        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }
      
        

        private void ConnectDataBase()
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                MessageBox.Show("Koneksi berhasil");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi gagal: " + ex.Message);
            }

        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            ConnectDataBase();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dtpTanggalLahir_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
