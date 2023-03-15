using BUS;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FHotelManagement : Form
    {
        public string username;
        public string password;
        private int seconds = 0;
        private readonly Weather_BUS busWeather = new Weather_BUS();

        public FHotelManagement()
        {
            InitializeComponent();
            seconds = 75;
            CountDown.Start();
        }

        private void LoadTime()
        {
            DateTime day_hour = DateTime.Now;
            string am_pm = day_hour.ToString("tt");
            int hour = Convert.ToInt32(day_hour.ToString("HH"));
            if (am_pm == "AM")
            {
                lblGreeting.Text = "Good morning";
            }
            else
            {
                if (hour > 19)
                {
                    lblGreeting.Text = "Have a good night";
                }
                else
                {
                    lblGreeting.Text = "Good afternoon";
                }
            }
            lblTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm tt");
            Time.Start();
        }

       /* private void LoadWeather()
        {
            var tuple = busWeather.Weather();
            lblTemp.Text = tuple.Item1;
            lblHumidity.Text = "Độ ẩm: " + tuple.Item2 + "%";
            lblWind.Text = "Gió: " + tuple.Item3 + " m/s";
        }*/

        private void FHotelManagement_Load(object sender, EventArgs e)
        {
            LoadTime();
            /*LoadWeather();*/
            ShadowForm.SetShadowForm(this);
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            FLogin login = new FLogin();
            login.Show();
            Hide();
        }

        private void Info_Click(object sender, EventArgs e)
        {
            /*FInfo info = new FInfo();
            info.Show();*/
        }

        private void Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Liên hệ bộ phận IT để nhận trợ giúp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void Staff_Click(object sender, EventArgs e)
        {
            FStaff fStaff = new FStaff
            {
                username = username,
                password = password
            };
            fStaff.Show();
            Hide();
        }

        private void Room_Click(object sender, EventArgs e)
        {
            FRoom fRoom = new FRoom
            {
                username = username,
                password = password
            };
            fRoom.Show();
            Hide();
        }

        private void Service_Click(object sender, EventArgs e)
        {
            FService fService = new FService
            {
                username = username,
                password = password
            };
            fService.Show();
            Hide();
        }

        private void Customer_Click(object sender, EventArgs e)
        {
            FCustomer fCustomer = new FCustomer
            {
                username = username,
                password = password
            };
            fCustomer.Show();
            Hide();
        }

        private void ToBook_Click(object sender, EventArgs e)
        {
            FToBook fTobook = new FToBook
            {
                username = username,
                password = password
            };
            fTobook.Show();
            Hide();
        }

        private void CheckIn_Click(object sender, EventArgs e)
        {
            FCheckIn fCheckin = new FCheckIn
            {
                username = username,
                password = password
            };
            fCheckin.Show();
            Hide();
        }

        private void Regulations_Click(object sender, EventArgs e)
        {
            /*FRegulation fRegulations = new FRegulation();
            fRegulations.Show();
            Hide();*/
            MessageBox.Show("Tính năng đang phát triển.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void AccountManagement_Click(object sender, EventArgs e)
        {
            /* AccountManagement account = new AccountManagement();
             account.Show();
             Hide();*/
        }

        private void Account_Click(object sender, EventArgs e)
        {
            FAccount fAccount = new FAccount
            {
                username = username,
                password = password
            };
            fAccount.Show();
            Hide();
        }

        private void Pay_Click(object sender, EventArgs e)
        {
            FPay fPay = new FPay
            {
                username = username,
                password = password
            };
            fPay.Show();
            Hide();
        }

        private void CountDown_Tick(object sender, EventArgs e)
        {
            seconds--;
            if (seconds == 0)
            {
                lblGreeting.Text = null;
            }
        }

        private void Bill_Click(object sender, EventArgs e)
        {
            FBill fBill = new FBill
            {
                username = username,
                password = password
            };
            fBill.Show();
            Hide();
        }

        private void Revenue_Click(object sender, EventArgs e)
        {
            FRevenue fRevenue = new FRevenue
            {
                username = username,
                password = password
            };
            fRevenue.Show();
            Hide();
        }

        private void guna2TileButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng đang phát triển.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
