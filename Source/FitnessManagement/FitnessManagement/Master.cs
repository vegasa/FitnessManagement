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
using FitnessManagement.form;

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
            AddCustomer cus = new AddCustomer();
            cus.StartPosition = FormStartPosition.CenterParent;
            cus.UIControl = new UI_StudentofClass();
            cus.ShowDialog();
        }
    }
}