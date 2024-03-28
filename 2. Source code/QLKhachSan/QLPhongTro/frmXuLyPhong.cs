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
    public partial class frmXuLyPhong : Form
    {
        private string idPhong;
        private Database db;
        public frmXuLyPhong(string idPhong)
        {
            this.idPhong = idPhong;
            InitializeComponent();
        }

        private void frmXuLyPhong_Load(object sender, EventArgs e)
        {
            db = new Database();
            LoadLoaiPhong();

            if (string.IsNullOrEmpty(idPhong)) //nếu idphong được truyền qua là null = trường hợp thêm mới 
            {
                lblTitle.Text = "Thêm phòng mới";
            }
            else //nếu idphong khác null <=> trường hợp cập nhật
            {
                lblTitle.Text = "Cập nhật thông tin phòng";

                //vì phòng được xác định qua id nên cần truyền tham số là giá trị của id phòng vào
                var lstPara = new List<CustomParameter>()
                {
                    new CustomParameter
                    {
                    key = "@idPhong",
                    value = idPhong
                    }
                };
                var phong = db.SelectData("[ChonPhong]", lstPara).Rows[0]; //Sử dụng hàm selecdata trong class database để lấy dữ liệu 
                //kết quả trả về là 1 datatable chỉ gồm 1 hàng chính là chỉ số hàng bằng 0

                //set các dữ liệu lấy đc cho các component trên frmXuLyPhong
                cbb_LoaiPhong.SelectedValue = phong["IDLoaiPhong"].ToString(); //set id loại phòng cho cbb
                txt_Phong.Text = phong["TenPhong"].ToString(); //set giá trị tên phòng cho txtTenPhong
                if (phong["TinhTrang"].ToString() == "1") //set tình trạng hoạt động cho ckbHoatDong
                {
                    ckbHoatDong.Checked = true;
                }
                else
                {
                    ckbHoatDong.Checked = false;
                }
            }
        }

        private void LoadLoaiPhong()
        {
            var dt = db.SelectData("loadDmPhong");
            cbb_LoaiPhong.DataSource = dt;
            cbb_LoaiPhong.DisplayMember = "TenLoaiPhong";
            cbb_LoaiPhong.ValueMember = "ID";
        }

        private void ptbExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            var idLoaiPhong = cbb_LoaiPhong.SelectedValue.ToString();
            var tenPhong = txt_Phong.Text.Trim();
            var tinhTrang = ckbHoatDong.Checked ? 1 : 0;

            if (cbb_LoaiPhong.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại phòng", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(tenPhong))
            {
                MessageBox.Show("Vui lòng nhập tên phòng", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(idPhong)) //trường hợp thêm mới phòng không có idphong <=> null
            {
                var lstPra = new List<CustomParameter>()
                {
                    new CustomParameter
                    {
                    key = "@idLoaiPhong",
                    value = idLoaiPhong
                    },
                    new CustomParameter
                    {
                    key = "@tenPhong",
                    value = tenPhong
                    },
                    new CustomParameter
                    {
                    key = "@tinhTrang",
                    value = tinhTrang.ToString()
                    }
                };

                var rs = db.ExeCute("[capNhatPhong]", lstPra);
                if (rs == 1)
                {
                    MessageBox.Show("Thêm mới phòng thành công!", "Succecfully!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("Thêm phòng không thành công!", "Fail!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else //trường hợp cập nhật phòng đã tồn tại <=> idPhong có gia tri = null 
            {
                //xử lý trường hợp khi click vào btnXacNhan
                //bên proc có 4 tham số đầu vào
                //vì vậy cần truyền vào 4 tham số tương ứng
                var lstPara = new List<CustomParameter>()
                {
                    new CustomParameter
                    {
                        key = "@idPhong",
                        value = idPhong
                    },

                    new CustomParameter
                    {
                        key = "@tenPhong",
                        value = txt_Phong.Text
                    },

                    new CustomParameter
                    {
                        key = "@idLoaiPhong",
                        value = cbb_LoaiPhong.SelectedValue.ToString()
                    },
                    
                    new CustomParameter
                    {
                        key = "@tinhTrang",
                        value =  tinhTrang.ToString()
                    }

                };

                var kq = db.ExeCute("updatePhong",lstPara);
                if (kq == 1)
                {
                    MessageBox.Show("Cập nhật thành công!", "Successfully!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công!", "Fail!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
    }
}
