
namespace GUI
{
    partial class FConfirmAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FConfirmAccount));
            this.txtNotification = new Guna.UI2.WinForms.Guna2Chip();
            this.lblOtp = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtOtp = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.lblLogin = new Guna.UI2.WinForms.Guna2Chip();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.picHotel = new Guna.UI2.WinForms.Guna2PictureBox();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.CountDown = new System.Windows.Forms.Timer(this.components);
            this.ShadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picHotel)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNotification
            // 
            this.txtNotification.FillColor = System.Drawing.Color.White;
            this.txtNotification.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotification.ForeColor = System.Drawing.Color.Black;
            this.txtNotification.Location = new System.Drawing.Point(418, 354);
            this.txtNotification.Name = "txtNotification";
            this.txtNotification.ShadowDecoration.Parent = this.txtNotification;
            this.txtNotification.Size = new System.Drawing.Size(267, 23);
            this.txtNotification.TabIndex = 58;
            this.txtNotification.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // lblOtp
            // 
            this.lblOtp.BackColor = System.Drawing.Color.Transparent;
            this.lblOtp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtp.Location = new System.Drawing.Point(416, 189);
            this.lblOtp.Name = "lblOtp";
            this.lblOtp.Size = new System.Drawing.Size(77, 19);
            this.lblOtp.TabIndex = 57;
            this.lblOtp.Text = "Mã xác nhận";
            // 
            // txtOtp
            // 
            this.txtOtp.BorderColor = System.Drawing.Color.Silver;
            this.txtOtp.BorderRadius = 3;
            this.txtOtp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOtp.DefaultText = "";
            this.txtOtp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOtp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOtp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOtp.DisabledState.Parent = this.txtOtp;
            this.txtOtp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOtp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtOtp.FocusedState.Parent = this.txtOtp;
            this.txtOtp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtp.ForeColor = System.Drawing.Color.Black;
            this.txtOtp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtOtp.HoverState.Parent = this.txtOtp;
            this.txtOtp.Location = new System.Drawing.Point(416, 215);
            this.txtOtp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOtp.Name = "txtOtp";
            this.txtOtp.PasswordChar = '\0';
            this.txtOtp.PlaceholderText = "";
            this.txtOtp.SelectedText = "";
            this.txtOtp.ShadowDecoration.Parent = this.txtOtp;
            this.txtOtp.Size = new System.Drawing.Size(267, 36);
            this.txtOtp.TabIndex = 56;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BorderRadius = 3;
            this.btnConfirm.CheckedState.Parent = this.btnConfirm;
            this.btnConfirm.CustomImages.Parent = this.btnConfirm;
            this.btnConfirm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnConfirm.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnConfirm.HoverState.Parent = this.btnConfirm;
            this.btnConfirm.Location = new System.Drawing.Point(418, 303);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.ShadowDecoration.Parent = this.btnConfirm;
            this.btnConfirm.Size = new System.Drawing.Size(267, 45);
            this.btnConfirm.TabIndex = 55;
            this.btnConfirm.Text = "Xác nhận đăng ký";
            this.btnConfirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.FillColor = System.Drawing.Color.White;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.lblLogin.Location = new System.Drawing.Point(416, 70);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.ShadowDecoration.Parent = this.lblLogin;
            this.lblLogin.Size = new System.Drawing.Size(267, 47);
            this.lblLogin.TabIndex = 54;
            this.lblLogin.Text = "XÁC NHẬN";
            this.lblLogin.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMinimize.FillColor = System.Drawing.Color.White;
            this.btnMinimize.HoverState.Parent = this.btnMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.Black;
            this.btnMinimize.Location = new System.Drawing.Point(641, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.Size = new System.Drawing.Size(45, 30);
            this.btnMinimize.TabIndex = 52;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FillColor = System.Drawing.Color.White;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.btnClose.HoverState.IconColor = System.Drawing.Color.White;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(692, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedColor = System.Drawing.Color.Empty;
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(45, 30);
            this.btnClose.TabIndex = 53;
            // 
            // picHotel
            // 
            this.picHotel.Image = ((System.Drawing.Image)(resources.GetObject("picHotel.Image")));
            this.picHotel.Location = new System.Drawing.Point(0, -11);
            this.picHotel.Name = "picHotel";
            this.picHotel.ShadowDecoration.Parent = this.picHotel;
            this.picHotel.Size = new System.Drawing.Size(350, 529);
            this.picHotel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHotel.TabIndex = 51;
            this.picHotel.TabStop = false;
            // 
            // DragControl
            // 
            this.DragControl.ContainerControl = this;
            this.DragControl.TargetControl = this;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderColor = System.Drawing.Color.Silver;
            this.txtEmail.BorderRadius = 3;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.Parent = this.txtEmail;
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.txtEmail.FocusedState.Parent = this.txtEmail;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.txtEmail.HoverState.Parent = this.txtEmail;
            this.txtEmail.Location = new System.Drawing.Point(70, 182);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.ShadowDecoration.Parent = this.txtEmail;
            this.txtEmail.Size = new System.Drawing.Size(267, 36);
            this.txtEmail.TabIndex = 59;
            this.txtEmail.Visible = false;
            // 
            // CountDown
            // 
            this.CountDown.Tick += new System.EventHandler(this.CountDown_Tick);
            // 
            // FConfirmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(740, 500);
            this.Controls.Add(this.txtNotification);
            this.Controls.Add(this.lblOtp);
            this.Controls.Add(this.txtOtp);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.picHotel);
            this.Controls.Add(this.txtEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FConfirmAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FConfirmAccount";
            this.Load += new System.EventHandler(this.FConfirmAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHotel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Chip txtNotification;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblOtp;
        private Guna.UI2.WinForms.Guna2TextBox txtOtp;
        private Guna.UI2.WinForms.Guna2Button btnConfirm;
        private Guna.UI2.WinForms.Guna2Chip lblLogin;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimize;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2PictureBox picHotel;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.Timer CountDown;
        private Guna.UI2.WinForms.Guna2ShadowForm ShadowForm;
    }
}