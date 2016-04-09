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

namespace FitnessManagement.form
{
    public partial class AddCustomer : DevExpress.XtraEditors.XtraForm
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void pictureImage_EditValueChanged(object sender, EventArgs e)
        {
            Image i = pictureImage.Image;
            pictureImage.Image = i;
            i.Save(Application.StartupPath + "hinhanh.png");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (rbtNu.Checked)
            {
                MessageBox.Show("Bạn chọn nữ");
            }
            if (rbtNam.Checked)
            {
                MessageBox.Show("Bạn chọn nam");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}