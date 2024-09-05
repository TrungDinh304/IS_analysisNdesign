using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTTK;

namespace PTTK
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
            if (Login_information.role == "nhân viên tiếp tân")
            {
                radioButton_BaiDangTuyen.BackColor = Color.DarkGray;
                radioButton_BaiDangTuyen.Enabled = false;

                radioButton_ChienLuoc.BackColor = Color.DarkGray;
                radioButton_ChienLuoc.Enabled = false;

                radioButton_ChonGiaHan.BackColor = Color.DarkGray;
                radioButton_ChonGiaHan.Enabled = false;

                radioButton_DuyetHoSo.BackColor = Color.DarkGray;
                radioButton_DuyetHoSo.Enabled = false;
            }
            else if(Login_information.role == "Nhân viên quảng cáo")
            {
                radioButton_DoanhNghiep.BackColor = Color.DarkGray;
                radioButton_DoanhNghiep.Enabled = false;

                radioButton_UngVien.BackColor = Color.DarkGray;
                radioButton_UngVien.Enabled = false;

                radioButton_ChienLuoc.BackColor = Color.DarkGray;
                radioButton_ChienLuoc.Enabled = false;

                radioButton_ChonGiaHan.BackColor = Color.DarkGray;
                radioButton_ChonGiaHan.Enabled = false;

                radioButton_DuyetHoSo.BackColor = Color.DarkGray;
                radioButton_DuyetHoSo.Enabled = false;
            }    
        }

        public void openUC(UserControl uc)
        {
            if (uc == null)
            {
                return;
            }

            uc.Dock = DockStyle.Fill;
            panel_Home.Controls.Clear();
            panel_Home.Controls.Add(uc);
            uc.BringToFront();
        }

        private void radioButton_ChonGiaHan_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                RadioButton radioButton = (RadioButton)sender;
                for (int i = 0; i < this.Controls.Count; i++)
                {
                    if (this.Controls[i] is RadioButton && this.Controls[i] != radioButton)
                    {
                        RadioButton radioButton1 = (RadioButton)this.Controls[i];
                        radioButton1.BackColor = Color.White;
                        radioButton1.ForeColor = Color.Black;
                    }
                }

                radioButton.BackColor = Color.RoyalBlue;
                radioButton.ForeColor = Color.White;
            }
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            pictureBox_homeLogo_Click(sender, e);
        }

        private void pictureBox_homeLogo_Click(object sender, EventArgs e)
        {
            radioButton_TrangChu.Checked = true;
            radioButton_TrangChu_Click(sender, e);
        }

        private void radioButton_TrangChu_Click(object sender, EventArgs e)
        {
            UserControl_TrangChu uc = new UserControl_TrangChu();
            openUC(uc);

        }
        private void radioButton_BaiDangTuyen_Click(object sender, EventArgs e)
        {
            UserControl_BaiDangTuyen_2 uc = new UserControl_BaiDangTuyen_2();
            openUC(uc);
        }

        private void button_DangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private UserControl_UngVien userControl1;
        private UC_UngVien_ID userControl2;
        private string MaUngVien;
        private void radioButton_UngVien_Click(object sender, EventArgs e)
        {
            userControl1 = new UserControl_UngVien();
            openUC(userControl1);

            // Đăng ký sự kiện từ UserControl1 để yêu cầu mở UserControl2
            userControl1.RequestOpenUserControl2 += UserControl1_RequestOpenUserControl2;
        }

        private void UserControl1_RequestOpenUserControl2(object sender, EventArgs e)
        {
            // Đóng UserControl1
            // panel_Home.Controls.Remove(userControl1);
            MaUngVien = userControl1.GetUserData();
            // Khởi tạo UserControl2 và đặt nó trong Panel
            userControl2 = new UC_UngVien_ID(MaUngVien);
            openUC(userControl2);

            // Đăng ký sự kiện từ UserControl2 để quay trở lại UserControl1
            userControl2.RequestReturnToUserControl1 += UserControl2_RequestReturnToUserControl1;
        }

        private void UserControl2_RequestReturnToUserControl1(object sender, EventArgs e)
        {
            // Đóng UserControl2
            // panel_Home.Controls.Remove(userControl2);

            // Khởi tạo lại UserControl1 và đặt nó trong Panel
            userControl1 = new UserControl_UngVien();
            openUC(userControl1);

            // Đăng ký lại sự kiện từ UserControl1 để yêu cầu mở UserControl2
            userControl1.RequestOpenUserControl2 += UserControl1_RequestOpenUserControl2;
        }

        private void radioButton_DoanhNghiep_Click(object sender, EventArgs e)
        {
            UserControl_DoanhNghiep uc = new UserControl_DoanhNghiep();
            openUC(uc);
        }
    }
}