using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

namespace QLTH.GUI
{
    public partial class ThongKe : UserControl
    {
        public ThongKe()
        {
            InitializeComponent();
        }
        DATA.linqDataContext linq = new DATA.linqDataContext();
        private static ThongKe _instance;
        public static ThongKe Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ThongKe();
                return _instance;
            }
        }
        private void btnTK_Click(object sender, EventArgs e)
        {
            if (cbxTK.Text == "Học Phí, Lương")
            {
                int i = 0;
                var dsnv = linq.TK_TIEN_THEOTHANG().ToList()
                        .Select(p => new
                        {
                            STT = ++i,
                            Tháng = p.THANG,
                            Tổng_Học_Phí = p.THU,
                            Tổng_Lương = p.CHI
                        }).ToList();
                dgvTK.DataSource = dsnv;

                Series series1 = new Series("1", ViewType.Pie);
                var dt = from p in linq.TK_TIEN() select p;
                List<Tien> list = new List<Tien>();
                foreach (var item in dt)
                {
                    
                    Tien nv = new Tien
                    {
                        Thu = Convert.ToDouble(item.HocPhi),
                        Chi = Convert.ToDouble(item.Luong)
                    };
                    list.Add(nv);
                    
                    series1.Points.Add(new SeriesPoint("Lương giáo viên", item.Luong));
                    series1.Points.Add(new SeriesPoint("Học phí", item.HocPhi));
                }
                chartTK.Series.Clear();
                chartTK.DataSource = list;
                chartTK.Series.Add(series1);
                series1.Label.TextPattern = "{A}: {V} VNĐ";
                chartTK.AppearanceNameSerializable = "Grays";
                DevExpress.XtraCharts.ChartTitle title = new DevExpress.XtraCharts.ChartTitle();
                chartTK.Titles.Clear();
                title.Text = "Thống kê học phí, lương";
                chartTK.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] { title });

            }
            if (cbxTK.Text == "Giáo viên theo trình độ")
            {
                int i = 0;
                var dsnv = linq.XEM_TRINHDO().ToList()
                        .Select(p => new
                        {
                            STT = ++i,
                            Mã_Giáo_Viên = p.MaGV,
                            Tên_Giáo_Viên = p.HoTen,
                            Ngày_Sinh = p.NgaySinh,
                            Trình_Độ = p.TrinhDo
                        }).ToList();
                dgvTK.DataSource = dsnv;

                Series series1 = new Series("1", ViewType.Pie);
                var dt = from p in linq.XEM_TRINHDO_BieuDo() select p;
                List<TrinhDo> list = new List<TrinhDo>();
                foreach (var item in dt)
                {

                    TrinhDo nv = new TrinhDo
                    {
                        TD= item.TrinhDo.ToString(),
                        Tong = Convert.ToInt32(item.Tong)
                    };
                    list.Add(nv);              
                }
                chartTK.Series.Clear();
                chartTK.DataSource = list;
                chartTK.Series.Add(series1);
                series1.ArgumentDataMember = "TD";
                series1.ValueDataMembers.AddRange("Tong");
                series1.Label.TextPattern = "{A}: {V}"; 
                chartTK.AppearanceNameSerializable = "Grays";
                DevExpress.XtraCharts.ChartTitle title = new DevExpress.XtraCharts.ChartTitle();
                chartTK.Titles.Clear();
                title.Text = "Thống kê giáo viên theo trình độ";
                chartTK.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] { title });
            }
            if (cbxTK.Text == "Giáo viên theo môn học")
            {
                int i = 0;
                var dsnv = linq.XEM_GIAOVIEN_THEOMONHOC().ToList()
                        .Select(p => new
                        {
                            STT = ++i,
                            Mã_Giáo_Viên = p.MaGV,
                            Tên_Giáo_Viên = p.HoTen,
                            Ngày_Sinh = p.NgaySinh,
                            Môn_Học = p.TenMon
                        }).ToList();
                dgvTK.DataSource = dsnv;

                Series series1 = new Series("1", ViewType.Pie);
                var dt = from p in linq.XEM_GIAOVIEN_THEOMONHOC_BIEUDO() select p;
                List<MonHoc> list = new List<MonHoc>();
                foreach (var item in dt)
                {

                    MonHoc nv = new MonHoc
                    {
                        MH = item.TenMon.ToString(),
                        Tong = Convert.ToInt32(item.TONG)
                    };
                    list.Add(nv);                  
                }
                chartTK.Series.Clear();
                chartTK.DataSource = list;
                chartTK.Series.Add(series1);
                series1.ArgumentDataMember = "MH";
                series1.ValueDataMembers.AddRange("Tong");
                series1.Label.TextPattern = "{A}: {V}";
                chartTK.AppearanceNameSerializable = "Grays";
                DevExpress.XtraCharts.ChartTitle title = new DevExpress.XtraCharts.ChartTitle();
                chartTK.Titles.Clear();
                title.Text = "Thống kê giáo viên theo môn học";
                chartTK.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] { title });
            }
            if (cbxTK.Text == "Học sinh theo định mức")
            {
                int i = 0;
                var dsnv = linq.XEM_HOCSINH_DINHMUC().ToList()
                        .Select(p => new
                        {
                            STT = ++i,
                            Mã_Học_Sinh = p.MaHS,
                            Tên_Học_Sinh = p.HoTen,
                            Ngày_Sinh = p.NgaySinh,
                            Định_Mức = p.DinhMucHocPhi
                        }).ToList();
                dgvTK.DataSource = dsnv;

                Series series1 = new Series("1", ViewType.Pie);
                var dt = from p in linq.XEM_HOCSINH_DINHMUC_BIEUDO() select p;
                List<DinhMuc> list = new List<DinhMuc>();
                foreach (var item in dt)
                {

                    DinhMuc nv = new DinhMuc
                    {
                        DM = item.DinhMucHocPhi.ToString(),
                        Tong = Convert.ToInt32(item.TONG)
                    };
                    list.Add(nv);
                }
                chartTK.Series.Clear();
                chartTK.DataSource = list;
                chartTK.Series.Add(series1);
                series1.ArgumentDataMember = "DM";
                series1.ValueDataMembers.AddRange("Tong");
                series1.Label.TextPattern = "{A}: {V}";
                chartTK.AppearanceNameSerializable = "Grays";
                DevExpress.XtraCharts.ChartTitle title = new DevExpress.XtraCharts.ChartTitle();
                chartTK.Titles.Clear();
                title.Text = "Thống kê học sinh theo định mức";
                chartTK.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] { title });
            }
        }
        public class Tien
        {
            public double Thu{ set; get; }
            public double Chi { set; get; }
        }

        public class TrinhDo
        {
            public string TD{ set; get; }
            public int Tong { set; get; }
        }
        public class MonHoc
        {
            public string MH { set; get; }
            public int Tong { set; get; }
        }
        public class DinhMuc
        {
            public string DM { set; get; }
            public int Tong { set; get; }
        }

    }
}
