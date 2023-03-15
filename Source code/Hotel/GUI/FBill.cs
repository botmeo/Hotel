using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace GUI
{
    public partial class FBill : Form
    {
        public string username;
        public string password;
        private readonly CultureInfo culture = new CultureInfo("vi-VN");
        private readonly Account_BUS busAccount = new Account_BUS();
        private readonly Bill_BUS busBill = new Bill_BUS();
        private readonly BillDetails_BUS busBillDetails = new BillDetails_BUS();
        private readonly Encode_BUS busEncode = new Encode_BUS();
        private readonly ExportToExcel_BUS busExportExcel = new ExportToExcel_BUS();

        public FBill()
        {
            InitializeComponent();
        }

        #region Load, Get data & Method
        private void FBill_Load(object sender, EventArgs e)
        {
            RefreshData();
            ShadowForm.SetShadowForm(this);
        }

        private void RefreshData()
        {
            dgvBill.DataSource = busBill.GetBill();
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

        private void Bill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            string idBill = dgvBill.Rows[dong].Cells[1].Value.ToString();
            txtIdBill.Text = idBill;
            ShowBillDetails(idBill);
            txtRoomPrice.Text = String.Format(culture, "{0:c}", Convert.ToInt32(dgvBill.Rows[dong].Cells[2].Value.ToString()));
            txtServicePrice.Text = String.Format(culture, "{0:c}", Convert.ToInt32(dgvBill.Rows[dong].Cells[3].Value.ToString()));
            txtSurcharge.Text = dgvBill.Rows[dong].Cells[4].Value.ToString();
            txtDiscount.Text = dgvBill.Rows[dong].Cells[5].Value.ToString();
            txtTotalMoney.Text = String.Format(culture, "{0:c}", Convert.ToInt32(dgvBill.Rows[dong].Cells[6].Value.ToString()));
            dtmDateCreated.Text = dgvBill.Rows[dong].Cells[7].Value.ToString();
            string staff = dgvBill.Rows[dong].Cells[8].Value.ToString();
            txtIdStaff.DataBindings.Clear();
            txtIdStaff.DataBindings.Add(new Binding("Text", busAccount.GetIdStaff(busEncode.Encrypt(staff)), "IdStaff"));
        }

        private void Export_Click(object sender, EventArgs e)
        {
            if (dgvBill.SelectedRows.Count > 0)
            {
                DataGridView datagridview = dgvBill;
                busExportExcel.ExportExcel(datagridview);
            }
            else
            {
                MessageBox.Show("Không thể xuất danh sách hóa đơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
    }
}
