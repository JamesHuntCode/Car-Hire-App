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
            this.lstAllCompanies = new System.Windows.Forms.ListBox();
            this.lblCompaniesHeader = new System.Windows.Forms.Label();
            this.txtSearchCompanies = new System.Windows.Forms.TextBox();
            this.btnAddNewCompany = new System.Windows.Forms.Button();
            this.btnUpdateCompany = new System.Windows.Forms.Button();
            this.lblOptions = new System.Windows.Forms.Label();
            this.lblMainHeader = new System.Windows.Forms.Label();
            this.lstRecentActivity = new System.Windows.Forms.ListBox();
            this.txtSearchRecentActivity = new System.Windows.Forms.TextBox();
            this.lblRecentActivityHeader = new System.Windows.Forms.Label();
            this.btnOpenCompany = new System.Windows.Forms.Button();
            this.btnRemoveCompany = new System.Windows.Forms.Button();
            this.btnSearchCompanies = new System.Windows.Forms.Button();
            this.btnSearchRecentActivity = new System.Windows.Forms.Button();
            this.btnRefreshCompanies = new System.Windows.Forms.Button();
            this.btnRefreshNotifications = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstAllCompanies
            // 
            this.lstAllCompanies.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAllCompanies.FormattingEnabled = true;
            this.lstAllCompanies.ItemHeight = 18;
            this.lstAllCompanies.Location = new System.Drawing.Point(188, 159);
            this.lstAllCompanies.Margin = new System.Windows.Forms.Padding(2);
            this.lstAllCompanies.Name = "lstAllCompanies";
            this.lstAllCompanies.Size = new System.Drawing.Size(543, 292);
            this.lstAllCompanies.TabIndex = 0;
            // 
            // lblCompaniesHeader
            // 
            this.lblCompaniesHeader.AutoSize = true;
            this.lblCompaniesHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompaniesHeader.Location = new System.Drawing.Point(238, 105);
            this.lblCompaniesHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompaniesHeader.Name = "lblCompaniesHeader";
            this.lblCompaniesHeader.Size = new System.Drawing.Size(176, 24);
            this.lblCompaniesHeader.TabIndex = 2;
            this.lblCompaniesHeader.Text = "Search Companies:";
            // 
            // txtSearchCompanies
            // 
            this.txtSearchCompanies.Location = new System.Drawing.Point(188, 135);
            this.txtSearchCompanies.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchCompanies.Name = "txtSearchCompanies";
            this.txtSearchCompanies.Size = new System.Drawing.Size(275, 20);
            this.txtSearchCompanies.TabIndex = 5;
            // 
            // btnAddNewCompany
            // 
            this.btnAddNewCompany.Location = new System.Drawing.Point(11, 313);
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
            this.btnUpdateCompany.Location = new System.Drawing.Point(11, 230);
            this.btnUpdateCompany.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateCompany.Name = "btnUpdateCompany";
            this.btnUpdateCompany.Size = new System.Drawing.Size(168, 67);
            this.btnUpdateCompany.TabIndex = 11;
            this.btnUpdateCompany.Text = "Update Selected Company";
            this.btnUpdateCompany.UseVisualStyleBackColor = true;
            this.btnUpdateCompany.Click += new System.EventHandler(this.btnUpdateCompany_Click);
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptions.Location = new System.Drawing.Point(58, 130);
            this.lblOptions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(64, 24);
            this.lblOptions.TabIndex = 12;
            this.lblOptions.Text = "Menu:";
            // 
            // lblMainHeader
            // 
            this.lblMainHeader.AutoSize = true;
            this.lblMainHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainHeader.Location = new System.Drawing.Point(6, 6);
            this.lblMainHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMainHeader.Name = "lblMainHeader";
            this.lblMainHeader.Size = new System.Drawing.Size(408, 29);
            this.lblMainHeader.TabIndex = 13;
            this.lblMainHeader.Text = "Hire Car Maintenance Inc Homepage";
            // 
            // lstRecentActivity
            // 
            this.lstRecentActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRecentActivity.FormattingEnabled = true;
            this.lstRecentActivity.ItemHeight = 18;
            this.lstRecentActivity.Location = new System.Drawing.Point(735, 159);
            this.lstRecentActivity.Margin = new System.Windows.Forms.Padding(2);
            this.lstRecentActivity.Name = "lstRecentActivity";
            this.lstRecentActivity.Size = new System.Drawing.Size(543, 292);
            this.lstRecentActivity.TabIndex = 14;
            // 
            // txtSearchRecentActivity
            // 
            this.txtSearchRecentActivity.Location = new System.Drawing.Point(735, 135);
            this.txtSearchRecentActivity.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchRecentActivity.Name = "txtSearchRecentActivity";
            this.txtSearchRecentActivity.Size = new System.Drawing.Size(275, 20);
            this.txtSearchRecentActivity.TabIndex = 15;
            // 
            // lblRecentActivityHeader
            // 
            this.lblRecentActivityHeader.AutoSize = true;
            this.lblRecentActivityHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentActivityHeader.Location = new System.Drawing.Point(775, 109);
            this.lblRecentActivityHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecentActivityHeader.Name = "lblRecentActivityHeader";
            this.lblRecentActivityHeader.Size = new System.Drawing.Size(202, 24);
            this.lblRecentActivityHeader.TabIndex = 16;
            this.lblRecentActivityHeader.Text = "Search Recent Activity:";
            // 
            // btnOpenCompany
            // 
            this.btnOpenCompany.Location = new System.Drawing.Point(11, 159);
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
            this.btnRemoveCompany.Location = new System.Drawing.Point(11, 384);
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
            this.btnSearchCompanies.Location = new System.Drawing.Point(467, 135);
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
            this.btnSearchRecentActivity.Location = new System.Drawing.Point(1014, 135);
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
            this.btnRefreshCompanies.Location = new System.Drawing.Point(601, 135);
            this.btnRefreshCompanies.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefreshCompanies.Name = "btnRefreshCompanies";
            this.btnRefreshCompanies.Size = new System.Drawing.Size(130, 20);
            this.btnRefreshCompanies.TabIndex = 21;
            this.btnRefreshCompanies.Text = "Refresh";
            this.btnRefreshCompanies.UseVisualStyleBackColor = true;
            this.btnRefreshCompanies.Click += new System.EventHandler(this.btnRefreshCompanies_Click);
            // 
            // btnRefreshNotifications
            // 
            this.btnRefreshNotifications.Location = new System.Drawing.Point(1148, 135);
            this.btnRefreshNotifications.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefreshNotifications.Name = "btnRefreshNotifications";
            this.btnRefreshNotifications.Size = new System.Drawing.Size(130, 20);
            this.btnRefreshNotifications.TabIndex = 22;
            this.btnRefreshNotifications.Text = "Refresh";
            this.btnRefreshNotifications.UseVisualStyleBackColor = true;
            this.btnRefreshNotifications.Click += new System.EventHandler(this.btnRefreshNotifications_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 462);
            this.Controls.Add(this.btnRefreshNotifications);
            this.Controls.Add(this.btnRefreshCompanies);
            this.Controls.Add(this.btnSearchRecentActivity);
            this.Controls.Add(this.btnSearchCompanies);
            this.Controls.Add(this.btnRemoveCompany);
            this.Controls.Add(this.btnOpenCompany);
            this.Controls.Add(this.lblRecentActivityHeader);
            this.Controls.Add(this.txtSearchRecentActivity);
            this.Controls.Add(this.lstRecentActivity);
            this.Controls.Add(this.lblMainHeader);
            this.Controls.Add(this.lblOptions);
            this.Controls.Add(this.btnUpdateCompany);
            this.Controls.Add(this.btnAddNewCompany);
            this.Controls.Add(this.txtSearchCompanies);
            this.Controls.Add(this.lblCompaniesHeader);
            this.Controls.Add(this.lstAllCompanies);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "Hire Car Maintenance Inc";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstAllCompanies;
        private System.Windows.Forms.Label lblCompaniesHeader;
        private System.Windows.Forms.TextBox txtSearchCompanies;
        private System.Windows.Forms.Button btnAddNewCompany;
        private System.Windows.Forms.Button btnUpdateCompany;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.Label lblMainHeader;
        private System.Windows.Forms.ListBox lstRecentActivity;
        private System.Windows.Forms.TextBox txtSearchRecentActivity;
        private System.Windows.Forms.Label lblRecentActivityHeader;
        private System.Windows.Forms.Button btnOpenCompany;
        private System.Windows.Forms.Button btnRemoveCompany;
        private System.Windows.Forms.Button btnSearchCompanies;
        private System.Windows.Forms.Button btnSearchRecentActivity;
        private System.Windows.Forms.Button btnRefreshCompanies;
        private System.Windows.Forms.Button btnRefreshNotifications;
    }
}

