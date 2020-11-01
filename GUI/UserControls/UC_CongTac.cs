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
    public partial class UC_CongTac : UserControl
    {
        private NhanVien_BUL nhanVien_BUL = new NhanVien_BUL();
        private CongTac_DTO congTac_DTO = new CongTac_DTO();
        private CongTac_BUL congTac_BUL = new CongTac_BUL();
        public UC_CongTac()
        {
            InitializeComponent();
        }

        private void UC_CongTac_Load(object sender, EventArgs e)
        {
            HienThi();
            DataTable tb = nhanVien_BUL.getAllNhanVien();
            cbbmanv.DataSource = tb;
            cbbmanv.DisplayMember = "Mã nhân viên";
        }
        private void HienThi()
        {
            DataTable dt = congTac_BUL.getAllCongTac();
            dtgCongTac.DataSource = dt;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            CongTac_DTO ct = new CongTac_DTO();
            ct.MaNV = cbbmanv.Text;
            ct.NgayCongTac = dtpngaycongtac.Text;
            ct.NoiCongTac = txtNoiCongTac.Text;
            int kq = congTac_BUL.insertCongTac(ct);
            //if (kq == 1)
            //{
            //    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (kq == 0)
            //    MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            HienThi();
            LamSach();
        }

        private void dtgCongTac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                cbbmanv.Text = dtgCongTac.Rows[row].Cells[0].Value.ToString();
                dtpngaycongtac.Text = dtgCongTac.Rows[row].Cells[1].Value.ToString();
                txtNoiCongTac.Text = dtgCongTac.Rows[row].Cells[2].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            CongTac_DTO ct = new CongTac_DTO();
            ct.MaNV = cbbmanv.Text;
            ct.NgayCongTac = dtpngaycongtac.Text;
            ct.NoiCongTac = txtNoiCongTac.Text;
            int kq = congTac_BUL.updateCongTac(ct);
            if (kq == 1)
            {
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (kq == 0)
                MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            HienThi();
            LamSach();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {


            int kq = congTac_BUL.deleteCongTac(cbbmanv.Text, dtpngaycongtac.Text);
                if (kq == 1)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (kq == 0)
                    MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            MessageBox.Show(dtpngaycongtac.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            HienThi();
            LamSach();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            CongTac_DTO ct = new CongTac_DTO();
            ct.MaNV = cbbmanv.SelectedValue.ToString();
            ct.NgayCongTac = dtpngaycongtac.Text;
            ct.NoiCongTac = txtNoiCongTac.Text;
            DataTable dt = congTac_BUL.timkiemCongTac(ct);
            dtgCongTac.DataSource = dt;
            
        }

        public void LamSach()
        {
            cbbmanv.Text = "";
            txtNoiCongTac.Text = "";
        }

        private void guna2ButtonHienThi_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void guna2ButtonLamSach_Click(object sender, EventArgs e)
        {
            LamSach();
        }

        private void dtgCongTac_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int row = dtgCongTac.CurrentCell.RowIndex;
            cbbmanv.Text = dtgCongTac.Rows[row].Cells["Column1"].Value.ToString();
            dtpngaycongtac.Text = dtgCongTac.Rows[row].Cells["Column2"].Value.ToString();
            txtNoiCongTac.Text = dtgCongTac.Rows[row].Cells["Column3"].Value.ToString();
        }
    }
    
}
