using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class CongTac_DAL
    {
        public SqlConnection getConnection()
        {
            String strconn = @"Data Source=PC-TRUONG\SQLEXPRESS;Initial Catalog=QLNhanSu;Integrated Security=True";
            return new SqlConnection(strconn);
        }
        public DataTable getAllCongTac()
        {
            try
            {
                String sql = "Select * from CongTac";
                SqlConnection conn = getConnection();
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                return dt;
            }
            catch (SqlException)
            {
                //MessageBox.Show(e.Message);
                //return 0;
            }
            return null;
        }
        public int insertCongTac(CongTac_DTO ct)
        {
            String sql = "insert into CongTac values(@MaNV,@NgayCongTac,@NoiCongTac)";
            try
            {
                SqlConnection conn = getConnection();
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaNV", ct.MaNV);
                cmd.Parameters.AddWithValue("@NgayCongTac", ct.NgayCongTac);
                cmd.Parameters.AddWithValue("@NoiCongTac", ct.NoiCongTac);
                cmd.ExecuteNonQuery();
                return 1;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                //return 0;
            }
            return 0;
        }
        public int updateCongTac(CongTac_DTO ct)
        {
            String sql = "update CongTac set NoiCongTac=@NoiCongTac where manv=@MaNV and ngaycongtac=@NgayCongTac";
            try
            {
                SqlConnection conn = getConnection();
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaNV", ct.MaNV);
                cmd.Parameters.AddWithValue("@NgayCongTac", ct.NgayCongTac);
                cmd.Parameters.AddWithValue("@NoiCongTac", ct.NoiCongTac);
                cmd.ExecuteNonQuery();
                return 1;
            }
            catch (SqlException)
            {
                //MessageBox.Show(e.Message);
                //return 0;
            }
            return 0;
        }
        public int deleteCongTac(string manv, string ngaycongtac)
        {
            String sql = "delete from congtac where manv=@MaNV and ngaycongtac=@NgayCongTac";
            try
            {
                SqlConnection conn = getConnection();
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaNV", manv);
                cmd.Parameters.AddWithValue("@NgayCongTac", ngaycongtac);
                cmd.ExecuteNonQuery();
                return 1;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                //return 0;
            }
            return 0;
        }
        public DataTable timkiemCongTac(CongTac_DTO ct)
        {

            try
            {
                String sql = "select * from congtac where 1=1 and manv like '%" + ct.MaNV + "%' and ngaycongtac like '%" + ct.NgayCongTac + "%'";
                SqlConnection conn = getConnection();
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                return dt;
            }
            catch (SqlException)
            {
                //MessageBox.Show(e.Message);

            }
            return null;
        }
    }
}
