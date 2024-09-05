using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTK
{
    internal class DangTuyen
    {
        public string MaDangTuyen { get; set; }
        public string MaDoanhNghiep { get; set; }
        public string HinhThucDangTuyen { get; set; }
        public string NgayLap { get; set; }
        public string NgayDangTuyen { get; set; }
        public int ThoiHan { get; set; }
        public string ViTriUngTuyen { get; set; }
        public int SoLuong { get; set; }
        public string YeuCauChoUngVien { get; set; }
        public string TrangThai { get; set; }
        public string LinkDangBai { get; set; }

        public DangTuyen()
        {
        }
        public List<DangTuyen> TimKiem_DangTuyen(string key, string DN)
        {
            return new DangTuyen_DAO().TimKiem_DangTuyen(key, DN);
        }

        public bool Them_DangTuyen(DangTuyen dangTuyen)
        {
            return new DangTuyen_DAO().Them_DangTuyen(dangTuyen);
        }

        public DangTuyen LayChiTietDangTuyen(string maDangTuyen)
        {
            return new DangTuyen_DAO().LayChiTietDangTuyen(maDangTuyen);
        }

        public bool CapNhatDangTuyen(DangTuyen dangTuyen)
        {
            return new DangTuyen_DAO().CapNhatDangTuyen(dangTuyen);
        }

    }

    internal class DangTuyen_DAO
    {
        public List<DangTuyen> TimKiem_DangTuyen(string key, string DN)
        {
            List<DangTuyen> list = new List<DangTuyen>();
            string query;
            if (string.IsNullOrEmpty(DN))
            {
                query = $"select * from admin2.DangTuyen WHERE MADANGTUYEN like '%{key}%' or ViTriUngTuyen like '%{key}%'";
            }
            else
                query = $"select * from admin2.DangTuyen WHERE MaDoanhNghiep = '{DN}' and (MADANGTUYEN like '%{key}%' or ViTriUngTuyen like '%{key}%')";

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
                        DangTuyen dangTuyen = new DangTuyen();
                        dangTuyen.MaDangTuyen = row["MADANGTUYEN"].ToString();
                        dangTuyen.MaDoanhNghiep = row["MADOANHNGHIEP"].ToString();
                        dangTuyen.HinhThucDangTuyen = row["HINHTHUCDANGTUYEN"].ToString();
                        dangTuyen.NgayLap = row["NGAYLAP"].ToString();
                        dangTuyen.NgayDangTuyen = row["NGAYDANGTUYEN"].ToString();
                        dangTuyen.ThoiHan = Convert.ToInt32(row["THOIHAN"]);
                        dangTuyen.ViTriUngTuyen = row["VITRIUNGTUYEN"].ToString();
                        dangTuyen.SoLuong = Convert.ToInt32(row["SOLUONG"]);
                        dangTuyen.YeuCauChoUngVien = row["YEUCAUCHOUNGVIEN"].ToString();
                        dangTuyen.TrangThai = row["TRANGTHAI"].ToString();
                        dangTuyen.LinkDangBai = row["LINKDANGBAI"].ToString();
                        list.Add(dangTuyen);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            return list;
        }

        public bool Them_DangTuyen(DangTuyen dangTuyen)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(ConnectionStr.connectionStr))
                {
                    connection.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "admin2.USP_insert_DangTuyen";

                    cmd.Parameters.Add("p_MaDN", OracleDbType.Varchar2).Value = dangTuyen.MaDoanhNghiep;
                    cmd.Parameters.Add("p_ViTri", OracleDbType.Varchar2).Value = dangTuyen.ViTriUngTuyen;
                    cmd.Parameters.Add("p_SoLuong", OracleDbType.Int32).Value = dangTuyen.SoLuong;
                    cmd.Parameters.Add("p_YeuCauungvien", OracleDbType.Varchar2).Value = dangTuyen.YeuCauChoUngVien;
                    cmd.Parameters.Add("p_HinhThuc", OracleDbType.Varchar2).Value = dangTuyen.HinhThucDangTuyen;
                    cmd.Parameters.Add("p_ThoiHan", OracleDbType.Int32).Value = dangTuyen.ThoiHan;


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

        public DangTuyen LayChiTietDangTuyen(string maDangTuyen)
        {
            DangTuyen dangTuyen = null;
            string query = $"select * from admin2.DangTuyen WHERE MADANGTUYEN = '{maDangTuyen}'";

            try
            {
                using (OracleConnection connection = new OracleConnection(ConnectionStr.connectionStr))
                {
                    connection.Open();
                    OracleCommand command = new OracleCommand(query, connection);
                    OracleDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string ngayDangTuyen = reader["NGAYDANGTUYEN"] == DBNull.Value ? DateTime.Now.ToString("yyyy-MM-dd") : reader["NGAYDANGTUYEN"].ToString();
                        dangTuyen = new DangTuyen
                        {
                            MaDangTuyen = reader["MADANGTUYEN"].ToString(),
                            MaDoanhNghiep = reader["MADOANHNGHIEP"].ToString(),
                            HinhThucDangTuyen = reader["HINHTHUCDANGTUYEN"].ToString(),
                            NgayLap = reader["NGAYLAP"].ToString(),
                            NgayDangTuyen = ngayDangTuyen,
                            ThoiHan = Convert.ToInt32(reader["THOIHAN"]),
                            ViTriUngTuyen = reader["VITRIUNGTUYEN"].ToString(),
                            SoLuong = Convert.ToInt32(reader["SOLUONG"]),
                            YeuCauChoUngVien = reader["YEUCAUCHOUNGVIEN"].ToString(),
                            TrangThai = reader["TRANGTHAI"].ToString(),
                            LinkDangBai = reader["LINKDANGBAI"].ToString()
                        };
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            return dangTuyen;
        }

        public bool CapNhatDangTuyen(DangTuyen dangTuyen)
        {
            bool result = false;
            string query = "UPDATE admin2.DangTuyen SET " +
                           "NGAYDANGTUYEN = TO_DATE(:NgayDangTuyen, 'yyyy-mm-dd'), " +
                           "THOIHAN = :ThoiHan, " +
                           "SOLUONG = :SoLuong, " +
                           "YEUCAUCHOUNGVIEN = :YeuCauChoUngVien, " +
                           "HINHTHUCDANGTUYEN = :HinhThucDangTuyen, " +
                           "TRANGTHAI = :TrangThai, " +
                           "LINKDANGBAI = :LinkDangBai " +
                           "WHERE MADANGTUYEN = :MaDangTuyen";

            try
            {
                using (OracleConnection connection = new OracleConnection(ConnectionStr.connectionStr))
                {
                    connection.Open();
                    OracleCommand command = new OracleCommand(query, connection);

                    command.Parameters.Add(new OracleParameter("NgayDangTuyen", DateTime.Parse(dangTuyen.NgayDangTuyen).ToString("yyyy-MM-dd")));
                    command.Parameters.Add(new OracleParameter("ThoiHan", dangTuyen.ThoiHan));

                    command.Parameters.Add(new OracleParameter("SoLuong", dangTuyen.SoLuong));
                    command.Parameters.Add(new OracleParameter("YeuCauChoUngVien", dangTuyen.YeuCauChoUngVien));

                    command.Parameters.Add(new OracleParameter("HinhThucDangTuyen", dangTuyen.HinhThucDangTuyen));
                    command.Parameters.Add(new OracleParameter("TrangThai", dangTuyen.TrangThai));
                    command.Parameters.Add(new OracleParameter("LinkDangBai", dangTuyen.LinkDangBai));
                    command.Parameters.Add(new OracleParameter("MaDangTuyen", dangTuyen.MaDangTuyen));

                    int rowsUpdated = command.ExecuteNonQuery();
                    result = rowsUpdated > 0;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            return result;
        }


    }
}
