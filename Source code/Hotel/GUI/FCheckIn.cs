using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace GUI
{
    public partial class FCheckIn : Form
    {
        public string username;
        public string password;
        private int totalPrice;
        private static readonly int width = 93;
        private static readonly int height = 85;
        private readonly Room_BUS busRoom = new Room_BUS();
        private readonly ToBook_BUS busToBook = new ToBook_BUS();
        private readonly Service_BUS busService = new Service_BUS();
        private readonly ServiceType_BUS busServiceType = new ServiceType_BUS();
        private readonly BillDetails_BUS busBillDetails = new BillDetails_BUS();

        public FCheckIn()
        {
            InitializeComponent();
        }

        #region Load, Get data & Method
        private void FCheckIn_Load(object sender, EventArgs e)
        {
            LoadToBook();
            LoadServiceType();
            ShadowForm.SetShadowForm(this);
        }

        private void ShowBillDetails(string idBook)
        {
            txtTotalPrice.Text = "";
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

        private void ShowSumTotalPrice(string idBook)
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            txtTotalPriceHide.DataBindings.Clear();
            txtTotalPriceHide.DataBindings.Add(new Binding("Text", busBillDetails.GetSumTotalPrice(idBook), "SumTotalPrice"));
            if (txtTotalPriceHide.Text != "")
            {
                txtTotalPrice.Text = String.Format(culture, "{0:c}", Convert.ToInt32(txtTotalPriceHide.Text));
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

        private void LoadServiceType()
        {
            cboServiceType.DataSource = busServiceType.LoadServiceType().Tables[0];
            cboServiceType.DisplayMember = "ServiceType";
        }

        private bool CheckServiceExist(string idBook, string serviceName)
        {
            return busBillDetails.CheckServiceExist(idBook, serviceName);
        }
        #endregion

        #region Click & Events
        private void ServiceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboServiceType.SelectedValue.ToString() != null)
            {
                string serviceType = cboServiceType.Text;
                cboServiceName.DataSource = busService.LoadService(serviceType);
                cboServiceName.DisplayMember = "ServiceName";
                txtServicePrice.DataBindings.Clear();
                txtServicePrice.DataBindings.Add(new Binding("Text", cboServiceName.DataSource, "Price"));
            }
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

        private void BookClick(object sender, EventArgs e)
        {
            string idBook = ((sender as Guna.UI2.WinForms.Guna2Button).Tag as BookRoom_DTO).IdBook;
            string roomName = ((sender as Guna.UI2.WinForms.Guna2Button).Tag as BookRoom_DTO).RoomName;
            ShowBillDetails(idBook);
            ShowSumTotalPrice(idBook);
            txtIdBook.Text = idBook;
            txtRoomName.Text = roomName;
        }

        private void AddService_Click(object sender, EventArgs e)
        {
            if (txtRoomName.Text != "")
            {
                int totalCount;
                string roomName = txtRoomName.Text;
                string idBook = txtIdBook.Text;
                string serviceName = cboServiceName.Text;
                int count = Convert.ToInt32(nudCount.Value);
                int price = Convert.ToInt32(txtServicePrice.Text);
                if (count > 0)
                {
                    if (CheckServiceExist(idBook, serviceName))
                    {
                        txtOldCount.DataBindings.Clear();
                        txtOldCount.DataBindings.Add(new Binding("Text", busBillDetails.GetCountService(serviceName), "Count"));
                        int oldCount = Convert.ToInt32(txtOldCount.Text);
                        totalCount = count + oldCount;
                        busBillDetails.UpdateCountServiceBillDetails(idBook, serviceName, totalCount);
                        busBillDetails.UpdateTotalPriceServiceBillDetails(idBook, serviceName);
                        ShowBillDetails(idBook);
                        ShowSumTotalPrice(idBook);
                    }
                    else
                    {
                        totalPrice = count * price;
                        BillDetails_DTO billDetails = new BillDetails_DTO(idBook, serviceName, count, price, totalPrice);
                        busBillDetails.AddBillDetails(billDetails);
                        ShowBillDetails(idBook);
                        ShowSumTotalPrice(idBook);
                        MessageBox.Show("Phòng " + roomName + " thêm dịch vụ " + serviceName + " thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Số lượng dịch vụ không được nhỏ hơn 1.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn phòng cần thêm dịch vụ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Increase_Click(object sender, EventArgs e)
        {
            int totalCount;
            string idBook = txtIdBook.Text;
            string serviceName = cboServiceName.Text;
            int count = Convert.ToInt32(nudCount.Value);
            if (CheckServiceExist(idBook, serviceName))
            {
                txtOldCount.DataBindings.Clear();
                txtOldCount.DataBindings.Add(new Binding("Text", busBillDetails.GetCountService(serviceName), "Count"));
                int oldCount = Convert.ToInt32(txtOldCount.Text);
                totalCount = count + oldCount;
                busBillDetails.UpdateCountServiceBillDetails(idBook, serviceName, totalCount);
                busBillDetails.UpdateTotalPriceServiceBillDetails(idBook, serviceName);
                ShowBillDetails(idBook);
                ShowSumTotalPrice(idBook);
            }
        }

        private void Decrease_Click(object sender, EventArgs e)
        {
            int totalCount;
            string idBook = txtIdBook.Text;
            string serviceName = cboServiceName.Text;
            int count = Convert.ToInt32(nudCount.Value);
            if (CheckServiceExist(idBook, serviceName))
            {
                txtOldCount.DataBindings.Clear();
                txtOldCount.DataBindings.Add(new Binding("Text", busBillDetails.GetCountService(serviceName), "Count"));
                int oldCount = Convert.ToInt32(txtOldCount.Text);
                if (oldCount > count)
                {
                    totalCount = oldCount - count;
                    busBillDetails.UpdateCountServiceBillDetails(idBook, serviceName, totalCount);
                    busBillDetails.UpdateTotalPriceServiceBillDetails(idBook, serviceName);
                    ShowBillDetails(idBook);
                    ShowSumTotalPrice(idBook);
                }
                else
                {
                    MessageBox.Show("Không thể giảm số lượng dịch vụ " + serviceName + " nữa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void DeleteService_Click(object sender, EventArgs e)
        {
            if (txtRoomName.Text != "")
            {
                string roomName = txtRoomName.Text;
                string idBook = txtIdBook.Text;
                string serviceName = cboServiceName.Text;
                busBillDetails.DeleteServiceBillDetails(idBook, serviceName);
                ShowBillDetails(idBook);
                ShowSumTotalPrice(idBook);
                MessageBox.Show("Phòng " + roomName + " xóa dịch vụ " + serviceName + " thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bạn phải chọn phòng cần xóa dịch vụ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
    }
}
