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

namespace QLTH.GUI
{
    public partial class QLTH_GiaoVien : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public QLTH_GiaoVien()
        {
            InitializeComponent();
               ribbon.Manager.ForceLinkCreate();
               DevExpress.UserSkins.BonusSkins.Register();
               DevExpress.Skins.SkinManager.EnableFormSkins();
               DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(skinRibbon, true, true);
          }
        public static string magv;

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!viewSitePanel.Controls.Contains(GIAOVIEN.Instance))
            {
                viewSitePanel.Controls.Add(GIAOVIEN.Instance);
                GIAOVIEN.Instance.Dock = DockStyle.Fill;
                GIAOVIEN.Instance.BringToFront();
            }
            else
            {
                GIAOVIEN.Instance.BringToFront();
                GIAOVIEN.Instance.Dock = DockStyle.Fill;

            }
        }

          private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
          {
               viewSitePanel.Controls.Clear();
               viewSitePanel.Controls.Add(ThongTinGiangDay_GiaoVien.Instance);
          }
     }
}