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
               ribbon.Manager.ForceLinkCreate();
               DevExpress.UserSkins.BonusSkins.Register();
               DevExpress.Skins.SkinManager.EnableFormSkins();
               DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(skinRibbon, true, true);
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

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            viewSitePanel.Controls.Clear();
            viewSitePanel.Controls.Add(QLHocSinh_ADMIN.Instance);
        }

          private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
          {
               viewSitePanel.Controls.Clear();
               viewSitePanel.Controls.Add(ThongKe.Instance);
          }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = new FormDangNhap();
            f.Show();
            this.Hide();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }
    }
}