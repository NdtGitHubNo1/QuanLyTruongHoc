using DevExpress.XtraEditors;
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
     public partial class ThongTinGiangDay_GiaoVien : DevExpress.XtraEditors.XtraUserControl
     {
          public ThongTinGiangDay_GiaoVien()
          {
               InitializeComponent();
          }
          private static ThongTinGiangDay_GiaoVien _instance;
          public static ThongTinGiangDay_GiaoVien Instance
          {
               get
               {
                    if (_instance == null)
                         _instance = new ThongTinGiangDay_GiaoVien();
                    return _instance;
               }
          }
          DATA.linqDataContext linq = new DATA.linqDataContext();

          private void ThongTinGiangDay_GiaoVien_Load(object sender, EventArgs e)
          {
               dgvTTGD.DataSource = linq.XemTTGD_GiaoVien("GV00000001");
          }
     }
}
