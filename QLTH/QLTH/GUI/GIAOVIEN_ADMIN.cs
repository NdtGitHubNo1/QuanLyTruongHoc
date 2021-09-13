using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoreLinq;
using DevExpress.XtraReports.UI;


namespace QLTH.GUI
{
    public partial class GIAOVIEN_ADMIN : UserControl
    {
        public GIAOVIEN_ADMIN()
        {
            InitializeComponent();
        }
        private static GIAOVIEN_ADMIN _instance;
        public static GIAOVIEN_ADMIN Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GIAOVIEN_ADMIN();
                return _instance;
            }
        }
        string trangthai = "";
        DATA.linqDataContext linq = new DATA.linqDataContext();

        public bool Checkcontrol()
        {
            if (string.IsNullOrWhiteSpace(txtMaGV.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã giáo viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaGV.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtHoten.Text))
            {
                MessageBox.Show("Bạn chưa nhập họ tên giáo viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoten.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cbbGioiTinh.Text))
            {
                MessageBox.Show("Bạn chưa nhập giới tính.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbbGioiTinh.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(dtpNgaysinh.Text))
            {
                MessageBox.Show("Bạn chưa nhập ngày sinh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpNgaysinh.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDiachi.Text))
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiachi.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSdt.Text))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSdt.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtLuong.Text))
            {
                MessageBox.Show("Bạn chưa nhập lương.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLuong.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cbbTrinhdo.Text))
            {
                MessageBox.Show("Bạn chưa nhập trình độ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbbTrinhdo.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cbbMamon.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã môn học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbbMamon.Focus();
                return false;
            }
            return true;
        }
        void refresh()
        {
            txtMaGV.Text = "";
            txtHoten.Text = "";
            cbbGioiTinh.Text = "";
            dtpNgaysinh.Text = "";
            txtDiachi.Text = "";
            txtSdt.Text = "";
            txtLuong.Text = "";
            cbbTrinhdo.Text = "";
            cbbMamon.Text = "";
        }
        private string SinhMa()
        {
            string magv = "";
            int ma = 1;
            DataTable gv = new DataTable();
            gv = linq.DANGNHAP1().ToDataTable();
            for (int i = 0; i < gv.Rows.Count; i++)
            {
                gv.Rows[i]["MaGV"] = gv.Rows[i]["MaGV"].ToString().Substring(8, 2);
            }
            for (int i = 0; i < gv.Rows.Count; i++)
            {
                if (ma != Int32.Parse(gv.Rows[i]["MaGV"].ToString())) break;
                else ma++;
            }
            if (ma >= 10)
            {
                magv = String.Concat("GV000000", ma.ToString());
            }
            if (ma < 10)
            {
                magv = String.Concat("GV0000000", ma.ToString());
            }
            return magv;


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            refresh();
            txtMaGV.Text = SinhMa();
            trangthai = "thêm";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            trangthai = "sửa";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                linq.XOAGIAOVIEN_ADMIN(txtMaGV.Text);
                MessageBox.Show("Xóa giáo viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
                GIAOVIEN_ADMIN_Load(sender, e);
            }
        }
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                MessageBox.Show("Bạn chưa nhập dữ kiện tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTimKiem.Focus();
            }
            else
            {
                try
                {
                    dataGridViewGiaoVien.DataSource = linq.TIMGIAOVIEN_ADMIN(txtTimKiem.Text);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void GIAOVIEN_ADMIN_Load(object sender, EventArgs e)
        {
            dataGridViewGiaoVien.DataSource = linq.XEMGIAOVIEN_ADMIN();
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            if (Checkcontrol())
            {
                if (trangthai == "thêm")
                {
                    try
                    {
                        linq.THEMGIAOVIEN_ADMIN(txtMaGV.Text, txtHoten.Text, cbbGioiTinh.Text, dtpNgaysinh.Value, txtDiachi.Text, int.Parse(txtSdt.Text), long.Parse(txtLuong.Text), cbbTrinhdo.Text, cbbMamon.Text);
                        MessageBox.Show("Thêm giáo viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        linq.SUAGIAOVIEN_ADMIN(txtMaGV.Text, txtHoten.Text, cbbGioiTinh.Text, dtpNgaysinh.Value, txtDiachi.Text, int.Parse(txtSdt.Text), long.Parse(txtLuong.Text), cbbTrinhdo.Text, cbbMamon.Text);
                        MessageBox.Show("Sửa thông tin thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            GIAOVIEN_ADMIN_Load(sender, e);
        }
        private void dataGridViewGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && index < dataGridViewGiaoVien.Rows.Count)
            {
                txtMaGV.Text = dataGridViewGiaoVien.Rows[index].Cells["MaGV"].Value.ToString();
                txtHoten.Text = dataGridViewGiaoVien.Rows[index].Cells["HoTen"].Value.ToString();
                cbbGioiTinh.Text = dataGridViewGiaoVien.Rows[index].Cells["GT"].Value.ToString();
                dtpNgaysinh.Text = dataGridViewGiaoVien.Rows[index].Cells["NgaySinh"].Value.ToString();
                txtDiachi.Text = dataGridViewGiaoVien.Rows[index].Cells["DiaChi"].Value.ToString();
                txtSdt.Text = dataGridViewGiaoVien.Rows[index].Cells["SDT"].Value.ToString();
                txtLuong.Text = dataGridViewGiaoVien.Rows[index].Cells["LuongCung"].Value.ToString();
                cbbTrinhdo.Text = dataGridViewGiaoVien.Rows[index].Cells["MaTrinhDo"].Value.ToString();
                cbbMamon.Text = dataGridViewGiaoVien.Rows[index].Cells["MaMon"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dt = from p in linq.XEM_TRINHDO() select p;
            List<GiaoVien> list = new List<GiaoVien>();
            foreach (var item in dt)
            {
                GiaoVien gv = new GiaoVien
                {
                    MaGV = item.MaGV.ToString(),
                    HoTen = item.HoTen.ToString(),
                    TrinhDo = item.TrinhDo.ToString(),
                    NgaySinh = item.NgaySinh.ToString()
                };
                list.Add(gv);
            }
            XtraReport2 xr2 = new XtraReport2();
            xr2.DataSource = list;
            xr2.ShowPreviewDialog();
        }
        public class GiaoVien
        {
            public string MaGV { set; get; }
            public string HoTen { set; get; }
            public string NgaySinh { set; get; }
            public string TrinhDo { set; get; }
        }
    }
}
