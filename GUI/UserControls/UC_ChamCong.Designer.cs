namespace QLNhanSu.UserControls
{
    partial class UC_ChamCong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ChamCong));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnxuatfile = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtpngaycong = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtghichu = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtgrvchamcong = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbmanv = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnhienthi = new Guna.UI2.WinForms.Guna2Button();
            this.btnxuatluong = new Guna.UI2.WinForms.Guna2Button();
            this.btnreset = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvchamcong)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 26;
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnxuatfile
            // 
            this.btnxuatfile.BorderRadius = 10;
            this.btnxuatfile.CheckedState.Parent = this.btnxuatfile;
            this.btnxuatfile.CustomImages.Parent = this.btnxuatfile;
            this.btnxuatfile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxuatfile.ForeColor = System.Drawing.Color.White;
            this.btnxuatfile.HoverState.Parent = this.btnxuatfile;
            this.btnxuatfile.Location = new System.Drawing.Point(588, 236);
            this.btnxuatfile.Name = "btnxuatfile";
            this.btnxuatfile.ShadowDecoration.Parent = this.btnxuatfile;
            this.btnxuatfile.Size = new System.Drawing.Size(130, 36);
            this.btnxuatfile.TabIndex = 107;
            this.btnxuatfile.Text = "Xuất file";
            this.btnxuatfile.Click += new System.EventHandler(this.btnxuatfile_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(353, 19);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(361, 53);
            this.guna2HtmlLabel1.TabIndex = 77;
            this.guna2HtmlLabel1.Text = "Quản lý chấm công";
            // 
            // dtpngaycong
            // 
            this.dtpngaycong.BorderRadius = 10;
            this.dtpngaycong.CheckedState.Parent = this.dtpngaycong;
            this.dtpngaycong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dtpngaycong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpngaycong.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpngaycong.HoverState.Parent = this.dtpngaycong;
            this.dtpngaycong.Location = new System.Drawing.Point(206, 176);
            this.dtpngaycong.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpngaycong.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpngaycong.Name = "dtpngaycong";
            this.dtpngaycong.ShadowDecoration.Parent = this.dtpngaycong;
            this.dtpngaycong.Size = new System.Drawing.Size(200, 30);
            this.dtpngaycong.TabIndex = 101;
            this.dtpngaycong.Value = new System.DateTime(2020, 8, 26, 17, 28, 52, 796);
            // 
            // txtghichu
            // 
            this.txtghichu.BorderRadius = 10;
            this.txtghichu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtghichu.DefaultText = "";
            this.txtghichu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtghichu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtghichu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtghichu.DisabledState.Parent = this.txtghichu;
            this.txtghichu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtghichu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtghichu.FocusedState.Parent = this.txtghichu;
            this.txtghichu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtghichu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtghichu.HoverState.Parent = this.txtghichu;
            this.txtghichu.Location = new System.Drawing.Point(206, 248);
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.PasswordChar = '\0';
            this.txtghichu.PlaceholderText = "";
            this.txtghichu.SelectedText = "";
            this.txtghichu.ShadowDecoration.Parent = this.txtghichu;
            this.txtghichu.Size = new System.Drawing.Size(200, 24);
            this.txtghichu.TabIndex = 102;
            // 
            // dtgrvchamcong
            // 
            this.dtgrvchamcong.AllowUserToOrderColumns = true;
            this.dtgrvchamcong.AllowUserToResizeColumns = false;
            this.dtgrvchamcong.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgrvchamcong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgrvchamcong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrvchamcong.BackgroundColor = System.Drawing.Color.White;
            this.dtgrvchamcong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgrvchamcong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgrvchamcong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrvchamcong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgrvchamcong.ColumnHeadersHeight = 25;
            this.dtgrvchamcong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrvchamcong.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgrvchamcong.EnableHeadersVisualStyles = false;
            this.dtgrvchamcong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgrvchamcong.Location = new System.Drawing.Point(128, 351);
            this.dtgrvchamcong.Name = "dtgrvchamcong";
            this.dtgrvchamcong.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrvchamcong.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgrvchamcong.RowHeadersVisible = false;
            this.dtgrvchamcong.RowHeadersWidth = 40;
            this.dtgrvchamcong.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgrvchamcong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrvchamcong.Size = new System.Drawing.Size(735, 239);
            this.dtgrvchamcong.TabIndex = 77;
            this.dtgrvchamcong.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtgrvchamcong.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgrvchamcong.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgrvchamcong.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgrvchamcong.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgrvchamcong.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgrvchamcong.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgrvchamcong.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgrvchamcong.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgrvchamcong.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgrvchamcong.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgrvchamcong.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgrvchamcong.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgrvchamcong.ThemeStyle.HeaderStyle.Height = 25;
            this.dtgrvchamcong.ThemeStyle.ReadOnly = true;
            this.dtgrvchamcong.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgrvchamcong.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgrvchamcong.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgrvchamcong.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgrvchamcong.ThemeStyle.RowsStyle.Height = 22;
            this.dtgrvchamcong.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgrvchamcong.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgrvchamcong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrvchamcong_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "manv";
            this.Column1.HeaderText = "Mã nhân viên";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "tennv";
            this.Column4.HeaderText = "Tên nhân viên";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ngaycong";
            this.Column2.HeaderText = "Ngày công";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ghichu";
            this.Column3.HeaderText = "Ghi chú";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BorderRadius = 10;
            this.btnTimKiem.CheckedState.Parent = this.btnTimKiem;
            this.btnTimKiem.CustomImages.Parent = this.btnTimKiem;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.HoverState.Parent = this.btnTimKiem;
            this.btnTimKiem.Location = new System.Drawing.Point(779, 170);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.ShadowDecoration.Parent = this.btnTimKiem;
            this.btnTimKiem.Size = new System.Drawing.Size(130, 36);
            this.btnTimKiem.TabIndex = 106;
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
            this.btnSua.Location = new System.Drawing.Point(588, 170);
            this.btnSua.Name = "btnSua";
            this.btnSua.ShadowDecoration.Parent = this.btnSua;
            this.btnSua.Size = new System.Drawing.Size(130, 36);
            this.btnSua.TabIndex = 104;
            this.btnSua.Text = "Sửa";
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
            this.btnXoa.Location = new System.Drawing.Point(779, 104);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Parent = this.btnXoa;
            this.btnXoa.Size = new System.Drawing.Size(130, 36);
            this.btnXoa.TabIndex = 105;
            this.btnXoa.Text = "Xóa";
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
            this.btnThem.Location = new System.Drawing.Point(588, 104);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(130, 36);
            this.btnThem.TabIndex = 103;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(84, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 22);
            this.label6.TabIndex = 72;
            this.label6.Text = "Ghi chú";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(84, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 22);
            this.label5.TabIndex = 71;
            this.label5.Text = "Ngày công";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(84, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 22);
            this.label1.TabIndex = 70;
            this.label1.Text = "Mã nhân viên";
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
            this.cbbmanv.Location = new System.Drawing.Point(206, 104);
            this.cbbmanv.Name = "cbbmanv";
            this.cbbmanv.ShadowDecoration.Parent = this.cbbmanv;
            this.cbbmanv.Size = new System.Drawing.Size(200, 36);
            this.cbbmanv.TabIndex = 100;
            // 
            // btnhienthi
            // 
            this.btnhienthi.BorderRadius = 10;
            this.btnhienthi.CheckedState.Parent = this.btnhienthi;
            this.btnhienthi.CustomImages.Parent = this.btnhienthi;
            this.btnhienthi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhienthi.ForeColor = System.Drawing.Color.White;
            this.btnhienthi.HoverState.Parent = this.btnhienthi;
            this.btnhienthi.Location = new System.Drawing.Point(779, 236);
            this.btnhienthi.Name = "btnhienthi";
            this.btnhienthi.ShadowDecoration.Parent = this.btnhienthi;
            this.btnhienthi.Size = new System.Drawing.Size(130, 36);
            this.btnhienthi.TabIndex = 108;
            this.btnhienthi.Text = "Hiển thị";
            this.btnhienthi.Click += new System.EventHandler(this.btnhienthi_Click);
            // 
            // btnxuatluong
            // 
            this.btnxuatluong.BorderRadius = 10;
            this.btnxuatluong.CheckedState.Parent = this.btnxuatluong;
            this.btnxuatluong.CustomImages.Parent = this.btnxuatluong;
            this.btnxuatluong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxuatluong.ForeColor = System.Drawing.Color.White;
            this.btnxuatluong.HoverState.Parent = this.btnxuatluong;
            this.btnxuatluong.Location = new System.Drawing.Point(318, 626);
            this.btnxuatluong.Name = "btnxuatluong";
            this.btnxuatluong.ShadowDecoration.Parent = this.btnxuatluong;
            this.btnxuatluong.Size = new System.Drawing.Size(361, 36);
            this.btnxuatluong.TabIndex = 109;
            this.btnxuatluong.Text = "Xem bảng lương";
            this.btnxuatluong.Click += new System.EventHandler(this.btnxuatluong_Click);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.Transparent;
            this.btnreset.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnreset.CheckedState.Parent = this.btnreset;
            this.btnreset.HoverState.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            this.btnreset.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.btnreset.HoverState.Parent = this.btnreset;
            this.btnreset.Image = ((System.Drawing.Image)(resources.GetObject("btnreset.Image")));
            this.btnreset.ImageRotate = 0F;
            this.btnreset.ImageSize = new System.Drawing.Size(32, 32);
            this.btnreset.IndicateFocus = true;
            this.btnreset.Location = new System.Drawing.Point(449, 175);
            this.btnreset.Name = "btnreset";
            this.btnreset.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.btnreset.PressedState.Parent = this.btnreset;
            this.btnreset.Size = new System.Drawing.Size(34, 38);
            this.btnreset.TabIndex = 131;
            this.btnreset.UseTransparentBackground = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // UC_ChamCong
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnxuatluong);
            this.Controls.Add(this.btnhienthi);
            this.Controls.Add(this.cbbmanv);
            this.Controls.Add(this.btnxuatfile);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.dtpngaycong);
            this.Controls.Add(this.txtghichu);
            this.Controls.Add(this.dtgrvchamcong);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "UC_ChamCong";
            this.Size = new System.Drawing.Size(1011, 681);
            this.Load += new System.EventHandler(this.UC_ChamCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvchamcong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnxuatfile;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpngaycong;
        private Guna.UI2.WinForms.Guna2TextBox txtghichu;
        private Guna.UI2.WinForms.Guna2DataGridView dtgrvchamcong;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbbmanv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private Guna.UI2.WinForms.Guna2Button btnhienthi;
        private Guna.UI2.WinForms.Guna2Button btnxuatluong;
        private Guna.UI2.WinForms.Guna2ImageButton btnreset;
    }
}
