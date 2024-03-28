
namespace QLPhongTro
{
    partial class frmThemLoaiKhach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemLoaiKhach));
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.ptbExit = new System.Windows.Forms.PictureBox();
            this.pblBottom = new System.Windows.Forms.Panel();
            this.lblThemLK = new System.Windows.Forms.Label();
            this.dgv_LoaiKhach = new System.Windows.Forms.DataGridView();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtHeSo = new System.Windows.Forms.TextBox();
            this.lblHeSo = new System.Windows.Forms.Label();
            this.txtLoaiKhach = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblLoaiKhach = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiKhach)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(68)))), ((int)(((byte)(85)))));
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(1049, 46);
            this.pnlRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(15, 646);
            this.pnlRight.TabIndex = 2;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(68)))), ((int)(((byte)(85)))));
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 46);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(15, 646);
            this.pnlLeft.TabIndex = 3;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(68)))), ((int)(((byte)(85)))));
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Controls.Add(this.ptbLogo);
            this.pnlTop.Controls.Add(this.ptbExit);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1064, 46);
            this.pnlTop.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(70, 17);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(120, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Phiếu thêm";
            // 
            // ptbLogo
            // 
            this.ptbLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.ptbLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptbLogo.Image")));
            this.ptbLogo.Location = new System.Drawing.Point(12, 3);
            this.ptbLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(40, 42);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLogo.TabIndex = 0;
            this.ptbLogo.TabStop = false;
            // 
            // ptbExit
            // 
            this.ptbExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbExit.Image = ((System.Drawing.Image)(resources.GetObject("ptbExit.Image")));
            this.ptbExit.Location = new System.Drawing.Point(1016, 11);
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
            this.pblBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(68)))), ((int)(((byte)(85)))));
            this.pblBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pblBottom.Location = new System.Drawing.Point(0, 692);
            this.pblBottom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pblBottom.Name = "pblBottom";
            this.pblBottom.Size = new System.Drawing.Size(1064, 10);
            this.pblBottom.TabIndex = 5;
            // 
            // lblThemLK
            // 
            this.lblThemLK.AutoSize = true;
            this.lblThemLK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThemLK.Location = new System.Drawing.Point(450, 74);
            this.lblThemLK.Name = "lblThemLK";
            this.lblThemLK.Size = new System.Drawing.Size(144, 25);
            this.lblThemLK.TabIndex = 21;
            this.lblThemLK.Text = "LOẠI KHÁCH";
            // 
            // dgv_LoaiKhach
            // 
            this.dgv_LoaiKhach.AllowUserToAddRows = false;
            this.dgv_LoaiKhach.AllowUserToDeleteRows = false;
            this.dgv_LoaiKhach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_LoaiKhach.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_LoaiKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LoaiKhach.Location = new System.Drawing.Point(17, 243);
            this.dgv_LoaiKhach.MultiSelect = false;
            this.dgv_LoaiKhach.Name = "dgv_LoaiKhach";
            this.dgv_LoaiKhach.ReadOnly = true;
            this.dgv_LoaiKhach.RowHeadersWidth = 62;
            this.dgv_LoaiKhach.RowTemplate.Height = 28;
            this.dgv_LoaiKhach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_LoaiKhach.Size = new System.Drawing.Size(1029, 446);
            this.dgv_LoaiKhach.TabIndex = 30;
            this.dgv_LoaiKhach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_LoaiKhach_CellClick);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhat.Location = new System.Drawing.Point(835, 163);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(129, 39);
            this.btnCapNhat.TabIndex = 37;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtHeSo
            // 
            this.txtHeSo.Location = new System.Drawing.Point(179, 182);
            this.txtHeSo.Name = "txtHeSo";
            this.txtHeSo.Size = new System.Drawing.Size(291, 26);
            this.txtHeSo.TabIndex = 36;
            this.txtHeSo.Text = "0";
            this.txtHeSo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblHeSo
            // 
            this.lblHeSo.AutoSize = true;
            this.lblHeSo.Location = new System.Drawing.Point(68, 182);
            this.lblHeSo.Name = "lblHeSo";
            this.lblHeSo.Size = new System.Drawing.Size(51, 20);
            this.lblHeSo.TabIndex = 35;
            this.lblHeSo.Text = "Hệ số";
            // 
            // txtLoaiKhach
            // 
            this.txtLoaiKhach.Location = new System.Drawing.Point(179, 137);
            this.txtLoaiKhach.Name = "txtLoaiKhach";
            this.txtLoaiKhach.Size = new System.Drawing.Size(291, 26);
            this.txtLoaiKhach.TabIndex = 34;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Location = new System.Drawing.Point(659, 163);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(129, 39);
            this.btnThem.TabIndex = 33;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblLoaiKhach
            // 
            this.lblLoaiKhach.AutoSize = true;
            this.lblLoaiKhach.Location = new System.Drawing.Point(68, 137);
            this.lblLoaiKhach.Name = "lblLoaiKhach";
            this.lblLoaiKhach.Size = new System.Drawing.Size(86, 20);
            this.lblLoaiKhach.TabIndex = 32;
            this.lblLoaiKhach.Text = "Loại khách";
            // 
            // frmThemLoaiKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(192)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(1064, 702);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.txtHeSo);
            this.Controls.Add(this.lblHeSo);
            this.Controls.Add(this.txtLoaiKhach);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblLoaiKhach);
            this.Controls.Add(this.dgv_LoaiKhach);
            this.Controls.Add(this.lblThemLK);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pblBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThemLoaiKhach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThemLoaiKhach";
            this.Load += new System.EventHandler(this.frmThemLoaiKhach_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiKhach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.PictureBox ptbExit;
        private System.Windows.Forms.Panel pblBottom;
        private System.Windows.Forms.Label lblThemLK;
        private System.Windows.Forms.DataGridView dgv_LoaiKhach;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtHeSo;
        private System.Windows.Forms.Label lblHeSo;
        private System.Windows.Forms.TextBox txtLoaiKhach;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblLoaiKhach;
    }
}