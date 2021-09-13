using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTH
{
    public partial class QLHocSinh_ADMIN : UserControl
    {
        public QLHocSinh_ADMIN()
        {
            InitializeComponent();
        }
        private static QLHocSinh_ADMIN _instance;
        public static QLHocSinh_ADMIN Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new QLHocSinh_ADMIN();
                return _instance;
            }
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        string trangthai = "";
        DATA.linqDataContext linq = new DATA.linqDataContext();

        private void QLHocSinh_ADMIN_Load(object sender, EventArgs e)
        {
            dataGridViewQLHS_ADMIN.DataSource = linq.QLHS_ADMIN();
        }

        void ReLoad()
        {
            txtMaHS.Text = "";
            txtHoTen.Text = "";
            txtGT.Text = "";
            dateTimePicker1.Text = "";
            txtDiaChi.Text = "";
            txtPhuHuynh.Text = "";
            txtDMHocPhi.Text = "";
            txtMaLop.Text = "";
        }

        public bool Checkcontrol()
        {
            if (string.IsNullOrWhiteSpace(txtMaHS.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã học sinh .", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaHS.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Bạn chưa nhập họ tên học sinh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTen.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtGT.Text))
            {
                MessageBox.Show("Bạn chưa nhập giới tính học sinh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGT.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(dateTimePicker1.Text))
            {
                MessageBox.Show("Bạn chưa nhập ngày sinh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePicker1.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ học sinh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiaChi.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPhuHuynh.Text))
            {
                MessageBox.Show("Bạn chưa nhập phụ huynh học sinh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhuHuynh.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDMHocPhi.Text))
            {
                MessageBox.Show("Bạn chưa nhập định mức học phí cho học sinh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDMHocPhi.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMaLop.Text))
            {
                MessageBox.Show("Bạn chưa nhập giới tính học sinh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaLop.Focus();
                return false;
            }

            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ReLoad();
            txtMaHS.Enabled = true;
            trangthai = "thêm_hs";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            trangthai = "sửa_hs";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                linq.XOA_HS_ADMIN(txtMaHS.Text);
                ReLoad();
                QLHocSinh_ADMIN_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Checkcontrol())
            {
                if (trangthai == "thêm_hs")
                {
                    try
                    {
                        linq.THEM_HS_ADMIN(txtMaHS.Text, txtHoTen.Text, txtGT.Text, dateTimePicker1.Value, txtDiaChi.Text, txtPhuHuynh.Text, Math.Round(float.Parse(txtDMHocPhi.Text),2), txtMaLop.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (trangthai == "sửa_hs")
                {
                    try
                    {
                        linq.SUA_HS_ADMIN(txtMaHS.Text, txtHoTen.Text, txtGT.Text, dateTimePicker1.Value, txtDiaChi.Text, txtPhuHuynh.Text, Math.Round(float.Parse(txtDMHocPhi.Text), 2), txtMaLop.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            QLHocSinh_ADMIN_Load(sender, e);
            txtMaHS.Enabled = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            ReLoad();
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                MessageBox.Show("Bạn chưa nhập dữ kiện tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTimKiem.Focus();
            }
            else
            {
                dataGridViewQLHS_ADMIN.DataSource = linq.TIMHS_ADMIN(txtTimKiem.Text);
            }
        }

        private void dataGridViewQLHS_ADMIN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && index < dataGridViewQLHS_ADMIN.Rows.Count)
            {
                txtMaHS.Text = dataGridViewQLHS_ADMIN.Rows[index].Cells["MaHS"].Value.ToString();
                txtHoTen.Text = dataGridViewQLHS_ADMIN.Rows[index].Cells["HoTen"].Value.ToString();
                txtGT.Text = dataGridViewQLHS_ADMIN.Rows[index].Cells["GT"].Value.ToString();
                dateTimePicker1.Text = dataGridViewQLHS_ADMIN.Rows[index].Cells["NgaySinh"].Value.ToString();
                txtDiaChi.Text = dataGridViewQLHS_ADMIN.Rows[index].Cells["DiaChi"].Value.ToString();
                txtPhuHuynh.Text = dataGridViewQLHS_ADMIN.Rows[index].Cells["PhuHuynh"].Value.ToString();
                txtDMHocPhi.Text = dataGridViewQLHS_ADMIN.Rows[index].Cells["DinhMucHocPhi"].Value.ToString();
                txtMaLop.Text = dataGridViewQLHS_ADMIN.Rows[index].Cells["MaLop"].Value.ToString();

            }
        }
    }
}
