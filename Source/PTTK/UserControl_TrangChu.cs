using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTTK;


namespace PTTK
{
    public partial class UserControl_TrangChu : UserControl
    {
        public UserControl_TrangChu()
        {
            InitializeComponent();

            if(Login_information.role == "nhân viên tiếp tân")
            {
                panel_GiamDoc.Visible = false;
                panel_NhanVienSanLoc.Visible = false;
                panel_NhanVien_QC_TN.Visible = false;
            }
            else if (Login_information.role == "Nhân viên quảng cáo")
            {
                panel_GiamDoc.Visible = false;
                panel_NhanVienSanLoc.Visible = false;
                panel_NhanVienTiepTan.Visible = false;
            }
        }


        private void button_DoanhNghiep_Click(object sender, EventArgs e)
        {
            UserControl_DoanhNghiep userControl_DoanhNghiep = new UserControl_DoanhNghiep();
            TrangChu trangChu = (TrangChu)this.FindForm();
            trangChu.openUC(userControl_DoanhNghiep);
            trangChu.radioButton_DoanhNghiep.Checked = true;
        }

        private void button_BaiDangTuyen_Click(object sender, EventArgs e)
        {
            UserControl_BaiDangTuyen_2 userControl_BaiDangTuyen = new UserControl_BaiDangTuyen_2();
            TrangChu trangChu = (TrangChu)this.FindForm();
            trangChu.openUC(userControl_BaiDangTuyen);
            trangChu.radioButton_BaiDangTuyen.Checked = true;
        }

        private void button_UngVien_Click(object sender, EventArgs e)
        {
            UserControl_UngVien UC_UngVien = new UserControl_UngVien();
            TrangChu trangChu = (TrangChu)this.FindForm();
            trangChu.openUC(UC_UngVien);
            trangChu.radioButton_UngVien.Checked = true;
        }
    }
}
