
namespace GUI
{
    partial class FAccount
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAccount));
            this.txtUsername = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btnReturn = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.txtStaffType = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblId = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblEmail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtmDateOfBirth = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtPhone = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cboSex = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblStaffType = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDateOfBirth = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDateStartWork = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtAddress = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.dtmDateStartWork = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblSex = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblIdCard = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtIDcard = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtIdStaff = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblAddress = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPhone = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.grpAccount = new System.Windows.Forms.GroupBox();
            this.btnShowConfirmPassword = new Guna.UI2.WinForms.Guna2Button();
            this.btnShowNewPassword = new Guna.UI2.WinForms.Guna2Button();
            this.lblConfirmNewPass = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.lblNewPassword = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblUsername = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPassword = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnShowPassword = new Guna.UI2.WinForms.Guna2Button();
            this.btnHidePassword = new Guna.UI2.WinForms.Guna2Button();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnHideNewPassword = new Guna.UI2.WinForms.Guna2Button();
            this.txtNewPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnHideConfirmPassword = new Guna.UI2.WinForms.Guna2Button();
            this.txtConfirmPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.ShadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.grpInfo.SuspendLayout();
            this.grpAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtUsername.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtUsername.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtUsername.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtUsername.BorderThickness = 1;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Enabled = false;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.isPassword = false;
            this.txtUsername.Location = new System.Drawing.Point(40, 72);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(220, 36);
            this.txtUsername.TabIndex = 48;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // DragControl
            // 
            this.DragControl.ContainerControl = this;
            this.DragControl.TargetControl = this;
            // 
            // btnReturn
            // 
            this.btnReturn.CheckedState.Parent = this.btnReturn;
            this.btnReturn.CustomImages.Parent = this.btnReturn;
            this.btnReturn.FillColor = System.Drawing.Color.White;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.HoverState.Parent = this.btnReturn;
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.ImageSize = new System.Drawing.Size(16, 16);
            this.btnReturn.Location = new System.Drawing.Point(3, 3);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.PressedColor = System.Drawing.Color.Transparent;
            this.btnReturn.ShadowDecoration.Parent = this.btnReturn;
            this.btnReturn.Size = new System.Drawing.Size(45, 30);
            this.btnReturn.TabIndex = 64;
            this.btnReturn.Click += new System.EventHandler(this.Return_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BorderColor = System.Drawing.Color.White;
            this.btnClose.FillColor = System.Drawing.Color.White;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.btnClose.HoverState.IconColor = System.Drawing.Color.White;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(842, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(45, 30);
            this.btnClose.TabIndex = 65;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMinimize.FillColor = System.Drawing.Color.White;
            this.btnMinimize.HoverState.Parent = this.btnMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.Black;
            this.btnMinimize.Location = new System.Drawing.Point(791, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.PressedColor = System.Drawing.Color.Transparent;
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.Size = new System.Drawing.Size(45, 30);
            this.btnMinimize.TabIndex = 66;
            // 
            // grpInfo
            // 
            this.grpInfo.BackColor = System.Drawing.Color.White;
            this.grpInfo.Controls.Add(this.txtStaffType);
            this.grpInfo.Controls.Add(this.txtEmail);
            this.grpInfo.Controls.Add(this.lblId);
            this.grpInfo.Controls.Add(this.lblEmail);
            this.grpInfo.Controls.Add(this.dtmDateOfBirth);
            this.grpInfo.Controls.Add(this.txtPhone);
            this.grpInfo.Controls.Add(this.lblName);
            this.grpInfo.Controls.Add(this.cboSex);
            this.grpInfo.Controls.Add(this.lblStaffType);
            this.grpInfo.Controls.Add(this.lblDateOfBirth);
            this.grpInfo.Controls.Add(this.lblDateStartWork);
            this.grpInfo.Controls.Add(this.txtAddress);
            this.grpInfo.Controls.Add(this.dtmDateStartWork);
            this.grpInfo.Controls.Add(this.lblSex);
            this.grpInfo.Controls.Add(this.lblIdCard);
            this.grpInfo.Controls.Add(this.txtIDcard);
            this.grpInfo.Controls.Add(this.txtIdStaff);
            this.grpInfo.Controls.Add(this.lblAddress);
            this.grpInfo.Controls.Add(this.lblPhone);
            this.grpInfo.Controls.Add(this.txtName);
            this.grpInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfo.Location = new System.Drawing.Point(12, 39);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(560, 438);
            this.grpInfo.TabIndex = 67;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Thông tin nhân viên";
            // 
            // txtStaffType
            // 
            this.txtStaffType.BackColor = System.Drawing.Color.White;
            this.txtStaffType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtStaffType.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtStaffType.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtStaffType.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtStaffType.BorderThickness = 1;
            this.txtStaffType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStaffType.Enabled = false;
            this.txtStaffType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffType.ForeColor = System.Drawing.Color.Black;
            this.txtStaffType.isPassword = false;
            this.txtStaffType.Location = new System.Drawing.Point(300, 72);
            this.txtStaffType.Margin = new System.Windows.Forms.Padding(5);
            this.txtStaffType.Name = "txtStaffType";
            this.txtStaffType.Size = new System.Drawing.Size(220, 36);
            this.txtStaffType.TabIndex = 52;
            this.txtStaffType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtEmail.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtEmail.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtEmail.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtEmail.BorderThickness = 1;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.isPassword = false;
            this.txtEmail.Location = new System.Drawing.Point(300, 285);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(220, 36);
            this.txtEmail.TabIndex = 57;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblId
            // 
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.Black;
            this.lblId.IsContextMenuEnabled = false;
            this.lblId.IsSelectionEnabled = false;
            this.lblId.Location = new System.Drawing.Point(40, 45);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(81, 19);
            this.lblId.TabIndex = 48;
            this.lblId.Text = "Mã nhân viên";
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.IsContextMenuEnabled = false;
            this.lblEmail.IsSelectionEnabled = false;
            this.lblEmail.Location = new System.Drawing.Point(300, 258);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(34, 19);
            this.lblEmail.TabIndex = 56;
            this.lblEmail.Text = "Email";
            // 
            // dtmDateOfBirth
            // 
            this.dtmDateOfBirth.Animated = true;
            this.dtmDateOfBirth.BackColor = System.Drawing.Color.White;
            this.dtmDateOfBirth.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.dtmDateOfBirth.CheckedState.Parent = this.dtmDateOfBirth;
            this.dtmDateOfBirth.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.dtmDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtmDateOfBirth.ForeColor = System.Drawing.Color.White;
            this.dtmDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmDateOfBirth.HoverState.Parent = this.dtmDateOfBirth;
            this.dtmDateOfBirth.Location = new System.Drawing.Point(40, 214);
            this.dtmDateOfBirth.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtmDateOfBirth.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.dtmDateOfBirth.Name = "dtmDateOfBirth";
            this.dtmDateOfBirth.ShadowDecoration.Parent = this.dtmDateOfBirth;
            this.dtmDateOfBirth.Size = new System.Drawing.Size(220, 36);
            this.dtmDateOfBirth.TabIndex = 19;
            this.dtmDateOfBirth.Value = new System.DateTime(2021, 3, 7, 0, 0, 0, 0);
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.White;
            this.txtPhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtPhone.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtPhone.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtPhone.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtPhone.BorderThickness = 1;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.Color.Black;
            this.txtPhone.isPassword = false;
            this.txtPhone.Location = new System.Drawing.Point(300, 214);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(220, 36);
            this.txtPhone.TabIndex = 55;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.IsContextMenuEnabled = false;
            this.lblName.IsSelectionEnabled = false;
            this.lblName.Location = new System.Drawing.Point(40, 116);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(83, 19);
            this.lblName.TabIndex = 29;
            this.lblName.Text = "Tên nhân viên ";
            // 
            // cboSex
            // 
            this.cboSex.BackColor = System.Drawing.Color.White;
            this.cboSex.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.cboSex.BorderThickness = 0;
            this.cboSex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSex.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.cboSex.FocusedColor = System.Drawing.Color.Empty;
            this.cboSex.FocusedState.Parent = this.cboSex;
            this.cboSex.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboSex.ForeColor = System.Drawing.Color.White;
            this.cboSex.HoverState.Parent = this.cboSex;
            this.cboSex.ItemHeight = 30;
            this.cboSex.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cboSex.ItemsAppearance.Parent = this.cboSex;
            this.cboSex.Location = new System.Drawing.Point(40, 285);
            this.cboSex.Name = "cboSex";
            this.cboSex.ShadowDecoration.Parent = this.cboSex;
            this.cboSex.Size = new System.Drawing.Size(220, 36);
            this.cboSex.StartIndex = 0;
            this.cboSex.TabIndex = 30;
            // 
            // lblStaffType
            // 
            this.lblStaffType.BackColor = System.Drawing.Color.Transparent;
            this.lblStaffType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffType.ForeColor = System.Drawing.Color.Black;
            this.lblStaffType.IsContextMenuEnabled = false;
            this.lblStaffType.IsSelectionEnabled = false;
            this.lblStaffType.Location = new System.Drawing.Point(300, 45);
            this.lblStaffType.Name = "lblStaffType";
            this.lblStaffType.Size = new System.Drawing.Size(49, 19);
            this.lblStaffType.TabIndex = 54;
            this.lblStaffType.Text = "Chức vụ";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.BackColor = System.Drawing.Color.Transparent;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.ForeColor = System.Drawing.Color.Black;
            this.lblDateOfBirth.IsContextMenuEnabled = false;
            this.lblDateOfBirth.IsSelectionEnabled = false;
            this.lblDateOfBirth.Location = new System.Drawing.Point(40, 187);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(61, 19);
            this.lblDateOfBirth.TabIndex = 30;
            this.lblDateOfBirth.Text = "Ngày sinh ";
            // 
            // lblDateStartWork
            // 
            this.lblDateStartWork.BackColor = System.Drawing.Color.Transparent;
            this.lblDateStartWork.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateStartWork.ForeColor = System.Drawing.Color.Black;
            this.lblDateStartWork.IsContextMenuEnabled = false;
            this.lblDateStartWork.IsSelectionEnabled = false;
            this.lblDateStartWork.Location = new System.Drawing.Point(40, 329);
            this.lblDateStartWork.Name = "lblDateStartWork";
            this.lblDateStartWork.Size = new System.Drawing.Size(84, 19);
            this.lblDateStartWork.TabIndex = 53;
            this.lblDateStartWork.Text = "Ngày vào làm";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtAddress.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtAddress.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtAddress.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtAddress.BorderThickness = 1;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.isPassword = false;
            this.txtAddress.Location = new System.Drawing.Point(300, 143);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(220, 36);
            this.txtAddress.TabIndex = 26;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dtmDateStartWork
            // 
            this.dtmDateStartWork.Animated = true;
            this.dtmDateStartWork.BackColor = System.Drawing.Color.White;
            this.dtmDateStartWork.CheckedState.Parent = this.dtmDateStartWork;
            this.dtmDateStartWork.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.dtmDateStartWork.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtmDateStartWork.ForeColor = System.Drawing.Color.White;
            this.dtmDateStartWork.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmDateStartWork.HoverState.Parent = this.dtmDateStartWork;
            this.dtmDateStartWork.Location = new System.Drawing.Point(40, 356);
            this.dtmDateStartWork.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtmDateStartWork.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.dtmDateStartWork.Name = "dtmDateStartWork";
            this.dtmDateStartWork.ShadowDecoration.Parent = this.dtmDateStartWork;
            this.dtmDateStartWork.Size = new System.Drawing.Size(220, 36);
            this.dtmDateStartWork.TabIndex = 52;
            this.dtmDateStartWork.Value = new System.DateTime(2021, 3, 7, 0, 0, 0, 0);
            // 
            // lblSex
            // 
            this.lblSex.BackColor = System.Drawing.Color.Transparent;
            this.lblSex.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.ForeColor = System.Drawing.Color.Black;
            this.lblSex.IsContextMenuEnabled = false;
            this.lblSex.IsSelectionEnabled = false;
            this.lblSex.Location = new System.Drawing.Point(40, 258);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(51, 19);
            this.lblSex.TabIndex = 31;
            this.lblSex.Text = "Giới tính ";
            // 
            // lblIdCard
            // 
            this.lblIdCard.BackColor = System.Drawing.Color.Transparent;
            this.lblIdCard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCard.ForeColor = System.Drawing.Color.Black;
            this.lblIdCard.IsContextMenuEnabled = false;
            this.lblIdCard.IsSelectionEnabled = false;
            this.lblIdCard.Location = new System.Drawing.Point(300, 329);
            this.lblIdCard.Name = "lblIdCard";
            this.lblIdCard.Size = new System.Drawing.Size(131, 19);
            this.lblIdCard.TabIndex = 32;
            this.lblIdCard.Text = "Chứng minh nhân dân ";
            // 
            // txtIDcard
            // 
            this.txtIDcard.BackColor = System.Drawing.Color.White;
            this.txtIDcard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtIDcard.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtIDcard.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtIDcard.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtIDcard.BorderThickness = 1;
            this.txtIDcard.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDcard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDcard.ForeColor = System.Drawing.Color.Black;
            this.txtIDcard.isPassword = false;
            this.txtIDcard.Location = new System.Drawing.Point(300, 356);
            this.txtIDcard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIDcard.Name = "txtIDcard";
            this.txtIDcard.Size = new System.Drawing.Size(220, 36);
            this.txtIDcard.TabIndex = 25;
            this.txtIDcard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtIdStaff
            // 
            this.txtIdStaff.BackColor = System.Drawing.Color.White;
            this.txtIdStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtIdStaff.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtIdStaff.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtIdStaff.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtIdStaff.BorderThickness = 1;
            this.txtIdStaff.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdStaff.Enabled = false;
            this.txtIdStaff.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdStaff.ForeColor = System.Drawing.Color.Black;
            this.txtIdStaff.isPassword = false;
            this.txtIdStaff.Location = new System.Drawing.Point(40, 72);
            this.txtIdStaff.Margin = new System.Windows.Forms.Padding(5);
            this.txtIdStaff.Name = "txtIdStaff";
            this.txtIdStaff.Size = new System.Drawing.Size(220, 36);
            this.txtIdStaff.TabIndex = 47;
            this.txtIdStaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblAddress
            // 
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.IsContextMenuEnabled = false;
            this.lblAddress.IsSelectionEnabled = false;
            this.lblAddress.Location = new System.Drawing.Point(300, 116);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(42, 19);
            this.lblAddress.TabIndex = 33;
            this.lblAddress.Text = "Địa chỉ ";
            // 
            // lblPhone
            // 
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.Black;
            this.lblPhone.IsContextMenuEnabled = false;
            this.lblPhone.IsSelectionEnabled = false;
            this.lblPhone.Location = new System.Drawing.Point(300, 187);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(80, 19);
            this.lblPhone.TabIndex = 34;
            this.lblPhone.Text = "Số điện thoại ";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtName.BorderThickness = 1;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.isPassword = false;
            this.txtName.Location = new System.Drawing.Point(40, 143);
            this.txtName.Margin = new System.Windows.Forms.Padding(5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(220, 36);
            this.txtName.TabIndex = 17;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // grpAccount
            // 
            this.grpAccount.BackColor = System.Drawing.Color.White;
            this.grpAccount.Controls.Add(this.btnShowConfirmPassword);
            this.grpAccount.Controls.Add(this.btnShowNewPassword);
            this.grpAccount.Controls.Add(this.lblConfirmNewPass);
            this.grpAccount.Controls.Add(this.btnSave);
            this.grpAccount.Controls.Add(this.lblNewPassword);
            this.grpAccount.Controls.Add(this.lblUsername);
            this.grpAccount.Controls.Add(this.txtUsername);
            this.grpAccount.Controls.Add(this.lblPassword);
            this.grpAccount.Controls.Add(this.btnShowPassword);
            this.grpAccount.Controls.Add(this.btnHidePassword);
            this.grpAccount.Controls.Add(this.txtPassword);
            this.grpAccount.Controls.Add(this.btnHideNewPassword);
            this.grpAccount.Controls.Add(this.txtNewPassword);
            this.grpAccount.Controls.Add(this.btnHideConfirmPassword);
            this.grpAccount.Controls.Add(this.txtConfirmPassword);
            this.grpAccount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAccount.Location = new System.Drawing.Point(578, 39);
            this.grpAccount.Name = "grpAccount";
            this.grpAccount.Size = new System.Drawing.Size(300, 438);
            this.grpAccount.TabIndex = 68;
            this.grpAccount.TabStop = false;
            this.grpAccount.Text = "Thông tin nhân viên";
            // 
            // btnShowConfirmPassword
            // 
            this.btnShowConfirmPassword.BorderColor = System.Drawing.Color.Transparent;
            this.btnShowConfirmPassword.CheckedState.Parent = this.btnShowConfirmPassword;
            this.btnShowConfirmPassword.CustomImages.Parent = this.btnShowConfirmPassword;
            this.btnShowConfirmPassword.FillColor = System.Drawing.Color.White;
            this.btnShowConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShowConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.btnShowConfirmPassword.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnShowConfirmPassword.HoverState.Parent = this.btnShowConfirmPassword;
            this.btnShowConfirmPassword.Image = ((System.Drawing.Image)(resources.GetObject("btnShowConfirmPassword.Image")));
            this.btnShowConfirmPassword.Location = new System.Drawing.Point(231, 290);
            this.btnShowConfirmPassword.Name = "btnShowConfirmPassword";
            this.btnShowConfirmPassword.PressedColor = System.Drawing.Color.Transparent;
            this.btnShowConfirmPassword.ShadowDecoration.Parent = this.btnShowConfirmPassword;
            this.btnShowConfirmPassword.Size = new System.Drawing.Size(27, 27);
            this.btnShowConfirmPassword.TabIndex = 58;
            this.btnShowConfirmPassword.Click += new System.EventHandler(this.ShowConfirmPassword_Click);
            // 
            // btnShowNewPassword
            // 
            this.btnShowNewPassword.BorderColor = System.Drawing.Color.Transparent;
            this.btnShowNewPassword.CheckedState.Parent = this.btnShowNewPassword;
            this.btnShowNewPassword.CustomImages.Parent = this.btnShowNewPassword;
            this.btnShowNewPassword.FillColor = System.Drawing.Color.White;
            this.btnShowNewPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShowNewPassword.ForeColor = System.Drawing.Color.White;
            this.btnShowNewPassword.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnShowNewPassword.HoverState.Parent = this.btnShowNewPassword;
            this.btnShowNewPassword.Image = ((System.Drawing.Image)(resources.GetObject("btnShowNewPassword.Image")));
            this.btnShowNewPassword.Location = new System.Drawing.Point(231, 219);
            this.btnShowNewPassword.Name = "btnShowNewPassword";
            this.btnShowNewPassword.PressedColor = System.Drawing.Color.Transparent;
            this.btnShowNewPassword.ShadowDecoration.Parent = this.btnShowNewPassword;
            this.btnShowNewPassword.Size = new System.Drawing.Size(27, 27);
            this.btnShowNewPassword.TabIndex = 56;
            this.btnShowNewPassword.Click += new System.EventHandler(this.ShowNewPassword_Click);
            // 
            // lblConfirmNewPass
            // 
            this.lblConfirmNewPass.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmNewPass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmNewPass.ForeColor = System.Drawing.Color.Black;
            this.lblConfirmNewPass.IsContextMenuEnabled = false;
            this.lblConfirmNewPass.IsSelectionEnabled = false;
            this.lblConfirmNewPass.Location = new System.Drawing.Point(40, 258);
            this.lblConfirmNewPass.Name = "lblConfirmNewPass";
            this.lblConfirmNewPass.Size = new System.Drawing.Size(139, 19);
            this.lblConfirmNewPass.TabIndex = 52;
            this.lblConfirmNewPass.Text = "Xác nhận mật khẩu mới";
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.BorderRadius = 4;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.IndicateFocus = true;
            this.btnSave.Location = new System.Drawing.Point(40, 356);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(218, 36);
            this.btnSave.TabIndex = 51;
            this.btnSave.Text = "Lưu thay đổi";
            this.btnSave.Click += new System.EventHandler(this.Save_Click);
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblNewPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.ForeColor = System.Drawing.Color.Black;
            this.lblNewPassword.IsContextMenuEnabled = false;
            this.lblNewPassword.IsSelectionEnabled = false;
            this.lblNewPassword.Location = new System.Drawing.Point(40, 187);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(83, 19);
            this.lblNewPassword.TabIndex = 49;
            this.lblNewPassword.Text = "Mật khẩu mới";
            // 
            // lblUsername
            // 
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Black;
            this.lblUsername.IsContextMenuEnabled = false;
            this.lblUsername.IsSelectionEnabled = false;
            this.lblUsername.Location = new System.Drawing.Point(40, 45);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(91, 19);
            this.lblUsername.TabIndex = 48;
            this.lblUsername.Text = "Tên đăng nhập";
            // 
            // lblPassword
            // 
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.IsContextMenuEnabled = false;
            this.lblPassword.IsSelectionEnabled = false;
            this.lblPassword.Location = new System.Drawing.Point(40, 116);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(57, 19);
            this.lblPassword.TabIndex = 29;
            this.lblPassword.Text = "Mật khẩu";
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.BorderColor = System.Drawing.Color.Transparent;
            this.btnShowPassword.CheckedState.Parent = this.btnShowPassword;
            this.btnShowPassword.CustomImages.Parent = this.btnShowPassword;
            this.btnShowPassword.FillColor = System.Drawing.Color.White;
            this.btnShowPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShowPassword.ForeColor = System.Drawing.Color.White;
            this.btnShowPassword.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnShowPassword.HoverState.Parent = this.btnShowPassword;
            this.btnShowPassword.Image = ((System.Drawing.Image)(resources.GetObject("btnShowPassword.Image")));
            this.btnShowPassword.Location = new System.Drawing.Point(231, 148);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.PressedColor = System.Drawing.Color.Transparent;
            this.btnShowPassword.ShadowDecoration.Parent = this.btnShowPassword;
            this.btnShowPassword.Size = new System.Drawing.Size(27, 27);
            this.btnShowPassword.TabIndex = 54;
            this.btnShowPassword.Click += new System.EventHandler(this.ShowPassword_Click);
            // 
            // btnHidePassword
            // 
            this.btnHidePassword.BorderColor = System.Drawing.Color.Transparent;
            this.btnHidePassword.CheckedState.Parent = this.btnHidePassword;
            this.btnHidePassword.CustomImages.Parent = this.btnHidePassword;
            this.btnHidePassword.FillColor = System.Drawing.Color.White;
            this.btnHidePassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHidePassword.ForeColor = System.Drawing.Color.White;
            this.btnHidePassword.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnHidePassword.HoverState.Parent = this.btnHidePassword;
            this.btnHidePassword.Image = ((System.Drawing.Image)(resources.GetObject("btnHidePassword.Image")));
            this.btnHidePassword.Location = new System.Drawing.Point(231, 148);
            this.btnHidePassword.Name = "btnHidePassword";
            this.btnHidePassword.PressedColor = System.Drawing.Color.Transparent;
            this.btnHidePassword.ShadowDecoration.Parent = this.btnHidePassword;
            this.btnHidePassword.Size = new System.Drawing.Size(27, 27);
            this.btnHidePassword.TabIndex = 55;
            this.btnHidePassword.Click += new System.EventHandler(this.HidePassword_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtPassword.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtPassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtPassword.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtPassword.BorderThickness = 1;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Enabled = false;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.isPassword = true;
            this.txtPassword.Location = new System.Drawing.Point(40, 143);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(220, 36);
            this.txtPassword.TabIndex = 17;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnHideNewPassword
            // 
            this.btnHideNewPassword.BorderColor = System.Drawing.Color.Transparent;
            this.btnHideNewPassword.CheckedState.Parent = this.btnHideNewPassword;
            this.btnHideNewPassword.CustomImages.Parent = this.btnHideNewPassword;
            this.btnHideNewPassword.FillColor = System.Drawing.Color.White;
            this.btnHideNewPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHideNewPassword.ForeColor = System.Drawing.Color.White;
            this.btnHideNewPassword.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnHideNewPassword.HoverState.Parent = this.btnHideNewPassword;
            this.btnHideNewPassword.Image = ((System.Drawing.Image)(resources.GetObject("btnHideNewPassword.Image")));
            this.btnHideNewPassword.Location = new System.Drawing.Point(231, 219);
            this.btnHideNewPassword.Name = "btnHideNewPassword";
            this.btnHideNewPassword.PressedColor = System.Drawing.Color.Transparent;
            this.btnHideNewPassword.ShadowDecoration.Parent = this.btnHideNewPassword;
            this.btnHideNewPassword.Size = new System.Drawing.Size(27, 27);
            this.btnHideNewPassword.TabIndex = 57;
            this.btnHideNewPassword.Click += new System.EventHandler(this.HideNewPassword_Click);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.Color.White;
            this.txtNewPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtNewPassword.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtNewPassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtNewPassword.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtNewPassword.BorderThickness = 1;
            this.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.ForeColor = System.Drawing.Color.Black;
            this.txtNewPassword.isPassword = true;
            this.txtNewPassword.Location = new System.Drawing.Point(40, 214);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(220, 36);
            this.txtNewPassword.TabIndex = 50;
            this.txtNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnHideConfirmPassword
            // 
            this.btnHideConfirmPassword.BorderColor = System.Drawing.Color.Transparent;
            this.btnHideConfirmPassword.CheckedState.Parent = this.btnHideConfirmPassword;
            this.btnHideConfirmPassword.CustomImages.Parent = this.btnHideConfirmPassword;
            this.btnHideConfirmPassword.FillColor = System.Drawing.Color.White;
            this.btnHideConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHideConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.btnHideConfirmPassword.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnHideConfirmPassword.HoverState.Parent = this.btnHideConfirmPassword;
            this.btnHideConfirmPassword.Image = ((System.Drawing.Image)(resources.GetObject("btnHideConfirmPassword.Image")));
            this.btnHideConfirmPassword.Location = new System.Drawing.Point(231, 290);
            this.btnHideConfirmPassword.Name = "btnHideConfirmPassword";
            this.btnHideConfirmPassword.PressedColor = System.Drawing.Color.Transparent;
            this.btnHideConfirmPassword.ShadowDecoration.Parent = this.btnHideConfirmPassword;
            this.btnHideConfirmPassword.Size = new System.Drawing.Size(27, 27);
            this.btnHideConfirmPassword.TabIndex = 59;
            this.btnHideConfirmPassword.Click += new System.EventHandler(this.HideConfirmPassword_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.White;
            this.txtConfirmPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtConfirmPassword.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtConfirmPassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtConfirmPassword.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtConfirmPassword.BorderThickness = 1;
            this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.Black;
            this.txtConfirmPassword.isPassword = true;
            this.txtConfirmPassword.Location = new System.Drawing.Point(38, 285);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(222, 36);
            this.txtConfirmPassword.TabIndex = 53;
            this.txtConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // FAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(890, 489);
            this.Controls.Add(this.grpAccount);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnReturn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "            ";
            this.Load += new System.EventHandler(this.FAccount_Load);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.grpAccount.ResumeLayout(false);
            this.grpAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox txtUsername;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private Guna.UI2.WinForms.Guna2Button btnReturn;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimize;
        private System.Windows.Forms.GroupBox grpInfo;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtEmail;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblId;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEmail;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtmDateOfBirth;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPhone;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblName;
        private Guna.UI2.WinForms.Guna2ComboBox cboSex;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblStaffType;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDateOfBirth;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDateStartWork;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtAddress;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtmDateStartWork;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSex;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblIdCard;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtIDcard;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtIdStaff;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAddress;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPhone;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtName;
        private System.Windows.Forms.GroupBox grpAccount;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUsername;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPassword;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNewPassword;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNewPassword;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtStaffType;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtConfirmPassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblConfirmNewPass;
        private Guna.UI2.WinForms.Guna2ShadowForm ShadowForm;
        private Guna.UI2.WinForms.Guna2Button btnShowPassword;
        private Guna.UI2.WinForms.Guna2Button btnHidePassword;
        private Guna.UI2.WinForms.Guna2Button btnShowNewPassword;
        private Guna.UI2.WinForms.Guna2Button btnHideNewPassword;
        private Guna.UI2.WinForms.Guna2Button btnShowConfirmPassword;
        private Guna.UI2.WinForms.Guna2Button btnHideConfirmPassword;
    }
}