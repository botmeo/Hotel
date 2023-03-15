using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class FToBook : Form
    {
        public string username;
        public string password;
        private static readonly int width = 136;
        private static readonly int height = 75;
        private readonly ToBook_BUS busToBook = new ToBook_BUS();
        private readonly Customer_BUS busCustomer = new Customer_BUS();
        private readonly Room_BUS busRoom = new Room_BUS();
        private readonly BillDetails_BUS busBillDetails = new BillDetails_BUS();
        private readonly CheckInput_BUS busCheckInput = new CheckInput_BUS();

        public FToBook()
        {
            InitializeComponent();
        }

        #region Load, Get data & Method
        private void FToBook_Load(object sender, EventArgs e)
        {
            LoadDate();
            RefreshData();
            ShadowForm.SetShadowForm(this);
        }

        private void RefreshData()
        {
            dgvToBook.DataSource = busToBook.GetDataBook();
            LoadRoomType();
            LoadRoomList();
            CountRoom();
        }

        private void LoadDate()
        {
            dtmDateCheckIn.Value = DateTime.Now;
            dtmDateCheckOut.Value = DateTime.Now.AddDays(1);
        }

        private void LoadRoomList()
        {
            flpRoom.Controls.Clear();
            List<Room_DTO> roomList = busRoom.LoadRoomList();
            foreach (Room_DTO item in roomList)
            {
                Guna.UI2.WinForms.Guna2Chip room = new Guna.UI2.WinForms.Guna2Chip() { Height = height, Width = width };
                room.Text = item.RoomName + Environment.NewLine + item.Type;
                room.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
                switch (item.StatusRoom)
                {
                    case "Có khách":
                        room.FillColor = Color.Coral;
                        break;
                    case "Trống":
                        room.FillColor = Color.DarkSlateBlue;
                        break;
                    default:
                        room.FillColor = Color.DimGray;
                        break;
                }
                flpRoom.Controls.Add(room);
            }
        }

        private void LoadRoomType()
        {
            cboRoomType.DataSource = busRoom.LoadRoomType().Tables[0];
            cboRoomType.DisplayMember = "Type";
            txtRoomPrice.DataBindings.Clear();
            txtRoomPrice.DataBindings.Add(new Binding("Text", cboRoomType.DataSource, "Price"));
            txtLimitPeople.DataBindings.Clear();
            txtLimitPeople.DataBindings.Add(new Binding("Text", cboRoomType.DataSource, "LimitPeople"));
        }

        private void CountRoom()
        {
            int totalRoom = 0;
            int roomFree = 0;
            int roomBusy = 0;
            int roomOther = 0;
            List<Room_DTO> roomList = busRoom.LoadRoomList();
            foreach (Room_DTO item in roomList)
            {
                totalRoom++;
                txtTotalRoom.Text = Convert.ToString(totalRoom);
                if (item.StatusRoom == "Có khách")
                {
                    roomBusy++;
                    txtRoomBusy.Text = Convert.ToString(roomBusy);
                }
                else if (item.StatusRoom == "Trống")
                {
                    roomFree++;
                    txtRoomFree.Text = Convert.ToString(roomFree);
                }
                else
                {
                    roomOther++;
                    txtRoomOther.Text = Convert.ToString(roomOther);
                }
            }
        }

        private void GetCustomer()
        {
            string id_customer = txtIdCustomer.Text;
            txtCustomerName.DataBindings.Clear();
            txtCustomerName.DataBindings.Add(new Binding("Text", busCustomer.GetCustomer(id_customer), "Name"));
            dtmDateOfBirth.DataBindings.Clear();
            dtmDateOfBirth.DataBindings.Add(new Binding("Text", busCustomer.GetCustomer(id_customer), "DateOfBirth"));
            cboSex.DataBindings.Clear();
            cboSex.DataBindings.Add(new Binding("Text", busCustomer.GetCustomer(id_customer), "Sex"));
            txtIDcard.DataBindings.Clear();
            txtIDcard.DataBindings.Add(new Binding("Text", busCustomer.GetCustomer(id_customer), "IdCard"));
            txtPhone.DataBindings.Clear();
            txtPhone.DataBindings.Add(new Binding("Text", busCustomer.GetCustomer(id_customer), "Phone"));
            cboNationality.DataBindings.Clear();
            cboNationality.DataBindings.Add(new Binding("Text", busCustomer.GetCustomer(id_customer), "Nationality"));
        }

        private bool CheckIdBook()
        {
            return busToBook.CheckIdBook(txtIdBook.Text);
        }

        private bool CheckIdCustomer()
        {
            return busCustomer.CheckIdCustomer(txtIdCustomer.Text);
        }

        private bool CheckIdBill()
        {
            return busBillDetails.CheckIdBillDetails(txtIdBook.Text);
        }

        private bool CheckChangeRoom()
        {
            return busCustomer.CheckIdCustomer(txtRoomName.Text);
        }

        private bool CheckNull()
        {
            return txtCustomerName.Text != "" && txtIDcard.Text != "" && txtPhone.Text != "" && txtRoomName.Text != "";
        }

        private void ClearText()
        {
            txtCustomerName.Text = txtIDcard.Text = txtPhone.Text = txtSearch.Text = txtIdBook.Text = txtIdCustomer.Text = txtRoomName.Text = null;
        }
        #endregion

        #region Notification
        private void MessageBoxWarning()
        {
            MessageBox.Show("Xin hãy nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void MessageBoxError()
        {
            MessageBox.Show("Không có phiếu đặt phòng nào.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            txtIdBook.Text = dgvToBook.Rows[dong].Cells[0].Value.ToString();
            txtIdCustomer.Text = dgvToBook.Rows[dong].Cells[1].Value.ToString();
            txtRoomName.Text = dgvToBook.Rows[dong].Cells[2].Value.ToString();
            txtChangeRoom.Text = dgvToBook.Rows[dong].Cells[2].Value.ToString();
            dtmDateCheckIn.Text = dgvToBook.Rows[dong].Cells[3].Value.ToString();
            dtmDateCheckOut.Text = dgvToBook.Rows[dong].Cells[4].Value.ToString();
            GetCustomer();
        }

        private void Paydate_ValueChanged(object sender, EventArgs e)
        {
            int dateofhire = DateTime.Compare(dtmDateCheckIn.Value, dtmDateCheckOut.Value);
            if (dateofhire > 0)
            {
                MessageBox.Show("Số ngày thuê phải nhiều hơn 1 ngày.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtmDateCheckOut.Value = dtmDateCheckIn.Value.AddDays(1);
            }
        }

        private void RoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRoomType.SelectedValue.ToString() != null)
            {
                string type = cboRoomType.Text;
                cboRoomName.DataSource = busRoom.LoadRoomName(type);
                cboRoomName.DisplayMember = "RoomName";
            }
        }

        private void RoomName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRoomName.SelectedValue.ToString() != null)
            {
                string room_name = cboRoomName.Text;
                txtRoomName.Text = room_name;
            }
        }

        private void Search_OnValueChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            busToBook.SearchBook(search);
            dgvToBook.DataSource = busToBook.SearchBook(search);
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
            busToBook.SearchBook(search);
            dgvToBook.DataSource = busToBook.SearchBook(search);
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            ClearText();
            RefreshData();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (CheckIdBook() || CheckIdCustomer() || CheckIdBill())
            {
                MessageBox.Show("Vui lòng bấm đặt phòng lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdBook.Text = txtIdCustomer.Text = null;
            }
            else
            {
                if (CheckNull())
                {
                    var chars = "1234567890ABCDEFGHIJKLMNOQRSTUVWXYZ";
                    var stringChars = new char[12];
                    var random = new Random();
                    for (int i = 0; i < stringChars.Length; i++)
                    {
                        stringChars[i] = chars[random.Next(chars.Length)];
                    }
                    string idBook = new string(stringChars);
                    string idCustomer = new string(stringChars);
                    string roomName = txtRoomName.Text;
                    DateTime dateCheckIn = dtmDateCheckIn.Value;
                    DateTime dateCheckOut = dtmDateCheckOut.Value;
                    string customerName = txtCustomerName.Text;
                    DateTime dateOfBirth = dtmDateOfBirth.Value;
                    string sex = cboSex.Text;
                    string idCard = txtIDcard.Text;
                    string phone = txtPhone.Text;
                    string nationality = cboNationality.Text;
                    Customer_DTO customer = new Customer_DTO(idCustomer, customerName, dateOfBirth, sex, idCard, phone, nationality);
                    BookRoom_DTO book = new BookRoom_DTO(idBook, idCustomer, roomName, dateCheckIn, dateCheckOut);
                    busCustomer.AddCustomer(customer);
                    busToBook.AddBookRoom(book);
                    busRoom.UpdateRoomBusy(roomName);
                    MessageBox.Show("Phiếu đặt phòng đã được thêm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    RefreshData();
                    ClearText();
                }
                else
                {
                    MessageBoxWarning();
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (dgvToBook.SelectedRows.Count > 0)
            {
                if (CheckNull())
                {
                    if (!CheckChangeRoom())
                    {
                        DialogResult result = MessageBox.Show("Bạn có muốn đổi từ " + txtChangeRoom.Text + " sang phòng " + txtRoomName.Text + " không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            string idBook = txtIdBook.Text;
                            string idCustomer = txtIdCustomer.Text;
                            string roomName = txtRoomName.Text;
                            DateTime dateCheckIn = dtmDateCheckIn.Value;
                            DateTime dateCheckOut = dtmDateCheckOut.Value;
                            string customerName = txtCustomerName.Text;
                            DateTime dateOfBirth = dtmDateOfBirth.Value;
                            string sex = cboSex.Text;
                            string idCard = txtIDcard.Text;
                            string phone = txtPhone.Text;
                            string nationality = cboNationality.Text;
                            Customer_DTO customer = new Customer_DTO(idCustomer, customerName, dateOfBirth, sex, idCard, phone, nationality);
                            BookRoom_DTO book = new BookRoom_DTO(idBook, idCustomer, roomName, dateCheckIn, dateCheckOut);
                            busToBook.EditBookRoom(book);
                            busCustomer.EditCustomer(customer);
                            busRoom.UpdateRoomBusy(roomName);
                            busRoom.UpdateRoomFree(txtChangeRoom.Text);
                            MessageBox.Show("Thông tin phiếu đặt phòng " + idBook + " đã cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            RefreshData();
                        }
                    }
                    else
                    {
                        string idBook = txtIdBook.Text;
                        string idCustomer = txtIdCustomer.Text;
                        string roomName = txtRoomName.Text;
                        DateTime dateCheckIn = dtmDateCheckIn.Value;
                        DateTime dateCheckOut = dtmDateCheckOut.Value;
                        string customerName = txtCustomerName.Text;
                        DateTime dateOfBirth = dtmDateOfBirth.Value;
                        string sex = cboSex.Text;
                        string idCard = txtIDcard.Text;
                        string phone = txtPhone.Text;
                        string nationality = cboNationality.Text;
                        BookRoom_DTO book = new BookRoom_DTO(idBook, idCustomer, roomName, dateCheckIn, dateCheckOut);
                        Customer_DTO customer = new Customer_DTO(idCustomer, customerName, dateOfBirth, sex, idCard, phone, nationality);
                        busToBook.EditBookRoom(book);
                        busCustomer.EditCustomer(customer);
                        MessageBox.Show("Thông tin phiếu đặt phòng " + idBook + " đã cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

        private void Cancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvToBook.SelectedRows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn hủy phiếu đặt phòng " + txtIdBook.Text + " không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string idBook = txtIdBook.Text;
                        string idCustomer = txtIdCustomer.Text;
                        string roomName = txtRoomName.Text;
                        busToBook.DeleteBookRoom(idBook);
                        busCustomer.DeleteCustomer(idCustomer);
                        busRoom.UpdateRoomFree(roomName);
                        MessageBox.Show("Phiếu đặt phòng đã được hủy bỏ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                MessageBox.Show("Không thể hủy bỏ phiếu đặt phòng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void CheckIn_Click(object sender, EventArgs e)
        {
            if (chkCheckIn.Checked)
            {
                FCheckIn fCheckIn = new FCheckIn
                {
                    username = username,
                    password = password
                };
                fCheckIn.Show();
                Hide();
            }
        }
        #endregion
    }
}
