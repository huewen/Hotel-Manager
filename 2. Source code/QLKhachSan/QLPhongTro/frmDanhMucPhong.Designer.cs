
namespace QLPhongTro
{
    partial class frmDanhMucPhong
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
            this.dgv_DMPhong = new System.Windows.Forms.DataGridView();
            this.lbl_DMLoaiPhong = new System.Windows.Forms.Label();
            this.lbl_DMDonGia = new System.Windows.Forms.Label();
            this.txt_DMLoaiPhong = new System.Windows.Forms.TextBox();
            this.txt_DMDonGia = new System.Windows.Forms.TextBox();
            this.lbl_DanhMucPhong = new System.Windows.Forms.Label();
            this.btn_DMThem = new System.Windows.Forms.Button();
            this.btn_DMCapNhat = new System.Windows.Forms.Button();
            this.btn_DMXoa = new System.Windows.Forms.Button();
            this.txtDMghiChu = new System.Windows.Forms.TextBox();
            this.lbl_DMghiChu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DMPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_DMPhong
            // 
            this.dgv_DMPhong.AllowUserToAddRows = false;
            this.dgv_DMPhong.AllowUserToDeleteRows = false;
            this.dgv_DMPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DMPhong.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_DMPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DMPhong.Location = new System.Drawing.Point(4, 285);
            this.dgv_DMPhong.MultiSelect = false;
            this.dgv_DMPhong.Name = "dgv_DMPhong";
            this.dgv_DMPhong.ReadOnly = true;
            this.dgv_DMPhong.RowHeadersWidth = 62;
            this.dgv_DMPhong.RowTemplate.Height = 28;
            this.dgv_DMPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DMPhong.Size = new System.Drawing.Size(1280, 391);
            this.dgv_DMPhong.TabIndex = 0;
            this.dgv_DMPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DMPhong_CellClick);
            // 
            // lbl_DMLoaiPhong
            // 
            this.lbl_DMLoaiPhong.AutoSize = true;
            this.lbl_DMLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DMLoaiPhong.Location = new System.Drawing.Point(93, 143);
            this.lbl_DMLoaiPhong.Name = "lbl_DMLoaiPhong";
            this.lbl_DMLoaiPhong.Size = new System.Drawing.Size(88, 20);
            this.lbl_DMLoaiPhong.TabIndex = 2;
            this.lbl_DMLoaiPhong.Text = "Loại phòng";
            // 
            // lbl_DMDonGia
            // 
            this.lbl_DMDonGia.AutoSize = true;
            this.lbl_DMDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DMDonGia.Location = new System.Drawing.Point(93, 203);
            this.lbl_DMDonGia.Name = "lbl_DMDonGia";
            this.lbl_DMDonGia.Size = new System.Drawing.Size(64, 20);
            this.lbl_DMDonGia.TabIndex = 3;
            this.lbl_DMDonGia.Text = "Đơn giá";
            // 
            // txt_DMLoaiPhong
            // 
            this.txt_DMLoaiPhong.Location = new System.Drawing.Point(187, 143);
            this.txt_DMLoaiPhong.Name = "txt_DMLoaiPhong";
            this.txt_DMLoaiPhong.Size = new System.Drawing.Size(266, 26);
            this.txt_DMLoaiPhong.TabIndex = 5;
            // 
            // txt_DMDonGia
            // 
            this.txt_DMDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DMDonGia.Location = new System.Drawing.Point(187, 201);
            this.txt_DMDonGia.Name = "txt_DMDonGia";
            this.txt_DMDonGia.Size = new System.Drawing.Size(266, 26);
            this.txt_DMDonGia.TabIndex = 6;
            this.txt_DMDonGia.Text = "0";
            this.txt_DMDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_DMDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DMDonGia_KeyPress);
            // 
            // lbl_DanhMucPhong
            // 
            this.lbl_DanhMucPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_DanhMucPhong.AutoSize = true;
            this.lbl_DanhMucPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DanhMucPhong.Location = new System.Drawing.Point(92, 41);
            this.lbl_DanhMucPhong.Name = "lbl_DanhMucPhong";
            this.lbl_DanhMucPhong.Size = new System.Drawing.Size(248, 29);
            this.lbl_DanhMucPhong.TabIndex = 9;
            this.lbl_DanhMucPhong.Text = "DANH MỤC PHÒNG";
            this.lbl_DanhMucPhong.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_DMThem
            // 
            this.btn_DMThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DMThem.BackColor = System.Drawing.SystemColors.Control;
            this.btn_DMThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DMThem.Location = new System.Drawing.Point(526, 202);
            this.btn_DMThem.Name = "btn_DMThem";
            this.btn_DMThem.Size = new System.Drawing.Size(109, 37);
            this.btn_DMThem.TabIndex = 10;
            this.btn_DMThem.Text = "Thêm";
            this.btn_DMThem.UseVisualStyleBackColor = false;
            this.btn_DMThem.Click += new System.EventHandler(this.btn_DMThem_Click);
            // 
            // btn_DMCapNhat
            // 
            this.btn_DMCapNhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DMCapNhat.BackColor = System.Drawing.SystemColors.Control;
            this.btn_DMCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DMCapNhat.Location = new System.Drawing.Point(656, 202);
            this.btn_DMCapNhat.Name = "btn_DMCapNhat";
            this.btn_DMCapNhat.Size = new System.Drawing.Size(126, 37);
            this.btn_DMCapNhat.TabIndex = 11;
            this.btn_DMCapNhat.Text = "Cập nhật";
            this.btn_DMCapNhat.UseVisualStyleBackColor = false;
            this.btn_DMCapNhat.Click += new System.EventHandler(this.btn_DMCapNhat_Click);
            // 
            // btn_DMXoa
            // 
            this.btn_DMXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DMXoa.BackColor = System.Drawing.SystemColors.Control;
            this.btn_DMXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DMXoa.Location = new System.Drawing.Point(803, 202);
            this.btn_DMXoa.Name = "btn_DMXoa";
            this.btn_DMXoa.Size = new System.Drawing.Size(122, 37);
            this.btn_DMXoa.TabIndex = 12;
            this.btn_DMXoa.Text = "Xóa";
            this.btn_DMXoa.UseVisualStyleBackColor = false;
            this.btn_DMXoa.Click += new System.EventHandler(this.btn_DMXoa_Click);
            // 
            // txtDMghiChu
            // 
            this.txtDMghiChu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDMghiChu.Location = new System.Drawing.Point(994, 143);
            this.txtDMghiChu.Multiline = true;
            this.txtDMghiChu.Name = "txtDMghiChu";
            this.txtDMghiChu.Size = new System.Drawing.Size(254, 89);
            this.txtDMghiChu.TabIndex = 16;
            // 
            // lbl_DMghiChu
            // 
            this.lbl_DMghiChu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_DMghiChu.AutoSize = true;
            this.lbl_DMghiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DMghiChu.Location = new System.Drawing.Point(898, 141);
            this.lbl_DMghiChu.Name = "lbl_DMghiChu";
            this.lbl_DMghiChu.Size = new System.Drawing.Size(64, 20);
            this.lbl_DMghiChu.TabIndex = 15;
            this.lbl_DMghiChu.Text = "Ghi chú";
            // 
            // frmDanhMucPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(192)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(1287, 678);
            this.Controls.Add(this.txtDMghiChu);
            this.Controls.Add(this.lbl_DMghiChu);
            this.Controls.Add(this.btn_DMXoa);
            this.Controls.Add(this.lbl_DanhMucPhong);
            this.Controls.Add(this.btn_DMCapNhat);
            this.Controls.Add(this.dgv_DMPhong);
            this.Controls.Add(this.btn_DMThem);
            this.Controls.Add(this.lbl_DMLoaiPhong);
            this.Controls.Add(this.txt_DMDonGia);
            this.Controls.Add(this.lbl_DMDonGia);
            this.Controls.Add(this.txt_DMLoaiPhong);
            this.Name = "frmDanhMucPhong";
            this.Text = "frmDanhMucPhong";
            this.Load += new System.EventHandler(this.frmDanhMucPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DMPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_DMPhong;
        private System.Windows.Forms.Label lbl_DMLoaiPhong;
        private System.Windows.Forms.Label lbl_DMDonGia;
        private System.Windows.Forms.TextBox txt_DMLoaiPhong;
        private System.Windows.Forms.TextBox txt_DMDonGia;
        private System.Windows.Forms.Label lbl_DanhMucPhong;
        private System.Windows.Forms.Button btn_DMThem;
        private System.Windows.Forms.Button btn_DMCapNhat;
        private System.Windows.Forms.Button btn_DMXoa;
        private System.Windows.Forms.TextBox txtDMghiChu;
        private System.Windows.Forms.Label lbl_DMghiChu;
    }
}