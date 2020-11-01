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
    public class Luong_DAL
    {
        public SqlConnection getConnection()
        {
            string strconn = @"Data Source=PC-TRUONG\SQLEXPRESS;Initial Catalog=QLNhanSu;Integrated Security=True";
            return new SqlConnection(strconn);
        }
        public DataTable getLuong()
        {
            String sql = "SELECT manv[Mã nhân viên], tennv[Tên nhân viên], nam[Năm], thang[Tháng], socong[Số công], tongluong[Lương] FROM dbo.tblluong()";
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

        public DataTable findLuong(string manv, string tennv, string nam, string thang, string socong, string tongluong)
        {
            try
            {
                string sql = "SELECT manv[Mã nhân viên], tennv[Tên nhân viên], nam[Năm], thang[Tháng], ";
                sql += "socong[Số công], tongluong[Lương] FROM dbo.tblluong() ";
                sql += "WHERE manv like '%" + manv + "%' AND tennv like '%" + tennv + "%' ";
                sql += "AND nam like '%" + nam + "%' AND thang like '%" + thang + "%' ";
                sql += "AND socong like '%" + socong + "%' AND tongluong like '%" + tongluong + "%' ";
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
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            return null;
        }
    }
}
