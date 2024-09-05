using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTK
{
    internal class UngVien
    {
        private String maUV;
        private String hoTen;
        private String ngaySinh;
        private String sdt;
        private String diaChi;
        private String cccd;
        private String phai;

        public UngVien()
        {
            maUV = null;
            hoTen = null;
            ngaySinh = null;
            sdt = null;
            diaChi = null;
            cccd = null;
            phai = null;
        }

        public UngVien(String ma, String hoten, String nsinh,
            String SDT, String diachi, String CCCD, String gioitinh)
        {
            maUV = ma;
            hoTen = hoten;
            ngaySinh = nsinh;
            sdt = SDT;
            diaChi = diachi;
            cccd = CCCD;
            phai = gioitinh;
        }

        public String getMaUV() { return maUV; }
        public String getHoTen() { return hoTen; }
        public String getNgaySinh() { return ngaySinh; }
        public String getSdt() { return sdt; }
        public String getDiaChi() { return diaChi; }
        public String getCCCD() { return cccd; }
        public String getGioitinh() { return phai; }
        public static String SinhMa()
        {
            int n = UngVienDB.TinhSoThuTu() + 1;
            int padlen = 3;
            String id = "UV" + n.ToString("D" + padlen.ToString());

            return id;
        }
        public static bool KiemTraTen(String mauv)
        {
            return UngVienDB.DocThongTin(mauv) != null;
        }

        public static void ThemUngVien(UngVien uv)
        {
            UngVienDB.Them(uv);
        }

        public static DataSet LayDanhSach(String mauv)
        {
            DataSet ds = null;
            try
            {
                if (mauv != null)
                {
                    ds = UngVienDB.DocBang(mauv);
                }
                else
                {
                    ds = UngVienDB.DocTatCa();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Loi khong doc duoc du lieu. ({e.Message})");
            }
            return ds;
        }
    }
}