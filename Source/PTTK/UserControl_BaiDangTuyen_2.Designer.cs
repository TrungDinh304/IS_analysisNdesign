namespace PTTK
{
    partial class UserControl_BaiDangTuyen_2
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
            this.lbFind = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridViewDangTuyen = new System.Windows.Forms.DataGridView();
            this.btnGhiThongTin = new System.Windows.Forms.Button();
            this.btnLapPhieuThu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDangTuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitleDirect
            // 
            this.lbTitleDirect.AutoSize = true;
            this.lbTitleDirect.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleDirect.Location = new System.Drawing.Point(52, 42);
            this.lbTitleDirect.Name = "lbTitleDirect";
            this.lbTitleDirect.Size = new System.Drawing.Size(428, 65);
            this.lbTitleDirect.TabIndex = 0;
            this.lbTitleDirect.Text = "Bài đăng tuyển";
            // 
            // lbFind
            // 
            this.lbFind.AutoSize = true;
            this.lbFind.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbFind.Location = new System.Drawing.Point(131, 140);
            this.lbFind.Name = "lbFind";
            this.lbFind.Size = new System.Drawing.Size(116, 27);
            this.lbFind.TabIndex = 6;
            this.lbFind.Text = "Tìm kiếm:";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Arial", 12F);
            this.txtSearch.ForeColor = System.Drawing.Color.Silver;
            this.txtSearch.Location = new System.Drawing.Point(258, 140);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(605, 35);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.Text = "Nhập mã đăng tuyển ...";
            this.txtSearch.Enter += new System.EventHandler(this.txtMaDangTuyen_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtMaDangTuyen_Leave);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 12F);
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch.Location = new System.Drawing.Point(897, 134);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(135, 50);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridViewDangTuyen
            // 
            this.dataGridViewDangTuyen.AllowUserToAddRows = false;
            this.dataGridViewDangTuyen.AllowUserToDeleteRows = false;
            this.dataGridViewDangTuyen.AllowUserToResizeColumns = false;
            this.dataGridViewDangTuyen.AllowUserToResizeRows = false;
            this.dataGridViewDangTuyen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDangTuyen.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDangTuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDangTuyen.Location = new System.Drawing.Point(61, 205);
            this.dataGridViewDangTuyen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewDangTuyen.Name = "dataGridViewDangTuyen";
            this.dataGridViewDangTuyen.ReadOnly = true;
            this.dataGridViewDangTuyen.RowHeadersVisible = false;
            this.dataGridViewDangTuyen.RowHeadersWidth = 62;
            this.dataGridViewDangTuyen.Size = new System.Drawing.Size(1095, 558);
            this.dataGridViewDangTuyen.TabIndex = 2;
            // 
            // btnGhiThongTin
            // 
            this.btnGhiThongTin.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGhiThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhiThongTin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGhiThongTin.Location = new System.Drawing.Point(337, 795);
            this.btnGhiThongTin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGhiThongTin.Name = "btnGhiThongTin";
            this.btnGhiThongTin.Size = new System.Drawing.Size(275, 50);
            this.btnGhiThongTin.TabIndex = 3;
            this.btnGhiThongTin.Text = "Ghi thông tin bài đăng";
            this.btnGhiThongTin.UseVisualStyleBackColor = false;
            // 
            // btnLapPhieuThu
            // 
            this.btnLapPhieuThu.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLapPhieuThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapPhieuThu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLapPhieuThu.Location = new System.Drawing.Point(649, 795);
            this.btnLapPhieuThu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLapPhieuThu.Name = "btnLapPhieuThu";
            this.btnLapPhieuThu.Size = new System.Drawing.Size(200, 50);
            this.btnLapPhieuThu.TabIndex = 4;
            this.btnLapPhieuThu.Text = "Lập phiếu thu";
            this.btnLapPhieuThu.UseVisualStyleBackColor = false;
            // 
            // UserControl_BaiDangTuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lbFind);
            this.Controls.Add(this.btnGhiThongTin);
            this.Controls.Add(this.btnLapPhieuThu);
            this.Controls.Add(this.dataGridViewDangTuyen);
            this.Controls.Add(this.lbTitleDirect);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserControl_BaiDangTuyen";
            this.Size = new System.Drawing.Size(1225, 889);
            this.Load += new System.EventHandler(this.UserControl_BaiDangTuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDangTuyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbTitleDirect;

        private System.Windows.Forms.Label lbFind;
        private System.Windows.Forms.DataGridView dataGridViewDangTuyen;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnGhiThongTin;
        private System.Windows.Forms.Button btnLapPhieuThu;
    }
}
