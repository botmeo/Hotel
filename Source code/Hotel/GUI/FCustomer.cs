using BUS;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FCustomer : Form
    {
        public string username;
        public string password;
        private readonly Customer_BUS busCustomer = new Customer_BUS();
        private readonly ExportToExcel_BUS exportExcel = new ExportToExcel_BUS();
        private readonly CheckInput_BUS busCheckInput = new CheckInput_BUS();

        public FCustomer()
        {
            InitializeComponent();
        }

        #region Load, Get data & Method
        private void FCustomer_Load(object sender, EventArgs e)
        {
            RefreshData();
            ShadowForm.SetShadowForm(this);
        }

        private void RefreshData()
        {
            dgvCustomer.DataSource = busCustomer.LoadDataCustomer();
        }

        private bool CheckNull()
        {
            return txtCustomerName.Text != "" && dtmDateOfBirth.Text != "" && cboSex.Text != "" && txtIDcard.Text != "" && txtPhone.Text != "" && cboNationality.Text != "";
        }

        private void ClearText()
        {
            txtIdCustomer.Text = txtCustomerName.Text = txtIDcard.Text = txtPhone.Text = txtSearch.Text = null;
        }
        #endregion

        #region Notification
        private void MessageBoxWarning()
        {
            MessageBox.Show("Xin hãy nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void MessageBoxError()
        {
            MessageBox.Show("Không có khách hàng nào.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ExportError()
        {
            MessageBox.Show("Không thể xuất danh sách khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        #endregion

        #region Check input data
        private void Customername_KeyPress(object sender, KeyPressEventArgs e)
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
        #endregion

        #region Click & Events
        private void Datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtIdCustomer.Text = dgvCustomer.Rows[dong].Cells[0].Value.ToString();
            txtCustomerName.Text = dgvCustomer.Rows[dong].Cells[1].Value.ToString();
            dtmDateOfBirth.Text = dgvCustomer.Rows[dong].Cells[2].Value.ToString();
            cboSex.Text = dgvCustomer.Rows[dong].Cells[3].Value.ToString();
            txtIDcard.Text = dgvCustomer.Rows[dong].Cells[4].Value.ToString();
            txtPhone.Text = dgvCustomer.Rows[dong].Cells[5].Value.ToString();
            cboNationality.Text = dgvCustomer.Rows[dong].Cells[6].Value.ToString();
        }

        private void Search_OnValueChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            busCustomer.SearchCustomer(search);
            dgvCustomer.DataSource = busCustomer.SearchCustomer(search);
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
            busCustomer.SearchCustomer(search);
            dgvCustomer.DataSource = busCustomer.SearchCustomer(search);
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            ClearText();
            RefreshData();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.SelectedRows.Count > 0)
            {
                if (CheckNull())
                {
                    string idCustomer = txtIdCustomer.Text;
                    string customerName = txtCustomerName.Text;
                    DateTime dateOfBirth = dtmDateOfBirth.Value;
                    string sex = cboSex.Text;
                    string idCard = txtIDcard.Text;
                    string phone = txtPhone.Text;
                    string nationality = cboNationality.Text;
                    Customer_DTO customer = new Customer_DTO(idCustomer, customerName, dateOfBirth, sex, idCard, phone, nationality);
                    busCustomer.EditCustomer(customer);
                    MessageBox.Show("Thông tin khách hàng " + customerName + " đã cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
            try
            {
                if (dgvCustomer.SelectedRows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn xóa thông tin khách hàng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string idCustomer = txtIdCustomer.Text;
                        string customerName = txtCustomerName.Text;
                        busCustomer.DeleteCustomer(idCustomer);
                        MessageBox.Show("Thông tin khách hàng " + customerName + " đã xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        RefreshData();
                    }
                }
                else
                {
                    MessageBoxError();
                }
            }
            catch
            {
                MessageBox.Show("Không thể xóa thông tin khách hàng đã có phiếu đặt phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void Export_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.Rows.Count > 1)
            {
                DataGridView datagridview = dgvCustomer;
                exportExcel.ExportExcel(datagridview);
            }
            else
            {
                ExportError();
            }
        }
        #endregion
    }
}