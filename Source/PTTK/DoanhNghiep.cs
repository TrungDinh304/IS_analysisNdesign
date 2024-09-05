using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;



namespace PTTK
{
    internal class DoanhNghiep
    {
        public string MaDoanhNghiep;
        public string TenCongTy;
        public string DiaChi;
        public string Email;
        public string MaSoThue;
        public DateTime NgayDangKy;
        public string NguoiDaiDien;
        public string TrangThai;
        //public DoanhNghiep_BUS(string MaDoanhNghiep, string TenCongTy, string DiaChi, string Email, string MaSoThue, DateTime NgayDangKy, string NguoiDaiDien, string TrangThai)
        public DoanhNghiep()
        {
            MaDoanhNghiep = "";
            TenCongTy = "";
            DiaChi = "";
            Email = "";
            MaSoThue = "";
            NgayDangKy = DateTime.Now;
            NguoiDaiDien = "";
            TrangThai = "";
        }
        public DoanhNghiep(string MaDoanhNghiep, string TenCongTy, string DiaChi, string Email, string MaSoThue, DateTime NgayDangKy, string NguoiDaiDien, string TrangThai)
        {
            this.MaDoanhNghiep = MaDoanhNghiep;
            this.TenCongTy = TenCongTy;
            this.DiaChi = DiaChi;
            this.Email = Email;
            this.MaSoThue = MaSoThue;
            this.NgayDangKy = NgayDangKy;
            this.NguoiDaiDien = NguoiDaiDien;
            this.TrangThai = TrangThai;
        }
        public List<DoanhNghiep> TimKiem_DoanhNghiep(string filter)
        {
            return DoanhNghiep_DAO.TimKiem_DoanhNghiep(filter);
        }
        public bool Them_DoanhNghiep(DoanhNghiep dn)
        {
            return DoanhNghiep_DAO.Them_DoanhNghiep(dn);
        }

    }
    internal class DoanhNghiep_DAO
    {
        public static List<DoanhNghiep> TimKiem_DoanhNghiep(string filter)
        {
            List<DoanhNghiep> list = new List<DoanhNghiep>();
            string query = $"select * from admin2.DoanhNghiep WHERE MADOANHNGHIEP like '%{filter}%' or TenCongTy like '%{filter}%'";
            // truy vấn đến oracle database và lưu vào dataset
            try
            {
                using (OracleConnection connection = new OracleConnection(ConnectionStr.connectionStr))
                {
                    connection.Open();
                    OracleCommand command = new OracleCommand(query, connection);
                    OracleDataAdapter adapter = new OracleDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    connection.Close();
                    // duyệt từng dòng trong dataset và lưu vào list

                    foreach (DataRow row in table.Rows)
                    {
                        DoanhNghiep dn = new DoanhNghiep();
                        dn.MaDoanhNghiep = row["MADOANHNGHIEP"].ToString();
                        dn.TenCongTy = row["TENCONGTY"].ToString();
                        dn.DiaChi = row["DIACHI"].ToString();
                        dn.Email = row["EMAIL"].ToString();
                        dn.MaSoThue = row["MASOTHUE"].ToString();
                        dn.NgayDangKy = Convert.ToDateTime(row["NGAYDANGKY"].ToString());
                        dn.NguoiDaiDien = row["NGUOIDAIDIEN"].ToString();
                        dn.TrangThai = row["TRANGTHAI"].ToString();
                        list.Add(dn);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            return list;
        }
        public static bool Them_DoanhNghiep(DoanhNghiep dn)
        {

            try
            {
                using (OracleConnection connection = new OracleConnection(ConnectionStr.connectionStr))
                {
                    connection.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "admin2.USP_insert_DoanhNghiep";

                    cmd.Parameters.Add("p_TenDN", OracleDbType.Varchar2).Value = dn.TenCongTy;
                    cmd.Parameters.Add("p_nguoidaidien", OracleDbType.Varchar2).Value = dn.NguoiDaiDien;
                    cmd.Parameters.Add("p_diachi", OracleDbType.Varchar2).Value = dn.DiaChi;
                    cmd.Parameters.Add("p_email", OracleDbType.Varchar2).Value = dn.Email;
                    cmd.Parameters.Add("p_masothue", OracleDbType.Varchar2).Value = dn.MaSoThue;



                    OracleParameter errorCodeParam = new OracleParameter("p_error_code", OracleDbType.Int32);
                    errorCodeParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(errorCodeParam);

                    OracleParameter errorMsgParam = new OracleParameter("p_error_msg", OracleDbType.Varchar2, 1000);
                    errorMsgParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(errorMsgParam);

                    cmd.ExecuteNonQuery();
                    connection.Close();

                    int errorCode = Convert.ToInt32(cmd.Parameters["p_error_code"].Value.ToString());
                    if (errorCode != 0)
                    {
                        MessageBox.Show(cmd.Parameters["p_error_msg"].Value.ToString());
                        //hiển thị call stack

                        return false;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return false;
            }
            return true;
        }
    }
}
