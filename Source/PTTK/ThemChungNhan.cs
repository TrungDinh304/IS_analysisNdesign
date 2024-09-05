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
    public partial class ThemChungNhan : Form
    {
        public ThemChungNhan(string MaUngVien)
        {
            InitializeComponent();
            label3.Text = MaUngVien;
        }

        private void ThemChungNhan_Load(object sender, EventArgs e)
        {
            String MaUngVien = label3.Text;
            // Lấy tên ứng viên
            DataSet data3 = new DataSet();
            String query3 = $"SELECT TenUngVien FROM ADMIN2.UNGVIEN WHERE MAUNGVIEN = '{MaUngVien}'";
            using (OracleConnection connection = new OracleConnection(ConnectionStr.connectionStr))
            {
                connection.Open();
                OracleDataAdapter adapter = new OracleDataAdapter(query3, connection);
                adapter.Fill(data3);

                connection.Close();
            }
            textBox1.Text = data3.Tables[0].Rows[0]["TenUngVien"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra các TextBox không được rỗng
            if (string.IsNullOrEmpty(textBox1.Text) ||
                string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox3.Text) ||
                string.IsNullOrEmpty(textBox4.Text) ||
                string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return; // Không thực hiện thêm dữ liệu nếu có TextBox rỗng
            }

            // Kiểm tra ngày cấp phải trước ngày hết hạn
            if (dateTimePicker1.Value >= dateTimePicker2.Value)
            {
                MessageBox.Show("Ngày cấp hoặc ngày hết hạn không hợp lệ");
                return; // Không thực hiện thêm dữ liệu nếu ngày cấp không hợp lệ
            }


            String MaUngVien = label3.Text;
            String TenChungNhan = textBox2.Text;
            String ChuyenNganh = textBox5.Text;
            String LoaiBang = textBox3.Text;
            DateTime selectedDate1 = dateTimePicker1.Value.Date;
            DateTime selectedDate2 = dateTimePicker2.Value.Date;
            String NgayCap = selectedDate1.ToShortDateString();
            String NgayHetHan = selectedDate2.ToShortDateString();
            String ToChucCap = textBox4.Text;

            // Tạo ID
            string query1 = "SELECT COUNT(*) AS SOLUONG FROM ADMIN2.CHUNGNHAN";
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
            int SOCN = Convert.ToInt32(ds.Tables[0].Rows[0]["SOLUONG"].ToString());
            SOCN += 1;
            String ID = "CN" + SOCN.ToString("D3");

            // Thêm chứng nhận
            string query2 = $"INSERT INTO ADMIN2.CHUNGNHAN VALUES('{MaUngVien}', '{ID}','{TenChungNhan}', '{ChuyenNganh}', '{LoaiBang}',TO_DATE('{NgayCap}','MM-DD-YYYY'),TO_DATE('{NgayHetHan}','MM-DD-YYYY'), '{ToChucCap}')";
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
                MessageBox.Show("Thêm chứng nhận ứng tuyển thành công");
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                MessageBox.Show("Thêm chứng nhận ứng tuyển thất bại: " + ex.Message);
            }

        }
    }
}
