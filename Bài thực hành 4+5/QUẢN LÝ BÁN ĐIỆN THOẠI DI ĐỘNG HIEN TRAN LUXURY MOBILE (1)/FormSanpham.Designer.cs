namespace QUẢN_LÝ_BÁN_ĐIỆN_THOẠI_DI_ĐỘNG_HIEN_TRAN_LUXURY_MOBILE
{
    partial class FormSanpham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSanpham));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThemVaoGioHang = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dsSanPham = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dsSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.label1.Location = new System.Drawing.Point(-98, 463);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tên sản phẩm:";
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Location = new System.Drawing.Point(44, 456);
            this.txtTenSanPham.Margin = new System.Windows.Forms.Padding(5);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(203, 22);
            this.txtTenSanPham.TabIndex = 19;
            // 
            // btnLoad
            // 
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.Location = new System.Drawing.Point(764, 431);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(5);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(110, 107);
            this.btnLoad.TabIndex = 18;
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(920, 431);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(113, 107);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnThemVaoGioHang
            // 
            this.btnThemVaoGioHang.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemVaoGioHang.Image = ((System.Drawing.Image)(resources.GetObject("btnThemVaoGioHang.Image")));
            this.btnThemVaoGioHang.Location = new System.Drawing.Point(575, 436);
            this.btnThemVaoGioHang.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.btnThemVaoGioHang.Name = "btnThemVaoGioHang";
            this.btnThemVaoGioHang.Size = new System.Drawing.Size(141, 102);
            this.btnThemVaoGioHang.TabIndex = 16;
            this.btnThemVaoGioHang.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(265, 436);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(86, 58);
            this.btnTimKiem.TabIndex = 15;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // dsSanPham
            // 
            this.dsSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dsSanPham.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dsSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsSanPham.Location = new System.Drawing.Point(44, 3);
            this.dsSanPham.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.dsSanPham.Name = "dsSanPham";
            this.dsSanPham.ReadOnly = true;
            this.dsSanPham.RowHeadersWidth = 51;
            this.dsSanPham.RowTemplate.Height = 24;
            this.dsSanPham.Size = new System.Drawing.Size(1106, 395);
            this.dsSanPham.TabIndex = 14;
            // 
            // FormSanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 571);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenSanPham);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThemVaoGioHang);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dsSanPham);
            this.Name = "FormSanpham";
            this.Text = "FormSanpham";
            ((System.ComponentModel.ISupportInitialize)(this.dsSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThemVaoGioHang;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dsSanPham;
    }
}