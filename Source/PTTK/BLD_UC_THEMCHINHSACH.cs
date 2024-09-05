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
    public partial class BLD_UC_THEMCHINHSACH : Form
    {
        public BLD_UC_THEMCHINHSACH()
        {
            InitializeComponent();
        }

        private void bld_tcs_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string TRANGTHAI = bld_tcs_comboBox1.SelectedItem.ToString();
        }

        private void BLD_UC_THEMCHINHSACH_Load(object sender, EventArgs e)
        {

        }
        private void ThemChinhSach()
        {
            string query1 = "SELECT COUNT(*) AS SOLUONG FROM ADMIN2.CHINHSACH";
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
            int SOCHINHSACH = Convert.ToInt32(ds.Tables[0].Rows[0]["SOLUONG"].ToString());
            SOCHINHSACH += 1;

            string MACHINHSACH = "CS" + SOCHINHSACH.ToString("D3");
            string TEN = bld_tcs_textBox1.Text;
            string MOTA = bld_tcs_textBox2.Text;
            string TRANGTHAI = bld_tcs_comboBox1.SelectedItem.ToString();

            string query2 = $"INSERT INTO ADMIN2.CHINHSACH VALUES('{MACHINHSACH}', '{TEN}','{MOTA}', '{TRANGTHAI}')";
            DataSet dt = new DataSet();
            try
            {
                // Mở kết nối đến cơ sở dữ liệu
                using (OracleConnection connection = new OracleConnection(ConnectionStr.connectionStr))
                {
                    connection.Open();
                    OracleDataAdapter adapter = new OracleDataAdapter(query2, connection);
                    adapter.Fill(dt);
                    connection.Close();
                }
                MessageBox.Show("Thêm chính sách thành công");
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                MessageBox.Show("Thêm chính sách thất bại: " + ex.Message);
            }
            //MessageBox.Show(query2);

        }

        private void bld_tcs_button1_Click(object sender, EventArgs e)
        {
            ThemChinhSach();
        }

        private void bld_tcs_button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
