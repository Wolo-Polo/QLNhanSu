using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TrinhDo_DAL
    {
        public SqlConnection getConnection()
        {
            String strConn = @"Data Source=PC-TRUONG\SQLEXPRESS;Initial Catalog=QLNhanSu;Integrated Security=True";
            return new SqlConnection(strConn);
        }

        public DataTable getAllTrinhDo()
        {
            SqlConnection conn = getConnection();
            conn.Open();

            String sql = "select * from trinhdo";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void insertTrinhDo(TrinhDo trinhDo)
        {
            String sql = "insert into trinhdo values(@manv, @nganh, @trinhdo, @truong)";
            SqlConnection conn = getConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("manv", trinhDo.MaNV);
            cmd.Parameters.AddWithValue("nganh", trinhDo.Nganh);
            cmd.Parameters.AddWithValue("trinhdo", trinhDo.TrinhDoDaoTao);
            cmd.Parameters.AddWithValue("truong", trinhDo.Truong);

            cmd.ExecuteNonQuery();

        }

        public void updateTrinhDo(TrinhDo trinhDo)
        {
            String sql = "update trinhdo set trinhdo=@trinhdo, truong=@truong where manv=@manv and nganh=@nganh";
            SqlConnection conn = getConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("manv", trinhDo.MaNV);
            cmd.Parameters.AddWithValue("nganh", trinhDo.Nganh);
            cmd.Parameters.AddWithValue("trinhdo", trinhDo.TrinhDoDaoTao);
            cmd.Parameters.AddWithValue("truong", trinhDo.Truong);

            cmd.ExecuteNonQuery();
        }

        public void deleteTrinhDo(TrinhDo trinhDo)
        {
            String sql = "delete trinhdo where manv=@manv and nganh=@nganh";
            SqlConnection conn = getConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("manv", trinhDo.MaNV);
            cmd.Parameters.AddWithValue("nganh", trinhDo.Nganh);

            cmd.ExecuteNonQuery();
        }

        public DataTable findTrinhDo(TrinhDo trinhDo)
        {

            string sql = "SELECT * FROM trinhdo WHERE 1=1 and manv LIKE '%" + trinhDo.MaNV + "%' AND  nganh LIKE '%" + trinhDo.Nganh + "%' AND trinhdo LIKE '%" + trinhDo.TrinhDoDaoTao + "%' AND truong like '%" + trinhDo.Truong + "%'";
            SqlConnection conn = getConnection();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

    }
}
