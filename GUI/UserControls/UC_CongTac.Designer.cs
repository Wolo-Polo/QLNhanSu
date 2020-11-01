namespace QLNhanSu.UserControls
{
    partial class UC_CongTac
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.cbbmanv = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpngaycongtac = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtNoiCongTac = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonHienThi = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonLamSach = new Guna.UI2.WinForms.Guna2Button();
            this.dtgCongTac = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCongTac)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 26;
            this.guna2Elipse1.TargetControl = this;
            // 
            // cbbmanv
            // 
            this.cbbmanv.BackColor = System.Drawing.Color.Transparent;
            this.cbbmanv.BorderRadius = 10;
            this.cbbmanv.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbmanv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbmanv.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbmanv.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbmanv.FocusedState.Parent = this.cbbmanv;
            this.cbbmanv.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbmanv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbmanv.HoverState.Parent = this.cbbmanv;
            this.cbbmanv.ItemHeight = 30;
            this.cbbmanv.ItemsAppearance.Parent = this.cbbmanv;
            this.cbbmanv.Location = new System.Drawing.Point(230, 100);
            this.cbbmanv.Name = "cbbmanv";
            this.cbbmanv.ShadowDecoration.Parent = this.cbbmanv;
            this.cbbmanv.Size = new System.Drawing.Size(200, 36);
            this.cbbmanv.TabIndex = 106;
            // 
            // dtpngaycongtac
            // 
            this.dtpngaycongtac.BorderRadius = 10;
            this.dtpngaycongtac.CheckedState.Parent = this.dtpngaycongtac;
            this.dtpngaycongtac.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dtpngaycongtac.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpngaycongtac.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpngaycongtac.HoverState.Parent = this.dtpngaycongtac;
            this.dtpngaycongtac.Location = new System.Drawing.Point(230, 172);
            this.dtpngaycongtac.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpngaycongtac.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpngaycongtac.Name = "dtpngaycongtac";
            this.dtpngaycongtac.ShadowDecoration.Parent = this.dtpngaycongtac;
            this.dtpngaycongtac.Size = new System.Drawing.Size(200, 30);
            this.dtpngaycongtac.TabIndex = 107;
            this.dtpngaycongtac.Value = new System.DateTime(2020, 8, 26, 17, 28, 52, 796);
            // 
            // txtNoiCongTac
            // 
            this.txtNoiCongTac.BorderRadius = 10;
            this.txtNoiCongTac.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoiCongTac.DefaultText = "";
            this.txtNoiCongTac.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNoiCongTac.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNoiCongTac.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoiCongTac.DisabledState.Parent = this.txtNoiCongTac;
            this.txtNoiCongTac.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoiCongTac.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNoiCongTac.FocusedState.Parent = this.txtNoiCongTac;
            this.txtNoiCongTac.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiCongTac.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNoiCongTac.HoverState.Parent = this.txtNoiCongTac;
            this.txtNoiCongTac.Location = new System.Drawing.Point(230, 244);
            this.txtNoiCongTac.Name = "txtNoiCongTac";
            this.txtNoiCongTac.PasswordChar = '\0';
            this.txtNoiCongTac.PlaceholderText = "";
            this.txtNoiCongTac.SelectedText = "";
            this.txtNoiCongTac.ShadowDecoration.Parent = this.txtNoiCongTac;
            this.txtNoiCongTac.Size = new System.Drawing.Size(200, 24);
            this.txtNoiCongTac.TabIndex = 108;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(74, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 19);
            this.label6.TabIndex = 105;
            this.label6.Text = "Nơi công tác";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(74, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 19);
            this.label5.TabIndex = 104;
            this.label5.Text = "Ngày công tác";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(74, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 103;
            this.label1.Text = "Mã nhân viên";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(340, 30);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(320, 42);
            this.guna2HtmlLabel1.TabIndex = 110;
            this.guna2HtmlLabel1.Text = "Quản lý lịch công tác";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BorderRadius = 10;
            this.btnTimKiem.CheckedState.Parent = this.btnTimKiem;
            this.btnTimKiem.CustomImages.Parent = this.btnTimKiem;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.HoverState.Parent = this.btnTimKiem;
            this.btnTimKiem.Location = new System.Drawing.Point(726, 232);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.ShadowDecoration.Parent = this.btnTimKiem;
            this.btnTimKiem.Size = new System.Drawing.Size(180, 45);
            this.btnTimKiem.TabIndex = 114;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BorderRadius = 10;
            this.btnSua.CheckedState.Parent = this.btnSua;
            this.btnSua.CustomImages.Parent = this.btnSua;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.HoverState.Parent = this.btnSua;
            this.btnSua.Location = new System.Drawing.Point(726, 166);
            this.btnSua.Name = "btnSua";
            this.btnSua.ShadowDecoration.Parent = this.btnSua;
            this.btnSua.Size = new System.Drawing.Size(180, 45);
            this.btnSua.TabIndex = 113;
            this.btnSua.Text = "Sửa lịch công tác";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 10;
            this.btnXoa.CheckedState.Parent = this.btnXoa;
            this.btnXoa.CustomImages.Parent = this.btnXoa;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.HoverState.Parent = this.btnXoa;
            this.btnXoa.Location = new System.Drawing.Point(512, 232);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Parent = this.btnXoa;
            this.btnXoa.Size = new System.Drawing.Size(180, 45);
            this.btnXoa.TabIndex = 112;
            this.btnXoa.Text = "Xóa lịch công tác";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 10;
            this.btnThem.CheckedState.Parent = this.btnThem;
            this.btnThem.CustomImages.Parent = this.btnThem;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.HoverState.Parent = this.btnThem;
            this.btnThem.Location = new System.Drawing.Point(512, 166);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(180, 45);
            this.btnThem.TabIndex = 111;
            this.btnThem.Text = "Thêm lịch công tác";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // guna2ButtonHienThi
            // 
            this.guna2ButtonHienThi.BorderRadius = 10;
            this.guna2ButtonHienThi.CheckedState.Parent = this.guna2ButtonHienThi;
            this.guna2ButtonHienThi.CustomImages.Parent = this.guna2ButtonHienThi;
            this.guna2ButtonHienThi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2ButtonHienThi.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonHienThi.HoverState.Parent = this.guna2ButtonHienThi;
            this.guna2ButtonHienThi.Location = new System.Drawing.Point(512, 100);
            this.guna2ButtonHienThi.Name = "guna2ButtonHienThi";
            this.guna2ButtonHienThi.ShadowDecoration.Parent = this.guna2ButtonHienThi;
            this.guna2ButtonHienThi.Size = new System.Drawing.Size(180, 45);
            this.guna2ButtonHienThi.TabIndex = 115;
            this.guna2ButtonHienThi.Text = "Hiển thị tất cả";
            this.guna2ButtonHienThi.Click += new System.EventHandler(this.guna2ButtonHienThi_Click);
            // 
            // guna2ButtonLamSach
            // 
            this.guna2ButtonLamSach.BorderRadius = 10;
            this.guna2ButtonLamSach.CheckedState.Parent = this.guna2ButtonLamSach;
            this.guna2ButtonLamSach.CustomImages.Parent = this.guna2ButtonLamSach;
            this.guna2ButtonLamSach.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2ButtonLamSach.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonLamSach.HoverState.Parent = this.guna2ButtonLamSach;
            this.guna2ButtonLamSach.Location = new System.Drawing.Point(726, 100);
            this.guna2ButtonLamSach.Name = "guna2ButtonLamSach";
            this.guna2ButtonLamSach.ShadowDecoration.Parent = this.guna2ButtonLamSach;
            this.guna2ButtonLamSach.Size = new System.Drawing.Size(180, 45);
            this.guna2ButtonLamSach.TabIndex = 116;
            this.guna2ButtonLamSach.Text = "Làm trống text box";
            this.guna2ButtonLamSach.Click += new System.EventHandler(this.guna2ButtonLamSach_Click);
            // 
            // dtgCongTac
            // 
            this.dtgCongTac.AllowUserToAddRows = false;
            this.dtgCongTac.AllowUserToDeleteRows = false;
            this.dtgCongTac.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgCongTac.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgCongTac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCongTac.BackgroundColor = System.Drawing.Color.White;
            this.dtgCongTac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgCongTac.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgCongTac.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgCongTac.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgCongTac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCongTac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgCongTac.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgCongTac.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgCongTac.EnableHeadersVisualStyles = false;
            this.dtgCongTac.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgCongTac.Location = new System.Drawing.Point(157, 359);
            this.dtgCongTac.MultiSelect = false;
            this.dtgCongTac.Name = "dtgCongTac";
            this.dtgCongTac.RowHeadersVisible = false;
            this.dtgCongTac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCongTac.Size = new System.Drawing.Size(614, 150);
            this.dtgCongTac.TabIndex = 117;
            this.dtgCongTac.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtgCongTac.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgCongTac.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgCongTac.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgCongTac.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgCongTac.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgCongTac.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgCongTac.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgCongTac.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgCongTac.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgCongTac.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgCongTac.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgCongTac.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCongTac.ThemeStyle.HeaderStyle.Height = 21;
            this.dtgCongTac.ThemeStyle.ReadOnly = false;
            this.dtgCongTac.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgCongTac.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgCongTac.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgCongTac.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgCongTac.ThemeStyle.RowsStyle.Height = 22;
            this.dtgCongTac.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgCongTac.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgCongTac.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCongTac_CellClick_1);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "manv";
            this.Column1.HeaderText = "Mã nhân viên";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ngaycongtac";
            this.Column2.HeaderText = "Ngày công tác";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "noicongtac";
            this.Column3.HeaderText = "Nơi công tác";
            this.Column3.Name = "Column3";
            // 
            // UC_CongTac
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dtgCongTac);
            this.Controls.Add(this.guna2ButtonLamSach);
            this.Controls.Add(this.guna2ButtonHienThi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.cbbmanv);
            this.Controls.Add(this.dtpngaycongtac);
            this.Controls.Add(this.txtNoiCongTac);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_CongTac";
            this.Size = new System.Drawing.Size(1011, 681);
            this.Load += new System.EventHandler(this.UC_CongTac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCongTac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ComboBox cbbmanv;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpngaycongtac;
        private Guna.UI2.WinForms.Guna2TextBox txtNoiCongTac;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonLamSach;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonHienThi;
        private Guna.UI2.WinForms.Guna2DataGridView dtgCongTac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
