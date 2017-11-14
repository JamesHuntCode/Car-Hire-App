namespace SOFT151_Coursework
{
    partial class Form1
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
            this.txtSearchCompany = new System.Windows.Forms.TextBox();
            this.btnAddNewCompany = new System.Windows.Forms.Button();
            this.btnUpdateCompany = new System.Windows.Forms.Button();
            this.lblOptions = new System.Windows.Forms.Label();
            this.lblMainHeader = new System.Windows.Forms.Label();
            this.lstRecentActivity = new System.Windows.Forms.ListBox();
            this.txtSearchRecentActivity = new System.Windows.Forms.TextBox();
            this.lblRecentActivityHeader = new System.Windows.Forms.Label();
            this.btnOpenCompany = new System.Windows.Forms.Button();
            this.btnRemoveCompany = new System.Windows.Forms.Button();
            this.lblLogIn = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblLogInStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstAllCompanies
            // 
            this.lstAllCompanies.FormattingEnabled = true;
            this.lstAllCompanies.ItemHeight = 25;
            this.lstAllCompanies.Location = new System.Drawing.Point(375, 305);
            this.lstAllCompanies.Margin = new System.Windows.Forms.Padding(4);
            this.lstAllCompanies.Name = "lstAllCompanies";
            this.lstAllCompanies.Size = new System.Drawing.Size(521, 354);
            this.lstAllCompanies.TabIndex = 0;
            // 
            // lblCompaniesHeader
            // 
            this.lblCompaniesHeader.AutoSize = true;
            this.lblCompaniesHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompaniesHeader.Location = new System.Drawing.Point(473, 202);
            this.lblCompaniesHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompaniesHeader.Name = "lblCompaniesHeader";
            this.lblCompaniesHeader.Size = new System.Drawing.Size(354, 44);
            this.lblCompaniesHeader.TabIndex = 2;
            this.lblCompaniesHeader.Text = "Search Companies:";
            // 
            // txtSearchCompany
            // 
            this.txtSearchCompany.Location = new System.Drawing.Point(375, 259);
            this.txtSearchCompany.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchCompany.Name = "txtSearchCompany";
            this.txtSearchCompany.Size = new System.Drawing.Size(521, 31);
            this.txtSearchCompany.TabIndex = 5;
            this.txtSearchCompany.TextChanged += new System.EventHandler(this.txtSearchCompany_TextChanged);
            // 
            // btnAddNewCompany
            // 
            this.btnAddNewCompany.Location = new System.Drawing.Point(21, 259);
            this.btnAddNewCompany.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewCompany.Name = "btnAddNewCompany";
            this.btnAddNewCompany.Size = new System.Drawing.Size(336, 74);
            this.btnAddNewCompany.TabIndex = 7;
            this.btnAddNewCompany.Text = "Add New Company";
            this.btnAddNewCompany.UseVisualStyleBackColor = true;
            this.btnAddNewCompany.Click += new System.EventHandler(this.btnAddNewCompany_Click);
            // 
            // btnUpdateCompany
            // 
            this.btnUpdateCompany.Location = new System.Drawing.Point(21, 340);
            this.btnUpdateCompany.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateCompany.Name = "btnUpdateCompany";
            this.btnUpdateCompany.Size = new System.Drawing.Size(336, 74);
            this.btnUpdateCompany.TabIndex = 11;
            this.btnUpdateCompany.Text = "Update Selected Company";
            this.btnUpdateCompany.UseVisualStyleBackColor = true;
            this.btnUpdateCompany.Click += new System.EventHandler(this.btnUpdateCompany_Click);
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptions.Location = new System.Drawing.Point(96, 202);
            this.lblOptions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(181, 44);
            this.lblOptions.TabIndex = 12;
            this.lblOptions.Text = "Features:";
            // 
            // lblMainHeader
            // 
            this.lblMainHeader.AutoSize = true;
            this.lblMainHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainHeader.Location = new System.Drawing.Point(12, 11);
            this.lblMainHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMainHeader.Name = "lblMainHeader";
            this.lblMainHeader.Size = new System.Drawing.Size(819, 55);
            this.lblMainHeader.TabIndex = 13;
            this.lblMainHeader.Text = "Hire Car Maintenance Inc Homepage";
            // 
            // lstRecentActivity
            // 
            this.lstRecentActivity.FormattingEnabled = true;
            this.lstRecentActivity.ItemHeight = 25;
            this.lstRecentActivity.Location = new System.Drawing.Point(905, 306);
            this.lstRecentActivity.Margin = new System.Windows.Forms.Padding(4);
            this.lstRecentActivity.Name = "lstRecentActivity";
            this.lstRecentActivity.Size = new System.Drawing.Size(521, 354);
            this.lstRecentActivity.TabIndex = 14;
            // 
            // txtSearchRecentActivity
            // 
            this.txtSearchRecentActivity.Location = new System.Drawing.Point(905, 259);
            this.txtSearchRecentActivity.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchRecentActivity.Name = "txtSearchRecentActivity";
            this.txtSearchRecentActivity.Size = new System.Drawing.Size(521, 31);
            this.txtSearchRecentActivity.TabIndex = 15;
            this.txtSearchRecentActivity.TextChanged += new System.EventHandler(this.txtSearchRecentActivity_TextChanged);
            // 
            // lblRecentActivityHeader
            // 
            this.lblRecentActivityHeader.AutoSize = true;
            this.lblRecentActivityHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentActivityHeader.Location = new System.Drawing.Point(967, 202);
            this.lblRecentActivityHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecentActivityHeader.Name = "lblRecentActivityHeader";
            this.lblRecentActivityHeader.Size = new System.Drawing.Size(413, 44);
            this.lblRecentActivityHeader.TabIndex = 16;
            this.lblRecentActivityHeader.Text = "Search Recent Activity:";
            // 
            // btnOpenCompany
            // 
            this.btnOpenCompany.Location = new System.Drawing.Point(21, 421);
            this.btnOpenCompany.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenCompany.Name = "btnOpenCompany";
            this.btnOpenCompany.Size = new System.Drawing.Size(336, 74);
            this.btnOpenCompany.TabIndex = 17;
            this.btnOpenCompany.Text = "Open Selected Company";
            this.btnOpenCompany.UseVisualStyleBackColor = true;
            this.btnOpenCompany.Click += new System.EventHandler(this.btnOpenCompany_Click);
            // 
            // btnRemoveCompany
            // 
            this.btnRemoveCompany.Location = new System.Drawing.Point(21, 502);
            this.btnRemoveCompany.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveCompany.Name = "btnRemoveCompany";
            this.btnRemoveCompany.Size = new System.Drawing.Size(336, 74);
            this.btnRemoveCompany.TabIndex = 18;
            this.btnRemoveCompany.Text = "Remove Selected Company";
            this.btnRemoveCompany.UseVisualStyleBackColor = true;
            this.btnRemoveCompany.Click += new System.EventHandler(this.btnRemoveCompany_Click);
            // 
            // lblLogIn
            // 
            this.lblLogIn.AutoSize = true;
            this.lblLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogIn.Location = new System.Drawing.Point(1069, 28);
            this.lblLogIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogIn.Name = "lblLogIn";
            this.lblLogIn.Size = new System.Drawing.Size(97, 31);
            this.lblLogIn.TabIndex = 19;
            this.lblLogIn.Text = "Log In:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1173, 28);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 31);
            this.textBox1.TabIndex = 20;
            // 
            // lblLogInStatus
            // 
            this.lblLogInStatus.AutoSize = true;
            this.lblLogInStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogInStatus.Location = new System.Drawing.Point(1168, 75);
            this.lblLogInStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogInStatus.Name = "lblLogInStatus";
            this.lblLogInStatus.Size = new System.Drawing.Size(30, 26);
            this.lblLogInStatus.TabIndex = 21;
            this.lblLogInStatus.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 670);
            this.Controls.Add(this.lblLogInStatus);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblLogIn);
            this.Controls.Add(this.btnRemoveCompany);
            this.Controls.Add(this.btnOpenCompany);
            this.Controls.Add(this.lblRecentActivityHeader);
            this.Controls.Add(this.txtSearchRecentActivity);
            this.Controls.Add(this.lstRecentActivity);
            this.Controls.Add(this.lblMainHeader);
            this.Controls.Add(this.lblOptions);
            this.Controls.Add(this.btnUpdateCompany);
            this.Controls.Add(this.btnAddNewCompany);
            this.Controls.Add(this.txtSearchCompany);
            this.Controls.Add(this.lblCompaniesHeader);
            this.Controls.Add(this.lstAllCompanies);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Hire Car Maintenance Inc";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstAllCompanies;
        private System.Windows.Forms.Label lblCompaniesHeader;
        private System.Windows.Forms.TextBox txtSearchCompany;
        private System.Windows.Forms.Button btnAddNewCompany;
        private System.Windows.Forms.Button btnUpdateCompany;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.Label lblMainHeader;
        private System.Windows.Forms.ListBox lstRecentActivity;
        private System.Windows.Forms.TextBox txtSearchRecentActivity;
        private System.Windows.Forms.Label lblRecentActivityHeader;
        private System.Windows.Forms.Button btnOpenCompany;
        private System.Windows.Forms.Button btnRemoveCompany;
        private System.Windows.Forms.Label lblLogIn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblLogInStatus;
    }
}

