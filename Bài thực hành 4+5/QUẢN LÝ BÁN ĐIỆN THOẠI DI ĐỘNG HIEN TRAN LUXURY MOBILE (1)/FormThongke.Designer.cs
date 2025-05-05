namespace QUẢN_LÝ_BÁN_ĐIỆN_THOẠI_DI_ĐỘNG_HIEN_TRAN_LUXURY_MOBILE
{
    partial class FormThongke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThongke));
            this.txtThang = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.txtNgay = new System.Windows.Forms.TextBox();
            this.labelNam = new System.Windows.Forms.Label();
            this.labelThang = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radGiaTien = new System.Windows.Forms.RadioButton();
            this.radSoLuong = new System.Windows.Forms.RadioButton();
            this.radMa = new System.Windows.Forms.RadioButton();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnSapXepGiam = new System.Windows.Forms.Button();
            this.btnSapXepTang = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnTongGT = new System.Windows.Forms.Button();
            this.btnTongsl = new System.Windows.Forms.Button();
            this.Ds_ThongKe = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Ds_ThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(174, 425);
            this.txtThang.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(101, 22);
            this.txtThang.TabIndex = 45;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(301, 425);
            this.txtNam.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(101, 22);
            this.txtNam.TabIndex = 44;
            // 
            // txtNgay
            // 
            this.txtNgay.Location = new System.Drawing.Point(50, 425);
            this.txtNgay.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(101, 22);
            this.txtNgay.TabIndex = 43;
            // 
            // labelNam
            // 
            this.labelNam.AutoSize = true;
            this.labelNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelNam.Location = new System.Drawing.Point(314, 385);
            this.labelNam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNam.Name = "labelNam";
            this.labelNam.Size = new System.Drawing.Size(53, 20);
            this.labelNam.TabIndex = 41;
            this.labelNam.Text = "Năm:";
            // 
            // labelThang
            // 
            this.labelThang.AutoSize = true;
            this.labelThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelThang.Location = new System.Drawing.Point(189, 385);
            this.labelThang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelThang.Name = "labelThang";
            this.labelThang.Size = new System.Drawing.Size(66, 20);
            this.labelThang.TabIndex = 40;
            this.labelThang.Text = "Tháng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(70, 385);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Ngày:";
            // 
            // radGiaTien
            // 
            this.radGiaTien.AutoSize = true;
            this.radGiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radGiaTien.Location = new System.Drawing.Point(301, 323);
            this.radGiaTien.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radGiaTien.Name = "radGiaTien";
            this.radGiaTien.Size = new System.Drawing.Size(96, 24);
            this.radGiaTien.TabIndex = 35;
            this.radGiaTien.TabStop = true;
            this.radGiaTien.Text = "Giá tiền";
            this.radGiaTien.UseVisualStyleBackColor = true;
            // 
            // radSoLuong
            // 
            this.radSoLuong.AutoSize = true;
            this.radSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radSoLuong.Location = new System.Drawing.Point(162, 323);
            this.radSoLuong.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radSoLuong.Name = "radSoLuong";
            this.radSoLuong.Size = new System.Drawing.Size(103, 24);
            this.radSoLuong.TabIndex = 34;
            this.radSoLuong.TabStop = true;
            this.radSoLuong.Text = "Số lượng";
            this.radSoLuong.UseVisualStyleBackColor = true;
            // 
            // radMa
            // 
            this.radMa.AutoSize = true;
            this.radMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radMa.Location = new System.Drawing.Point(59, 320);
            this.radMa.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radMa.Name = "radMa";
            this.radMa.Size = new System.Drawing.Size(55, 24);
            this.radMa.TabIndex = 33;
            this.radMa.TabStop = true;
            this.radMa.Text = "Mã";
            this.radMa.UseVisualStyleBackColor = true;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThongKe.Location = new System.Drawing.Point(598, 389);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(179, 65);
            this.btnThongKe.TabIndex = 30;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            // 
            // btnSapXepGiam
            // 
            this.btnSapXepGiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSapXepGiam.Location = new System.Drawing.Point(598, 307);
            this.btnSapXepGiam.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSapXepGiam.Name = "btnSapXepGiam";
            this.btnSapXepGiam.Size = new System.Drawing.Size(179, 54);
            this.btnSapXepGiam.TabIndex = 37;
            this.btnSapXepGiam.Text = "Sắp xếp giảm";
            this.btnSapXepGiam.UseVisualStyleBackColor = true;
            // 
            // btnSapXepTang
            // 
            this.btnSapXepTang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSapXepTang.Location = new System.Drawing.Point(409, 307);
            this.btnSapXepTang.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSapXepTang.Name = "btnSapXepTang";
            this.btnSapXepTang.Size = new System.Drawing.Size(181, 54);
            this.btnSapXepTang.TabIndex = 36;
            this.btnSapXepTang.Text = "Sắp xếp tăng";
            this.btnSapXepTang.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(1001, 21);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(80, 66);
            this.btnHome.TabIndex = 39;
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.Location = new System.Drawing.Point(1023, 450);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(68, 66);
            this.btnLoad.TabIndex = 38;
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnTongGT
            // 
            this.btnTongGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTongGT.Location = new System.Drawing.Point(781, 385);
            this.btnTongGT.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTongGT.Name = "btnTongGT";
            this.btnTongGT.Size = new System.Drawing.Size(238, 74);
            this.btnTongGT.TabIndex = 32;
            this.btnTongGT.Text = "Tổng giá tiền đã bán";
            this.btnTongGT.UseVisualStyleBackColor = true;
            // 
            // btnTongsl
            // 
            this.btnTongsl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTongsl.Location = new System.Drawing.Point(781, 297);
            this.btnTongsl.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTongsl.Name = "btnTongsl";
            this.btnTongsl.Size = new System.Drawing.Size(238, 65);
            this.btnTongsl.TabIndex = 31;
            this.btnTongsl.Text = "Tổng số lượng đã bán";
            this.btnTongsl.UseVisualStyleBackColor = true;
            // 
            // Ds_ThongKe
            // 
            this.Ds_ThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Ds_ThongKe.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Ds_ThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Ds_ThongKe.Location = new System.Drawing.Point(29, 107);
            this.Ds_ThongKe.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Ds_ThongKe.Name = "Ds_ThongKe";
            this.Ds_ThongKe.RowHeadersWidth = 51;
            this.Ds_ThongKe.RowTemplate.Height = 24;
            this.Ds_ThongKe.Size = new System.Drawing.Size(1073, 169);
            this.Ds_ThongKe.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1178, 93);
            this.label2.TabIndex = 28;
            this.label2.Text = "Danh sách sản phẩm đã bán";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormThongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 525);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.txtNgay);
            this.Controls.Add(this.labelNam);
            this.Controls.Add(this.labelThang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radGiaTien);
            this.Controls.Add(this.radSoLuong);
            this.Controls.Add(this.radMa);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnSapXepGiam);
            this.Controls.Add(this.btnSapXepTang);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnTongGT);
            this.Controls.Add(this.btnTongsl);
            this.Controls.Add(this.Ds_ThongKe);
            this.Controls.Add(this.label2);
            this.Name = "FormThongke";
            this.Text = "FormThongke";
            ((System.ComponentModel.ISupportInitialize)(this.Ds_ThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.TextBox txtNgay;
        private System.Windows.Forms.Label labelNam;
        private System.Windows.Forms.Label labelThang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radGiaTien;
        private System.Windows.Forms.RadioButton radSoLuong;
        private System.Windows.Forms.RadioButton radMa;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnSapXepGiam;
        private System.Windows.Forms.Button btnSapXepTang;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnTongGT;
        private System.Windows.Forms.Button btnTongsl;
        private System.Windows.Forms.DataGridView Ds_ThongKe;
        private System.Windows.Forms.Label label2;
    }
}