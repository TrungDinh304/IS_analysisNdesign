namespace PTTK
{
    partial class UserControl_UngVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTitleDirect = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbFind = new System.Windows.Forms.Label();
            this.txtTenUV = new System.Windows.Forms.TextBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.tbUngVien = new System.Windows.Forms.DataGridView();
            this.btn_MHDangKy = new System.Windows.Forms.Button();
            this.btn_MHDuyet = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbUngVien)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitleDirect
            // 
            this.lbTitleDirect.AutoSize = true;
            this.lbTitleDirect.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleDirect.Location = new System.Drawing.Point(46, 34);
            this.lbTitleDirect.Name = "lbTitleDirect";
            this.lbTitleDirect.Size = new System.Drawing.Size(181, 44);
            this.lbTitleDirect.TabIndex = 0;
            this.lbTitleDirect.Text = "Ứng viên";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_TimKiem);
            this.panel1.Controls.Add(this.txtTenUV);
            this.panel1.Controls.Add(this.lbFind);
            this.panel1.Location = new System.Drawing.Point(44, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 48);
            this.panel1.TabIndex = 1;
            // 
            // lbFind
            // 
            this.lbFind.AutoSize = true;
            this.lbFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFind.Location = new System.Drawing.Point(6, 12);
            this.lbFind.Name = "lbFind";
            this.lbFind.Size = new System.Drawing.Size(92, 24);
            this.lbFind.TabIndex = 0;
            this.lbFind.Text = "Tìm kiếm:";
            // 
            // txtTenUV
            // 
            this.txtTenUV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenUV.ForeColor = System.Drawing.Color.Silver;
            this.txtTenUV.Location = new System.Drawing.Point(140, 9);
            this.txtTenUV.Name = "txtTenUV";
            this.txtTenUV.Size = new System.Drawing.Size(455, 29);
            this.txtTenUV.TabIndex = 1;
            this.txtTenUV.Text = "# Tìm theo tên ứng viên";
            this.txtTenUV.Enter += new System.EventHandler(this.txtTenUV_Enter);
            this.txtTenUV.Leave += new System.EventHandler(this.txtTenUV_Leave);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.ForeColor = System.Drawing.Color.White;
            this.btn_TimKiem.Location = new System.Drawing.Point(632, 9);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(88, 28);
            this.btn_TimKiem.TabIndex = 2;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // tbUngVien
            // 
            this.tbUngVien.AllowUserToAddRows = false;
            this.tbUngVien.AllowUserToDeleteRows = false;
            this.tbUngVien.AllowUserToResizeColumns = false;
            this.tbUngVien.AllowUserToResizeRows = false;
            this.tbUngVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbUngVien.BackgroundColor = System.Drawing.Color.White;
            this.tbUngVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbUngVien.Location = new System.Drawing.Point(54, 164);
            this.tbUngVien.Name = "tbUngVien";
            this.tbUngVien.ReadOnly = true;
            this.tbUngVien.RowHeadersVisible = false;
            this.tbUngVien.Size = new System.Drawing.Size(710, 318);
            this.tbUngVien.TabIndex = 2;
            // 
            // btn_MHDangKy
            // 
            this.btn_MHDangKy.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_MHDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MHDangKy.ForeColor = System.Drawing.Color.White;
            this.btn_MHDangKy.Location = new System.Drawing.Point(54, 526);
            this.btn_MHDangKy.Name = "btn_MHDangKy";
            this.btn_MHDangKy.Size = new System.Drawing.Size(88, 28);
            this.btn_MHDangKy.TabIndex = 3;
            this.btn_MHDangKy.Text = "Đăng kí";
            this.btn_MHDangKy.UseVisualStyleBackColor = false;
            this.btn_MHDangKy.Click += new System.EventHandler(this.btn_MHDangKy_Click);
            // 
            // btn_MHDuyet
            // 
            this.btn_MHDuyet.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_MHDuyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MHDuyet.ForeColor = System.Drawing.Color.White;
            this.btn_MHDuyet.Location = new System.Drawing.Point(184, 526);
            this.btn_MHDuyet.Name = "btn_MHDuyet";
            this.btn_MHDuyet.Size = new System.Drawing.Size(147, 28);
            this.btn_MHDuyet.TabIndex = 4;
            this.btn_MHDuyet.Text = "Kiểm duyệt hồ sơ";
            this.btn_MHDuyet.UseVisualStyleBackColor = false;
            // 
            // UserControl_UngVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_MHDuyet);
            this.Controls.Add(this.btn_MHDangKy);
            this.Controls.Add(this.tbUngVien);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTitleDirect);
            this.Name = "UserControl_UngVien";
            this.Size = new System.Drawing.Size(818, 579);
            this.Load += new System.EventHandler(this.UserControl_UngVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbUngVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitleDirect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbFind;
        private System.Windows.Forms.TextBox txtTenUV;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.DataGridView tbUngVien;
        private System.Windows.Forms.Button btn_MHDangKy;
        private System.Windows.Forms.Button btn_MHDuyet;
    }
}