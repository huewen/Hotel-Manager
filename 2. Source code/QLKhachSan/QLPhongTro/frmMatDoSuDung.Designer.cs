
namespace QLPhongTro
{
    partial class frmMatDoSuDung
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
            this.dgv_MatDo = new System.Windows.Forms.DataGridView();
            this.lbl_BCMatDo = new System.Windows.Forms.Label();
            this.lblThang = new System.Windows.Forms.Label();
            this.lbl_Thang = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MatDo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_MatDo
            // 
            this.dgv_MatDo.AllowUserToAddRows = false;
            this.dgv_MatDo.AllowUserToDeleteRows = false;
            this.dgv_MatDo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_MatDo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_MatDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MatDo.Location = new System.Drawing.Point(1, 192);
            this.dgv_MatDo.MultiSelect = false;
            this.dgv_MatDo.Name = "dgv_MatDo";
            this.dgv_MatDo.ReadOnly = true;
            this.dgv_MatDo.RowHeadersWidth = 62;
            this.dgv_MatDo.RowTemplate.Height = 28;
            this.dgv_MatDo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_MatDo.Size = new System.Drawing.Size(1284, 482);
            this.dgv_MatDo.TabIndex = 0;
            // 
            // lbl_BCMatDo
            // 
            this.lbl_BCMatDo.AutoSize = true;
            this.lbl_BCMatDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BCMatDo.Location = new System.Drawing.Point(432, 37);
            this.lbl_BCMatDo.Name = "lbl_BCMatDo";
            this.lbl_BCMatDo.Size = new System.Drawing.Size(456, 29);
            this.lbl_BCMatDo.TabIndex = 1;
            this.lbl_BCMatDo.Text = "BÁO CÁO MẬT ĐỘ SỬ DỤNG PHÒNG";
            // 
            // lblThang
            // 
            this.lblThang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblThang.AutoSize = true;
            this.lblThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThang.Location = new System.Drawing.Point(886, 122);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(29, 20);
            this.lblThang.TabIndex = 2;
            this.lblThang.Text = "12";
            // 
            // lbl_Thang
            // 
            this.lbl_Thang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Thang.AutoSize = true;
            this.lbl_Thang.Location = new System.Drawing.Point(817, 122);
            this.lbl_Thang.Name = "lbl_Thang";
            this.lbl_Thang.Size = new System.Drawing.Size(54, 20);
            this.lbl_Thang.TabIndex = 8;
            this.lbl_Thang.Text = "Tháng";
            // 
            // frmMatDoSuDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(192)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(1287, 678);
            this.Controls.Add(this.lbl_Thang);
            this.Controls.Add(this.lblThang);
            this.Controls.Add(this.lbl_BCMatDo);
            this.Controls.Add(this.dgv_MatDo);
            this.Name = "frmMatDoSuDung";
            this.Text = "frmMatDoSuDung";
            this.Load += new System.EventHandler(this.frmMatDoSuDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MatDo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_MatDo;
        private System.Windows.Forms.Label lbl_BCMatDo;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.Label lbl_Thang;
    }
}