
namespace GUI
{
    partial class FPay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPay));
            this.btnReturn = new Guna.UI2.WinForms.Guna2Button();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.grpRoomBookList = new System.Windows.Forms.GroupBox();
            this.flpBookList = new System.Windows.Forms.FlowLayoutPanel();
            this.grpServiceRoom = new System.Windows.Forms.GroupBox();
            this.lsvBillDetails = new System.Windows.Forms.ListView();
            this.colService = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsvRegulations = new System.Windows.Forms.ListView();
            this.colRegulationsName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCoefficient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCompletePayment = new Guna.UI2.WinForms.Guna2Button();
            this.txtSurcharge = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnViewDetails = new Guna.UI2.WinForms.Guna2Button();
            this.btnPayOff = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTotalMoney = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtDiscount = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblDiscount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTotalServicePrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTotalServicePrice = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblRoomPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtRoomPrice = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.ShadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.txtRoomPriceHide = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTotalServicePriceHide = new Guna.UI2.WinForms.Guna2TextBox();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.txtRoomName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIdBook = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTotalMoneyHide = new Guna.UI2.WinForms.Guna2TextBox();
            this.grpRoomBookList.SuspendLayout();
            this.grpServiceRoom.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.CheckedState.Parent = this.btnReturn;
            this.btnReturn.CustomImages.Parent = this.btnReturn;
            this.btnReturn.FillColor = System.Drawing.Color.White;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.HoverState.Parent = this.btnReturn;
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.ImageSize = new System.Drawing.Size(16, 16);
            this.btnReturn.Location = new System.Drawing.Point(3, 3);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.PressedColor = System.Drawing.Color.Transparent;
            this.btnReturn.ShadowDecoration.Parent = this.btnReturn;
            this.btnReturn.Size = new System.Drawing.Size(45, 30);
            this.btnReturn.TabIndex = 78;
            this.btnReturn.Click += new System.EventHandler(this.Return_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMinimize.FillColor = System.Drawing.Color.White;
            this.btnMinimize.HoverState.Parent = this.btnMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.Black;
            this.btnMinimize.Location = new System.Drawing.Point(1241, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.PressedColor = System.Drawing.Color.Transparent;
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.Size = new System.Drawing.Size(45, 30);
            this.btnMinimize.TabIndex = 80;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.BorderColor = System.Drawing.Color.White;
            this.btnClose.FillColor = System.Drawing.Color.White;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.btnClose.HoverState.IconColor = System.Drawing.Color.White;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(1292, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(45, 30);
            this.btnClose.TabIndex = 79;
            // 
            // grpRoomBookList
            // 
            this.grpRoomBookList.Controls.Add(this.flpBookList);
            this.grpRoomBookList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.grpRoomBookList.Location = new System.Drawing.Point(12, 39);
            this.grpRoomBookList.Name = "grpRoomBookList";
            this.grpRoomBookList.Size = new System.Drawing.Size(512, 709);
            this.grpRoomBookList.TabIndex = 81;
            this.grpRoomBookList.TabStop = false;
            this.grpRoomBookList.Text = "Danh sách phòng";
            // 
            // flpBookList
            // 
            this.flpBookList.AutoScroll = true;
            this.flpBookList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpBookList.Location = new System.Drawing.Point(6, 24);
            this.flpBookList.Name = "flpBookList";
            this.flpBookList.Size = new System.Drawing.Size(500, 679);
            this.flpBookList.TabIndex = 78;
            // 
            // grpServiceRoom
            // 
            this.grpServiceRoom.Controls.Add(this.lsvBillDetails);
            this.grpServiceRoom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.grpServiceRoom.Location = new System.Drawing.Point(530, 117);
            this.grpServiceRoom.Name = "grpServiceRoom";
            this.grpServiceRoom.Size = new System.Drawing.Size(798, 180);
            this.grpServiceRoom.TabIndex = 82;
            this.grpServiceRoom.TabStop = false;
            this.grpServiceRoom.Text = "Hóa đơn dịch vụ";
            // 
            // lsvBillDetails
            // 
            this.lsvBillDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lsvBillDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colService,
            this.colCount,
            this.colPrice,
            this.colTotalPrice});
            this.lsvBillDetails.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvBillDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lsvBillDetails.GridLines = true;
            this.lsvBillDetails.HideSelection = false;
            this.lsvBillDetails.Location = new System.Drawing.Point(6, 24);
            this.lsvBillDetails.Name = "lsvBillDetails";
            this.lsvBillDetails.Size = new System.Drawing.Size(786, 146);
            this.lsvBillDetails.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lsvBillDetails.TabIndex = 80;
            this.lsvBillDetails.UseCompatibleStateImageBehavior = false;
            this.lsvBillDetails.View = System.Windows.Forms.View.Details;
            // 
            // colService
            // 
            this.colService.Text = "Dịch vụ";
            this.colService.Width = 196;
            // 
            // colCount
            // 
            this.colCount.Text = "Số lượng";
            this.colCount.Width = 196;
            // 
            // colPrice
            // 
            this.colPrice.Text = "Giá dịch vụ";
            this.colPrice.Width = 196;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.Text = "Thành tiền";
            this.colTotalPrice.Width = 197;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsvBill);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(530, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 72);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa đơn tiền phòng";
            // 
            // lsvBill
            // 
            this.lsvBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.lsvBill.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lsvBill.GridLines = true;
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(6, 24);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Scrollable = false;
            this.lsvBill.Size = new System.Drawing.Size(786, 42);
            this.lsvBill.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lsvBill.TabIndex = 80;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên phòng";
            this.columnHeader2.Width = 196;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Giá phòng";
            this.columnHeader10.Width = 196;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Ngày vào";
            this.columnHeader11.Width = 197;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Ngày ra";
            this.columnHeader12.Width = 197;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsvRegulations);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(530, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(798, 160);
            this.groupBox2.TabIndex = 83;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chính sách phụ thu";
            // 
            // lsvRegulations
            // 
            this.lsvRegulations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lsvRegulations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colRegulationsName,
            this.colCoefficient,
            this.colDescription});
            this.lsvRegulations.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvRegulations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lsvRegulations.GridLines = true;
            this.lsvRegulations.HideSelection = false;
            this.lsvRegulations.Location = new System.Drawing.Point(12, 24);
            this.lsvRegulations.Name = "lsvRegulations";
            this.lsvRegulations.Size = new System.Drawing.Size(780, 129);
            this.lsvRegulations.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lsvRegulations.TabIndex = 80;
            this.lsvRegulations.UseCompatibleStateImageBehavior = false;
            this.lsvRegulations.View = System.Windows.Forms.View.Details;
            // 
            // colRegulationsName
            // 
            this.colRegulationsName.Text = "Tên quy định";
            this.colRegulationsName.Width = 196;
            // 
            // colDescription
            // 
            this.colDescription.Text = "Miêu tả";
            this.colDescription.Width = 382;
            // 
            // colCoefficient
            // 
            this.colCoefficient.Text = "Hệ số";
            this.colCoefficient.Width = 196;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCompletePayment);
            this.groupBox3.Controls.Add(this.txtSurcharge);
            this.groupBox3.Controls.Add(this.guna2HtmlLabel1);
            this.groupBox3.Controls.Add(this.btnViewDetails);
            this.groupBox3.Controls.Add(this.btnPayOff);
            this.groupBox3.Controls.Add(this.guna2HtmlLabel3);
            this.groupBox3.Controls.Add(this.txtTotalMoney);
            this.groupBox3.Controls.Add(this.txtDiscount);
            this.groupBox3.Controls.Add(this.lblDiscount);
            this.groupBox3.Controls.Add(this.lblTotalServicePrice);
            this.groupBox3.Controls.Add(this.txtTotalServicePrice);
            this.groupBox3.Controls.Add(this.lblRoomPrice);
            this.groupBox3.Controls.Add(this.txtRoomPrice);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(530, 469);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(798, 279);
            this.groupBox3.TabIndex = 84;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tính tiền";
            // 
            // btnCompletePayment
            // 
            this.btnCompletePayment.Animated = true;
            this.btnCompletePayment.BorderRadius = 4;
            this.btnCompletePayment.CheckedState.Parent = this.btnCompletePayment;
            this.btnCompletePayment.CustomImages.Parent = this.btnCompletePayment;
            this.btnCompletePayment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnCompletePayment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompletePayment.ForeColor = System.Drawing.Color.White;
            this.btnCompletePayment.HoverState.Parent = this.btnCompletePayment;
            this.btnCompletePayment.IndicateFocus = true;
            this.btnCompletePayment.Location = new System.Drawing.Point(524, 217);
            this.btnCompletePayment.Name = "btnCompletePayment";
            this.btnCompletePayment.ShadowDecoration.Parent = this.btnCompletePayment;
            this.btnCompletePayment.Size = new System.Drawing.Size(238, 36);
            this.btnCompletePayment.TabIndex = 98;
            this.btnCompletePayment.Text = "Hoàn tất thanh toán hóa đơn";
            this.btnCompletePayment.Click += new System.EventHandler(this.CompletePayment_Click);
            // 
            // txtSurcharge
            // 
            this.txtSurcharge.BackColor = System.Drawing.Color.White;
            this.txtSurcharge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtSurcharge.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtSurcharge.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtSurcharge.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtSurcharge.BorderThickness = 1;
            this.txtSurcharge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSurcharge.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurcharge.ForeColor = System.Drawing.Color.Black;
            this.txtSurcharge.isPassword = false;
            this.txtSurcharge.Location = new System.Drawing.Point(33, 136);
            this.txtSurcharge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSurcharge.Name = "txtSurcharge";
            this.txtSurcharge.Size = new System.Drawing.Size(220, 36);
            this.txtSurcharge.TabIndex = 97;
            this.txtSurcharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.IsContextMenuEnabled = false;
            this.guna2HtmlLabel1.IsSelectionEnabled = false;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(34, 109);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(92, 19);
            this.guna2HtmlLabel1.TabIndex = 96;
            this.guna2HtmlLabel1.Text = "Phụ thu (Hệ số)";
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.Animated = true;
            this.btnViewDetails.BorderRadius = 4;
            this.btnViewDetails.CheckedState.Parent = this.btnViewDetails;
            this.btnViewDetails.CustomImages.Parent = this.btnViewDetails;
            this.btnViewDetails.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnViewDetails.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDetails.ForeColor = System.Drawing.Color.White;
            this.btnViewDetails.HoverState.Parent = this.btnViewDetails;
            this.btnViewDetails.IndicateFocus = true;
            this.btnViewDetails.Location = new System.Drawing.Point(278, 217);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.ShadowDecoration.Parent = this.btnViewDetails;
            this.btnViewDetails.Size = new System.Drawing.Size(240, 36);
            this.btnViewDetails.TabIndex = 95;
            this.btnViewDetails.Text = "Xem chi tiết hóa đơn";
            this.btnViewDetails.Click += new System.EventHandler(this.ViewDetails_Click);
            // 
            // btnPayOff
            // 
            this.btnPayOff.Animated = true;
            this.btnPayOff.BorderRadius = 4;
            this.btnPayOff.CheckedState.Parent = this.btnPayOff;
            this.btnPayOff.CustomImages.Parent = this.btnPayOff;
            this.btnPayOff.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnPayOff.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayOff.ForeColor = System.Drawing.Color.White;
            this.btnPayOff.HoverState.Parent = this.btnPayOff;
            this.btnPayOff.IndicateFocus = true;
            this.btnPayOff.Location = new System.Drawing.Point(34, 217);
            this.btnPayOff.Name = "btnPayOff";
            this.btnPayOff.ShadowDecoration.Parent = this.btnPayOff;
            this.btnPayOff.Size = new System.Drawing.Size(238, 36);
            this.btnPayOff.TabIndex = 94;
            this.btnPayOff.Text = "Tính tiền hóa đơn";
            this.btnPayOff.Click += new System.EventHandler(this.PayOff_Click);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel3.IsContextMenuEnabled = false;
            this.guna2HtmlLabel3.IsSelectionEnabled = false;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(289, 109);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(58, 19);
            this.guna2HtmlLabel3.TabIndex = 93;
            this.guna2HtmlLabel3.Text = "Tổng tiền";
            // 
            // txtTotalMoney
            // 
            this.txtTotalMoney.BackColor = System.Drawing.Color.White;
            this.txtTotalMoney.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtTotalMoney.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtTotalMoney.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtTotalMoney.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtTotalMoney.BorderThickness = 1;
            this.txtTotalMoney.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalMoney.Enabled = false;
            this.txtTotalMoney.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalMoney.ForeColor = System.Drawing.Color.Black;
            this.txtTotalMoney.isPassword = false;
            this.txtTotalMoney.Location = new System.Drawing.Point(289, 136);
            this.txtTotalMoney.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalMoney.Name = "txtTotalMoney";
            this.txtTotalMoney.Size = new System.Drawing.Size(473, 36);
            this.txtTotalMoney.TabIndex = 92;
            this.txtTotalMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtDiscount
            // 
            this.txtDiscount.BackColor = System.Drawing.Color.White;
            this.txtDiscount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtDiscount.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtDiscount.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtDiscount.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtDiscount.BorderThickness = 1;
            this.txtDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiscount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.ForeColor = System.Drawing.Color.Black;
            this.txtDiscount.isPassword = false;
            this.txtDiscount.Location = new System.Drawing.Point(542, 65);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(220, 36);
            this.txtDiscount.TabIndex = 91;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Discount_KeyPress);
            // 
            // lblDiscount
            // 
            this.lblDiscount.BackColor = System.Drawing.Color.Transparent;
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.ForeColor = System.Drawing.Color.Black;
            this.lblDiscount.IsContextMenuEnabled = false;
            this.lblDiscount.IsSelectionEnabled = false;
            this.lblDiscount.Location = new System.Drawing.Point(542, 38);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(78, 19);
            this.lblDiscount.TabIndex = 90;
            this.lblDiscount.Text = "Giảm giá (%)";
            // 
            // lblTotalServicePrice
            // 
            this.lblTotalServicePrice.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalServicePrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalServicePrice.ForeColor = System.Drawing.Color.Black;
            this.lblTotalServicePrice.IsContextMenuEnabled = false;
            this.lblTotalServicePrice.IsSelectionEnabled = false;
            this.lblTotalServicePrice.Location = new System.Drawing.Point(289, 38);
            this.lblTotalServicePrice.Name = "lblTotalServicePrice";
            this.lblTotalServicePrice.Size = new System.Drawing.Size(72, 19);
            this.lblTotalServicePrice.TabIndex = 89;
            this.lblTotalServicePrice.Text = "Tiền dịch vụ";
            // 
            // txtTotalServicePrice
            // 
            this.txtTotalServicePrice.BackColor = System.Drawing.Color.White;
            this.txtTotalServicePrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtTotalServicePrice.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtTotalServicePrice.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtTotalServicePrice.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtTotalServicePrice.BorderThickness = 1;
            this.txtTotalServicePrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalServicePrice.Enabled = false;
            this.txtTotalServicePrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalServicePrice.ForeColor = System.Drawing.Color.Black;
            this.txtTotalServicePrice.isPassword = false;
            this.txtTotalServicePrice.Location = new System.Drawing.Point(289, 65);
            this.txtTotalServicePrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalServicePrice.Name = "txtTotalServicePrice";
            this.txtTotalServicePrice.Size = new System.Drawing.Size(220, 36);
            this.txtTotalServicePrice.TabIndex = 88;
            this.txtTotalServicePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblRoomPrice
            // 
            this.lblRoomPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomPrice.ForeColor = System.Drawing.Color.Black;
            this.lblRoomPrice.IsContextMenuEnabled = false;
            this.lblRoomPrice.IsSelectionEnabled = false;
            this.lblRoomPrice.Location = new System.Drawing.Point(34, 38);
            this.lblRoomPrice.Name = "lblRoomPrice";
            this.lblRoomPrice.Size = new System.Drawing.Size(69, 19);
            this.lblRoomPrice.TabIndex = 87;
            this.lblRoomPrice.Text = "Tiền phòng";
            // 
            // txtRoomPrice
            // 
            this.txtRoomPrice.BackColor = System.Drawing.Color.White;
            this.txtRoomPrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtRoomPrice.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtRoomPrice.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtRoomPrice.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtRoomPrice.BorderThickness = 1;
            this.txtRoomPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomPrice.Enabled = false;
            this.txtRoomPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomPrice.ForeColor = System.Drawing.Color.Black;
            this.txtRoomPrice.isPassword = false;
            this.txtRoomPrice.Location = new System.Drawing.Point(34, 65);
            this.txtRoomPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRoomPrice.Name = "txtRoomPrice";
            this.txtRoomPrice.Size = new System.Drawing.Size(220, 36);
            this.txtRoomPrice.TabIndex = 84;
            this.txtRoomPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtRoomPriceHide
            // 
            this.txtRoomPriceHide.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomPriceHide.DefaultText = "";
            this.txtRoomPriceHide.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRoomPriceHide.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRoomPriceHide.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomPriceHide.DisabledState.Parent = this.txtRoomPriceHide;
            this.txtRoomPriceHide.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomPriceHide.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomPriceHide.FocusedState.Parent = this.txtRoomPriceHide;
            this.txtRoomPriceHide.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRoomPriceHide.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomPriceHide.HoverState.Parent = this.txtRoomPriceHide;
            this.txtRoomPriceHide.Location = new System.Drawing.Point(350, 96);
            this.txtRoomPriceHide.Name = "txtRoomPriceHide";
            this.txtRoomPriceHide.PasswordChar = '\0';
            this.txtRoomPriceHide.PlaceholderText = "";
            this.txtRoomPriceHide.SelectedText = "";
            this.txtRoomPriceHide.ShadowDecoration.Parent = this.txtRoomPriceHide;
            this.txtRoomPriceHide.Size = new System.Drawing.Size(10, 36);
            this.txtRoomPriceHide.TabIndex = 85;
            // 
            // txtTotalServicePriceHide
            // 
            this.txtTotalServicePriceHide.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalServicePriceHide.DefaultText = "";
            this.txtTotalServicePriceHide.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalServicePriceHide.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalServicePriceHide.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalServicePriceHide.DisabledState.Parent = this.txtTotalServicePriceHide;
            this.txtTotalServicePriceHide.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalServicePriceHide.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalServicePriceHide.FocusedState.Parent = this.txtTotalServicePriceHide;
            this.txtTotalServicePriceHide.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotalServicePriceHide.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalServicePriceHide.HoverState.Parent = this.txtTotalServicePriceHide;
            this.txtTotalServicePriceHide.Location = new System.Drawing.Point(366, 96);
            this.txtTotalServicePriceHide.Name = "txtTotalServicePriceHide";
            this.txtTotalServicePriceHide.PasswordChar = '\0';
            this.txtTotalServicePriceHide.PlaceholderText = "";
            this.txtTotalServicePriceHide.SelectedText = "";
            this.txtTotalServicePriceHide.ShadowDecoration.Parent = this.txtTotalServicePriceHide;
            this.txtTotalServicePriceHide.Size = new System.Drawing.Size(10, 36);
            this.txtTotalServicePriceHide.TabIndex = 86;
            // 
            // DragControl
            // 
            this.DragControl.ContainerControl = this;
            this.DragControl.TargetControl = this;
            // 
            // txtRoomName
            // 
            this.txtRoomName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomName.DefaultText = "";
            this.txtRoomName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRoomName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRoomName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomName.DisabledState.Parent = this.txtRoomName;
            this.txtRoomName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomName.FocusedState.Parent = this.txtRoomName;
            this.txtRoomName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRoomName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomName.HoverState.Parent = this.txtRoomName;
            this.txtRoomName.Location = new System.Drawing.Point(382, 96);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.PasswordChar = '\0';
            this.txtRoomName.PlaceholderText = "";
            this.txtRoomName.SelectedText = "";
            this.txtRoomName.ShadowDecoration.Parent = this.txtRoomName;
            this.txtRoomName.Size = new System.Drawing.Size(10, 36);
            this.txtRoomName.TabIndex = 87;
            // 
            // txtIdBook
            // 
            this.txtIdBook.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdBook.DefaultText = "";
            this.txtIdBook.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdBook.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdBook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdBook.DisabledState.Parent = this.txtIdBook;
            this.txtIdBook.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdBook.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdBook.FocusedState.Parent = this.txtIdBook;
            this.txtIdBook.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdBook.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdBook.HoverState.Parent = this.txtIdBook;
            this.txtIdBook.Location = new System.Drawing.Point(398, 96);
            this.txtIdBook.Name = "txtIdBook";
            this.txtIdBook.PasswordChar = '\0';
            this.txtIdBook.PlaceholderText = "";
            this.txtIdBook.SelectedText = "";
            this.txtIdBook.ShadowDecoration.Parent = this.txtIdBook;
            this.txtIdBook.Size = new System.Drawing.Size(10, 36);
            this.txtIdBook.TabIndex = 88;
            // 
            // txtTotalMoneyHide
            // 
            this.txtTotalMoneyHide.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalMoneyHide.DefaultText = "";
            this.txtTotalMoneyHide.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalMoneyHide.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalMoneyHide.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalMoneyHide.DisabledState.Parent = this.txtTotalMoneyHide;
            this.txtTotalMoneyHide.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalMoneyHide.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalMoneyHide.FocusedState.Parent = this.txtTotalMoneyHide;
            this.txtTotalMoneyHide.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotalMoneyHide.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalMoneyHide.HoverState.Parent = this.txtTotalMoneyHide;
            this.txtTotalMoneyHide.Location = new System.Drawing.Point(414, 96);
            this.txtTotalMoneyHide.Name = "txtTotalMoneyHide";
            this.txtTotalMoneyHide.PasswordChar = '\0';
            this.txtTotalMoneyHide.PlaceholderText = "";
            this.txtTotalMoneyHide.SelectedText = "";
            this.txtTotalMoneyHide.ShadowDecoration.Parent = this.txtTotalMoneyHide;
            this.txtTotalMoneyHide.Size = new System.Drawing.Size(10, 36);
            this.txtTotalMoneyHide.TabIndex = 89;
            // 
            // FPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1340, 760);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpServiceRoom);
            this.Controls.Add(this.grpRoomBookList);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.txtTotalServicePriceHide);
            this.Controls.Add(this.txtRoomPriceHide);
            this.Controls.Add(this.txtRoomName);
            this.Controls.Add(this.txtIdBook);
            this.Controls.Add(this.txtTotalMoneyHide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FPay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FPay";
            this.Load += new System.EventHandler(this.FPay_Load);
            this.grpRoomBookList.ResumeLayout(false);
            this.grpServiceRoom.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnReturn;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimize;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private System.Windows.Forms.GroupBox grpRoomBookList;
        private System.Windows.Forms.FlowLayoutPanel flpBookList;
        private System.Windows.Forms.GroupBox grpServiceRoom;
        private System.Windows.Forms.ListView lsvBillDetails;
        private System.Windows.Forms.ColumnHeader colService;
        private System.Windows.Forms.ColumnHeader colCount;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.ColumnHeader colTotalPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lsvRegulations;
        private System.Windows.Forms.ColumnHeader colRegulationsName;
        private System.Windows.Forms.ColumnHeader colDescription;
        private System.Windows.Forms.ColumnHeader colCoefficient;
        private System.Windows.Forms.GroupBox groupBox3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtRoomPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRoomPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalServicePrice;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTotalServicePrice;
        private Guna.UI2.WinForms.Guna2ShadowForm ShadowForm;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private Guna.UI2.WinForms.Guna2TextBox txtRoomPriceHide;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalServicePriceHide;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDiscount;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtDiscount;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTotalMoney;
        private Guna.UI2.WinForms.Guna2Button btnPayOff;
        private Guna.UI2.WinForms.Guna2Button btnViewDetails;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private Guna.UI2.WinForms.Guna2TextBox txtRoomName;
        private Guna.UI2.WinForms.Guna2TextBox txtIdBook;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSurcharge;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnCompletePayment;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalMoneyHide;
    }
}