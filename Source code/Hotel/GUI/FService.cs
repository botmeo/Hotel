using BUS;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FService : Form
    {
        public string username;
        public string password;
        private readonly Service_BUS busService = new Service_BUS();
        private readonly ServiceType_BUS busServiceType = new ServiceType_BUS();
        private readonly CheckInput_BUS busCheckInput = new CheckInput_BUS();

        public FService()
        {
            InitializeComponent();
        }

        #region Load, Get data & Method
        private void FService_Load(object sender, EventArgs e)
        {
            RefreshDataService();
            RefreshDataServiceType();
            ShadowForm.SetShadowForm(this);
        }
        #region tpService
        private void LoadServiceType()
        {
            cboServiceType.DataSource = busServiceType.LoadServiceType().Tables[0];
            cboServiceType.DisplayMember = "ServiceType";
        }

        private void RefreshDataService()
        {
            dgvService.DataSource = busService.GetService();
        }

        private bool CheckServiceName()
        {
            return busService.CheckServiceName(txtServiceName.Text);
        }

        private bool CheckNullService()
        {
            return txtServiceName.Text != "" && cboServiceType.Text != "" && txtPrice.Text != "";
        }

        private void ClearTextService()
        {
            txtServiceName.Text = txtPrice.Text = txtSearchService.Text = null;
        }
        #endregion
        #region tpServiceType
        private void RefreshDataServiceType()
        {
            dgvServiceType.DataSource = busServiceType.GetServiceType();
            LoadServiceType();
        }

        private bool CheckServiceNameType()
        {
            return busServiceType.CheckServiceNameType(txtServiceTypeName.Text);
        }

        private bool CheckNullServiceType()
        {
            return txtServiceTypeName.Text != "";
        }

        private void ClearTextServiceType()
        {
            txtServiceTypeName.Text = txtSearchServiceType.Text = null;
        }
        #endregion
        #endregion

        #region Notification
        private void MessageBoxWarning()
        {
            MessageBox.Show("Xin hãy nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void MessageBoxError()
        {
            MessageBox.Show("Không có dịch vụ nào.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        #endregion

        #region Check input data     
        private void Service_KeyPress(object sender, KeyPressEventArgs e)
        {
            busCheckInput.CheckLetter(e);
        }

        private void Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            busCheckInput.CheckNumber(e);
        }

        private void Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            busCheckInput.CheckSearchInput(e);
        }
        #endregion

        #region Click & Events
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
        #region tpService
        private void DatagridviewService_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtServiceName.Text = dgvService.Rows[dong].Cells[0].Value.ToString();
            cboServiceType.Text = dgvService.Rows[dong].Cells[1].Value.ToString();
            txtPrice.Text = dgvService.Rows[dong].Cells[2].Value.ToString();
        }

        private void SearchService_OnValueChanged(object sender, EventArgs e)
        {
            string search = txtSearchService.Text;
            busService.SearchService(search);
            dgvService.DataSource = busService.SearchService(search);
        }

        private void SearchService_Click(object sender, EventArgs e)
        {
            string search = txtSearchService.Text;
            busService.SearchService(search);
            dgvService.DataSource = busService.SearchService(search);
        }

        private void RefreshService_Click(object sender, EventArgs e)
        {
            ClearTextService();
            RefreshDataService();
        }

        private void AddService_Click(object sender, EventArgs e)
        {
            if (CheckServiceName())
            {
                MessageBox.Show("Tên dịch vụ đã được sử dụng. Hãy nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtServiceName.Text = null;
            }
            else
            {
                if (CheckNullService())
                {
                    string serviceName = txtServiceName.Text;
                    string serviceType = cboServiceType.Text;
                    int price = Convert.ToInt32(txtPrice.Text);
                    Service_DTO service = new Service_DTO(serviceName, serviceType, price);
                    busService.AddService(service);
                    MessageBox.Show("Dịch vụ " + serviceName + " đã được thêm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    RefreshDataService();
                }
                else
                {
                    MessageBoxWarning();
                }
            }
        }

        private void EditService_Click(object sender, EventArgs e)
        {
            if (dgvService.SelectedRows.Count > 0)
            {
                if (CheckNullService())
                {
                    string serviceName = txtServiceName.Text;
                    string serviceType = cboServiceType.Text;
                    int price = Convert.ToInt32(txtPrice.Text);
                    Service_DTO service = new Service_DTO(serviceName, serviceType, price);
                    busService.EditService(service);
                    MessageBox.Show("Thông tin dịch vụ " + serviceName + " đã cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    RefreshDataService();
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

        private void DeleteService_Click(object sender, EventArgs e)
        {
            if (dgvService.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa dịch vụ " + txtServiceName.Text + " không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string serviceName = txtServiceName.Text;
                    busService.DeleteService(serviceName);
                    MessageBox.Show("Thông tin dịch vụ " + serviceName + " đã xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    RefreshDataService();
                    ClearTextService();
                }
            }
            else
            {
                MessageBoxError();
            }
        }
        #endregion
        #region tpServiceType
        private void DatagridviewServiceType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtServiceTypeName.Text = dgvServiceType.Rows[dong].Cells[1].Value.ToString();
        }

        private void SearchServiceType_OnValueChanged(object sender, EventArgs e)
        {
            string search = txtSearchServiceType.Text;
            busServiceType.SearchServiceType(search);
            dgvServiceType.DataSource = busServiceType.SearchServiceType(search);
        }

        private void SearchServiceType_Click(object sender, EventArgs e)
        {
            string search = txtSearchServiceType.Text;
            busServiceType.SearchServiceType(search);
            dgvServiceType.DataSource = busServiceType.SearchServiceType(search);
        }

        private void RefreshServiceType_Click(object sender, EventArgs e)
        {
            ClearTextServiceType();
            RefreshDataServiceType();
        }

        private void AddServiceType_Click(object sender, EventArgs e)
        {
            if (CheckServiceNameType())
            {
                MessageBox.Show("Tên loại dịch vụ đã được sử dụng. Hãy nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtServiceTypeName.Text = null;
            }
            else
            {
                if (CheckNullServiceType())
                {
                    string serviceType = txtServiceTypeName.Text;
                    ServiceType_DTO type = new ServiceType_DTO(serviceType);
                    busServiceType.AddServiceType(type);
                    MessageBox.Show("Loại dịch vụ " + serviceType + " đã được thêm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    RefreshDataServiceType();
                }
                else
                {
                    MessageBoxWarning();
                }
            }
        }

        private void DeleteServiceType_Click(object sender, EventArgs e)
        {
            if (dgvServiceType.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa loại dịch vụ " + txtServiceTypeName.Text + " không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string serviceType = txtServiceTypeName.Text;
                    busServiceType.DeleteServiceType(serviceType);
                    MessageBox.Show("Thông tin loại dịch vụ " + serviceType + " đã xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    RefreshDataServiceType();
                    ClearTextServiceType();
                }
            }
            else
            {
                MessageBoxError();
            }
        }
        #endregion
        #endregion
    }
}
