using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPhongTro
{
    public partial class frmThemLoaiKhach : Form
    {
        private Database db;
        private int maLoaiKhach = 0;

        public frmThemLoaiKhach()
        {
            InitializeComponent();
        }
       
        private void frmThemLoaiKhach_Load(object sender, EventArgs e)
        {
            db = new Database();
            LoadLoaiKhach();

            #region gui
            //đặt lại tên cột
            dgv_LoaiKhach.Columns[0].HeaderText = "STT";
            dgv_LoaiKhach.Columns[1].HeaderText = "Loại Khách";
            dgv_LoaiKhach.Columns[2].HeaderText = "Hệ số";

            //set kích thước các cột
            dgv_LoaiKhach.Columns[0].Width = 100;
            dgv_LoaiKhach.Columns[1].Width = 200;
            dgv_LoaiKhach.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//cho cột tên phòng tự động co giãn theo form

            //căn chỉnh vị trí cột
            dgv_LoaiKhach.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; //chỉnh cho số về bên phải

            #endregion
        }

        private void LoadLoaiKhach()
        {
            //var dt = db.SelectData("loadLoaiKhach");
            dgv_LoaiKhach.DataSource = db.SelectData("loadLoaiKhach");
        }

        private void txtHeSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgv_LoaiKhach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                maLoaiKhach = int.Parse(dgv_LoaiKhach.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtLoaiKhach.Text = dgv_LoaiKhach.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtHeSo.Text = dgv_LoaiKhach.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void ptbExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var tenLoaiKhach = txtLoaiKhach.Text.Trim();
            var heSo = float.Parse(txtHeSo.Text);

            if (string.IsNullOrEmpty(tenLoaiKhach))
            {
                MessageBox.Show("Vui lòng nhập tên loại khách", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (heSo < 1)
            {
                MessageBox.Show("Hệ số tối thiểu phải là 1", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var lstPra = new List<CustomParameter>();

            lstPra.Add(new CustomParameter
            {
                key = "@tenLoaiKhach",
                value = tenLoaiKhach
            });

            lstPra.Add(new CustomParameter
            {
                key = "@heSo",
                value = heSo.ToString()
            });

            var rs = db.ExeCute("themLoaiKhach", lstPra);
            if (rs == 1)
            {
                MessageBox.Show("Thêm mới loại khách thành công!", "Succecfully!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadLoaiKhach();
            }
            else
            {
                MessageBox.Show("Thêm loại khách không thành công!", "Fail!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            var tenLoaiKhach = txtLoaiKhach.Text.Trim();
            var heSo = float.Parse(txtHeSo.Text);

            //ràng buộc dữ liệu

            if (maLoaiKhach == 0)
            {
                MessageBox.Show("Vui lòng chọn loại khách cần cập nhật", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //dừng chương trình
            }

            if (string.IsNullOrEmpty(tenLoaiKhach))
            {
                MessageBox.Show("Vui lòng nhập tên loại khách", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //dừng chương trình
            }

            if (heSo < 1)
            {
                MessageBox.Show("Hệ số tối thiểu phải là 1", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var lstPra = new List<CustomParameter>();


            lstPra.Add(new CustomParameter
            {
                key = "@idLoaiKhach",
                value = maLoaiKhach.ToString()
            });

            lstPra.Add(new CustomParameter
            {
                key = "@tenLoaiKhach",
                value = tenLoaiKhach
            });

            lstPra.Add(new CustomParameter
            {
                key = "@heSo",
                value = heSo.ToString()
            });

            var rs = db.ExeCute("capNhatLoaiKhach", lstPra);
            if (rs == 1)
            {
                MessageBox.Show("Cập nhật thành công!", "Succecfully!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadLoaiKhach();
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công!", "Fail!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
