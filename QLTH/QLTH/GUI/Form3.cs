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
    public partial class Form3 : Form
    {
        DATA.linqDataContext linq = new DATA.linqDataContext();
        public Form3()
        {
            InitializeComponent();
        }

        private void LichDayButton_Click(object sender, EventArgs e)
        {
            var dt = from p in linq.XEM_LICHDAY_BAOCAO(textBox1.Text) select p;
            int count = 0;
            
            foreach(var item in dt)
            {
                count++;
            }    
            if(count == 0)
            {
                MessageBox.Show("Không tìm thấy lịch dạy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var dt1 = from p in linq.XEM_LICHDAY_BAOCAO(textBox1.Text) select p;
                List<LichDay> list = new List<LichDay>();
                foreach(var item1 in dt1)
                {
                    LichDay ld = new LichDay
                    {
                        TenLop = item1.TENLOP.ToString(),
                        NgayDay = item1.NGAYDAY.ToString(),
                        TenGV = item1.HoTen.ToString(),
                        MAGV  = item1.MaGV.ToString()

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
    }
}
