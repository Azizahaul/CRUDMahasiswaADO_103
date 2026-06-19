using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net; // Wajib untuk GetLocalIPAddress

namespace CRUDMahasiswaADO
{
    internal class DAL
    {
        // 1. Fungsi untuk mendapatkan IP Address server secara otomatis
        public static string GetLocalIPAddress()
        {
            string localIP = string.Empty;
            try
            {
                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        localIP = ip.ToString();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting local IP address: " + ex.Message);
            }
            return localIP;
        }

        // 2. Fungsi untuk menghasilkan Connection String secara dinamis
        public static string GetConnectionString()
        {
            // Ganti "AZi700306" dengan password database kamu
            return "Data Source=LAPTOP-RB8DQ53H\\ZIZEE;Initial Catalog=DBAkademikADO;User ID=sa;Password=AZi700306";
        }

        // 3. Koneksi statis yang digunakan di seluruh aplikasi (panggil dengan DAL.conn)
        public static SqlConnection conn = new SqlConnection(GetConnectionString());

        SqlDataAdapter da;
        DataTable dtMahasiswa;
        DataTable dtProdi;

        public int CountMhs()
        {
            if (conn.State == ConnectionState.Closed) { conn.Open(); }
            SqlCommand cmd = new SqlCommand("sp_CountMahasiswa", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter outputParam = new SqlParameter("@pCount", SqlDbType.Int);
            outputParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(outputParam);
            cmd.ExecuteNonQuery();
            return Convert.ToInt32(outputParam.Value);
        }

        public DataTable GetMhs()
        {
            if (conn.State == ConnectionState.Closed) { conn.Open(); }
            SqlCommand cmd = new SqlCommand("sp_GetMahasiswa", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            dtMahasiswa = new DataTable();
            da.Fill(dtMahasiswa);
            return dtMahasiswa;
        }

        public void InsertMhs(string nim, string nama, string alamat, string jenisKelamin, DateTime tanggalLahir, string kodeProdi, byte[] foto)
        {
            if (conn.State == ConnectionState.Closed) { conn.Open(); }
            SqlTransaction trans = conn.BeginTransaction();
            try
            {
                SqlCommand command = new SqlCommand("sp_InsertMahasiswa", conn, trans);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("pNIM", nim);
                command.Parameters.AddWithValue("pNama", nama);
                command.Parameters.AddWithValue("pAlamat", alamat);
                command.Parameters.AddWithValue("pTanggalLahir", tanggalLahir);
                command.Parameters.AddWithValue("pJenisKelamin", jenisKelamin);
                command.Parameters.AddWithValue("pNmProdi", kodeProdi);
                command.Parameters.AddWithValue("pFoto", foto);
                command.ExecuteNonQuery();
                trans.Commit();
            }
            catch (Exception) { trans.Rollback(); }
            finally { conn.Close(); }
        }

        public void UpdateMhs(string nim, string nama, string alamat, string jenisKelamin, DateTime tanggalLahir, string kodeProdi, byte[] foto)
        {
            if (conn.State == ConnectionState.Closed) { conn.Open(); }
            SqlCommand command = new SqlCommand("sp_UpdateMahasiswa", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("pNIM", nim);
            command.Parameters.AddWithValue("pNama", nama);
            command.Parameters.AddWithValue("pAlamat", alamat);
            command.Parameters.AddWithValue("pJenisKelamin", jenisKelamin);
            command.Parameters.AddWithValue("pTanggalLahir", tanggalLahir);
            command.Parameters.AddWithValue("pNmProdi", kodeProdi);
            command.Parameters.AddWithValue("pFoto", foto);
            command.ExecuteNonQuery();
        }

        public void DeleteMhs(string nim)
        {
            if (conn.State == ConnectionState.Closed) { conn.Open(); }
            SqlCommand cmd = new SqlCommand("sp_DeleteMahasiswa", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("pNIM", nim);
            cmd.ExecuteNonQuery();
        }

        public void resetData()
        {
            if (conn.State == ConnectionState.Closed) { conn.Open(); }
            SqlCommand cmdDelete = new SqlCommand("DELETE FROM mahasiswa;", conn);
            cmdDelete.ExecuteNonQuery();
            SqlCommand cmdInsert = new SqlCommand("INSERT INTO mahasiswa SELECT * FROM mahasiswa_backup;", conn);
            cmdInsert.ExecuteNonQuery();
        }

        public DataTable GetMhsByNIM(string nim)
        {
            if (conn.State == ConnectionState.Closed) { conn.Open(); }
            SqlCommand cmd = new SqlCommand("sp_GetMahasiswaByNIM", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("pNIM", nim);
            da = new SqlDataAdapter(cmd);
            dtMahasiswa = new DataTable();
            da.Fill(dtMahasiswa);
            return dtMahasiswa;
        }

        public void InsertLog(string message)
        {
            if (conn.State == ConnectionState.Closed) { conn.Open(); }
            SqlCommand cmd = new SqlCommand("sp_LogMessage", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("psn", message);
            cmd.ExecuteNonQuery();
        }

        public DataTable getProdi()
        {
            if (conn.State == ConnectionState.Closed) { conn.Open(); }
            SqlCommand cmd = new SqlCommand("select namaprodi from prodi", conn);
            dtProdi = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dtProdi);
            return dtProdi;
        }

        public DataTable getDataRekap(string prodi, DateTime tanggalMasuk)
        {
            if (conn.State == ConnectionState.Closed) { conn.Open(); }
            SqlCommand cmd = new SqlCommand("sp_Report", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@inProdi", prodi);
            cmd.Parameters.AddWithValue("@inTglMsuk", tanggalMasuk.Year.ToString());
            da = new SqlDataAdapter(cmd);
            dtMahasiswa = new DataTable();
            da.Fill(dtMahasiswa);
            return dtMahasiswa;
        }

        public DataTable getAllDataChart()
        {
            if (conn.State == ConnectionState.Closed) { conn.Open(); }
            SqlCommand cmd = new SqlCommand("sp_DashBoard", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            dtMahasiswa = new DataTable();
            da.Fill(dtMahasiswa);
            return dtMahasiswa;
        }

        public DataTable getDataChartByTahun(DateTime thMasuk)
        {
            if (conn.State == ConnectionState.Closed) { conn.Open(); }
            SqlCommand cmd = new SqlCommand("sp_DashBoardByTahun", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@inTglMsuk", thMasuk.Year);
            da = new SqlDataAdapter(cmd);
            dtMahasiswa = new DataTable();
            da.Fill(dtMahasiswa);
            return dtMahasiswa;
        }
        public void testInject(string nim)
        {
            if (conn.State == ConnectionState.Closed) { conn.Open(); }
            string query = "Update mahasiswa set nama = 'HACKED' where NIM = " + nim;
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
        }
    }
}