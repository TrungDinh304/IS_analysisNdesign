using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace PTTK
{
    public partial class MH_DangKyUngVien : Form
    {
        public MH_DangKyUngVien()
        {
            InitializeComponent();
        }

        private void HienThi()
        {

        }
        private void DangKyUngVien_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            String name = txtHoTen.Text,
                cccd = txtCCCD.Text,
                dob = dateNgaySinh.Value.ToString("dd/MM/yyyy"),
                phone = txtSdt.Text,
                addr = txtDiachi.Text;
            String phai = null;

            if (chbNam.Checked) phai = "Nam";
            else if (chbNu.Checked) phai = "Nữ";

            if (phai == null || name.Length == 0 || cccd.Length == 0 || dob.Length == 0
                || phone.Length == 0 || addr.Length == 0)
            {
                MessageBox.Show("Thông tin không đầy đủ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!UngVien.KiemTraTen(name))
            {
                String id = UngVien.SinhMa();
                UngVien uv = new UngVien(id, name, dob, phone, addr, cccd, phai);

                UngVien.ThemUngVien(uv);

                // Show the message after procedure.
                MessageBox.Show("Đăng ký thành công.");

                // Close the form
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại.");
            }

        }

        private void chbNam_CheckedChanged(object sender, EventArgs e)
        {
            if (chbNam.CheckState == CheckState.Checked && chbNu.CheckState == CheckState.Checked)
            {
                chbNu.CheckState = CheckState.Unchecked;
            }
            if (chbNam.CheckState == CheckState.Unchecked && chbNu.CheckState == CheckState.Unchecked)
            {
                chbNu.CheckState = CheckState.Checked;
            }
        }
        private void chbNu_CheckedChanged(object sender, EventArgs e)
        {
            if (chbNu.CheckState == CheckState.Checked && chbNam.CheckState == CheckState.Checked)
            {
                chbNam.CheckState = CheckState.Unchecked;
            }
            if (chbNu.CheckState == CheckState.Unchecked && chbNam.CheckState == CheckState.Unchecked)
            {
                chbNam.CheckState = CheckState.Checked;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}