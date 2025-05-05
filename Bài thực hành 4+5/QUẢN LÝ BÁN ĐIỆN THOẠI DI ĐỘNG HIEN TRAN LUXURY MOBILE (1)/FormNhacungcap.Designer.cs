namespace QUẢN_LÝ_BÁN_ĐIỆN_THOẠI_DI_ĐỘNG_HIEN_TRAN_LUXURY_MOBILE
{
    partial class FormNhacungcap
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
            System.Windows.Forms.Label sDTNCCLabel;
            System.Windows.Forms.Label diaChiNCCLabel;
            System.Windows.Forms.Label tenNCCLabel;
            System.Windows.Forms.Label maNCCLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhacungcap));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nHACUNGCAPDataGridView = new System.Windows.Forms.DataGridView();
            this.nHACUNGCAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sDTNCCTextBox = new System.Windows.Forms.TextBox();
            this.diaChiNCCTextBox = new System.Windows.Forms.TextBox();
            this.tenNCCTextBox = new System.Windows.Forms.TextBox();
            this.maNCCTextBox = new System.Windows.Forms.TextBox();
            this.huy = new System.Windows.Forms.ToolStripButton();
            this.nHACUNGCAPBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.nHACUNGCAPBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            sDTNCCLabel = new System.Windows.Forms.Label();
            diaChiNCCLabel = new System.Windows.Forms.Label();
            tenNCCLabel = new System.Windows.Forms.Label();
            maNCCLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHACUNGCAPDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHACUNGCAPBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHACUNGCAPBindingNavigator)).BeginInit();
            this.nHACUNGCAPBindingNavigator.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nHACUNGCAPDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(485, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(869, 501);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhà cung cấp";
            // 
            // nHACUNGCAPDataGridView
            // 
            this.nHACUNGCAPDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.nHACUNGCAPDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nHACUNGCAPDataGridView.Location = new System.Drawing.Point(19, 29);
            this.nHACUNGCAPDataGridView.Name = "nHACUNGCAPDataGridView";
            this.nHACUNGCAPDataGridView.RowHeadersWidth = 51;
            this.nHACUNGCAPDataGridView.RowTemplate.Height = 24;
            this.nHACUNGCAPDataGridView.Size = new System.Drawing.Size(822, 472);
            this.nHACUNGCAPDataGridView.TabIndex = 22;
            // 
            // nHACUNGCAPBindingSource
            // 
            this.nHACUNGCAPBindingSource.DataMember = "NHACUNGCAP";
            // 
            // sDTNCCTextBox
            // 
            this.sDTNCCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHACUNGCAPBindingSource, "SDTNCC", true));
            this.sDTNCCTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sDTNCCTextBox.Location = new System.Drawing.Point(25, 360);
            this.sDTNCCTextBox.Name = "sDTNCCTextBox";
            this.sDTNCCTextBox.Size = new System.Drawing.Size(330, 30);
            this.sDTNCCTextBox.TabIndex = 22;
            // 
            // diaChiNCCTextBox
            // 
            this.diaChiNCCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHACUNGCAPBindingSource, "DiaChiNCC", true));
            this.diaChiNCCTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.diaChiNCCTextBox.Location = new System.Drawing.Point(25, 271);
            this.diaChiNCCTextBox.Name = "diaChiNCCTextBox";
            this.diaChiNCCTextBox.Size = new System.Drawing.Size(330, 30);
            this.diaChiNCCTextBox.TabIndex = 21;
            // 
            // tenNCCTextBox
            // 
            this.tenNCCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHACUNGCAPBindingSource, "TenNCC", true));
            this.tenNCCTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tenNCCTextBox.Location = new System.Drawing.Point(25, 183);
            this.tenNCCTextBox.Name = "tenNCCTextBox";
            this.tenNCCTextBox.Size = new System.Drawing.Size(330, 30);
            this.tenNCCTextBox.TabIndex = 20;
            // 
            // maNCCTextBox
            // 
            this.maNCCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHACUNGCAPBindingSource, "MaNCC", true));
            this.maNCCTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.maNCCTextBox.Location = new System.Drawing.Point(25, 89);
            this.maNCCTextBox.Name = "maNCCTextBox";
            this.maNCCTextBox.Size = new System.Drawing.Size(330, 30);
            this.maNCCTextBox.TabIndex = 19;
            // 
            // huy
            // 
            this.huy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.huy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.huy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.huy.Name = "huy";
            this.huy.Size = new System.Drawing.Size(54, 32);
            this.huy.Text = "Hủy";
            // 
            // nHACUNGCAPBindingNavigatorSaveItem
            // 
            this.nHACUNGCAPBindingNavigatorSaveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.nHACUNGCAPBindingNavigatorSaveItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nHACUNGCAPBindingNavigatorSaveItem.Name = "nHACUNGCAPBindingNavigatorSaveItem";
            this.nHACUNGCAPBindingNavigatorSaveItem.Size = new System.Drawing.Size(51, 32);
            this.nHACUNGCAPBindingNavigatorSaveItem.Text = "Lưu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(sDTNCCLabel);
            this.groupBox1.Controls.Add(this.sDTNCCTextBox);
            this.groupBox1.Controls.Add(diaChiNCCLabel);
            this.groupBox1.Controls.Add(this.diaChiNCCTextBox);
            this.groupBox1.Controls.Add(tenNCCLabel);
            this.groupBox1.Controls.Add(this.tenNCCTextBox);
            this.groupBox1.Controls.Add(maNCCLabel);
            this.groupBox1.Controls.Add(this.maNCCTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(32, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 421);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhà cung cấp";
            // 
            // sDTNCCLabel
            // 
            sDTNCCLabel.AutoSize = true;
            sDTNCCLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            sDTNCCLabel.Location = new System.Drawing.Point(20, 320);
            sDTNCCLabel.Name = "sDTNCCLabel";
            sDTNCCLabel.Size = new System.Drawing.Size(126, 25);
            sDTNCCLabel.TabIndex = 21;
            sDTNCCLabel.Text = "Số điện thoại";
            // 
            // diaChiNCCLabel
            // 
            diaChiNCCLabel.AutoSize = true;
            diaChiNCCLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            diaChiNCCLabel.Location = new System.Drawing.Point(20, 234);
            diaChiNCCLabel.Name = "diaChiNCCLabel";
            diaChiNCCLabel.Size = new System.Drawing.Size(71, 25);
            diaChiNCCLabel.TabIndex = 20;
            diaChiNCCLabel.Text = "Địa chỉ";
            // 
            // tenNCCLabel
            // 
            tenNCCLabel.AutoSize = true;
            tenNCCLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            tenNCCLabel.Location = new System.Drawing.Point(20, 143);
            tenNCCLabel.Name = "tenNCCLabel";
            tenNCCLabel.Size = new System.Drawing.Size(96, 25);
            tenNCCLabel.TabIndex = 19;
            tenNCCLabel.Text = "Tên NCC";
            // 
            // maNCCLabel
            // 
            maNCCLabel.AutoSize = true;
            maNCCLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            maNCCLabel.Location = new System.Drawing.Point(20, 47);
            maNCCLabel.Name = "maNCCLabel";
            maNCCLabel.Size = new System.Drawing.Size(89, 25);
            maNCCLabel.TabIndex = 18;
            maNCCLabel.Text = "Mã NCC";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bindingNavigatorDeleteItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(52, 32);
            this.bindingNavigatorDeleteItem.Text = "Xóa";
            // 
            // nHACUNGCAPBindingNavigator
            // 
            this.nHACUNGCAPBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.nHACUNGCAPBindingNavigator.BindingSource = this.nHACUNGCAPBindingSource;
            this.nHACUNGCAPBindingNavigator.CountItem = null;
            this.nHACUNGCAPBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.nHACUNGCAPBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.nHACUNGCAPBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.nHACUNGCAPBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.nHACUNGCAPBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.bindingNavigatorAddNewItem,
            this.toolStripButton2,
            this.nHACUNGCAPBindingNavigatorSaveItem,
            this.toolStripButton3,
            this.bindingNavigatorDeleteItem,
            this.toolStripButton4,
            this.huy});
            this.nHACUNGCAPBindingNavigator.Location = new System.Drawing.Point(31, 503);
            this.nHACUNGCAPBindingNavigator.MoveFirstItem = null;
            this.nHACUNGCAPBindingNavigator.MoveLastItem = null;
            this.nHACUNGCAPBindingNavigator.MoveNextItem = null;
            this.nHACUNGCAPBindingNavigator.MovePreviousItem = null;
            this.nHACUNGCAPBindingNavigator.Name = "nHACUNGCAPBindingNavigator";
            this.nHACUNGCAPBindingNavigator.PositionItem = null;
            this.nHACUNGCAPBindingNavigator.Size = new System.Drawing.Size(345, 35);
            this.nHACUNGCAPBindingNavigator.TabIndex = 26;
            this.nHACUNGCAPBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bindingNavigatorAddNewItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(69, 32);
            this.bindingNavigatorAddNewItem.Text = "Thêm";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1013, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mã NCC",
            "Tên NCC"});
            this.comboBox1.Location = new System.Drawing.Point(266, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 33);
            this.comboBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox1.Location = new System.Drawing.Point(686, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(299, 37);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(71, 10);
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
            this.label1.Location = new System.Drawing.Point(480, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập thông tin";
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
            this.panel1.Size = new System.Drawing.Size(1427, 52);
            this.panel1.TabIndex = 25;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 32);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 42);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 32);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(29, 32);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // FormNhacungcap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1427, 742);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nHACUNGCAPBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "FormNhacungcap";
            this.Text = " ";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nHACUNGCAPDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHACUNGCAPBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHACUNGCAPBindingNavigator)).EndInit();
            this.nHACUNGCAPBindingNavigator.ResumeLayout(false);
            this.nHACUNGCAPBindingNavigator.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView nHACUNGCAPDataGridView;
        private System.Windows.Forms.BindingSource nHACUNGCAPBindingSource;
        private System.Windows.Forms.TextBox sDTNCCTextBox;
        private System.Windows.Forms.TextBox diaChiNCCTextBox;
        private System.Windows.Forms.TextBox tenNCCTextBox;
        private System.Windows.Forms.TextBox maNCCTextBox;
        private System.Windows.Forms.ToolStripButton huy;
        private System.Windows.Forms.ToolStripButton nHACUNGCAPBindingNavigatorSaveItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.BindingNavigator nHACUNGCAPBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
    }
}