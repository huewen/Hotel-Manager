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
    public partial class frmBaoCaoTheoLoaiPhong : Form
    {
        private Database db;
        public frmBaoCaoTheoLoaiPhong()
        {
            InitializeComponent();
        }

        private void LoadDSBCLoaiPhong()
        {
            dgv_BaoCaoTheoLoai.DataSource = db.SelectData("loadBCLoaiPhong");
        }

        private void frmBaoCaoTheoLoaiPhong_Load(object sender, EventArgs e)
        {
            db = new Database();
            LoadDSBCLoaiPhong();

            #region gui
            //đặt lại tên cột
            dgv_BaoCaoTheoLoai.Columns[0].HeaderText = "STT";
            dgv_BaoCaoTheoLoai.Columns[1].HeaderText = "Loại phòng";
            dgv_BaoCaoTheoLoai.Columns[2].HeaderText = "Doanh thu";
            dgv_BaoCaoTheoLoai.Columns[3].HeaderText = "Tỷ lệ";

            //set kích thước các cột
            dgv_BaoCaoTheoLoai.Columns[0].Width = 150;
            dgv_BaoCaoTheoLoai.Columns[1].Width = 200;
            dgv_BaoCaoTheoLoai.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//cho cột tên phòng tự động co giãn theo form
            dgv_BaoCaoTheoLoai.Columns[3].Width = 200;

            //căn chỉnh vị trí cột
            dgv_BaoCaoTheoLoai.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;//chỉnh cho số về bên phải
            dgv_BaoCaoTheoLoai.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //định dạng phần nghìn cho cột doanh thu
            dgv_BaoCaoTheoLoai.Columns[2].DefaultCellStyle.Format = "N0";
            #endregion
        }
    }
}
