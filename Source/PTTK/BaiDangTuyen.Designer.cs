using System.Windows.Forms;

namespace PTTK
{
    partial class BaiDangTuyen
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
            this.dataGridViewDangTuyen = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnGhiThongTin = new System.Windows.Forms.Button();
            this.btnLapPhieuThu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDangTuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDangTuyen
            // 
            this.dataGridViewDangTuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDangTuyen.Location = new System.Drawing.Point(40, 87);
            this.dataGridViewDangTuyen.Name = "dataGridViewDangTuyen";
            this.dataGridViewDangTuyen.RowHeadersWidth = 62;
            this.dataGridViewDangTuyen.Size = new System.Drawing.Size(1008, 552);
            this.dataGridViewDangTuyen.TabIndex = 0;
            this.dataGridViewDangTuyen.BackgroundColor = System.Drawing.Color.White;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Silver;
            this.txtSearch.Location = new System.Drawing.Point(140, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(592, 35);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "Nhập mã đăng tuyển ...";
            this.txtSearch.Enter += new System.EventHandler(this.txtMaDangTuyen_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtMaDangTuyen_Leave);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(819, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(152, 40);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnGhiThongTin
            // 
            this.btnGhiThongTin.ForeColor = System.Drawing.Color.White;
            this.btnGhiThongTin.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGhiThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhiThongTin.Location = new System.Drawing.Point(257, 660);
            this.btnGhiThongTin.Name = "btnGhiThongTin";
            this.btnGhiThongTin.Size = new System.Drawing.Size(317, 40);
            this.btnGhiThongTin.TabIndex = 3;
            this.btnGhiThongTin.Text = "Ghi thông tin bài đăng";
            this.btnGhiThongTin.UseVisualStyleBackColor = false;
            // 
            // btnLapPhieuThu
            // 
            this.btnLapPhieuThu.ForeColor = System.Drawing.Color.White;
            this.btnLapPhieuThu.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLapPhieuThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapPhieuThu.Location = new System.Drawing.Point(635, 660);
            this.btnLapPhieuThu.Name = "btnLapPhieuThu";
            this.btnLapPhieuThu.Size = new System.Drawing.Size(190, 40);
            this.btnLapPhieuThu.TabIndex = 4;
            this.btnLapPhieuThu.Text = "Lập phiếu thu";
            this.btnLapPhieuThu.UseVisualStyleBackColor = false;
            // 
            // BaiDangTuyen
            // 
            this.ClientSize = new System.Drawing.Size(1093, 715);
            this.Controls.Add(this.btnLapPhieuThu);
            this.Controls.Add(this.btnGhiThongTin);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridViewDangTuyen);
            this.Name = "BaiDangTuyen";
            this.Text = "BaiDangTuyen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDangTuyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDangTuyen;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnGhiThongTin;
        private System.Windows.Forms.Button btnLapPhieuThu;
    }
}