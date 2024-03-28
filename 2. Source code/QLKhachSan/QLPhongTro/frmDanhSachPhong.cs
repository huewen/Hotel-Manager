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
    public partial class frmDanhSachPhong : Form
    {
        private Database db;
        //private string idPhong= null;
        private int rowIndex = -1; //biến lưu chỉ số phòng của phòng đc chọn

        public frmDanhSachPhong()
        {
            InitializeComponent();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            new frmXuLyPhong(null).ShowDialog(); //truyền tham số null để xác định trường hợp thêm mới phòng 
            LoadDSPhong();
        }

        private void frmDanhSachPhong_Load(object sender, EventArgs e)
        {
            LoadDSPhong();

            #region gui
            //đặt lại tên cột
            dgv_DSPhong.Columns["id"].HeaderText = "STT";
            dgv_DSPhong.Columns["tenloaiphong"].HeaderText = "Loại Phòng";
            dgv_DSPhong.Columns["tenphong"].HeaderText = "Phòng";
            dgv_DSPhong.Columns["dongia"].HeaderText = "Đơn giá";
            dgv_DSPhong.Columns["tinhtrang"].HeaderText = "Tình Trạng";

            //set kích thước các cột
            dgv_DSPhong.Columns["id"].Width = 100;
            dgv_DSPhong.Columns["tenloaiphong"].Width = 150;
            dgv_DSPhong.Columns["dongia"].Width = 200;
            dgv_DSPhong.Columns["tinhtrang"].Width = 200;
            dgv_DSPhong.Columns["tenphong"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//cho cột tên phòng tự động co giãn theo form

            //căn chỉnh vị trí cột
            dgv_DSPhong.Columns["dongia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; //chỉnh cho số của đơn giá về bên phải

            //định dạng phần nghìn cho cột đơn giá
            dgv_DSPhong.Columns["dongia"].DefaultCellStyle.Format = "N0";
            #endregion
        }

        private void LoadDSPhong()
        {
            db = new Database();
            var dt = db.SelectData("loadDsPhong");
            dgv_DSPhong.DataSource = dt;
        }

        private void dgv_DSPhong_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //lấy id phòng được chọn
            var idPhong = dgv_DSPhong.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            new frmXuLyPhong(idPhong).ShowDialog(); //truyền idPhong được chọn qua form frmXuLyPhong để xác định trường hợp cập nhật phòng
            LoadDSPhong();
        }

        private void dgv_DSPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //lấy id phòng cần xóa trong sự kiện cell click của datagridview
            rowIndex = e.RowIndex;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //kiem tra rowIndex có phải < 0 hay ko
            //nếu < 0 chưa có phòng nào được chọn để xóa
            if(rowIndex<0)
            {
                MessageBox.Show("Vui lòng chọn phòng cần xóa", "Chú ý!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //nếu gặp trường hợp chưa có phòng nào được chọn để xóa thì dừng chường trình
            }
            //nếu có phòng đc chọn để xóa thì hiện câu hỏi xác nhận
            if (MessageBox.Show("Bạn có chắc muốn xóa phòng "+dgv_DSPhong.Rows[rowIndex].Cells["tenphong"].Value.ToString()+" hay không?", "Xác nhận xóa phòng", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.OK)
            {
                var lstPra = new List<CustomParameter>()
                {
                    new CustomParameter()
                    {
                        key = "@idPhong",
                        value = dgv_DSPhong.Rows[rowIndex].Cells["ID"].Value.ToString()
                    }
                };
                var kq = db.ExeCute("deletePhong", lstPra);
                if (kq == 1)
                {
                    MessageBox.Show("Xóa loại phòng thành công!", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDSPhong();
                }
                else
                {
                    MessageBox.Show("Xóa phòng không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
