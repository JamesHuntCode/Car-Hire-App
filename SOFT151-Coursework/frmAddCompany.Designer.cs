namespace SOFT151_Coursework
{
    partial class frmAddCompany
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblCompanyId = new System.Windows.Forms.Label();
            this.lblCompanyPostcode = new System.Windows.Forms.Label();
            this.lblCompanyAddress = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtNewID = new System.Windows.Forms.TextBox();
            this.txtNewAddress = new System.Windows.Forms.TextBox();
            this.txtNewPostcode = new System.Windows.Forms.TextBox();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.btnSaveAndUpdate = new System.Windows.Forms.Button();
            this.btnCancelUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(87, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(255, 31);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Add New Company:";
            // 
            // lblCompanyId
            // 
            this.lblCompanyId.AutoSize = true;
            this.lblCompanyId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyId.Location = new System.Drawing.Point(52, 65);
            this.lblCompanyId.Name = "lblCompanyId";
            this.lblCompanyId.Size = new System.Drawing.Size(101, 20);
            this.lblCompanyId.TabIndex = 1;
            this.lblCompanyId.Text = "Company ID:";
            // 
            // lblCompanyPostcode
            // 
            this.lblCompanyPostcode.AutoSize = true;
            this.lblCompanyPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyPostcode.Location = new System.Drawing.Point(2, 161);
            this.lblCompanyPostcode.Name = "lblCompanyPostcode";
            this.lblCompanyPostcode.Size = new System.Drawing.Size(151, 20);
            this.lblCompanyPostcode.TabIndex = 3;
            this.lblCompanyPostcode.Text = "Company Postcode:";
            // 
            // lblCompanyAddress
            // 
            this.lblCompanyAddress.AutoSize = true;
            this.lblCompanyAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyAddress.Location = new System.Drawing.Point(10, 128);
            this.lblCompanyAddress.Name = "lblCompanyAddress";
            this.lblCompanyAddress.Size = new System.Drawing.Size(143, 20);
            this.lblCompanyAddress.TabIndex = 4;
            this.lblCompanyAddress.Text = "Company Address:";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(27, 95);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(126, 20);
            this.lblCompanyName.TabIndex = 5;
            this.lblCompanyName.Text = "Company Name:";
            // 
            // txtNewID
            // 
            this.txtNewID.Location = new System.Drawing.Point(159, 65);
            this.txtNewID.Name = "txtNewID";
            this.txtNewID.Size = new System.Drawing.Size(243, 20);
            this.txtNewID.TabIndex = 6;
            // 
            // txtNewAddress
            // 
            this.txtNewAddress.Location = new System.Drawing.Point(159, 130);
            this.txtNewAddress.Name = "txtNewAddress";
            this.txtNewAddress.Size = new System.Drawing.Size(243, 20);
            this.txtNewAddress.TabIndex = 8;
            // 
            // txtNewPostcode
            // 
            this.txtNewPostcode.Location = new System.Drawing.Point(159, 163);
            this.txtNewPostcode.Name = "txtNewPostcode";
            this.txtNewPostcode.Size = new System.Drawing.Size(243, 20);
            this.txtNewPostcode.TabIndex = 9;
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(159, 97);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(243, 20);
            this.txtNewName.TabIndex = 10;
            // 
            // btnSaveAndUpdate
            // 
            this.btnSaveAndUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAndUpdate.Location = new System.Drawing.Point(10, 217);
            this.btnSaveAndUpdate.Name = "btnSaveAndUpdate";
            this.btnSaveAndUpdate.Size = new System.Drawing.Size(188, 48);
            this.btnSaveAndUpdate.TabIndex = 11;
            this.btnSaveAndUpdate.Text = "Add Company";
            this.btnSaveAndUpdate.UseVisualStyleBackColor = true;
            this.btnSaveAndUpdate.Click += new System.EventHandler(this.btnSaveAndUpdate_Click);
            // 
            // btnCancelUpdate
            // 
            this.btnCancelUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelUpdate.Location = new System.Drawing.Point(214, 217);
            this.btnCancelUpdate.Name = "btnCancelUpdate";
            this.btnCancelUpdate.Size = new System.Drawing.Size(188, 48);
            this.btnCancelUpdate.TabIndex = 12;
            this.btnCancelUpdate.Text = "Cancel";
            this.btnCancelUpdate.UseVisualStyleBackColor = true;
            this.btnCancelUpdate.Click += new System.EventHandler(this.btnCancelUpdate_Click);
            // 
            // frmAddCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 273);
            this.Controls.Add(this.btnCancelUpdate);
            this.Controls.Add(this.btnSaveAndUpdate);
            this.Controls.Add(this.txtNewName);
            this.Controls.Add(this.txtNewPostcode);
            this.Controls.Add(this.txtNewAddress);
            this.Controls.Add(this.txtNewID);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblCompanyAddress);
            this.Controls.Add(this.lblCompanyPostcode);
            this.Controls.Add(this.lblCompanyId);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAddCompany";
            this.Text = "DynamicAddOrUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblCompanyId;
        private System.Windows.Forms.Label lblCompanyPostcode;
        private System.Windows.Forms.Label lblCompanyAddress;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtNewID;
        private System.Windows.Forms.TextBox txtNewAddress;
        private System.Windows.Forms.TextBox txtNewPostcode;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.Button btnSaveAndUpdate;
        private System.Windows.Forms.Button btnCancelUpdate;
    }
}