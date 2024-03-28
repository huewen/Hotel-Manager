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
    public partial class frmThuePhong : Form
    {
        private Database db;
        private int rowIndex = -1; //biến lưu chỉ số phòng của phòng đc chọn

        public frmThuePhong()
        {
            InitializeComponent();
        }

        private void btnAddLK_Click(object sender, EventArgs e)
        {
            new frmThemLoaiKhach().ShowDialog();
            LoadPhieuThuePhong();
        }

        private void btnAddKH_Click(object sender, EventArgs e)
        {
            new frmThemKhachHang().ShowDialog();
            LoadPhieuThuePhong();
        }

        private void frmThuePhong_Load(object sender, EventArgs e)
        {
            db = new Database();
            LoadPhieuThuePhong();
            #region gui
            //đặt lại tên cột
            dgv_PhieuThue.Columns["id"].HeaderText = "STT";
            dgv_PhieuThue.Columns["hoten"].HeaderText = "Khách hàng";
            dgv_PhieuThue.Columns["loaikhach"].HeaderText = "Loại khách";
            dgv_PhieuThue.Columns["cmnd"].HeaderText = "CMND";
            dgv_PhieuThue.Columns["diachi"].HeaderText = "Địa chỉ";
 

            //set kích thước các cột
            dgv_PhieuThue.Columns["id"].Width = 50;
            dgv_PhieuThue.Columns["hoten"].Width = 150;
            dgv_PhieuThue.Columns["loaikhach"].Width = 100;
            dgv_PhieuThue.Columns["cmnd"].Width = 100; 
            dgv_PhieuThue.Columns["diachi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//cho cột tên phòng tự động co giãn theo form
            #endregion
        }

        private void LoadPhieuThuePhong()
        {
            db = new Database();
            dgv_PhieuThue.DataSource = db.SelectData("LoadPhieuThuePhong");

            var dt = db.SelectData("loadDsPhong");
            cbbPhong.DataSource = dt;
            cbbPhong.DisplayMember = "TenPhong";
            cbbPhong.ValueMember = "ID";
        }

        private void dgv_PhieuThue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
        }
    }
}

