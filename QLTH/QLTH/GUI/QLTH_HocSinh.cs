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
    public partial class QLTH_HocSinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public QLTH_HocSinh()
        {
            InitializeComponent();
               ribbon.Manager.ForceLinkCreate();
               DevExpress.UserSkins.BonusSkins.Register();
               DevExpress.Skins.SkinManager.EnableFormSkins();
               DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(skinRibbon, true, true);
          }
        public static string mahs;

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            viewSitePanel.Controls.Clear();
            viewSitePanel.Controls.Add(QLHocSinh_HOCSINH.Instance);
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            viewSitePanel.Controls.Clear();
            viewSitePanel.Controls.Add(LichHoc_HocSinh.Instance);
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = new FormDangNhap();
            f.Show();
            this.Hide();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }
    }
}