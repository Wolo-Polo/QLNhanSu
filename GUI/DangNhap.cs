using BUL;
//using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhanSu
{
    public partial class Dangnhap : Form
    {
        private Admin_BUL Admin = new Admin_BUL();
        public Dangnhap()
        {
            InitializeComponent();
        }

       

        

        bool dangnhap(string taikhoan, string matkhau)
        {
            return Admin.Dangnhap(taikhoan, matkhau);
        }

        

        private void btndong_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btndangnhap_Click_1(object sender, EventArgs e)
        {
            string taikhoan = txttaikhoan.Text;
            string matkhau = txtmatkhau.Text;
            if (dangnhap(taikhoan, matkhau))
            {
                Form1 frmForm1 = new Form1();
                this.Hide();
                frmForm1.ShowDialog();
                this.Show();
                txttaikhoan.Text = "";
                txtmatkhau.Text = "";
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            }
        }

        private void Dangnhap_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn thực sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }
    }
}
