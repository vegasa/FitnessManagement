using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System.Threading;
using FitnessManagement.Utilitys;


namespace FitnessManagement.form
{
    public partial class frmLogin : XtraForm
    {
        #region Init
        //public SystemUser userLogin;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            WaitHelper.Manager = splashScrManager;
            txtTenDN.Text = "1314";
            //txtMK.Text = "Concung@123";
        }
        #endregion

        #region Function
        bool DoLogin()
        {
            
            bool result = false;
            string user = txtTenDN.Text.Trim();
            string pass = txtMK.Text.Trim();

            //CC.Accounting.AppCore.SystemUser login = new CC.Accounting.AppCore.SystemUser();
            //userLogin = login.DoLogin(Utility.AccConfigUtility.URI, user, pass);
            //result = userLogin != null ? true : false;
            //return result;
            return true;
        }
        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnDN_Click(null, null);               
            }
        }
        #endregion

        #region Event
        private   void btnDN_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            string strMessage = string.Empty;
            var w = new WaitHelper();
            w.Show();
            w.SetDescription("Kiểm tra thông tin đăng nhập");
            if (!string.IsNullOrEmpty(txtTenDN.Text.Trim()) && !string.IsNullOrEmpty(txtMK.Text))
            {
                try
                {
                    bool kq = DoLogin();
                    if (kq)
                    {
                        //AccConfigUtility.Init(w);
                        this.Close();
                    }
                    else
                        strMessage = AccMessageUtility.APP_LOGIN_FAILED;
                }
                catch
                {
                    w.Hide(true);
                    strMessage = AccMessageUtility.APP_SERVICE_CONNECTION;
                }
            }
            else
                strMessage = AccMessageUtility.APP_LOGIN_EMPTY_REQUIRE;
            w.Hide(true);
            this.Cursor = Cursors.Default;
            if (!string.IsNullOrEmpty(strMessage))
            {
                txtMK.Text = string.Empty;
                Utils.ShowMsg(strMessage);
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
