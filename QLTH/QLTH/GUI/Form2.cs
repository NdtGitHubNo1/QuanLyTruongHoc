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
    public partial class Form2 : Form
    {
        DATA.linqDataContext linq = new DATA.linqDataContext();
        public Form2()
        {
            InitializeComponent();
        }

        private void BaoCaoButton_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "")
            {
                MessageBox.Show("Hẫy nhập mã lớp", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                var dt = from p in linq.XEM_HOCSINH_BAOCAO(comboBox1.Text) select p;
                List<HocSinh> list = new List<HocSinh>();
                foreach(var item in dt)
                {
                    HocSinh hs = new HocSinh
                    {
                        MaHS = item.MaHS.ToString(),
                        HoTen = item.HoTen.ToString(),
                        GioiTinh = item.GT.ToString(),
                        DiaChi = item.DiaChi.ToString(),
                        NgaySinh = item.NgaySinh.ToString(),
                        PhuHuynh = item.PhuHuynh.ToString(),
                        DinhMuc = Convert.ToDouble(item.DinhMucHocPhi.ToString()),
                        MaLop = item.MaLop.ToString()
                    };
                    list.Add(hs);
                }
                XtraReport1 xr1 = new XtraReport1();
                xr1.DataSource = list;
                xr1.ShowPreviewDialog();
                //frm3.ShowDialog();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var dt= from p in linq.XEMMALOP() select p;
            foreach(var item in dt)
            {
                comboBox1.Items.Add(item.MALOP.ToString());
            }
        }
        public class HocSinh
        {
            public string MaHS { set; get; }
            public string HoTen { set; get; }
            public string GioiTinh { set; get; }
            public string NgaySinh{ set; get; }
            public string DiaChi{ set; get; }
            public string PhuHuynh { set; get; }
            public double DinhMuc { set; get; }
            public string MaLop { set; get; }
        }

    }
}
