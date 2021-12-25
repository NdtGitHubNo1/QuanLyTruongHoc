using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTH.DATA;
using MoreLinq;

namespace QLTH.GUI
{
    public partial class FormDangNhap : Form
    {
        linqDataContext db = new linqDataContext();
        DataTable dt = new DataTable();
        public FormDangNhap()
        {
            InitializeComponent();         
        }


        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                txtMK.UseSystemPasswordChar = false;
            }
            else
            {
                txtMK.UseSystemPasswordChar = true;
            }
        }
       

public void login()
        {
            string quyen = "";
            string t1 = txtTK.Text;
            string t2 = txtMK.Text;
            if (txtTK.Text == "")
            {
                MessageBox.Show("Chưa nhập tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTK.Focus();

            }
            if (txtMK.Text == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTK.Focus();
            }
            else
            {
                var quyen1 = from a in db.DANGNHAP1(txtTK.Text, txtMK.Text) select a;
                   foreach (var item in quyen1)
                      {
                        quyen = item.QUYEN;
                      }
                var quyen2 = from a in db.DANGNHAP2(txtTK.Text, txtMK.Text) select a;
                     foreach (var item in quyen2)
                       {
                         quyen = item.QUYEN;
                       }

              }
            if (quyen == "admin")
            {
                QLTH_Admin admin = new QLTH_Admin();
                MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                admin.Show();
                this.Hide();
            }
            if (quyen == "GiaoVien")
            {
                GUI.QLTH_GiaoVien giaovien = new GUI.QLTH_GiaoVien();
                GUI.QLTH_GiaoVien.magv = txtTK.Text;
                MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                giaovien.Show();
                this.Hide();
            }
            if (quyen == "HocSinh")
            {
                GUI.QLTH_HocSinh hocsinh = new GUI.QLTH_HocSinh();
                GUI.QLTH_HocSinh.mahs = txtTK.Text;
                MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hocsinh.Show();
                this.Hide();
            }
    if (quyen == "")
    {
        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

}


private void btnLogin_Click_1(object sender, EventArgs e)
        {
            login();
        }
    }
}


