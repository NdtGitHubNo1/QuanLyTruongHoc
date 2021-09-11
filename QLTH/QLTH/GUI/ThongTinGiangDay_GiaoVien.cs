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

namespace QLTH
{
     public partial class ThongTinGiangDay_GiaoVien : DevExpress.XtraEditors.XtraUserControl
     {
          public ThongTinGiangDay_GiaoVien()
          {
               InitializeComponent();
          }
          private static ThongTinGiangDay_GiaoVien _instance;
          public static ThongTinGiangDay_GiaoVien Instance
          {
               get
               {
                    if (_instance == null)
                         _instance = new ThongTinGiangDay_GiaoVien();
                    return _instance;
               }
          }
          DATA.linqDataContext linq = new DATA.linqDataContext();

          private void ThongTinGiangDay_GiaoVien_Load(object sender, EventArgs e)
          {
               dgvTTGD.DataSource = linq.XemTTGD_GiaoVien("GV00000004");
          }

          private void btnTimKiem_Click(object sender, EventArgs e)
          {
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
     }
}
