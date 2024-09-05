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
    public partial class Form_Xem_Them_BaiDang : Form
    {
        public Form_Xem_Them_BaiDang(string DN)
        {
            InitializeComponent();
            this.label_ID_DN.Text = DN;
            this.label_ID_BaiDang.Text += "Đăng Ký";

            
            this.label_trangthai.Visible = false;
            this.label_ngaylapphieu.Visible = false;
            this.label_ngaydang.Visible = false;
            this.textBox_linkbaidang.Visible = false;

            this.label7.Visible = false;
            this.label6.Visible = false;
            this.label9.Visible = false;
            this.label10.Visible = false;

            comboBox_hinhthucdangtuyen.Items.Add("Social media");
            comboBox_hinhthucdangtuyen.Items.Add("Banner");
            comboBox_hinhthucdangtuyen.Items.Add("Báo giấy");
            comboBox_hinhthucdangtuyen.SelectedIndex = -1;

        }
        public Form_Xem_Them_BaiDang(string key, string DN)
        {
            InitializeComponent();
            List<DangTuyen> list = new DangTuyen().TimKiem_DangTuyen(key, DN);
            DangTuyen curdangTuyen = list[0];
            button_DangKy.Visible = false;

            this.label_ID_DN.Text = curdangTuyen.MaDoanhNghiep;
            this.label_ID_BaiDang.Text += curdangTuyen.MaDangTuyen;

            this.textBox_Vitri.Text = curdangTuyen.ViTriUngTuyen;
            this.textBox_Vitri.ReadOnly = true;

            this.textBox_soluong.Text = curdangTuyen.SoLuong.ToString();
            this.textBox_soluong.ReadOnly = true;

            this.textBox_yeucauungvien.Text = curdangTuyen.YeuCauChoUngVien;
            this.textBox_yeucauungvien.ReadOnly = true;

            this.comboBox_hinhthucdangtuyen.Text = curdangTuyen.HinhThucDangTuyen;
            this.comboBox_hinhthucdangtuyen.Enabled = false;

            this.textBox_thoihandang.Text = curdangTuyen.ThoiHan.ToString();
            this.textBox_thoihandang.ReadOnly = true;

            this.label_ngaylapphieu.Text = curdangTuyen.NgayLap.ToString();
            this.label_ngaydang.Text = curdangTuyen.NgayDangTuyen.ToString();
            this.textBox_linkbaidang.Text = curdangTuyen.LinkDangBai;
            this.textBox_linkbaidang.ReadOnly = true;
            this.label_trangthai.Text = curdangTuyen.TrangThai;
        }

        private void button_DangKy_Click(object sender, EventArgs e)
        {
            
            DangTuyen add_new = new DangTuyen();
            add_new.MaDoanhNghiep = this.label_ID_DN.Text;
            add_new.HinhThucDangTuyen = comboBox_hinhthucdangtuyen.Text;
            add_new.ViTriUngTuyen = textBox_Vitri.Text;
            add_new.SoLuong = int.Parse(textBox_soluong.Text);
            add_new.YeuCauChoUngVien = textBox_yeucauungvien.Text;
            add_new.ThoiHan = int.Parse(textBox_thoihandang.Text);

            bool insert_result = new DangTuyen().Them_DangTuyen(add_new);

            if (insert_result)
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
