using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLPhongTro
{
    public partial class frmDangNhap : Form
    {
        public string tendangnhap = "";
        public string matkhau = "";
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void ptbExit_Click(object sender, EventArgs e)
        {
            //this.Dispose();
            Application.Exit();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Dispose();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDangNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!!!", "Tài khoản không được để trống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDangNhap.Select();
                return;
            }
            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!!!","Mật khẩu không thể để trống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Select();
                return;
            }

            tendangnhap = txtDangNhap.Text;
            matkhau = txtMatKhau.Text;

            var lstPara = new List<CustomParameter>()
                {
                    new CustomParameter
                    {
                    key = "@taiKhoan",
                    value = txtDangNhap.Text
                    },

                    new CustomParameter
                    {
                    key = "@matKhau",
                    value = txtMatKhau.Text
                    }
                };
            var rs =new Database().SelectData("dangNhap", lstPara);
            if (rs.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
