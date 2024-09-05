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
    public partial class BLD_CHINHSACH : Form
    {
        public BLD_CHINHSACH()
        {
            InitializeComponent();
        }

        private void BLD_CHINHSACH_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            // Call getAllUser to retrieve data
            DataSet userData = getAll();

            // Check if there is at least one table in the DataSet
            if (userData.Tables.Count > 0)
            {
                // Set the DataGridView DataSource to the first table in the DataSet
                bld_cs_dataGridView1.DataSource = userData.Tables[0];
                bld_cs_dataGridView1.Columns[0].HeaderText = "Mã chính sách";
                bld_cs_dataGridView1.Columns[1].HeaderText = "Tên chính sách";
                bld_cs_dataGridView1.Columns[2].HeaderText = "Mô tả chính sách";
                bld_cs_dataGridView1.Columns[3].HeaderText = "Trạng thái hoạt động";
            }
        }

        /*Hiển thị tất cả chính sách */
        DataSet getAll()
        {
            DataSet data = new DataSet();
            String query = "select * from ADMIN2.CHINHSACH";
            using (OracleConnection connection = new OracleConnection(ConnectionStr.connectionStr))
            {
                connection.Open();
                OracleDataAdapter adapter = new OracleDataAdapter(query, connection);
                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }

        // tìm kiếm kế hoạch mở theo mã
        private void bld_cs_textBox1_TextChanged(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ TextBox
            string username = bld_cs_textBox1.Text.Trim();
            // Kiểm tra xem người dùng đã nhập tên người dùng hay chưa
            if (!string.IsNullOrEmpty(username))
            {
                // Gọi phương thức để lấy dữ liệu từ cơ sở dữ liệu và hiển thị trên DataGridView
                LoadData(username);
            }
            else
            {
                LoadData();
            }
        }

        private void LoadData(string input)
        {
            // Format font column headers
            this.bld_cs_dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            // Format font row
            foreach (DataGridViewRow row in bld_cs_dataGridView1.Rows)
            {
                row.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            }
            // Tạo câu truy vấn dựa trên username
            string query = $"SELECT * FROM ADMIN2.CHINHSACH WHERE MaChinhSach LIKE '%{input}%' OR Ten LIKE '%{input}%' OR MoTa LIKE '%{input}%'";

            // Gọi phương thức để thực hiện truy vấn
            DataSet userData = GetDataFromDatabase(query);

            // Hiển thị dữ liệu trên DataGridView
            bld_cs_dataGridView1.DataSource = userData.Tables[0];

        }

        private DataSet GetDataFromDatabase(string query)
        {
            DataSet data = new DataSet();
            using (OracleConnection connection = new OracleConnection(ConnectionStr.connectionStr))
            {
                connection.Open();
                OracleDataAdapter adapter = new OracleDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        private int indexOfContent;

        private void bld_cs_dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            indexOfContent = e.RowIndex;
            if (e.Button == MouseButtons.Right && indexOfContent > -1)
            {
                DataGridViewRow t = bld_cs_dataGridView1.Rows[indexOfContent];
                if (!t.IsNewRow)
                {
                    bld_cs_contextMenuStrip1.Show(bld_cs_dataGridView1, e.Location);
                    bld_cs_contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void hoạtĐộngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow t = bld_cs_dataGridView1.Rows[indexOfContent];
            t.Cells[3].Value = this.hoạtĐộngToolStripMenuItem.Text;
        }

        private void khôngHoạtĐộngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow t = bld_cs_dataGridView1.Rows[indexOfContent];
            t.Cells[3].Value = this.khôngHoạtĐộngToolStripMenuItem.Text;
        }

        private void bld_cs_button1_Click(object sender, EventArgs e)
        {
            // Duyệt từng hàng trong DataGridView
            foreach (DataGridViewRow row in bld_cs_dataGridView1.Rows)
            {
                // Kiểm tra nếu hàng không phải là hàng mới (new row)
                if (!row.IsNewRow)
                {
                    string MACS = row.Cells[0].Value.ToString();
                    string TT = row.Cells[3].Value.ToString();
                    // gọi hàm update
                    updateTrangThaiChinhSach(MACS, TT);
                }
            }
            MessageBox.Show("Danh sách chính sách được cập nhật thành công!");
        }

        private void updateTrangThaiChinhSach(string MACS, string TT)
        {
            string query = $"UPDATE ADMIN2.CHINHSACH SET TrangThai='{TT}' WHERE MaChinhSach='{MACS}'";

            try
            {
                using (OracleConnection connection = new OracleConnection(ConnectionStr.connectionStr))
                {
                    connection.Open();
                    using (OracleCommand alterSessionCommand = new OracleCommand(query, connection))
                    {
                        alterSessionCommand.ExecuteNonQuery();
                    }
                }
                //MessageBox.Show("Chính sách đã được cập nhật thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void bld_cs_button2_Click(object sender, EventArgs e)
        {
            Form nextForm = new BLD_UC_THEMCHINHSACH();
            nextForm.Show();
            bld_cs_button2.Enabled = false;
            nextForm.FormClosed += (s, args) =>
            {
                bld_cs_button2.Enabled = true;
                LoadData();
            };
        }
    }
}
