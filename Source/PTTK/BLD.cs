using Oracle.ManagedDataAccess.Client;
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
    public partial class BLD : Form
    {
        public BLD()
        {
            InitializeComponent();
        }

        private void BLD_Load(object sender, EventArgs e)
        {
            bld_label2.Text = "Xin chào " + Login_information.fullname;
            if (KiemTraThoiGianChinhSuaHopLe())
            {
                OpenChildForm(new BLD_DOANHNGHIEP());
                bld_label1.Text = bld_button_dn.Text;
            }
            else
            {
                bld_label2.Text = "Chưa đến thời gian xem xét gia hạn doanh nghiệp sắp hết hạn hợp đồng. Thời gian xem xét gia hạn từ ngày 27 hàng tháng";
            }
        }

        private Form currentFormChild;

        private void OpenChildForm(Form chilForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = chilForm;
            chilForm.TopLevel = false;
            chilForm.FormBorderStyle = FormBorderStyle.None;
            chilForm.Dock = DockStyle.Fill;
            bld_panel_body.Controls.Add(chilForm);
            bld_panel_body.Tag = chilForm;
            chilForm.BringToFront();
            chilForm.Show();
        }

        private void bld_pictureBox_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            bld_label1.Text = "Trang chủ";
        }

        private void bld_button_dn_Click(object sender, EventArgs e)
        {
            if (KiemTraThoiGianChinhSuaHopLe())
            {
                OpenChildForm(new BLD_DOANHNGHIEP());
                bld_label1.Text = bld_button_dn.Text;
            }
            else
            {
                bld_label2.Text = "Chưa đến thời gian xem xét gia hạn doanh nghiệp sắp hết hạn hợp đồng. Thời gian xem xét gia hạn từ ngày 27 hàng tháng";
            }
            
        }

        private void bld_button_cs_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BLD_CHINHSACH());
            bld_label1.Text = bld_button_cs.Text;
        }

        private void bld_button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool KiemTraThoiGianChinhSuaHopLe()
        {
            string query1 = "SELECT TO_CHAR(SYSDATE, 'DD') AS TODAY FROM DUAL";
            DataSet ds = new DataSet();
            try
            {
                // Mở kết nối đến cơ sở dữ liệu
                using (OracleConnection connection = new OracleConnection(ConnectionStr.connectionStr))
                {
                    connection.Open();
                    OracleDataAdapter adapter = new OracleDataAdapter(query1, connection);
                    adapter.Fill(ds);
                    connection.Close();

                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                MessageBox.Show("Lỗi khi kiểm tra sự tồn tại của người dùng: " + ex.Message);
            }

            int today = Convert.ToInt32(ds.Tables[0].Rows[0]["TODAY"].ToString());
            return today > 26;
        }


    }
}
