
namespace QLPhongTro
{
    partial class frmLienHe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLienHe));
            this.ptb_Title = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbContent = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Title)).BeginInit();
            this.grbContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptb_Title
            // 
            this.ptb_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.ptb_Title.Image = ((System.Drawing.Image)(resources.GetObject("ptb_Title.Image")));
            this.ptb_Title.Location = new System.Drawing.Point(0, 0);
            this.ptb_Title.Name = "ptb_Title";
            this.ptb_Title.Size = new System.Drawing.Size(1287, 211);
            this.ptb_Title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_Title.TabIndex = 2;
            this.ptb_Title.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(6, 16);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(728, 213);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(783, 16);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(452, 213);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "***Thông tin----------------------------\r\n\r\n*Khách sạn DREAMS HOTEL\r\n\r\n*Phone: 12" +
    "3-456-7890\r\n*Infor: @hndreamshotel";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(12, 508);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(1241, 92);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Chúng tôi luôn muốn được lắng nghe ý kiến của bạn!";
            // 
            // grbContent
            // 
            this.grbContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.grbContent.Controls.Add(this.textBox1);
            this.grbContent.Controls.Add(this.textBox2);
            this.grbContent.Location = new System.Drawing.Point(18, 242);
            this.grbContent.Name = "grbContent";
            this.grbContent.Size = new System.Drawing.Size(1241, 241);
            this.grbContent.TabIndex = 6;
            this.grbContent.TabStop = false;
            // 
            // frmLienHe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(192)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(1287, 653);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptb_Title);
            this.Controls.Add(this.grbContent);
            this.Name = "frmLienHe";
            this.Text = "frmLienHe";
            this.Load += new System.EventHandler(this.frmLienHe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Title)).EndInit();
            this.grbContent.ResumeLayout(false);
            this.grbContent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ptb_Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grbContent;
    }
}