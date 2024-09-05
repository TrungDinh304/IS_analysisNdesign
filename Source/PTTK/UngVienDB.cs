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
    internal class UngVienDB
    {
        public static UngVien DocThongTin(String tenuv)
        {
            UngVien uv = null;
            String query = $"SELECT UV.* " +
                    $"FROM ADMIN2.UNGVIEN UV " +
                    $"WHERE UV.TENUNGVIEN = '{tenuv}'";

            // Querying selected name
            using (OracleConnection connection = new OracleConnection(ConnectionStr.connectionStr))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            String Id = reader.GetString(0);
                            String Name = reader.GetString(1);
                            String DOB = reader.GetString(2);
                            String Gender = reader.GetString(3);
                            String CCCD = reader.GetString(4);
                            String Phone = reader.GetString(5);
                            String Address = reader.GetString(6);

                            uv = new UngVien(Id, Name, DOB, Gender, CCCD, Phone, Address);

                        }
                    }
                }

                connection.Close();
            }

            return uv;
        }

        public static int TinhSoThuTu()
        {
            int highestId;
            using (OracleConnection connection = new OracleConnection(ConnectionStr.connectionStr))
            {
                connection.Open();

                string query = "SELECT TO_NUMBER(MAX(SUBSTR(TO_CHAR(UV.MAUNGVIEN),3))) FROM ADMIN2.UNGVIEN UV";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        highestId = Convert.ToInt32(result);
                        return highestId;
                    }
                }
            }
            return 0;
        }

        public static void Them(UngVien uv)
        {
            int len = 0;
            try
            {
                // TODO: code to add a candidate
                String s1 = uv.getMaUV();
                String s2 = uv.getHoTen();
                String s3 = uv.getNgaySinh();
                String s4 = uv.getSdt();
                len = s4.Length;
                String s5 = uv.getDiaChi();
                String s6 = uv.getCCCD();
                String s7 = uv.getGioitinh();

                String query = $"INSERT INTO ADMIN2.UNGVIEN VALUES('{s1}','{s2}',TO_DATE('{s3}','dd/mm/yyyy')" +
                    $",'{s7}','{s6}','{s4}','{s5}')";
                // Mở kết nối đến cơ sở dữ liệu
                DataSet dt = new DataSet();

                using (OracleConnection connection = new OracleConnection(ConnectionStr.connectionStr))
                {
                    connection.Open();
                    OracleDataAdapter adapter = new OracleDataAdapter(query, connection);
                    adapter.Fill(dt);
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Lỗi: {e.Message}.");
            }
        }

        public static DataSet DocBang(String ten)
        {
            DataSet data = new DataSet();

            String query = $"SELECT UV.MAUNGVIEN, UV.TENUNGVIEN, UV.NGAYSINH, UV.DIACHI, UV.SDT " +
                    $"FROM ADMIN2.UNGVIEN UV " +
                    $"WHERE UV.TENUNGVIEN = '{ten}'";
            // Querying selected name
            using (OracleConnection connection = new OracleConnection(ConnectionStr.connectionStr))
            {
                connection.Open();
                OracleDataAdapter adapter = new OracleDataAdapter(query, connection);
                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }

        public static DataSet DocTatCa()
        {
            DataSet data = new DataSet();
            String queryAll = $"SELECT UV.MAUNGVIEN, UV.TENUNGVIEN, UV.NGAYSINH, UV.DIACHI, UV.SDT " +
                $"FROM ADMIN2.UNGVIEN UV";
            using (OracleConnection connection = new OracleConnection(ConnectionStr.connectionStr))
            {
                connection.Open();
                OracleDataAdapter adapter = new OracleDataAdapter(queryAll, connection);
                adapter.Fill(data);
            }
            return data;
        }
    }
}
