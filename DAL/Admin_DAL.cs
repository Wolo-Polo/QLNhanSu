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
    public class Admin_DAL
    {
        public SqlConnection getConnection()
        {
            string strconn = @"Data Source=PC-TRUONG\SQLEXPRESS;Initial Catalog=QLNhanSu;Integrated Security=True";
            return new SqlConnection(strconn);
        }
        public Boolean Dangnhap(string taikhoan, string matkhau)
        {
            String sql = "SELECT * FROM nhanvien WHERE taikhoan = '" + taikhoan + "' AND matkhau = '" + matkhau + "'";
            SqlConnection conn = getConnection();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            return dt.Rows.Count > 0;
        }
    }
}
