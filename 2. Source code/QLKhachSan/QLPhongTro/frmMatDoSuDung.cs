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
    public partial class frmMatDoSuDung : Form
    {
        private Database db;
        public frmMatDoSuDung()
        {
            InitializeComponent();
        }

        private void LoadBCMatDoPhong()
        {
            dgv_MatDo.DataSource = db.SelectData("loadBCMDPhong");
        }

        private void frmMatDoSuDung_Load(object sender, EventArgs e)
        {
            db = new Database();
            LoadBCMatDoPhong();

            #region gui
           //đặt lại tên cột
            dgv_MatDo.Columns[0].HeaderText = "STT";
            dgv_MatDo.Columns[1].HeaderText = "Phòng";
            dgv_MatDo.Columns[2].HeaderText = "Số ngày thuê";
            dgv_MatDo.Columns[3].HeaderText = "Tỷ lệ";

            //set kích thước các cột
            dgv_MatDo.Columns[0].Width = 150;
            dgv_MatDo.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_MatDo.Columns[2].Width = 200;
            dgv_MatDo.Columns[3].Width = 200;

            //căn chỉnh vị trí cột
            dgv_MatDo.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;//chỉnh cho số về bên phải
            #endregion
        }


    }
}
