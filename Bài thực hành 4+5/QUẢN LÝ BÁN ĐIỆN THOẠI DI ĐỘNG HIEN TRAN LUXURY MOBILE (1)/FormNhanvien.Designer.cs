namespace QUẢN_LÝ_BÁN_ĐIỆN_THOẠI_DI_ĐỘNG_HIEN_TRAN_LUXURY_MOBILE
{
    partial class FormNhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhanvien));
            System.Windows.Forms.Label gioiTinhLabel;
            System.Windows.Forms.Label ngayVaoLamLabel;
            System.Windows.Forms.Label chucVuLabel;
            System.Windows.Forms.Label sDT_NVLabel;
            System.Windows.Forms.Label diaChiNVLabel;
            System.Windows.Forms.Label tenNVLabel;
            System.Windows.Forms.Label maNVLabel;
            this.gioiTinhComboBox = new System.Windows.Forms.ComboBox();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chucVuComboBox = new System.Windows.Forms.ComboBox();
            this.sDT_NVTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hinhAnhPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ngayVaoLamDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.diaChiNVTextBox = new System.Windows.Forms.TextBox();
            this.tenNVTextBox = new System.Windows.Forms.TextBox();
            this.maNVTextBox = new System.Windows.Forms.TextBox();
            this.nHANVIENDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nHANVIENBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.nHANVIENBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            gioiTinhLabel = new System.Windows.Forms.Label();
            ngayVaoLamLabel = new System.Windows.Forms.Label();
            chucVuLabel = new System.Windows.Forms.Label();
            sDT_NVLabel = new System.Windows.Forms.Label();
            diaChiNVLabel = new System.Windows.Forms.Label();
            tenNVLabel = new System.Windows.Forms.Label();
            maNVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinhAnhPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingNavigator)).BeginInit();
            this.nHANVIENBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // gioiTinhComboBox
            // 
            this.gioiTinhComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHANVIENBindingSource, "GioiTinh", true));
            this.gioiTinhComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gioiTinhComboBox.FormattingEnabled = true;
            this.gioiTinhComboBox.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.gioiTinhComboBox.Location = new System.Drawing.Point(34, 258);
            this.gioiTinhComboBox.Name = "gioiTinhComboBox";
            this.gioiTinhComboBox.Size = new System.Drawing.Size(280, 33);
            this.gioiTinhComboBox.TabIndex = 14;
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            // 
            // chucVuComboBox
            // 
            this.chucVuComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHANVIENBindingSource, "ChucVu", true));
            this.chucVuComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chucVuComboBox.FormattingEnabled = true;
            this.chucVuComboBox.Items.AddRange(new object[] {
            "Nhân viên",
            "Quản lý"});
            this.chucVuComboBox.Location = new System.Drawing.Point(384, 167);
            this.chucVuComboBox.Name = "chucVuComboBox";
            this.chucVuComboBox.Size = new System.Drawing.Size(280, 33);
            this.chucVuComboBox.TabIndex = 10;
            // 
            // sDT_NVTextBox
            // 
            this.sDT_NVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHANVIENBindingSource, "SDT_NV", true));
            this.sDT_NVTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sDT_NVTextBox.Location = new System.Drawing.Point(384, 70);
            this.sDT_NVTextBox.Multiline = true;
            this.sDT_NVTextBox.Name = "sDT_NVTextBox";
            this.sDT_NVTextBox.Size = new System.Drawing.Size(280, 31);
            this.sDT_NVTextBox.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1073, 48);
            this.panel1.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(886, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mã nhân viên",
            "Tên nhân viên"});
            this.comboBox1.Location = new System.Drawing.Point(194, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 33);
            this.comboBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox1.Location = new System.Drawing.Point(600, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 36);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tìm kiếm theo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(410, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập thông tin";
            // 
            // groupBox2
            // 
            this.groupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.hinhAnhPictureBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(39, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 404);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ảnh";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(111, 323);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // hinhAnhPictureBox
            // 
            this.hinhAnhPictureBox.BackColor = System.Drawing.Color.White;
            this.hinhAnhPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.nHANVIENBindingSource, "HinhAnh", true));
            this.hinhAnhPictureBox.Location = new System.Drawing.Point(41, 33);
            this.hinhAnhPictureBox.Name = "hinhAnhPictureBox";
            this.hinhAnhPictureBox.Size = new System.Drawing.Size(228, 284);
            this.hinhAnhPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hinhAnhPictureBox.TabIndex = 17;
            this.hinhAnhPictureBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(gioiTinhLabel);
            this.groupBox1.Controls.Add(this.gioiTinhComboBox);
            this.groupBox1.Controls.Add(ngayVaoLamLabel);
            this.groupBox1.Controls.Add(this.ngayVaoLamDateTimePicker);
            this.groupBox1.Controls.Add(chucVuLabel);
            this.groupBox1.Controls.Add(this.chucVuComboBox);
            this.groupBox1.Controls.Add(sDT_NVLabel);
            this.groupBox1.Controls.Add(this.sDT_NVTextBox);
            this.groupBox1.Controls.Add(diaChiNVLabel);
            this.groupBox1.Controls.Add(this.diaChiNVTextBox);
            this.groupBox1.Controls.Add(tenNVLabel);
            this.groupBox1.Controls.Add(this.tenNVTextBox);
            this.groupBox1.Controls.Add(maNVLabel);
            this.groupBox1.Controls.Add(this.maNVTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(357, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 404);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cơ bản";
            // 
            // gioiTinhLabel
            // 
            gioiTinhLabel.AutoSize = true;
            gioiTinhLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            gioiTinhLabel.Location = new System.Drawing.Point(39, 218);
            gioiTinhLabel.Name = "gioiTinhLabel";
            gioiTinhLabel.Size = new System.Drawing.Size(82, 25);
            gioiTinhLabel.TabIndex = 13;
            gioiTinhLabel.Text = "Giới tính";
            // 
            // ngayVaoLamLabel
            // 
            ngayVaoLamLabel.AutoSize = true;
            ngayVaoLamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            ngayVaoLamLabel.Location = new System.Drawing.Point(379, 235);
            ngayVaoLamLabel.Name = "ngayVaoLamLabel";
            ngayVaoLamLabel.Size = new System.Drawing.Size(131, 25);
            ngayVaoLamLabel.TabIndex = 11;
            ngayVaoLamLabel.Text = "Ngày vào làm";
            // 
            // ngayVaoLamDateTimePicker
            // 
            this.ngayVaoLamDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.nHANVIENBindingSource, "NgayVaoLam", true));
            this.ngayVaoLamDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ngayVaoLamDateTimePicker.Location = new System.Drawing.Point(384, 275);
            this.ngayVaoLamDateTimePicker.Name = "ngayVaoLamDateTimePicker";
            this.ngayVaoLamDateTimePicker.Size = new System.Drawing.Size(280, 30);
            this.ngayVaoLamDateTimePicker.TabIndex = 12;
            // 
            // chucVuLabel
            // 
            chucVuLabel.AutoSize = true;
            chucVuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            chucVuLabel.Location = new System.Drawing.Point(379, 127);
            chucVuLabel.Name = "chucVuLabel";
            chucVuLabel.Size = new System.Drawing.Size(85, 25);
            chucVuLabel.TabIndex = 9;
            chucVuLabel.Text = "Chức vụ";
            // 
            // sDT_NVLabel
            // 
            sDT_NVLabel.AutoSize = true;
            sDT_NVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            sDT_NVLabel.Location = new System.Drawing.Point(379, 42);
            sDT_NVLabel.Name = "sDT_NVLabel";
            sDT_NVLabel.Size = new System.Drawing.Size(126, 25);
            sDT_NVLabel.TabIndex = 7;
            sDT_NVLabel.Text = "Số điện thoại";
            // 
            // diaChiNVLabel
            // 
            diaChiNVLabel.AutoSize = true;
            diaChiNVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            diaChiNVLabel.Location = new System.Drawing.Point(39, 318);
            diaChiNVLabel.Name = "diaChiNVLabel";
            diaChiNVLabel.Size = new System.Drawing.Size(71, 25);
            diaChiNVLabel.TabIndex = 5;
            diaChiNVLabel.Text = "Địa chỉ";
            // 
            // diaChiNVTextBox
            // 
            this.diaChiNVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHANVIENBindingSource, "DiaChiNV", true));
            this.diaChiNVTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.diaChiNVTextBox.Location = new System.Drawing.Point(34, 355);
            this.diaChiNVTextBox.Multiline = true;
            this.diaChiNVTextBox.Name = "diaChiNVTextBox";
            this.diaChiNVTextBox.Size = new System.Drawing.Size(280, 40);
            this.diaChiNVTextBox.TabIndex = 6;
            // 
            // tenNVLabel
            // 
            tenNVLabel.AutoSize = true;
            tenNVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            tenNVLabel.Location = new System.Drawing.Point(29, 127);
            tenNVLabel.Name = "tenNVLabel";
            tenNVLabel.Size = new System.Drawing.Size(137, 25);
            tenNVLabel.TabIndex = 3;
            tenNVLabel.Text = "Tên nhân viên";
            // 
            // tenNVTextBox
            // 
            this.tenNVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHANVIENBindingSource, "TenNV", true));
            this.tenNVTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tenNVTextBox.Location = new System.Drawing.Point(34, 167);
            this.tenNVTextBox.Multiline = true;
            this.tenNVTextBox.Name = "tenNVTextBox";
            this.tenNVTextBox.Size = new System.Drawing.Size(280, 31);
            this.tenNVTextBox.TabIndex = 4;
            // 
            // maNVLabel
            // 
            maNVLabel.AutoSize = true;
            maNVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            maNVLabel.Location = new System.Drawing.Point(29, 33);
            maNVLabel.Name = "maNVLabel";
            maNVLabel.Size = new System.Drawing.Size(130, 25);
            maNVLabel.TabIndex = 1;
            maNVLabel.Text = "Mã nhân viên";
            // 
            // maNVTextBox
            // 
            this.maNVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHANVIENBindingSource, "MaNV", true));
            this.maNVTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.maNVTextBox.Location = new System.Drawing.Point(34, 70);
            this.maNVTextBox.Multiline = true;
            this.maNVTextBox.Name = "maNVTextBox";
            this.maNVTextBox.Size = new System.Drawing.Size(280, 31);
            this.maNVTextBox.TabIndex = 2;
            // 
            // nHANVIENDataGridView
            // 
            this.nHANVIENDataGridView.AutoGenerateColumns = false;
            this.nHANVIENDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.nHANVIENDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nHANVIENDataGridView.DataSource = this.nHANVIENBindingSource;
            this.nHANVIENDataGridView.Location = new System.Drawing.Point(6, 37);
            this.nHANVIENDataGridView.Name = "nHANVIENDataGridView";
            this.nHANVIENDataGridView.RowHeadersWidth = 51;
            this.nHANVIENDataGridView.RowTemplate.Height = 24;
            this.nHANVIENDataGridView.Size = new System.Drawing.Size(1033, 282);
            this.nHANVIENDataGridView.TabIndex = 19;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nHANVIENDataGridView);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(12, 529);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1152, 347);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin nhân viên";
            // 
            // nHANVIENBindingNavigator
            // 
            this.nHANVIENBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.nHANVIENBindingNavigator.BackColor = System.Drawing.Color.White;
            this.nHANVIENBindingNavigator.BindingSource = this.nHANVIENBindingSource;
            this.nHANVIENBindingNavigator.CountItem = null;
            this.nHANVIENBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.nHANVIENBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.nHANVIENBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nHANVIENBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.nHANVIENBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.nHANVIENBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.bindingNavigatorAddNewItem,
            this.toolStripButton6,
            this.toolStripButton1,
            this.toolStripButton4,
            this.bindingNavigatorDeleteItem,
            this.toolStripButton5,
            this.nHANVIENBindingNavigatorSaveItem,
            this.toolStripButton7,
            this.toolStripButton2,
            this.toolStripSeparator,
            this.toolStripSeparator1});
            this.nHANVIENBindingNavigator.Location = new System.Drawing.Point(512, 485);
            this.nHANVIENBindingNavigator.MoveFirstItem = null;
            this.nHANVIENBindingNavigator.MoveLastItem = null;
            this.nHANVIENBindingNavigator.MoveNextItem = null;
            this.nHANVIENBindingNavigator.MovePreviousItem = null;
            this.nHANVIENBindingNavigator.Name = "nHANVIENBindingNavigator";
            this.nHANVIENBindingNavigator.Padding = new System.Windows.Forms.Padding(0);
            this.nHANVIENBindingNavigator.PositionItem = null;
            this.nHANVIENBindingNavigator.Size = new System.Drawing.Size(496, 41);
            this.nHANVIENBindingNavigator.TabIndex = 21;
            this.nHANVIENBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bindingNavigatorAddNewItem.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bindingNavigatorAddNewItem.Margin = new System.Windows.Forms.Padding(0);
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.Padding = new System.Windows.Forms.Padding(3);
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(82, 41);
            this.bindingNavigatorAddNewItem.Text = "Thêm";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bindingNavigatorDeleteItem.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bindingNavigatorDeleteItem.Margin = new System.Windows.Forms.Padding(0);
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.Padding = new System.Windows.Forms.Padding(3);
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(64, 41);
            this.bindingNavigatorDeleteItem.Text = "Xóa";
            // 
            // nHANVIENBindingNavigatorSaveItem
            // 
            this.nHANVIENBindingNavigatorSaveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.nHANVIENBindingNavigatorSaveItem.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nHANVIENBindingNavigatorSaveItem.Margin = new System.Windows.Forms.Padding(0);
            this.nHANVIENBindingNavigatorSaveItem.Name = "nHANVIENBindingNavigatorSaveItem";
            this.nHANVIENBindingNavigatorSaveItem.Padding = new System.Windows.Forms.Padding(3);
            this.nHANVIENBindingNavigatorSaveItem.Size = new System.Drawing.Size(62, 41);
            this.nHANVIENBindingNavigatorSaveItem.Text = "Lưu";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Padding = new System.Windows.Forms.Padding(3);
            this.toolStripButton1.Size = new System.Drawing.Size(63, 41);
            this.toolStripButton1.Text = "Sửa";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.toolStripButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Padding = new System.Windows.Forms.Padding(3);
            this.toolStripButton2.Size = new System.Drawing.Size(66, 41);
            this.toolStripButton2.Text = "Hủy";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 38);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(29, 38);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(29, 38);
            this.toolStripButton5.Text = "toolStripButton5";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(29, 38);
            this.toolStripButton7.Text = "toolStripButton7";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 41);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 41);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(29, 38);
            this.toolStripButton6.Text = "toolStripButton6";
            // 
            // FormNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1073, 1055);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.nHANVIENBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "FormNhanvien";
            this.Text = "FormNhanvien";
            this.Load += new System.EventHandler(this.FormNhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinhAnhPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingNavigator)).EndInit();
            this.nHANVIENBindingNavigator.ResumeLayout(false);
            this.nHANVIENBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox gioiTinhComboBox;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private System.Windows.Forms.ComboBox chucVuComboBox;
        private System.Windows.Forms.TextBox sDT_NVTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox hinhAnhPictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker ngayVaoLamDateTimePicker;
        private System.Windows.Forms.TextBox diaChiNVTextBox;
        private System.Windows.Forms.TextBox tenNVTextBox;
        private System.Windows.Forms.TextBox maNVTextBox;
        private System.Windows.Forms.DataGridView nHANVIENDataGridView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.BindingNavigator nHANVIENBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton nHANVIENBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
    }
}