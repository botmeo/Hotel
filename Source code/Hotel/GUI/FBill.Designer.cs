
namespace GUI
{
    partial class FBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FBill));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnReturn = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.dgvBill = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.grpStaff = new System.Windows.Forms.GroupBox();
            this.lblIdStaff = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTotalMoney = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTotalMoney = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblDiscount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtDiscount = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblSurcharge = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSurcharge = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblServicePrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtServicePrice = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblIdBill = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnExport = new Guna.UI2.WinForms.Guna2Button();
            this.txtIdStaff = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblRoomPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDateStartWork = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtmDateCreated = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtIdBill = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtRoomPrice = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lsvBillDetails = new System.Windows.Forms.ListView();
            this.colService = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ShadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.grpStaff.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.btnReturn.TabIndex = 64;
            this.btnReturn.Click += new System.EventHandler(this.Return_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.White;
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
            this.btnClose.TabIndex = 65;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMinimize.FillColor = System.Drawing.Color.White;
            this.btnMinimize.HoverState.Parent = this.btnMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.Black;
            this.btnMinimize.Location = new System.Drawing.Point(1241, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.PressedColor = System.Drawing.Color.Transparent;
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.Size = new System.Drawing.Size(45, 30);
            this.btnMinimize.TabIndex = 66;
            // 
            // dgvBill
            // 
            this.dgvBill.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBill.BackgroundColor = System.Drawing.Color.White;
            this.dgvBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBill.ColumnHeadersHeight = 40;
            this.dgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column11,
            this.Column10,
            this.Column12,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(90)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBill.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBill.DoubleBuffered = true;
            this.dgvBill.EnableHeadersVisualStyles = false;
            this.dgvBill.GridColor = System.Drawing.Color.White;
            this.dgvBill.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.dgvBill.HeaderForeColor = System.Drawing.Color.White;
            this.dgvBill.Location = new System.Drawing.Point(318, 48);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.ReadOnly = true;
            this.dgvBill.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBill.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvBill.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBill.RowTemplate.Height = 30;
            this.dgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBill.Size = new System.Drawing.Size(1010, 377);
            this.dgvBill.StandardTab = true;
            this.dgvBill.TabIndex = 67;
            this.dgvBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Bill_CellContentClick);
            // 
            // grpStaff
            // 
            this.grpStaff.Controls.Add(this.lblIdStaff);
            this.grpStaff.Controls.Add(this.lblTotalMoney);
            this.grpStaff.Controls.Add(this.txtTotalMoney);
            this.grpStaff.Controls.Add(this.lblDiscount);
            this.grpStaff.Controls.Add(this.txtDiscount);
            this.grpStaff.Controls.Add(this.lblSurcharge);
            this.grpStaff.Controls.Add(this.txtSurcharge);
            this.grpStaff.Controls.Add(this.lblServicePrice);
            this.grpStaff.Controls.Add(this.txtServicePrice);
            this.grpStaff.Controls.Add(this.lblIdBill);
            this.grpStaff.Controls.Add(this.btnExport);
            this.grpStaff.Controls.Add(this.txtIdStaff);
            this.grpStaff.Controls.Add(this.lblRoomPrice);
            this.grpStaff.Controls.Add(this.lblDateStartWork);
            this.grpStaff.Controls.Add(this.dtmDateCreated);
            this.grpStaff.Controls.Add(this.txtIdBill);
            this.grpStaff.Controls.Add(this.txtRoomPrice);
            this.grpStaff.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStaff.Location = new System.Drawing.Point(12, 39);
            this.grpStaff.Name = "grpStaff";
            this.grpStaff.Size = new System.Drawing.Size(300, 709);
            this.grpStaff.TabIndex = 68;
            this.grpStaff.TabStop = false;
            this.grpStaff.Text = "Thông tin hóa đơn";
            // 
            // lblIdStaff
            // 
            this.lblIdStaff.BackColor = System.Drawing.Color.Transparent;
            this.lblIdStaff.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdStaff.ForeColor = System.Drawing.Color.Black;
            this.lblIdStaff.IsContextMenuEnabled = false;
            this.lblIdStaff.IsSelectionEnabled = false;
            this.lblIdStaff.Location = new System.Drawing.Point(40, 542);
            this.lblIdStaff.Name = "lblIdStaff";
            this.lblIdStaff.Size = new System.Drawing.Size(147, 19);
            this.lblIdStaff.TabIndex = 66;
            this.lblIdStaff.Text = "Mã nhân viên thanh toán";
            // 
            // lblTotalMoney
            // 
            this.lblTotalMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalMoney.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMoney.ForeColor = System.Drawing.Color.Black;
            this.lblTotalMoney.IsContextMenuEnabled = false;
            this.lblTotalMoney.IsSelectionEnabled = false;
            this.lblTotalMoney.Location = new System.Drawing.Point(40, 400);
            this.lblTotalMoney.Name = "lblTotalMoney";
            this.lblTotalMoney.Size = new System.Drawing.Size(58, 19);
            this.lblTotalMoney.TabIndex = 65;
            this.lblTotalMoney.Text = "Tổng tiền";
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
            this.txtTotalMoney.Location = new System.Drawing.Point(40, 427);
            this.txtTotalMoney.Margin = new System.Windows.Forms.Padding(5);
            this.txtTotalMoney.Name = "txtTotalMoney";
            this.txtTotalMoney.Size = new System.Drawing.Size(220, 36);
            this.txtTotalMoney.TabIndex = 64;
            this.txtTotalMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblDiscount
            // 
            this.lblDiscount.BackColor = System.Drawing.Color.Transparent;
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.ForeColor = System.Drawing.Color.Black;
            this.lblDiscount.IsContextMenuEnabled = false;
            this.lblDiscount.IsSelectionEnabled = false;
            this.lblDiscount.Location = new System.Drawing.Point(40, 329);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(78, 19);
            this.lblDiscount.TabIndex = 63;
            this.lblDiscount.Text = "Giảm giá (%)";
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
            this.txtDiscount.Enabled = false;
            this.txtDiscount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.ForeColor = System.Drawing.Color.Black;
            this.txtDiscount.isPassword = false;
            this.txtDiscount.Location = new System.Drawing.Point(40, 356);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(5);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(220, 36);
            this.txtDiscount.TabIndex = 62;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblSurcharge
            // 
            this.lblSurcharge.BackColor = System.Drawing.Color.Transparent;
            this.lblSurcharge.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurcharge.ForeColor = System.Drawing.Color.Black;
            this.lblSurcharge.IsContextMenuEnabled = false;
            this.lblSurcharge.IsSelectionEnabled = false;
            this.lblSurcharge.Location = new System.Drawing.Point(40, 258);
            this.lblSurcharge.Name = "lblSurcharge";
            this.lblSurcharge.Size = new System.Drawing.Size(92, 19);
            this.lblSurcharge.TabIndex = 61;
            this.lblSurcharge.Text = "Phụ thu (Hệ số)";
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
            this.txtSurcharge.Enabled = false;
            this.txtSurcharge.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurcharge.ForeColor = System.Drawing.Color.Black;
            this.txtSurcharge.isPassword = false;
            this.txtSurcharge.Location = new System.Drawing.Point(40, 285);
            this.txtSurcharge.Margin = new System.Windows.Forms.Padding(5);
            this.txtSurcharge.Name = "txtSurcharge";
            this.txtSurcharge.Size = new System.Drawing.Size(220, 36);
            this.txtSurcharge.TabIndex = 60;
            this.txtSurcharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblServicePrice
            // 
            this.lblServicePrice.BackColor = System.Drawing.Color.Transparent;
            this.lblServicePrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicePrice.ForeColor = System.Drawing.Color.Black;
            this.lblServicePrice.IsContextMenuEnabled = false;
            this.lblServicePrice.IsSelectionEnabled = false;
            this.lblServicePrice.Location = new System.Drawing.Point(40, 187);
            this.lblServicePrice.Name = "lblServicePrice";
            this.lblServicePrice.Size = new System.Drawing.Size(72, 19);
            this.lblServicePrice.TabIndex = 59;
            this.lblServicePrice.Text = "Tiền dịch vụ";
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
            this.txtServicePrice.Location = new System.Drawing.Point(40, 214);
            this.txtServicePrice.Margin = new System.Windows.Forms.Padding(5);
            this.txtServicePrice.Name = "txtServicePrice";
            this.txtServicePrice.Size = new System.Drawing.Size(220, 36);
            this.txtServicePrice.TabIndex = 58;
            this.txtServicePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblIdBill
            // 
            this.lblIdBill.BackColor = System.Drawing.Color.Transparent;
            this.lblIdBill.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdBill.ForeColor = System.Drawing.Color.Black;
            this.lblIdBill.IsContextMenuEnabled = false;
            this.lblIdBill.IsSelectionEnabled = false;
            this.lblIdBill.Location = new System.Drawing.Point(40, 45);
            this.lblIdBill.Name = "lblIdBill";
            this.lblIdBill.Size = new System.Drawing.Size(75, 19);
            this.lblIdBill.TabIndex = 48;
            this.lblIdBill.Text = "Mã hóa đơn";
            // 
            // btnExport
            // 
            this.btnExport.Animated = true;
            this.btnExport.BackColor = System.Drawing.Color.White;
            this.btnExport.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnExport.BorderRadius = 4;
            this.btnExport.CheckedState.Parent = this.btnExport;
            this.btnExport.CustomImages.Parent = this.btnExport;
            this.btnExport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.HoverState.Parent = this.btnExport;
            this.btnExport.IndicateFocus = true;
            this.btnExport.Location = new System.Drawing.Point(40, 639);
            this.btnExport.Name = "btnExport";
            this.btnExport.ShadowDecoration.Parent = this.btnExport;
            this.btnExport.Size = new System.Drawing.Size(220, 36);
            this.btnExport.TabIndex = 44;
            this.btnExport.Text = "In toàn bộ hóa đơn";
            this.btnExport.Click += new System.EventHandler(this.Export_Click);
            // 
            // txtIdStaff
            // 
            this.txtIdStaff.BackColor = System.Drawing.Color.White;
            this.txtIdStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtIdStaff.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtIdStaff.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtIdStaff.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtIdStaff.BorderThickness = 1;
            this.txtIdStaff.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdStaff.Enabled = false;
            this.txtIdStaff.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdStaff.ForeColor = System.Drawing.Color.Black;
            this.txtIdStaff.isPassword = false;
            this.txtIdStaff.Location = new System.Drawing.Point(40, 569);
            this.txtIdStaff.Margin = new System.Windows.Forms.Padding(5);
            this.txtIdStaff.Name = "txtIdStaff";
            this.txtIdStaff.Size = new System.Drawing.Size(220, 36);
            this.txtIdStaff.TabIndex = 55;
            this.txtIdStaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblRoomPrice
            // 
            this.lblRoomPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomPrice.ForeColor = System.Drawing.Color.Black;
            this.lblRoomPrice.IsContextMenuEnabled = false;
            this.lblRoomPrice.IsSelectionEnabled = false;
            this.lblRoomPrice.Location = new System.Drawing.Point(40, 116);
            this.lblRoomPrice.Name = "lblRoomPrice";
            this.lblRoomPrice.Size = new System.Drawing.Size(69, 19);
            this.lblRoomPrice.TabIndex = 29;
            this.lblRoomPrice.Text = "Tiền phòng";
            // 
            // lblDateStartWork
            // 
            this.lblDateStartWork.BackColor = System.Drawing.Color.Transparent;
            this.lblDateStartWork.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateStartWork.ForeColor = System.Drawing.Color.Black;
            this.lblDateStartWork.IsContextMenuEnabled = false;
            this.lblDateStartWork.IsSelectionEnabled = false;
            this.lblDateStartWork.Location = new System.Drawing.Point(40, 471);
            this.lblDateStartWork.Name = "lblDateStartWork";
            this.lblDateStartWork.Size = new System.Drawing.Size(100, 19);
            this.lblDateStartWork.TabIndex = 53;
            this.lblDateStartWork.Text = "Ngày thanh toán";
            // 
            // dtmDateCreated
            // 
            this.dtmDateCreated.Animated = true;
            this.dtmDateCreated.BackColor = System.Drawing.Color.Transparent;
            this.dtmDateCreated.CheckedState.FillColor = System.Drawing.Color.Black;
            this.dtmDateCreated.CheckedState.Parent = this.dtmDateCreated;
            this.dtmDateCreated.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.dtmDateCreated.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtmDateCreated.ForeColor = System.Drawing.Color.White;
            this.dtmDateCreated.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmDateCreated.HoverState.Parent = this.dtmDateCreated;
            this.dtmDateCreated.Location = new System.Drawing.Point(40, 498);
            this.dtmDateCreated.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtmDateCreated.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.dtmDateCreated.Name = "dtmDateCreated";
            this.dtmDateCreated.ShadowDecoration.Parent = this.dtmDateCreated;
            this.dtmDateCreated.Size = new System.Drawing.Size(220, 36);
            this.dtmDateCreated.TabIndex = 52;
            this.dtmDateCreated.Value = new System.DateTime(2021, 3, 7, 0, 0, 0, 0);
            // 
            // txtIdBill
            // 
            this.txtIdBill.BackColor = System.Drawing.Color.White;
            this.txtIdBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtIdBill.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtIdBill.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtIdBill.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtIdBill.BorderThickness = 1;
            this.txtIdBill.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdBill.Enabled = false;
            this.txtIdBill.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdBill.ForeColor = System.Drawing.Color.Black;
            this.txtIdBill.isPassword = false;
            this.txtIdBill.Location = new System.Drawing.Point(40, 72);
            this.txtIdBill.Margin = new System.Windows.Forms.Padding(5);
            this.txtIdBill.Name = "txtIdBill";
            this.txtIdBill.Size = new System.Drawing.Size(220, 36);
            this.txtIdBill.TabIndex = 47;
            this.txtIdBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.txtRoomPrice.Location = new System.Drawing.Point(40, 143);
            this.txtRoomPrice.Margin = new System.Windows.Forms.Padding(5);
            this.txtRoomPrice.Name = "txtRoomPrice";
            this.txtRoomPrice.Size = new System.Drawing.Size(220, 36);
            this.txtRoomPrice.TabIndex = 17;
            this.txtRoomPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsvBillDetails);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(318, 431);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1010, 317);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa đơn dịch vụ";
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
            this.lsvBillDetails.Size = new System.Drawing.Size(998, 287);
            this.lsvBillDetails.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lsvBillDetails.TabIndex = 81;
            this.lsvBillDetails.UseCompatibleStateImageBehavior = false;
            this.lsvBillDetails.View = System.Windows.Forms.View.Details;
            // 
            // colService
            // 
            this.colService.Text = "Dịch vụ";
            this.colService.Width = 249;
            // 
            // colCount
            // 
            this.colCount.Text = "Số lượng";
            this.colCount.Width = 249;
            // 
            // colPrice
            // 
            this.colPrice.Text = "Giá dịch vụ";
            this.colPrice.Width = 248;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.Text = "Thành tiền";
            this.colTotalPrice.Width = 248;
            // 
            // DragControl
            // 
            this.DragControl.ContainerControl = this;
            this.DragControl.TargetControl = this;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Id";
            this.Column4.FillWeight = 120F;
            this.Column4.HeaderText = "ID";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "IdBook";
            this.Column1.FillWeight = 6.527741F;
            this.Column1.HeaderText = "MÃ HÓA ĐƠN";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 144;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.DataPropertyName = "RoomPrice";
            this.Column2.FillWeight = 6.438196F;
            this.Column2.HeaderText = "TIỀN PHÒNG";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Width = 144;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.DataPropertyName = "ServicePrice";
            this.Column3.FillWeight = 9.629339F;
            this.Column3.HeaderText = "TIỀN DỊCH VỤ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.Width = 144;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Surcharge";
            this.Column6.HeaderText = "PHỤ THU";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column11.DataPropertyName = "Discount";
            this.Column11.FillWeight = 218.591F;
            this.Column11.HeaderText = "GIẢM GIÁ";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 140;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column10.DataPropertyName = "TotalPrice";
            this.Column10.FillWeight = 54.2452F;
            this.Column10.HeaderText = "TỔNG TIỀN";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 144;
            // 
            // Column12
            // 
            this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column12.DataPropertyName = "DateCreated";
            this.Column12.FillWeight = 304.5685F;
            this.Column12.HeaderText = "NGÀY THANH TOÁN";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column12.Width = 154;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "CreateBy";
            this.Column5.HeaderText = "NHÂN VIÊN THANH TOÁN";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // FBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1340, 760);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpStaff);
            this.Controls.Add(this.dgvBill);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnReturn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FBill";
            this.Load += new System.EventHandler(this.FBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.grpStaff.ResumeLayout(false);
            this.grpStaff.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnReturn;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimize;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvBill;
        private System.Windows.Forms.GroupBox grpStaff;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblIdBill;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtIdStaff;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRoomPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDateStartWork;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtmDateCreated;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtIdBill;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtRoomPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblServicePrice;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtServicePrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSurcharge;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSurcharge;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDiscount;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtDiscount;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalMoney;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTotalMoney;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblIdStaff;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button btnExport;
        private System.Windows.Forms.ListView lsvBillDetails;
        private System.Windows.Forms.ColumnHeader colService;
        private System.Windows.Forms.ColumnHeader colCount;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.ColumnHeader colTotalPrice;
        private Guna.UI2.WinForms.Guna2ShadowForm ShadowForm;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}