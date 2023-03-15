using BUS;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FChangePassword : Form
    {
        private readonly Account_BUS busAccount = new Account_BUS();

        public FChangePassword()
        {
            InitializeComponent();
        }

        #region Load, Get data & Method
        private void FChangePassword_Load(object sender, EventArgs e)
        {
            ShadowForm.SetShadowForm(this);
        }

        private bool CheckAccount()
        {
            string username = txtUsername.Text.Trim();
            return busAccount.CheckUser(username);
        }
        #endregion

        #region Click & Events
        private void ChangePassword_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPassword.Text != "" && txtPasswordConfrim.Text != "")
            {
                if (txtPassword.Text.Trim() == txtPasswordConfrim.Text.Trim())
                {
                    if (CheckAccount())
                    {
                        string username = txtUsername.Text.Trim();
                        string password = txtPasswordConfrim.Text.Trim();
                        busAccount.UpdatePassword(password, username);
                        DialogResult result = MessageBox.Show("Mật khẩu đã được cập nhật. Bạn có muốn quay trở về trang chủ ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (result == DialogResult.OK)
                        {
                            FLogin login = new FLogin();
                            login.Show();
                            Hide();
                        }
                        else
                        {
                            Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản người dùng không đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu xác nhận không chính xác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPasswordConfrim.Text = null;
                }
            }
            else
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
    }
}
