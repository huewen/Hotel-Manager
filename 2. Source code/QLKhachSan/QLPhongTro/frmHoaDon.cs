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
    public partial class frmHoaDon : Form
    {
        private Database db;
        //private int maHoaDon = 0;
        private int rowIndex = -1;
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            db = new Database();
            LoadDSHoaDon();

            #region gui
            //đặt lại tên cột
            dgv_HDTT.Columns["id"].HeaderText = "STT";
            dgv_HDTT.Columns["tenphong"].HeaderText = "Phòng";
            dgv_HDTT.Columns["hoten"].HeaderText = "Khách hàng";
            dgv_HDTT.Columns["diachi"].HeaderText = "Địa chỉ";
            dgv_HDTT.Columns["songaythue"].HeaderText = "Số ngày thuê";
            dgv_HDTT.Columns["dongia"].HeaderText = "Đơn giá";
            dgv_HDTT.Columns["thanhtien"].HeaderText = "Thành tiền";
            dgv_HDTT.Columns["phuthu"].HeaderText = "Phụ thu";
            dgv_HDTT.Columns["heso"].HeaderText = "Hệ số";

            //set kích thước các cột
            dgv_HDTT.Columns["id"].Width = 50;
            dgv_HDTT.Columns["tenphong"].Width = 50;
            dgv_HDTT.Columns["hoten"].Width = 150;
            dgv_HDTT.Columns["diachi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//cho cột tên phòng tự động co giãn theo form
            dgv_HDTT.Columns["songaythue"].Width = 50;
            dgv_HDTT.Columns["dongia"].Width = 100;
            dgv_HDTT.Columns["thanhtien"].Width = 100;
            dgv_HDTT.Columns["phuthu"].Width = 50;
            dgv_HDTT.Columns["heso"].Width = 60;
           
            //căn chỉnh vị trí cột
            dgv_HDTT.Columns["dongia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; //chỉnh cho số của đơn giá về bên phải
            dgv_HDTT.Columns["thanhtien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //định dạng phần nghìn cho cột
            dgv_HDTT.Columns["dongia"].DefaultCellStyle.Format = "N0";
            dgv_HDTT.Columns["thanhtien"].DefaultCellStyle.Format = "N0";
            #endregion
        }
        private void LoadDSHoaDon()
        {
            db = new Database();
            dgv_HDTT.DataSource = db.SelectData("loadDsHoaDon");

            var dt = db.SelectData("loadKhachHang");
            cbbKhachHang.DataSource = dt;
            cbbKhachHang.DisplayMember = "HoTen";
            cbbKhachHang.ValueMember = "ID";

            var ds = db.SelectData("loadLoaiKhach");
            cbbHeSo.DataSource = ds;
            cbbHeSo.DisplayMember = "HeSo";
            cbbHeSo.ValueMember = "ID";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void dgv_HDTT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (e.RowIndex >= 0)
            {
                maHoaDon= int.Parse(dgv_HDTT.Rows[e.RowIndex].Cells[0].Value.ToString());
               
                txtDiaChi.Text=dgv_HDTT.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPhuThu.Text= dgv_HDTT.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_SoNgayThue.Text= dgv_HDTT.Rows[e.RowIndex].Cells[1].Value.ToString();
            }*/
            rowIndex = e.RowIndex;
        }
    }
}
