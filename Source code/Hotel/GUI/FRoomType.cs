using BUS;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FRoomType : Form
    {
        public string username;
        public string password;
        private readonly RoomType_BUS busRoomType = new RoomType_BUS();
        private readonly CheckInput_BUS busCheckInput = new CheckInput_BUS();

        public FRoomType()
        {
            InitializeComponent();
        }

        #region Load, Get data & Method
        private void FRoomType_Load(object sender, EventArgs e)
        {
            RefreshData();
            ShadowForm.SetShadowForm(this);
        }

        private void RefreshData()
        {
            dgvRoomType.DataSource = busRoomType.GetRoomType();
        }

        private bool CheckType()
        {
            return busRoomType.CheckRoomType(txtRoomType.Text);
        }

        private void ClearText()
        {
            txtRoomType.Text = txtPrice.Text = txtLimitPeople.Text = null;
        }
        #endregion

        #region Notification
        private void MessageBoxWarning()
        {
            MessageBox.Show("Xin hãy nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void MessageBoxError()
        {
            MessageBox.Show("Không có loại phòng nào.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        #endregion

        #region Check input data
        private bool CheckNull()
        {
            return txtRoomType.Text != "" && txtPrice.Text != "" && txtLimitPeople.Text != "";
        }

        private void Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            busCheckInput.CheckNumber(e);
        }

        private void Limitpeople_KeyPress(object sender, KeyPressEventArgs e)
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
            txtRoomType.Text = dgvRoomType.Rows[dong].Cells[0].Value.ToString();
            txtPrice.Text = dgvRoomType.Rows[dong].Cells[1].Value.ToString();
            txtLimitPeople.Text = dgvRoomType.Rows[dong].Cells[2].Value.ToString();
        }

        private void Search_OnValueChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            busRoomType.SearchRoomType(search);
            dgvRoomType.DataSource = busRoomType.SearchRoomType(search);
        }

        private void Return_Click(object sender, EventArgs e)
        {
            FRoom fRoom = new FRoom
            {
                username = username,
                password = password
            };
            fRoom.Show();
            Hide();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            busRoomType.SearchRoomType(search);
            dgvRoomType.DataSource = busRoomType.SearchRoomType(search);
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            ClearText();
            RefreshData();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (CheckType())
            {
                MessageBox.Show("Tên loại phòng đã được sử dụng.Hãy nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRoomType.Text = null;
            }
            else
            {
                if (CheckNull())
                {
                    string type = txtRoomType.Text;
                    int price = Convert.ToInt32(txtPrice.Text);
                    int limitPeople = Convert.ToInt32(txtLimitPeople.Text);
                    RoomType_DTO roomtype = new RoomType_DTO(type, price, limitPeople);
                    busRoomType.AddRoomType(roomtype);
                    MessageBox.Show("Thêm loại phòng " + type + " thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
            if (dgvRoomType.SelectedRows.Count > 0)
            {
                if (CheckNull())
                {
                    string type = txtRoomType.Text;
                    int price = Convert.ToInt32(txtPrice.Text);
                    int limitPeople = Convert.ToInt32(txtLimitPeople.Text);
                    RoomType_DTO roomtype = new RoomType_DTO(type, price, limitPeople);
                    busRoomType.EditRoomType(roomtype);
                    MessageBox.Show("Thông tin loại phòng " + type + " đã cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                if (dgvRoomType.SelectedRows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn xóa loại phòng " + txtRoomType.Text + " không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string type = txtRoomType.Text;
                        busRoomType.DeleteRoomType(type);
                        MessageBox.Show("Thông tin loại phòng " + type + " đã xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        RefreshData();
                        ClearText();
                    }
                }
                else
                {
                    MessageBoxError();
                }
            }
            catch
            {
                string type = txtRoomType.Text;
                MessageBox.Show("Bạn phải xóa thông tin các phòng của loại phòng " + type + " trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        #endregion
    }
}
