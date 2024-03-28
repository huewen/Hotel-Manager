
namespace QLPhongTro
{
    partial class frmXuLyPhong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXuLyPhong));
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ptbExit = new System.Windows.Forms.PictureBox();
            this.pblBottom = new System.Windows.Forms.Panel();
            this.lbl_Phong = new System.Windows.Forms.Label();
            this.ckbHoatDong = new System.Windows.Forms.CheckBox();
            this.cbb_LoaiPhong = new System.Windows.Forms.ComboBox();
            this.lbl_LoaiPhong = new System.Windows.Forms.Label();
            this.txt_Phong = new System.Windows.Forms.TextBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.Silver;
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(631, 46);
            this.pnlRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(15, 392);
            this.pnlRight.TabIndex = 9;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.Silver;
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 46);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(15, 392);
            this.pnlLeft.TabIndex = 10;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Silver;
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Controls.Add(this.pictureBox1);
            this.pnlTop.Controls.Add(this.ptbExit);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(646, 46);
            this.pnlTop.TabIndex = 11;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(60, 11);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(138, 26);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Xử lý phòng";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ptbExit
            // 
            this.ptbExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbExit.Image = ((System.Drawing.Image)(resources.GetObject("ptbExit.Image")));
            this.ptbExit.Location = new System.Drawing.Point(598, 11);
            this.ptbExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ptbExit.Name = "ptbExit";
            this.ptbExit.Size = new System.Drawing.Size(30, 31);
            this.ptbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbExit.TabIndex = 0;
            this.ptbExit.TabStop = false;
            this.ptbExit.Click += new System.EventHandler(this.ptbExit_Click);
            // 
            // pblBottom
            // 
            this.pblBottom.BackColor = System.Drawing.Color.Silver;
            this.pblBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pblBottom.Location = new System.Drawing.Point(0, 438);
            this.pblBottom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pblBottom.Name = "pblBottom";
            this.pblBottom.Size = new System.Drawing.Size(646, 15);
            this.pblBottom.TabIndex = 12;
            // 
            // lbl_Phong
            // 
            this.lbl_Phong.AutoSize = true;
            this.lbl_Phong.Location = new System.Drawing.Point(108, 191);
            this.lbl_Phong.Name = "lbl_Phong";
            this.lbl_Phong.Size = new System.Drawing.Size(55, 20);
            this.lbl_Phong.TabIndex = 13;
            this.lbl_Phong.Text = "Phòng";
            // 
            // ckbHoatDong
            // 
            this.ckbHoatDong.AutoSize = true;
            this.ckbHoatDong.Checked = true;
            this.ckbHoatDong.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbHoatDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbHoatDong.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ckbHoatDong.Location = new System.Drawing.Point(232, 247);
            this.ckbHoatDong.Name = "ckbHoatDong";
            this.ckbHoatDong.Size = new System.Drawing.Size(119, 24);
            this.ckbHoatDong.TabIndex = 14;
            this.ckbHoatDong.Text = "Hoạt động";
            this.ckbHoatDong.UseVisualStyleBackColor = true;
            // 
            // cbb_LoaiPhong
            // 
            this.cbb_LoaiPhong.FormattingEnabled = true;
            this.cbb_LoaiPhong.Location = new System.Drawing.Point(232, 134);
            this.cbb_LoaiPhong.Name = "cbb_LoaiPhong";
            this.cbb_LoaiPhong.Size = new System.Drawing.Size(302, 28);
            this.cbb_LoaiPhong.TabIndex = 15;
            // 
            // lbl_LoaiPhong
            // 
            this.lbl_LoaiPhong.AutoSize = true;
            this.lbl_LoaiPhong.Location = new System.Drawing.Point(108, 137);
            this.lbl_LoaiPhong.Name = "lbl_LoaiPhong";
            this.lbl_LoaiPhong.Size = new System.Drawing.Size(88, 20);
            this.lbl_LoaiPhong.TabIndex = 16;
            this.lbl_LoaiPhong.Text = "Loại phòng";
            // 
            // txt_Phong
            // 
            this.txt_Phong.Location = new System.Drawing.Point(232, 185);
            this.txt_Phong.Multiline = true;
            this.txt_Phong.Name = "txt_Phong";
            this.txt_Phong.Size = new System.Drawing.Size(302, 26);
            this.txt_Phong.TabIndex = 17;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(108, 247);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(80, 20);
            this.lblTrangThai.TabIndex = 18;
            this.lblTrangThai.Text = "Trạng thái";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.White;
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Location = new System.Drawing.Point(150, 322);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(129, 45);
            this.btnXacNhan.TabIndex = 19;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.White;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(326, 322);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(129, 45);
            this.btnHuy.TabIndex = 20;
            this.btnHuy.Text = "Thoát";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmXuLyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(192)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(646, 453);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.txt_Phong);
            this.Controls.Add(this.lbl_LoaiPhong);
            this.Controls.Add(this.cbb_LoaiPhong);
            this.Controls.Add(this.ckbHoatDong);
            this.Controls.Add(this.lbl_Phong);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pblBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmXuLyPhong";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmXuLyPhong";
            this.Load += new System.EventHandler(this.frmXuLyPhong_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ptbExit;
        private System.Windows.Forms.Panel pblBottom;
        private System.Windows.Forms.Label lbl_Phong;
        private System.Windows.Forms.CheckBox ckbHoatDong;
        private System.Windows.Forms.ComboBox cbb_LoaiPhong;
        private System.Windows.Forms.Label lbl_LoaiPhong;
        private System.Windows.Forms.TextBox txt_Phong;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnHuy;
    }
}