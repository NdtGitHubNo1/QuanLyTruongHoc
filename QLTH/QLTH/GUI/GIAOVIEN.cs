using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTH.DATA;
using MoreLinq;

namespace QLTH.GUI
{
    public partial class GIAOVIEN : UserControl
    {
        public GIAOVIEN()
        {
            InitializeComponent();
        }
        private static GIAOVIEN _instance;
        public static GIAOVIEN Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GIAOVIEN();
                return _instance;
            }
        }
        linqDataContext linq = new linqDataContext();
        DataTable db = new DataTable();
        private void label9_Click(object sender, EventArgs e)
        {

        }
         
         void ReadOnly()
        {
            txtMaGV.ReadOnly = true;
            txtHoten.ReadOnly = true;
            txtGioitinh.ReadOnly = true;
            txtNgaySinh.ReadOnly = true;
            txtDiachi.ReadOnly = true;
            txtSdt.ReadOnly = true;
            txtluong.ReadOnly = true;
            txttrinhdo.ReadOnly = true;
            txtmamon.ReadOnly = true;      

        }

          private void GIAOVIEN_Load(object sender, EventArgs e)
          {
               db = linq.THONGTIN_GIAOVIEN(GUI.QLTH_GiaoVien.magv).ToDataTable();
               txtMaGV.Text = db.Rows[0]["MaGV"].ToString();
               txtHoten.Text = db.Rows[0]["HoTen"].ToString();
               txtGioitinh.Text = db.Rows[0]["GT"].ToString();
               txtNgaySinh.Text = db.Rows[0]["NgaySinh"].ToString();
               txtDiachi.Text = db.Rows[0]["DiaChi"].ToString();
               txtSdt.Text = db.Rows[0]["SDT"].ToString();
               txtluong.Text = db.Rows[0]["LuongCung"].ToString();
               txttrinhdo.Text = db.Rows[0]["MaTrinhDo"].ToString();
               txtmamon.Text = db.Rows[0]["MaMon"].ToString();

            ReadOnly();
          }
     }
}
