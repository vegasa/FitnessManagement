using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using FitnessManagement.MsgBox;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessManagement.Utilitys
{
    public enum MessageBoxConfirmType
    {
        YesNo,
        YesNoCancel
    }

    public static class Utils
    {
        #region Skin

        public static void RegisterSkins()
        {
            SkinManager.EnableFormSkins();
            //SkinManager.EnableFormSkinsIfNotVista();
            BonusSkins.Register();
        }

        /// <summary>
        /// Initialize skin for application
        /// </summary>
        /// <param name="skinName">Skin's name</param>
        public static void InitDefaultUI(string skinName)
        {
            //var gui = new DefaultLookAndFeel();
            //gui.LookAndFeel.SetSkinStyle(skinName);

            UserLookAndFeel.Default.SetSkinStyle(skinName);
        }

        #endregion

        #region MessageBox

        /// <summary>
        /// MessageBox.Show() replacement.
        /// </summary>
        public static void ShowMsg(string msg)
        {
            XMsgBox(null, msg, false);
        }

        /// <summary>
        /// MessageBox.Show() replacement.
        /// </summary>
        public static void ShowError(string error, Exception ex = null)
        {
            //XMsgBox(null, error, true);
            CustomMessageBox.ShowError(error, Constants.APP_TITLE, ex);
        }

        ///// <summary>
        ///// MessageBox.Show() replacement.
        ///// </summary>
        //public static void ShowErrorWithOwner(IWin32Window owner, string error)
        //{
        //    XMsgBox(owner, error, true);
        //}

        private static void XMsgBox(IWin32Window owner, string msg, bool error)
        {
            DialogResult[] buttons = { DialogResult.OK };
            Icon ico = error ? Global.WarningIcon : Global.InfoIcon;
            MessageBoxIcon beep = error ? MessageBoxIcon.Exclamation : MessageBoxIcon.Information;

            //var feel = new UserLookAndFeel(owner);
            //feel.SetSkinStyle(Config.Skin);

            var feel = UserLookAndFeel.Default;

            Action action = () => XtraMessageBox.Show(feel, owner, msg, Constants.APP_TITLE, buttons, ico, 0, beep);

            if (owner is Control)
            {
                var ctrl = owner as Control;
                if (ctrl.InvokeRequired)
                {
                    ctrl.Invoke(action);
                    return;
                }
            }

            action();
        }

        /// <summary>
        /// Show user-confirm message box.
        /// </summary>
        public static DialogResult ShowConfirmMsg(string msg, MessageBoxConfirmType type)
        {
            return ShowConfirmMsg(null, msg, type);
        }

        /// <summary>
        /// Show user-confirm message box with owner.
        /// </summary>
        public static DialogResult ShowConfirmMsg(IWin32Window owner, string msg, MessageBoxConfirmType type)
        {
            DialogResult[] buttons =
                type == MessageBoxConfirmType.YesNoCancel ?
                new DialogResult[] { DialogResult.Yes, DialogResult.No, DialogResult.Cancel } :
                new DialogResult[] { DialogResult.Yes, DialogResult.No };

            Icon ico = Global.QuestionIcon;
            const MessageBoxIcon beep = MessageBoxIcon.Question;

            //UserLookAndFeel feel = new UserLookAndFeel(owner);
            //feel.SetSkinStyle(Config.Skin);

            var feel = UserLookAndFeel.Default;

            return XtraMessageBox.Show(feel, owner, msg, Constants.APP_TITLE, buttons, ico, 0, beep);
        }

        #endregion

        #region Open, Save dialog

        /// <summary>
        /// Create an open file dialog
        /// </summary>
        /// <param name="multiSelect">Enable select multiple files</param>
        /// <param name="filter">Filter of open file dialog</param>
        /// <param name="filterIndex">Default filter</param>
        /// <param name="initDir">Initilize directory</param>
        /// <returns>Open file dialog</returns>
        public static OpenFileDialog CreateOpenFileDialog(bool multiSelect, string filter, int filterIndex, string initDir)
        {
            var dlg = new OpenFileDialog
            {
                Multiselect = multiSelect,
                Filter = filter,
                FilterIndex = filterIndex
            };
            if (!string.IsNullOrEmpty(initDir)) dlg.InitialDirectory = initDir;
            return dlg;
        }

        /// <summary>
        /// Create an save file dialog
        /// </summary>
        /// <param name="filter">Filter of save file dialog</param>
        /// <param name="filterIndex">Default filter</param>
        /// <param name="initDir">Initilize directory</param>
        /// <returns>Save file dialog</returns>
        public static SaveFileDialog CreateSaveFileDialog(string filter, int filterIndex, string initDir)
        {
            var dlg = new SaveFileDialog
            {
                Filter = filter,
                FilterIndex = filterIndex
            };
            if (!string.IsNullOrEmpty(initDir)) dlg.InitialDirectory = initDir;
            return dlg;
        }
        #endregion

        #region Clean Up

        /// <summary>
        /// Clear textEdits
        /// </summary>
        public static void ClearTextEdits(params TextEdit[] txts)
        {
            foreach (TextEdit txt in txts) txt.Text = string.Empty;
        }

        /// <summary>
        /// Clear comboBoxEdits
        /// </summary>
        public static void ClearComboBoxEdits(params ComboBoxEdit[] cbes)
        {
            foreach (ComboBoxEdit cbe in cbes) cbe.Text = string.Empty;
        }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        public static void SetEnabled(bool enabled, params Control[] controls)
        {
            foreach (var c in controls) c.Enabled = enabled;
        }

        /// <summary>
        /// Show Help (chm) file.
        /// </summary>
        /// <param name="f"></param>
        /// <param name="url"></param>
        public static void ShowHelp(Form f, string url)
        {
            if (File.Exists(PathProvider.HelpPATH))
            {
                Help.ShowHelp(f, PathProvider.HelpPATH, HelpNavigator.Topic, url);
            }
        }

        
        #region LookupEdit
        public static void LoadLookupEdit(LookUpEdit lkup, BindingSource data, string valueMember, string displayMember, bool showHeader, params LookUpColumnInfo[] cols)
        {
            lkup.Properties.DataSource = data;
            lkup.Properties.ValueMember = valueMember;
            lkup.Properties.DisplayMember = displayMember;
            lkup.Properties.ShowHeader = showHeader;
            lkup.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            lkup.Properties.Columns.Clear();
            lkup.Properties.Columns.AddRange(cols);
        }
        //public static void LoadLkupTK(object lkup, params string[] codes)
        //{
        //    List<OpenBalance> dataSource = new List<OpenBalance>();
        //    if (codes.Length > 0)
        //    {
        //        List<OpenBalance> data = new List<OpenBalance>();
        //        foreach (string str in codes)
        //        {
        //            data = new ACCAsset().GetAllNodeOfRootNode(Utility.AccConfigUtility.URI, str);
        //            dataSource.AddRange(data);
        //        }
        //    }
        //    BindingSource source = new BindingSource() { DataSource = dataSource };
        //    LookUpColumnInfo colCode = new LookUpColumnInfo("OpeningBalanceCode");
        //    LookUpColumnInfo colName = new LookUpColumnInfo("OpeningBalanceName");
        //    if (lkup is LookUpEdit)
        //        LoadLookupEdit((LookUpEdit)lkup, source, "OpeningBalanceID", "OpeningBalanceCode", false, colCode, colName);
        //    else if (lkup is RepositoryItemLookUpEdit)
        //    {
        //        RepositoryItemLookUpEdit repoEdit = (RepositoryItemLookUpEdit)lkup;
        //        repoEdit.DataSource = dataSource;
        //        repoEdit.ValueMember = "OpeningBalanceID";
        //        repoEdit.DisplayMember = "OpeningBalanceCode";
        //        repoEdit.ShowHeader = false;
        //        repoEdit.Columns.Clear();
        //        repoEdit.Columns.Add(colCode);
        //        repoEdit.Columns.Add(colName);
        //        repoEdit.BestFitMode = BestFitMode.BestFitResizePopup;
        //    }
        //}
        #endregion
    }
}
