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
    public partial class UserControl_BaiDangTuyen : UserControl
    {
        public UserControl_BaiDangTuyen()
        {
            InitializeComponent();
        }
        string current;
        string TenCongTy;

        public UserControl_BaiDangTuyen(string key)
        {
            InitializeComponent();
            DoanhNghiep current_DN = new DoanhNghiep().TimKiem_DoanhNghiep(key)[0];
            current = current_DN.MaDoanhNghiep;
            TenCongTy = current_DN.TenCongTy;
            this.label_MaDoanhNghiep.Text += current_DN.MaDoanhNghiep;
        }

        private void label_DoanhNghiep_Click(object sender, EventArgs e)
        {
            TrangChu trangChu = (TrangChu)this.FindForm();
            trangChu.radioButton_DoanhNghiep.Checked = true;
            trangChu.openUC(new UserControl_DoanhNghiep());
        }

        private void button_TimKiem_Click(object sender, EventArgs e)
        {
            List<DangTuyen> list = new DangTuyen().TimKiem_DangTuyen(textBox_TimKiem.Text, current);
            DataTable table = ConvertToDataTable(list);
            dataGridView_ds_BaiDangTuyen.DataSource = table;
            dataGridView_ds_BaiDangTuyen.Columns[1].Visible = false;
            dataGridView_ds_BaiDangTuyen.Columns[8].Visible = false;
            dataGridView_ds_BaiDangTuyen.Columns[10].Visible = false;
        }
        private DataTable ConvertToDataTable(List<DangTuyen> dangTuyens)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Mã Đăng Tuyển", typeof(string));
            table.Columns.Add("Mã Doanh Nghiệp", typeof(string));
            table.Columns.Add("Hình Thức Đăng Tuyển", typeof(string));
            table.Columns.Add("Ngày Lập", typeof(string));
            table.Columns.Add("Ngày Đăng Tuyển", typeof(string));
            table.Columns.Add("Thời Hạn", typeof(int));
            table.Columns.Add("Vị Trí Ứng Tuyển", typeof(string));
            table.Columns.Add("Số Lượng", typeof(int));
            table.Columns.Add("Yêu Cầu Cho Ứng Viên", typeof(string));
            table.Columns.Add("Trạng Thái", typeof(string));
            table.Columns.Add("Link Đăng Bài", typeof(string));
            foreach (var dangTuyen in dangTuyens)
            {
                table.Rows.Add(dangTuyen.MaDangTuyen, dangTuyen.MaDoanhNghiep, dangTuyen.HinhThucDangTuyen,
                    dangTuyen.NgayLap, dangTuyen.NgayDangTuyen, dangTuyen.ThoiHan, dangTuyen.ViTriUngTuyen,
                    dangTuyen.SoLuong, dangTuyen.YeuCauChoUngVien, dangTuyen.TrangThai, dangTuyen.LinkDangBai);
            }
            return table;
        }

        private void UserControl_BaiDangTuyen_Load(object sender, EventArgs e)
        {
            button_TimKiem_Click(sender, e);
        }

        private void textBox_TimKiem_TextChanged(object sender, EventArgs e)
        {
            button_TimKiem_Click(sender, e);
        }

        private void dataGridView_ds_BaiDangTuyen_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dataGridView_ds_BaiDangTuyen.ClearSelection();
                dataGridView_ds_BaiDangTuyen.Rows[e.RowIndex].Selected = true;
                contextMenuStrip_xemchitiet.Show(Cursor.Position);
            }
        }

        private void dataGridView_ds_BaiDangTuyen_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_ds_BaiDangTuyen.ClearSelection();
            dataGridView_ds_BaiDangTuyen.Rows[e.RowIndex].Selected = true;
            contextMenuStrip_xemchitiet.Show(Cursor.Position);
        }

        private void xemChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Xem_Them_BaiDang form_Xem_Them_BaiDang = new Form_Xem_Them_BaiDang(dataGridView_ds_BaiDangTuyen.SelectedRows[0].Cells[0].Value.ToString(), current);
            form_Xem_Them_BaiDang.ShowDialog();
        }

        private void button_DangKy_Click(object sender, EventArgs e)
        {
            Form_Xem_Them_BaiDang form_Xem_Them_BaiDang = new Form_Xem_Them_BaiDang(current);
            form_Xem_Them_BaiDang.ShowDialog();
            UserControl_BaiDangTuyen_Load(sender, e);
        }
    }
}