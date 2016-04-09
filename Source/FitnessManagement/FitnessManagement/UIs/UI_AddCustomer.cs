using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using System.Drawing.Imaging;

namespace FitnessManagement.UIs
{
    public partial class UI_AddCustomer : DevExpress.XtraEditors.XtraUserControl
    {
        public UI_AddCustomer()
        {
            InitializeComponent();
        }

        private void pictureImage_EditValueChanged(object sender, EventArgs e)
        {
            Image i = pictureImage.Image;
            pictureImage.Image = i;
            //i.Save(Application.StartupPath + "hinhanh.png");
            var stream = new MemoryStream();
            i.Save(stream, ImageFormat.Jpeg);
            imageData = stream.ToArray();
        }
        private byte[] imageData;
        public byte[] ImageData
        {
            get { return imageData; }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MemoryStream stream = new MemoryStream(ImageData);
            Image i = Image.FromStream(stream);
            i.Save(Application.StartupPath + "hinhanh.png");
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.ParentForm.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }
    }
}
