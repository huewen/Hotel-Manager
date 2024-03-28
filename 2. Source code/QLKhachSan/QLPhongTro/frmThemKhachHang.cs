using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPhongTro
{
    public partial class frmThemKhachHang : Form
    {
        private Database db;
        public frmThemKhachHang()
        {
            InitializeComponent();
        }

        private void frmThemKhachHang_Load(object sender, EventArgs e)
        {
            db = new Database();
            LoadKhachHang();

            #region gui
            //đặt lại tên cột
            dgvKhachHang.Columns["id"].HeaderText = "STT";
            dgvKhachHang.Columns["hoten"].HeaderText = "Họ tên";
            dgvKhachHang.Columns["cmnd"].HeaderText = "CMND";
            dgvKhachHang.Columns["diachi"].HeaderText = "Địa chỉ";
            dgvKhachHang.Columns["loaikhach"].HeaderText = "Loại khách";

            //set kích thước các cột
            dgvKhachHang.Columns["id"].Width = 50;
            dgvKhachHang.Columns["hoten"].Width = 200;
            dgvKhachHang.Columns["cmnd"].Width = 100;
            dgvKhachHang.Columns["diachi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//cho cột tên phòng tự động co giãn theo form
            dgvKhachHang.Columns["loaikhach"].Width = 100;
            #endregion
        }

        private void LoadKhachHang()
        {
            var dt = db.SelectData("loadLoaiKhach");
            cbbLoaikhach.DataSource = dt;
            cbbLoaikhach.DisplayMember = "LoaiKhach";
            cbbLoaikhach.ValueMember = "ID";
            dgvKhachHang.DataSource = db.SelectData("loadKhachHang");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var idLoaiKhach = cbbLoaikhach.SelectedValue.ToString();
            var hoTen = txtHoten.Text.Trim();
            var cmnd = txtCMND.Text.Trim();
            var diaChi = txtDiachi.Text.Trim();

            if (cbbLoaikhach.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại khách!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng nhập họ tên khách hàng!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(cmnd))
            {
                MessageBox.Show("Vui lòng nhập số CMND!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(diaChi))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var lstPra = new List<CustomParameter>()
                {
                    new CustomParameter
                    {
                    key = "@idLoaiKhach",
                    value = idLoaiKhach
                    },

                    new CustomParameter
                    {
                    key = "@hoTen",
                    value = hoTen
                    },

                    new CustomParameter
                    {
                    key = "@cmnd",
                    value = cmnd
                    },

                    new CustomParameter
                    {
                    key = "@diaChi",
                    value = diaChi
                    }
                };

            var rs = db.ExeCute("themKhachHang", lstPra);
            if (rs == 1)
            {
                MessageBox.Show("Thêm mới khách hàng thành công!", "Succecfully!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadKhachHang();
            }
            else
            {
                MessageBox.Show("Thêm khách hàng không thành công!", "Fail!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ptbExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
