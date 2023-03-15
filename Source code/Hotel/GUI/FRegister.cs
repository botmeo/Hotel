using BUS;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FRegister : Form
    {
        private readonly Staff_BUS busStaff = new Staff_BUS();
        private readonly Account_BUS busAccount = new Account_BUS();
        private readonly CheckInput_BUS busCheckInput = new CheckInput_BUS();
        private readonly Otp_BUS busOtp = new Otp_BUS();
        private readonly SendEmail_BUS busSendEmail = new SendEmail_BUS();
        private readonly Encode_BUS busEncode = new Encode_BUS();
        private string otpCode;
        private int seconds = 0;

        public FRegister()
        {
            InitializeComponent();
        }

        #region Load, Get data & Method
        private void FRegister_Load(object sender, EventArgs e)
        {
            ShadowForm.SetShadowForm(this);
        }

        private bool CheckIdStaff()
        {
            return busStaff.CheckIdStaff(txtIdStaff.Text);
        }

        private bool CheckAccountExist()
        {
            string id = txtIdStaff.Text.Trim();
            return busAccount.CheckAccountExist(id);
        }

        private bool CheckUsername()
        {
            string username = txtUsername.Text.Trim();
            return busAccount.CheckUser(busEncode.Encrypt(username));
        }

        private void GetEmail()
        {
            string id = txtIdStaff.Text.Trim();
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add(new Binding("Text", busStaff.GetInfo(id), "Email"));
        }
        #endregion

        #region Notification
        private void MessageBoxWarning()
        {
            MessageBox.Show("Xin hãy nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        #endregion

        #region Check input data
        private bool CheckNull()
        {
            return txtUsername.Text != "" && txtPassword.Text != "" && txtIdStaff.Text != "";
        }

        private void Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            busCheckInput.UsernameValidating(e);
            busCheckInput.VietnameseValidating(e);
        }

        private void Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            busCheckInput.VietnameseValidating(e);
        }

        #endregion

        #region Click & Events
        private void CountDown_Tick(object sender, EventArgs e)
        {
            seconds--;
            if (seconds == 0)
            {
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();
                string idStaff = txtIdStaff.Text.Trim();
                string otp = otpCode;
                FConfirmAccount fConfirmAccount = new FConfirmAccount(username, password, idStaff, otp);
                fConfirmAccount.Show();
                Hide();
            }
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if (CheckNull())
            {
                if (CheckIdStaff())
                {
                    if (CheckAccountExist())
                    {
                        txtNotification.Text = "Mã nhân viên đã được sử dụng";
                    }
                    else
                    {
                        if (CheckUsername())
                        {
                            txtNotification.Text = "Tên đăng nhập đã được sử dụng";
                        }
                        else
                        {
                            GetEmail();
                            otpCode = busOtp.OtpCode();
                            if (txtEmail.Text != null)
                            {
                                string toEmail = txtEmail.Text;
                                busSendEmail.ConfirmAccount(otpCode, toEmail);
                                txtNotification.Text = "Mã xác nhận đã được gửi, kiểm tra email của bạn";
                                seconds = 7;
                                CountDown.Start();
                            }
                        }
                    }
                }
                else
                {
                    txtNotification.Text = "Mã nhân viên không được đăng ký";
                    txtIdStaff.Text = null;
                }
            }
            else
            {
                MessageBoxWarning();
            }
        }

        private void Return_Click(object sender, EventArgs e)
        {
            FLogin fLogin = new FLogin();
            fLogin.Show();
            Hide();
        }
        #endregion
    }
}
