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
    public partial class frmMain : Form
    {
        
        public frmMain()
        {
            InitializeComponent();
        }

        #region gui
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void ptbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ptbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ptbState_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
            {
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                this.WindowState = FormWindowState.Maximized;
               // ptbState.Image = Properties.Resources.res;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
               // ptbState.Image = Properties.Resources.maxi;
            }
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion

        //hàm add form lên groupbox có tên là grbContent
        private void AddForm(Form f)
        {
            this.grbContent.Controls.Clear();//xóa các control hiện có trên groupbox
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;//bỏ viền của form
            f.Dock = DockStyle.Fill;
            this.Text = f.Text;
            this.grbContent.Controls.Add(f);
            f.Show();
        }

       private void frmMain_Load(object sender, EventArgs e)
       {
            var f = new frmDangNhap();
            f.ShowDialog(); //load form đăng nhập khi frmMain được gọi

            //sau khi form đăng nhập tắt, lấy tài khoản đã đăng nhập
            var tk = f.tendangnhap;
            MessageBox.Show("Tài khoản đã đăng nhập là: " + tk);
        }

        private void danhMucPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmDanhMucPhong();
            AddForm(f);
        }

        private void phieuThueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmThuePhong();
            AddForm(f);
        }

        private void traCuuPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmDanhSachPhong();
            AddForm(f);
        }

        private void hoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmHoaDon();
            AddForm(f);
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmBaoCaoTheoLoaiPhong();
            AddForm(f);
        }

        private void matDoSuDungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmMatDoSuDung();
            AddForm(f);
        }

        private void lienHeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmLienHe();
            AddForm(f);
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
