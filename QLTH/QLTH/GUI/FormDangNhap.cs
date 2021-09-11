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
        linqDataContext linq = new linqDataContext();
        DataTable dt = new DataTable();
        public FormDangNhap()
        {
            InitializeComponent();
            dt = Bang();
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
        public DataTable Bang()
        {
            DataTable data1 = new DataTable();
            DataTable data2 = new DataTable();
            data1 = linq.DANGNHAP1().ToDataTable();
            data2 = linq.DANGNHAP2().ToDataTable();
            DataTable danhsach = new DataTable();
            danhsach.Columns.Add("TenDangNhap");
            danhsach.Columns.Add("MatKhau");
            danhsach.Columns.Add("Quyen");
            DataRow admin = danhsach.NewRow();
            admin["TenDangNhap"] = admin["MatKhau"] = admin["Quyen"] = "admin";
            danhsach.Rows.Add(admin);
            for (int i = 0; i < data1.Rows.Count; i++)
            {
                DataRow row = danhsach.NewRow();
                row["TenDangNhap"] = data1.Rows[i]["MaGV"].ToString();
                row["MatKhau"] = data1.Rows[i]["SDT"].ToString();
                row["Quyen"] = "GiaoVien";
                danhsach.Rows.Add(row);
            }
            for (int i = 0; i < data2.Rows.Count; i++)
            {
                DataRow row = danhsach.NewRow();
                row["TenDangNhap"] = data2.Rows[i]["MaHS"].ToString();
                row["MatKhau"] = data2.Rows[i]["MaHS"].ToString();
                row["Quyen"] = "HocSinh";
                danhsach.Rows.Add(row);
            }
            return danhsach;
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
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string s1 = dt.Rows[i]["TenDangNhap"].ToString();
                    string s2 = dt.Rows[i]["MatKhau"].ToString();
                    if (t1.Trim() == s1.Trim() && t2.Trim() == s2.Trim())
                    {
                        quyen = dt.Rows[i]["Quyen"].ToString();
                        break;
                    }
                    if (i == dt.Rows.Count - 1)
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txtTK.Focus();
                        this.txtTK.SelectAll();
                        break;
                    }
                }

            }
            if (quyen == "admin")
            {
                MessageBox.Show("đăng nhập với quyền admin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            if (quyen == "GiaoVien")
            {
                MessageBox.Show("đăng nhập với quyền GiaoVien", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            if (quyen == "HocSinh")
            {
                MessageBox.Show("đăng nhập với quyền học sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }
    }
}


