﻿using DevExpress.XtraBars;
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
        }

          private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
          {
               viewSitePanel.Controls.Clear();
               viewSitePanel.Controls.Add(ThongTinGiangDay_GiaoVien.Instance);
          }
     }
}