using BUS;
using DTO;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GUI
{
    public partial class FStaff : Form
    {
        private readonly Staff_BUS busStaff = new Staff_BUS();
        private readonly Account_BUS busAccount = new Account_BUS();
        private readonly ExportToExcel_BUS busExportExcel = new ExportToExcel_BUS();
        private readonly CheckInput_BUS busCheckInput = new CheckInput_BUS();
        public string username;
        public string password;

        public FStaff()
        {
            InitializeComponent();
        }

        #region Load, Get data & Method
        private void FStaff_Load(object sender, EventArgs e)
        {
            ShadowForm.SetShadowForm(this);
            RefreshData();
        }

        private void RefreshData()
        {
            dgvStaff.DataSource = busStaff.GetStaff();
        }

        private bool CheckID()
        {
            return busStaff.CheckIdStaff(txtIdStaff.Text);
        }

        private void ClearText()
        {
            txtIdStaff.Text = txtName.Text = txtIDcard.Text = txtAddress.Text = txtPhone.Text = txtEmail.Text = txtSearch.Text = null;
        }
        #endregion

        #region Notification
        private void MessageBoxWarning()
        {
            MessageBox.Show("Xin hãy nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void MessageBoxError()
        {
            MessageBox.Show("Không có nhân viên nào.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        #endregion

        #region Check input data
        private bool CheckNull()
        {
            return txtIdStaff.Text != "" && txtName.Text != "" && dtmDateOfBirth.Text != "" && cboSex.Text != "" && cboStaffType.Text != "" && txtIDcard.Text != "" && txtAddress.Text != "" && txtPhone.Text != "" && txtEmail.Text != "" && dtmDateStartWork.Text != "";
        }

        private void Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            busCheckInput.CheckLetter(e);
        }

        private void Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            busCheckInput.CheckNumber(e);
        }

        private void Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            busCheckInput.CheckSearchInput(e);
        }

        private void Email_Validating(object sender, System.ComponentModel.CancelEventArgs e)
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
            }
        }
        #endregion

        #region Click & Events
        private void Datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtIdStaff.Text = dgvStaff.Rows[dong].Cells[0].Value.ToString();
            txtName.Text = dgvStaff.Rows[dong].Cells[1].Value.ToString();
            dtmDateOfBirth.Text = dgvStaff.Rows[dong].Cells[2].Value.ToString();
            cboSex.Text = dgvStaff.Rows[dong].Cells[3].Value.ToString();
            cboStaffType.Text = dgvStaff.Rows[dong].Cells[4].Value.ToString(); ;
            txtIDcard.Text = dgvStaff.Rows[dong].Cells[5].Value.ToString();
            txtAddress.Text = dgvStaff.Rows[dong].Cells[6].Value.ToString();
            txtPhone.Text = dgvStaff.Rows[dong].Cells[7].Value.ToString();
            txtEmail.Text = dgvStaff.Rows[dong].Cells[8].Value.ToString();
            dtmDateStartWork.Text = dgvStaff.Rows[dong].Cells[9].Value.ToString();
        }

        private void Search_OnValueChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            busStaff.SearchStaff(search);
            dgvStaff.DataSource = busStaff.SearchStaff(search);
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

        private void Search_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            busStaff.SearchStaff(search);
            dgvStaff.DataSource = busStaff.SearchStaff(search);
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            ClearText();
            RefreshData();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (CheckID())
            {
                MessageBox.Show("Mã nhân viên đã được sử dụng. Hãy nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdStaff.Text = null;
            }
            else
            {
                if (CheckNull())
                {
                    string idStaff = txtIdStaff.Text;
                    string name = txtName.Text;
                    DateTime dateOfBirth = dtmDateOfBirth.Value;
                    string sex = cboSex.Text;
                    string staffType = cboStaffType.Text;
                    string idCard = txtIDcard.Text;
                    string address = txtAddress.Text;
                    string phone = txtPhone.Text;
                    string email = txtEmail.Text;
                    DateTime dateStartWork = dtmDateStartWork.Value;
                    Staff_DTO staff = new Staff_DTO(idStaff, name, dateOfBirth, sex, staffType, idCard, address, phone, email, dateStartWork);
                    busStaff.AddStaff(staff);
                    MessageBox.Show("Thêm nhân viên " + name + " thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    RefreshData();
                }
                else
                {
                    MessageBoxWarning();
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count > 0)
            {
                if (CheckNull())
                {
                    string idStaff = txtIdStaff.Text;
                    string name = txtName.Text;
                    DateTime dateOfBirth = dtmDateOfBirth.Value;
                    string sex = cboSex.Text;
                    string staffType = cboStaffType.Text;
                    string idCard = txtIDcard.Text;
                    string address = txtAddress.Text;
                    string phone = txtPhone.Text;
                    string email = txtEmail.Text;
                    DateTime dateStartWork = dtmDateStartWork.Value;
                    Staff_DTO staff = new Staff_DTO(idStaff, name, dateOfBirth, sex, staffType, idCard, address, phone, email, dateStartWork);
                    busStaff.EditStaff(staff);
                    MessageBox.Show("Thông tin nhân viên " + name + " đã cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    RefreshData();
                }
                else
                {
                    MessageBoxWarning();
                }
            }
            else
            {
                MessageBoxError();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa nhân viên " + txtName.Text + " mã nhân viên " + txtIdStaff.Text + " không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string idStaff = txtIdStaff.Text;
                    string name = txtName.Text;
                    busStaff.DeleteStaff(idStaff);
                    busAccount.DeleteAccount(idStaff);
                    MessageBox.Show("Thông tin nhân viên " + name + " đã xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    RefreshData();
                    ClearText();
                }
            }
            else
            {
                MessageBoxError();
            }
        }

        private void Export_Click(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count > 0)
            {
                DataGridView datagridview = dgvStaff;
                busExportExcel.ExportExcel(datagridview);
            }
            else
            {
                MessageBox.Show("Không thể xuất danh sách nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
    }
}
