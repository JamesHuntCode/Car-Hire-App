namespace SOFT151_Coursework
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
            this.lstAllCompanies = new System.Windows.Forms.ListBox();
            this.lblCompaniesHeader = new System.Windows.Forms.Label();
            this.txtSearchCompanies = new System.Windows.Forms.TextBox();
            this.btnAddNewCompany = new System.Windows.Forms.Button();
            this.btnUpdateCompany = new System.Windows.Forms.Button();
            this.lstRecentActivity = new System.Windows.Forms.ListBox();
            this.txtSearchRecentActivity = new System.Windows.Forms.TextBox();
            this.lblRecentActivityHeader = new System.Windows.Forms.Label();
            this.btnRemoveCompany = new System.Windows.Forms.Button();
            this.btnSearchCompanies = new System.Windows.Forms.Button();
            this.btnSearchRecentActivity = new System.Windows.Forms.Button();
            this.btnRefreshCompanies = new System.Windows.Forms.Button();
            this.btnRefreshNotifications = new System.Windows.Forms.Button();
            this.lblDisplayDate = new System.Windows.Forms.Label();
            this.btnClearAllCompanies = new System.Windows.Forms.Button();
            this.btnClearAllNotifications = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.lblTheTime = new System.Windows.Forms.Label();
            this.picBanner = new System.Windows.Forms.PictureBox();
            this.lstCars = new System.Windows.Forms.ListBox();
            this.btnRefreshCars = new System.Windows.Forms.Button();
            this.btnSearchCar = new System.Windows.Forms.Button();
            this.txtSearchCars = new System.Windows.Forms.TextBox();
            this.lblCarsHeader = new System.Windows.Forms.Label();
            this.btnRemoveCar = new System.Windows.Forms.Button();
            this.btnUpdateCar = new System.Windows.Forms.Button();
            this.btnAddNewCar = new System.Windows.Forms.Button();
            this.lblCompName = new System.Windows.Forms.Label();
            this.lblCompID = new System.Windows.Forms.Label();
            this.lblCompAddress = new System.Windows.Forms.Label();
            this.lblCompPostcode = new System.Windows.Forms.Label();
            this.lblCompCarCount = new System.Windows.Forms.Label();
            this.txtDisplayCarComments = new System.Windows.Forms.RichTextBox();
            this.lblCarReg = new System.Windows.Forms.Label();
            this.lblCarComments = new System.Windows.Forms.Label();
            this.lblFuelType = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCarModel = new System.Windows.Forms.Label();
            this.lblCarID = new System.Windows.Forms.Label();
            this.lblCarMake = new System.Windows.Forms.Label();
            this.grpCompanySummary = new System.Windows.Forms.GroupBox();
            this.grpCarSummary = new System.Windows.Forms.GroupBox();
            this.lblLastServiced = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).BeginInit();
            this.grpCompanySummary.SuspendLayout();
            this.grpCarSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstAllCompanies
            // 
            this.lstAllCompanies.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAllCompanies.FormattingEnabled = true;
            this.lstAllCompanies.ItemHeight = 36;
            this.lstAllCompanies.Location = new System.Drawing.Point(12, 579);
            this.lstAllCompanies.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstAllCompanies.Name = "lstAllCompanies";
            this.lstAllCompanies.Size = new System.Drawing.Size(1074, 544);
            this.lstAllCompanies.TabIndex = 0;
            this.lstAllCompanies.SelectedIndexChanged += new System.EventHandler(this.lstAllCompanies_SelectedIndexChanged);
            // 
            // lblCompaniesHeader
            // 
            this.lblCompaniesHeader.AutoSize = true;
            this.lblCompaniesHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompaniesHeader.Location = new System.Drawing.Point(4, 483);
            this.lblCompaniesHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompaniesHeader.Name = "lblCompaniesHeader";
            this.lblCompaniesHeader.Size = new System.Drawing.Size(354, 44);
            this.lblCompaniesHeader.TabIndex = 2;
            this.lblCompaniesHeader.Text = "Search Companies:";
            // 
            // txtSearchCompanies
            // 
            this.txtSearchCompanies.Location = new System.Drawing.Point(12, 533);
            this.txtSearchCompanies.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchCompanies.Name = "txtSearchCompanies";
            this.txtSearchCompanies.Size = new System.Drawing.Size(614, 31);
            this.txtSearchCompanies.TabIndex = 5;
            // 
            // btnAddNewCompany
            // 
            this.btnAddNewCompany.Location = new System.Drawing.Point(12, 1148);
            this.btnAddNewCompany.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddNewCompany.Name = "btnAddNewCompany";
            this.btnAddNewCompany.Size = new System.Drawing.Size(346, 129);
            this.btnAddNewCompany.TabIndex = 7;
            this.btnAddNewCompany.Text = "Add New Company";
            this.btnAddNewCompany.UseVisualStyleBackColor = true;
            this.btnAddNewCompany.Click += new System.EventHandler(this.btnAddNewCompany_Click);
            // 
            // btnUpdateCompany
            // 
            this.btnUpdateCompany.Location = new System.Drawing.Point(366, 1148);
            this.btnUpdateCompany.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateCompany.Name = "btnUpdateCompany";
            this.btnUpdateCompany.Size = new System.Drawing.Size(366, 129);
            this.btnUpdateCompany.TabIndex = 11;
            this.btnUpdateCompany.Text = "Update Selected Company";
            this.btnUpdateCompany.UseVisualStyleBackColor = true;
            this.btnUpdateCompany.Click += new System.EventHandler(this.btnUpdateCompany_Click);
            // 
            // lstRecentActivity
            // 
            this.lstRecentActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRecentActivity.FormattingEnabled = true;
            this.lstRecentActivity.ItemHeight = 36;
            this.lstRecentActivity.Location = new System.Drawing.Point(12, 1402);
            this.lstRecentActivity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstRecentActivity.Name = "lstRecentActivity";
            this.lstRecentActivity.Size = new System.Drawing.Size(2156, 292);
            this.lstRecentActivity.TabIndex = 14;
            // 
            // txtSearchRecentActivity
            // 
            this.txtSearchRecentActivity.Location = new System.Drawing.Point(12, 1354);
            this.txtSearchRecentActivity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchRecentActivity.Name = "txtSearchRecentActivity";
            this.txtSearchRecentActivity.Size = new System.Drawing.Size(546, 31);
            this.txtSearchRecentActivity.TabIndex = 15;
            // 
            // lblRecentActivityHeader
            // 
            this.lblRecentActivityHeader.AutoSize = true;
            this.lblRecentActivityHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentActivityHeader.Location = new System.Drawing.Point(4, 1304);
            this.lblRecentActivityHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecentActivityHeader.Name = "lblRecentActivityHeader";
            this.lblRecentActivityHeader.Size = new System.Drawing.Size(413, 44);
            this.lblRecentActivityHeader.TabIndex = 16;
            this.lblRecentActivityHeader.Text = "Search Recent Activity:";
            // 
            // btnRemoveCompany
            // 
            this.btnRemoveCompany.Location = new System.Drawing.Point(740, 1148);
            this.btnRemoveCompany.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveCompany.Name = "btnRemoveCompany";
            this.btnRemoveCompany.Size = new System.Drawing.Size(350, 129);
            this.btnRemoveCompany.TabIndex = 18;
            this.btnRemoveCompany.Text = "Remove Selected Company";
            this.btnRemoveCompany.UseVisualStyleBackColor = true;
            this.btnRemoveCompany.Click += new System.EventHandler(this.btnRemoveCompany_Click);
            // 
            // btnSearchCompanies
            // 
            this.btnSearchCompanies.Location = new System.Drawing.Point(638, 533);
            this.btnSearchCompanies.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchCompanies.Name = "btnSearchCompanies";
            this.btnSearchCompanies.Size = new System.Drawing.Size(222, 38);
            this.btnSearchCompanies.TabIndex = 19;
            this.btnSearchCompanies.Text = "Search";
            this.btnSearchCompanies.UseVisualStyleBackColor = true;
            this.btnSearchCompanies.Click += new System.EventHandler(this.btnSearchCompanies_Click);
            // 
            // btnSearchRecentActivity
            // 
            this.btnSearchRecentActivity.Location = new System.Drawing.Point(570, 1352);
            this.btnSearchRecentActivity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchRecentActivity.Name = "btnSearchRecentActivity";
            this.btnSearchRecentActivity.Size = new System.Drawing.Size(260, 40);
            this.btnSearchRecentActivity.TabIndex = 20;
            this.btnSearchRecentActivity.Text = "Search";
            this.btnSearchRecentActivity.UseVisualStyleBackColor = true;
            this.btnSearchRecentActivity.Click += new System.EventHandler(this.btnSearchRecentActivity_Click);
            // 
            // btnRefreshCompanies
            // 
            this.btnRefreshCompanies.Location = new System.Drawing.Point(868, 535);
            this.btnRefreshCompanies.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefreshCompanies.Name = "btnRefreshCompanies";
            this.btnRefreshCompanies.Size = new System.Drawing.Size(222, 38);
            this.btnRefreshCompanies.TabIndex = 21;
            this.btnRefreshCompanies.Text = "Cancel Search";
            this.btnRefreshCompanies.UseVisualStyleBackColor = true;
            this.btnRefreshCompanies.Click += new System.EventHandler(this.btnRefreshCompanies_Click);
            // 
            // btnRefreshNotifications
            // 
            this.btnRefreshNotifications.Location = new System.Drawing.Point(838, 1352);
            this.btnRefreshNotifications.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefreshNotifications.Name = "btnRefreshNotifications";
            this.btnRefreshNotifications.Size = new System.Drawing.Size(252, 40);
            this.btnRefreshNotifications.TabIndex = 22;
            this.btnRefreshNotifications.Text = "Cancel Search";
            this.btnRefreshNotifications.UseVisualStyleBackColor = true;
            this.btnRefreshNotifications.Click += new System.EventHandler(this.btnRefreshNotifications_Click);
            // 
            // lblDisplayDate
            // 
            this.lblDisplayDate.AutoSize = true;
            this.lblDisplayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayDate.ForeColor = System.Drawing.Color.Black;
            this.lblDisplayDate.Location = new System.Drawing.Point(2558, 17);
            this.lblDisplayDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDisplayDate.Name = "lblDisplayDate";
            this.lblDisplayDate.Size = new System.Drawing.Size(205, 37);
            this.lblDisplayDate.TabIndex = 24;
            this.lblDisplayDate.Text = "Todays\' Date";
            // 
            // btnClearAllCompanies
            // 
            this.btnClearAllCompanies.Location = new System.Drawing.Point(1454, 1352);
            this.btnClearAllCompanies.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClearAllCompanies.Name = "btnClearAllCompanies";
            this.btnClearAllCompanies.Size = new System.Drawing.Size(464, 40);
            this.btnClearAllCompanies.TabIndex = 25;
            this.btnClearAllCompanies.Text = "Remove All Data (Not Recommended)\r\n";
            this.btnClearAllCompanies.UseVisualStyleBackColor = true;
            this.btnClearAllCompanies.Click += new System.EventHandler(this.btnClearAllCompanies_Click);
            // 
            // btnClearAllNotifications
            // 
            this.btnClearAllNotifications.Location = new System.Drawing.Point(1098, 1352);
            this.btnClearAllNotifications.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClearAllNotifications.Name = "btnClearAllNotifications";
            this.btnClearAllNotifications.Size = new System.Drawing.Size(348, 40);
            this.btnClearAllNotifications.TabIndex = 26;
            this.btnClearAllNotifications.Text = "Clear All Notifications";
            this.btnClearAllNotifications.UseVisualStyleBackColor = true;
            this.btnClearAllNotifications.Click += new System.EventHandler(this.btnClearAllNotifications_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(1926, 1352);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(246, 40);
            this.btnAbout.TabIndex = 27;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // lblTheTime
            // 
            this.lblTheTime.AutoSize = true;
            this.lblTheTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheTime.ForeColor = System.Drawing.Color.Black;
            this.lblTheTime.Location = new System.Drawing.Point(4, 17);
            this.lblTheTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTheTime.Name = "lblTheTime";
            this.lblTheTime.Size = new System.Drawing.Size(88, 37);
            this.lblTheTime.TabIndex = 28;
            this.lblTheTime.Text = "Time";
            // 
            // picBanner
            // 
            this.picBanner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBanner.BackgroundImage")));
            this.picBanner.Location = new System.Drawing.Point(608, 17);
            this.picBanner.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.picBanner.Name = "picBanner";
            this.picBanner.Size = new System.Drawing.Size(1500, 387);
            this.picBanner.TabIndex = 29;
            this.picBanner.TabStop = false;
            // 
            // lstCars
            // 
            this.lstCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCars.FormattingEnabled = true;
            this.lstCars.ItemHeight = 36;
            this.lstCars.Location = new System.Drawing.Point(1098, 579);
            this.lstCars.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstCars.Name = "lstCars";
            this.lstCars.Size = new System.Drawing.Size(1070, 544);
            this.lstCars.TabIndex = 30;
            this.lstCars.SelectedIndexChanged += new System.EventHandler(this.lstCars_SelectedIndexChanged);
            // 
            // btnRefreshCars
            // 
            this.btnRefreshCars.Location = new System.Drawing.Point(1962, 533);
            this.btnRefreshCars.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefreshCars.Name = "btnRefreshCars";
            this.btnRefreshCars.Size = new System.Drawing.Size(210, 38);
            this.btnRefreshCars.TabIndex = 34;
            this.btnRefreshCars.Text = "Cancel Search";
            this.btnRefreshCars.UseVisualStyleBackColor = true;
            this.btnRefreshCars.Click += new System.EventHandler(this.btnRefreshCars_Click);
            // 
            // btnSearchCar
            // 
            this.btnSearchCar.Location = new System.Drawing.Point(1744, 533);
            this.btnSearchCar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchCar.Name = "btnSearchCar";
            this.btnSearchCar.Size = new System.Drawing.Size(210, 38);
            this.btnSearchCar.TabIndex = 33;
            this.btnSearchCar.Text = "Search";
            this.btnSearchCar.UseVisualStyleBackColor = true;
            this.btnSearchCar.Click += new System.EventHandler(this.btnSearchCar_Click);
            // 
            // txtSearchCars
            // 
            this.txtSearchCars.Location = new System.Drawing.Point(1098, 535);
            this.txtSearchCars.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchCars.Name = "txtSearchCars";
            this.txtSearchCars.Size = new System.Drawing.Size(634, 31);
            this.txtSearchCars.TabIndex = 32;
            // 
            // lblCarsHeader
            // 
            this.lblCarsHeader.AutoSize = true;
            this.lblCarsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarsHeader.Location = new System.Drawing.Point(1090, 483);
            this.lblCarsHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarsHeader.Name = "lblCarsHeader";
            this.lblCarsHeader.Size = new System.Drawing.Size(241, 44);
            this.lblCarsHeader.TabIndex = 31;
            this.lblCarsHeader.Text = "Search Cars:";
            // 
            // btnRemoveCar
            // 
            this.btnRemoveCar.Location = new System.Drawing.Point(1824, 1148);
            this.btnRemoveCar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveCar.Name = "btnRemoveCar";
            this.btnRemoveCar.Size = new System.Drawing.Size(348, 129);
            this.btnRemoveCar.TabIndex = 38;
            this.btnRemoveCar.Text = "Remove Selected Car";
            this.btnRemoveCar.UseVisualStyleBackColor = true;
            this.btnRemoveCar.Click += new System.EventHandler(this.btnRemoveCar_Click);
            // 
            // btnUpdateCar
            // 
            this.btnUpdateCar.Location = new System.Drawing.Point(1454, 1148);
            this.btnUpdateCar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateCar.Name = "btnUpdateCar";
            this.btnUpdateCar.Size = new System.Drawing.Size(362, 129);
            this.btnUpdateCar.TabIndex = 36;
            this.btnUpdateCar.Text = "Update Selected Car";
            this.btnUpdateCar.UseVisualStyleBackColor = true;
            this.btnUpdateCar.Click += new System.EventHandler(this.btnUpdateCar_Click);
            // 
            // btnAddNewCar
            // 
            this.btnAddNewCar.Location = new System.Drawing.Point(1098, 1148);
            this.btnAddNewCar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddNewCar.Name = "btnAddNewCar";
            this.btnAddNewCar.Size = new System.Drawing.Size(348, 129);
            this.btnAddNewCar.TabIndex = 35;
            this.btnAddNewCar.Text = "Add New Car";
            this.btnAddNewCar.UseVisualStyleBackColor = true;
            this.btnAddNewCar.Click += new System.EventHandler(this.btnAddNewCar_Click);
            // 
            // lblCompName
            // 
            this.lblCompName.AutoSize = true;
            this.lblCompName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompName.Location = new System.Drawing.Point(10, 75);
            this.lblCompName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompName.Name = "lblCompName";
            this.lblCompName.Size = new System.Drawing.Size(100, 36);
            this.lblCompName.TabIndex = 44;
            this.lblCompName.Text = "Name:";
            // 
            // lblCompID
            // 
            this.lblCompID.AutoSize = true;
            this.lblCompID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompID.Location = new System.Drawing.Point(16, 138);
            this.lblCompID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompID.Name = "lblCompID";
            this.lblCompID.Size = new System.Drawing.Size(52, 36);
            this.lblCompID.TabIndex = 45;
            this.lblCompID.Text = "ID:";
            // 
            // lblCompAddress
            // 
            this.lblCompAddress.AutoSize = true;
            this.lblCompAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompAddress.Location = new System.Drawing.Point(16, 206);
            this.lblCompAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompAddress.Name = "lblCompAddress";
            this.lblCompAddress.Size = new System.Drawing.Size(134, 36);
            this.lblCompAddress.TabIndex = 46;
            this.lblCompAddress.Text = "Address:";
            // 
            // lblCompPostcode
            // 
            this.lblCompPostcode.AutoSize = true;
            this.lblCompPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompPostcode.Location = new System.Drawing.Point(16, 275);
            this.lblCompPostcode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompPostcode.Name = "lblCompPostcode";
            this.lblCompPostcode.Size = new System.Drawing.Size(148, 36);
            this.lblCompPostcode.TabIndex = 47;
            this.lblCompPostcode.Text = "Postcode:";
            // 
            // lblCompCarCount
            // 
            this.lblCompCarCount.AutoSize = true;
            this.lblCompCarCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompCarCount.Location = new System.Drawing.Point(10, 338);
            this.lblCompCarCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompCarCount.Name = "lblCompCarCount";
            this.lblCompCarCount.Size = new System.Drawing.Size(189, 36);
            this.lblCompCarCount.TabIndex = 50;
            this.lblCompCarCount.Text = "Cars Rented:";
            // 
            // txtDisplayCarComments
            // 
            this.txtDisplayCarComments.Enabled = false;
            this.txtDisplayCarComments.Location = new System.Drawing.Point(12, 490);
            this.txtDisplayCarComments.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtDisplayCarComments.Name = "txtDisplayCarComments";
            this.txtDisplayCarComments.Size = new System.Drawing.Size(532, 237);
            this.txtDisplayCarComments.TabIndex = 59;
            this.txtDisplayCarComments.Text = "";
            // 
            // lblCarReg
            // 
            this.lblCarReg.AutoSize = true;
            this.lblCarReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarReg.Location = new System.Drawing.Point(10, 258);
            this.lblCarReg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarReg.Name = "lblCarReg";
            this.lblCarReg.Size = new System.Drawing.Size(183, 36);
            this.lblCarReg.TabIndex = 58;
            this.lblCarReg.Text = "Registration:";
            // 
            // lblCarComments
            // 
            this.lblCarComments.AutoSize = true;
            this.lblCarComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarComments.Location = new System.Drawing.Point(194, 450);
            this.lblCarComments.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarComments.Name = "lblCarComments";
            this.lblCarComments.Size = new System.Drawing.Size(163, 36);
            this.lblCarComments.TabIndex = 57;
            this.lblCarComments.Text = "Comments:";
            // 
            // lblFuelType
            // 
            this.lblFuelType.AutoSize = true;
            this.lblFuelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuelType.Location = new System.Drawing.Point(10, 323);
            this.lblFuelType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFuelType.Name = "lblFuelType";
            this.lblFuelType.Size = new System.Drawing.Size(155, 36);
            this.lblFuelType.TabIndex = 56;
            this.lblFuelType.Text = "Fuel Type:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 231);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 36);
            this.label10.TabIndex = 55;
            // 
            // lblCarModel
            // 
            this.lblCarModel.AutoSize = true;
            this.lblCarModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarModel.Location = new System.Drawing.Point(10, 198);
            this.lblCarModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarModel.Name = "lblCarModel";
            this.lblCarModel.Size = new System.Drawing.Size(97, 36);
            this.lblCarModel.TabIndex = 54;
            this.lblCarModel.Text = "Model";
            // 
            // lblCarID
            // 
            this.lblCarID.AutoSize = true;
            this.lblCarID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarID.Location = new System.Drawing.Point(10, 75);
            this.lblCarID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarID.Name = "lblCarID";
            this.lblCarID.Size = new System.Drawing.Size(52, 36);
            this.lblCarID.TabIndex = 53;
            this.lblCarID.Text = "ID:";
            // 
            // lblCarMake
            // 
            this.lblCarMake.AutoSize = true;
            this.lblCarMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarMake.Location = new System.Drawing.Point(10, 135);
            this.lblCarMake.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarMake.Name = "lblCarMake";
            this.lblCarMake.Size = new System.Drawing.Size(95, 36);
            this.lblCarMake.TabIndex = 52;
            this.lblCarMake.Text = "Make:";
            // 
            // grpCompanySummary
            // 
            this.grpCompanySummary.Controls.Add(this.lblCompCarCount);
            this.grpCompanySummary.Controls.Add(this.lblCompPostcode);
            this.grpCompanySummary.Controls.Add(this.lblCompAddress);
            this.grpCompanySummary.Controls.Add(this.lblCompID);
            this.grpCompanySummary.Controls.Add(this.lblCompName);
            this.grpCompanySummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCompanySummary.ForeColor = System.Drawing.Color.DarkOrange;
            this.grpCompanySummary.Location = new System.Drawing.Point(2182, 533);
            this.grpCompanySummary.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpCompanySummary.Name = "grpCompanySummary";
            this.grpCompanySummary.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpCompanySummary.Size = new System.Drawing.Size(580, 417);
            this.grpCompanySummary.TabIndex = 60;
            this.grpCompanySummary.TabStop = false;
            this.grpCompanySummary.Text = "Company Summary";
            // 
            // grpCarSummary
            // 
            this.grpCarSummary.Controls.Add(this.lblLastServiced);
            this.grpCarSummary.Controls.Add(this.lblCarComments);
            this.grpCarSummary.Controls.Add(this.txtDisplayCarComments);
            this.grpCarSummary.Controls.Add(this.lblCarReg);
            this.grpCarSummary.Controls.Add(this.lblCarMake);
            this.grpCarSummary.Controls.Add(this.lblFuelType);
            this.grpCarSummary.Controls.Add(this.lblCarID);
            this.grpCarSummary.Controls.Add(this.label10);
            this.grpCarSummary.Controls.Add(this.lblCarModel);
            this.grpCarSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCarSummary.ForeColor = System.Drawing.Color.DarkOrange;
            this.grpCarSummary.Location = new System.Drawing.Point(2182, 979);
            this.grpCarSummary.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpCarSummary.Name = "grpCarSummary";
            this.grpCarSummary.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpCarSummary.Size = new System.Drawing.Size(580, 742);
            this.grpCarSummary.TabIndex = 61;
            this.grpCarSummary.TabStop = false;
            this.grpCarSummary.Text = "Car Summary";
            // 
            // lblLastServiced
            // 
            this.lblLastServiced.AutoSize = true;
            this.lblLastServiced.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastServiced.Location = new System.Drawing.Point(10, 383);
            this.lblLastServiced.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastServiced.Name = "lblLastServiced";
            this.lblLastServiced.Size = new System.Drawing.Size(203, 36);
            this.lblLastServiced.TabIndex = 60;
            this.lblLastServiced.Text = "Last Serviced:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2564, 1559);
            this.Controls.Add(this.grpCarSummary);
            this.Controls.Add(this.grpCompanySummary);
            this.Controls.Add(this.btnRemoveCar);
            this.Controls.Add(this.btnUpdateCar);
            this.Controls.Add(this.btnAddNewCar);
            this.Controls.Add(this.btnRefreshCars);
            this.Controls.Add(this.btnSearchCar);
            this.Controls.Add(this.txtSearchCars);
            this.Controls.Add(this.lblCarsHeader);
            this.Controls.Add(this.lstCars);
            this.Controls.Add(this.picBanner);
            this.Controls.Add(this.lblTheTime);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnClearAllNotifications);
            this.Controls.Add(this.btnClearAllCompanies);
            this.Controls.Add(this.lblDisplayDate);
            this.Controls.Add(this.btnRefreshNotifications);
            this.Controls.Add(this.btnRefreshCompanies);
            this.Controls.Add(this.btnSearchRecentActivity);
            this.Controls.Add(this.btnSearchCompanies);
            this.Controls.Add(this.btnRemoveCompany);
            this.Controls.Add(this.lblRecentActivityHeader);
            this.Controls.Add(this.txtSearchRecentActivity);
            this.Controls.Add(this.lstRecentActivity);
            this.Controls.Add(this.btnUpdateCompany);
            this.Controls.Add(this.btnAddNewCompany);
            this.Controls.Add(this.txtSearchCompanies);
            this.Controls.Add(this.lblCompaniesHeader);
            this.Controls.Add(this.lstAllCompanies);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Hire Car Maintenance Inc";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).EndInit();
            this.grpCompanySummary.ResumeLayout(false);
            this.grpCompanySummary.PerformLayout();
            this.grpCarSummary.ResumeLayout(false);
            this.grpCarSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstAllCompanies;
        private System.Windows.Forms.Label lblCompaniesHeader;
        private System.Windows.Forms.TextBox txtSearchCompanies;
        private System.Windows.Forms.Button btnAddNewCompany;
        private System.Windows.Forms.Button btnUpdateCompany;
        private System.Windows.Forms.ListBox lstRecentActivity;
        private System.Windows.Forms.TextBox txtSearchRecentActivity;
        private System.Windows.Forms.Label lblRecentActivityHeader;
        private System.Windows.Forms.Button btnRemoveCompany;
        private System.Windows.Forms.Button btnSearchCompanies;
        private System.Windows.Forms.Button btnSearchRecentActivity;
        private System.Windows.Forms.Button btnRefreshCompanies;
        private System.Windows.Forms.Button btnRefreshNotifications;
        private System.Windows.Forms.Label lblDisplayDate;
        private System.Windows.Forms.Button btnClearAllCompanies;
        private System.Windows.Forms.Button btnClearAllNotifications;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label lblTheTime;
        private System.Windows.Forms.PictureBox picBanner;
        private System.Windows.Forms.ListBox lstCars;
        private System.Windows.Forms.Button btnRefreshCars;
        private System.Windows.Forms.Button btnSearchCar;
        private System.Windows.Forms.TextBox txtSearchCars;
        private System.Windows.Forms.Label lblCarsHeader;
        private System.Windows.Forms.Button btnRemoveCar;
        private System.Windows.Forms.Button btnUpdateCar;
        private System.Windows.Forms.Button btnAddNewCar;
        private System.Windows.Forms.Label lblCompName;
        private System.Windows.Forms.Label lblCompID;
        private System.Windows.Forms.Label lblCompAddress;
        private System.Windows.Forms.Label lblCompPostcode;
        private System.Windows.Forms.Label lblCompCarCount;
        private System.Windows.Forms.RichTextBox txtDisplayCarComments;
        private System.Windows.Forms.Label lblCarReg;
        private System.Windows.Forms.Label lblCarComments;
        private System.Windows.Forms.Label lblFuelType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCarModel;
        private System.Windows.Forms.Label lblCarID;
        private System.Windows.Forms.Label lblCarMake;
        private System.Windows.Forms.GroupBox grpCompanySummary;
        private System.Windows.Forms.GroupBox grpCarSummary;
        private System.Windows.Forms.Label lblLastServiced;
    }
}

