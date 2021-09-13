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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        DATA.linqDataContext linq = new DATA.linqDataContext();
        private void TrinhDoButton_Click(object sender, EventArgs e)
        {
            var dt = from p in linq.XEM_TRINHDO() select p;
            List<GiaoVien> list = new List<GiaoVien>();
            foreach(var item in dt)
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
