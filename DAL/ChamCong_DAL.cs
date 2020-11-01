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
    public class ChamCong_DAL
    {
        public SqlConnection getConnection()
        {
            string strconn = @"Data Source=PC-TRUONG\SQLEXPRESS;Initial Catalog=QLNhanSu;Integrated Security=True";
            return new SqlConnection(strconn);
        }
        public DataTable getAllChamCong()
        {
            try
            {
                String sql = "SELECT CONG.MaNV, TenNV, NgayCong, GhiChu FROM CONG INNER JOIN NHANVIEN ON NHANVIEN.MaNV = CONG.MaNV";
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
            }
            return null;
        }
        public Boolean insertChamCong(ChamCong_DTO c)
        {
            String sql = "INSERT INTO cong VALUES (@manv, @ngaycong, @ghichu)";
            try
            {
                SqlConnection conn = getConnection();
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@manv", c.Manv);
                cmd.Parameters.AddWithValue("@ngaycong", c.Ngaycong);
                cmd.Parameters.AddWithValue("@ghichu", c.Ghichu);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException)
            {
            }
            return false;
        }

        public Boolean updateChamCong(ChamCong_DTO c)
        {
            String sql = "UPDATE cong SET ghichu = @ghichu WHERE manv = @manv AND ngaycong = @ngaycong";
            try
            {
                SqlConnection conn = getConnection();
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ghichu", c.Ghichu);
                cmd.Parameters.AddWithValue("@manv", c.Manv);
                cmd.Parameters.AddWithValue("@ngaycong", c.Ngaycong);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException)
            {
            }
            return false;
        }
        public Boolean deleteChamCong(ChamCong_DTO c)
        {
            String sql = "DELETE FROM cong WHERE manv = @manv AND ngaycong = @ngaycong";
            try
            {
                SqlConnection conn = getConnection();
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@manv", c.Manv);
                cmd.Parameters.AddWithValue("@ngaycong", c.Ngaycong);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException)
            {
            }
            return false;
        }

        public DataTable findChamCong(ChamCong_DTO c)
        {
            try
            {
                string sql = "SELECT * FROM dbo.Fn_Find() WHERE manv = '" + c.Manv + "' AND ghichu LIKE '%" + c.Ghichu + "%'";
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
            }
            return null;
        }

    }
}
