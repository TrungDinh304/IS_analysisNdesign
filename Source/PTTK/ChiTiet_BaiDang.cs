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
    public partial class ChiTiet_BaiDang : Form
    {
        private string madt;
        public ChiTiet_BaiDang()
        {

            InitializeComponent();
        }

        internal void HienThiChiTiet(DangTuyen dangTuyen)
        {
            madt = dangTuyen.MaDangTuyen;
            txtNgayDang.Text = dangTuyen.NgayDangTuyen;
            txtThoiHan.Text = dangTuyen.ThoiHan.ToString();
            txtViTri.Text = dangTuyen.ViTriUngTuyen;
            txtSoLuong.Text = dangTuyen.SoLuong.ToString();
            txtYeuCauUngVien.Text = dangTuyen.YeuCauChoUngVien;
            txtNgayLapPhieu.Text = dangTuyen.NgayLap;
            txtHinhThucDang.Text = dangTuyen.HinhThucDangTuyen;
            txtTrangThai.Text = dangTuyen.TrangThai;
            txtLinkBaiDang.Text = dangTuyen.LinkDangBai;

            if(dangTuyen.NgayDangTuyen == "")
            {
                btnGhiNhan.Enabled = true;
                return;
            }
            DateTime ngayDang = DateTime.Parse(dangTuyen.NgayDangTuyen);
            
            if ((DateTime.Now - ngayDang).TotalDays <= 3)
            {
                btnGhiNhan.Enabled = true;
            }
            else
            {
                btnGhiNhan.Enabled = false;
            }
        }

        private void btnGhiNhan_Click(object sender, EventArgs e)
        {
            DangTuyen dangTuyen = new DangTuyen();
            dangTuyen.MaDangTuyen = madt;
            dangTuyen.NgayDangTuyen = txtNgayDang.Text;
            dangTuyen.ThoiHan = int.Parse(txtThoiHan.Text);
            dangTuyen.ViTriUngTuyen = txtViTri.Text;
            dangTuyen.SoLuong = int.Parse(txtSoLuong.Text);
            dangTuyen.YeuCauChoUngVien = txtYeuCauUngVien.Text;
            dangTuyen.NgayLap = txtNgayLapPhieu.Text;
            dangTuyen.HinhThucDangTuyen = txtHinhThucDang.Text;
            dangTuyen.TrangThai = txtTrangThai.Text;
            dangTuyen.LinkDangBai = txtLinkBaiDang.Text;

            DangTuyen_DAO dao = new DangTuyen_DAO();
            if (dao.CapNhatDangTuyen(dangTuyen))
            {
                MessageBox.Show("Cập nhật thành công!");
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }
    }
}
