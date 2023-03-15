
namespace GUI
{
    partial class FHotelManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FHotelManagement));
            this.lblWind = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblHumidity = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_Minimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnRegulations = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnRevenue = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2TileButton2 = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnBill = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnCustomer = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnToBook = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnPay = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnCheckIn = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnService = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnRoom = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnStaff = new Guna.UI2.WinForms.Guna2TileButton();
            this.lblTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblGreeting = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnAccount = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHelp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnInfo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbl_NameHotel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnLogout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Chip = new Guna.UI2.WinForms.Guna2Chip();
            this.btn_Close = new Guna.UI2.WinForms.Guna2ControlBox();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.lblTemp = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Time = new System.Windows.Forms.Timer(this.components);
            this.ShadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CountDown = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblWind
            // 
            this.lblWind.BackColor = System.Drawing.Color.Transparent;
            this.lblWind.Enabled = false;
            this.lblWind.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWind.ForeColor = System.Drawing.Color.DimGray;
            this.lblWind.Location = new System.Drawing.Point(1121, 145);
            this.lblWind.Name = "lblWind";
            this.lblWind.Size = new System.Drawing.Size(29, 23);
            this.lblWind.TabIndex = 101;
            this.lblWind.Text = "Gió";
            this.lblWind.Visible = false;
            // 
            // lblHumidity
            // 
            this.lblHumidity.BackColor = System.Drawing.Color.Transparent;
            this.lblHumidity.Enabled = false;
            this.lblHumidity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumidity.ForeColor = System.Drawing.Color.DimGray;
            this.lblHumidity.Location = new System.Drawing.Point(1121, 116);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(53, 23);
            this.lblHumidity.TabIndex = 100;
            this.lblHumidity.Text = "Độ ẩm";
            this.lblHumidity.Visible = false;
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btn_Minimize.FillColor = System.Drawing.Color.White;
            this.btn_Minimize.HoverState.Parent = this.btn_Minimize;
            this.btn_Minimize.IconColor = System.Drawing.Color.Black;
            this.btn_Minimize.Location = new System.Drawing.Point(1243, 3);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.ShadowDecoration.Parent = this.btn_Minimize;
            this.btn_Minimize.Size = new System.Drawing.Size(45, 29);
            this.btn_Minimize.TabIndex = 98;
            // 
            // btnRegulations
            // 
            this.btnRegulations.Animated = true;
            this.btnRegulations.BackColor = System.Drawing.Color.Transparent;
            this.btnRegulations.BorderColor = System.Drawing.Color.White;
            this.btnRegulations.BorderRadius = 5;
            this.btnRegulations.CheckedState.Parent = this.btnRegulations;
            this.btnRegulations.CustomImages.Parent = this.btnRegulations;
            this.btnRegulations.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnRegulations.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegulations.ForeColor = System.Drawing.Color.White;
            this.btnRegulations.HoverState.Parent = this.btnRegulations;
            this.btnRegulations.Image = ((System.Drawing.Image)(resources.GetObject("btnRegulations.Image")));
            this.btnRegulations.ImageOffset = new System.Drawing.Point(0, 15);
            this.btnRegulations.ImageSize = new System.Drawing.Size(64, 64);
            this.btnRegulations.Location = new System.Drawing.Point(957, 372);
            this.btnRegulations.Name = "btnRegulations";
            this.btnRegulations.PressedDepth = 40;
            this.btnRegulations.ShadowDecoration.Parent = this.btnRegulations;
            this.btnRegulations.Size = new System.Drawing.Size(346, 170);
            this.btnRegulations.TabIndex = 96;
            this.btnRegulations.Text = "Quy định";
            this.btnRegulations.TextOffset = new System.Drawing.Point(0, 15);
            this.btnRegulations.Click += new System.EventHandler(this.Regulations_Click);
            // 
            // btnRevenue
            // 
            this.btnRevenue.Animated = true;
            this.btnRevenue.BackColor = System.Drawing.Color.Transparent;
            this.btnRevenue.BorderColor = System.Drawing.Color.White;
            this.btnRevenue.BorderRadius = 5;
            this.btnRevenue.CheckedState.Parent = this.btnRevenue;
            this.btnRevenue.CustomImages.Parent = this.btnRevenue;
            this.btnRevenue.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnRevenue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevenue.ForeColor = System.Drawing.Color.White;
            this.btnRevenue.HoverState.Parent = this.btnRevenue;
            this.btnRevenue.Image = ((System.Drawing.Image)(resources.GetObject("btnRevenue.Image")));
            this.btnRevenue.ImageOffset = new System.Drawing.Point(0, 15);
            this.btnRevenue.ImageSize = new System.Drawing.Size(64, 64);
            this.btnRevenue.Location = new System.Drawing.Point(605, 548);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.PressedDepth = 40;
            this.btnRevenue.ShadowDecoration.Parent = this.btnRevenue;
            this.btnRevenue.Size = new System.Drawing.Size(346, 170);
            this.btnRevenue.TabIndex = 95;
            this.btnRevenue.Text = "Thống kê doanh thu";
            this.btnRevenue.TextOffset = new System.Drawing.Point(0, 15);
            this.btnRevenue.Click += new System.EventHandler(this.Revenue_Click);
            // 
            // guna2TileButton2
            // 
            this.guna2TileButton2.Animated = true;
            this.guna2TileButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2TileButton2.BorderColor = System.Drawing.Color.White;
            this.guna2TileButton2.BorderRadius = 5;
            this.guna2TileButton2.CheckedState.Parent = this.guna2TileButton2;
            this.guna2TileButton2.CustomImages.Parent = this.guna2TileButton2;
            this.guna2TileButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.guna2TileButton2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TileButton2.ForeColor = System.Drawing.Color.White;
            this.guna2TileButton2.HoverState.Parent = this.guna2TileButton2;
            this.guna2TileButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2TileButton2.Image")));
            this.guna2TileButton2.ImageOffset = new System.Drawing.Point(0, 15);
            this.guna2TileButton2.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2TileButton2.Location = new System.Drawing.Point(957, 196);
            this.guna2TileButton2.Name = "guna2TileButton2";
            this.guna2TileButton2.PressedDepth = 40;
            this.guna2TileButton2.ShadowDecoration.Parent = this.guna2TileButton2;
            this.guna2TileButton2.Size = new System.Drawing.Size(346, 170);
            this.guna2TileButton2.TabIndex = 94;
            this.guna2TileButton2.Text = "Phân quyền nhân viên";
            this.guna2TileButton2.TextOffset = new System.Drawing.Point(0, 15);
            this.guna2TileButton2.Click += new System.EventHandler(this.guna2TileButton2_Click);
            // 
            // btnBill
            // 
            this.btnBill.Animated = true;
            this.btnBill.BackColor = System.Drawing.Color.Transparent;
            this.btnBill.BorderColor = System.Drawing.Color.White;
            this.btnBill.BorderRadius = 5;
            this.btnBill.CheckedState.Parent = this.btnBill;
            this.btnBill.CustomImages.Parent = this.btnBill;
            this.btnBill.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnBill.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.ForeColor = System.Drawing.Color.White;
            this.btnBill.HoverState.Parent = this.btnBill;
            this.btnBill.Image = ((System.Drawing.Image)(resources.GetObject("btnBill.Image")));
            this.btnBill.ImageOffset = new System.Drawing.Point(0, 15);
            this.btnBill.ImageSize = new System.Drawing.Size(64, 64);
            this.btnBill.Location = new System.Drawing.Point(253, 548);
            this.btnBill.Name = "btnBill";
            this.btnBill.PressedDepth = 40;
            this.btnBill.ShadowDecoration.Parent = this.btnBill;
            this.btnBill.Size = new System.Drawing.Size(346, 170);
            this.btnBill.TabIndex = 93;
            this.btnBill.Text = "Quản lý hóa đơn";
            this.btnBill.TextOffset = new System.Drawing.Point(0, 15);
            this.btnBill.Click += new System.EventHandler(this.Bill_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Animated = true;
            this.btnCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomer.BorderColor = System.Drawing.Color.White;
            this.btnCustomer.BorderRadius = 5;
            this.btnCustomer.CheckedState.Parent = this.btnCustomer;
            this.btnCustomer.CustomImages.Parent = this.btnCustomer;
            this.btnCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnCustomer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.HoverState.Parent = this.btnCustomer;
            this.btnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Image")));
            this.btnCustomer.ImageOffset = new System.Drawing.Point(0, 15);
            this.btnCustomer.ImageSize = new System.Drawing.Size(64, 64);
            this.btnCustomer.Location = new System.Drawing.Point(605, 372);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.PressedDepth = 40;
            this.btnCustomer.ShadowDecoration.Parent = this.btnCustomer;
            this.btnCustomer.Size = new System.Drawing.Size(170, 170);
            this.btnCustomer.TabIndex = 92;
            this.btnCustomer.Text = "Quản lý khách hàng";
            this.btnCustomer.TextOffset = new System.Drawing.Point(0, 15);
            this.btnCustomer.Click += new System.EventHandler(this.Customer_Click);
            // 
            // btnToBook
            // 
            this.btnToBook.Animated = true;
            this.btnToBook.BackColor = System.Drawing.Color.Transparent;
            this.btnToBook.BorderColor = System.Drawing.Color.White;
            this.btnToBook.BorderRadius = 5;
            this.btnToBook.CheckedState.Parent = this.btnToBook;
            this.btnToBook.CustomImages.Parent = this.btnToBook;
            this.btnToBook.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnToBook.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToBook.ForeColor = System.Drawing.Color.White;
            this.btnToBook.HoverState.Parent = this.btnToBook;
            this.btnToBook.Image = ((System.Drawing.Image)(resources.GetObject("btnToBook.Image")));
            this.btnToBook.ImageOffset = new System.Drawing.Point(0, 15);
            this.btnToBook.ImageSize = new System.Drawing.Size(64, 64);
            this.btnToBook.Location = new System.Drawing.Point(253, 196);
            this.btnToBook.Name = "btnToBook";
            this.btnToBook.PressedDepth = 40;
            this.btnToBook.ShadowDecoration.Parent = this.btnToBook;
            this.btnToBook.Size = new System.Drawing.Size(170, 170);
            this.btnToBook.TabIndex = 91;
            this.btnToBook.Text = "Đặt phòng";
            this.btnToBook.TextOffset = new System.Drawing.Point(0, 15);
            this.btnToBook.Click += new System.EventHandler(this.ToBook_Click);
            // 
            // btnPay
            // 
            this.btnPay.Animated = true;
            this.btnPay.BackColor = System.Drawing.Color.Transparent;
            this.btnPay.BorderColor = System.Drawing.Color.White;
            this.btnPay.BorderRadius = 5;
            this.btnPay.CheckedState.Parent = this.btnPay;
            this.btnPay.CustomImages.Parent = this.btnPay;
            this.btnPay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.HoverState.Parent = this.btnPay;
            this.btnPay.Image = ((System.Drawing.Image)(resources.GetObject("btnPay.Image")));
            this.btnPay.ImageOffset = new System.Drawing.Point(0, 15);
            this.btnPay.ImageSize = new System.Drawing.Size(64, 64);
            this.btnPay.Location = new System.Drawing.Point(254, 372);
            this.btnPay.Name = "btnPay";
            this.btnPay.PressedDepth = 40;
            this.btnPay.ShadowDecoration.Parent = this.btnPay;
            this.btnPay.Size = new System.Drawing.Size(345, 170);
            this.btnPay.TabIndex = 90;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.TextOffset = new System.Drawing.Point(0, 15);
            this.btnPay.Click += new System.EventHandler(this.Pay_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Animated = true;
            this.btnCheckIn.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckIn.BorderColor = System.Drawing.Color.White;
            this.btnCheckIn.BorderRadius = 5;
            this.btnCheckIn.CheckedState.Parent = this.btnCheckIn;
            this.btnCheckIn.CustomImages.Parent = this.btnCheckIn;
            this.btnCheckIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnCheckIn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnCheckIn.HoverState.Parent = this.btnCheckIn;
            this.btnCheckIn.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckIn.Image")));
            this.btnCheckIn.ImageOffset = new System.Drawing.Point(0, 15);
            this.btnCheckIn.ImageSize = new System.Drawing.Size(64, 64);
            this.btnCheckIn.Location = new System.Drawing.Point(429, 196);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.PressedDepth = 40;
            this.btnCheckIn.ShadowDecoration.Parent = this.btnCheckIn;
            this.btnCheckIn.Size = new System.Drawing.Size(170, 170);
            this.btnCheckIn.TabIndex = 89;
            this.btnCheckIn.Text = "Nhận phòng";
            this.btnCheckIn.TextOffset = new System.Drawing.Point(0, 15);
            this.btnCheckIn.Click += new System.EventHandler(this.CheckIn_Click);
            // 
            // btnService
            // 
            this.btnService.Animated = true;
            this.btnService.BackColor = System.Drawing.Color.Transparent;
            this.btnService.BorderColor = System.Drawing.Color.White;
            this.btnService.BorderRadius = 5;
            this.btnService.CheckedState.Parent = this.btnService;
            this.btnService.CustomImages.Parent = this.btnService;
            this.btnService.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnService.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnService.ForeColor = System.Drawing.Color.White;
            this.btnService.HoverState.Parent = this.btnService;
            this.btnService.Image = ((System.Drawing.Image)(resources.GetObject("btnService.Image")));
            this.btnService.ImageOffset = new System.Drawing.Point(0, 15);
            this.btnService.ImageSize = new System.Drawing.Size(64, 64);
            this.btnService.Location = new System.Drawing.Point(781, 372);
            this.btnService.Name = "btnService";
            this.btnService.PressedDepth = 40;
            this.btnService.ShadowDecoration.Parent = this.btnService;
            this.btnService.Size = new System.Drawing.Size(170, 170);
            this.btnService.TabIndex = 88;
            this.btnService.Text = "Dịch vụ & Tiện ích";
            this.btnService.TextOffset = new System.Drawing.Point(0, 15);
            this.btnService.Click += new System.EventHandler(this.Service_Click);
            // 
            // btnRoom
            // 
            this.btnRoom.Animated = true;
            this.btnRoom.BackColor = System.Drawing.Color.Transparent;
            this.btnRoom.BorderColor = System.Drawing.Color.White;
            this.btnRoom.BorderRadius = 5;
            this.btnRoom.CheckedState.Parent = this.btnRoom;
            this.btnRoom.CustomImages.Parent = this.btnRoom;
            this.btnRoom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnRoom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoom.ForeColor = System.Drawing.Color.White;
            this.btnRoom.HoverState.Parent = this.btnRoom;
            this.btnRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnRoom.Image")));
            this.btnRoom.ImageOffset = new System.Drawing.Point(0, 15);
            this.btnRoom.ImageSize = new System.Drawing.Size(64, 64);
            this.btnRoom.Location = new System.Drawing.Point(781, 196);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.PressedDepth = 40;
            this.btnRoom.ShadowDecoration.Parent = this.btnRoom;
            this.btnRoom.Size = new System.Drawing.Size(170, 170);
            this.btnRoom.TabIndex = 87;
            this.btnRoom.Text = "Quản lý phòng";
            this.btnRoom.TextOffset = new System.Drawing.Point(0, 15);
            this.btnRoom.Click += new System.EventHandler(this.Room_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Animated = true;
            this.btnStaff.BorderColor = System.Drawing.Color.White;
            this.btnStaff.BorderRadius = 5;
            this.btnStaff.CheckedState.Parent = this.btnStaff;
            this.btnStaff.CustomImages.Parent = this.btnStaff;
            this.btnStaff.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnStaff.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.Color.White;
            this.btnStaff.HoverState.Parent = this.btnStaff;
            this.btnStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnStaff.Image")));
            this.btnStaff.ImageOffset = new System.Drawing.Point(0, 15);
            this.btnStaff.ImageSize = new System.Drawing.Size(64, 64);
            this.btnStaff.Location = new System.Drawing.Point(605, 196);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.PressedDepth = 40;
            this.btnStaff.ShadowDecoration.Parent = this.btnStaff;
            this.btnStaff.Size = new System.Drawing.Size(170, 170);
            this.btnStaff.TabIndex = 86;
            this.btnStaff.Text = "Quản lý nhân viên";
            this.btnStaff.TextOffset = new System.Drawing.Point(0, 15);
            this.btnStaff.Click += new System.EventHandler(this.Staff_Click);
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Enabled = false;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.DimGray;
            this.lblTime.Location = new System.Drawing.Point(254, 116);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(73, 23);
            this.lblTime.TabIndex = 85;
            this.lblTime.Text = "Ngày giờ";
            // 
            // lblGreeting
            // 
            this.lblGreeting.BackColor = System.Drawing.Color.Transparent;
            this.lblGreeting.Enabled = false;
            this.lblGreeting.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.ForeColor = System.Drawing.Color.DimGray;
            this.lblGreeting.Location = new System.Drawing.Point(254, 145);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(96, 23);
            this.lblGreeting.TabIndex = 84;
            this.lblGreeting.Text = "Lời chào hỏi";
            // 
            // btnAccount
            // 
            this.btnAccount.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAccount.BorderRadius = 0;
            this.btnAccount.ButtonText = "Tài khoản";
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnAccount.DisabledColor = System.Drawing.Color.Gray;
            this.btnAccount.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAccount.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAccount.Iconimage")));
            this.btnAccount.Iconimage_right = null;
            this.btnAccount.Iconimage_right_Selected = null;
            this.btnAccount.Iconimage_Selected = null;
            this.btnAccount.IconMarginLeft = 30;
            this.btnAccount.IconMarginRight = 0;
            this.btnAccount.IconRightVisible = true;
            this.btnAccount.IconRightZoom = 0D;
            this.btnAccount.IconVisible = true;
            this.btnAccount.IconZoom = 90D;
            this.btnAccount.IsTab = false;
            this.btnAccount.Location = new System.Drawing.Point(0, 521);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnAccount.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnAccount.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAccount.selected = false;
            this.btnAccount.Size = new System.Drawing.Size(210, 45);
            this.btnAccount.TabIndex = 83;
            this.btnAccount.Text = "Tài khoản";
            this.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.Textcolor = System.Drawing.Color.White;
            this.btnAccount.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.Click += new System.EventHandler(this.Account_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelp.BorderRadius = 0;
            this.btnHelp.ButtonText = "Trợ giúp";
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnHelp.DisabledColor = System.Drawing.Color.Gray;
            this.btnHelp.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHelp.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHelp.Iconimage")));
            this.btnHelp.Iconimage_right = null;
            this.btnHelp.Iconimage_right_Selected = null;
            this.btnHelp.Iconimage_Selected = null;
            this.btnHelp.IconMarginLeft = 30;
            this.btnHelp.IconMarginRight = 0;
            this.btnHelp.IconRightVisible = true;
            this.btnHelp.IconRightZoom = 0D;
            this.btnHelp.IconVisible = true;
            this.btnHelp.IconZoom = 90D;
            this.btnHelp.IsTab = false;
            this.btnHelp.Location = new System.Drawing.Point(0, 572);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnHelp.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnHelp.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHelp.selected = false;
            this.btnHelp.Size = new System.Drawing.Size(210, 45);
            this.btnHelp.TabIndex = 82;
            this.btnHelp.Text = "Trợ giúp";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Textcolor = System.Drawing.Color.White;
            this.btnHelp.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Click += new System.EventHandler(this.Help_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInfo.BorderRadius = 0;
            this.btnInfo.ButtonText = "Thông tin";
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnInfo.DisabledColor = System.Drawing.Color.Gray;
            this.btnInfo.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInfo.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnInfo.Iconimage")));
            this.btnInfo.Iconimage_right = null;
            this.btnInfo.Iconimage_right_Selected = null;
            this.btnInfo.Iconimage_Selected = null;
            this.btnInfo.IconMarginLeft = 30;
            this.btnInfo.IconMarginRight = 0;
            this.btnInfo.IconRightVisible = true;
            this.btnInfo.IconRightZoom = 0D;
            this.btnInfo.IconVisible = true;
            this.btnInfo.IconZoom = 90D;
            this.btnInfo.IsTab = false;
            this.btnInfo.Location = new System.Drawing.Point(0, 623);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnInfo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnInfo.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInfo.selected = false;
            this.btnInfo.Size = new System.Drawing.Size(210, 45);
            this.btnInfo.TabIndex = 81;
            this.btnInfo.Text = "Thông tin";
            this.btnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.Textcolor = System.Drawing.Color.White;
            this.btnInfo.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.Click += new System.EventHandler(this.Info_Click);
            // 
            // lbl_NameHotel
            // 
            this.lbl_NameHotel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NameHotel.Enabled = false;
            this.lbl_NameHotel.Font = new System.Drawing.Font("Segoe UI Black", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NameHotel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.lbl_NameHotel.Location = new System.Drawing.Point(253, 50);
            this.lbl_NameHotel.Name = "lbl_NameHotel";
            this.lbl_NameHotel.Size = new System.Drawing.Size(408, 64);
            this.lbl_NameHotel.TabIndex = 80;
            this.lbl_NameHotel.Text = "Khách sạn Liberty";
            // 
            // btnLogout
            // 
            this.btnLogout.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.BorderRadius = 0;
            this.btnLogout.ButtonText = "Đăng xuất ";
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnLogout.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogout.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogout.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLogout.Iconimage")));
            this.btnLogout.Iconimage_right = null;
            this.btnLogout.Iconimage_right_Selected = null;
            this.btnLogout.Iconimage_Selected = null;
            this.btnLogout.IconMarginLeft = 30;
            this.btnLogout.IconMarginRight = 0;
            this.btnLogout.IconRightVisible = true;
            this.btnLogout.IconRightZoom = 0D;
            this.btnLogout.IconVisible = true;
            this.btnLogout.IconZoom = 90D;
            this.btnLogout.IsTab = false;
            this.btnLogout.Location = new System.Drawing.Point(0, 674);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnLogout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnLogout.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogout.selected = false;
            this.btnLogout.Size = new System.Drawing.Size(210, 45);
            this.btnLogout.TabIndex = 79;
            this.btnLogout.Text = "Đăng xuất ";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Textcolor = System.Drawing.Color.White;
            this.btnLogout.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Chip
            // 
            this.Chip.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.Chip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Chip.ForeColor = System.Drawing.Color.White;
            this.Chip.Location = new System.Drawing.Point(0, 0);
            this.Chip.Name = "Chip";
            this.Chip.ShadowDecoration.Parent = this.Chip;
            this.Chip.Size = new System.Drawing.Size(210, 761);
            this.Chip.TabIndex = 78;
            this.Chip.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.FillColor = System.Drawing.Color.White;
            this.btn_Close.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.btn_Close.HoverState.IconColor = System.Drawing.Color.White;
            this.btn_Close.HoverState.Parent = this.btn_Close;
            this.btn_Close.IconColor = System.Drawing.Color.Black;
            this.btn_Close.Location = new System.Drawing.Point(1294, 3);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.PressedColor = System.Drawing.Color.Transparent;
            this.btn_Close.ShadowDecoration.Parent = this.btn_Close;
            this.btn_Close.Size = new System.Drawing.Size(45, 30);
            this.btn_Close.TabIndex = 77;
            // 
            // DragControl
            // 
            this.DragControl.ContainerControl = this;
            this.DragControl.TargetControl = this;
            // 
            // lblTemp
            // 
            this.lblTemp.BackColor = System.Drawing.Color.Transparent;
            this.lblTemp.Enabled = false;
            this.lblTemp.Font = new System.Drawing.Font("Segoe UI Black", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.lblTemp.Location = new System.Drawing.Point(1030, 107);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(55, 61);
            this.lblTemp.TabIndex = 99;
            this.lblTemp.Text = "20";
            this.lblTemp.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTemp.Visible = false;
            // 
            // Time
            // 
            this.Time.Enabled = true;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Enabled = false;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(1082, 116);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(24, 32);
            this.guna2HtmlLabel1.TabIndex = 102;
            this.guna2HtmlLabel1.Text = "°C";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.guna2HtmlLabel1.Visible = false;
            // 
            // CountDown
            // 
            this.CountDown.Tick += new System.EventHandler(this.CountDown_Tick);
            // 
            // FHotelManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1340, 760);
            this.Controls.Add(this.lblWind);
            this.Controls.Add(this.lblHumidity);
            this.Controls.Add(this.btn_Minimize);
            this.Controls.Add(this.btnRegulations);
            this.Controls.Add(this.btnRevenue);
            this.Controls.Add(this.guna2TileButton2);
            this.Controls.Add(this.btnBill);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnToBook);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.btnService);
            this.Controls.Add(this.btnRoom);
            this.Controls.Add(this.btnStaff);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.lbl_NameHotel);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.Chip);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FHotelManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FHotelManagement";
            this.Load += new System.EventHandler(this.FHotelManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblWind;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblHumidity;
        private Guna.UI2.WinForms.Guna2ControlBox btn_Minimize;
        private Guna.UI2.WinForms.Guna2TileButton btnRegulations;
        private Guna.UI2.WinForms.Guna2TileButton btnRevenue;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton2;
        private Guna.UI2.WinForms.Guna2TileButton btnBill;
        private Guna.UI2.WinForms.Guna2TileButton btnCustomer;
        private Guna.UI2.WinForms.Guna2TileButton btnToBook;
        private Guna.UI2.WinForms.Guna2TileButton btnPay;
        private Guna.UI2.WinForms.Guna2TileButton btnCheckIn;
        private Guna.UI2.WinForms.Guna2TileButton btnService;
        private Guna.UI2.WinForms.Guna2TileButton btnRoom;
        private Guna.UI2.WinForms.Guna2TileButton btnStaff;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTime;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblGreeting;
        private Bunifu.Framework.UI.BunifuFlatButton btnAccount;
        private Bunifu.Framework.UI.BunifuFlatButton btnHelp;
        private Bunifu.Framework.UI.BunifuFlatButton btnInfo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_NameHotel;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogout;
        private Guna.UI2.WinForms.Guna2Chip Chip;
        private Guna.UI2.WinForms.Guna2ControlBox btn_Close;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTemp;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.Timer Time;
        private Guna.UI2.WinForms.Guna2ShadowForm ShadowForm;
        private System.Windows.Forms.Timer CountDown;
    }
}