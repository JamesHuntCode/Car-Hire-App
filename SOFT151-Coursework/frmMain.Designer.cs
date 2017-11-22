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
            this.lstAllCompanies.ItemHeight = 18;
            this.lstAllCompanies.Location = new System.Drawing.Point(6, 301);
            this.lstAllCompanies.Margin = new System.Windows.Forms.Padding(2);
            this.lstAllCompanies.Name = "lstAllCompanies";
            this.lstAllCompanies.Size = new System.Drawing.Size(539, 292);
            this.lstAllCompanies.TabIndex = 0;
            this.lstAllCompanies.SelectedIndexChanged += new System.EventHandler(this.lstAllCompanies_SelectedIndexChanged);
            // 
            // lblCompaniesHeader
            // 
            this.lblCompaniesHeader.AutoSize = true;
            this.lblCompaniesHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompaniesHeader.Location = new System.Drawing.Point(2, 251);
            this.lblCompaniesHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompaniesHeader.Name = "lblCompaniesHeader";
            this.lblCompaniesHeader.Size = new System.Drawing.Size(176, 24);
            this.lblCompaniesHeader.TabIndex = 2;
            this.lblCompaniesHeader.Text = "Search Companies:";
            // 
            // txtSearchCompanies
            // 
            this.txtSearchCompanies.Location = new System.Drawing.Point(6, 277);
            this.txtSearchCompanies.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchCompanies.Name = "txtSearchCompanies";
            this.txtSearchCompanies.Size = new System.Drawing.Size(309, 20);
            this.txtSearchCompanies.TabIndex = 5;
            // 
            // btnAddNewCompany
            // 
            this.btnAddNewCompany.Location = new System.Drawing.Point(6, 597);
            this.btnAddNewCompany.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewCompany.Name = "btnAddNewCompany";
            this.btnAddNewCompany.Size = new System.Drawing.Size(173, 67);
            this.btnAddNewCompany.TabIndex = 7;
            this.btnAddNewCompany.Text = "Add New Company";
            this.btnAddNewCompany.UseVisualStyleBackColor = true;
            this.btnAddNewCompany.Click += new System.EventHandler(this.btnAddNewCompany_Click);
            // 
            // btnUpdateCompany
            // 
            this.btnUpdateCompany.Location = new System.Drawing.Point(183, 597);
            this.btnUpdateCompany.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateCompany.Name = "btnUpdateCompany";
            this.btnUpdateCompany.Size = new System.Drawing.Size(183, 67);
            this.btnUpdateCompany.TabIndex = 11;
            this.btnUpdateCompany.Text = "Update Selected Company";
            this.btnUpdateCompany.UseVisualStyleBackColor = true;
            this.btnUpdateCompany.Click += new System.EventHandler(this.btnUpdateCompany_Click);
            // 
            // lstRecentActivity
            // 
            this.lstRecentActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRecentActivity.FormattingEnabled = true;
            this.lstRecentActivity.ItemHeight = 18;
            this.lstRecentActivity.Location = new System.Drawing.Point(6, 729);
            this.lstRecentActivity.Margin = new System.Windows.Forms.Padding(2);
            this.lstRecentActivity.Name = "lstRecentActivity";
            this.lstRecentActivity.Size = new System.Drawing.Size(1090, 166);
            this.lstRecentActivity.TabIndex = 14;
            // 
            // txtSearchRecentActivity
            // 
            this.txtSearchRecentActivity.Location = new System.Drawing.Point(6, 704);
            this.txtSearchRecentActivity.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchRecentActivity.Name = "txtSearchRecentActivity";
            this.txtSearchRecentActivity.Size = new System.Drawing.Size(275, 20);
            this.txtSearchRecentActivity.TabIndex = 15;
            // 
            // lblRecentActivityHeader
            // 
            this.lblRecentActivityHeader.AutoSize = true;
            this.lblRecentActivityHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentActivityHeader.Location = new System.Drawing.Point(2, 678);
            this.lblRecentActivityHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecentActivityHeader.Name = "lblRecentActivityHeader";
            this.lblRecentActivityHeader.Size = new System.Drawing.Size(202, 24);
            this.lblRecentActivityHeader.TabIndex = 16;
            this.lblRecentActivityHeader.Text = "Search Recent Activity:";
            // 
            // btnRemoveCompany
            // 
            this.btnRemoveCompany.Location = new System.Drawing.Point(370, 597);
            this.btnRemoveCompany.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveCompany.Name = "btnRemoveCompany";
            this.btnRemoveCompany.Size = new System.Drawing.Size(175, 67);
            this.btnRemoveCompany.TabIndex = 18;
            this.btnRemoveCompany.Text = "Remove Selected Company";
            this.btnRemoveCompany.UseVisualStyleBackColor = true;
            this.btnRemoveCompany.Click += new System.EventHandler(this.btnRemoveCompany_Click);
            // 
            // btnSearchCompanies
            // 
            this.btnSearchCompanies.Location = new System.Drawing.Point(319, 277);
            this.btnSearchCompanies.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchCompanies.Name = "btnSearchCompanies";
            this.btnSearchCompanies.Size = new System.Drawing.Size(111, 20);
            this.btnSearchCompanies.TabIndex = 19;
            this.btnSearchCompanies.Text = "Search";
            this.btnSearchCompanies.UseVisualStyleBackColor = true;
            this.btnSearchCompanies.Click += new System.EventHandler(this.btnSearchCompanies_Click);
            // 
            // btnSearchRecentActivity
            // 
            this.btnSearchRecentActivity.Location = new System.Drawing.Point(285, 703);
            this.btnSearchRecentActivity.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchRecentActivity.Name = "btnSearchRecentActivity";
            this.btnSearchRecentActivity.Size = new System.Drawing.Size(130, 21);
            this.btnSearchRecentActivity.TabIndex = 20;
            this.btnSearchRecentActivity.Text = "Search";
            this.btnSearchRecentActivity.UseVisualStyleBackColor = true;
            this.btnSearchRecentActivity.Click += new System.EventHandler(this.btnSearchRecentActivity_Click);
            // 
            // btnRefreshCompanies
            // 
            this.btnRefreshCompanies.Location = new System.Drawing.Point(434, 278);
            this.btnRefreshCompanies.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefreshCompanies.Name = "btnRefreshCompanies";
            this.btnRefreshCompanies.Size = new System.Drawing.Size(111, 20);
            this.btnRefreshCompanies.TabIndex = 21;
            this.btnRefreshCompanies.Text = "Cancel Search";
            this.btnRefreshCompanies.UseVisualStyleBackColor = true;
            this.btnRefreshCompanies.Click += new System.EventHandler(this.btnRefreshCompanies_Click);
            // 
            // btnRefreshNotifications
            // 
            this.btnRefreshNotifications.Location = new System.Drawing.Point(419, 703);
            this.btnRefreshNotifications.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefreshNotifications.Name = "btnRefreshNotifications";
            this.btnRefreshNotifications.Size = new System.Drawing.Size(130, 21);
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
            this.lblDisplayDate.Location = new System.Drawing.Point(1279, 9);
            this.lblDisplayDate.Name = "lblDisplayDate";
            this.lblDisplayDate.Size = new System.Drawing.Size(102, 20);
            this.lblDisplayDate.TabIndex = 24;
            this.lblDisplayDate.Text = "Todays\' Date";
            // 
            // btnClearAllCompanies
            // 
            this.btnClearAllCompanies.Location = new System.Drawing.Point(732, 703);
            this.btnClearAllCompanies.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearAllCompanies.Name = "btnClearAllCompanies";
            this.btnClearAllCompanies.Size = new System.Drawing.Size(227, 21);
            this.btnClearAllCompanies.TabIndex = 25;
            this.btnClearAllCompanies.Text = "Remove All Data (Not Recommended)\r\n";
            this.btnClearAllCompanies.UseVisualStyleBackColor = true;
            this.btnClearAllCompanies.Click += new System.EventHandler(this.btnClearAllCompanies_Click);
            // 
            // btnClearAllNotifications
            // 
            this.btnClearAllNotifications.Location = new System.Drawing.Point(552, 703);
            this.btnClearAllNotifications.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearAllNotifications.Name = "btnClearAllNotifications";
            this.btnClearAllNotifications.Size = new System.Drawing.Size(176, 21);
            this.btnClearAllNotifications.TabIndex = 26;
            this.btnClearAllNotifications.Text = "Clear All Notifications";
            this.btnClearAllNotifications.UseVisualStyleBackColor = true;
            this.btnClearAllNotifications.Click += new System.EventHandler(this.btnClearAllNotifications_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(963, 703);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(2);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(130, 21);
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
            this.lblTheTime.Location = new System.Drawing.Point(2, 9);
            this.lblTheTime.Name = "lblTheTime";
            this.lblTheTime.Size = new System.Drawing.Size(43, 20);
            this.lblTheTime.TabIndex = 28;
            this.lblTheTime.Text = "Time";
            // 
            // picBanner
            // 
            this.picBanner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBanner.BackgroundImage")));
            this.picBanner.Location = new System.Drawing.Point(304, 9);
            this.picBanner.Name = "picBanner";
            this.picBanner.Size = new System.Drawing.Size(750, 201);
            this.picBanner.TabIndex = 29;
            this.picBanner.TabStop = false;
            // 
            // lstCars
            // 
            this.lstCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCars.FormattingEnabled = true;
            this.lstCars.ItemHeight = 18;
            this.lstCars.Location = new System.Drawing.Point(559, 301);
            this.lstCars.Margin = new System.Windows.Forms.Padding(2);
            this.lstCars.Name = "lstCars";
            this.lstCars.Size = new System.Drawing.Size(537, 292);
            this.lstCars.TabIndex = 30;
            this.lstCars.SelectedIndexChanged += new System.EventHandler(this.lstCars_SelectedIndexChanged);
            // 
            // btnRefreshCars
            // 
            this.btnRefreshCars.Location = new System.Drawing.Point(991, 277);
            this.btnRefreshCars.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefreshCars.Name = "btnRefreshCars";
            this.btnRefreshCars.Size = new System.Drawing.Size(105, 20);
            this.btnRefreshCars.TabIndex = 34;
            this.btnRefreshCars.Text = "Cancel Search";
            this.btnRefreshCars.UseVisualStyleBackColor = true;
            this.btnRefreshCars.Click += new System.EventHandler(this.btnRefreshCars_Click);
            // 
            // btnSearchCar
            // 
            this.btnSearchCar.Location = new System.Drawing.Point(882, 277);
            this.btnSearchCar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchCar.Name = "btnSearchCar";
            this.btnSearchCar.Size = new System.Drawing.Size(105, 20);
            this.btnSearchCar.TabIndex = 33;
            this.btnSearchCar.Text = "Search";
            this.btnSearchCar.UseVisualStyleBackColor = true;
            this.btnSearchCar.Click += new System.EventHandler(this.btnSearchCar_Click);
            // 
            // txtSearchCars
            // 
            this.txtSearchCars.Location = new System.Drawing.Point(559, 278);
            this.txtSearchCars.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchCars.Name = "txtSearchCars";
            this.txtSearchCars.Size = new System.Drawing.Size(319, 20);
            this.txtSearchCars.TabIndex = 32;
            // 
            // lblCarsHeader
            // 
            this.lblCarsHeader.AutoSize = true;
            this.lblCarsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarsHeader.Location = new System.Drawing.Point(555, 251);
            this.lblCarsHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarsHeader.Name = "lblCarsHeader";
            this.lblCarsHeader.Size = new System.Drawing.Size(118, 24);
            this.lblCarsHeader.TabIndex = 31;
            this.lblCarsHeader.Text = "Search Cars:";
            // 
            // btnRemoveCar
            // 
            this.btnRemoveCar.Location = new System.Drawing.Point(922, 597);
            this.btnRemoveCar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveCar.Name = "btnRemoveCar";
            this.btnRemoveCar.Size = new System.Drawing.Size(174, 67);
            this.btnRemoveCar.TabIndex = 38;
            this.btnRemoveCar.Text = "Remove Selected Car";
            this.btnRemoveCar.UseVisualStyleBackColor = true;
            this.btnRemoveCar.Click += new System.EventHandler(this.btnRemoveCar_Click);
            // 
            // btnUpdateCar
            // 
            this.btnUpdateCar.Location = new System.Drawing.Point(737, 597);
            this.btnUpdateCar.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateCar.Name = "btnUpdateCar";
            this.btnUpdateCar.Size = new System.Drawing.Size(181, 67);
            this.btnUpdateCar.TabIndex = 36;
            this.btnUpdateCar.Text = "Update Selected Car";
            this.btnUpdateCar.UseVisualStyleBackColor = true;
            this.btnUpdateCar.Click += new System.EventHandler(this.btnUpdateCar_Click);
            // 
            // btnAddNewCar
            // 
            this.btnAddNewCar.Location = new System.Drawing.Point(559, 597);
            this.btnAddNewCar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewCar.Name = "btnAddNewCar";
            this.btnAddNewCar.Size = new System.Drawing.Size(174, 67);
            this.btnAddNewCar.TabIndex = 35;
            this.btnAddNewCar.Text = "Add New Car";
            this.btnAddNewCar.UseVisualStyleBackColor = true;
            this.btnAddNewCar.Click += new System.EventHandler(this.btnAddNewCar_Click);
            // 
            // lblCompName
            // 
            this.lblCompName.AutoSize = true;
            this.lblCompName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompName.Location = new System.Drawing.Point(5, 39);
            this.lblCompName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompName.Name = "lblCompName";
            this.lblCompName.Size = new System.Drawing.Size(52, 18);
            this.lblCompName.TabIndex = 44;
            this.lblCompName.Text = "Name:";
            // 
            // lblCompID
            // 
            this.lblCompID.AutoSize = true;
            this.lblCompID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompID.Location = new System.Drawing.Point(8, 72);
            this.lblCompID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompID.Name = "lblCompID";
            this.lblCompID.Size = new System.Drawing.Size(26, 18);
            this.lblCompID.TabIndex = 45;
            this.lblCompID.Text = "ID:";
            // 
            // lblCompAddress
            // 
            this.lblCompAddress.AutoSize = true;
            this.lblCompAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompAddress.Location = new System.Drawing.Point(8, 107);
            this.lblCompAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompAddress.Name = "lblCompAddress";
            this.lblCompAddress.Size = new System.Drawing.Size(66, 18);
            this.lblCompAddress.TabIndex = 46;
            this.lblCompAddress.Text = "Address:";
            // 
            // lblCompPostcode
            // 
            this.lblCompPostcode.AutoSize = true;
            this.lblCompPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompPostcode.Location = new System.Drawing.Point(8, 143);
            this.lblCompPostcode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompPostcode.Name = "lblCompPostcode";
            this.lblCompPostcode.Size = new System.Drawing.Size(76, 18);
            this.lblCompPostcode.TabIndex = 47;
            this.lblCompPostcode.Text = "Postcode:";
            // 
            // lblCompCarCount
            // 
            this.lblCompCarCount.AutoSize = true;
            this.lblCompCarCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompCarCount.Location = new System.Drawing.Point(5, 176);
            this.lblCompCarCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompCarCount.Name = "lblCompCarCount";
            this.lblCompCarCount.Size = new System.Drawing.Size(95, 18);
            this.lblCompCarCount.TabIndex = 50;
            this.lblCompCarCount.Text = "Cars Rented:";
            // 
            // txtDisplayCarComments
            // 
            this.txtDisplayCarComments.Enabled = false;
            this.txtDisplayCarComments.Location = new System.Drawing.Point(6, 255);
            this.txtDisplayCarComments.Name = "txtDisplayCarComments";
            this.txtDisplayCarComments.Size = new System.Drawing.Size(268, 125);
            this.txtDisplayCarComments.TabIndex = 59;
            this.txtDisplayCarComments.Text = "";
            // 
            // lblCarReg
            // 
            this.lblCarReg.AutoSize = true;
            this.lblCarReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarReg.Location = new System.Drawing.Point(5, 134);
            this.lblCarReg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarReg.Name = "lblCarReg";
            this.lblCarReg.Size = new System.Drawing.Size(91, 18);
            this.lblCarReg.TabIndex = 58;
            this.lblCarReg.Text = "Registration:";
            // 
            // lblCarComments
            // 
            this.lblCarComments.AutoSize = true;
            this.lblCarComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarComments.Location = new System.Drawing.Point(97, 234);
            this.lblCarComments.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarComments.Name = "lblCarComments";
            this.lblCarComments.Size = new System.Drawing.Size(86, 18);
            this.lblCarComments.TabIndex = 57;
            this.lblCarComments.Text = "Comments:";
            // 
            // lblFuelType
            // 
            this.lblFuelType.AutoSize = true;
            this.lblFuelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuelType.Location = new System.Drawing.Point(5, 168);
            this.lblFuelType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFuelType.Name = "lblFuelType";
            this.lblFuelType.Size = new System.Drawing.Size(76, 18);
            this.lblFuelType.TabIndex = 56;
            this.lblFuelType.Text = "Fuel Type:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 120);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 18);
            this.label10.TabIndex = 55;
            // 
            // lblCarModel
            // 
            this.lblCarModel.AutoSize = true;
            this.lblCarModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarModel.Location = new System.Drawing.Point(5, 103);
            this.lblCarModel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarModel.Name = "lblCarModel";
            this.lblCarModel.Size = new System.Drawing.Size(49, 18);
            this.lblCarModel.TabIndex = 54;
            this.lblCarModel.Text = "Model";
            // 
            // lblCarID
            // 
            this.lblCarID.AutoSize = true;
            this.lblCarID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarID.Location = new System.Drawing.Point(5, 39);
            this.lblCarID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarID.Name = "lblCarID";
            this.lblCarID.Size = new System.Drawing.Size(26, 18);
            this.lblCarID.TabIndex = 53;
            this.lblCarID.Text = "ID:";
            // 
            // lblCarMake
            // 
            this.lblCarMake.AutoSize = true;
            this.lblCarMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarMake.Location = new System.Drawing.Point(5, 70);
            this.lblCarMake.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarMake.Name = "lblCarMake";
            this.lblCarMake.Size = new System.Drawing.Size(49, 18);
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
            this.grpCompanySummary.Location = new System.Drawing.Point(1101, 277);
            this.grpCompanySummary.Name = "grpCompanySummary";
            this.grpCompanySummary.Size = new System.Drawing.Size(280, 217);
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
            this.grpCarSummary.Location = new System.Drawing.Point(1101, 509);
            this.grpCarSummary.Name = "grpCarSummary";
            this.grpCarSummary.Size = new System.Drawing.Size(280, 386);
            this.grpCarSummary.TabIndex = 61;
            this.grpCarSummary.TabStop = false;
            this.grpCarSummary.Text = "Car Summary";
            // 
            // lblLastServiced
            // 
            this.lblLastServiced.AutoSize = true;
            this.lblLastServiced.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastServiced.Location = new System.Drawing.Point(5, 199);
            this.lblLastServiced.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastServiced.Name = "lblLastServiced";
            this.lblLastServiced.Size = new System.Drawing.Size(101, 18);
            this.lblLastServiced.TabIndex = 60;
            this.lblLastServiced.Text = "Last Serviced:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 899);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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

