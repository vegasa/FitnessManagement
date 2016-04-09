using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using FitnessManagement.Utilitys;
using FitnessManagement.form;
using FitnessManagement.UIs;

namespace FitnessManagement
{
    public partial class Master : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Master()
        {
            InitializeComponent();
        }

        private void btnListCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnAddCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {
            var waiting = new WaitHelper();
            waiting.Show();
            FormAdd cus = new FormAdd();
            cus.StartPosition = FormStartPosition.CenterParent;
            cus.UIControl = new UI_AddCustomer();
            waiting.Hide(true);
            cus.ShowDialog();
        }
        #region tabcontrol
        int GetIndexExistPage(XtraTabControl tabMain, XtraTabPage page)
        {
            if (tabMain.TabPages.Count > 0)
            {
                foreach (XtraTabPage chkPage in tabMain.TabPages)
                {
                    if (chkPage.Name.Equals(page.Name))
                    {
                        tabMain.SelectedTabPage = chkPage;
                        return tabMain.SelectedTabPageIndex;
                    }
                }
                return -1;
            }
            else
                return -1;
        }
        void AddTabPage(string Caption, UserControl us)
        {
            this.Cursor = Cursors.WaitCursor;
            TabControl.BeginUpdate();

            XtraTabPage page = new XtraTabPage();
            page.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;

            page.Text = Caption;
            page.Name = us.Name;
            page.Controls.Add(us);
            int selectedIndex = GetIndexExistPage(TabControl, page);
            if (selectedIndex == -1)
            {
                TabControl.TabPages.Add(page);
                TabControl.SelectedTabPage = page;
            }
            else
                TabControl.SelectedTabPageIndex = selectedIndex;
            TabControl.EndUpdate();
            this.Cursor = Cursors.Default;
        }
        private void TabControl_CloseButtonClick(object sender, EventArgs e)
        {
            XtraTabControl tabMain = (XtraTabControl)sender;
            ClosePageButtonEventArgs arg = e as ClosePageButtonEventArgs;
            if (arg.PrevPage != null)
            {
                tabMain.TabPages.Remove(arg.Page as XtraTabPage);
            }
            else
            {
                for (int i = tabMain.TabPages.Count - 1; i >= 0; i--)
                {
                    XtraTabPage tab = tabMain.TabPages[i];
                    tabMain.TabPages.Remove(tab);
                }
            }
        }
        void usCloseTab(XtraTabPage page)
        {
            this.Cursor = Cursors.WaitCursor;
            TabControl.TabPages.Remove(page);
            this.Cursor = Cursors.Default;
        }
        #endregion

        private void Master_Load(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLG = new frmLogin();
            frmLG.ShowDialog();
            //dateCurrent.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //Utility.AccConfigUtility.CurrentUser = frmLG.userLogin;
            //if (Utility.AccConfigUtility.CurrentUser == null)
            //    this.Close();
            //else
            //{
                this.Show();
            //    dateCurrent.DateTime = DateTime.Now.Date;
            //    bsiUser.Caption = Utility.AccConfigUtility.CurrentUser.Fullname + " - " + Utility.AccConfigUtility.CurrentUser.PositionName;
            //    bsiUser.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            //}
        }
    }
}