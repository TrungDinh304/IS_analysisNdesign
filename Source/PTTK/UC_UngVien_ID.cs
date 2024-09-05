using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTK
{
    public partial class UC_UngVien_ID : UserControl
    {
        private static UC_UngVien_ID _instance;
        public event EventHandler RequestReturnToUserControl1;
        /*
        public static UC_UngVien_ID Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_UngVien_ID();
                return _instance;
            }
        }
        */
        public UC_UngVien_ID(string MaUngVien)
        {
            InitializeComponent();
            UC_UV_ID_label3.Text = MaUngVien;
        }

        private void UC_UV_ID_label2_Click(object sender, EventArgs e)
        {

        }

        private void UC_UngVien_ID_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void HienThi()
        {
            String MaUngVien = UC_UV_ID_label3.Text;
            //
            DataSet data = new DataSet();
            String query = $"SELECT TenUngVien,CCCD,NgaySinh,SDT,DiaChi FROM ADMIN2.UNGVIEN WHERE MAUNGVIEN = '{MaUngVien}'";
            using (OracleConnection connection = new OracleConnection(ConnectionStr.connectionStr))
            {
                connection.Open();
                OracleDataAdapter adapter = new OracleDataAdapter(query, connection);
                adapter.Fill(data);

                connection.Close();
            }
            UC_UV_ID_textBox1.Text = data.Tables[0].Rows[0]["TenUngVien"].ToString();
            UC_UV_ID_textBox2.Text = data.Tables[0].Rows[0]["CCCD"].ToString();
            UC_UV_ID_textBox3.Text = data.Tables[0].Rows[0]["NgaySinh"].ToString();
            UC_UV_ID_textBox4.Text = data.Tables[0].Rows[0]["SDT"].ToString();
            UC_UV_ID_textBox5.Text = data.Tables[0].Rows[0]["DiaChi"].ToString();

            //
            DataSet data1 = new DataSet();
            String query1 = $"SELECT ID,LoaiBang,ToChucCap FROM ADMIN2.CHUNGNHAN WHERE MAUNGVIEN = '{MaUngVien}'";
            using (OracleConnection connection = new OracleConnection(ConnectionStr.connectionStr))
            {
                connection.Open();
                OracleDataAdapter adapter = new OracleDataAdapter(query1, connection);
                adapter.Fill(data1);

                connection.Close();
            }
            UC_UV_ID_dataGridView1.DataSource = data1.Tables[0];

            //
            DataSet data2 = new DataSet();
            String query2 = $"SELECT MaHoSo,NgayLap,TrangThaiHoSo FROM ADMIN2.HOSOUNGTUYEN WHERE MAUNGVIEN = '{MaUngVien}'";
            using (OracleConnection connection = new OracleConnection(ConnectionStr.connectionStr))
            {
                connection.Open();
                OracleDataAdapter adapter = new OracleDataAdapter(query2, connection);
                adapter.Fill(data2);

                connection.Close();
            }
            UC_UV_ID_dataGridView2.DataSource = data2.Tables[0];

        }

        private void UC_UV_ID_button1_Click(object sender, EventArgs e)
        {
            Form nextForm = new ThemChungNhan(UC_UV_ID_label3.Text);
            nextForm.Show();
            UC_UV_ID_button1.Enabled = false;
            nextForm.FormClosed += (s, args) =>
            {
                UC_UV_ID_button1.Enabled = true;
                HienThi();
            };
        }

        private void UC_UV_ID_button2_Click(object sender, EventArgs e)
        {
            Form nextForm = new TaoHoSo(UC_UV_ID_label3.Text);
            nextForm.Show();
            UC_UV_ID_button2.Enabled = false;
            nextForm.FormClosed += (s, args) =>
            {
                UC_UV_ID_button2.Enabled = true;
                HienThi();
            };
        }

        private void UC_UV_ID_label1_Click(object sender, EventArgs e)
        {
            // Khi người dùng click button để yêu cầu quay trở lại UserControl1
            OnRequestReturnToUserControl1();
        }
        protected virtual void OnRequestReturnToUserControl1()
        {
            RequestReturnToUserControl1?.Invoke(this, EventArgs.Empty);
        }
    }
}