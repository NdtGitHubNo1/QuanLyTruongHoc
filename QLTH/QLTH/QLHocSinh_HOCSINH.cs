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

        string MaHocSinh = "";
        DATA.linqDataContext linq = new DATA.linqDataContext();

        private void QLHocSinh_HOCSINH_Load(object sender, EventArgs e)
        {
            dataGridViewQLHS_HocSinh.DataSource = linq.QLHS_HOCSINH("HS00000001");
        }

        private void dataGridViewQLHS_HocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >=0)
            {
                txtMaHS.Text = dataGridViewQLHS_HocSinh.Rows[index].Cells["MaHS"].Value.ToString();
                txtHoTen.Text = dataGridViewQLHS_HocSinh.Rows[index].Cells["HoTen"].Value.ToString();
                txtGT.Text = dataGridViewQLHS_HocSinh.Rows[index].Cells["GT"].Value.ToString();
                txtNgaySinh.Text = dataGridViewQLHS_HocSinh.Rows[index].Cells["NgaySinh"].Value.ToString();
                txtDiaChi.Text = dataGridViewQLHS_HocSinh.Rows[index].Cells["DiaChi"].Value.ToString();
                txtPhuHuynh.Text = dataGridViewQLHS_HocSinh.Rows[index].Cells["PhuHuynh"].Value.ToString();
                txtDMHocPhi.Text = dataGridViewQLHS_HocSinh.Rows[index].Cells["DMHocPhi"].Value.ToString();
                txtMaLop.Text = dataGridViewQLHS_HocSinh.Rows[index].Cells["MaLop"].Value.ToString();
            }    
        }
    }
}
