using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using QLNhanSu.UserControls;

namespace QLNhanSu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }
        private void moveImageBox(object sender)
        {
            Guna2Button b = (Guna2Button)sender;
            imgSlide.Location = new Point(b.Location.X + 163, b.Location.Y - 30);
            imgSlide.SendToBack();
        }
        private void guna2Button1_CheckedChanged(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void addControls(UserControl uc)
        {
            panel2.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panel2.Controls.Add(uc);
            uc.BringToFront();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UC_NhanVien un = new UC_NhanVien();
            addControls(un);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            UC_ChamCong ucc = new UC_ChamCong();
            addControls(ucc);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UC_ChucVu ucv = new UC_ChucVu();
            addControls(ucv);
        }

        private void btnNhanVien_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnPhongBan_Click(object sender, EventArgs e)
        {
            UC_PhongBan ub = new UC_PhongBan();
            addControls(ub);
        }

        private void btnTrinhDo_Click(object sender, EventArgs e)
        {
            UC_TrinhDo ut = new UC_TrinhDo();
            addControls(ut);
        }

        private void btnCongTac_Click(object sender, EventArgs e)
        {
            UC_CongTac uct = new UC_CongTac();
            addControls(uct);
        }
        private void  timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lableTime.Text = dt.ToString("HH:mm:ss");
        }

        private void uC_NhanVien1_Load(object sender, EventArgs e)
        {
            //a Tuân Idol
        }

        private void lableTime_Click(object sender, EventArgs e)
        {

        }
    }
}
