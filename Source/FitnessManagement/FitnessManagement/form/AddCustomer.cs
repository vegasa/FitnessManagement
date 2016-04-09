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
using DevExpress.XtraEditors.Camera;
using System.IO;
using System.Drawing.Imaging;

namespace FitnessManagement.form
{
    public partial class AddCustomer : DevExpress.XtraEditors.XtraForm
    {
        public AddCustomer()
        {
            InitializeComponent();
        }
        private Control uiControl;

        public Control UIControl
        {
            get { return uiControl; }
            set { uiControl = value; }
        }
        private void AddCustomer_Load(object sender, EventArgs e)
        {
            this.Controls.Add(uiControl);
        }
    }
}