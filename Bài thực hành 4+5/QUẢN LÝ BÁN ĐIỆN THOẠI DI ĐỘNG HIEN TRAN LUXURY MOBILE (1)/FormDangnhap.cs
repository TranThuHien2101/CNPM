using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUẢN_LÝ_BÁN_ĐIỆN_THOẠI_DI_ĐỘNG_HIEN_TRAN_LUXURY_MOBILE
{
    public partial class FormDangnhap : Form
    {
        public FormDangnhap()
        {
            InitializeComponent();
        }

        private void Trang_chủ_Load(object sender, EventArgs e)
        {
            string lenh = $"select CustomerID, Password  from DangNhap where CustomerID = '{txtDangnhap.Text.Trim()}' and Password = '{txtMatkhau.Text.Trim()}'";
            dt = DatabaseAccess.GetDataTable(lenh);
        }
        private void btDangnhap_Click(object sender, EventArgs e)
        {
            Check();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    string tenDangNhap = row["CustomerID"].ToString().Trim();
                    string matKhau = row["Password"].ToString().Trim();

                    if (txtDangnhap.Text.Trim() == tenDangNhap && txtMatkhau.Text.Trim() == matKhau)
                    {
                        // Dữ liệu trùng khớp
                        MessageBox.Show("Đăng nhập thành công!");
                        FormTrangchu formTrangChu = new FormTrangchu();
                        this.Hide();
                        formTrangChu.ShowDialog();
                        this.Close();
                        return; // Kết thúc vòng lặp nếu dữ liệu trùng khớp
                    }
                    else
                    {
                        // Dữ liệu không trùng khớp hoặc DataTable rỗng
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!");
                    }
                }
            }
        }

        private void txtMatkhau_TextChanged(object sender, EventArgs e)
        {
            
                //thuộc tính PasswordChar thay hết kí tự nhập vào textbox thành kí tự * hết
                txtMatkhau.PasswordChar = '*';
        }
        private bool isButtonClicked = false; // Biến để theo dõi trạng thái button
        private void btnHienMatKhau_Click(object sender, EventArgs e)
        {
            if (isButtonClicked) // Kiểm tra trạng thái của button
            {
                txtMatkhau.PasswordChar = '*'; // Ẩn mật khẩu bằng kí tự '*'
                isButtonClicked = false; // Đặt lại trạng thái button
            }
            else
            {
                txtMatkhau.PasswordChar = '\0'; // Hiển thị mật khẩu trên textbox
                isButtonClicked = true; // Đặt lại trạng thái button
            }
        }

        
    }
}

