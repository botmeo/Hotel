using BUS;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FLogin : Form
    {
        private readonly Access_BUS busAccess = new Access_BUS();

        public FLogin()
        {
            InitializeComponent();
        }

        #region Load, Get data & Method
        private void FLogin_Load(object sender, EventArgs e)
        {
            ShadowForm.SetShadowForm(this);
        }

        private bool CheckLogin()
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            return busAccess.Authentication(username, password);
        }
        #endregion

        #region Click & Events
        private void Login_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                if (CheckLogin())
                {
                    FHotelManagement fHotel = new FHotelManagement
                    {
                        username = txtUsername.Text.Trim(),
                        password = txtPassword.Text.Trim()
                    };
                    fHotel.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu người dùng không đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsername.Text = null;
                    txtPassword.Text = null;
                }
            }
            else if (txtUsername.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Bạn phải nhập mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Register_Click(object sender, EventArgs e)
        {
            FRegister fRegister = new FRegister();
            fRegister.Show();
            Hide();
        }

        private void ForgetPassword_Click(object sender, EventArgs e)
        {
            FRestore fRestore = new FRestore();
            fRestore.Show();
            Hide();
        }
        #endregion
    }
}
