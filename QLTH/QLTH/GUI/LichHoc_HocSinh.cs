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
    public partial class LichHoc_HocSinh : UserControl
    {
        public LichHoc_HocSinh()
        {
            InitializeComponent();
        }

        string mahs = "";

        DATA.linqDataContext linq = new DATA.linqDataContext();

        private static LichHoc_HocSinh _instance;
        public static LichHoc_HocSinh Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LichHoc_HocSinh();
                return _instance;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LichHoc_HocSinh_Load(object sender, EventArgs e)
        {
            dataGridViewLichHoc.DataSource = linq.XEMLICHHOC_HOCSINH(GUI.QLTH_HocSinh.mahs);

        }

        private void dataGridViewLichHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && index < dataGridViewLichHoc.Rows.Count)
            {
                txtMaHS.Text = dataGridViewLichHoc.Rows[index].Cells["MaHS"].Value.ToString();
                txtMaLop.Text = dataGridViewLichHoc.Rows[index].Cells["MaLop"].Value.ToString();
                txtHoTen.Text = dataGridViewLichHoc.Rows[index].Cells["HoTen"].Value.ToString();
                txtTenLop.Text = dataGridViewLichHoc.Rows[index].Cells["TenLop"].Value.ToString();
                txtTenMon.Text = dataGridViewLichHoc.Rows[index].Cells["TenMon"].Value.ToString();
                txtNgayDay.Text = dataGridViewLichHoc.Rows[index].Cells["NgayDay"].Value.ToString();
                txtSoTiet.Text = dataGridViewLichHoc.Rows[index].Cells["SoTiet"].Value.ToString();
                txtGVCN.Text = dataGridViewLichHoc.Rows[index].Cells["GVCN"].Value.ToString();
            }
        }
    }
}
