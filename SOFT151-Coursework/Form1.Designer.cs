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
            this.lstAllCompanies.ItemHeight = 20;
            this.lstAllCompanies.Location = new System.Drawing.Point(281, 244);
            this.lstAllCompanies.Name = "lstAllCompanies";
            this.lstAllCompanies.Size = new System.Drawing.Size(392, 284);
            this.lstAllCompanies.TabIndex = 0;
            // 
            // lblCompaniesHeader
            // 
            this.lblCompaniesHeader.AutoSize = true;
            this.lblCompaniesHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompaniesHeader.Location = new System.Drawing.Point(355, 162);
            this.lblCompaniesHeader.Name = "lblCompaniesHeader";
            this.lblCompaniesHeader.Size = new System.Drawing.Size(264, 32);
            this.lblCompaniesHeader.TabIndex = 2;
            this.lblCompaniesHeader.Text = "Search Companies:";
            // 
            // txtSearchCompany
            // 
            this.txtSearchCompany.Location = new System.Drawing.Point(281, 207);
            this.txtSearchCompany.Name = "txtSearchCompany";
            this.txtSearchCompany.Size = new System.Drawing.Size(392, 26);
            this.txtSearchCompany.TabIndex = 5;
            // 
            // btnAddNewCompany
            // 
            this.btnAddNewCompany.Location = new System.Drawing.Point(16, 207);
            this.btnAddNewCompany.Name = "btnAddNewCompany";
            this.btnAddNewCompany.Size = new System.Drawing.Size(252, 59);
            this.btnAddNewCompany.TabIndex = 7;
            this.btnAddNewCompany.Text = "Add New Company";
            this.btnAddNewCompany.UseVisualStyleBackColor = true;
            // 
            // btnUpdateCompany
            // 
            this.btnUpdateCompany.Location = new System.Drawing.Point(16, 272);
            this.btnUpdateCompany.Name = "btnUpdateCompany";
            this.btnUpdateCompany.Size = new System.Drawing.Size(252, 59);
            this.btnUpdateCompany.TabIndex = 11;
            this.btnUpdateCompany.Text = "Update Selected Company";
            this.btnUpdateCompany.UseVisualStyleBackColor = true;
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptions.Location = new System.Drawing.Point(72, 162);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(135, 32);
            this.lblOptions.TabIndex = 12;
            this.lblOptions.Text = "Features:";
            // 
            // lblMainHeader
            // 
            this.lblMainHeader.AutoSize = true;
            this.lblMainHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainHeader.Location = new System.Drawing.Point(9, 9);
            this.lblMainHeader.Name = "lblMainHeader";
            this.lblMainHeader.Size = new System.Drawing.Size(610, 40);
            this.lblMainHeader.TabIndex = 13;
            this.lblMainHeader.Text = "Hire Car Maintenance Inc Homepage";
            // 
            // lstRecentActivity
            // 
            this.lstRecentActivity.FormattingEnabled = true;
            this.lstRecentActivity.ItemHeight = 20;
            this.lstRecentActivity.Location = new System.Drawing.Point(679, 245);
            this.lstRecentActivity.Name = "lstRecentActivity";
            this.lstRecentActivity.Size = new System.Drawing.Size(392, 284);
            this.lstRecentActivity.TabIndex = 14;
            // 
            // txtSearchRecentActivity
            // 
            this.txtSearchRecentActivity.Location = new System.Drawing.Point(679, 207);
            this.txtSearchRecentActivity.Name = "txtSearchRecentActivity";
            this.txtSearchRecentActivity.Size = new System.Drawing.Size(392, 26);
            this.txtSearchRecentActivity.TabIndex = 15;
            // 
            // lblRecentActivityHeader
            // 
            this.lblRecentActivityHeader.AutoSize = true;
            this.lblRecentActivityHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentActivityHeader.Location = new System.Drawing.Point(725, 162);
            this.lblRecentActivityHeader.Name = "lblRecentActivityHeader";
            this.lblRecentActivityHeader.Size = new System.Drawing.Size(308, 32);
            this.lblRecentActivityHeader.TabIndex = 16;
            this.lblRecentActivityHeader.Text = "Search Recent Activity:";
            // 
            // btnOpenCompany
            // 
            this.btnOpenCompany.Location = new System.Drawing.Point(16, 337);
            this.btnOpenCompany.Name = "btnOpenCompany";
            this.btnOpenCompany.Size = new System.Drawing.Size(252, 59);
            this.btnOpenCompany.TabIndex = 17;
            this.btnOpenCompany.Text = "Open Selected Company";
            this.btnOpenCompany.UseVisualStyleBackColor = true;
            // 
            // btnRemoveCompany
            // 
            this.btnRemoveCompany.Location = new System.Drawing.Point(16, 402);
            this.btnRemoveCompany.Name = "btnRemoveCompany";
            this.btnRemoveCompany.Size = new System.Drawing.Size(252, 59);
            this.btnRemoveCompany.TabIndex = 18;
            this.btnRemoveCompany.Text = "Remove Selected Company";
            this.btnRemoveCompany.UseVisualStyleBackColor = true;
            // 
            // lblLogIn
            // 
            this.lblLogIn.AutoSize = true;
            this.lblLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogIn.Location = new System.Drawing.Point(802, 22);
            this.lblLogIn.Name = "lblLogIn";
            this.lblLogIn.Size = new System.Drawing.Size(72, 25);
            this.lblLogIn.TabIndex = 19;
            this.lblLogIn.Text = "Log In:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(880, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 26);
            this.textBox1.TabIndex = 20;
            // 
            // lblLogInStatus
            // 
            this.lblLogInStatus.AutoSize = true;
            this.lblLogInStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogInStatus.Location = new System.Drawing.Point(876, 51);
            this.lblLogInStatus.Name = "lblLogInStatus";
            this.lblLogInStatus.Size = new System.Drawing.Size(21, 20);
            this.lblLogInStatus.TabIndex = 21;
            this.lblLogInStatus.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 536);
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
            this.Name = "Form1";
            this.Text = "Hire Car Maintenance Inc";
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

