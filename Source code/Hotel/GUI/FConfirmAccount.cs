using BUS;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FConfirmAccount : Form
    {
        private readonly Account_BUS busAccount = new Account_BUS();
        private readonly Encode_BUS busEncode = new Encode_BUS();
        private readonly string username, password, idStaff, otp;
        private int seconds = 0;

        public FConfirmAccount(string username, string password, string idStaff, string otp)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            this.idStaff = idStaff;
            this.otp = otp;
        }

        #region Load, Get data & Method
        private void FConfirmAccount_Load(object sender, EventArgs e)
        {
            ShadowForm.SetShadowForm(this);
        }
        #endregion

        #region Check input data
        private bool CheckNull()
        {
            return txtOtp.Text != "";
        }

        private bool CheckOtp()
        {
            string confirmOtp = txtOtp.Text.Trim();
            return otp == confirmOtp;
        }
        #endregion

        #region Click & Events
        private void CountDown_Tick(object sender, EventArgs e)
        {
            seconds--;
            if (seconds == 0)
            {
                FLogin fLogin = new FLogin();
                fLogin.Show();
                Hide();
            }
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if (CheckNull())
            {
                if (CheckOtp())
                {
                    Account_DTO account = new Account_DTO(busEncode.Encrypt(username), busEncode.Encrypt(password), idStaff);
                    busAccount.AddAccount(account);
                    txtNotification.Text = "Đăng ký tài khoản thành công";
                    seconds = 7;
                    CountDown.Start();
                }
                else
                {
                    txtNotification.Text = "Mã xác nhận không chính xác";
                }
            }
            else
            {
                txtNotification.Text = "Bạn phải nhập mã xác nhận";
            }
        }
        #endregion
    }
}
