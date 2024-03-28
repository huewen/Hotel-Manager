
namespace QLPhongTro
{
    partial class frmThuePhong
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
            this.dgv_PhieuThue = new System.Windows.Forms.DataGridView();
            this.lbl_PhieuThue = new System.Windows.Forms.Label();
            this.btnAddKH = new System.Windows.Forms.Button();
            this.btnAddLK = new System.Windows.Forms.Button();
            this.lblNgayThue = new System.Windows.Forms.Label();
            this.txtNgayThue = new System.Windows.Forms.TextBox();
            this.cbbPhong = new System.Windows.Forms.ComboBox();
            this.lblPhong = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuThue)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_PhieuThue
            // 
            this.dgv_PhieuThue.AllowUserToAddRows = false;
            this.dgv_PhieuThue.AllowUserToDeleteRows = false;
            this.dgv_PhieuThue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_PhieuThue.BackgroundColor = System.Drawing.Color.White;
            this.dgv_PhieuThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PhieuThue.Location = new System.Drawing.Point(3, 231);
            this.dgv_PhieuThue.MultiSelect = false;
            this.dgv_PhieuThue.Name = "dgv_PhieuThue";
            this.dgv_PhieuThue.ReadOnly = true;
            this.dgv_PhieuThue.RowHeadersWidth = 62;
            this.dgv_PhieuThue.RowTemplate.Height = 28;
            this.dgv_PhieuThue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_PhieuThue.Size = new System.Drawing.Size(1279, 446);
            this.dgv_PhieuThue.TabIndex = 0;
            this.dgv_PhieuThue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PhieuThue_CellClick);
            // 
            // lbl_PhieuThue
            // 
            this.lbl_PhieuThue.AutoSize = true;
            this.lbl_PhieuThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PhieuThue.Location = new System.Drawing.Point(489, 33);
            this.lbl_PhieuThue.Name = "lbl_PhieuThue";
            this.lbl_PhieuThue.Size = new System.Drawing.Size(395, 29);
            this.lbl_PhieuThue.TabIndex = 1;
            this.lbl_PhieuThue.Text = "QUẢN LÝ KHÁCH THUÊ PHÒNG";
            // 
            // btnAddKH
            // 
            this.btnAddKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddKH.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddKH.Location = new System.Drawing.Point(526, 144);
            this.btnAddKH.Name = "btnAddKH";
            this.btnAddKH.Size = new System.Drawing.Size(124, 44);
            this.btnAddKH.TabIndex = 4;
            this.btnAddKH.Text = "Khách hàng";
            this.btnAddKH.UseVisualStyleBackColor = false;
            this.btnAddKH.Click += new System.EventHandler(this.btnAddKH_Click);
            // 
            // btnAddLK
            // 
            this.btnAddLK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddLK.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddLK.Location = new System.Drawing.Point(673, 144);
            this.btnAddLK.Name = "btnAddLK";
            this.btnAddLK.Size = new System.Drawing.Size(124, 44);
            this.btnAddLK.TabIndex = 5;
            this.btnAddLK.Text = "Loại khách";
            this.btnAddLK.UseVisualStyleBackColor = false;
            this.btnAddLK.Click += new System.EventHandler(this.btnAddLK_Click);
            // 
            // lblNgayThue
            // 
            this.lblNgayThue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNgayThue.AutoSize = true;
            this.lblNgayThue.Location = new System.Drawing.Point(864, 165);
            this.lblNgayThue.Name = "lblNgayThue";
            this.lblNgayThue.Size = new System.Drawing.Size(81, 20);
            this.lblNgayThue.TabIndex = 21;
            this.lblNgayThue.Text = "Ngày thuê";
            // 
            // txtNgayThue
            // 
            this.txtNgayThue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNgayThue.Location = new System.Drawing.Point(951, 162);
            this.txtNgayThue.Name = "txtNgayThue";
            this.txtNgayThue.Size = new System.Drawing.Size(256, 26);
            this.txtNgayThue.TabIndex = 25;
            // 
            // cbbPhong
            // 
            this.cbbPhong.FormattingEnabled = true;
            this.cbbPhong.Location = new System.Drawing.Point(190, 162);
            this.cbbPhong.Name = "cbbPhong";
            this.cbbPhong.Size = new System.Drawing.Size(256, 28);
            this.cbbPhong.TabIndex = 28;
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Location = new System.Drawing.Point(71, 162);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(55, 20);
            this.lblPhong.TabIndex = 29;
            this.lblPhong.Text = "Phòng";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(190, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(256, 26);
            this.textBox1.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Khách hàng";
            // 
            // frmThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(192)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(1287, 678);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPhong);
            this.Controls.Add(this.cbbPhong);
            this.Controls.Add(this.txtNgayThue);
            this.Controls.Add(this.lbl_PhieuThue);
            this.Controls.Add(this.dgv_PhieuThue);
            this.Controls.Add(this.btnAddKH);
            this.Controls.Add(this.lblNgayThue);
            this.Controls.Add(this.btnAddLK);
            this.Name = "frmThuePhong";
            this.Text = "frmPhieuThue";
            this.Load += new System.EventHandler(this.frmThuePhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuThue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_PhieuThue;
        private System.Windows.Forms.Label lbl_PhieuThue;
        private System.Windows.Forms.Button btnAddKH;
        private System.Windows.Forms.Button btnAddLK;
        private System.Windows.Forms.Label lblNgayThue;
        private System.Windows.Forms.TextBox txtNgayThue;
        private System.Windows.Forms.ComboBox cbbPhong;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}