using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTK
{
    public partial class BLD_DOANHNGHIEP : Form
    {
        public BLD_DOANHNGHIEP()
        {
            InitializeComponent();
        }

        private void BLD_DOANHNGHIEP_Load(object sender, EventArgs e)
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
                bld_dn_dataGridView1.DataSource = userData.Tables[0];
                bld_dn_dataGridView1.Columns[0].HeaderText = "Mã doanh nghiệp";
                bld_dn_dataGridView1.Columns[1].HeaderText = "Tên doanh nghiệp";
                bld_dn_dataGridView1.Columns[2].HeaderText = "Địa chỉ";
                bld_dn_dataGridView1.Columns[3].HeaderText = "Email";
                bld_dn_dataGridView1.Columns[4].HeaderText = "Mã số thuế";
                bld_dn_dataGridView1.Columns[5].HeaderText = "Ngày đăng ký";
                bld_dn_dataGridView1.Columns[6].HeaderText = "Người đại diện";
                bld_dn_dataGridView1.Columns[7].HeaderText = "Tiềm năng công ty";
            }
        }

        /*Hiển thị tất cả chính sách */
        DataSet getAll()
        {
            DataSet data = new DataSet();
            String query = "select * from ADMIN2.V_DN_SAP_HET_HAN_BLD";
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
        private void bld_dn_textBox1_TextChanged(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ TextBox
            string username = bld_dn_textBox1.Text.Trim();
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
            this.bld_dn_dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            // Format font row
            foreach (DataGridViewRow row in bld_dn_dataGridView1.Rows)
            {
                row.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            }
            // Tạo câu truy vấn dựa trên username
            string query = $"SELECT * FROM ADMIN2.V_DN_SAP_HET_HAN_BLD WHERE MaDoanhNghiep LIKE '%{input}%' OR TenCongTy LIKE '%{input}%' OR MaSoThue LIKE '%{input}%'";

            // Gọi phương thức để thực hiện truy vấn
            DataSet userData = GetDataFromDatabase(query);

            // Hiển thị dữ liệu trên DataGridView
            bld_dn_dataGridView1.DataSource = userData.Tables[0];

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

        private void bld_dn_dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            indexOfContent = e.RowIndex;
            if (e.Button == MouseButtons.Right && indexOfContent > -1)
            {
                DataGridViewRow t = bld_dn_dataGridView1.Rows[indexOfContent];
                if (!t.IsNewRow)
                {
                    bld_dn_contextMenuStrip1.Show(bld_dn_dataGridView1, e.Location);
                    bld_dn_contextMenuStrip1.Show(Cursor.Position);
                }    
            } 

        }

        
        private void doanhNghiệpTiềmNăngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow t = bld_dn_dataGridView1.Rows[indexOfContent];
            t.Cells[7].Value = this.doanhNghiệpTiềmNăngToolStripMenuItem.Text;
        }

        private void doanhNghiệpTiềmNăngLớnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow t = bld_dn_dataGridView1.Rows[indexOfContent];
            t.Cells[7].Value = this.doanhNghiệpTiềmNăngLớnToolStripMenuItem.Text;
        }

        private void khôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow t = bld_dn_dataGridView1.Rows[indexOfContent];
            t.Cells[7].Value = this.khôngToolStripMenuItem.Text;
        }

        private void bld_dn_button1_Click(object sender, EventArgs e)
        {
            // Duyệt từng hàng trong DataGridView
            foreach (DataGridViewRow row in bld_dn_dataGridView1.Rows)
            {
                // Kiểm tra nếu hàng không phải là hàng mới (new row)
                if (!row.IsNewRow)
                {
                    string MADN = row.Cells[0].Value.ToString();
                    string TT = row.Cells[7].Value.ToString();
                    // gọi hàm update
                    updateTrangThaiDoanhNghiep(MADN, TT);
                }
            }
            MessageBox.Show("Danh sách doanh nghiệp được cập nhật thành công!");
        }

        private void updateTrangThaiDoanhNghiep(string MADN, string TT)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(ConnectionStr.connectionStr))
                {
                    connection.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "ADMIN2.USP_UPDATE_TRANGTHAI_DOANHNGHIEP";
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Input parameters
                    cmd.Parameters.Add("MA", OracleDbType.Varchar2).Value = MADN;
                    cmd.Parameters.Add("TT", OracleDbType.Varchar2).Value = TT;

                    // Output parameters
                    OracleParameter errorCodeParam = new OracleParameter("p_error_code", OracleDbType.Int32);
                    errorCodeParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(errorCodeParam);

                    OracleParameter errorMsgParam = new OracleParameter("p_error_msg", OracleDbType.Varchar2, 1000);
                    errorMsgParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(errorMsgParam);

                    // Execute the command
                    cmd.ExecuteNonQuery();

                    //MessageBox.Show("Update thành công!");
                    // reload thông tin hiển thị trên form

                    connection.Close();

                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                MessageBox.Show("ERR: " + ex.Message);
            }
        }
    }
}
