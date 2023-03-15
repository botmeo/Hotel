using BUS;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace GUI
{
    public partial class FRevenue : Form
    {
        public string username;
        public string password;
        private readonly CultureInfo culture = new CultureInfo("vi-VN");
        private readonly CheckInput_BUS busCheckInput = new CheckInput_BUS();
        private readonly Bill_BUS busBill = new Bill_BUS();

        public FRevenue()
        {
            InitializeComponent();
        }

        #region Load, Get data & Method
        private void FRevenue_Load(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            int year = Convert.ToInt32(dateTime.Year.ToString());
            GetRevenue();
            GetRevenueOfYear(year);
            ShadowForm.SetShadowForm(this);
        }

        private void GetRevenue()
        {
            // Doanh thu phòng
            txtRoomRevenueHide.DataBindings.Clear();
            txtRoomRevenueHide.DataBindings.Add(new Binding("Text", busBill.GetRevenue("RoomPrice"), "Revenue"));
            if (txtRoomRevenueHide.Text != "")
            {
                int roomRevenue = Convert.ToInt32(txtRoomRevenueHide.Text);
                txtRoomRevenue.Text = String.Format(culture, "{0:c}", roomRevenue);
                chartRevenue.Series["Doanh thu"].Points.AddXY("Doanh thu phòng", roomRevenue);
            }
            else
            {
                txtRoomRevenue.Text = String.Format(culture, "{0:c}", 0);
                chartRevenue.Series["Doanh thu"].Points.AddXY("Doanh thu phòng", 0);
            }
            // Doanh thu dịch vụ
            txtServiceRevenueHide.DataBindings.Clear();
            txtServiceRevenueHide.DataBindings.Add(new Binding("Text", busBill.GetRevenue("ServicePrice"), "Revenue"));
            if (txtServiceRevenueHide.Text != "")
            {
                int serviceRevenue = Convert.ToInt32(txtServiceRevenueHide.Text);
                txtServiceRevenue.Text = String.Format(culture, "{0:c}", serviceRevenue);
                chartRevenue.Series["Doanh thu"].Points.AddXY("Doanh thu dịch vụ", serviceRevenue);
            }
            else
            {
                txtServiceRevenue.Text = String.Format(culture, "{0:c}", 0);
                chartRevenue.Series["Doanh thu"].Points.AddXY("Doanh thu dịch vụ", 0);
            }
            // Tổng doanh thu
            txtTotalRevenueHide.DataBindings.Clear();
            txtTotalRevenueHide.DataBindings.Add(new Binding("Text", busBill.GetRevenue("TotalPrice"), "Revenue"));
            if (txtTotalRevenueHide.Text != "")
            {
                int totalRevenue = Convert.ToInt32(txtTotalRevenueHide.Text);
                txtTotalRevenue.Text = String.Format(culture, "{0:c}", totalRevenue);
                chartRevenue.Series["Doanh thu"].Points.AddXY("Tổng doanh thu", totalRevenue);
            }
            else
            {
                txtTotalRevenue.Text = String.Format(culture, "{0:c}", 0);
                chartRevenue.Series["Doanh thu"].Points.AddXY("Tổng doanh thu", 0);
            }
        }

        private void GetRevenueOfYear(int year)
        {
            chartRevenueOfYear.Series["Doanh thu năm"].Points.Clear();
            // Doanh thu tháng 1
            txtJanuary.DataBindings.Clear();
            txtJanuary.DataBindings.Add(new Binding("Text", busBill.GetRevenueMonthOfYear(1, year), "Revenue"));
            if (txtJanuary.Text != "")
            {
                int revenue = Convert.ToInt32(txtJanuary.Text);
                chartRevenueOfYear.Series["Doanh thu năm"].Points.AddXY("Tháng 1", revenue);
                chartRevenueOfYear.Series["Doanh thu năm"].Points[0].Color = Color.Crimson;
            }
            else
            {
                chartRevenueOfYear.Series["Doanh thu năm"].Points.AddXY("Tháng 1", 0);
            }
            //Doanh thu tháng 2
            txtFebruary.DataBindings.Clear();
            txtFebruary.DataBindings.Add(new Binding("Text", busBill.GetRevenueMonthOfYear(2, year), "Revenue"));
            if (txtFebruary.Text != "")
            {
                int revenue = Convert.ToInt32(txtFebruary.Text);
                chartRevenueOfYear.Series["Doanh thu năm"].Points.AddXY("Tháng 2", revenue);
                chartRevenueOfYear.Series["Doanh thu năm"].Points[1].Color = Color.DarkSlateBlue;
            }
            else
            {
                chartRevenueOfYear.Series["Doanh thu năm"].Points.AddXY("Tháng 2", 0);
            }
            //Doanh thu tháng 3
            txtMarch.DataBindings.Clear();
            txtMarch.DataBindings.Add(new Binding("Text", busBill.GetRevenueMonthOfYear(3, year), "Revenue"));
            if (txtMarch.Text != "")
            {
                int revenue = Convert.ToInt32(txtMarch.Text);
                chartRevenueOfYear.Series["Doanh thu năm"].Points.AddXY("Tháng 3", revenue);
                chartRevenueOfYear.Series["Doanh thu năm"].Points[2].Color = Color.Gold;
            }
            else
            {
                chartRevenueOfYear.Series["Doanh thu năm"].Points.AddXY("Tháng 3", 0);
            }
            //Doanh thu tháng 4
            txtApril.DataBindings.Clear();
            txtApril.DataBindings.Add(new Binding("Text", busBill.GetRevenueMonthOfYear(4, year), "Revenue"));
            if (txtApril.Text != "")
            {
                int revenue = Convert.ToInt32(txtApril.Text);
                chartRevenueOfYear.Series["Doanh thu năm"].Points.AddXY("Tháng 4", revenue);
                chartRevenueOfYear.Series["Doanh thu năm"].Points[3].Color = Color.LimeGreen;
            }
            else
            {
                chartRevenueOfYear.Series["Doanh thu năm"].Points.AddXY("Tháng 4", 0);
            }
            //Doanh thu tháng 5
            txtMay.DataBindings.Clear();
            txtMay.DataBindings.Add(new Binding("Text", busBill.GetRevenueMonthOfYear(5, year), "Revenue"));
            if (txtMay.Text != "")
            {
                int revenue = Convert.ToInt32(txtMay.Text);
                chartRevenueOfYear.Series["Doanh thu năm"].Points.AddXY("Tháng 5", revenue);
                chartRevenueOfYear.Series["Doanh thu năm"].Points[4].Color = Color.Chocolate;
            }
            else
            {
                chartRevenueOfYear.Series["Doanh thu năm"].Points.AddXY("Tháng 5", 0);
            }
            //Doanh thu tháng 6
            txtJune.DataBindings.Clear();
            txtJune.DataBindings.Add(new Binding("Text", busBill.GetRevenueMonthOfYear(6, year), "Revenue"));
            if (txtJune.Text != "")
            {
                int revenue = Convert.ToInt32(txtJune.Text);
                chartRevenueOfYear.Series["Doanh thu năm"].Points.AddXY("Tháng 6", revenue);
                chartRevenueOfYear.Series["Doanh thu năm"].Points[5].Color = Color.CadetBlue;
            }
            else
            {
                chartRevenueOfYear.Series["Doanh thu năm"].Points.AddXY("Tháng 6", 0);
            }
            //Doanh thu tháng 7
            txtJuly.DataBindings.Clear();
            txtJuly.DataBindings.Add(new Binding("Text", busBill.GetRevenueMonthOfYear(7, year), "Revenue"));
            if (txtJuly.Text != "")
            {
                int revenue = Convert.ToInt32(txtJuly.Text);
                chartRevenueOfYear.Series["Doanh thu năm"].Points.AddXY("Tháng 7", revenue);
                chartRevenueOfYear.Series["Doanh thu năm"].Points[6].Color = Color.Tomato;
            }
            else
            {
                chartRevenueOfYear.Series["Doanh thu năm"].Points.AddXY("Tháng 7", 0);
            }
            //Doanh thu tháng 8
            txtAugust.DataBindings.Clear();
            txtAugust.DataBindings.Add(new Binding("Text", busBill.GetRevenueMonthOfYear(8, year), "Revenue"));
            if (txtAugust.Text != "")
            {
                int revenue = Convert.ToInt32(txtAugust.Text);
                chartRevenueOfYear.Series["Doanh thu năm"].Points.AddXY("Tháng 8", revenue);
                chartRevenueOfYear.Series["Doanh thu năm"].Points[7].Color = Color.DarkOliveGreen;
            }
            else
            {
                chartRevenueOfYear.Series["Doanh thu năm"].Points.AddXY("Tháng 8", 0);
            }
            //Doanh thu tháng 9
            txtSeptember.DataBindings.Clear();
            txtSeptember.DataBindings.Add(new Binding("Text", busBill.GetRevenueMonthOfYear(9, year), "Revenue"));
            if (txtSeptember.Text != "")
            {
                int revenue = Convert.ToInt32(txtSeptember.Text);
                chartRevenueOfYear.Series["Doanh thu năm"].Points.AddXY("Tháng 9", revenue);
                chartRevenueOfYear.Series["Doanh thu năm"].Points[8].Color = Color.BlueViolet;
            }
            else
            {
                chartRevenueOfYear.Series["Doanh thu năm"].Points.AddXY("Tháng 9", 0);
            }
            //Doanh thu tháng 10
            txtOctober.DataBindings.Clear();
            txtOctober.DataBindings.Add(new Binding("Text", busBill.GetRevenueMonthOfYear(10, year), "Revenue"));
            if (txtOctober.Text != "")
            {
                int revenue = Convert.ToInt32(txtOctober.Text);
                chartRevenueOfYear.Series["Doanh thu năm"].Points.AddXY("Tháng 10", revenue);
                chartRevenueOfYear.Series["Doanh thu năm"].Points[9].Color = Color.NavajoWhite;
            }
            else
            {
                chartRevenueOfYear.Series["Doanh thu năm"].Points.AddXY("Tháng 10", 0);
            }
            //Doanh thu tháng 11
            txtNovember.DataBindings.Clear();
            txtNovember.DataBindings.Add(new Binding("Text", busBill.GetRevenueMonthOfYear(11, year), "Revenue"));
            if (txtNovember.Text != "")
            {
                int revenue = Convert.ToInt32(txtNovember.Text);
                chartRevenueOfYear.Series["Doanh thu năm"].Points.AddXY("Tháng 11", revenue);
                chartRevenueOfYear.Series["Doanh thu năm"].Points[10].Color = Color.DimGray;
            }
            else
            {
                chartRevenueOfYear.Series["Doanh thu năm"].Points.AddXY("Tháng 11", 0);
            }
            //Doanh thu tháng 12
            txtDecember.DataBindings.Clear();
            txtDecember.DataBindings.Add(new Binding("Text", busBill.GetRevenueMonthOfYear(12, year), "Revenue"));
            if (txtDecember.Text != "")
            {
                int revenue = Convert.ToInt32(txtDecember.Text);
                chartRevenueOfYear.Series["Doanh thu năm"].Points.AddXY("Tháng 12", revenue);
                chartRevenueOfYear.Series["Doanh thu"].Points[11].Color = Color.GreenYellow;
            }
            else
            {
                chartRevenueOfYear.Series["Doanh thu năm"].Points.AddXY("Tháng 12", 0);
            }
            //Doanh thu năm
            txtRevenueYear.DataBindings.Clear();
            txtRevenueYear.DataBindings.Add(new Binding("Text", busBill.GetRevenueOfYear(year), "Revenue"));
            if (txtRevenueYear.Text != "")
            {
                int revenue = Convert.ToInt32(txtRevenueYear.Text);
                chartRevenueOfYear.Series["Doanh thu năm"].Points.AddXY("Doanh thu năm", revenue);
            }
            else
            {
                chartRevenueOfYear.Series["Doanh thu năm"].Points.AddXY("Doanh thu năm", 0);
            }
        }
        #endregion

        #region Check input data
        private void Year_KeyPress(object sender, KeyPressEventArgs e)
        {
            busCheckInput.CheckNumber(e);
        }
        #endregion

        # region Click & Events
        private void Year_OnValueChanged(object sender, EventArgs e)
        {
            if (txtYear.Text != "")
            {
                int year = Convert.ToInt32(txtYear.Text);
                GetRevenueOfYear(year);
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

        private void Search_Click(object sender, EventArgs e)
        {
            if (txtYear.Text != "")
            {
                int year = Convert.ToInt32(txtYear.Text);
                GetRevenueOfYear(year);
            }
        }
        #endregion
    }
}
