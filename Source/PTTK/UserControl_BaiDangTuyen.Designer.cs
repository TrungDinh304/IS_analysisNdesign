namespace PTTK
{
    partial class UserControl_BaiDangTuyen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_DoanhNghiep = new System.Windows.Forms.Label();
            this.label_MaDoanhNghiep = new System.Windows.Forms.Label();
            this.button_DangKy = new System.Windows.Forms.Button();
            this.button_TimKiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_TimKiem = new System.Windows.Forms.TextBox();
            this.dataGridView_ds_BaiDangTuyen = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip_xemchitiet = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xemChiTiếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ds_BaiDangTuyen)).BeginInit();
            this.contextMenuStrip_xemchitiet.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_DoanhNghiep
            // 
            this.label_DoanhNghiep.AutoSize = true;
            this.label_DoanhNghiep.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_DoanhNghiep.Location = new System.Drawing.Point(24, 20);
            this.label_DoanhNghiep.Name = "label_DoanhNghiep";
            this.label_DoanhNghiep.Size = new System.Drawing.Size(308, 44);
            this.label_DoanhNghiep.TabIndex = 4;
            this.label_DoanhNghiep.Text = "DOANH NGHIỆP";
            this.label_DoanhNghiep.Click += new System.EventHandler(this.label_DoanhNghiep_Click);
            // 
            // label_MaDoanhNghiep
            // 
            this.label_MaDoanhNghiep.AutoSize = true;
            this.label_MaDoanhNghiep.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_MaDoanhNghiep.Location = new System.Drawing.Point(338, 20);
            this.label_MaDoanhNghiep.Name = "label_MaDoanhNghiep";
            this.label_MaDoanhNghiep.Size = new System.Drawing.Size(51, 44);
            this.label_MaDoanhNghiep.TabIndex = 5;
            this.label_MaDoanhNghiep.Text = "> ";
            // 
            // button_DangKy
            // 
            this.button_DangKy.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_DangKy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_DangKy.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.button_DangKy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_DangKy.Location = new System.Drawing.Point(681, 20);
            this.button_DangKy.Name = "button_DangKy";
            this.button_DangKy.Size = new System.Drawing.Size(154, 44);
            this.button_DangKy.TabIndex = 13;
            this.button_DangKy.Text = "Đăng Ký";
            this.button_DangKy.UseVisualStyleBackColor = false;
            this.button_DangKy.Click += new System.EventHandler(this.button_DangKy_Click);
            // 
            // button_TimKiem
            // 
            this.button_TimKiem.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_TimKiem.Font = new System.Drawing.Font("Arial", 9F);
            this.button_TimKiem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_TimKiem.Location = new System.Drawing.Point(736, 114);
            this.button_TimKiem.Name = "button_TimKiem";
            this.button_TimKiem.Size = new System.Drawing.Size(99, 30);
            this.button_TimKiem.TabIndex = 12;
            this.button_TimKiem.Text = "Tìm Kiếm";
            this.button_TimKiem.UseVisualStyleBackColor = false;
            this.button_TimKiem.Click += new System.EventHandler(this.button_TimKiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(65, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tìm kiếm:";
            // 
            // textBox_TimKiem
            // 
            this.textBox_TimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_TimKiem.Font = new System.Drawing.Font("Arial", 12F);
            this.textBox_TimKiem.Location = new System.Drawing.Point(168, 114);
            this.textBox_TimKiem.Name = "textBox_TimKiem";
            this.textBox_TimKiem.Size = new System.Drawing.Size(538, 30);
            this.textBox_TimKiem.TabIndex = 10;
            this.textBox_TimKiem.TextChanged += new System.EventHandler(this.textBox_TimKiem_TextChanged);
            // 
            // dataGridView_ds_BaiDangTuyen
            // 
            this.dataGridView_ds_BaiDangTuyen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_ds_BaiDangTuyen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ds_BaiDangTuyen.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ds_BaiDangTuyen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_ds_BaiDangTuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_ds_BaiDangTuyen.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_ds_BaiDangTuyen.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_ds_BaiDangTuyen.Location = new System.Drawing.Point(33, 178);
            this.dataGridView_ds_BaiDangTuyen.Name = "dataGridView_ds_BaiDangTuyen";
            this.dataGridView_ds_BaiDangTuyen.RowHeadersWidth = 51;
            this.dataGridView_ds_BaiDangTuyen.RowTemplate.Height = 24;
            this.dataGridView_ds_BaiDangTuyen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ds_BaiDangTuyen.Size = new System.Drawing.Size(1020, 509);
            this.dataGridView_ds_BaiDangTuyen.TabIndex = 9;
            this.dataGridView_ds_BaiDangTuyen.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ds_BaiDangTuyen_CellDoubleClick);
            this.dataGridView_ds_BaiDangTuyen.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_ds_BaiDangTuyen_CellMouseClick);
            // 
            // contextMenuStrip_xemchitiet
            // 
            this.contextMenuStrip_xemchitiet.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip_xemchitiet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemChiTiếtToolStripMenuItem});
            this.contextMenuStrip_xemchitiet.Name = "contextMenuStrip_xemchitiet";
            this.contextMenuStrip_xemchitiet.Size = new System.Drawing.Size(158, 28);
            // 
            // xemChiTiếtToolStripMenuItem
            // 
            this.xemChiTiếtToolStripMenuItem.Name = "xemChiTiếtToolStripMenuItem";
            this.xemChiTiếtToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.xemChiTiếtToolStripMenuItem.Text = "Xem chi tiết";
            this.xemChiTiếtToolStripMenuItem.Click += new System.EventHandler(this.xemChiTiếtToolStripMenuItem_Click);
            // 
            // UserControl_BaiDangTuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContextMenuStrip = this.contextMenuStrip_xemchitiet;
            this.Controls.Add(this.button_DangKy);
            this.Controls.Add(this.button_TimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_TimKiem);
            this.Controls.Add(this.dataGridView_ds_BaiDangTuyen);
            this.Controls.Add(this.label_MaDoanhNghiep);
            this.Controls.Add(this.label_DoanhNghiep);
            this.Name = "UserControl_BaiDangTuyen";
            this.Size = new System.Drawing.Size(1087, 709);
            this.Load += new System.EventHandler(this.UserControl_BaiDangTuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ds_BaiDangTuyen)).EndInit();
            this.contextMenuStrip_xemchitiet.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_DoanhNghiep;
        private System.Windows.Forms.Label label_MaDoanhNghiep;
        private System.Windows.Forms.Button button_DangKy;
        private System.Windows.Forms.Button button_TimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_TimKiem;
        private System.Windows.Forms.DataGridView dataGridView_ds_BaiDangTuyen;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_xemchitiet;
        private System.Windows.Forms.ToolStripMenuItem xemChiTiếtToolStripMenuItem;
    }
}