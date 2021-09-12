using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTH.GUI;

namespace QLTH
{
    public partial class QLTH_Admin : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public QLTH_Admin()
        {
            InitializeComponent();
        }
          private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
          {
               if (!viewSitePanel.Controls.Contains(GIAOVIEN_ADMIN.Instance))
               {
                    viewSitePanel.Controls.Add(GIAOVIEN_ADMIN.Instance);
                    GIAOVIEN_ADMIN.Instance.Dock = DockStyle.Fill;
                    GIAOVIEN_ADMIN.Instance.BringToFront();
               }
               else
               {
                    GIAOVIEN_ADMIN.Instance.BringToFront();
                    GIAOVIEN_ADMIN.Instance.Dock = DockStyle.Fill;

               }
          }
          private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
          {
               viewSitePanel.Controls.Clear();
               viewSitePanel.Controls.Add(ThongTinGiangDay_Admin.Instance);
          }
     }
}