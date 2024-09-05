using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTK
{
    public partial class TaoHoSo : Form
    {
        public TaoHoSo(string MaUngVien)
        {
            InitializeComponent();
            THS_label3.Text = MaUngVien;
        }

        private void TaoHoSo_Load(object sender, EventArgs e)
        {
            HienThi();
        }


        private void HienThi()
        {
            String MaUngVien = THS_label3.Text;
            DataSet data2 = new DataSet();
            String query2 = $"SELECT TenUngVien FROM ADMIN2.UNGVIEN WHERE MAUNGVIEN = '{MaUngVien}'";
            using (OracleConnection connection = new OracleConnection(ConnectionStr.connectionStr))
            {
                connection.Open();
                OracleDataAdapter adapter = new OracleDataAdapter(query2, connection);
                adapter.Fill(data2);

                connection.Close();
            }
            THS_label7.Text = data2.Tables[0].Rows[0]["TenUngVien"].ToString();

            // Call getAllUser to retrieve data
            DataSet data = new DataSet();
            String query = $"SELECT DT.MADANGTUYEN, DN.TENCONGTY, DT.VITRIUNGTUYEN " +
                $"FROM ADMIN2.DANGTUYEN DT JOIN ADMIN2.DOANHNGHIEP DN ON DT.MADOANHNGHIEP = DN.MADOANHNGHIEP " +
                $"WHERE DT.MADANGTUYEN NOT IN (SELECT MADANGTUYEN FROM ADMIN2.HOSOUNGTUYEN WHERE MAUNGVIEN = '{MaUngVien}')";
            using (OracleConnection connection = new OracleConnection(ConnectionStr.connectionStr))
            {
                connection.Open();
                OracleDataAdapter adapter = new OracleDataAdapter(query, connection);
                adapter.Fill(data);

                connection.Close();
            }

            // Tìm cột DataGridViewCheckBoxColumn cần xóa
            DataGridViewColumn columnToRemove = THS_dataGridView1.Columns["checkBoxColumn"];

            // Kiểm tra nếu cột tồn tại
            if (columnToRemove != null)
            {
                // Xóa cột khỏi DataGridView
                THS_dataGridView1.Columns.Remove(columnToRemove);
            }
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            
            // Check if there is at least one table in the DataSet
            if (data.Tables.Count > 0)
            {
                // Set the DataGridView DataSource to the first table in the DataSet
                THS_dataGridView1.DataSource = data.Tables[0];
                THS_dataGridView1.Columns.Add(checkBoxColumn);
                checkBoxColumn.HeaderText = "Chọn";
                checkBoxColumn.Name = "checkboxColumn";
                THS_dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                THS_dataGridView1.Columns[0].HeaderText = "Mã đăng tuyển";
                THS_dataGridView1.Columns[1].HeaderText = "Tên công ty";
                THS_dataGridView1.Columns[2].HeaderText = "Vị trí ứng tuyển";
                THS_dataGridView1.Columns[3].HeaderText = "Chọn";
                
            }
            //THS_dataGridView1.Columns["Chọn"].DisplayIndex = THS_dataGridView1.RowCount - 1;

        }

        private void THS_textBox1_TextChanged(object sender, EventArgs e)
        {
            String MaUngVien = THS_label3.Text;
            // Lấy dữ liệu từ TextBox
            string input = THS_textBox1.Text.Trim();

            // Tìm cột DataGridViewCheckBoxColumn cần xóa
            DataGridViewColumn columnToRemove = THS_dataGridView1.Columns["checkBoxColumn"];

            // Kiểm tra nếu cột tồn tại
            if (columnToRemove != null)
            {
                // Xóa cột khỏi DataGridView
                THS_dataGridView1.Columns.Remove(columnToRemove);
            }
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();

            // Kiểm tra xem người dùng đã nhập tên người dùng hay chưa
            if (!string.IsNullOrEmpty(input))
            {
                // Gọi phương thức để lấy dữ liệu từ cơ sở dữ liệu và hiển thị trên DataGridView
                // Format font column headers
                this.THS_dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

                // Format font row
                foreach (DataGridViewRow row in THS_dataGridView1.Rows)
                {
                    row.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
                }
                // Tạo câu truy vấn dựa trên input
                String query = $"SELECT DT.MADANGTUYEN, DN.TENCONGTY, DT.VITRIUNGTUYEN " +
                $"FROM ADMIN2.DANGTUYEN DT JOIN ADMIN2.DOANHNGHIEP DN ON DT.MADOANHNGHIEP = DN.MADOANHNGHIEP " +
                $"WHERE DT.MADANGTUYEN NOT IN (SELECT MADANGTUYEN FROM ADMIN2.HOSOUNGTUYEN WHERE MAUNGVIEN = '{MaUngVien}') AND DT.VITRIUNGTUYEN LIKE '%{input}%'";

                // Gọi phương thức để thực hiện truy vấn
                DataSet data = new DataSet();
                using (OracleConnection connection = new OracleConnection(ConnectionStr.connectionStr))
                {
                    connection.Open();
                    OracleDataAdapter adapter = new OracleDataAdapter(query, connection);
                    adapter.Fill(data);
                    connection.Close();
                }


                // Hiển thị dữ liệu trên DataGridView
                THS_dataGridView1.DataSource = data.Tables[0];
                THS_dataGridView1.Columns.Add(checkBoxColumn);
                checkBoxColumn.HeaderText = "Chọn";
                checkBoxColumn.Name = "checkboxColumn";
                THS_dataGridView1.Columns[0].HeaderText = "Mã đăng tuyển";
                THS_dataGridView1.Columns[1].HeaderText = "Tên công ty";
                THS_dataGridView1.Columns[2].HeaderText = "Vị trí ứng tuyển";
            }
            else
            {
                HienThi();
            }

            
        }

        private void THS_button1_Click(object sender, EventArgs e)
        {
            for (int i = 0;i < THS_dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToBoolean(THS_dataGridView1.Rows[i].Cells[3].Value) == true)
                {
                    ThemHoSo(i);
                }
            }
        }

        private void ThemHoSo(int i)
        {
            string query0 = "SELECT TO_CHAR(SYSDATE, 'DD-MM-YYYY') AS CURRENT_DATE FROM dual";
            DataSet ds0 = new DataSet();
            try
            {
                // Mở kết nối đến cơ sở dữ liệu
                using (OracleConnection connection = new OracleConnection(ConnectionStr.connectionStr))
                {
                    connection.Open();
                    OracleDataAdapter adapter = new OracleDataAdapter(query0, connection);
                    adapter.Fill(ds0);
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                MessageBox.Show("Lỗi khi kiểm tra sự tồn tại của người dùng: " + ex.Message);
            }
            String NGAYLAP = ds0.Tables[0].Rows[0]["CURRENT_DATE"].ToString();

            string query1 = "SELECT COUNT(*) AS SOLUONG FROM ADMIN2.HOSOUNGTUYEN";
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
            int SOHOSO = Convert.ToInt32(ds.Tables[0].Rows[0]["SOLUONG"].ToString());
            SOHOSO += 1;

            String MAHOSO = "HS" + SOHOSO.ToString("D3");

            DataGridViewRow t = THS_dataGridView1.Rows[i];
            
            String MAUNGVIEN = THS_label3.Text;
            String MADANGTUYEN = t.Cells[0].Value.ToString();
            String TRANGTHAIHOSO = "đang chờ duyệt";
            String VITRIUNGTUYEN = t.Cells[2].Value.ToString();
            int DOUUTIEN = 0;
            

            string query2 = $"INSERT INTO ADMIN2.HOSOUNGTUYEN VALUES('{MAHOSO}', '{MAUNGVIEN}','{MADANGTUYEN}', '{TRANGTHAIHOSO}', '{VITRIUNGTUYEN}',{DOUUTIEN}, NULL,TO_DATE('{NGAYLAP}','DD-MM-YYYY'), NULL)";
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
                MessageBox.Show("Thêm hồ sơ ứng tuyển thành công");
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                MessageBox.Show("Thêm hồ sơ ứng tuyển thất bại: " + ex.Message);
            }

            HienThi();
        }


        
    }
}
