﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

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
                    linq.XoaTTGD_Admin(txtMaLop.Text, txtMaGV.Text, dtNgayDay.Value, Int32.Parse(txtSoTiet.Text), Int32.Parse(txtSoTien1Tiet.Text));
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
                              int index = dgvTTGD.CurrentRow.Index;
                              linq.SuaTTGD_Admin(txtMaLop.Text, txtMaGV.Text, Convert.ToDateTime(dgvTTGD.Rows[index].Cells["NgayDay"].Value.ToString()), Int32.Parse(dgvTTGD.Rows[index].Cells["SoTiet"].Value.ToString()), Int32.Parse(dgvTTGD.Rows[index].Cells["SoTienMotTiet"].Value.ToString()), dtNgayDay.Value, Int32.Parse(txtSoTiet.Text), Int32.Parse(txtSoTien1Tiet.Text));
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var dt = from p in linq.XEM_LICHDAY_BAOCAO(textEdit1.Text) select p;
            int count = 0;

            foreach (var item in dt)
            {
                count++;
            }
            if (count == 0)
            {
                MessageBox.Show("Không tìm thấy lịch dạy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var dt1 = from p in linq.XEM_LICHDAY_BAOCAO(textEdit1.Text) select p;
                List<LichDay> list = new List<LichDay>();
                foreach (var item1 in dt1)
                {
                    LichDay ld = new LichDay
                    {
                        TenLop = item1.TENLOP.ToString(),
                        NgayDay = item1.NGAYDAY.ToString(),
                        TenGV = item1.HoTen.ToString(),
                        MAGV = item1.MaGV.ToString()

                    };
                    list.Add(ld);
                }

                XtraReport3 xr3 = new XtraReport3();
                xr3.DataSource = list;
                xr3.ShowPreviewDialog();

            }
        }
        public class LichDay
        {
            public string TenLop { set; get; }
            public string NgayDay { set; get; }
            public string MAGV { set; get; }
            public string TenGV { set; get; }
        }

        private void txtSoTiet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Số tiết phải là các chữ số");
            }
        }

        private void txtSoTien1Tiet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Số tiền 1 tiết phải là các chữ số");
            }
        }
    }
}
