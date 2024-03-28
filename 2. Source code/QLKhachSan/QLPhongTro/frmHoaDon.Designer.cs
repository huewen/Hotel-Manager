
namespace QLPhongTro
{
    partial class frmHoaDon
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
            this.dgv_HDTT = new System.Windows.Forms.DataGridView();
            this.lbl_HoaDon = new System.Windows.Forms.Label();
            this.lbl_HDKH = new System.Windows.Forms.Label();
            this.lbl_SoNgayThue = new System.Windows.Forms.Label();
            this.txt_SoNgayThue = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.cbbHeSo = new System.Windows.Forms.ComboBox();
            this.lblHeSo = new System.Windows.Forms.Label();
            this.txtPhuThu = new System.Windows.Forms.TextBox();
            this.lblPhuThu = new System.Windows.Forms.Label();
            this.cbbKhachHang = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HDTT)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_HDTT
            // 
            this.dgv_HDTT.AllowUserToAddRows = false;
            this.dgv_HDTT.AllowUserToDeleteRows = false;
            this.dgv_HDTT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_HDTT.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_HDTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HDTT.Location = new System.Drawing.Point(3, 247);
            this.dgv_HDTT.MultiSelect = false;
            this.dgv_HDTT.Name = "dgv_HDTT";
            this.dgv_HDTT.ReadOnly = true;
            this.dgv_HDTT.RowHeadersWidth = 62;
            this.dgv_HDTT.RowTemplate.Height = 28;
            this.dgv_HDTT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_HDTT.Size = new System.Drawing.Size(1281, 431);
            this.dgv_HDTT.TabIndex = 0;
            this.dgv_HDTT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HDTT_CellClick);
            // 
            // lbl_HoaDon
            // 
            this.lbl_HoaDon.AutoSize = true;
            this.lbl_HoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HoaDon.Location = new System.Drawing.Point(515, 36);
            this.lbl_HoaDon.Name = "lbl_HoaDon";
            this.lbl_HoaDon.Size = new System.Drawing.Size(305, 29);
            this.lbl_HoaDon.TabIndex = 1;
            this.lbl_HoaDon.Text = "HÓA ĐƠN THANH TOÁN";
            // 
            // lbl_HDKH
            // 
            this.lbl_HDKH.AutoSize = true;
            this.lbl_HDKH.Location = new System.Drawing.Point(64, 125);
            this.lbl_HDKH.Name = "lbl_HDKH";
            this.lbl_HDKH.Size = new System.Drawing.Size(94, 20);
            this.lbl_HDKH.TabIndex = 2;
            this.lbl_HDKH.Text = "Khách hàng";
            // 
            // lbl_SoNgayThue
            // 
            this.lbl_SoNgayThue.AutoSize = true;
            this.lbl_SoNgayThue.Location = new System.Drawing.Point(64, 183);
            this.lbl_SoNgayThue.Name = "lbl_SoNgayThue";
            this.lbl_SoNgayThue.Size = new System.Drawing.Size(103, 20);
            this.lbl_SoNgayThue.TabIndex = 3;
            this.lbl_SoNgayThue.Text = "Số ngày thuê";
            // 
            // txt_SoNgayThue
            // 
            this.txt_SoNgayThue.Location = new System.Drawing.Point(176, 180);
            this.txt_SoNgayThue.Name = "txt_SoNgayThue";
            this.txt_SoNgayThue.Size = new System.Drawing.Size(169, 26);
            this.txt_SoNgayThue.TabIndex = 5;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.BackColor = System.Drawing.SystemColors.Control;
            this.btnThem.Location = new System.Drawing.Point(954, 173);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(124, 41);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.BackColor = System.Drawing.SystemColors.Control;
            this.btnXoa.Location = new System.Drawing.Point(1111, 173);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(124, 41);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(664, 119);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(374, 26);
            this.txtDiaChi.TabIndex = 14;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(592, 122);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(57, 20);
            this.lblDiaChi.TabIndex = 13;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // cbbHeSo
            // 
            this.cbbHeSo.FormattingEnabled = true;
            this.cbbHeSo.Location = new System.Drawing.Point(664, 178);
            this.cbbHeSo.Name = "cbbHeSo";
            this.cbbHeSo.Size = new System.Drawing.Size(138, 28);
            this.cbbHeSo.TabIndex = 12;
            // 
            // lblHeSo
            // 
            this.lblHeSo.AutoSize = true;
            this.lblHeSo.Location = new System.Drawing.Point(592, 183);
            this.lblHeSo.Name = "lblHeSo";
            this.lblHeSo.Size = new System.Drawing.Size(51, 20);
            this.lblHeSo.TabIndex = 11;
            this.lblHeSo.Text = "Hệ số";
            // 
            // txtPhuThu
            // 
            this.txtPhuThu.Location = new System.Drawing.Point(441, 180);
            this.txtPhuThu.Name = "txtPhuThu";
            this.txtPhuThu.Size = new System.Drawing.Size(117, 26);
            this.txtPhuThu.TabIndex = 10;
            // 
            // lblPhuThu
            // 
            this.lblPhuThu.AutoSize = true;
            this.lblPhuThu.Location = new System.Drawing.Point(371, 183);
            this.lblPhuThu.Name = "lblPhuThu";
            this.lblPhuThu.Size = new System.Drawing.Size(64, 20);
            this.lblPhuThu.TabIndex = 9;
            this.lblPhuThu.Text = "Phụ thu";
            // 
            // cbbKhachHang
            // 
            this.cbbKhachHang.FormattingEnabled = true;
            this.cbbKhachHang.Location = new System.Drawing.Point(176, 122);
            this.cbbKhachHang.Name = "cbbKhachHang";
            this.cbbKhachHang.Size = new System.Drawing.Size(338, 28);
            this.cbbKhachHang.TabIndex = 8;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(192)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(1287, 678);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.cbbHeSo);
            this.Controls.Add(this.lbl_HoaDon);
            this.Controls.Add(this.lblHeSo);
            this.Controls.Add(this.dgv_HDTT);
            this.Controls.Add(this.txtPhuThu);
            this.Controls.Add(this.lbl_HDKH);
            this.Controls.Add(this.lblPhuThu);
            this.Controls.Add(this.lbl_SoNgayThue);
            this.Controls.Add(this.cbbKhachHang);
            this.Controls.Add(this.txt_SoNgayThue);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Name = "frmHoaDon";
            this.Text = "frmHoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HDTT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_HDTT;
        private System.Windows.Forms.Label lbl_HoaDon;
        private System.Windows.Forms.Label lbl_HDKH;
        private System.Windows.Forms.Label lbl_SoNgayThue;
        private System.Windows.Forms.TextBox txt_SoNgayThue;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cbbKhachHang;
        private System.Windows.Forms.TextBox txtPhuThu;
        private System.Windows.Forms.Label lblPhuThu;
        private System.Windows.Forms.ComboBox cbbHeSo;
        private System.Windows.Forms.Label lblHeSo;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblDiaChi;
    }
}