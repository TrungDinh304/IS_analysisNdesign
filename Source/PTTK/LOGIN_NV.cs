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
    public partial class LOGIN_NV : Form
    {
        public LOGIN_NV()
        {
            InitializeComponent();
        }
        private void LOGIN_NV_Load(object sender, EventArgs e)
        {
        }

        private void login_nv_button1_Click(object sender, EventArgs e)
        {
            string current_username = login_nv_textBox_username.Text;
            string current_password = login_nv_textBox_password.Text;
            UserLogin(current_username, current_password);
        }
        private void UserLogin(string username, string password)
        {
            ConnectionStr.connectionStr = $@"DATA SOURCE=localhost:1521/xe;PERSIST SECURITY INFO=True;USER ID={username};PASSWORD={password}";

            try
            {
                using (OracleConnection connection = new OracleConnection(ConnectionStr.connectionStr))
                {
                    connection.Open();
                }

                Login_information.username = username;
                Login_information.password = password;

                bool check_login = HandleUserLogin(username);
                if(check_login == false)
                {
                    throw new Exception("Người dùng không tồn tại.");
                }

                TrangChu trangChu = new TrangChu();
                this.Hide();
                trangChu.Show();
                trangChu.FormClosed += (s, args) => this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra lại thông tin đăng nhập.\n" + ex.Message);
                login_nv_textBox_password.Text = "";
                return;
            }

            

            ResetTextBoxes();
        }
        private bool HandleUserLogin(string username)
        {
            string query = "select TenNhanVien,ChucVu from ADMIN2.V_XEM_THONGTINCANHAN";
            
            try
            {
                DataSet dsns = ExecuteQuery(query);

                if (dsns.Tables[0].Rows.Count > 0)
                {
                    DataRow row = dsns.Tables[0].Rows[0];
                    Login_information.role = row["ChucVu"].ToString();
                    Login_information.fullname = row["TenNhanVien"].ToString();
                }
                else
                {
                    throw new Exception("Người dùng không tồn tại.");
                }
            }
            catch
            {
                MessageBox.Show("Thông tin đăng nhập không hợp lệ.");
                return false;
            }
            return true;
        }
        private DataSet ExecuteQuery(string query)
        {
            DataSet ds = new DataSet();
            using (OracleConnection connection = new OracleConnection(ConnectionStr.connectionStr))
            {
                connection.Open();
                OracleDataAdapter adapter = new OracleDataAdapter(query, connection);
                adapter.Fill(ds);
            }
            return ds;
        }
        
        private void ResetTextBoxes()
        {
            login_nv_textBox_username.Text = string.Empty;
            login_nv_textBox_password.Text = string.Empty;
        }
        private void login_nv_textBox_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login_nv_button1_Click(sender, e);
            }
        }


    }
}
