
namespace QLPhongTro
{
    partial class frmBaoCaoTheoLoaiPhong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_BaoCaoTheoLoai = new System.Windows.Forms.DataGridView();
            this.lbl_BCTheoLP = new System.Windows.Forms.Label();
            this.lbl_Thang = new System.Windows.Forms.Label();
            this.lblThang = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BaoCaoTheoLoai)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_BaoCaoTheoLoai
            // 
            this.dgv_BaoCaoTheoLoai.AllowUserToAddRows = false;
            this.dgv_BaoCaoTheoLoai.AllowUserToDeleteRows = false;
            this.dgv_BaoCaoTheoLoai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_BaoCaoTheoLoai.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_BaoCaoTheoLoai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_BaoCaoTheoLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_BaoCaoTheoLoai.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_BaoCaoTheoLoai.Location = new System.Drawing.Point(-6, 130);
            this.dgv_BaoCaoTheoLoai.MultiSelect = false;
            this.dgv_BaoCaoTheoLoai.Name = "dgv_BaoCaoTheoLoai";
            this.dgv_BaoCaoTheoLoai.ReadOnly = true;
            this.dgv_BaoCaoTheoLoai.RowHeadersWidth = 62;
            this.dgv_BaoCaoTheoLoai.RowTemplate.Height = 28;
            this.dgv_BaoCaoTheoLoai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_BaoCaoTheoLoai.Size = new System.Drawing.Size(1294, 563);
            this.dgv_BaoCaoTheoLoai.TabIndex = 0;
            // 
            // lbl_BCTheoLP
            // 
            this.lbl_BCTheoLP.AutoSize = true;
            this.lbl_BCTheoLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BCTheoLP.Location = new System.Drawing.Point(79, 43);
            this.lbl_BCTheoLP.Name = "lbl_BCTheoLP";
            this.lbl_BCTheoLP.Size = new System.Drawing.Size(528, 29);
            this.lbl_BCTheoLP.TabIndex = 1;
            this.lbl_BCTheoLP.Text = "BÁO CÁO DOANH THU THEO LOẠI PHÒNG";
            // 
            // lbl_Thang
            // 
            this.lbl_Thang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Thang.AutoSize = true;
            this.lbl_Thang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Thang.Location = new System.Drawing.Point(936, 83);
            this.lbl_Thang.Name = "lbl_Thang";
            this.lbl_Thang.Size = new System.Drawing.Size(54, 20);
            this.lbl_Thang.TabIndex = 2;
            this.lbl_Thang.Text = "Tháng";
            // 
            // lblThang
            // 
            this.lblThang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblThang.AutoSize = true;
            this.lblThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThang.Location = new System.Drawing.Point(988, 83);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(29, 20);
            this.lblThang.TabIndex = 3;
            this.lblThang.Text = "12";
            // 
            // frmBaoCaoTheoLoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(192)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(1287, 678);
            this.Controls.Add(this.lblThang);
            this.Controls.Add(this.lbl_Thang);
            this.Controls.Add(this.lbl_BCTheoLP);
            this.Controls.Add(this.dgv_BaoCaoTheoLoai);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmBaoCaoTheoLoaiPhong";
            this.Text = "frmBaoCaoTheoLoaiPhong";
            this.Load += new System.EventHandler(this.frmBaoCaoTheoLoaiPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BaoCaoTheoLoai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_BaoCaoTheoLoai;
        private System.Windows.Forms.Label lbl_BCTheoLP;
        private System.Windows.Forms.Label lbl_Thang;
        private System.Windows.Forms.Label lblThang;
    }
}