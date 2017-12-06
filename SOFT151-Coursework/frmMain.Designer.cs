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
            this.btnSearchCompanies = new System.Windows.Forms.Button();
            this.btnRefreshCompanies = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
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
            this.txtCompID = new System.Windows.Forms.TextBox();
            this.txtCompPostcode = new System.Windows.Forms.TextBox();
            this.txtCompAddress = new System.Windows.Forms.TextBox();
            this.txtCompName = new System.Windows.Forms.TextBox();
            this.grpCarSummary = new System.Windows.Forms.GroupBox();
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
            this.grpCompanySummary.SuspendLayout();
            this.grpCarSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMainLogo)).BeginInit();
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
            this.txtSearchCompanies.Location = new System.Drawing.Point(8, 224);
            this.txtSearchCompanies.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchCompanies.Name = "txtSearchCompanies";
            this.txtSearchCompanies.Size = new System.Drawing.Size(309, 20);
            this.txtSearchCompanies.TabIndex = 5;
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
            // btnSearchCompanies
            // 
            this.btnSearchCompanies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCompanies.Location = new System.Drawing.Point(321, 224);
            this.btnSearchCompanies.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchCompanies.Name = "btnSearchCompanies";
            this.btnSearchCompanies.Size = new System.Drawing.Size(111, 21);
            this.btnSearchCompanies.TabIndex = 19;
            this.btnSearchCompanies.Text = "Search";
            this.btnSearchCompanies.UseVisualStyleBackColor = true;
            this.btnSearchCompanies.Click += new System.EventHandler(this.btnSearchCompanies_Click);
            // 
            // btnRefreshCompanies
            // 
            this.btnRefreshCompanies.Location = new System.Drawing.Point(436, 224);
            this.btnRefreshCompanies.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefreshCompanies.Name = "btnRefreshCompanies";
            this.btnRefreshCompanies.Size = new System.Drawing.Size(109, 21);
            this.btnRefreshCompanies.TabIndex = 21;
            this.btnRefreshCompanies.Text = "Cancel Search";
            this.btnRefreshCompanies.UseVisualStyleBackColor = true;
            this.btnRefreshCompanies.Click += new System.EventHandler(this.btnRefreshCompanies_Click);
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
            // btnRefreshCars
            // 
            this.btnRefreshCars.Location = new System.Drawing.Point(446, 551);
            this.btnRefreshCars.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefreshCars.Name = "btnRefreshCars";
            this.btnRefreshCars.Size = new System.Drawing.Size(99, 21);
            this.btnRefreshCars.TabIndex = 34;
            this.btnRefreshCars.Text = "Cancel Search";
            this.btnRefreshCars.UseVisualStyleBackColor = true;
            this.btnRefreshCars.Click += new System.EventHandler(this.btnRefreshCars_Click);
            // 
            // btnSearchCar
            // 
            this.btnSearchCar.Location = new System.Drawing.Point(328, 551);
            this.btnSearchCar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchCar.Name = "btnSearchCar";
            this.btnSearchCar.Size = new System.Drawing.Size(114, 21);
            this.btnSearchCar.TabIndex = 33;
            this.btnSearchCar.Text = "Search";
            this.btnSearchCar.UseVisualStyleBackColor = true;
            this.btnSearchCar.Click += new System.EventHandler(this.btnSearchCar_Click);
            // 
            // txtSearchCars
            // 
            this.txtSearchCars.Location = new System.Drawing.Point(5, 552);
            this.txtSearchCars.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchCars.Name = "txtSearchCars";
            this.txtSearchCars.Size = new System.Drawing.Size(319, 20);
            this.txtSearchCars.TabIndex = 32;
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
            // txtCompID
            // 
            this.txtCompID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompID.Location = new System.Drawing.Point(104, 47);
            this.txtCompID.Margin = new System.Windows.Forms.Padding(2);
            this.txtCompID.Name = "txtCompID";
            this.txtCompID.Size = new System.Drawing.Size(447, 22);
            this.txtCompID.TabIndex = 75;
            // 
            // txtCompPostcode
            // 
            this.txtCompPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompPostcode.Location = new System.Drawing.Point(104, 152);
            this.txtCompPostcode.Margin = new System.Windows.Forms.Padding(2);
            this.txtCompPostcode.Name = "txtCompPostcode";
            this.txtCompPostcode.Size = new System.Drawing.Size(447, 22);
            this.txtCompPostcode.TabIndex = 73;
            // 
            // txtCompAddress
            // 
            this.txtCompAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompAddress.Location = new System.Drawing.Point(104, 116);
            this.txtCompAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtCompAddress.Name = "txtCompAddress";
            this.txtCompAddress.Size = new System.Drawing.Size(447, 22);
            this.txtCompAddress.TabIndex = 72;
            // 
            // txtCompName
            // 
            this.txtCompName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompName.Location = new System.Drawing.Point(104, 82);
            this.txtCompName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCompName.Name = "txtCompName";
            this.txtCompName.Size = new System.Drawing.Size(447, 22);
            this.txtCompName.TabIndex = 71;
            // 
            // grpCarSummary
            // 
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
            this.txtCarMake.Size = new System.Drawing.Size(451, 22);
            this.txtCarMake.TabIndex = 81;
            // 
            // txtCarModel
            // 
            this.txtCarModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarModel.Location = new System.Drawing.Point(101, 103);
            this.txtCarModel.Margin = new System.Windows.Forms.Padding(2);
            this.txtCarModel.Name = "txtCarModel";
            this.txtCarModel.Size = new System.Drawing.Size(451, 22);
            this.txtCarModel.TabIndex = 80;
            // 
            // txtCarReg
            // 
            this.txtCarReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarReg.Location = new System.Drawing.Point(100, 134);
            this.txtCarReg.Margin = new System.Windows.Forms.Padding(2);
            this.txtCarReg.Name = "txtCarReg";
            this.txtCarReg.Size = new System.Drawing.Size(451, 22);
            this.txtCarReg.TabIndex = 79;
            // 
            // txtCarID
            // 
            this.txtCarID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarID.Location = new System.Drawing.Point(101, 39);
            this.txtCarID.Margin = new System.Windows.Forms.Padding(2);
            this.txtCarID.Name = "txtCarID";
            this.txtCarID.Size = new System.Drawing.Size(451, 22);
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
            this.btnSaveWork.Location = new System.Drawing.Point(1185, 7);
            this.btnSaveWork.Name = "btnSaveWork";
            this.btnSaveWork.Size = new System.Drawing.Size(166, 23);
            this.btnSaveWork.TabIndex = 63;
            this.btnSaveWork.Text = "Save Work";
            this.btnSaveWork.UseVisualStyleBackColor = true;
            this.btnSaveWork.Click += new System.EventHandler(this.btnSaveWork_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1182, 33);
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
            this.radAutoSaveOn.Location = new System.Drawing.Point(1264, 34);
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
            this.radAutoSaveOff.Location = new System.Drawing.Point(1309, 34);
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
            this.lblLastSaved.Location = new System.Drawing.Point(1182, 55);
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
            this.picMainLogo.Location = new System.Drawing.Point(436, 4);
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1360, 854);
            this.Controls.Add(this.btnSaveCompanyChanges);
            this.Controls.Add(this.btnSaveCarChanges);
            this.Controls.Add(this.btnCancelCarUpdate);
            this.Controls.Add(this.btnCancelCompanyUpdate);
            this.Controls.Add(this.picMainLogo);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.txtInputFileName);
            this.Controls.Add(this.lblFileBeingRead);
            this.Controls.Add(this.lblLastSaved);
            this.Controls.Add(this.radAutoSaveOff);
            this.Controls.Add(this.radAutoSaveOn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveWork);
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
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnRefreshCompanies);
            this.Controls.Add(this.btnSearchCompanies);
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
            this.grpCarSummary.ResumeLayout(false);
            this.grpCarSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMainLogo)).EndInit();
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
        private System.Windows.Forms.Button btnSearchCompanies;
        private System.Windows.Forms.Button btnRefreshCompanies;
        private System.Windows.Forms.Button btnAbout;
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
    }
}

