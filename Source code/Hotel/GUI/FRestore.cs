using BUS;
using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GUI
{
    public partial class FRestore : Form
    {
        private readonly Access_BUS busAccess = new Access_BUS();
        private readonly Otp_BUS busOtp = new Otp_BUS();
        private readonly SendEmail_BUS busSendEmail = new SendEmail_BUS();
        private string OTPCode;

        public FRestore()
        {
            InitializeComponent();
        }

        #region Load, Get data & Method
        private void FRestore_Load(object sender, EventArgs e)
        {
            ShadowForm.SetShadowForm(this);
        }

        private bool CheckEmail()
        {
            return busAccess.CheckEmailStaff(txtEmail.Text.Trim());
        }

        #endregion

        #region Notification
        private void MessageBoxWarning()
        {
            MessageBox.Show("Xin hãy nhập email của bạn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        #endregion

        #region Check input data
        private void Email_Validating(object sender, CancelEventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-z]{2,9})$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(txtEmail.Text))
            {
                errorProvider.Clear();
            }
            else
            {
                errorProvider.SetError(txtEmail, "Định dạng email không đúng.");
                txtEmail.Text = null;
            }
        }
        #endregion

        #region Click & Events
        private void Return_Click(object sender, EventArgs e)
        {
            FLogin fLogin = new FLogin();
            fLogin.Show();
            Hide();
        }

        private void SendOTP_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "")
            {
                if (CheckEmail())
                {
                    OTPCode = busOtp.OtpCode();
                    string toEmail = txtEmail.Text;
                    busSendEmail.RestoreAccount(OTPCode, toEmail);
                    txtNotification.Text = "OTP đã được gửi. Kiểm tra email của bạn";
                }
                else
                {
                    MessageBox.Show("Email không được đăng ký.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Text = null;
                }
            }
            else
            {
                MessageBoxWarning();
            }
        }

        private void OTP_TextChanged(object sender, EventArgs e)
        {
            if (OTPCode == txtOTP.Text.ToString())
            {
                txtNotification.Text = "";
                FChangePassword fChangePassword = new FChangePassword();
                fChangePassword.Show();
                Hide();
            }
            else if (txtOTP.Text == "")
            {
                txtNotification.Text = "";
            }
            else
            {
                txtNotification.Text = "Mã xác nhận không chính xác";
            }
        }
        #endregion
    }
}
