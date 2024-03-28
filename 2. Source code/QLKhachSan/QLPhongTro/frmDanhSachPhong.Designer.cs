
namespace QLPhongTro
{
    partial class frmDanhSachPhong
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
            this.dgv_DSPhong = new System.Windows.Forms.DataGridView();
            this.lblPhong = new System.Windows.Forms.Label();
            this.lbl_TimKiem = new System.Windows.Forms.Label();
            this.lbl_DanhSachPhong = new System.Windows.Forms.Label();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_DSPhong
            // 
            this.dgv_DSPhong.AllowUserToAddRows = false;
            this.dgv_DSPhong.AllowUserToDeleteRows = false;
            this.dgv_DSPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DSPhong.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_DSPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSPhong.Location = new System.Drawing.Point(3, 215);
            this.dgv_DSPhong.MultiSelect = false;
            this.dgv_DSPhong.Name = "dgv_DSPhong";
            this.dgv_DSPhong.ReadOnly = true;
            this.dgv_DSPhong.RowHeadersWidth = 62;
            this.dgv_DSPhong.RowTemplate.Height = 28;
            this.dgv_DSPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DSPhong.Size = new System.Drawing.Size(1273, 462);
            this.dgv_DSPhong.TabIndex = 0;
            this.dgv_DSPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DSPhong_CellClick);
            this.dgv_DSPhong.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DSPhong_CellDoubleClick);
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Location = new System.Drawing.Point(67, 63);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(0, 20);
            this.lblPhong.TabIndex = 1;
            // 
            // lbl_TimKiem
            // 
            this.lbl_TimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_TimKiem.AutoSize = true;
            this.lbl_TimKiem.Location = new System.Drawing.Point(338, 131);
            this.lbl_TimKiem.Name = "lbl_TimKiem";
            this.lbl_TimKiem.Size = new System.Drawing.Size(71, 20);
            this.lbl_TimKiem.TabIndex = 6;
            this.lbl_TimKiem.Text = "Tìm kiếm";
            // 
            // lbl_DanhSachPhong
            // 
            this.lbl_DanhSachPhong.AutoSize = true;
            this.lbl_DanhSachPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DanhSachPhong.Location = new System.Drawing.Point(73, 54);
            this.lbl_DanhSachPhong.Name = "lbl_DanhSachPhong";
            this.lbl_DanhSachPhong.Size = new System.Drawing.Size(260, 29);
            this.lbl_DanhSachPhong.TabIndex = 8;
            this.lbl_DanhSachPhong.Text = "DANH SÁCH PHÒNG";
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_TimKiem.Location = new System.Drawing.Point(427, 128);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(375, 26);
            this.txt_TimKiem.TabIndex = 9;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_TimKiem.BackColor = System.Drawing.SystemColors.Control;
            this.btn_TimKiem.Location = new System.Drawing.Point(848, 121);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(105, 40);
            this.btn_TimKiem.TabIndex = 10;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CapNhat.BackColor = System.Drawing.SystemColors.Control;
            this.btn_CapNhat.Location = new System.Drawing.Point(976, 121);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(105, 40);
            this.btn_CapNhat.TabIndex = 11;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.UseVisualStyleBackColor = false;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.BackColor = System.Drawing.SystemColors.Control;
            this.btnXoa.Location = new System.Drawing.Point(1100, 121);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(105, 40);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frmDanhSachPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(192)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(1287, 678);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btn_CapNhat);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.lbl_DanhSachPhong);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.lblPhong);
            this.Controls.Add(this.lbl_TimKiem);
            this.Controls.Add(this.dgv_DSPhong);
            this.Name = "frmDanhSachPhong";
            this.Text = "Danh sách phòng";
            this.Load += new System.EventHandler(this.frmDanhSachPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_DSPhong;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.Label lbl_TimKiem;
        private System.Windows.Forms.Label lbl_DanhSachPhong;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Button btnXoa;
    }
}