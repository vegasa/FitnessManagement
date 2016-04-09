namespace FitnessManagement.UIs
{
    partial class UI_AddCustomer
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.pictureImage = new DevExpress.XtraEditors.PictureEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.rbtNam = new System.Windows.Forms.RadioButton();
            this.rbtNu = new System.Windows.Forms.RadioButton();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.txrDOB = new DevExpress.XtraEditors.DateEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtHo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txrDOB.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txrDOB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(637, 300);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 35);
            this.btnHuy.TabIndex = 52;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(537, 300);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 35);
            this.btnSubmit.TabIndex = 51;
            this.btnSubmit.Text = "Lưu ";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pictureImage
            // 
            this.pictureImage.Location = new System.Drawing.Point(414, 62);
            this.pictureImage.Name = "pictureImage";
            this.pictureImage.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureImage.Size = new System.Drawing.Size(317, 215);
            this.pictureImage.TabIndex = 50;
            this.pictureImage.EditValueChanged += new System.EventHandler(this.pictureImage_EditValueChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(113, 251);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtEmail.Properties.Appearance.Options.UseFont = true;
            this.txtEmail.Size = new System.Drawing.Size(232, 26);
            this.txtEmail.TabIndex = 47;
            // 
            // rbtNam
            // 
            this.rbtNam.AutoSize = true;
            this.rbtNam.Font = new System.Drawing.Font("Tahoma", 12F);
            this.rbtNam.Location = new System.Drawing.Point(167, 126);
            this.rbtNam.Name = "rbtNam";
            this.rbtNam.Size = new System.Drawing.Size(60, 23);
            this.rbtNam.TabIndex = 40;
            this.rbtNam.Text = "Nam";
            this.rbtNam.UseVisualStyleBackColor = true;
            // 
            // rbtNu
            // 
            this.rbtNu.AutoSize = true;
            this.rbtNu.Checked = true;
            this.rbtNu.Font = new System.Drawing.Font("Tahoma", 12F);
            this.rbtNu.Location = new System.Drawing.Point(113, 126);
            this.rbtNu.Name = "rbtNu";
            this.rbtNu.Size = new System.Drawing.Size(48, 23);
            this.rbtNu.TabIndex = 39;
            this.rbtNu.TabStop = true;
            this.rbtNu.Text = "Nữ";
            this.rbtNu.UseVisualStyleBackColor = true;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(113, 219);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPhone.Properties.Appearance.Options.UseFont = true;
            this.txtPhone.Properties.Mask.EditMask = "(\\d?\\d?\\d?) \\d\\d\\d-\\d\\d\\d\\d\\d?";
            this.txtPhone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txtPhone.Size = new System.Drawing.Size(232, 26);
            this.txtPhone.TabIndex = 45;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(113, 187);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtAddress.Properties.Appearance.Options.UseFont = true;
            this.txtAddress.Size = new System.Drawing.Size(232, 26);
            this.txtAddress.TabIndex = 43;
            // 
            // txrDOB
            // 
            this.txrDOB.EditValue = new System.DateTime(2016, 4, 8, 21, 57, 35, 0);
            this.txrDOB.Location = new System.Drawing.Point(113, 155);
            this.txrDOB.Name = "txrDOB";
            this.txrDOB.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txrDOB.Properties.Appearance.Options.UseFont = true;
            this.txrDOB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txrDOB.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txrDOB.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            this.txrDOB.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.txrDOB.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txrDOB.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.txrDOB.Size = new System.Drawing.Size(232, 26);
            this.txrDOB.TabIndex = 42;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl7.Location = new System.Drawing.Point(18, 254);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(45, 19);
            this.labelControl7.TabIndex = 49;
            this.labelControl7.Text = "Email:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl6.Location = new System.Drawing.Point(18, 222);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(78, 19);
            this.labelControl6.TabIndex = 48;
            this.labelControl6.Text = "Điện thoại:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl5.Location = new System.Drawing.Point(18, 190);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(54, 19);
            this.labelControl5.TabIndex = 46;
            this.labelControl5.Text = "Địa chỉ:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl4.Location = new System.Drawing.Point(18, 158);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(76, 19);
            this.labelControl4.TabIndex = 44;
            this.labelControl4.Text = "Ngày sinh:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl3.Location = new System.Drawing.Point(18, 128);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 19);
            this.labelControl3.TabIndex = 41;
            this.labelControl3.Text = "Giới tính:";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(113, 94);
            this.txtTen.Name = "txtTen";
            this.txtTen.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtTen.Properties.Appearance.Options.UseFont = true;
            this.txtTen.Size = new System.Drawing.Size(232, 26);
            this.txtTen.TabIndex = 38;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Location = new System.Drawing.Point(18, 97);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 19);
            this.labelControl2.TabIndex = 37;
            this.labelControl2.Text = "Tên:";
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(113, 62);
            this.txtHo.Name = "txtHo";
            this.txtHo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtHo.Properties.Appearance.Options.UseFont = true;
            this.txtHo.Size = new System.Drawing.Size(232, 26);
            this.txtHo.TabIndex = 36;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Location = new System.Drawing.Point(18, 65);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(26, 19);
            this.labelControl1.TabIndex = 35;
            this.labelControl1.Text = "Họ:";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lblTitle.Location = new System.Drawing.Point(256, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(258, 33);
            this.lblTitle.TabIndex = 34;
            this.lblTitle.Text = "Thông tin khách hàng";
            // 
            // UI_AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.pictureImage);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.rbtNam);
            this.Controls.Add(this.rbtNu);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txrDOB);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lblTitle);
            this.Name = "UI_AddCustomer";
            this.Size = new System.Drawing.Size(750, 356);
            ((System.ComponentModel.ISupportInitialize)(this.pictureImage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txrDOB.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txrDOB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnSubmit;
        private DevExpress.XtraEditors.PictureEdit pictureImage;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private System.Windows.Forms.RadioButton rbtNam;
        private System.Windows.Forms.RadioButton rbtNu;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.DateEdit txrDOB;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtHo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblTitle;

    }
}
