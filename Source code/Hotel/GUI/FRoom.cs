using BUS;
using DTO;
using System;
using System.Windows.Forms;


namespace GUI
{
    public partial class FRoom : Form
    {
        private readonly Room_BUS busRoom = new Room_BUS();
        private readonly CheckInput_BUS busCheckInput = new CheckInput_BUS();
        public string username;
        public string password;

        public FRoom()
        {
            InitializeComponent();
        }

        #region Load, Get data & Method
        private void FRoom_Load(object sender, EventArgs e)
        {
            ShadowForm.SetShadowForm(this);
            RefreshData();
            LoadRoomType();
        }

        private void RefreshData()
        {
            dgvRoom.DataSource = busRoom.GetRoom();
        }

        private void LoadRoomType()
        {
            cboRoomType.DataSource = busRoom.LoadRoomType().Tables[0];
            cboRoomType.DisplayMember = "Type";
            txtPrice.DataBindings.Add(new Binding("Text", cboRoomType.DataSource, "Price"));
        }

        private bool CheckRoomName()
        {
            return busRoom.CheckRoomName(txtRoomName.Text);
        }

        private bool CheckNull()
        {
            return txtRoomName.Text != "" && cboRoomType.Text != "" && cboStatus.Text != "" && txtPrice.Text != "";
        }

        private void ClearText()
        {
            txtRoomName.Text = txtPrice.Text = txtSearch.Text = null;
        }
        #endregion

        #region Notification
        private void MessageBoxWarning()
        {
            MessageBox.Show("Xin hãy nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void MessageBoxError()
        {
            MessageBox.Show("Không có phòng nào.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        #endregion

        #region Check input data
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
        private void Datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtRoomName.Text = dgvRoom.Rows[dong].Cells[0].Value.ToString();
            cboRoomType.Text = dgvRoom.Rows[dong].Cells[1].Value.ToString();
            cboStatus.Text = dgvRoom.Rows[dong].Cells[2].Value.ToString();
            txtPrice.Text = dgvRoom.Rows[dong].Cells[3].Value.ToString();
        }

        private void Search_OnValueChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            busRoom.SearchRoom(search);
            dgvRoom.DataSource = busRoom.SearchRoom(search);
        }

        private void Return_Click(object sender, EventArgs e)
        {
            FHotelManagement fHotel = new FHotelManagement();
            fHotel.Show();
            Hide();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            busRoom.SearchRoom(search);
            dgvRoom.DataSource = busRoom.SearchRoom(search);
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            ClearText();
            RefreshData();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (CheckRoomName())
            {
                MessageBox.Show("Tên phòng đã được sử dụng. Hãy nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRoomName.Text = null;
            }
            else
            {
                if (CheckNull())
                {
                    string roomName = txtRoomName.Text;
                    string roomType = cboRoomType.Text;
                    string status = cboStatus.Text;
                    int price = Convert.ToInt32(txtPrice.Text);
                    Room_DTO room = new Room_DTO(roomName, roomType, status, price);
                    busRoom.AddRoom(room);
                    MessageBox.Show("Phòng " + roomName + " đã được thêm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
            if (dgvRoom.SelectedRows.Count > 0)
            {
                if (CheckNull())
                {
                    string roomName = txtRoomName.Text;
                    string roomType = cboRoomType.Text;
                    string status = cboStatus.Text;
                    int price = Convert.ToInt32(txtPrice.Text);
                    Room_DTO room = new Room_DTO(roomName, roomType, status, price);
                    busRoom.EditRoom(room);
                    MessageBox.Show("Thông tin phòng " + roomName + " đã được cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
            if (dgvRoom.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa phòng " + txtRoomName.Text + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string roomName = txtRoomName.Text;
                    busRoom.DeleteRoom(roomName);
                    MessageBox.Show("Thông tin phòng " + roomName + " đã xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    RefreshData();
                    ClearText();
                }
            }
            else
            {
                MessageBoxError();
            }
        }

        private void Roomtype_Click(object sender, EventArgs e)
        {
            FRoomType fRoomType = new FRoomType();
            fRoomType.Show();
            Hide();
        }
        #endregion

    }
}
