namespace QLNhanSu
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lableTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.btnCong = new Guna.UI2.WinForms.Guna2Button();
            this.btnCongTac = new Guna.UI2.WinForms.Guna2Button();
            this.btnTrinhDo = new Guna.UI2.WinForms.Guna2Button();
            this.btnPhongBan = new Guna.UI2.WinForms.Guna2Button();
            this.btnChucVu = new Guna.UI2.WinForms.Guna2Button();
            this.imgSlide = new System.Windows.Forms.PictureBox();
            this.btnNhanVien = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_NhanVien1 = new QLNhanSu.UserControls.UC_NhanVien();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlide)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lableTime);
            this.panel1.Controls.Add(this.guna2Button7);
            this.panel1.Controls.Add(this.btnCong);
            this.panel1.Controls.Add(this.btnCongTac);
            this.panel1.Controls.Add(this.btnTrinhDo);
            this.panel1.Controls.Add(this.btnPhongBan);
            this.panel1.Controls.Add(this.btnChucVu);
            this.panel1.Controls.Add(this.imgSlide);
            this.panel1.Controls.Add(this.btnNhanVien);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 681);
            this.panel1.TabIndex = 0;
            // 
            // lableTime
            // 
            this.lableTime.BackColor = System.Drawing.Color.Transparent;
            this.lableTime.Enabled = false;
            this.lableTime.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableTime.ForeColor = System.Drawing.Color.White;
            this.lableTime.Location = new System.Drawing.Point(56, 77);
            this.lableTime.Name = "lableTime";
            this.lableTime.Size = new System.Drawing.Size(121, 28);
            this.lableTime.TabIndex = 8;
            this.lableTime.Text = "HH:MM:ss";
            this.lableTime.Click += new System.EventHandler(this.lableTime_Click);
            // 
            // guna2Button7
            // 
            this.guna2Button7.BorderRadius = 5;
            this.guna2Button7.CheckedState.Parent = this.guna2Button7;
            this.guna2Button7.CustomImages.Parent = this.guna2Button7;
            this.guna2Button7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.guna2Button7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button7.ForeColor = System.Drawing.Color.White;
            this.guna2Button7.HoverState.Parent = this.guna2Button7;
            this.guna2Button7.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button7.Image")));
            this.guna2Button7.Location = new System.Drawing.Point(81, 604);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.ShadowDecoration.Parent = this.guna2Button7;
            this.guna2Button7.Size = new System.Drawing.Size(45, 38);
            this.guna2Button7.TabIndex = 7;
            this.guna2Button7.Click += new System.EventHandler(this.guna2Button7_Click);
            // 
            // btnCong
            // 
            this.btnCong.BackColor = System.Drawing.Color.Transparent;
            this.btnCong.BorderRadius = 22;
            this.btnCong.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCong.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCong.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnCong.CheckedState.Parent = this.btnCong;
            this.btnCong.CustomImages.Parent = this.btnCong;
            this.btnCong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnCong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCong.ForeColor = System.Drawing.Color.White;
            this.btnCong.HoverState.Parent = this.btnCong;
            this.btnCong.Location = new System.Drawing.Point(6, 532);
            this.btnCong.Name = "btnCong";
            this.btnCong.ShadowDecoration.Parent = this.btnCong;
            this.btnCong.Size = new System.Drawing.Size(198, 44);
            this.btnCong.TabIndex = 6;
            this.btnCong.Text = "Quản lý công";
            this.btnCong.UseTransparentBackground = true;
            this.btnCong.CheckedChanged += new System.EventHandler(this.guna2Button1_CheckedChanged);
            this.btnCong.Click += new System.EventHandler(this.guna2Button6_Click);
            // 
            // btnCongTac
            // 
            this.btnCongTac.BackColor = System.Drawing.Color.Transparent;
            this.btnCongTac.BorderRadius = 22;
            this.btnCongTac.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCongTac.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCongTac.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnCongTac.CheckedState.Parent = this.btnCongTac;
            this.btnCongTac.CustomImages.Parent = this.btnCongTac;
            this.btnCongTac.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnCongTac.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCongTac.ForeColor = System.Drawing.Color.White;
            this.btnCongTac.HoverState.Parent = this.btnCongTac;
            this.btnCongTac.Location = new System.Drawing.Point(6, 450);
            this.btnCongTac.Name = "btnCongTac";
            this.btnCongTac.ShadowDecoration.Parent = this.btnCongTac;
            this.btnCongTac.Size = new System.Drawing.Size(198, 44);
            this.btnCongTac.TabIndex = 5;
            this.btnCongTac.Text = "Quản lý công tác";
            this.btnCongTac.UseTransparentBackground = true;
            this.btnCongTac.CheckedChanged += new System.EventHandler(this.guna2Button1_CheckedChanged);
            this.btnCongTac.Click += new System.EventHandler(this.btnCongTac_Click);
            // 
            // btnTrinhDo
            // 
            this.btnTrinhDo.BackColor = System.Drawing.Color.Transparent;
            this.btnTrinhDo.BorderRadius = 22;
            this.btnTrinhDo.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTrinhDo.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnTrinhDo.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnTrinhDo.CheckedState.Parent = this.btnTrinhDo;
            this.btnTrinhDo.CustomImages.Parent = this.btnTrinhDo;
            this.btnTrinhDo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnTrinhDo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrinhDo.ForeColor = System.Drawing.Color.White;
            this.btnTrinhDo.HoverState.Parent = this.btnTrinhDo;
            this.btnTrinhDo.Location = new System.Drawing.Point(6, 368);
            this.btnTrinhDo.Name = "btnTrinhDo";
            this.btnTrinhDo.ShadowDecoration.Parent = this.btnTrinhDo;
            this.btnTrinhDo.Size = new System.Drawing.Size(198, 44);
            this.btnTrinhDo.TabIndex = 4;
            this.btnTrinhDo.Text = "Quản lý trình độ";
            this.btnTrinhDo.UseTransparentBackground = true;
            this.btnTrinhDo.CheckedChanged += new System.EventHandler(this.guna2Button1_CheckedChanged);
            this.btnTrinhDo.Click += new System.EventHandler(this.btnTrinhDo_Click);
            // 
            // btnPhongBan
            // 
            this.btnPhongBan.BackColor = System.Drawing.Color.Transparent;
            this.btnPhongBan.BorderRadius = 22;
            this.btnPhongBan.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPhongBan.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnPhongBan.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnPhongBan.CheckedState.Parent = this.btnPhongBan;
            this.btnPhongBan.CustomImages.Parent = this.btnPhongBan;
            this.btnPhongBan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnPhongBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhongBan.ForeColor = System.Drawing.Color.White;
            this.btnPhongBan.HoverState.Parent = this.btnPhongBan;
            this.btnPhongBan.Location = new System.Drawing.Point(6, 286);
            this.btnPhongBan.Name = "btnPhongBan";
            this.btnPhongBan.ShadowDecoration.Parent = this.btnPhongBan;
            this.btnPhongBan.Size = new System.Drawing.Size(198, 44);
            this.btnPhongBan.TabIndex = 3;
            this.btnPhongBan.Text = "Quản lý phòng ban";
            this.btnPhongBan.UseTransparentBackground = true;
            this.btnPhongBan.CheckedChanged += new System.EventHandler(this.guna2Button1_CheckedChanged);
            this.btnPhongBan.Click += new System.EventHandler(this.btnPhongBan_Click);
            // 
            // btnChucVu
            // 
            this.btnChucVu.BackColor = System.Drawing.Color.Transparent;
            this.btnChucVu.BorderRadius = 22;
            this.btnChucVu.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnChucVu.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnChucVu.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnChucVu.CheckedState.Parent = this.btnChucVu;
            this.btnChucVu.CustomImages.Parent = this.btnChucVu;
            this.btnChucVu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnChucVu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChucVu.ForeColor = System.Drawing.Color.White;
            this.btnChucVu.HoverState.Parent = this.btnChucVu;
            this.btnChucVu.Location = new System.Drawing.Point(6, 204);
            this.btnChucVu.Name = "btnChucVu";
            this.btnChucVu.ShadowDecoration.Parent = this.btnChucVu;
            this.btnChucVu.Size = new System.Drawing.Size(198, 44);
            this.btnChucVu.TabIndex = 2;
            this.btnChucVu.Text = "Quản lý chức vụ";
            this.btnChucVu.UseTransparentBackground = true;
            this.btnChucVu.CheckedChanged += new System.EventHandler(this.guna2Button1_CheckedChanged);
            this.btnChucVu.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // imgSlide
            // 
            this.imgSlide.Image = ((System.Drawing.Image)(resources.GetObject("imgSlide.Image")));
            this.imgSlide.Location = new System.Drawing.Point(168, 92);
            this.imgSlide.Name = "imgSlide";
            this.imgSlide.Size = new System.Drawing.Size(39, 101);
            this.imgSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSlide.TabIndex = 1;
            this.imgSlide.TabStop = false;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.btnNhanVien.BorderRadius = 22;
            this.btnNhanVien.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnNhanVien.Checked = true;
            this.btnNhanVien.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnNhanVien.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnNhanVien.CheckedState.Parent = this.btnNhanVien;
            this.btnNhanVien.CustomImages.Parent = this.btnNhanVien;
            this.btnNhanVien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnNhanVien.HoverState.Parent = this.btnNhanVien;
            this.btnNhanVien.Location = new System.Drawing.Point(6, 122);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNhanVien.ShadowDecoration.Parent = this.btnNhanVien;
            this.btnNhanVien.Size = new System.Drawing.Size(198, 44);
            this.btnNhanVien.TabIndex = 1;
            this.btnNhanVien.Text = "Quản lý nhân viên";
            this.btnNhanVien.UseTransparentBackground = true;
            this.btnNhanVien.CheckedChanged += new System.EventHandler(this.guna2Button1_CheckedChanged);
            this.btnNhanVien.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 26;
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.panel2.Controls.Add(this.uC_NhanVien1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(207, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 7, 7, 7);
            this.panel2.Size = new System.Drawing.Size(1011, 681);
            this.panel2.TabIndex = 1;
            // 
            // uC_NhanVien1
            // 
            this.uC_NhanVien1.BackColor = System.Drawing.Color.White;
            this.uC_NhanVien1.Location = new System.Drawing.Point(0, 7);
            this.uC_NhanVien1.Margin = new System.Windows.Forms.Padding(0);
            this.uC_NhanVien1.Name = "uC_NhanVien1";
            this.uC_NhanVien1.Size = new System.Drawing.Size(1004, 667);
            this.uC_NhanVien1.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1218, 681);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlide)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnCongTac;
        private Guna.UI2.WinForms.Guna2Button btnTrinhDo;
        private Guna.UI2.WinForms.Guna2Button btnPhongBan;
        private Guna.UI2.WinForms.Guna2Button btnChucVu;
        private System.Windows.Forms.PictureBox imgSlide;
        private Guna.UI2.WinForms.Guna2Button btnNhanVien;
        private Guna.UI2.WinForms.Guna2Button btnCong;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel2;
        private UserControls.UC_NhanVien uC_NhanVien1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lableTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

