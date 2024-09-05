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
    public partial class UserControl_BaiDangTuyen_2 : UserControl
    {
        public UserControl_BaiDangTuyen_2()
        {
            InitializeComponent();
            LoadData("");
        }

        public UserControl_BaiDangTuyen_2(string maDoanhNghiep)
        {
            InitializeComponent();
            LoadData(maDoanhNghiep);
        }

        private void LoadData(string maDoanhNghiep)
        {
            DangTuyen_DAO dao = new DangTuyen_DAO();
            List<DangTuyen> list = dao.TimKiem_DangTuyen("", maDoanhNghiep);

            dataGridViewDangTuyen.ColumnCount = 5;
            dataGridViewDangTuyen.Columns[0].Name = "ID";
            dataGridViewDangTuyen.Columns[1].Name = "Mã DN";
            dataGridViewDangTuyen.Columns[2].Name = "Vị trí";
            dataGridViewDangTuyen.Columns[3].Name = "Số lượng";
            dataGridViewDangTuyen.Columns[4].Name = "Trạng thái";

            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "Chi tiết";
            btnColumn.Name = "Chi tiết"; // Đặt tên cột nút là "Chi tiết"
            btnColumn.Text = "Chi tiết";
            btnColumn.UseColumnTextForButtonValue = true;
            dataGridViewDangTuyen.Columns.Add(btnColumn);

            dataGridViewDangTuyen.Rows.Clear();
            foreach (DangTuyen item in list)
            {
                dataGridViewDangTuyen.Rows.Add(item.MaDangTuyen, item.MaDoanhNghiep, item.ViTriUngTuyen, item.SoLuong, item.TrangThai);
            }

            dataGridViewDangTuyen.CellClick += new DataGridViewCellEventHandler(dataGridViewDangTuyen_CellClick);
        }

        private void dataGridViewDangTuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewDangTuyen.Columns["Chi tiết"].Index)
            {
                string maDangTuyen = dataGridViewDangTuyen.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                DangTuyen_DAO dao = new DangTuyen_DAO();
                DangTuyen dangTuyen = dao.LayChiTietDangTuyen(maDangTuyen);

                ChiTiet_BaiDang formChiTiet = new ChiTiet_BaiDang();
                formChiTiet.HienThiChiTiet(dangTuyen);
                formChiTiet.ShowDialog();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string filterText = txtSearch.Text.ToLower();
            foreach (DataGridViewRow row in dataGridViewDangTuyen.Rows)
            {
                if (row.Cells["ID"].Value.ToString().ToLower().Contains(filterText) ||
                    row.Cells["Mã DN"].Value.ToString().ToLower().Contains(filterText))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        private void txtMaDangTuyen_Enter(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtSearch.ForeColor = Color.Black;
        }

        private String defaultText = "Nhập mã đăng tuyển ...";

        private void txtMaDangTuyen_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = defaultText;
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void UserControl_BaiDangTuyen_Load(object sender, EventArgs e)
        {
            //LoadData("");
        }
    }
}
