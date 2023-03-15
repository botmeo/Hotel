using BUS;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FRegulation : Form
    {
        public string username;
        public string password;
        private readonly Regulations_BUS busRegulations = new Regulations_BUS();
        private readonly ExportToExcel_BUS busExportExcel = new ExportToExcel_BUS();

        public FRegulation()
        {
            InitializeComponent();
        }

        #region Load, Get data & Method
        private void FRegulation_Load(object sender, EventArgs e)
        {
            RefreshData();
            ShadowForm.SetShadowForm(this);
        }

        private void RefreshData()
        {
            dgvRegulations.DataSource = busRegulations.GetRegulations();
        }

        private void ClearText()
        {
            txtId.Text = txtRegulationsName.Text = txtCoefficient.Text = txtDescription.Text = null;
        }
        #endregion

        #region Check input data
        private bool CheckNull()
        {
            return txtRegulationsName.Text != "" && txtDescription.Text != "";
        }
        #endregion

        #region Notification
        private void MessageBoxWarning()
        {
            MessageBox.Show("Xin hãy nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void MessageBoxError()
        {
            MessageBox.Show("Không có quy định nào.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        #endregion

        #region Click & Events
        private void Regulations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtId.Text = dgvRegulations.Rows[dong].Cells[0].Value.ToString();
            txtRegulationsName.Text = dgvRegulations.Rows[dong].Cells[1].Value.ToString();
            txtCoefficient.Text = dgvRegulations.Rows[dong].Cells[2].Value.ToString();
            txtDescription.Text = dgvRegulations.Rows[dong].Cells[3].Value.ToString();
        }

        private void Search_OnValueChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            busRegulations.SearchRegulations(search);
            dgvRegulations.DataSource = busRegulations.SearchRegulations(search);
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
            busRegulations.SearchRegulations(search);
            dgvRegulations.DataSource = busRegulations.SearchRegulations(search);
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            ClearText();
            RefreshData();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (CheckNull())
            {
                string regulationsName = txtRegulationsName.Text;
                string description = txtDescription.Text;
                if (txtCoefficient.Text != "")
                {
                    float coefficient = float.Parse(txtCoefficient.Text);
                    Regulations_DTO regulations = new Regulations_DTO(regulationsName, coefficient, description);
                    busRegulations.AddRegulations(regulations);
                    MessageBox.Show("Thêm quy định " + regulationsName + " thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    RefreshData();
                }
                else
                {
                    Regulations_DTO regulations = new Regulations_DTO(regulationsName, 0, description);
                    busRegulations.AddRegulations(regulations);
                    MessageBox.Show("Thêm quy định " + regulationsName + " thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    RefreshData();
                }
            }
            else
            {
                MessageBoxWarning();
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (dgvRegulations.SelectedRows.Count > 0)
            {
                if (CheckNull())
                {
                    string regulationsName = txtRegulationsName.Text;
                    string description = txtDescription.Text;
                    if (txtCoefficient.Text != "")
                    {
                        float coefficient = float.Parse(txtCoefficient.Text);
                        Regulations_DTO regulations = new Regulations_DTO(regulationsName, coefficient, description);
                        busRegulations.EditRegulations(regulations);
                        MessageBox.Show("Cập nhật quy định " + regulationsName + " thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        RefreshData();
                    }
                    else
                    {
                        Regulations_DTO regulations = new Regulations_DTO(regulationsName, 0, description);
                        busRegulations.EditRegulations(regulations);
                        MessageBox.Show("Cập nhật quy định " + regulationsName + " thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        RefreshData();
                    }
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
            if (dgvRegulations.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa quy định " + txtRegulationsName.Text + " không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(txtId.Text);
                    string regulationsName = txtRegulationsName.Text;
                    busRegulations.DeleteRegulations(id);
                    MessageBox.Show("Thông tin quy định " + regulationsName + " đã xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
            if (dgvRegulations.SelectedRows.Count > 0)
            {
                DataGridView datagridview = dgvRegulations;
                busExportExcel.ExportExcel(datagridview);
            }
            else
            {
                MessageBox.Show("Không thể xuất danh sách quy định.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
    }
}
