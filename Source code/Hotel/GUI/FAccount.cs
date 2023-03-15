using BUS;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FAccount : Form
    {
        public string username;
        public string password;
        private readonly Account_BUS busAccount = new Account_BUS();
        private readonly Staff_BUS busStaff = new Staff_BUS();
        private readonly Encode_BUS busEncode = new Encode_BUS();

        public FAccount()
        {
            InitializeComponent();
        }

        #region Check input data
        private bool CheckNull()
        {
            return txtIdStaff.Text != "" && txtName.Text != "" && dtmDateOfBirth.Text != "" && cboSex.Text != "" && txtStaffType.Text != "" && txtIDcard.Text != "" && txtAddress.Text != "" && txtPhone.Text != "" && txtEmail.Text != "" && dtmDateStartWork.Text != "";
        }
        #endregion

        #region Load, Get data & Method
        private void FAccount_Load(object sender, EventArgs e)
        {
            txtUsername.Text = username;
            txtPassword.Text = password;
            GetIdStaff();
            GetInfo();
            ShadowForm.SetShadowForm(this);
        }

        private void GetIdStaff()
        {
            txtIdStaff.DataBindings.Add(new Binding("Text", busAccount.GetIdStaff(busEncode.Encrypt(username)), "IdStaff"));
        }

        private void GetInfo()
        {
            string id = txtIdStaff.Text.Trim();
            txtName.DataBindings.Clear();
            txtName.DataBindings.Add(new Binding("Text", busStaff.GetInfo(id), "Name"));
            dtmDateOfBirth.DataBindings.Add(new Binding("Text", busStaff.GetInfo(id), "DateOfBirth"));
            dtmDateStartWork.DataBindings.Add(new Binding("Text", busStaff.GetInfo(id), "DateStartWork"));
            txtStaffType.DataBindings.Clear();
            txtStaffType.DataBindings.Add(new Binding("Text", busStaff.GetInfo(id), "StaffType"));
            txtAddress.DataBindings.Clear();
            txtAddress.DataBindings.Add(new Binding("Text", busStaff.GetInfo(id), "Address"));
            txtPhone.DataBindings.Clear();
            txtPhone.DataBindings.Add(new Binding("Text", busStaff.GetInfo(id), "Phone"));
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add(new Binding("Text", busStaff.GetInfo(id), "Email"));
            txtIDcard.DataBindings.Clear();
            txtIDcard.DataBindings.Add(new Binding("Text", busStaff.GetInfo(id), "IDcard"));
        }

        private void UpdateInfo()
        {
            string idStaff = txtIdStaff.Text;
            string name = txtName.Text;
            DateTime dateOfBirth = dtmDateOfBirth.Value;
            string sex = cboSex.Text;
            string staffType = txtStaffType.Text;
            string idCard = txtIDcard.Text;
            string address = txtAddress.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            DateTime dateStartWork = dtmDateStartWork.Value;
            Staff_DTO staff = new Staff_DTO(idStaff, name, dateOfBirth, sex, staffType, idCard, address, phone, email, dateStartWork);
            busStaff.EditStaff(staff);
            DialogResult result = MessageBox.Show("Cập nhật thông tin thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            if (result == DialogResult.OK)
            {
                FLogin fLogin = new FLogin();
                fLogin.Show();
                Hide();
            }
        }
        #endregion

        #region Click & Events
        private void ShowPassword_Click(object sender, EventArgs e)
        {
            btnHidePassword.BringToFront();
            txtPassword.isPassword = false;
        }

        private void HidePassword_Click(object sender, EventArgs e)
        {
            btnShowPassword.BringToFront();
            txtPassword.isPassword = true;
        }

        private void ShowNewPassword_Click(object sender, EventArgs e)
        {
            btnHideNewPassword.BringToFront();
            txtNewPassword.isPassword = false;
        }

        private void HideNewPassword_Click(object sender, EventArgs e)
        {
            btnShowNewPassword.BringToFront();
            txtNewPassword.isPassword = true;
        }

        private void ShowConfirmPassword_Click(object sender, EventArgs e)
        {
            btnHideConfirmPassword.BringToFront();
            txtConfirmPassword.isPassword = false;
        }

        private void HideConfirmPassword_Click(object sender, EventArgs e)
        {
            btnShowConfirmPassword.BringToFront();
            txtConfirmPassword.isPassword = true;
        }

        private void Return_Click(object sender, EventArgs e)
        {
            FHotelManagement fHotel = new FHotelManagement
            {
                username = username,
                password = password
            };
            fHotel.Show();
            Hide();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (CheckNull())
            {
                if (txtConfirmPassword.Text.Trim() != "")
                {
                    if (txtNewPassword.Text.Equals(txtConfirmPassword.Text))
                    {
                        string newPassword = txtConfirmPassword.Text.Trim();
                        busAccount.UpdatePassword(username, newPassword);
                        UpdateInfo();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu xác nhận không chính xác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    UpdateInfo();
                }
            }
            else
            {
                MessageBox.Show("Không được để trống thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
    }
}
