using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTH.GUI
{
     public partial class ThongTinGiangDay_Admin : DevExpress.XtraEditors.XtraUserControl
     {
          public ThongTinGiangDay_Admin()
          {
               InitializeComponent();
          }
          private static ThongTinGiangDay_Admin _instance;
          public static ThongTinGiangDay_Admin Instance
          {
               get
               {
                    if (_instance == null)
                         _instance = new ThongTinGiangDay_Admin();
                    return _instance;
               }
          }
          string trangthai = "";
          DATA.linqDataContext linq = new DATA.linqDataContext();
          void refresh()
          {
               txtMaLop.Text = "";
               txtMaGV.Text = "";
               txtSoTiet.Text = "";
               txtSoTien1Tiet.Text = "";
          }
          public bool Check()
          {
               if (string.IsNullOrWhiteSpace(txtMaLop.Text))
               {
                    MessageBox.Show("Bạn chưa nhập mã lớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaLop.Focus();
                    return false;
               }
               if (string.IsNullOrWhiteSpace(txtMaGV.Text))
               {
                    MessageBox.Show("Bạn chưa nhập mã giáo viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaGV.Focus();
                    return false;
               }

               if (string.IsNullOrWhiteSpace(txtSoTiet.Text))
               {
                    MessageBox.Show("Bạn chưa nhập số tiết dạy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSoTiet.Focus();
                    return false;
               }
               if (string.IsNullOrWhiteSpace(txtSoTien1Tiet.Text))
               {
                    MessageBox.Show("Bạn chưa nhập số tiền của một tiết dạy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSoTien1Tiet.Focus();
                    return false;
               }
               return true;
          }

          private void dgvTTGD_CellClick(object sender, DataGridViewCellEventArgs e)
          {
               int index = e.RowIndex;
               if (index >= 0 && index < dgvTTGD.Rows.Count)
               {
                    txtMaLop.Text = dgvTTGD.Rows[index].Cells["MaLop"].Value.ToString();
                    txtMaGV.Text = dgvTTGD.Rows[index].Cells["MaGV"].Value.ToString();
                    dtNgayDay.Value = Convert.ToDateTime(dgvTTGD.Rows[index].Cells["NgayDay"].Value.ToString());
                    txtSoTiet.Text = dgvTTGD.Rows[index].Cells["SoTiet"].Value.ToString();
                    txtSoTien1Tiet.Text = dgvTTGD.Rows[index].Cells["SoTienMotTiet"].Value.ToString();
               }
          }

          private void ThongTinGiangDay_Admin_Load(object sender, EventArgs e)
          {
               dgvTTGD.DataSource = linq.XemTTGD_Admin();
          }

          private void btnThem_Click(object sender, EventArgs e)
          {
               refresh();
               txtMaLop.Enabled = true;
               txtMaGV.Enabled = true;
               trangthai = "thêm";
          }

          private void btnSua_Click(object sender, EventArgs e)
          {
               trangthai = "sửa";
               txtMaLop.Enabled = false;
          }

          private void btnXoa_Click(object sender, EventArgs e)
          {
               if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
               {
                    linq.XoaTTGD_Admin(txtMaLop.Text, txtMaGV.Text);
                    refresh();
                    ThongTinGiangDay_Admin_Load(sender, e);
               }
          }

          private void btnLuu_Click(object sender, EventArgs e)
          {
               if (Check())
               {
                    if (trangthai == "thêm")
                    {
                         try
                         {
                              linq.ThemTTGD_Admin(txtMaLop.Text, txtMaGV.Text, dtNgayDay.Value, Int32.Parse(txtSoTiet.Text), Int32.Parse(txtSoTien1Tiet.Text));
                         }
                         catch (Exception ex)
                         {
                              MessageBox.Show(ex.Message);
                         }
                    }
                    if (trangthai == "sửa")
                    {
                         try
                         {
                              linq.SuaTTGD_Admin(txtMaLop.Text, txtMaGV.Text, dtNgayDay.Value, Int32.Parse(txtSoTiet.Text), Int32.Parse(txtSoTien1Tiet.Text));
                         }
                         catch (Exception ex)
                         {
                              MessageBox.Show(ex.Message);
                         }
                    }
               }
               ThongTinGiangDay_Admin_Load(sender, e);
               txtMaLop.Enabled = false;
               txtMaGV.Enabled = false;
          }

          private void btnTimKiem_Click(object sender, EventArgs e)
          {
               refresh();
               if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
               {
                    MessageBox.Show("Bạn chưa nhập dữ kiện tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTimKiem.Focus();
               }
               else
               {
                    dgvTTGD.DataSource = linq.TimTTGD_Admin(txtTimKiem.Text);
               }
          }
     }
}
