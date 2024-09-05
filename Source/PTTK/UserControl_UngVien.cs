using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations.Model;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PTTK
{
    public partial class UserControl_UngVien : UserControl
    {
        private String defaultText = "# Tìm theo tên ứng viên";
        public event EventHandler RequestOpenUserControl2;
        private String MaUngVien;
        public UserControl_UngVien()
        {
            InitializeComponent();
        }

        private void HienThi()
        {
            // Loading data (Invoke returning a table to fit triple-layer model.
            // Call getAllUser to retrieve data
            DataSet data = UngVien.LayDanhSach(null);

            tbUngVien.DataSource = data.Tables[0];

            tbUngVien.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tbUngVien.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            // Tìm cột DataGridViewCheckBoxColumn cần xóa
            //DataGridViewColumn columnToRemove = tbUngVien.Columns["checkBoxColumn"];

            //// Kiểm tra nếu cột tồn tại
            //if (columnToRemove != null)
            //{
            //    // Xóa cột khỏi DataGridView
            //    THS_dataGridView1.Columns.Remove(columnToRemove);
            //}

            // Button Column (Style và thêm vào bảng)
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Text = "Chi tiết";
            buttonColumn.UseColumnTextForButtonValue = true;
            buttonColumn.DefaultCellStyle.BackColor = Color.RoyalBlue;
            buttonColumn.DefaultCellStyle.ForeColor = Color.White;
            ; buttonColumn.FlatStyle = FlatStyle.Popup;
            buttonColumn.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);
            tbUngVien.Columns.Add(buttonColumn);

            // Add all other columns:
            buttonColumn.HeaderText = "";
            buttonColumn.Name = "buttonColumn";

            tbUngVien.Columns[0].HeaderText = "ID";
            tbUngVien.Columns[1].HeaderText = "Tên ứng viên";
            tbUngVien.Columns[2].HeaderText = "Ngày sinh";
            tbUngVien.Columns[3].HeaderText = "Địa chỉ";
            tbUngVien.Columns[4].HeaderText = "SĐT";

            tbUngVien.CellClick += new DataGridViewCellEventHandler(tbUngVien_CellClick);
        }

        private void UserControl_UngVien_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void tbUngVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != tbUngVien.Columns["buttonColumn"].Index) return;

            // Code xử lý đi tới trang chi tiết ứng viên
            MaUngVien = tbUngVien.Rows[e.RowIndex].Cells[1].Value.ToString();
            // Khi người dùng click button để yêu cầu mở UserControl2
            OnRequestOpenUserControl2();
            // Test
            //MessageBox.Show("Đi tới trang chi tiết ứng viên");
        }
        protected virtual void OnRequestOpenUserControl2()
        {
            RequestOpenUserControl2?.Invoke(this, EventArgs.Empty);
        }
        // Phương thức để lấy dữ liệu từ bên ngoài
        public string GetUserData()
        {
            return MaUngVien;
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                String ten = null;
                if (txtTenUV.Text.Length != 0 && txtTenUV.Text != defaultText)
                {
                    ten = txtTenUV.Text;
                }
                DataSet data = UngVien.LayDanhSach(ten);

                if (data.Tables.Count > 0)
                {
                    tbUngVien.DataSource = data.Tables[0];
                }
            }
            catch
            {
                MessageBox.Show("Lỗi: Sự cố không ngờ đã xảy ra khi đọc dữ liệu.");
            }
        }

        private void btn_MHDangKy_Click(object sender, EventArgs e)
        {
            Form parent = this.FindForm();

            // Minor error prevention
            if (parent == null)
            {
                MessageBox.Show("Sự cố không ngờ xảy ra không thể mở trang đăng kí.");
                return;
            }

            MH_DangKyUngVien form = new MH_DangKyUngVien
            {
                StartPosition = FormStartPosition.Manual
            };

            Point p = parent.Location;
            Size original = parent.Size;
            Size popupSize = form.Size;

            int x = p.X + (original.Width - popupSize.Width) / 2;
            int y = p.Y + (original.Height - popupSize.Height) / 2;

            form.Location = new Point(x, y);

            form.ShowDialog();
        }

        private void txtTenUV_Enter(object sender, EventArgs e)
        {
            txtTenUV.Text = "";
            txtTenUV.ForeColor = Color.Black;
        }

        private void txtTenUV_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenUV.Text))
            {
                txtTenUV.Text = defaultText;
                txtTenUV.ForeColor = Color.Gray;
            }
        }
    }
}