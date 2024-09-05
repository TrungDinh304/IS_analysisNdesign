using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTTK;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace PTTK
{
    public partial class UserControl_DoanhNghiep : UserControl
    {
        public UserControl_DoanhNghiep()
        {
            InitializeComponent();
        }

        private void button_TimKiem_Click(object sender, EventArgs e)
        {
            //lấy danh sách doanh nghiệp từ hàm

            List<DoanhNghiep> list = new DoanhNghiep().TimKiem_DoanhNghiep(textBox_TimKiem.Text);
            
            DataTable table = ConvertToDataTable(list);

            //đổ dữ liệu từ list vào datagridview
            dataGridView_ds_DoanhNgiep.DataSource = table;
        }

        private DataTable ConvertToDataTable(List<DoanhNghiep> products)
        {
            DataTable table = new DataTable();

            // Thêm cột vào DataTable
            table.Columns.Add("Mã Doanh Nghiệp", typeof(string));
            table.Columns.Add("Tên Công Ty", typeof(string));
            table.Columns.Add("Địa Chỉ", typeof(string));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("Mã Số Thuế", typeof(string));
            table.Columns.Add("Ngày Đăng Ký", typeof(DateTime));
            table.Columns.Add("Người Đại Diện", typeof(string));
            table.Columns.Add("Trạng Thái", typeof(string));

            // Thêm hàng vào DataTable
            foreach (var product in products)
            {
                table.Rows.Add(product.MaDoanhNghiep, product.TenCongTy, product.DiaChi, product.Email, product.MaSoThue, product.NgayDangKy, product.NguoiDaiDien, product.TrangThai);
            }

            return table;
        }

        private void UserControl_DoanhNghiep_Load(object sender, EventArgs e)
        {
            button_TimKiem_Click(sender, e);
        }

        private void dataGridView_dsDoanhNghiep_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Nếu người dùng click chuột phải vào ô nào thì hiển thị menu strip
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    //Nếu người dùng click chuột phải vào hàng nào thì chọn hàng đó
                    dataGridView_ds_DoanhNgiep.ClearSelection();
                    dataGridView_ds_DoanhNgiep.Rows[e.RowIndex].Selected = true;
                    //kiểm tra xem đó có phải là row hay không
                    if (e.RowIndex != -1)
                    {
                        return;
                    }
                    //Hiển thị menu strip option
                    contextMenuStrip_Option.Show(Cursor.Position);
                }
            }
            catch
            {
                return;
            }

        }

        
        private void cácPhiếuĐăngTuyểnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                UserControl_BaiDangTuyen uc = new UserControl_BaiDangTuyen();
                TrangChu trangChu = (TrangChu)this.FindForm();


                //Lấy mã doanh nghiệp từ datagridview
                string maDoanhNghiep = dataGridView_ds_DoanhNgiep.SelectedRows[0].Cells[0].Value.ToString();
                //Mở uc_BaiDangTuyen với mã doanh nghiệp tương ứng
                uc = new UserControl_BaiDangTuyen(maDoanhNghiep);
                trangChu.openUC(uc);
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn doanh nghiệp cần xem");
            }
        }

        private void textBox_TimKiem_TextChanged(object sender, EventArgs e)
        {
            button_TimKiem_Click(sender, e);
        }

        private void button_DangKy_Click(object sender, EventArgs e)
        {
            Form_DangKyDN f_dangki = new Form_DangKyDN();

            f_dangki.ShowDialog();
            UserControl_DoanhNghiep_Load(sender, e);
        }

        private void xemChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form_DangKyDN form_DangKyDN = new Form_DangKyDN(dataGridView_ds_DoanhNgiep.SelectedRows[0].Cells[0].Value.ToString());
                form_DangKyDN.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn doanh nghiệp cần xem chi tiết");
            }
        }
    }
}
