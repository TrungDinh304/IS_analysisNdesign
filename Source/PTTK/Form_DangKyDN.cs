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
    public partial class Form_DangKyDN : Form
    {
        public Form_DangKyDN()
        {
            InitializeComponent();
            label_ID_DoanhNghiep.Text += "Đăng ký";
            label6.Visible = false;
            label_trangthai.Visible = false;
        }

        public Form_DangKyDN(string key)
        {
            InitializeComponent();
            List<DoanhNghiep> list = new DoanhNghiep().TimKiem_DoanhNghiep(key);
            DoanhNghiep curDoanhNghiep = list[0];
            button_DangKy.Visible = false;

            label_ID_DoanhNghiep.Text += curDoanhNghiep.MaDoanhNghiep;
            
            textBox_TenDoanhNghiep.Text = curDoanhNghiep.TenCongTy;
            textBox_TenDoanhNghiep.ReadOnly = true;

            textBox_diachi.Text = curDoanhNghiep.DiaChi;
            textBox_diachi.ReadOnly = true;

            textBox_email.Text = curDoanhNghiep.Email;
            textBox_email.ReadOnly = true;

            textBox_masothue.Text = curDoanhNghiep.MaSoThue;
            textBox_masothue.ReadOnly = true;

            textBox_nguoidaidien.Text = curDoanhNghiep.NguoiDaiDien;
            textBox_nguoidaidien.ReadOnly = true;

            label_trangthai.Text = curDoanhNghiep.TrangThai;
        }

        private void button_DangKy_Click(object sender, EventArgs e)
        {
            DoanhNghiep addnew = new DoanhNghiep();
            addnew.TenCongTy = textBox_TenDoanhNghiep.Text;
            addnew.NguoiDaiDien = textBox_nguoidaidien.Text;
            addnew.DiaChi = textBox_diachi.Text;
            addnew.Email = textBox_email.Text;
            addnew.MaSoThue = textBox_masothue.Text;

            if (addnew.TenCongTy == "" || addnew.NguoiDaiDien == "" || addnew.DiaChi == "" || addnew.Email == "" || addnew.MaSoThue == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            bool check = new DoanhNghiep().Them_DoanhNghiep(addnew);
            if (check)
            {
                MessageBox.Show("Đăng ký thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại");
            }
         
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
