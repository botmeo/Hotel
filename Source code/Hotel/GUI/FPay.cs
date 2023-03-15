using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace GUI
{
    public partial class FPay : Form
    {
        public string username;
        public string password;
        private static readonly int width = 93;
        private static readonly int height = 85;
        private readonly CultureInfo culture = new CultureInfo("vi-VN");
        private readonly ToBook_BUS busToBook = new ToBook_BUS();
        private readonly Customer_BUS busCustomer = new Customer_BUS();
        private readonly Regulations_BUS busRegulations = new Regulations_BUS();
        private readonly Room_BUS busRoom = new Room_BUS();
        private readonly Bill_BUS busBill = new Bill_BUS();
        private readonly BillDetails_BUS busBillDetails = new BillDetails_BUS();
        private readonly CheckInput_BUS busCheckInput = new CheckInput_BUS();

        public FPay()
        {
            InitializeComponent();
        }

        private void FPay_Load(object sender, EventArgs e)
        {
            LoadRegulations();
            LoadToBook();
            ShadowForm.SetShadowForm(this);
        }

        #region
        private void LoadRegulations()
        {
            lsvRegulations.Items.Clear();
            List<Regulations_DTO> regulationsList = busRegulations.LoadRegulationsList();
            foreach (Regulations_DTO item in regulationsList)
            {
                ListViewItem lsvItem = new ListViewItem(item.RegulationsName.ToString());
                lsvItem.SubItems.Add(item.Coefficient.ToString());
                lsvItem.SubItems.Add(item.Description.ToString());
                lsvRegulations.Items.Add(lsvItem);
            }
        }

        private void LoadToBook()
        {
            flpBookList.Controls.Clear();
            List<BookRoom_DTO> bookList = busToBook.LoadBookList();
            foreach (BookRoom_DTO itemBook in bookList)
            {
                List<Room_DTO> roomList = busRoom.GetRoomList(itemBook.RoomName);
                foreach (Room_DTO itemRoom in roomList)
                {
                    Guna.UI2.WinForms.Guna2Button button = new Guna.UI2.WinForms.Guna2Button() { Height = height, Width = width };
                    button.Text = itemBook.RoomName + Environment.NewLine + itemRoom.Type;
                    button.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
                    button.FillColor = Color.Coral;
                    button.Click += BookClick;
                    button.Tag = itemBook;
                    flpBookList.Controls.Add(button);
                }
            }
        }

        private void ShowToBook(string idBook)
        {
            lsvBill.Items.Clear();
            List<BookRoom_DTO> bookList = busToBook.GetBookList(idBook);
            foreach (BookRoom_DTO itemBook in bookList)
            {
                List<Room_DTO> roomList = busRoom.GetRoomList(itemBook.RoomName);
                foreach (Room_DTO itemRoom in roomList)
                {
                    ListViewItem lsvItem = new ListViewItem(itemBook.RoomName.ToString());
                    lsvItem.SubItems.Add(itemRoom.Price.ToString());
                    lsvItem.SubItems.Add(itemBook.DateCheckIn.ToString().Split(' ')[0]);
                    lsvItem.SubItems.Add(itemBook.DateCheckOut.ToString().Split(' ')[0]);
                    lsvBill.Items.Add(lsvItem);
                }
            }
        }

        private void ShowBillDetails(string idBook)
        {
            lsvBillDetails.Items.Clear();
            List<BillDetails_DTO> billDetailsList = busBillDetails.GetBillDetailList(idBook);
            foreach (BillDetails_DTO item in billDetailsList)
            {
                ListViewItem lsvItem = new ListViewItem(item.ServiceName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                lsvBillDetails.Items.Add(lsvItem);
            }
        }

        private void ShowSumTotalServicePrice(string idBook)
        {
            txtTotalServicePriceHide.DataBindings.Clear();
            txtTotalServicePriceHide.DataBindings.Add(new Binding("Text", busBillDetails.GetSumTotalPrice(idBook), "SumTotalPrice"));
            if (txtTotalServicePriceHide.Text != "")
            {
                txtTotalServicePrice.Text = String.Format(culture, "{0:c}", Convert.ToInt32(txtTotalServicePriceHide.Text));
            }
        }

        private void GetRoomPrice(string roomName)
        {
            txtRoomPriceHide.DataBindings.Clear();
            txtRoomPriceHide.DataBindings.Add(new Binding("Text", busRoom.GetRoomPrice(roomName), "Price"));
            if (txtRoomPriceHide.Text != null)
            {
                txtRoomPrice.Text = String.Format(culture, "{0:c}", Convert.ToInt32(txtRoomPriceHide.Text));
            }
        }
        #endregion

        #region
        private bool CheckNull()
        {
            return txtDiscount.Text != "" && txtSurcharge.Text != "";
        }

        private void Discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            busCheckInput.CheckNumber(e);
        }
        #endregion

        private void BookClick(object sender, EventArgs e)
        {
            string idBook = ((sender as Guna.UI2.WinForms.Guna2Button).Tag as BookRoom_DTO).IdBook;
            string roomName = ((sender as Guna.UI2.WinForms.Guna2Button).Tag as BookRoom_DTO).RoomName;
            ShowToBook(idBook);
            ShowBillDetails(idBook);
            ShowSumTotalServicePrice(idBook);
            GetRoomPrice(roomName);
            txtIdBook.Text = idBook;
            txtRoomName.Text = roomName;
            txtTotalMoney.Text = txtTotalMoneyHide.Text = "";
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

        private void PayOff_Click(object sender, EventArgs e)
        {
            if (txtRoomPriceHide.Text != "")
            {
                if (txtTotalServicePriceHide.Text != "")
                {
                    int servicePrice = Convert.ToInt32(txtTotalServicePriceHide.Text);
                    int roomPrice = Convert.ToInt32(txtRoomPriceHide.Text);
                    if (CheckNull())
                    {
                        int discount = Convert.ToInt32(txtDiscount.Text);
                        double surcharge = Convert.ToDouble(txtSurcharge.Text);
                        int totalMoney = Convert.ToInt32(((roomPrice + servicePrice) - ((roomPrice + servicePrice) * discount / 100)) * surcharge);
                        txtTotalMoneyHide.Text = totalMoney.ToString();
                        txtTotalMoney.Text = String.Format(culture, "{0:c}", totalMoney);
                    }
                    else
                    {
                        if (txtSurcharge.Text != "")
                        {
                            double surcharge = Convert.ToDouble(txtSurcharge.Text);
                            int totalMoney = Convert.ToInt32((roomPrice + servicePrice) * surcharge);
                            txtTotalMoneyHide.Text = totalMoney.ToString();
                            txtTotalMoney.Text = String.Format(culture, "{0:c}", totalMoney);
                        }
                        else if (txtDiscount.Text != "")
                        {
                            int discount = Convert.ToInt32(txtDiscount.Text);
                            int totalMoney = Convert.ToInt32((roomPrice + servicePrice) - ((roomPrice + servicePrice) * discount / 100));
                            txtTotalMoneyHide.Text = totalMoney.ToString();
                            txtTotalMoney.Text = String.Format(culture, "{0:c}", totalMoney);
                        }
                        else
                        {
                            int totalMoney = roomPrice + servicePrice;
                            txtTotalMoneyHide.Text = totalMoney.ToString();
                            txtTotalMoney.Text = String.Format(culture, "{0:c}", totalMoney);
                        }
                    }
                }
                else
                {
                    int servicePrice = 0;
                    int roomPrice = Convert.ToInt32(txtRoomPriceHide.Text);
                    if (CheckNull())
                    {
                        int discount = Convert.ToInt32(txtDiscount.Text);
                        double surcharge = Convert.ToDouble(txtSurcharge.Text);
                        int totalMoney = Convert.ToInt32(((roomPrice + servicePrice) - ((roomPrice + servicePrice) * discount / 100)) * surcharge);
                        txtTotalMoneyHide.Text = totalMoney.ToString();
                        txtTotalMoney.Text = String.Format(culture, "{0:c}", totalMoney);
                    }
                    else
                    {
                        if (txtSurcharge.Text != "")
                        {
                            double surcharge = Convert.ToDouble(txtSurcharge.Text);
                            int totalMoney = Convert.ToInt32((roomPrice + servicePrice) * surcharge);
                            txtTotalMoneyHide.Text = totalMoney.ToString();
                            txtTotalMoney.Text = String.Format(culture, "{0:c}", totalMoney);
                        }
                        else if (txtDiscount.Text != "")
                        {
                            int discount = Convert.ToInt32(txtDiscount.Text);
                            int totalMoney = Convert.ToInt32((roomPrice + servicePrice) - ((roomPrice + servicePrice) * discount / 100));
                            txtTotalMoneyHide.Text = totalMoney.ToString();
                            txtTotalMoney.Text = String.Format(culture, "{0:c}", totalMoney);
                        }
                        else
                        {
                            int totalMoney = roomPrice + servicePrice;
                            txtTotalMoneyHide.Text = totalMoney.ToString();
                            txtTotalMoney.Text = String.Format(culture, "{0:c}", totalMoney);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn phòng cần thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ViewDetails_Click(object sender, EventArgs e)
        {
            if (txtRoomName.Text != "")
            {
                MessageBox.Show("Tính năng đang phát triển.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CompletePayment_Click(object sender, EventArgs e)
        {
            if (txtRoomName.Text != "")
            {
                string roomName = txtRoomName.Text;
                DialogResult result = MessageBox.Show("Bạn có muốn hoàn tất thanh toán phòng " + roomName + " không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (txtTotalServicePriceHide.Text != "")
                    {
                        string idBook = txtIdBook.Text;
                        int roomPrice = Convert.ToInt32(txtRoomPriceHide.Text);
                        int servicePrice = Convert.ToInt32(txtTotalServicePriceHide.Text);
                        int totalMoney = Convert.ToInt32(txtTotalMoneyHide.Text);
                        DateTime date = DateTime.Today;
                        if (CheckNull())
                        {
                            double surcharge = Convert.ToDouble(txtSurcharge.Text);
                            int discount = Convert.ToInt32(txtDiscount.Text);
                            Bill_DTO bill = new Bill_DTO(idBook, roomPrice, servicePrice, surcharge, discount, totalMoney, date, username);
                            busBill.AddBill(bill);
                        }
                        else
                        {
                            double surcharge = 1;
                            int discount = 0;
                            Bill_DTO bill = new Bill_DTO(idBook, roomPrice, servicePrice, surcharge, discount, totalMoney, date, username);
                            busBill.AddBill(bill);
                        }
                        busToBook.DeleteBookRoom(idBook);
                        busCustomer.DeleteCustomer(idBook);
                        busRoom.UpdateRoomFree(roomName);
                        MessageBox.Show("Hoàn thành thanh toán phòng " + roomName + " thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadToBook();
                    } 
                    else
                    {
                        string idBook = txtIdBook.Text;
                        int roomPrice = Convert.ToInt32(txtRoomPriceHide.Text);
                        int servicePrice = 0;
                        int totalMoney = Convert.ToInt32(txtTotalMoneyHide.Text);
                        DateTime date = DateTime.Today;
                        if (CheckNull())
                        {
                            double surcharge = Convert.ToDouble(txtSurcharge.Text);
                            int discount = Convert.ToInt32(txtDiscount.Text);
                            Bill_DTO bill = new Bill_DTO(idBook, roomPrice, servicePrice, surcharge, discount, totalMoney, date, username);
                            busBill.AddBill(bill);
                        }
                        else
                        {
                            double surcharge = 1;
                            int discount = 0;
                            Bill_DTO bill = new Bill_DTO(idBook, roomPrice, servicePrice, surcharge, discount, totalMoney, date, username);
                            busBill.AddBill(bill);
                        }
                        busToBook.DeleteBookRoom(idBook);
                        busCustomer.DeleteCustomer(idBook);
                        busRoom.UpdateRoomFree(roomName);
                        MessageBox.Show("Hoàn thành thanh toán phòng " + roomName + " thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadToBook();
                    }
                }
            }
        }
    }
}
