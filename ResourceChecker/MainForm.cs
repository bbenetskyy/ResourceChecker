using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ResourceChecker.Models.Enums;

namespace ResourceChecker
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Settings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            navigationFrame.SelectedPage = SettingPage;
        }

        private void Check_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            navigationFrame.SelectedPage = CheckPage;
        }

        private void StartCheking_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new ProgressForm().Show(this);
        }
    }
}
