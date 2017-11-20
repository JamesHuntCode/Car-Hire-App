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
            this.btnOpenCompany = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).BeginInit();
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
            this.lstAllCompanies.Size = new System.Drawing.Size(543, 292);
            this.lstAllCompanies.TabIndex = 0;
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
            this.txtSearchCompanies.Size = new System.Drawing.Size(275, 20);
            this.txtSearchCompanies.TabIndex = 5;
            // 
            // btnAddNewCompany
            // 
            this.btnAddNewCompany.Location = new System.Drawing.Point(522, 597);
            this.btnAddNewCompany.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewCompany.Name = "btnAddNewCompany";
            this.btnAddNewCompany.Size = new System.Drawing.Size(168, 67);
            this.btnAddNewCompany.TabIndex = 7;
            this.btnAddNewCompany.Text = "Add New Company";
            this.btnAddNewCompany.UseVisualStyleBackColor = true;
            this.btnAddNewCompany.Click += new System.EventHandler(this.btnAddNewCompany_Click);
            // 
            // btnUpdateCompany
            // 
            this.btnUpdateCompany.Location = new System.Drawing.Point(178, 597);
            this.btnUpdateCompany.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateCompany.Name = "btnUpdateCompany";
            this.btnUpdateCompany.Size = new System.Drawing.Size(168, 67);
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
            this.lstRecentActivity.Location = new System.Drawing.Point(553, 301);
            this.lstRecentActivity.Margin = new System.Windows.Forms.Padding(2);
            this.lstRecentActivity.Name = "lstRecentActivity";
            this.lstRecentActivity.Size = new System.Drawing.Size(543, 292);
            this.lstRecentActivity.TabIndex = 14;
            // 
            // txtSearchRecentActivity
            // 
            this.txtSearchRecentActivity.Location = new System.Drawing.Point(553, 277);
            this.txtSearchRecentActivity.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchRecentActivity.Name = "txtSearchRecentActivity";
            this.txtSearchRecentActivity.Size = new System.Drawing.Size(275, 20);
            this.txtSearchRecentActivity.TabIndex = 15;
            // 
            // lblRecentActivityHeader
            // 
            this.lblRecentActivityHeader.AutoSize = true;
            this.lblRecentActivityHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentActivityHeader.Location = new System.Drawing.Point(549, 251);
            this.lblRecentActivityHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecentActivityHeader.Name = "lblRecentActivityHeader";
            this.lblRecentActivityHeader.Size = new System.Drawing.Size(202, 24);
            this.lblRecentActivityHeader.TabIndex = 16;
            this.lblRecentActivityHeader.Text = "Search Recent Activity:";
            // 
            // btnOpenCompany
            // 
            this.btnOpenCompany.Location = new System.Drawing.Point(6, 597);
            this.btnOpenCompany.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenCompany.Name = "btnOpenCompany";
            this.btnOpenCompany.Size = new System.Drawing.Size(168, 67);
            this.btnOpenCompany.TabIndex = 17;
            this.btnOpenCompany.Text = "View Selected Company";
            this.btnOpenCompany.UseVisualStyleBackColor = true;
            this.btnOpenCompany.Click += new System.EventHandler(this.btnOpenCompany_Click);
            // 
            // btnRemoveCompany
            // 
            this.btnRemoveCompany.Location = new System.Drawing.Point(350, 597);
            this.btnRemoveCompany.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveCompany.Name = "btnRemoveCompany";
            this.btnRemoveCompany.Size = new System.Drawing.Size(168, 67);
            this.btnRemoveCompany.TabIndex = 18;
            this.btnRemoveCompany.Text = "Remove Selected Company";
            this.btnRemoveCompany.UseVisualStyleBackColor = true;
            this.btnRemoveCompany.Click += new System.EventHandler(this.btnRemoveCompany_Click);
            // 
            // btnSearchCompanies
            // 
            this.btnSearchCompanies.Location = new System.Drawing.Point(285, 277);
            this.btnSearchCompanies.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchCompanies.Name = "btnSearchCompanies";
            this.btnSearchCompanies.Size = new System.Drawing.Size(130, 20);
            this.btnSearchCompanies.TabIndex = 19;
            this.btnSearchCompanies.Text = "Search";
            this.btnSearchCompanies.UseVisualStyleBackColor = true;
            this.btnSearchCompanies.Click += new System.EventHandler(this.btnSearchCompanies_Click);
            // 
            // btnSearchRecentActivity
            // 
            this.btnSearchRecentActivity.Location = new System.Drawing.Point(832, 277);
            this.btnSearchRecentActivity.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchRecentActivity.Name = "btnSearchRecentActivity";
            this.btnSearchRecentActivity.Size = new System.Drawing.Size(130, 20);
            this.btnSearchRecentActivity.TabIndex = 20;
            this.btnSearchRecentActivity.Text = "Search";
            this.btnSearchRecentActivity.UseVisualStyleBackColor = true;
            this.btnSearchRecentActivity.Click += new System.EventHandler(this.btnSearchRecentActivity_Click);
            // 
            // btnRefreshCompanies
            // 
            this.btnRefreshCompanies.Location = new System.Drawing.Point(419, 277);
            this.btnRefreshCompanies.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefreshCompanies.Name = "btnRefreshCompanies";
            this.btnRefreshCompanies.Size = new System.Drawing.Size(130, 20);
            this.btnRefreshCompanies.TabIndex = 21;
            this.btnRefreshCompanies.Text = "Cancel Search";
            this.btnRefreshCompanies.UseVisualStyleBackColor = true;
            this.btnRefreshCompanies.Click += new System.EventHandler(this.btnRefreshCompanies_Click);
            // 
            // btnRefreshNotifications
            // 
            this.btnRefreshNotifications.Location = new System.Drawing.Point(966, 277);
            this.btnRefreshNotifications.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefreshNotifications.Name = "btnRefreshNotifications";
            this.btnRefreshNotifications.Size = new System.Drawing.Size(130, 20);
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
            this.lblDisplayDate.Location = new System.Drawing.Point(2, 9);
            this.lblDisplayDate.Name = "lblDisplayDate";
            this.lblDisplayDate.Size = new System.Drawing.Size(102, 20);
            this.lblDisplayDate.TabIndex = 24;
            this.lblDisplayDate.Text = "Todays\' Date";
            // 
            // btnClearAllCompanies
            // 
            this.btnClearAllCompanies.Location = new System.Drawing.Point(866, 597);
            this.btnClearAllCompanies.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearAllCompanies.Name = "btnClearAllCompanies";
            this.btnClearAllCompanies.Size = new System.Drawing.Size(168, 67);
            this.btnClearAllCompanies.TabIndex = 25;
            this.btnClearAllCompanies.Text = "Remove All Data";
            this.btnClearAllCompanies.UseVisualStyleBackColor = true;
            this.btnClearAllCompanies.Click += new System.EventHandler(this.btnClearAllCompanies_Click);
            // 
            // btnClearAllNotifications
            // 
            this.btnClearAllNotifications.Location = new System.Drawing.Point(694, 597);
            this.btnClearAllNotifications.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearAllNotifications.Name = "btnClearAllNotifications";
            this.btnClearAllNotifications.Size = new System.Drawing.Size(168, 67);
            this.btnClearAllNotifications.TabIndex = 26;
            this.btnClearAllNotifications.Text = "Clear All Notifications";
            this.btnClearAllNotifications.UseVisualStyleBackColor = true;
            this.btnClearAllNotifications.Click += new System.EventHandler(this.btnClearAllNotifications_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(1038, 597);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(2);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(58, 67);
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
            this.lblTheTime.Location = new System.Drawing.Point(1034, 9);
            this.lblTheTime.Name = "lblTheTime";
            this.lblTheTime.Size = new System.Drawing.Size(43, 20);
            this.lblTheTime.TabIndex = 28;
            this.lblTheTime.Text = "Time";
            // 
            // picBanner
            // 
            this.picBanner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBanner.BackgroundImage")));
            this.picBanner.Location = new System.Drawing.Point(178, 9);
            this.picBanner.Name = "picBanner";
            this.picBanner.Size = new System.Drawing.Size(750, 201);
            this.picBanner.TabIndex = 29;
            this.picBanner.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 669);
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
            this.Controls.Add(this.btnOpenCompany);
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
        private System.Windows.Forms.Button btnOpenCompany;
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
    }
}

