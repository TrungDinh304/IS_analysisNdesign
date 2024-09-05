using PTTK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTK
{
    public partial class BaiDangTuyen : Form
    {
        public BaiDangTuyen()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            DangTuyen_DAO dao = new DangTuyen_DAO();
            List<DangTuyen> list = dao.TimKiem_DangTuyen("key", "DN");

            dataGridViewDangTuyen.ColumnCount = 5;
            dataGridViewDangTuyen.Columns[0].Name = "ID";
            dataGridViewDangTuyen.Columns[1].Name = "Tên DN";
            dataGridViewDangTuyen.Columns[2].Name = "Vị trí";
            dataGridViewDangTuyen.Columns[3].Name = "Số lượng";
            dataGridViewDangTuyen.Columns[4].Name = "Trạng thái";

            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "Chi tiết";
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
            if (e.ColumnIndex == dataGridViewDangTuyen.Columns["Chi tiết"].Index && e.RowIndex >= 0)
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
                if (row.Cells["Tên DN"].Value.ToString().ToLower().Contains(filterText) ||
                    row.Cells["Vị trí"].Value.ToString().ToLower().Contains(filterText))
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
    }
}
