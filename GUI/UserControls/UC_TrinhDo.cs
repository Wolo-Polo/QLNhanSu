using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUL;
using DTO;

namespace QLNhanSu.UserControls
{
    public partial class UC_TrinhDo : UserControl
    {
        private TrinhDo_BUL trinhDo_BUL= new TrinhDo_BUL();
        private NhanVien_BUL nhanVien_BUL = new NhanVien_BUL();

        public UC_TrinhDo()
        {
            InitializeComponent();
        }

        public void HienThi()
        {
            try
            {
                guna2DataGridViewTrinhDo.DataSource = trinhDo_BUL.getAllTrinhDo();
            }catch(System.InvalidOperationException invalidOperationException)
            {
                MessageBox.Show("Không thể mở kết nối đến database!");
            }
        }

        public void LamSach()
        {
            guna2ComboBoxMaNV.Text = "";
            guna2TextBoxTrinhDo.Text = "";
            guna2TextBoxTruong.Text = "";
            guna2TextBoxNganh.Text = "";
    
        }

        private void UC_TrinhDo_Load(object sender, EventArgs e)
        {
            DataTable dt= nhanVien_BUL.getAllNhanVien();
            guna2ComboBoxMaNV.DataSource = dt;
            guna2ComboBoxMaNV.DisplayMember = "Mã nhân viên";
            HienThi();
        }

        private void guna2ButtonThem_Click(object sender, EventArgs e)
        {
            try
            {
                TrinhDo trinhDo = new TrinhDo();
                trinhDo.MaNV = guna2ComboBoxMaNV.Text;
                trinhDo.Nganh = guna2TextBoxNganh.Text;
                trinhDo.TrinhDoDaoTao = guna2TextBoxTrinhDo.Text;
                trinhDo.Truong = guna2TextBoxTruong.Text;

                trinhDo_BUL.insertTrinhDo(trinhDo);

                LamSach();
                HienThi();
                MessageBox.Show("Thêm mới thành công!");
            }catch(System.Data.SqlClient.SqlException sqlException)
            {
                MessageBox.Show("Lỗi khi thực thi lệnh thêm mới!");
            }
        }

        private void guna2DataGridViewTrinhDo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = guna2DataGridViewTrinhDo.CurrentCell.RowIndex;
            guna2ComboBoxMaNV.Text = guna2DataGridViewTrinhDo.Rows[row].Cells["manv"].Value.ToString();
            guna2TextBoxTrinhDo.Text = guna2DataGridViewTrinhDo.Rows[row].Cells["trinhdo"].Value.ToString();
            guna2TextBoxNganh.Text = guna2DataGridViewTrinhDo.Rows[row].Cells["nganh"].Value.ToString();
            guna2TextBoxTruong.Text = guna2DataGridViewTrinhDo.Rows[row].Cells["truong"].Value.ToString();

        }

        private void guna2ButtonCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                TrinhDo trinhDo = new TrinhDo();
                trinhDo.MaNV = guna2ComboBoxMaNV.Text;
                trinhDo.Nganh = guna2TextBoxNganh.Text;
                trinhDo.TrinhDoDaoTao = guna2TextBoxTrinhDo.Text;
                trinhDo.Truong = guna2TextBoxTruong.Text;

                trinhDo_BUL.updateTrinhDo(trinhDo);

                LamSach();
                HienThi();
                MessageBox.Show("Cập nhật thành công!");
            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                MessageBox.Show("Lỗi khi thực thi lệnh cập nhật!");
            }
        }

        private void guna2ButtonXoa_Click(object sender, EventArgs e)
        {
            try
            {
                TrinhDo trinhDo = new TrinhDo();
                trinhDo.MaNV = guna2ComboBoxMaNV.Text;
                trinhDo.Nganh = guna2TextBoxNganh.Text;
                trinhDo.TrinhDoDaoTao = guna2TextBoxTrinhDo.Text;
                trinhDo.Truong = guna2TextBoxTruong.Text;

                trinhDo_BUL.deleteTrinhDo(trinhDo);

                LamSach();
                HienThi();
                MessageBox.Show("Đã xóa!");
            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                MessageBox.Show("Lỗi khi thực thi lệnh xóa!");
            }
        }

        private void guna2ButtonTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                TrinhDo trinhDo = new TrinhDo();
                trinhDo.MaNV = guna2ComboBoxMaNV.Text;
                trinhDo.Nganh = guna2TextBoxNganh.Text;
                trinhDo.TrinhDoDaoTao = guna2TextBoxTrinhDo.Text;
                trinhDo.Truong = guna2TextBoxTruong.Text;

                guna2DataGridViewTrinhDo.DataSource = trinhDo_BUL.findTrinhDo(trinhDo);
            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                MessageBox.Show("Lỗi khi thực thi lệnh tìm kiếm!");
            }
        }

        private void guna2ButtonHienThi_Click(object sender, EventArgs e)
        {
            LamSach();
            HienThi();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            LamSach();
        }
    }
}
