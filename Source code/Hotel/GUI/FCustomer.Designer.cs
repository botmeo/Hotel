
namespace GUI
{
    partial class FCustomer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCustomer));
            this.dtmDateOfBirth = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.ShadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.dgvCustomer = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnReturn = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.txtIdCustomer = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnExport = new Guna.UI2.WinForms.Guna2Button();
            this.lblIdCustomer = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cboSex = new Guna.UI2.WinForms.Guna2ComboBox();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.lblDateOfBirth = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtPhone = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblNationality = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblSex = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cboNationality = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblIDcard = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCustomerName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtIDcard = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtCustomerName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblPhone = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.grpCustomer.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtmDateOfBirth
            // 
            this.dtmDateOfBirth.Animated = true;
            this.dtmDateOfBirth.BackColor = System.Drawing.Color.Transparent;
            this.dtmDateOfBirth.CheckedState.Parent = this.dtmDateOfBirth;
            this.dtmDateOfBirth.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.dtmDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtmDateOfBirth.ForeColor = System.Drawing.Color.White;
            this.dtmDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmDateOfBirth.HoverState.Parent = this.dtmDateOfBirth;
            this.dtmDateOfBirth.Location = new System.Drawing.Point(40, 214);
            this.dtmDateOfBirth.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtmDateOfBirth.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.dtmDateOfBirth.Name = "dtmDateOfBirth";
            this.dtmDateOfBirth.ShadowDecoration.Parent = this.dtmDateOfBirth;
            this.dtmDateOfBirth.Size = new System.Drawing.Size(220, 36);
            this.dtmDateOfBirth.TabIndex = 19;
            this.dtmDateOfBirth.Value = new System.DateTime(2021, 3, 7, 0, 0, 0, 0);
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            this.dgvCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCustomer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvCustomer.ColumnHeadersHeight = 40;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column7,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(90)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomer.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvCustomer.DoubleBuffered = true;
            this.dgvCustomer.EnableHeadersVisualStyles = false;
            this.dgvCustomer.GridColor = System.Drawing.Color.White;
            this.dgvCustomer.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.dgvCustomer.HeaderForeColor = System.Drawing.Color.White;
            this.dgvCustomer.Location = new System.Drawing.Point(578, 50);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvCustomer.RowHeadersVisible = false;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCustomer.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvCustomer.RowTemplate.Height = 30;
            this.dgvCustomer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(750, 698);
            this.dgvCustomer.StandardTab = true;
            this.dgvCustomer.TabIndex = 68;
            this.dgvCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datagridview_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IdCustomer";
            this.Column1.HeaderText = "MÃ KHÁCH HÀNG";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "TÊN KHÁCH HÀNG";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DateOfBirth";
            this.Column4.HeaderText = "NGÀY SINH";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Sex";
            this.Column3.HeaderText = "GIỚI TÍNH";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "IdCard";
            this.Column7.HeaderText = "CHỨNG MINH NHÂN DÂN";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Phone";
            this.Column5.HeaderText = "SỐ ĐIỆN THOẠI";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Nationality";
            this.Column6.HeaderText = "QUỐC TỊCH";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
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
            this.btnClose.TabIndex = 67;
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
            this.btnReturn.TabIndex = 65;
            this.btnReturn.Click += new System.EventHandler(this.Return_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Animated = true;
            this.btnEdit.BorderRadius = 4;
            this.btnEdit.CheckedState.Parent = this.btnEdit;
            this.btnEdit.CustomImages.Parent = this.btnEdit;
            this.btnEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.HoverState.Parent = this.btnEdit;
            this.btnEdit.IndicateFocus = true;
            this.btnEdit.Location = new System.Drawing.Point(40, 450);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShadowDecoration.Parent = this.btnEdit;
            this.btnEdit.Size = new System.Drawing.Size(156, 36);
            this.btnEdit.TabIndex = 61;
            this.btnEdit.Text = "Sửa thông tin";
            this.btnEdit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // txtIdCustomer
            // 
            this.txtIdCustomer.BackColor = System.Drawing.Color.White;
            this.txtIdCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtIdCustomer.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtIdCustomer.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtIdCustomer.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtIdCustomer.BorderThickness = 1;
            this.txtIdCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdCustomer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCustomer.ForeColor = System.Drawing.Color.Black;
            this.txtIdCustomer.isPassword = false;
            this.txtIdCustomer.Location = new System.Drawing.Point(40, 72);
            this.txtIdCustomer.Margin = new System.Windows.Forms.Padding(5);
            this.txtIdCustomer.Name = "txtIdCustomer";
            this.txtIdCustomer.Size = new System.Drawing.Size(220, 36);
            this.txtIdCustomer.TabIndex = 63;
            this.txtIdCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnDelete
            // 
            this.btnDelete.Animated = true;
            this.btnDelete.BorderRadius = 4;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.IndicateFocus = true;
            this.btnDelete.Location = new System.Drawing.Point(202, 450);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(156, 36);
            this.btnDelete.TabIndex = 60;
            this.btnDelete.Text = "Xóa thông tin";
            this.btnDelete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // btnExport
            // 
            this.btnExport.Animated = true;
            this.btnExport.BorderRadius = 4;
            this.btnExport.CheckedState.Parent = this.btnExport;
            this.btnExport.CustomImages.Parent = this.btnExport;
            this.btnExport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.HoverState.Parent = this.btnExport;
            this.btnExport.IndicateFocus = true;
            this.btnExport.Location = new System.Drawing.Point(364, 450);
            this.btnExport.Name = "btnExport";
            this.btnExport.ShadowDecoration.Parent = this.btnExport;
            this.btnExport.Size = new System.Drawing.Size(156, 36);
            this.btnExport.TabIndex = 59;
            this.btnExport.Text = "In danh sách";
            this.btnExport.Click += new System.EventHandler(this.Export_Click);
            // 
            // lblIdCustomer
            // 
            this.lblIdCustomer.BackColor = System.Drawing.Color.Transparent;
            this.lblIdCustomer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCustomer.ForeColor = System.Drawing.Color.Black;
            this.lblIdCustomer.IsContextMenuEnabled = false;
            this.lblIdCustomer.IsSelectionEnabled = false;
            this.lblIdCustomer.Location = new System.Drawing.Point(40, 45);
            this.lblIdCustomer.Name = "lblIdCustomer";
            this.lblIdCustomer.Size = new System.Drawing.Size(92, 19);
            this.lblIdCustomer.TabIndex = 62;
            this.lblIdCustomer.Text = "Mã khách hàng";
            // 
            // cboSex
            // 
            this.cboSex.BackColor = System.Drawing.Color.Transparent;
            this.cboSex.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.cboSex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSex.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.cboSex.FocusedColor = System.Drawing.Color.Empty;
            this.cboSex.FocusedState.Parent = this.cboSex;
            this.cboSex.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboSex.ForeColor = System.Drawing.Color.White;
            this.cboSex.HoverState.Parent = this.cboSex;
            this.cboSex.ItemHeight = 30;
            this.cboSex.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cboSex.ItemsAppearance.Parent = this.cboSex;
            this.cboSex.Location = new System.Drawing.Point(40, 285);
            this.cboSex.Name = "cboSex";
            this.cboSex.ShadowDecoration.Parent = this.cboSex;
            this.cboSex.Size = new System.Drawing.Size(220, 36);
            this.cboSex.StartIndex = 0;
            this.cboSex.TabIndex = 30;
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.btnEdit);
            this.grpCustomer.Controls.Add(this.txtIdCustomer);
            this.grpCustomer.Controls.Add(this.btnDelete);
            this.grpCustomer.Controls.Add(this.btnExport);
            this.grpCustomer.Controls.Add(this.lblIdCustomer);
            this.grpCustomer.Controls.Add(this.dtmDateOfBirth);
            this.grpCustomer.Controls.Add(this.cboSex);
            this.grpCustomer.Controls.Add(this.lblDateOfBirth);
            this.grpCustomer.Controls.Add(this.txtPhone);
            this.grpCustomer.Controls.Add(this.lblNationality);
            this.grpCustomer.Controls.Add(this.lblSex);
            this.grpCustomer.Controls.Add(this.cboNationality);
            this.grpCustomer.Controls.Add(this.lblIDcard);
            this.grpCustomer.Controls.Add(this.lblCustomerName);
            this.grpCustomer.Controls.Add(this.txtIDcard);
            this.grpCustomer.Controls.Add(this.txtCustomerName);
            this.grpCustomer.Controls.Add(this.lblPhone);
            this.grpCustomer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustomer.Location = new System.Drawing.Point(12, 211);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(560, 537);
            this.grpCustomer.TabIndex = 70;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Thông tin khách hàng";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.BackColor = System.Drawing.Color.Transparent;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.ForeColor = System.Drawing.Color.Black;
            this.lblDateOfBirth.IsContextMenuEnabled = false;
            this.lblDateOfBirth.IsSelectionEnabled = false;
            this.lblDateOfBirth.Location = new System.Drawing.Point(40, 187);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(61, 19);
            this.lblDateOfBirth.TabIndex = 30;
            this.lblDateOfBirth.Text = "Ngày sinh ";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.White;
            this.txtPhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtPhone.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtPhone.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtPhone.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtPhone.BorderThickness = 1;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.Color.Black;
            this.txtPhone.isPassword = false;
            this.txtPhone.Location = new System.Drawing.Point(300, 143);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(220, 36);
            this.txtPhone.TabIndex = 27;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblNationality
            // 
            this.lblNationality.BackColor = System.Drawing.Color.Transparent;
            this.lblNationality.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationality.ForeColor = System.Drawing.Color.Black;
            this.lblNationality.IsContextMenuEnabled = false;
            this.lblNationality.IsSelectionEnabled = false;
            this.lblNationality.Location = new System.Drawing.Point(300, 45);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(58, 19);
            this.lblNationality.TabIndex = 54;
            this.lblNationality.Text = "Quốc tịch";
            // 
            // lblSex
            // 
            this.lblSex.BackColor = System.Drawing.Color.Transparent;
            this.lblSex.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.ForeColor = System.Drawing.Color.Black;
            this.lblSex.IsContextMenuEnabled = false;
            this.lblSex.IsSelectionEnabled = false;
            this.lblSex.Location = new System.Drawing.Point(40, 258);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(51, 19);
            this.lblSex.TabIndex = 31;
            this.lblSex.Text = "Giới tính ";
            // 
            // cboNationality
            // 
            this.cboNationality.BackColor = System.Drawing.Color.Transparent;
            this.cboNationality.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.cboNationality.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNationality.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.cboNationality.FocusedColor = System.Drawing.Color.Empty;
            this.cboNationality.FocusedState.Parent = this.cboNationality;
            this.cboNationality.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboNationality.ForeColor = System.Drawing.Color.White;
            this.cboNationality.HoverState.Parent = this.cboNationality;
            this.cboNationality.ItemHeight = 30;
            this.cboNationality.Items.AddRange(new object[] {
            "Việt Nam",
            "Khác"});
            this.cboNationality.ItemsAppearance.Parent = this.cboNationality;
            this.cboNationality.Location = new System.Drawing.Point(300, 72);
            this.cboNationality.Name = "cboNationality";
            this.cboNationality.ShadowDecoration.Parent = this.cboNationality;
            this.cboNationality.Size = new System.Drawing.Size(220, 36);
            this.cboNationality.StartIndex = 0;
            this.cboNationality.TabIndex = 30;
            // 
            // lblIDcard
            // 
            this.lblIDcard.BackColor = System.Drawing.Color.Transparent;
            this.lblIDcard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDcard.ForeColor = System.Drawing.Color.Black;
            this.lblIDcard.IsContextMenuEnabled = false;
            this.lblIDcard.IsSelectionEnabled = false;
            this.lblIDcard.Location = new System.Drawing.Point(40, 329);
            this.lblIDcard.Name = "lblIDcard";
            this.lblIDcard.Size = new System.Drawing.Size(131, 19);
            this.lblIDcard.TabIndex = 32;
            this.lblIDcard.Text = "Chứng minh nhân dân ";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.ForeColor = System.Drawing.Color.Black;
            this.lblCustomerName.IsContextMenuEnabled = false;
            this.lblCustomerName.IsSelectionEnabled = false;
            this.lblCustomerName.Location = new System.Drawing.Point(40, 116);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(94, 19);
            this.lblCustomerName.TabIndex = 48;
            this.lblCustomerName.Text = "Tên khách hàng";
            // 
            // txtIDcard
            // 
            this.txtIDcard.BackColor = System.Drawing.Color.White;
            this.txtIDcard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtIDcard.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtIDcard.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtIDcard.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtIDcard.BorderThickness = 1;
            this.txtIDcard.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDcard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDcard.ForeColor = System.Drawing.Color.Black;
            this.txtIDcard.isPassword = false;
            this.txtIDcard.Location = new System.Drawing.Point(40, 356);
            this.txtIDcard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIDcard.Name = "txtIDcard";
            this.txtIDcard.Size = new System.Drawing.Size(220, 36);
            this.txtIDcard.TabIndex = 25;
            this.txtIDcard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.Color.White;
            this.txtCustomerName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtCustomerName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtCustomerName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtCustomerName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtCustomerName.BorderThickness = 1;
            this.txtCustomerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.ForeColor = System.Drawing.Color.Black;
            this.txtCustomerName.isPassword = false;
            this.txtCustomerName.Location = new System.Drawing.Point(40, 143);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(5);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(220, 36);
            this.txtCustomerName.TabIndex = 47;
            this.txtCustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblPhone
            // 
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.Black;
            this.lblPhone.IsContextMenuEnabled = false;
            this.lblPhone.IsSelectionEnabled = false;
            this.lblPhone.Location = new System.Drawing.Point(300, 116);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(80, 19);
            this.lblPhone.TabIndex = 34;
            this.lblPhone.Text = "Số điện thoại ";
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.btnRefresh);
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.txtSearch);
            this.grpSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearch.Location = new System.Drawing.Point(12, 41);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(560, 164);
            this.grpSearch.TabIndex = 69;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Tìm kiếm";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Animated = true;
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.BorderColor = System.Drawing.Color.White;
            this.btnRefresh.BorderRadius = 4;
            this.btnRefresh.CheckedState.Parent = this.btnRefresh;
            this.btnRefresh.CustomImages.Parent = this.btnRefresh;
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.HoverState.Parent = this.btnRefresh;
            this.btnRefresh.IndicateFocus = true;
            this.btnRefresh.Location = new System.Drawing.Point(420, 69);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ShadowDecoration.Parent = this.btnRefresh;
            this.btnRefresh.Size = new System.Drawing.Size(100, 36);
            this.btnRefresh.TabIndex = 62;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Animated = true;
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BorderColor = System.Drawing.Color.White;
            this.btnSearch.BorderRadius = 4;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.IndicateFocus = true;
            this.btnSearch.Location = new System.Drawing.Point(314, 69);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(100, 36);
            this.btnSearch.TabIndex = 61;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.Search_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtSearch.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtSearch.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtSearch.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.txtSearch.BorderThickness = 1;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.isPassword = false;
            this.txtSearch.Location = new System.Drawing.Point(40, 69);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(266, 36);
            this.txtSearch.TabIndex = 17;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.OnValueChanged += new System.EventHandler(this.Search_OnValueChanged);
            // 
            // DragControl
            // 
            this.DragControl.ContainerControl = this;
            this.DragControl.TargetControl = this;
            // 
            // FCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1340, 760);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.grpSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FCustomer";
            this.Load += new System.EventHandler(this.FCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker dtmDateOfBirth;
        private Guna.UI2.WinForms.Guna2ShadowForm ShadowForm;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimize;
        private Guna.UI2.WinForms.Guna2Button btnReturn;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtIdCustomer;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnExport;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblIdCustomer;
        private Guna.UI2.WinForms.Guna2ComboBox cboSex;
        private System.Windows.Forms.GroupBox grpCustomer;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDateOfBirth;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPhone;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNationality;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSex;
        private Guna.UI2.WinForms.Guna2ComboBox cboNationality;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblIDcard;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCustomerName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtIDcard;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCustomerName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPhone;
        private System.Windows.Forms.GroupBox grpSearch;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSearch;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
    }
}