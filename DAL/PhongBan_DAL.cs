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
    public class PhongBan_DAL
    {
        public SqlConnection getConnection()
        {
            String strconn = @"Data Source=PC-TRUONG\SQLEXPRESS;Initial Catalog=QLNhanSu;Integrated Security=True";
            return new SqlConnection(strconn);
        }
        public DataTable getAllPhongBan()
        {
            String sql = "select * from PHONGBAN";
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
        public int insertPhongBan(PhongBan_DTO pb)
        {
            String sql = "insert into PhongBan values(@MaPB,@TenPB,@NgayTL)";
            try
            {
                SqlConnection conn = getConnection();
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaPB", pb.MaPB);
                cmd.Parameters.AddWithValue("@TenPB", pb.TenPB);
                cmd.Parameters.AddWithValue("@NgayTL", pb.NgayTL);
                
                cmd.ExecuteNonQuery();
                return 1;
            }
            catch (SqlException e)
            {
                //MessageBox.Show(e.Message);
                //return 0;
            }
            return 0;
        }
        public int updatePhongBan(PhongBan_DTO pb)
        {
            String sql = "update  PhongBan set tenpb=@TenPB,ngaytl=@NgayTL where mapb=@MaPB";
            try
            {
                SqlConnection conn = getConnection();
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaPB", pb.MaPB);
                cmd.Parameters.AddWithValue("@TenPB", pb.TenPB);
                cmd.Parameters.AddWithValue("@NgayTL", pb.NgayTL);

                cmd.ExecuteNonQuery();
                return 1;
            }
            catch (SqlException e)
            {
                //MessageBox.Show(e.Message);\
                //return 0;
            }
            return 0;
        }
        public int deletePhongBan(string MaPB)
        {
            String sql = "delete from phongban where mapb=@MaPB";
            try
            {
                SqlConnection conn = getConnection();
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaPB", MaPB);
                

                cmd.ExecuteNonQuery();
                return 1;
            }
            catch (SqlException e)
            {
                //MessageBox.Show(e.Message);
                //return 0;
            }
            return 0;
        }
        public DataTable findPhongBan(PhongBan_DTO pb)
        {
            String sql = "select * from PHONGBAN where 1=1 and mapb like '%"+pb.MaPB+"%' and tenpb like '%"+pb.TenPB+"%'";
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
    }
}
