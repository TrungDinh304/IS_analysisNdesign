namespace PTTK
{
    partial class UserControl_DoanhNghiep
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_DoanhNghiep = new System.Windows.Forms.Label();
            this.dataGridView_ds_DoanhNgiep = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip_Option = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xemChiTiếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chỉnhSửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cácPhiếuĐăngTuyểnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_TimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_TimKiem = new System.Windows.Forms.Button();
            this.button_DangKy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ds_DoanhNgiep)).BeginInit();
            this.contextMenuStrip_Option.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_DoanhNghiep
            // 
            this.label_DoanhNghiep.AutoSize = true;
            this.label_DoanhNghiep.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_DoanhNghiep.Location = new System.Drawing.Point(24, 20);
            this.label_DoanhNghiep.Name = "label_DoanhNghiep";
            this.label_DoanhNghiep.Size = new System.Drawing.Size(308, 44);
            this.label_DoanhNghiep.TabIndex = 3;
            this.label_DoanhNghiep.Text = "DOANH NGHIỆP";
            // 
            // dataGridView_ds_DoanhNgiep
            // 
            this.dataGridView_ds_DoanhNgiep.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_ds_DoanhNgiep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ds_DoanhNgiep.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ds_DoanhNgiep.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_ds_DoanhNgiep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ds_DoanhNgiep.ContextMenuStrip = this.contextMenuStrip_Option;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_ds_DoanhNgiep.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_ds_DoanhNgiep.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_ds_DoanhNgiep.Location = new System.Drawing.Point(32, 176);
            this.dataGridView_ds_DoanhNgiep.Name = "dataGridView_ds_DoanhNgiep";
            this.dataGridView_ds_DoanhNgiep.RowHeadersWidth = 51;
            this.dataGridView_ds_DoanhNgiep.RowTemplate.Height = 24;
            this.dataGridView_ds_DoanhNgiep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ds_DoanhNgiep.Size = new System.Drawing.Size(1020, 509);
            this.dataGridView_ds_DoanhNgiep.TabIndex = 4;
            this.dataGridView_ds_DoanhNgiep.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_dsDoanhNghiep_CellMouseDown);
            // 
            // contextMenuStrip_Option
            // 
            this.contextMenuStrip_Option.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip_Option.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemChiTiếtToolStripMenuItem,
            this.chỉnhSửaToolStripMenuItem,
            this.cácPhiếuĐăngTuyểnToolStripMenuItem});
            this.contextMenuStrip_Option.Name = "contextMenuStrip1";
            this.contextMenuStrip_Option.Size = new System.Drawing.Size(226, 104);
            // 
            // xemChiTiếtToolStripMenuItem
            // 
            this.xemChiTiếtToolStripMenuItem.Name = "xemChiTiếtToolStripMenuItem";
            this.xemChiTiếtToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.xemChiTiếtToolStripMenuItem.Text = "Xem Chi Tiết";
            this.xemChiTiếtToolStripMenuItem.Click += new System.EventHandler(this.xemChiTiếtToolStripMenuItem_Click);
            // 
            // chỉnhSửaToolStripMenuItem
            // 
            this.chỉnhSửaToolStripMenuItem.Name = "chỉnhSửaToolStripMenuItem";
            this.chỉnhSửaToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.chỉnhSửaToolStripMenuItem.Text = "Chỉnh Sửa";
            // 
            // cácPhiếuĐăngTuyểnToolStripMenuItem
            // 
            this.cácPhiếuĐăngTuyểnToolStripMenuItem.Name = "cácPhiếuĐăngTuyểnToolStripMenuItem";
            this.cácPhiếuĐăngTuyểnToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.cácPhiếuĐăngTuyểnToolStripMenuItem.Text = "Các Phiếu Đăng Tuyển";
            this.cácPhiếuĐăngTuyểnToolStripMenuItem.Click += new System.EventHandler(this.cácPhiếuĐăngTuyểnToolStripMenuItem_Click);
            // 
            // textBox_TimKiem
            // 
            this.textBox_TimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_TimKiem.Font = new System.Drawing.Font("Arial", 12F);
            this.textBox_TimKiem.Location = new System.Drawing.Point(167, 112);
            this.textBox_TimKiem.Name = "textBox_TimKiem";
            this.textBox_TimKiem.Size = new System.Drawing.Size(538, 30);
            this.textBox_TimKiem.TabIndex = 5;
            this.textBox_TimKiem.TextChanged += new System.EventHandler(this.textBox_TimKiem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(64, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tìm kiếm:";
            // 
            // button_TimKiem
            // 
            this.button_TimKiem.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_TimKiem.Font = new System.Drawing.Font("Arial", 9F);
            this.button_TimKiem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_TimKiem.Location = new System.Drawing.Point(735, 112);
            this.button_TimKiem.Name = "button_TimKiem";
            this.button_TimKiem.Size = new System.Drawing.Size(99, 30);
            this.button_TimKiem.TabIndex = 7;
            this.button_TimKiem.Text = "Tìm Kiếm";
            this.button_TimKiem.UseVisualStyleBackColor = false;
            this.button_TimKiem.Click += new System.EventHandler(this.button_TimKiem_Click);
            // 
            // button_DangKy
            // 
            this.button_DangKy.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_DangKy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_DangKy.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.button_DangKy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_DangKy.Location = new System.Drawing.Point(351, 20);
            this.button_DangKy.Name = "button_DangKy";
            this.button_DangKy.Size = new System.Drawing.Size(154, 44);
            this.button_DangKy.TabIndex = 8;
            this.button_DangKy.Text = "Đăng Ký";
            this.button_DangKy.UseVisualStyleBackColor = false;
            this.button_DangKy.Click += new System.EventHandler(this.button_DangKy_Click);
            // 
            // UserControl_DoanhNghiep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.button_DangKy);
            this.Controls.Add(this.button_TimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_TimKiem);
            this.Controls.Add(this.dataGridView_ds_DoanhNgiep);
            this.Controls.Add(this.label_DoanhNghiep);
            this.Name = "UserControl_DoanhNghiep";
            this.Size = new System.Drawing.Size(1089, 711);
            this.Load += new System.EventHandler(this.UserControl_DoanhNghiep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ds_DoanhNgiep)).EndInit();
            this.contextMenuStrip_Option.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_DoanhNghiep;
        private System.Windows.Forms.DataGridView dataGridView_ds_DoanhNgiep;
        private System.Windows.Forms.TextBox textBox_TimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_TimKiem;
        private System.Windows.Forms.Button button_DangKy;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Option;
        private System.Windows.Forms.ToolStripMenuItem xemChiTiếtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cácPhiếuĐăngTuyểnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaToolStripMenuItem;
    }
}
