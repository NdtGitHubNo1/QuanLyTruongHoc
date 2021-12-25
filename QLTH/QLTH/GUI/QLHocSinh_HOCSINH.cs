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
    public partial class QLHocSinh_HOCSINH : UserControl
    {
        public QLHocSinh_HOCSINH()
        {
            InitializeComponent();
        }
        private static QLHocSinh_HOCSINH _instance;
        public static QLHocSinh_HOCSINH Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new QLHocSinh_HOCSINH();
                return _instance;
            }
        }
        string mahs = "";
        DATA.linqDataContext linq = new DATA.linqDataContext();

        private void QLHocSinh_HOCSINH_Load(object sender, EventArgs e)
        {
            dataGridViewQLHS_HocSinh.DataSource = linq.QLHS_HOCSINH(GUI.QLTH_HocSinh.mahs);

        }

        void ReadOnly()
        {
            txtMaHS.ReadOnly = true;
            txtHoTen.ReadOnly = true;
            txtGT.ReadOnly = true;
            txtNgaySinh.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtPhuHuynh.ReadOnly = true;
            txtDMHocPhi.ReadOnly = true;
            txtMaLop.ReadOnly = true;

        }
        private void dataGridViewQLHS_HocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && index < dataGridViewQLHS_HocSinh.Rows.Count)
            {
                txtMaHS.Text = dataGridViewQLHS_HocSinh.Rows[index].Cells["MaHS"].Value.ToString();
                txtHoTen.Text = dataGridViewQLHS_HocSinh.Rows[index].Cells["HoTen"].Value.ToString();
                txtGT.Text = dataGridViewQLHS_HocSinh.Rows[index].Cells["GT"].Value.ToString();
                txtNgaySinh.Text = dataGridViewQLHS_HocSinh.Rows[index].Cells["NgaySinh"].Value.ToString();
                txtDiaChi.Text = dataGridViewQLHS_HocSinh.Rows[index].Cells["DiaChi"].Value.ToString();
                txtPhuHuynh.Text = dataGridViewQLHS_HocSinh.Rows[index].Cells["PhuHuynh"].Value.ToString();
                txtDMHocPhi.Text = dataGridViewQLHS_HocSinh.Rows[index].Cells["DinhMucHocPhi"].Value.ToString();
                txtMaLop.Text = dataGridViewQLHS_HocSinh.Rows[index].Cells["MaLop"].Value.ToString();

                ReadOnly();
            }
        }
    }
}
