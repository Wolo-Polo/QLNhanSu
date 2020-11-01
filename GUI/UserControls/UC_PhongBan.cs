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
    public partial class UC_PhongBan : UserControl
    {
        private PhongBan_BUL phongBan_BUL = new PhongBan_BUL();
        public UC_PhongBan()
        {
            InitializeComponent();
        }
        private void HienThi()
        {
            DataTable dt = phongBan_BUL.getAllPhongBan();
            dtgPhongBan.DataSource = dt;
        }

        private void UC_PhongBan_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            using(ThongKeTheoPhongBan tk=new ThongKeTheoPhongBan())
            {
                tk.ShowDialog();
                this.OnLoad(e);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaPB.Text.Equals("") || txtTenPB.Text.Equals(""))
            {
                MessageBox.Show("Phải điền đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PhongBan_DTO pb = new PhongBan_DTO();
                pb.MaPB = txtMaPB.Text;
                pb.TenPB = txtTenPB.Text;
                pb.NgayTL = dtpNgayTL.Text;
                int kq = phongBan_BUL.insertPhongBan(pb);
                if (kq == 1)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (kq == 0)
                    MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            HienThi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaPB.Text.Equals("") || txtTenPB.Text.Equals(""))
            {
                MessageBox.Show("Phải điền đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PhongBan_DTO pb = new PhongBan_DTO();
                pb.MaPB = txtMaPB.Text;
                pb.TenPB = txtTenPB.Text;
                pb.NgayTL = dtpNgayTL.Text;
                int kq = phongBan_BUL.updatePhongBan(pb);
                if (kq == 1)
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (kq == 0)
                    MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            HienThi();
        }

        private void dtgPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                txtMaPB.Text= dtgPhongBan.Rows[row].Cells[0].Value.ToString();
                txtTenPB.Text = dtgPhongBan.Rows[row].Cells[1].Value.ToString();
                dtpNgayTL.Text = dtgPhongBan.Rows[row].Cells[2].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaPB.Text.Equals("") || txtTenPB.Text.Equals(""))
            {
                MessageBox.Show("Phải điền đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int kq = phongBan_BUL.deletePhongBan(txtMaPB.Text);
                if (kq == 1)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (kq == 0)
                    MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            HienThi();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            PhongBan_DTO pb = new PhongBan_DTO();
            pb.MaPB = txtMaPB.Text;
            pb.TenPB = txtTenPB.Text;
            pb.NgayTL = dtpNgayTL.Text;
            DataTable dt = phongBan_BUL.findPhongBan(pb);
            dtgPhongBan.DataSource = dt;
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            txtMaPB.Text = "";
            txtTenPB.Text = "";
        }
    }
}
