
namespace GUI
{
    partial class FCheckIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCheckIn));
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnReturn = new Guna.UI2.WinForms.Guna2Button();
            this.flpBookList = new System.Windows.Forms.FlowLayoutPanel();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.ShadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.grpRoomBookList = new System.Windows.Forms.GroupBox();
            this.lsvBillDetails = new System.Windows.Forms.ListView();
            this.colService = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpServiceRoom = new System.Windows.Forms.GroupBox();
            this.txtTotalPrice = new Guna.UI2.WinForms.Guna2Chip();
            this.lblTotalPrice = new Guna.UI2.WinForms.Guna2Chip();
            this.btnDecrease = new Guna.UI2.WinForms.Guna2Button();
            this.btnIncrease = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnDeleteService = new Guna.UI2.WinForms.Guna2Button();
            this.nudCount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblServiceName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblServiceType = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnAddService = new Guna.UI2.WinForms.Guna2Button();
            this.txtServicePrice = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.cboServiceName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboServiceType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTotalPriceHide = new Guna.UI2.WinForms.Guna2Chip();
            this.txtRoomName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIdBook = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtOldCount = new Guna.UI2.WinForms.Guna2TextBox();
            this.grpRoomBookList.SuspendLayout();
            this.grpServiceRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
            this.SuspendLayout();
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
            this.btnClose.TabIndex = 75;
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
            this.btnMinimize.TabIndex = 76;
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
            this.btnReturn.TabIndex = 77;
            this.btnReturn.Click += new System.EventHandler(this.Return_Click);
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
            // DragControl
            // 
            this.DragControl.ContainerControl = this;
            this.DragControl.TargetControl = this;
            // 
            // grpRoomBookList
            // 
            this.grpRoomBookList.Controls.Add(this.flpBookList);
            this.grpRoomBookList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.grpRoomBookList.Location = new System.Drawing.Point(12, 39);
            this.grpRoomBookList.Name = "grpRoomBookList";
            this.grpRoomBookList.Size = new System.Drawing.Size(512, 709);
            this.grpRoomBookList.TabIndex = 79;
            this.grpRoomBookList.TabStop = false;
            this.grpRoomBookList.Text = "Danh sách phòng";
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
            this.lsvBillDetails.Location = new System.Drawing.Point(39, 211);
            this.lsvBillDetails.Name = "lsvBillDetails";
            this.lsvBillDetails.Size = new System.Drawing.Size(720, 435);
            this.lsvBillDetails.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lsvBillDetails.TabIndex = 80;
            this.lsvBillDetails.UseCompatibleStateImageBehavior = false;
            this.lsvBillDetails.View = System.Windows.Forms.View.Details;
            // 
            // colService
            // 
            this.colService.Text = "Dịch vụ";
            this.colService.Width = 179;
            // 
            // colCount
            // 
            this.colCount.Text = "Số lượng";
            this.colCount.Width = 179;
            // 
            // colPrice
            // 
            this.colPrice.Text = "Giá dịch vụ";
            this.colPrice.Width = 179;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.Text = "Thành tiền";
            this.colTotalPrice.Width = 179;
            // 
            // grpServiceRoom
            // 
            this.grpServiceRoom.Controls.Add(this.txtTotalPrice);
            this.grpServiceRoom.Controls.Add(this.lblTotalPrice);
            this.grpServiceRoom.Controls.Add(this.btnDecrease);
            this.grpServiceRoom.Controls.Add(this.btnIncrease);
            this.grpServiceRoom.Controls.Add(this.guna2HtmlLabel1);
            this.grpServiceRoom.Controls.Add(this.btnDeleteService);
            this.grpServiceRoom.Controls.Add(this.nudCount);
            this.grpServiceRoom.Controls.Add(this.lblServiceName);
            this.grpServiceRoom.Controls.Add(this.lblPrice);
            this.grpServiceRoom.Controls.Add(this.lblServiceType);
            this.grpServiceRoom.Controls.Add(this.btnAddService);
            this.grpServiceRoom.Controls.Add(this.txtServicePrice);
            this.grpServiceRoom.Controls.Add(this.cboServiceName);
            this.grpServiceRoom.Controls.Add(this.cboServiceType);
            this.grpServiceRoom.Controls.Add(this.lsvBillDetails);
            this.grpServiceRoom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.grpServiceRoom.Location = new System.Drawing.Point(530, 39);
            this.grpServiceRoom.Name = "grpServiceRoom";
            this.grpServiceRoom.Size = new System.Drawing.Size(798, 709);
            this.grpServiceRoom.TabIndex = 80;
            this.grpServiceRoom.TabStop = false;
            this.grpServiceRoom.Text = "Dịch vụ theo phòng";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.FillColor = System.Drawing.Color.White;
            this.txtTotalPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.ForeColor = System.Drawing.Color.Black;
            this.txtTotalPrice.Location = new System.Drawing.Point(169, 667);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ShadowDecoration.Parent = this.txtTotalPrice;
            this.txtTotalPrice.Size = new System.Drawing.Size(222, 23);
            this.txtTotalPrice.TabIndex = 100;
            this.txtTotalPrice.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.FillColor = System.Drawing.Color.White;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPrice.Location = new System.Drawing.Point(39, 667);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.ShadowDecoration.Parent = this.lblTotalPrice;
            this.lblTotalPrice.Size = new System.Drawing.Size(124, 23);
            this.lblTotalPrice.TabIndex = 99;
            this.lblTotalPrice.Text = "Tổng tiền dịch vụ :";
            this.lblTotalPrice.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // btnDecrease
            // 
            this.btnDecrease.Animated = true;
            this.btnDecrease.BorderRadius = 4;
            this.btnDecrease.CheckedState.Parent = this.btnDecrease;
            this.btnDecrease.CustomImages.Parent = this.btnDecrease;
            this.btnDecrease.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnDecrease.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrease.ForeColor = System.Drawing.Color.White;
            this.btnDecrease.HoverState.Parent = this.btnDecrease;
            this.btnDecrease.IndicateFocus = true;
            this.btnDecrease.Location = new System.Drawing.Point(647, 68);
            this.btnDecrease.Name = "btnDecrease";
            this.btnDecrease.ShadowDecoration.Parent = this.btnDecrease;
            this.btnDecrease.Size = new System.Drawing.Size(111, 36);
            this.btnDecrease.TabIndex = 95;
            this.btnDecrease.Text = "Giảm số lượng";
            this.btnDecrease.Click += new System.EventHandler(this.Decrease_Click);
            // 
            // btnIncrease
            // 
            this.btnIncrease.Animated = true;
            this.btnIncrease.BorderRadius = 4;
            this.btnIncrease.CheckedState.Parent = this.btnIncrease;
            this.btnIncrease.CustomImages.Parent = this.btnIncrease;
            this.btnIncrease.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnIncrease.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncrease.ForeColor = System.Drawing.Color.White;
            this.btnIncrease.HoverState.Parent = this.btnIncrease;
            this.btnIncrease.IndicateFocus = true;
            this.btnIncrease.Location = new System.Drawing.Point(526, 68);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.ShadowDecoration.Parent = this.btnIncrease;
            this.btnIncrease.Size = new System.Drawing.Size(115, 36);
            this.btnIncrease.TabIndex = 94;
            this.btnIncrease.Text = "Tăng số lượng";
            this.btnIncrease.Click += new System.EventHandler(this.Increase_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.IsContextMenuEnabled = false;
            this.guna2HtmlLabel1.IsSelectionEnabled = false;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(299, 43);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(56, 19);
            this.guna2HtmlLabel1.TabIndex = 91;
            this.guna2HtmlLabel1.Text = "Số lượng";
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.Animated = true;
            this.btnDeleteService.BorderRadius = 4;
            this.btnDeleteService.CheckedState.Parent = this.btnDeleteService;
            this.btnDeleteService.CustomImages.Parent = this.btnDeleteService;
            this.btnDeleteService.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnDeleteService.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteService.ForeColor = System.Drawing.Color.White;
            this.btnDeleteService.HoverState.Parent = this.btnDeleteService;
            this.btnDeleteService.IndicateFocus = true;
            this.btnDeleteService.Location = new System.Drawing.Point(647, 135);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.ShadowDecoration.Parent = this.btnDeleteService;
            this.btnDeleteService.Size = new System.Drawing.Size(111, 36);
            this.btnDeleteService.TabIndex = 90;
            this.btnDeleteService.Text = "Xóa dịch vụ";
            this.btnDeleteService.Click += new System.EventHandler(this.DeleteService_Click);
            // 
            // nudCount
            // 
            this.nudCount.BackColor = System.Drawing.Color.Transparent;
            this.nudCount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.nudCount.BorderRadius = 1;
            this.nudCount.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.nudCount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nudCount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nudCount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nudCount.DisabledState.Parent = this.nudCount;
            this.nudCount.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.nudCount.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.nudCount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nudCount.FocusedState.Parent = this.nudCount;
            this.nudCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudCount.ForeColor = System.Drawing.Color.Black;
            this.nudCount.Location = new System.Drawing.Point(299, 68);
            this.nudCount.Name = "nudCount";
            this.nudCount.ShadowDecoration.Parent = this.nudCount;
            this.nudCount.Size = new System.Drawing.Size(66, 36);
            this.nudCount.TabIndex = 88;
            this.nudCount.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.nudCount.UpDownButtonForeColor = System.Drawing.Color.White;
            this.nudCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblServiceName
            // 
            this.lblServiceName.BackColor = System.Drawing.Color.Transparent;
            this.lblServiceName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceName.ForeColor = System.Drawing.Color.Black;
            this.lblServiceName.IsContextMenuEnabled = false;
            this.lblServiceName.IsSelectionEnabled = false;
            this.lblServiceName.Location = new System.Drawing.Point(39, 110);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(69, 19);
            this.lblServiceName.TabIndex = 87;
            this.lblServiceName.Text = "Tên dịch vụ";
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Black;
            this.lblPrice.IsContextMenuEnabled = false;
            this.lblPrice.IsSelectionEnabled = false;
            this.lblPrice.Location = new System.Drawing.Point(299, 108);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(67, 19);
            this.lblPrice.TabIndex = 86;
            this.lblPrice.Text = "Giá dịch vụ";
            // 
            // lblServiceType
            // 
            this.lblServiceType.BackColor = System.Drawing.Color.Transparent;
            this.lblServiceType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceType.ForeColor = System.Drawing.Color.Black;
            this.lblServiceType.IsContextMenuEnabled = false;
            this.lblServiceType.IsSelectionEnabled = false;
            this.lblServiceType.Location = new System.Drawing.Point(39, 43);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(72, 19);
            this.lblServiceType.TabIndex = 85;
            this.lblServiceType.Text = "Loại dịch vụ";
            // 
            // btnAddService
            // 
            this.btnAddService.Animated = true;
            this.btnAddService.BorderRadius = 4;
            this.btnAddService.CheckedState.Parent = this.btnAddService;
            this.btnAddService.CustomImages.Parent = this.btnAddService;
            this.btnAddService.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnAddService.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddService.ForeColor = System.Drawing.Color.White;
            this.btnAddService.HoverState.Parent = this.btnAddService;
            this.btnAddService.IndicateFocus = true;
            this.btnAddService.Location = new System.Drawing.Point(526, 135);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.ShadowDecoration.Parent = this.btnAddService;
            this.btnAddService.Size = new System.Drawing.Size(115, 36);
            this.btnAddService.TabIndex = 84;
            this.btnAddService.Text = "Sử dụng dịch vụ";
            this.btnAddService.Click += new System.EventHandler(this.AddService_Click);
            // 
            // txtServicePrice
            // 
            this.txtServicePrice.BackColor = System.Drawing.Color.White;
            this.txtServicePrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtServicePrice.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtServicePrice.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtServicePrice.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtServicePrice.BorderThickness = 1;
            this.txtServicePrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServicePrice.Enabled = false;
            this.txtServicePrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServicePrice.ForeColor = System.Drawing.Color.Black;
            this.txtServicePrice.isPassword = false;
            this.txtServicePrice.Location = new System.Drawing.Point(299, 135);
            this.txtServicePrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtServicePrice.Name = "txtServicePrice";
            this.txtServicePrice.Size = new System.Drawing.Size(220, 36);
            this.txtServicePrice.TabIndex = 83;
            this.txtServicePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cboServiceName
            // 
            this.cboServiceName.BackColor = System.Drawing.Color.Transparent;
            this.cboServiceName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.cboServiceName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboServiceName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboServiceName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.cboServiceName.FocusedColor = System.Drawing.Color.Empty;
            this.cboServiceName.FocusedState.Parent = this.cboServiceName;
            this.cboServiceName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboServiceName.ForeColor = System.Drawing.Color.White;
            this.cboServiceName.HoverState.Parent = this.cboServiceName;
            this.cboServiceName.ItemHeight = 30;
            this.cboServiceName.ItemsAppearance.Parent = this.cboServiceName;
            this.cboServiceName.Location = new System.Drawing.Point(39, 135);
            this.cboServiceName.Name = "cboServiceName";
            this.cboServiceName.ShadowDecoration.Parent = this.cboServiceName;
            this.cboServiceName.Size = new System.Drawing.Size(220, 36);
            this.cboServiceName.TabIndex = 82;
            // 
            // cboServiceType
            // 
            this.cboServiceType.BackColor = System.Drawing.Color.Transparent;
            this.cboServiceType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.cboServiceType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboServiceType.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.cboServiceType.FocusedColor = System.Drawing.Color.Empty;
            this.cboServiceType.FocusedState.Parent = this.cboServiceType;
            this.cboServiceType.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboServiceType.ForeColor = System.Drawing.Color.White;
            this.cboServiceType.HoverState.Parent = this.cboServiceType;
            this.cboServiceType.ItemHeight = 30;
            this.cboServiceType.ItemsAppearance.Parent = this.cboServiceType;
            this.cboServiceType.Location = new System.Drawing.Point(39, 68);
            this.cboServiceType.Name = "cboServiceType";
            this.cboServiceType.ShadowDecoration.Parent = this.cboServiceType;
            this.cboServiceType.Size = new System.Drawing.Size(220, 36);
            this.cboServiceType.TabIndex = 81;
            this.cboServiceType.SelectedIndexChanged += new System.EventHandler(this.ServiceType_SelectedIndexChanged);
            // 
            // txtTotalPriceHide
            // 
            this.txtTotalPriceHide.FillColor = System.Drawing.Color.White;
            this.txtTotalPriceHide.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPriceHide.ForeColor = System.Drawing.Color.Black;
            this.txtTotalPriceHide.Location = new System.Drawing.Point(569, 719);
            this.txtTotalPriceHide.Name = "txtTotalPriceHide";
            this.txtTotalPriceHide.ShadowDecoration.Parent = this.txtTotalPriceHide;
            this.txtTotalPriceHide.Size = new System.Drawing.Size(222, 23);
            this.txtTotalPriceHide.TabIndex = 101;
            this.txtTotalPriceHide.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
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
            this.txtRoomName.Location = new System.Drawing.Point(852, 75);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.PasswordChar = '\0';
            this.txtRoomName.PlaceholderText = "";
            this.txtRoomName.SelectedText = "";
            this.txtRoomName.ShadowDecoration.Parent = this.txtRoomName;
            this.txtRoomName.Size = new System.Drawing.Size(30, 36);
            this.txtRoomName.TabIndex = 96;
            this.txtRoomName.Visible = false;
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
            this.txtIdBook.Location = new System.Drawing.Point(816, 75);
            this.txtIdBook.Name = "txtIdBook";
            this.txtIdBook.PasswordChar = '\0';
            this.txtIdBook.PlaceholderText = "";
            this.txtIdBook.SelectedText = "";
            this.txtIdBook.ShadowDecoration.Parent = this.txtIdBook;
            this.txtIdBook.Size = new System.Drawing.Size(30, 36);
            this.txtIdBook.TabIndex = 92;
            this.txtIdBook.Visible = false;
            // 
            // txtOldCount
            // 
            this.txtOldCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOldCount.DefaultText = "";
            this.txtOldCount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOldCount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOldCount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOldCount.DisabledState.Parent = this.txtOldCount;
            this.txtOldCount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOldCount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOldCount.FocusedState.Parent = this.txtOldCount;
            this.txtOldCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtOldCount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOldCount.HoverState.Parent = this.txtOldCount;
            this.txtOldCount.Location = new System.Drawing.Point(888, 75);
            this.txtOldCount.Name = "txtOldCount";
            this.txtOldCount.PasswordChar = '\0';
            this.txtOldCount.PlaceholderText = "";
            this.txtOldCount.SelectedText = "";
            this.txtOldCount.ShadowDecoration.Parent = this.txtOldCount;
            this.txtOldCount.Size = new System.Drawing.Size(30, 36);
            this.txtOldCount.TabIndex = 93;
            // 
            // FCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1340, 760);
            this.Controls.Add(this.grpServiceRoom);
            this.Controls.Add(this.grpRoomBookList);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtOldCount);
            this.Controls.Add(this.txtIdBook);
            this.Controls.Add(this.txtRoomName);
            this.Controls.Add(this.txtTotalPriceHide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FCheckIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FCheckIn_Load);
            this.grpRoomBookList.ResumeLayout(false);
            this.grpServiceRoom.ResumeLayout(false);
            this.grpServiceRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimize;
        private Guna.UI2.WinForms.Guna2Button btnReturn;
        private System.Windows.Forms.FlowLayoutPanel flpBookList;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private Guna.UI2.WinForms.Guna2ShadowForm ShadowForm;
        private System.Windows.Forms.GroupBox grpRoomBookList;
        private System.Windows.Forms.ListView lsvBillDetails;
        private System.Windows.Forms.ColumnHeader colService;
        private System.Windows.Forms.ColumnHeader colCount;
        private System.Windows.Forms.GroupBox grpServiceRoom;
        private Guna.UI2.WinForms.Guna2ComboBox cboServiceType;
        private Guna.UI2.WinForms.Guna2ComboBox cboServiceName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtServicePrice;
        private Guna.UI2.WinForms.Guna2Button btnAddService;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblServiceType;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblServiceName;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudCount;
        private Guna.UI2.WinForms.Guna2Button btnDeleteService;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.ColumnHeader colPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtIdBook;
        private Guna.UI2.WinForms.Guna2TextBox txtOldCount;
        private Guna.UI2.WinForms.Guna2Button btnIncrease;
        private Guna.UI2.WinForms.Guna2Button btnDecrease;
        private Guna.UI2.WinForms.Guna2TextBox txtRoomName;
        private System.Windows.Forms.ColumnHeader colTotalPrice;
        private Guna.UI2.WinForms.Guna2Chip lblTotalPrice;
        private Guna.UI2.WinForms.Guna2Chip txtTotalPrice;
        private Guna.UI2.WinForms.Guna2Chip txtTotalPriceHide;
    }
}