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
    public partial class frmDanhMucPhong : Form
    {
        private Database db;
        private int maLoaiPhong = 0;

        public frmDanhMucPhong()
        {
            InitializeComponent();
        }

        private void frmDanhMucPhong_Load(object sender, EventArgs e)
        {
            db = new Database();
            LoadDmPhong();

            dgv_DMPhong.Columns[0].Width = 100; //set bề rộng cho cột id
            dgv_DMPhong.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_DMPhong.Columns[0].HeaderText = "STT";


            dgv_DMPhong.Columns[1].Width = 150;
            dgv_DMPhong.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_DMPhong.Columns[1].DefaultCellStyle.Format = "N0";
            dgv_DMPhong.Columns[1].HeaderText = "Loại phòng";

            dgv_DMPhong.Columns[2].Width = 200;
            dgv_DMPhong.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_DMPhong.Columns[2].DefaultCellStyle.Format = "N0";
            dgv_DMPhong.Columns[2].HeaderText = "Đơn giá";

            dgv_DMPhong.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_DMPhong.Columns[3].HeaderText = "Ghi chú";
        }

        private void LoadDmPhong()
        {
            //var db = new Database();
            //var dt = db.SelectData("loadDmPhong");
            dgv_DMPhong.DataSource = db.SelectData("loadDmPhong");
        }

        private void btn_DMThem_Click(object sender, EventArgs e)
        {
            var tenLoaiPhong = txt_DMLoaiPhong.Text.Trim();
            var donGia = int.Parse(txt_DMDonGia.Text);
            var ghiChu = txtDMghiChu.Text.Trim();

            //ràng buộc dữ liệu
            if (string.IsNullOrEmpty(tenLoaiPhong))
            {
                MessageBox.Show("Vui lòng nhập tên loại phòng", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //dừng chương trình
            }

            if (donGia < 150000)
            {
                MessageBox.Show("Đơn giá tối thiểu phải là 150.000", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //dừng chương trình
            }

            if (string.IsNullOrEmpty(ghiChu))
            {
                MessageBox.Show("Vui lòng nhập ghi chú", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //dừng chương trình
            }

            var prList = new List<CustomParameter>();

            prList.Add(new CustomParameter
            {
                key = "@tenLoaiPhong",
                value = tenLoaiPhong
            });

            prList.Add(new CustomParameter
            {
                key = "@donGia",
                value = donGia.ToString()
            });

            prList.Add(new CustomParameter
            {
                key = "@ghiChu",
                value = ghiChu
            });

            var rs = db.ExeCute("themLoaiPhong", prList);
            if (rs == 1)
            {
                MessageBox.Show("Thêm mới loại phòng thành công!", "Successfully!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDmPhong();
                txt_DMDonGia.Text = "0";
                txt_DMLoaiPhong.Text = "";
                txtDMghiChu.Text = "";
            }
            else
            {
                MessageBox.Show("Thêm loại phòng không thành công!", "Fail!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void txt_DMDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgv_DMPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                maLoaiPhong = int.Parse(dgv_DMPhong.Rows[e.RowIndex].Cells[0].Value.ToString());
                txt_DMLoaiPhong.Text = dgv_DMPhong.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_DMDonGia.Text = dgv_DMPhong.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDMghiChu.Text = dgv_DMPhong.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void btn_DMCapNhat_Click(object sender, EventArgs e)
        {
            var tenLoaiPhong = txt_DMLoaiPhong.Text.Trim();
            var donGia = int.Parse(txt_DMDonGia.Text);
            var ghiChu = txtDMghiChu.Text.Trim();

            //ràng buộc dữ liệu

            if (maLoaiPhong == 0)
            {
                MessageBox.Show("Vui lòng chọn loại phòng cần cập nhật", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //dừng chương trình
            }

            if (string.IsNullOrEmpty(tenLoaiPhong))
            {
                MessageBox.Show("Vui lòng nhập tên loại phòng", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //dừng chương trình
            }

            if (donGia < 150000)
            {
                MessageBox.Show("Đơn giá tối thiểu phải là 150.000", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //dừng chương trình
            }

            if (string.IsNullOrEmpty(ghiChu))
            {
                MessageBox.Show("Vui lòng nhập ghi chú", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //dừng chương trình
            }

            var prList = new List<CustomParameter>();
            prList.Add(new CustomParameter()
            {
                key = "@idLoaiPhong",
                value = maLoaiPhong.ToString()
            });

            prList.Add(new CustomParameter
            {
                key = "@tenLoaiPhong",
                value = tenLoaiPhong
            });

            prList.Add(new CustomParameter
            {
                key = "@donGia",
                value = donGia.ToString()
            });

            prList.Add(new CustomParameter
            {
                key = "@ghiChu",
                value = ghiChu
            });

            var rs = db.ExeCute("[capNhatLoaiPhong]", prList);
            if (rs == 1)
            {
                MessageBox.Show("Cập nhật loại phòng thành công!", "Successfully!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDmPhong();
                txt_DMDonGia.Text = "0";
                txt_DMLoaiPhong.Text = "null";
                txtDMghiChu.Text = "null";
                maLoaiPhong = 0;
            }
            else
            {
                MessageBox.Show("Cập nhật loại phòng không thành công!", "Fail!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_DMXoa_Click(object sender, EventArgs e)
        {
            if (maLoaiPhong == 0)
            {
                MessageBox.Show("Vui lòng chọn loại phòng cần xóa", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //dừng chương trình
            }
            if (MessageBox.Show("Bạn có chắc muốn xóa loại phòng này hay không? ", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var lstPra = new List<CustomParameter>()
                {
                    new CustomParameter()
                    {
                        key = "@idLoaiPhong",
                        value = maLoaiPhong.ToString()
                    }
                };
                var rs = db.ExeCute("[xoaLoaiPhong]", lstPra);
                if (rs == 1)
                {
                    MessageBox.Show("Xóa loại phòng thành công!", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDmPhong();
                    maLoaiPhong = 0;//reset maloaiphong (id về giá trị mặc định)
                }
                else
                {
                    MessageBox.Show("Xóa loại phòng không thành công!", "Fail!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
