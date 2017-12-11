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
            this.btnRemoveCompany = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.lstCars = new System.Windows.Forms.ListBox();
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
            this.picCompName = new System.Windows.Forms.PictureBox();
            this.picCompAddress = new System.Windows.Forms.PictureBox();
            this.picCompPostcode = new System.Windows.Forms.PictureBox();
            this.picCompID = new System.Windows.Forms.PictureBox();
            this.txtCompID = new System.Windows.Forms.TextBox();
            this.txtCompPostcode = new System.Windows.Forms.TextBox();
            this.txtCompAddress = new System.Windows.Forms.TextBox();
            this.txtCompName = new System.Windows.Forms.TextBox();
            this.grpCarSummary = new System.Windows.Forms.GroupBox();
            this.picCarReg = new System.Windows.Forms.PictureBox();
            this.picCarID = new System.Windows.Forms.PictureBox();
            this.picCarMake = new System.Windows.Forms.PictureBox();
            this.picCarModel = new System.Windows.Forms.PictureBox();
            this.radDiesel = new System.Windows.Forms.RadioButton();
            this.radUnleaded = new System.Windows.Forms.RadioButton();
            this.dtpLastServiced = new System.Windows.Forms.DateTimePicker();
            this.txtCarMake = new System.Windows.Forms.TextBox();
            this.txtCarModel = new System.Windows.Forms.TextBox();
            this.txtCarReg = new System.Windows.Forms.TextBox();
            this.txtCarID = new System.Windows.Forms.TextBox();
            this.lblLastServiced = new System.Windows.Forms.Label();
            this.btnSaveWork = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radAutoSaveOn = new System.Windows.Forms.RadioButton();
            this.radAutoSaveOff = new System.Windows.Forms.RadioButton();
            this.lblLastSaved = new System.Windows.Forms.Label();
            this.lblFileBeingRead = new System.Windows.Forms.Label();
            this.txtInputFileName = new System.Windows.Forms.TextBox();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.picMainLogo = new System.Windows.Forms.PictureBox();
            this.btnCancelCompanyUpdate = new System.Windows.Forms.Button();
            this.btnCancelCarUpdate = new System.Windows.Forms.Button();
            this.btnSaveCarChanges = new System.Windows.Forms.Button();
            this.btnSaveCompanyChanges = new System.Windows.Forms.Button();
            this.lstRecentActivity = new System.Windows.Forms.ListBox();
            this.btnRefreshNotifications = new System.Windows.Forms.Button();
            this.btnSearchRecentActivity = new System.Windows.Forms.Button();
            this.txtSearchRecentActivity = new System.Windows.Forms.TextBox();
            this.lblActivityHeader = new System.Windows.Forms.Label();
            this.radNotificationsOff = new System.Windows.Forms.RadioButton();
            this.radNotificationsOn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.grpNotificationSettings = new System.Windows.Forms.GroupBox();
            this.grpSaveSettings = new System.Windows.Forms.GroupBox();
            this.grpCompanySummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCompName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompPostcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompID)).BeginInit();
            this.grpCarSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCarReg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarMake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainLogo)).BeginInit();
            this.grpNotificationSettings.SuspendLayout();
            this.grpSaveSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstAllCompanies
            // 
            this.lstAllCompanies.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAllCompanies.FormattingEnabled = true;
            this.lstAllCompanies.ItemHeight = 18;
            this.lstAllCompanies.Location = new System.Drawing.Point(6, 248);
            this.lstAllCompanies.Margin = new System.Windows.Forms.Padding(2);
            this.lstAllCompanies.Name = "lstAllCompanies";
            this.lstAllCompanies.Size = new System.Drawing.Size(539, 274);
            this.lstAllCompanies.TabIndex = 0;
            this.lstAllCompanies.SelectedIndexChanged += new System.EventHandler(this.lstAllCompanies_SelectedIndexChanged);
            // 
            // lblCompaniesHeader
            // 
            this.lblCompaniesHeader.AutoSize = true;
            this.lblCompaniesHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompaniesHeader.Location = new System.Drawing.Point(4, 198);
            this.lblCompaniesHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompaniesHeader.Name = "lblCompaniesHeader";
            this.lblCompaniesHeader.Size = new System.Drawing.Size(176, 24);
            this.lblCompaniesHeader.TabIndex = 2;
            this.lblCompaniesHeader.Text = "Search Companies:";
            // 
            // txtSearchCompanies
            // 
            this.txtSearchCompanies.Location = new System.Drawing.Point(6, 224);
            this.txtSearchCompanies.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchCompanies.Name = "txtSearchCompanies";
            this.txtSearchCompanies.Size = new System.Drawing.Size(539, 20);
            this.txtSearchCompanies.TabIndex = 5;
            this.txtSearchCompanies.TextChanged += new System.EventHandler(this.txtSearchCompanies_TextChanged);
            // 
            // btnAddNewCompany
            // 
            this.btnAddNewCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCompany.Location = new System.Drawing.Point(1122, 224);
            this.btnAddNewCompany.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewCompany.Name = "btnAddNewCompany";
            this.btnAddNewCompany.Size = new System.Drawing.Size(229, 42);
            this.btnAddNewCompany.TabIndex = 7;
            this.btnAddNewCompany.Text = "Add New Company";
            this.btnAddNewCompany.UseVisualStyleBackColor = true;
            this.btnAddNewCompany.Click += new System.EventHandler(this.btnAddNewCompany_Click);
            // 
            // btnUpdateCompany
            // 
            this.btnUpdateCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCompany.Location = new System.Drawing.Point(1122, 271);
            this.btnUpdateCompany.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateCompany.Name = "btnUpdateCompany";
            this.btnUpdateCompany.Size = new System.Drawing.Size(229, 65);
            this.btnUpdateCompany.TabIndex = 11;
            this.btnUpdateCompany.Text = "Edit Selected Company";
            this.btnUpdateCompany.UseVisualStyleBackColor = true;
            this.btnUpdateCompany.Click += new System.EventHandler(this.btnUpdateCompany_Click);
            // 
            // btnRemoveCompany
            // 
            this.btnRemoveCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveCompany.Location = new System.Drawing.Point(1122, 340);
            this.btnRemoveCompany.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveCompany.Name = "btnRemoveCompany";
            this.btnRemoveCompany.Size = new System.Drawing.Size(229, 49);
            this.btnRemoveCompany.TabIndex = 18;
            this.btnRemoveCompany.Text = "Remove Selected Company";
            this.btnRemoveCompany.UseVisualStyleBackColor = true;
            this.btnRemoveCompany.Click += new System.EventHandler(this.btnRemoveCompany_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Location = new System.Drawing.Point(5, 35);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(2);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(296, 28);
            this.btnAbout.TabIndex = 27;
            this.btnAbout.Text = "Need Help? View Full Guide Here";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // lstCars
            // 
            this.lstCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCars.FormattingEnabled = true;
            this.lstCars.ItemHeight = 18;
            this.lstCars.Location = new System.Drawing.Point(6, 576);
            this.lstCars.Margin = new System.Windows.Forms.Padding(2);
            this.lstCars.Name = "lstCars";
            this.lstCars.Size = new System.Drawing.Size(539, 274);
            this.lstCars.TabIndex = 30;
            this.lstCars.SelectedIndexChanged += new System.EventHandler(this.lstCars_SelectedIndexChanged);
            // 
            // txtSearchCars
            // 
            this.txtSearchCars.Location = new System.Drawing.Point(6, 552);
            this.txtSearchCars.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchCars.Name = "txtSearchCars";
            this.txtSearchCars.Size = new System.Drawing.Size(539, 20);
            this.txtSearchCars.TabIndex = 32;
            this.txtSearchCars.TextChanged += new System.EventHandler(this.txtSearchCars_TextChanged);
            // 
            // lblCarsHeader
            // 
            this.lblCarsHeader.AutoSize = true;
            this.lblCarsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarsHeader.Location = new System.Drawing.Point(4, 526);
            this.lblCarsHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarsHeader.Name = "lblCarsHeader";
            this.lblCarsHeader.Size = new System.Drawing.Size(118, 24);
            this.lblCarsHeader.TabIndex = 31;
            this.lblCarsHeader.Text = "Search Cars:";
            // 
            // btnRemoveCar
            // 
            this.btnRemoveCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveCar.Location = new System.Drawing.Point(1122, 648);
            this.btnRemoveCar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveCar.Name = "btnRemoveCar";
            this.btnRemoveCar.Size = new System.Drawing.Size(229, 66);
            this.btnRemoveCar.TabIndex = 38;
            this.btnRemoveCar.Text = "Remove Selected Car";
            this.btnRemoveCar.UseVisualStyleBackColor = true;
            this.btnRemoveCar.Click += new System.EventHandler(this.btnRemoveCar_Click);
            // 
            // btnUpdateCar
            // 
            this.btnUpdateCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCar.Location = new System.Drawing.Point(1122, 578);
            this.btnUpdateCar.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateCar.Name = "btnUpdateCar";
            this.btnUpdateCar.Size = new System.Drawing.Size(229, 66);
            this.btnUpdateCar.TabIndex = 36;
            this.btnUpdateCar.Text = "Edit Selected Car";
            this.btnUpdateCar.UseVisualStyleBackColor = true;
            this.btnUpdateCar.Click += new System.EventHandler(this.btnUpdateCar_Click);
            // 
            // btnAddNewCar
            // 
            this.btnAddNewCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCar.Location = new System.Drawing.Point(1122, 504);
            this.btnAddNewCar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewCar.Name = "btnAddNewCar";
            this.btnAddNewCar.Size = new System.Drawing.Size(229, 68);
            this.btnAddNewCar.TabIndex = 35;
            this.btnAddNewCar.Text = "Add New Car";
            this.btnAddNewCar.UseVisualStyleBackColor = true;
            this.btnAddNewCar.Click += new System.EventHandler(this.btnAddNewCar_Click);
            // 
            // lblCompName
            // 
            this.lblCompName.AutoSize = true;
            this.lblCompName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompName.Location = new System.Drawing.Point(44, 83);
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
            this.lblCompID.Location = new System.Drawing.Point(65, 48);
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
            this.lblCompAddress.Location = new System.Drawing.Point(30, 117);
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
            this.lblCompPostcode.Location = new System.Drawing.Point(20, 153);
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
            this.lblCompCarCount.Location = new System.Drawing.Point(1, 191);
            this.lblCompCarCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompCarCount.Name = "lblCompCarCount";
            this.lblCompCarCount.Size = new System.Drawing.Size(95, 18);
            this.lblCompCarCount.TabIndex = 50;
            this.lblCompCarCount.Text = "Cars Rented:";
            // 
            // txtDisplayCarComments
            // 
            this.txtDisplayCarComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplayCarComments.Location = new System.Drawing.Point(6, 243);
            this.txtDisplayCarComments.Name = "txtDisplayCarComments";
            this.txtDisplayCarComments.Size = new System.Drawing.Size(595, 104);
            this.txtDisplayCarComments.TabIndex = 59;
            this.txtDisplayCarComments.Text = "";
            // 
            // lblCarReg
            // 
            this.lblCarReg.AutoSize = true;
            this.lblCarReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarReg.Location = new System.Drawing.Point(6, 135);
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
            this.lblCarComments.Location = new System.Drawing.Point(194, 222);
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
            this.lblFuelType.Location = new System.Drawing.Point(20, 169);
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
            this.lblCarModel.Location = new System.Drawing.Point(47, 104);
            this.lblCarModel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarModel.Name = "lblCarModel";
            this.lblCarModel.Size = new System.Drawing.Size(53, 18);
            this.lblCarModel.TabIndex = 54;
            this.lblCarModel.Text = "Model:";
            // 
            // lblCarID
            // 
            this.lblCarID.AutoSize = true;
            this.lblCarID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarID.Location = new System.Drawing.Point(70, 40);
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
            this.lblCarMake.Location = new System.Drawing.Point(48, 72);
            this.lblCarMake.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarMake.Name = "lblCarMake";
            this.lblCarMake.Size = new System.Drawing.Size(49, 18);
            this.lblCarMake.TabIndex = 52;
            this.lblCarMake.Text = "Make:";
            // 
            // grpCompanySummary
            // 
            this.grpCompanySummary.Controls.Add(this.picCompName);
            this.grpCompanySummary.Controls.Add(this.picCompAddress);
            this.grpCompanySummary.Controls.Add(this.picCompPostcode);
            this.grpCompanySummary.Controls.Add(this.picCompID);
            this.grpCompanySummary.Controls.Add(this.txtCompID);
            this.grpCompanySummary.Controls.Add(this.txtCompPostcode);
            this.grpCompanySummary.Controls.Add(this.txtCompAddress);
            this.grpCompanySummary.Controls.Add(this.txtCompName);
            this.grpCompanySummary.Controls.Add(this.lblCompCarCount);
            this.grpCompanySummary.Controls.Add(this.lblCompPostcode);
            this.grpCompanySummary.Controls.Add(this.lblCompAddress);
            this.grpCompanySummary.Controls.Add(this.lblCompID);
            this.grpCompanySummary.Controls.Add(this.lblCompName);
            this.grpCompanySummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCompanySummary.ForeColor = System.Drawing.Color.Black;
            this.grpCompanySummary.Location = new System.Drawing.Point(550, 214);
            this.grpCompanySummary.Name = "grpCompanySummary";
            this.grpCompanySummary.Size = new System.Drawing.Size(567, 275);
            this.grpCompanySummary.TabIndex = 60;
            this.grpCompanySummary.TabStop = false;
            this.grpCompanySummary.Text = "Company Summary";
            // 
            // picCompName
            // 
            this.picCompName.Location = new System.Drawing.Point(525, 82);
            this.picCompName.Name = "picCompName";
            this.picCompName.Size = new System.Drawing.Size(26, 22);
            this.picCompName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCompName.TabIndex = 79;
            this.picCompName.TabStop = false;
            // 
            // picCompAddress
            // 
            this.picCompAddress.Location = new System.Drawing.Point(525, 116);
            this.picCompAddress.Name = "picCompAddress";
            this.picCompAddress.Size = new System.Drawing.Size(26, 22);
            this.picCompAddress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCompAddress.TabIndex = 78;
            this.picCompAddress.TabStop = false;
            // 
            // picCompPostcode
            // 
            this.picCompPostcode.Location = new System.Drawing.Point(525, 152);
            this.picCompPostcode.Name = "picCompPostcode";
            this.picCompPostcode.Size = new System.Drawing.Size(26, 22);
            this.picCompPostcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCompPostcode.TabIndex = 77;
            this.picCompPostcode.TabStop = false;
            // 
            // picCompID
            // 
            this.picCompID.Location = new System.Drawing.Point(525, 46);
            this.picCompID.Name = "picCompID";
            this.picCompID.Size = new System.Drawing.Size(26, 23);
            this.picCompID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCompID.TabIndex = 76;
            this.picCompID.TabStop = false;
            // 
            // txtCompID
            // 
            this.txtCompID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompID.Location = new System.Drawing.Point(104, 47);
            this.txtCompID.Margin = new System.Windows.Forms.Padding(2);
            this.txtCompID.Name = "txtCompID";
            this.txtCompID.Size = new System.Drawing.Size(416, 22);
            this.txtCompID.TabIndex = 75;
            // 
            // txtCompPostcode
            // 
            this.txtCompPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompPostcode.Location = new System.Drawing.Point(104, 152);
            this.txtCompPostcode.Margin = new System.Windows.Forms.Padding(2);
            this.txtCompPostcode.Name = "txtCompPostcode";
            this.txtCompPostcode.Size = new System.Drawing.Size(416, 22);
            this.txtCompPostcode.TabIndex = 73;
            // 
            // txtCompAddress
            // 
            this.txtCompAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompAddress.Location = new System.Drawing.Point(104, 116);
            this.txtCompAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtCompAddress.Name = "txtCompAddress";
            this.txtCompAddress.Size = new System.Drawing.Size(416, 22);
            this.txtCompAddress.TabIndex = 72;
            // 
            // txtCompName
            // 
            this.txtCompName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompName.Location = new System.Drawing.Point(104, 82);
            this.txtCompName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCompName.Name = "txtCompName";
            this.txtCompName.Size = new System.Drawing.Size(416, 22);
            this.txtCompName.TabIndex = 71;
            // 
            // grpCarSummary
            // 
            this.grpCarSummary.Controls.Add(this.picCarReg);
            this.grpCarSummary.Controls.Add(this.picCarID);
            this.grpCarSummary.Controls.Add(this.picCarMake);
            this.grpCarSummary.Controls.Add(this.picCarModel);
            this.grpCarSummary.Controls.Add(this.radDiesel);
            this.grpCarSummary.Controls.Add(this.radUnleaded);
            this.grpCarSummary.Controls.Add(this.dtpLastServiced);
            this.grpCarSummary.Controls.Add(this.txtCarMake);
            this.grpCarSummary.Controls.Add(this.txtCarModel);
            this.grpCarSummary.Controls.Add(this.txtCarReg);
            this.grpCarSummary.Controls.Add(this.txtCarID);
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
            this.grpCarSummary.ForeColor = System.Drawing.Color.Black;
            this.grpCarSummary.Location = new System.Drawing.Point(550, 495);
            this.grpCarSummary.Name = "grpCarSummary";
            this.grpCarSummary.Size = new System.Drawing.Size(567, 355);
            this.grpCarSummary.TabIndex = 61;
            this.grpCarSummary.TabStop = false;
            this.grpCarSummary.Text = "Car Summary";
            // 
            // picCarReg
            // 
            this.picCarReg.Location = new System.Drawing.Point(524, 134);
            this.picCarReg.Name = "picCarReg";
            this.picCarReg.Size = new System.Drawing.Size(26, 22);
            this.picCarReg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCarReg.TabIndex = 87;
            this.picCarReg.TabStop = false;
            // 
            // picCarID
            // 
            this.picCarID.Location = new System.Drawing.Point(525, 39);
            this.picCarID.Name = "picCarID";
            this.picCarID.Size = new System.Drawing.Size(26, 22);
            this.picCarID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCarID.TabIndex = 86;
            this.picCarID.TabStop = false;
            // 
            // picCarMake
            // 
            this.picCarMake.Location = new System.Drawing.Point(525, 71);
            this.picCarMake.Name = "picCarMake";
            this.picCarMake.Size = new System.Drawing.Size(26, 22);
            this.picCarMake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCarMake.TabIndex = 85;
            this.picCarMake.TabStop = false;
            // 
            // picCarModel
            // 
            this.picCarModel.Location = new System.Drawing.Point(525, 103);
            this.picCarModel.Name = "picCarModel";
            this.picCarModel.Size = new System.Drawing.Size(26, 22);
            this.picCarModel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCarModel.TabIndex = 84;
            this.picCarModel.TabStop = false;
            // 
            // radDiesel
            // 
            this.radDiesel.AutoSize = true;
            this.radDiesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDiesel.ForeColor = System.Drawing.Color.Black;
            this.radDiesel.Location = new System.Drawing.Point(198, 169);
            this.radDiesel.Name = "radDiesel";
            this.radDiesel.Size = new System.Drawing.Size(65, 20);
            this.radDiesel.TabIndex = 83;
            this.radDiesel.TabStop = true;
            this.radDiesel.Text = "Diesel";
            this.radDiesel.UseVisualStyleBackColor = true;
            // 
            // radUnleaded
            // 
            this.radUnleaded.AutoSize = true;
            this.radUnleaded.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radUnleaded.ForeColor = System.Drawing.Color.Black;
            this.radUnleaded.Location = new System.Drawing.Point(100, 169);
            this.radUnleaded.Name = "radUnleaded";
            this.radUnleaded.Size = new System.Drawing.Size(86, 20);
            this.radUnleaded.TabIndex = 72;
            this.radUnleaded.TabStop = true;
            this.radUnleaded.Text = "Unleaded";
            this.radUnleaded.UseVisualStyleBackColor = true;
            // 
            // dtpLastServiced
            // 
            this.dtpLastServiced.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpLastServiced.Location = new System.Drawing.Point(100, 197);
            this.dtpLastServiced.Name = "dtpLastServiced";
            this.dtpLastServiced.Size = new System.Drawing.Size(451, 22);
            this.dtpLastServiced.TabIndex = 82;
            // 
            // txtCarMake
            // 
            this.txtCarMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarMake.Location = new System.Drawing.Point(101, 71);
            this.txtCarMake.Margin = new System.Windows.Forms.Padding(2);
            this.txtCarMake.Name = "txtCarMake";
            this.txtCarMake.Size = new System.Drawing.Size(419, 22);
            this.txtCarMake.TabIndex = 81;
            // 
            // txtCarModel
            // 
            this.txtCarModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarModel.Location = new System.Drawing.Point(101, 103);
            this.txtCarModel.Margin = new System.Windows.Forms.Padding(2);
            this.txtCarModel.Name = "txtCarModel";
            this.txtCarModel.Size = new System.Drawing.Size(419, 22);
            this.txtCarModel.TabIndex = 80;
            // 
            // txtCarReg
            // 
            this.txtCarReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarReg.Location = new System.Drawing.Point(100, 134);
            this.txtCarReg.Margin = new System.Windows.Forms.Padding(2);
            this.txtCarReg.Name = "txtCarReg";
            this.txtCarReg.Size = new System.Drawing.Size(420, 22);
            this.txtCarReg.TabIndex = 79;
            // 
            // txtCarID
            // 
            this.txtCarID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarID.Location = new System.Drawing.Point(101, 39);
            this.txtCarID.Margin = new System.Windows.Forms.Padding(2);
            this.txtCarID.Name = "txtCarID";
            this.txtCarID.Size = new System.Drawing.Size(419, 22);
            this.txtCarID.TabIndex = 76;
            // 
            // lblLastServiced
            // 
            this.lblLastServiced.AutoSize = true;
            this.lblLastServiced.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastServiced.Location = new System.Drawing.Point(2, 200);
            this.lblLastServiced.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastServiced.Name = "lblLastServiced";
            this.lblLastServiced.Size = new System.Drawing.Size(101, 18);
            this.lblLastServiced.TabIndex = 60;
            this.lblLastServiced.Text = "Last Serviced:";
            // 
            // btnSaveWork
            // 
            this.btnSaveWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveWork.Location = new System.Drawing.Point(1151, 6);
            this.btnSaveWork.Name = "btnSaveWork";
            this.btnSaveWork.Size = new System.Drawing.Size(197, 23);
            this.btnSaveWork.TabIndex = 63;
            this.btnSaveWork.Text = "Save Work";
            this.btnSaveWork.UseVisualStyleBackColor = true;
            this.btnSaveWork.Click += new System.EventHandler(this.btnSaveWork_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 51;
            this.label1.Text = "Auto-Save:";
            // 
            // radAutoSaveOn
            // 
            this.radAutoSaveOn.AutoSize = true;
            this.radAutoSaveOn.ForeColor = System.Drawing.Color.Black;
            this.radAutoSaveOn.Location = new System.Drawing.Point(110, 20);
            this.radAutoSaveOn.Name = "radAutoSaveOn";
            this.radAutoSaveOn.Size = new System.Drawing.Size(39, 17);
            this.radAutoSaveOn.TabIndex = 64;
            this.radAutoSaveOn.TabStop = true;
            this.radAutoSaveOn.Text = "On";
            this.radAutoSaveOn.UseVisualStyleBackColor = true;
            // 
            // radAutoSaveOff
            // 
            this.radAutoSaveOff.AutoSize = true;
            this.radAutoSaveOff.ForeColor = System.Drawing.Color.Black;
            this.radAutoSaveOff.Location = new System.Drawing.Point(155, 20);
            this.radAutoSaveOff.Name = "radAutoSaveOff";
            this.radAutoSaveOff.Size = new System.Drawing.Size(39, 17);
            this.radAutoSaveOff.TabIndex = 65;
            this.radAutoSaveOff.TabStop = true;
            this.radAutoSaveOff.Text = "Off";
            this.radAutoSaveOff.UseVisualStyleBackColor = true;
            // 
            // lblLastSaved
            // 
            this.lblLastSaved.AutoSize = true;
            this.lblLastSaved.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastSaved.Location = new System.Drawing.Point(20, 40);
            this.lblLastSaved.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastSaved.Name = "lblLastSaved";
            this.lblLastSaved.Size = new System.Drawing.Size(125, 18);
            this.lblLastSaved.TabIndex = 66;
            this.lblLastSaved.Text = "Last Saved: 88:88";
            // 
            // lblFileBeingRead
            // 
            this.lblFileBeingRead.AutoSize = true;
            this.lblFileBeingRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileBeingRead.Location = new System.Drawing.Point(2, 8);
            this.lblFileBeingRead.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFileBeingRead.Name = "lblFileBeingRead";
            this.lblFileBeingRead.Size = new System.Drawing.Size(79, 18);
            this.lblFileBeingRead.TabIndex = 67;
            this.lblFileBeingRead.Text = "File Name:";
            // 
            // txtInputFileName
            // 
            this.txtInputFileName.Location = new System.Drawing.Point(86, 8);
            this.txtInputFileName.Name = "txtInputFileName";
            this.txtInputFileName.Size = new System.Drawing.Size(110, 20);
            this.txtInputFileName.TabIndex = 68;
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadFile.Location = new System.Drawing.Point(202, 7);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(99, 23);
            this.btnLoadFile.TabIndex = 69;
            this.btnLoadFile.Text = "Use This File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // picMainLogo
            // 
            this.picMainLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picMainLogo.BackgroundImage")));
            this.picMainLogo.Location = new System.Drawing.Point(446, 6);
            this.picMainLogo.Name = "picMainLogo";
            this.picMainLogo.Size = new System.Drawing.Size(579, 119);
            this.picMainLogo.TabIndex = 70;
            this.picMainLogo.TabStop = false;
            // 
            // btnCancelCompanyUpdate
            // 
            this.btnCancelCompanyUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelCompanyUpdate.Location = new System.Drawing.Point(1122, 443);
            this.btnCancelCompanyUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelCompanyUpdate.Name = "btnCancelCompanyUpdate";
            this.btnCancelCompanyUpdate.Size = new System.Drawing.Size(229, 46);
            this.btnCancelCompanyUpdate.TabIndex = 71;
            this.btnCancelCompanyUpdate.Text = "Cancel Company Update";
            this.btnCancelCompanyUpdate.UseVisualStyleBackColor = true;
            this.btnCancelCompanyUpdate.Click += new System.EventHandler(this.btnCancelCompanyUpdate_Click);
            // 
            // btnCancelCarUpdate
            // 
            this.btnCancelCarUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelCarUpdate.Location = new System.Drawing.Point(1122, 784);
            this.btnCancelCarUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelCarUpdate.Name = "btnCancelCarUpdate";
            this.btnCancelCarUpdate.Size = new System.Drawing.Size(229, 66);
            this.btnCancelCarUpdate.TabIndex = 72;
            this.btnCancelCarUpdate.Text = "Cancel Car Update";
            this.btnCancelCarUpdate.UseVisualStyleBackColor = true;
            this.btnCancelCarUpdate.Click += new System.EventHandler(this.btnCancelCarUpdate_Click);
            // 
            // btnSaveCarChanges
            // 
            this.btnSaveCarChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCarChanges.Location = new System.Drawing.Point(1122, 717);
            this.btnSaveCarChanges.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveCarChanges.Name = "btnSaveCarChanges";
            this.btnSaveCarChanges.Size = new System.Drawing.Size(229, 63);
            this.btnSaveCarChanges.TabIndex = 73;
            this.btnSaveCarChanges.Text = "Save Car Update";
            this.btnSaveCarChanges.UseVisualStyleBackColor = true;
            this.btnSaveCarChanges.Click += new System.EventHandler(this.btnSaveCarChanges_Click);
            // 
            // btnSaveCompanyChanges
            // 
            this.btnSaveCompanyChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCompanyChanges.Location = new System.Drawing.Point(1122, 393);
            this.btnSaveCompanyChanges.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveCompanyChanges.Name = "btnSaveCompanyChanges";
            this.btnSaveCompanyChanges.Size = new System.Drawing.Size(229, 46);
            this.btnSaveCompanyChanges.TabIndex = 74;
            this.btnSaveCompanyChanges.Text = "Save Company Update";
            this.btnSaveCompanyChanges.UseVisualStyleBackColor = true;
            this.btnSaveCompanyChanges.Click += new System.EventHandler(this.btnSaveCompanyChanges_Click);
            // 
            // lstRecentActivity
            // 
            this.lstRecentActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRecentActivity.FormattingEnabled = true;
            this.lstRecentActivity.ItemHeight = 16;
            this.lstRecentActivity.Location = new System.Drawing.Point(1367, 62);
            this.lstRecentActivity.Margin = new System.Windows.Forms.Padding(2);
            this.lstRecentActivity.Name = "lstRecentActivity";
            this.lstRecentActivity.Size = new System.Drawing.Size(448, 788);
            this.lstRecentActivity.TabIndex = 75;
            // 
            // btnRefreshNotifications
            // 
            this.btnRefreshNotifications.Location = new System.Drawing.Point(1716, 37);
            this.btnRefreshNotifications.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefreshNotifications.Name = "btnRefreshNotifications";
            this.btnRefreshNotifications.Size = new System.Drawing.Size(99, 21);
            this.btnRefreshNotifications.TabIndex = 79;
            this.btnRefreshNotifications.Text = "Cancel Search";
            this.btnRefreshNotifications.UseVisualStyleBackColor = true;
            this.btnRefreshNotifications.Click += new System.EventHandler(this.btnRefreshNotifications_Click_1);
            // 
            // btnSearchRecentActivity
            // 
            this.btnSearchRecentActivity.Location = new System.Drawing.Point(1598, 37);
            this.btnSearchRecentActivity.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchRecentActivity.Name = "btnSearchRecentActivity";
            this.btnSearchRecentActivity.Size = new System.Drawing.Size(114, 21);
            this.btnSearchRecentActivity.TabIndex = 78;
            this.btnSearchRecentActivity.Text = "Search";
            this.btnSearchRecentActivity.UseVisualStyleBackColor = true;
            this.btnSearchRecentActivity.Click += new System.EventHandler(this.btnSearchRecentActivity_Click_1);
            // 
            // txtSearchRecentActivity
            // 
            this.txtSearchRecentActivity.Location = new System.Drawing.Point(1367, 38);
            this.txtSearchRecentActivity.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchRecentActivity.Name = "txtSearchRecentActivity";
            this.txtSearchRecentActivity.Size = new System.Drawing.Size(227, 20);
            this.txtSearchRecentActivity.TabIndex = 77;
            // 
            // lblActivityHeader
            // 
            this.lblActivityHeader.AutoSize = true;
            this.lblActivityHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivityHeader.Location = new System.Drawing.Point(1363, 7);
            this.lblActivityHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActivityHeader.Name = "lblActivityHeader";
            this.lblActivityHeader.Size = new System.Drawing.Size(202, 24);
            this.lblActivityHeader.TabIndex = 76;
            this.lblActivityHeader.Text = "Search Recent Activity:";
            // 
            // radNotificationsOff
            // 
            this.radNotificationsOff.AutoSize = true;
            this.radNotificationsOff.ForeColor = System.Drawing.Color.Black;
            this.radNotificationsOff.Location = new System.Drawing.Point(155, 31);
            this.radNotificationsOff.Name = "radNotificationsOff";
            this.radNotificationsOff.Size = new System.Drawing.Size(39, 17);
            this.radNotificationsOff.TabIndex = 82;
            this.radNotificationsOff.TabStop = true;
            this.radNotificationsOff.Text = "Off";
            this.radNotificationsOff.UseVisualStyleBackColor = true;
            // 
            // radNotificationsOn
            // 
            this.radNotificationsOn.AutoSize = true;
            this.radNotificationsOn.ForeColor = System.Drawing.Color.Black;
            this.radNotificationsOn.Location = new System.Drawing.Point(110, 31);
            this.radNotificationsOn.Name = "radNotificationsOn";
            this.radNotificationsOn.Size = new System.Drawing.Size(39, 17);
            this.radNotificationsOn.TabIndex = 81;
            this.radNotificationsOn.TabStop = true;
            this.radNotificationsOn.Text = "On";
            this.radNotificationsOn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 80;
            this.label2.Text = "Notifications:";
            // 
            // grpNotificationSettings
            // 
            this.grpNotificationSettings.Controls.Add(this.label2);
            this.grpNotificationSettings.Controls.Add(this.radNotificationsOff);
            this.grpNotificationSettings.Controls.Add(this.radNotificationsOn);
            this.grpNotificationSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNotificationSettings.Location = new System.Drawing.Point(1151, 108);
            this.grpNotificationSettings.Name = "grpNotificationSettings";
            this.grpNotificationSettings.Size = new System.Drawing.Size(200, 71);
            this.grpNotificationSettings.TabIndex = 83;
            this.grpNotificationSettings.TabStop = false;
            this.grpNotificationSettings.Text = "Notifications";
            // 
            // grpSaveSettings
            // 
            this.grpSaveSettings.Controls.Add(this.lblLastSaved);
            this.grpSaveSettings.Controls.Add(this.label1);
            this.grpSaveSettings.Controls.Add(this.radAutoSaveOn);
            this.grpSaveSettings.Controls.Add(this.radAutoSaveOff);
            this.grpSaveSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSaveSettings.Location = new System.Drawing.Point(1151, 35);
            this.grpSaveSettings.Name = "grpSaveSettings";
            this.grpSaveSettings.Size = new System.Drawing.Size(200, 71);
            this.grpSaveSettings.TabIndex = 84;
            this.grpSaveSettings.TabStop = false;
            this.grpSaveSettings.Text = "Save Your Work";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1359, 854);
            this.Controls.Add(this.grpSaveSettings);
            this.Controls.Add(this.grpNotificationSettings);
            this.Controls.Add(this.btnRefreshNotifications);
            this.Controls.Add(this.btnSearchRecentActivity);
            this.Controls.Add(this.txtSearchRecentActivity);
            this.Controls.Add(this.lblActivityHeader);
            this.Controls.Add(this.lstRecentActivity);
            this.Controls.Add(this.btnSaveCompanyChanges);
            this.Controls.Add(this.btnSaveCarChanges);
            this.Controls.Add(this.btnCancelCarUpdate);
            this.Controls.Add(this.btnCancelCompanyUpdate);
            this.Controls.Add(this.picMainLogo);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.txtInputFileName);
            this.Controls.Add(this.lblFileBeingRead);
            this.Controls.Add(this.btnSaveWork);
            this.Controls.Add(this.grpCarSummary);
            this.Controls.Add(this.grpCompanySummary);
            this.Controls.Add(this.btnRemoveCar);
            this.Controls.Add(this.btnUpdateCar);
            this.Controls.Add(this.btnAddNewCar);
            this.Controls.Add(this.txtSearchCars);
            this.Controls.Add(this.lblCarsHeader);
            this.Controls.Add(this.lstCars);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnRemoveCompany);
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
            this.grpCompanySummary.ResumeLayout(false);
            this.grpCompanySummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCompName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompPostcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompID)).EndInit();
            this.grpCarSummary.ResumeLayout(false);
            this.grpCarSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCarReg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarMake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainLogo)).EndInit();
            this.grpNotificationSettings.ResumeLayout(false);
            this.grpNotificationSettings.PerformLayout();
            this.grpSaveSettings.ResumeLayout(false);
            this.grpSaveSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstAllCompanies;
        private System.Windows.Forms.Label lblCompaniesHeader;
        private System.Windows.Forms.TextBox txtSearchCompanies;
        private System.Windows.Forms.Button btnAddNewCompany;
        private System.Windows.Forms.Button btnUpdateCompany;
        private System.Windows.Forms.Button btnRemoveCompany;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.ListBox lstCars;
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
        private System.Windows.Forms.Button btnSaveWork;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radAutoSaveOn;
        private System.Windows.Forms.RadioButton radAutoSaveOff;
        private System.Windows.Forms.Label lblLastSaved;
        private System.Windows.Forms.Label lblFileBeingRead;
        private System.Windows.Forms.TextBox txtInputFileName;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.PictureBox picMainLogo;
        private System.Windows.Forms.TextBox txtCompID;
        private System.Windows.Forms.TextBox txtCompPostcode;
        private System.Windows.Forms.TextBox txtCompAddress;
        private System.Windows.Forms.TextBox txtCompName;
        private System.Windows.Forms.DateTimePicker dtpLastServiced;
        private System.Windows.Forms.TextBox txtCarMake;
        private System.Windows.Forms.TextBox txtCarModel;
        private System.Windows.Forms.TextBox txtCarReg;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.RadioButton radDiesel;
        private System.Windows.Forms.RadioButton radUnleaded;
        private System.Windows.Forms.Button btnCancelCompanyUpdate;
        private System.Windows.Forms.Button btnCancelCarUpdate;
        private System.Windows.Forms.Button btnSaveCarChanges;
        private System.Windows.Forms.Button btnSaveCompanyChanges;
        private System.Windows.Forms.ListBox lstRecentActivity;
        private System.Windows.Forms.Button btnRefreshNotifications;
        private System.Windows.Forms.Button btnSearchRecentActivity;
        private System.Windows.Forms.TextBox txtSearchRecentActivity;
        private System.Windows.Forms.Label lblActivityHeader;
        private System.Windows.Forms.RadioButton radNotificationsOff;
        private System.Windows.Forms.RadioButton radNotificationsOn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpNotificationSettings;
        private System.Windows.Forms.GroupBox grpSaveSettings;
        private System.Windows.Forms.PictureBox picCompName;
        private System.Windows.Forms.PictureBox picCompAddress;
        private System.Windows.Forms.PictureBox picCompPostcode;
        private System.Windows.Forms.PictureBox picCompID;
        private System.Windows.Forms.PictureBox picCarReg;
        private System.Windows.Forms.PictureBox picCarID;
        private System.Windows.Forms.PictureBox picCarMake;
        private System.Windows.Forms.PictureBox picCarModel;
    }
}

