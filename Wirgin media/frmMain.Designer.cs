namespace Wirgin_media
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpCustomerSelect = new System.Windows.Forms.GroupBox();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.grpCustomerDetails = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.dgdCustomerDetails = new System.Windows.Forms.DataGridView();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lstServices = new System.Windows.Forms.ListBox();
            this.grpServices = new System.Windows.Forms.GroupBox();
            this.grpServiceDetails = new System.Windows.Forms.GroupBox();
            this.dgdServiceDetails = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grpDashboard = new System.Windows.Forms.GroupBox();
            this.lblServiceDash = new System.Windows.Forms.Label();
            this.lblCustomerDash = new System.Windows.Forms.Label();
            this.btnServiceCancel = new System.Windows.Forms.Button();
            this.btnDeleteService = new System.Windows.Forms.Button();
            this.btnEditServiceConfirm = new System.Windows.Forms.Button();
            this.btnAddService = new System.Windows.Forms.Button();
            this.btnServiceConfirm = new System.Windows.Forms.Button();
            this.btnEditService = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnEditCustomerConfirm = new System.Windows.Forms.Button();
            this.btnCustomerCancel = new System.Windows.Forms.Button();
            this.btnCustomerConfirm = new System.Windows.Forms.Button();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.grpCustomerSearch = new System.Windows.Forms.GroupBox();
            this.txtCustomerSearch = new System.Windows.Forms.TextBox();
            this.txtServiceSearch = new System.Windows.Forms.TextBox();
            this.grpServiceSearch = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpCustomerSelect.SuspendLayout();
            this.grpCustomerDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdCustomerDetails)).BeginInit();
            this.grpServices.SuspendLayout();
            this.grpServiceDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdServiceDetails)).BeginInit();
            this.grpDashboard.SuspendLayout();
            this.grpCustomerSearch.SuspendLayout();
            this.grpServiceSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(246, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(591, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // grpCustomerSelect
            // 
            this.grpCustomerSelect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpCustomerSelect.Controls.Add(this.lstCustomers);
            this.grpCustomerSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpCustomerSelect.Location = new System.Drawing.Point(354, 231);
            this.grpCustomerSelect.Name = "grpCustomerSelect";
            this.grpCustomerSelect.Size = new System.Drawing.Size(640, 125);
            this.grpCustomerSelect.TabIndex = 6;
            this.grpCustomerSelect.TabStop = false;
            this.grpCustomerSelect.Text = "Please select a customer";
            // 
            // lstCustomers
            // 
            this.lstCustomers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lstCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.ItemHeight = 20;
            this.lstCustomers.Location = new System.Drawing.Point(6, 25);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(628, 80);
            this.lstCustomers.TabIndex = 0;
            this.lstCustomers.SelectedIndexChanged += new System.EventHandler(this.lstCustomers_SelectedIndexChanged);
            // 
            // grpCustomerDetails
            // 
            this.grpCustomerDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpCustomerDetails.Controls.Add(this.label1);
            this.grpCustomerDetails.Controls.Add(this.lblId);
            this.grpCustomerDetails.Controls.Add(this.dgdCustomerDetails);
            this.grpCustomerDetails.Controls.Add(this.lblFirstName);
            this.grpCustomerDetails.Controls.Add(this.lblSurname);
            this.grpCustomerDetails.Controls.Add(this.lblPostcode);
            this.grpCustomerDetails.Controls.Add(this.lblAddress);
            this.grpCustomerDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpCustomerDetails.Location = new System.Drawing.Point(354, 362);
            this.grpCustomerDetails.Name = "grpCustomerDetails";
            this.grpCustomerDetails.Size = new System.Drawing.Size(640, 188);
            this.grpCustomerDetails.TabIndex = 7;
            this.grpCustomerDetails.TabStop = false;
            this.grpCustomerDetails.Text = "Customer details";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Number Of Services:";
            // 
            // lblId
            // 
            this.lblId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(142, 25);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(27, 20);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "Id:";
            // 
            // dgdCustomerDetails
            // 
            this.dgdCustomerDetails.AllowUserToAddRows = false;
            this.dgdCustomerDetails.AllowUserToDeleteRows = false;
            this.dgdCustomerDetails.AllowUserToResizeColumns = false;
            this.dgdCustomerDetails.AllowUserToResizeRows = false;
            this.dgdCustomerDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgdCustomerDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgdCustomerDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgdCustomerDetails.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgdCustomerDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgdCustomerDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgdCustomerDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgdCustomerDetails.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgdCustomerDetails.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgdCustomerDetails.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgdCustomerDetails.Enabled = false;
            this.dgdCustomerDetails.Location = new System.Drawing.Point(175, 25);
            this.dgdCustomerDetails.MultiSelect = false;
            this.dgdCustomerDetails.Name = "dgdCustomerDetails";
            this.dgdCustomerDetails.RowHeadersVisible = false;
            this.dgdCustomerDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgdCustomerDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgdCustomerDetails.Size = new System.Drawing.Size(459, 151);
            this.dgdCustomerDetails.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(78, 50);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(90, 20);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblSurname
            // 
            this.lblSurname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(89, 77);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(78, 20);
            this.lblSurname.TabIndex = 4;
            this.lblSurname.Text = "Surname:";
            // 
            // lblPostcode
            // 
            this.lblPostcode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Location = new System.Drawing.Point(85, 124);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(80, 20);
            this.lblPostcode.TabIndex = 6;
            this.lblPostcode.Text = "Postcode:";
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(93, 102);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(72, 20);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Address:";
            // 
            // lstServices
            // 
            this.lstServices.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lstServices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstServices.Enabled = false;
            this.lstServices.FormattingEnabled = true;
            this.lstServices.ItemHeight = 20;
            this.lstServices.Items.AddRange(new object[] {
            "Nothing will be shown until a customer has been selected."});
            this.lstServices.Location = new System.Drawing.Point(6, 25);
            this.lstServices.Name = "lstServices";
            this.lstServices.Size = new System.Drawing.Size(628, 140);
            this.lstServices.TabIndex = 0;
            this.lstServices.SelectedIndexChanged += new System.EventHandler(this.lstServices_SelectedIndexChanged);
            // 
            // grpServices
            // 
            this.grpServices.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpServices.Controls.Add(this.lstServices);
            this.grpServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpServices.Location = new System.Drawing.Point(354, 632);
            this.grpServices.Name = "grpServices";
            this.grpServices.Size = new System.Drawing.Size(640, 188);
            this.grpServices.TabIndex = 8;
            this.grpServices.TabStop = false;
            this.grpServices.Text = "Please select a service  ";
            // 
            // grpServiceDetails
            // 
            this.grpServiceDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpServiceDetails.Controls.Add(this.dgdServiceDetails);
            this.grpServiceDetails.Controls.Add(this.label3);
            this.grpServiceDetails.Controls.Add(this.label4);
            this.grpServiceDetails.Controls.Add(this.label5);
            this.grpServiceDetails.Controls.Add(this.label6);
            this.grpServiceDetails.Controls.Add(this.label7);
            this.grpServiceDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpServiceDetails.Location = new System.Drawing.Point(354, 826);
            this.grpServiceDetails.Name = "grpServiceDetails";
            this.grpServiceDetails.Size = new System.Drawing.Size(640, 157);
            this.grpServiceDetails.TabIndex = 9;
            this.grpServiceDetails.TabStop = false;
            this.grpServiceDetails.Text = "Service details";
            // 
            // dgdServiceDetails
            // 
            this.dgdServiceDetails.AllowUserToAddRows = false;
            this.dgdServiceDetails.AllowUserToDeleteRows = false;
            this.dgdServiceDetails.AllowUserToResizeColumns = false;
            this.dgdServiceDetails.AllowUserToResizeRows = false;
            this.dgdServiceDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgdServiceDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgdServiceDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgdServiceDetails.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgdServiceDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgdServiceDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgdServiceDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgdServiceDetails.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgdServiceDetails.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgdServiceDetails.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgdServiceDetails.Enabled = false;
            this.dgdServiceDetails.Location = new System.Drawing.Point(175, 24);
            this.dgdServiceDetails.MultiSelect = false;
            this.dgdServiceDetails.Name = "dgdServiceDetails";
            this.dgdServiceDetails.RowHeadersVisible = false;
            this.dgdServiceDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgdServiceDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgdServiceDetails.Size = new System.Drawing.Size(459, 127);
            this.dgdServiceDetails.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Id:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Description:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Start Date:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Notes:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Date last contacted:";
            // 
            // grpDashboard
            // 
            this.grpDashboard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpDashboard.Controls.Add(this.lblServiceDash);
            this.grpDashboard.Controls.Add(this.lblCustomerDash);
            this.grpDashboard.Controls.Add(this.btnServiceCancel);
            this.grpDashboard.Controls.Add(this.btnDeleteService);
            this.grpDashboard.Controls.Add(this.btnEditServiceConfirm);
            this.grpDashboard.Controls.Add(this.btnAddService);
            this.grpDashboard.Controls.Add(this.btnServiceConfirm);
            this.grpDashboard.Controls.Add(this.btnEditService);
            this.grpDashboard.Controls.Add(this.btnAddCustomer);
            this.grpDashboard.Controls.Add(this.btnEditCustomerConfirm);
            this.grpDashboard.Controls.Add(this.btnCustomerCancel);
            this.grpDashboard.Controls.Add(this.btnCustomerConfirm);
            this.grpDashboard.Controls.Add(this.btnEditCustomer);
            this.grpDashboard.Controls.Add(this.btnDeleteCustomer);
            this.grpDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpDashboard.Location = new System.Drawing.Point(44, 231);
            this.grpDashboard.Name = "grpDashboard";
            this.grpDashboard.Size = new System.Drawing.Size(293, 676);
            this.grpDashboard.TabIndex = 1;
            this.grpDashboard.TabStop = false;
            this.grpDashboard.Text = "Dashboard";
            // 
            // lblServiceDash
            // 
            this.lblServiceDash.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblServiceDash.AutoSize = true;
            this.lblServiceDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline);
            this.lblServiceDash.Location = new System.Drawing.Point(70, 405);
            this.lblServiceDash.Name = "lblServiceDash";
            this.lblServiceDash.Size = new System.Drawing.Size(116, 20);
            this.lblServiceDash.TabIndex = 23;
            this.lblServiceDash.Text = "Service actions";
            // 
            // lblCustomerDash
            // 
            this.lblCustomerDash.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCustomerDash.AutoSize = true;
            this.lblCustomerDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline);
            this.lblCustomerDash.Location = new System.Drawing.Point(70, 63);
            this.lblCustomerDash.Name = "lblCustomerDash";
            this.lblCustomerDash.Size = new System.Drawing.Size(133, 20);
            this.lblCustomerDash.TabIndex = 22;
            this.lblCustomerDash.Text = "Customer actions";
            // 
            // btnServiceCancel
            // 
            this.btnServiceCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnServiceCancel.ForeColor = System.Drawing.Color.Red;
            this.btnServiceCancel.Location = new System.Drawing.Point(150, 520);
            this.btnServiceCancel.Name = "btnServiceCancel";
            this.btnServiceCancel.Size = new System.Drawing.Size(138, 39);
            this.btnServiceCancel.TabIndex = 21;
            this.btnServiceCancel.Text = "Cancel Action";
            this.btnServiceCancel.UseVisualStyleBackColor = true;
            this.btnServiceCancel.Click += new System.EventHandler(this.btnServiceCancel_Click);
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteService.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteService.Location = new System.Drawing.Point(6, 519);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(138, 39);
            this.btnDeleteService.TabIndex = 18;
            this.btnDeleteService.Text = "Delete Service";
            this.btnDeleteService.UseVisualStyleBackColor = true;
            this.btnDeleteService.Click += new System.EventHandler(this.btnDeleteService_Click);
            // 
            // btnEditServiceConfirm
            // 
            this.btnEditServiceConfirm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditServiceConfirm.Enabled = false;
            this.btnEditServiceConfirm.ForeColor = System.Drawing.Color.Black;
            this.btnEditServiceConfirm.Location = new System.Drawing.Point(150, 475);
            this.btnEditServiceConfirm.Name = "btnEditServiceConfirm";
            this.btnEditServiceConfirm.Size = new System.Drawing.Size(138, 39);
            this.btnEditServiceConfirm.TabIndex = 20;
            this.btnEditServiceConfirm.Text = "Confirm";
            this.btnEditServiceConfirm.UseVisualStyleBackColor = true;
            this.btnEditServiceConfirm.Click += new System.EventHandler(this.btnEditServiceConfirm_Click);
            // 
            // btnAddService
            // 
            this.btnAddService.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddService.ForeColor = System.Drawing.Color.Black;
            this.btnAddService.Location = new System.Drawing.Point(6, 428);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(138, 39);
            this.btnAddService.TabIndex = 16;
            this.btnAddService.Text = "Add Service";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // btnServiceConfirm
            // 
            this.btnServiceConfirm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnServiceConfirm.Enabled = false;
            this.btnServiceConfirm.ForeColor = System.Drawing.Color.Black;
            this.btnServiceConfirm.Location = new System.Drawing.Point(150, 428);
            this.btnServiceConfirm.Name = "btnServiceConfirm";
            this.btnServiceConfirm.Size = new System.Drawing.Size(138, 39);
            this.btnServiceConfirm.TabIndex = 19;
            this.btnServiceConfirm.Text = "Confirm";
            this.btnServiceConfirm.UseVisualStyleBackColor = true;
            this.btnServiceConfirm.Click += new System.EventHandler(this.btnServiceConfirm_Click);
            // 
            // btnEditService
            // 
            this.btnEditService.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditService.ForeColor = System.Drawing.Color.Black;
            this.btnEditService.Location = new System.Drawing.Point(6, 476);
            this.btnEditService.Name = "btnEditService";
            this.btnEditService.Size = new System.Drawing.Size(138, 39);
            this.btnEditService.TabIndex = 17;
            this.btnEditService.Text = "Edit Service";
            this.btnEditService.UseVisualStyleBackColor = true;
            this.btnEditService.Click += new System.EventHandler(this.btnEditService_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnAddCustomer.Location = new System.Drawing.Point(6, 86);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(138, 39);
            this.btnAddCustomer.TabIndex = 10;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnEditCustomerConfirm
            // 
            this.btnEditCustomerConfirm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditCustomerConfirm.Enabled = false;
            this.btnEditCustomerConfirm.ForeColor = System.Drawing.Color.Black;
            this.btnEditCustomerConfirm.Location = new System.Drawing.Point(150, 131);
            this.btnEditCustomerConfirm.Name = "btnEditCustomerConfirm";
            this.btnEditCustomerConfirm.Size = new System.Drawing.Size(138, 39);
            this.btnEditCustomerConfirm.TabIndex = 15;
            this.btnEditCustomerConfirm.Text = "Confirm";
            this.btnEditCustomerConfirm.UseVisualStyleBackColor = true;
            this.btnEditCustomerConfirm.Click += new System.EventHandler(this.btnEditCustomerConfirm_Click);
            // 
            // btnCustomerCancel
            // 
            this.btnCustomerCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCustomerCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCustomerCancel.Location = new System.Drawing.Point(150, 179);
            this.btnCustomerCancel.Name = "btnCustomerCancel";
            this.btnCustomerCancel.Size = new System.Drawing.Size(138, 39);
            this.btnCustomerCancel.TabIndex = 13;
            this.btnCustomerCancel.Text = "Cancel Action";
            this.btnCustomerCancel.UseVisualStyleBackColor = true;
            this.btnCustomerCancel.Click += new System.EventHandler(this.btnCustomerCancel_Click);
            // 
            // btnCustomerConfirm
            // 
            this.btnCustomerConfirm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCustomerConfirm.Enabled = false;
            this.btnCustomerConfirm.ForeColor = System.Drawing.Color.Black;
            this.btnCustomerConfirm.Location = new System.Drawing.Point(150, 86);
            this.btnCustomerConfirm.Name = "btnCustomerConfirm";
            this.btnCustomerConfirm.Size = new System.Drawing.Size(138, 39);
            this.btnCustomerConfirm.TabIndex = 14;
            this.btnCustomerConfirm.Text = "Confirm";
            this.btnCustomerConfirm.UseVisualStyleBackColor = true;
            this.btnCustomerConfirm.Click += new System.EventHandler(this.btnCustomerConfirm_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnEditCustomer.Location = new System.Drawing.Point(6, 131);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(138, 39);
            this.btnEditCustomer.TabIndex = 11;
            this.btnEditCustomer.Text = "Edit Customer";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteCustomer.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(6, 179);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(138, 39);
            this.btnDeleteCustomer.TabIndex = 12;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // grpCustomerSearch
            // 
            this.grpCustomerSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpCustomerSearch.Controls.Add(this.txtCustomerSearch);
            this.grpCustomerSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpCustomerSearch.Location = new System.Drawing.Point(212, 164);
            this.grpCustomerSearch.Name = "grpCustomerSearch";
            this.grpCustomerSearch.Size = new System.Drawing.Size(651, 61);
            this.grpCustomerSearch.TabIndex = 10;
            this.grpCustomerSearch.TabStop = false;
            this.grpCustomerSearch.Text = "Start searching and customers will be filtered below";
            // 
            // txtCustomerSearch
            // 
            this.txtCustomerSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCustomerSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtCustomerSearch.Location = new System.Drawing.Point(81, 25);
            this.txtCustomerSearch.MaxLength = 39;
            this.txtCustomerSearch.Name = "txtCustomerSearch";
            this.txtCustomerSearch.Size = new System.Drawing.Size(490, 26);
            this.txtCustomerSearch.TabIndex = 7;
            this.txtCustomerSearch.Text = "Search";
            this.txtCustomerSearch.TextChanged += new System.EventHandler(this.txtCustomerSearch_TextChanged);
            // 
            // txtServiceSearch
            // 
            this.txtServiceSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtServiceSearch.Enabled = false;
            this.txtServiceSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtServiceSearch.Location = new System.Drawing.Point(81, 25);
            this.txtServiceSearch.MaxLength = 39;
            this.txtServiceSearch.Name = "txtServiceSearch";
            this.txtServiceSearch.Size = new System.Drawing.Size(490, 26);
            this.txtServiceSearch.TabIndex = 7;
            this.txtServiceSearch.Text = "Search";
            this.txtServiceSearch.TextChanged += new System.EventHandler(this.txtServiceSearch_TextChanged);
            // 
            // grpServiceSearch
            // 
            this.grpServiceSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpServiceSearch.Controls.Add(this.txtServiceSearch);
            this.grpServiceSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpServiceSearch.Location = new System.Drawing.Point(349, 556);
            this.grpServiceSearch.Name = "grpServiceSearch";
            this.grpServiceSearch.Size = new System.Drawing.Size(651, 61);
            this.grpServiceSearch.TabIndex = 11;
            this.grpServiceSearch.TabStop = false;
            this.grpServiceSearch.Text = "Select a customer, start searching and services will be filtered below";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(1134, 0);
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1150, 637);
            this.Controls.Add(this.grpServiceSearch);
            this.Controls.Add(this.grpServiceDetails);
            this.Controls.Add(this.grpCustomerDetails);
            this.Controls.Add(this.grpCustomerSelect);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpCustomerSearch);
            this.Controls.Add(this.grpServices);
            this.Controls.Add(this.grpDashboard);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Wirgin Media";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Click += new System.EventHandler(this.frmMain_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpCustomerSelect.ResumeLayout(false);
            this.grpCustomerDetails.ResumeLayout(false);
            this.grpCustomerDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdCustomerDetails)).EndInit();
            this.grpServices.ResumeLayout(false);
            this.grpServiceDetails.ResumeLayout(false);
            this.grpServiceDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdServiceDetails)).EndInit();
            this.grpDashboard.ResumeLayout(false);
            this.grpDashboard.PerformLayout();
            this.grpCustomerSearch.ResumeLayout(false);
            this.grpCustomerSearch.PerformLayout();
            this.grpServiceSearch.ResumeLayout(false);
            this.grpServiceSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpCustomerSelect;
        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.GroupBox grpCustomerDetails;
        private System.Windows.Forms.ListBox lstServices;
        private System.Windows.Forms.GroupBox grpServices;
        private System.Windows.Forms.GroupBox grpServiceDetails;
        private System.Windows.Forms.DataGridView dgdCustomerDetails;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgdServiceDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpDashboard;
        private System.Windows.Forms.Label lblServiceDash;
        private System.Windows.Forms.Label lblCustomerDash;
        private System.Windows.Forms.Button btnServiceCancel;
        private System.Windows.Forms.Button btnDeleteService;
        private System.Windows.Forms.Button btnEditServiceConfirm;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Button btnServiceConfirm;
        private System.Windows.Forms.Button btnEditService;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnEditCustomerConfirm;
        private System.Windows.Forms.Button btnCustomerCancel;
        private System.Windows.Forms.Button btnCustomerConfirm;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.GroupBox grpCustomerSearch;
        private System.Windows.Forms.TextBox txtCustomerSearch;
        private System.Windows.Forms.TextBox txtServiceSearch;
        private System.Windows.Forms.GroupBox grpServiceSearch;
    }
}

