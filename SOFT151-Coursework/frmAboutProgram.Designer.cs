namespace SOFT151_Coursework
{
    partial class frmAboutProgram
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
            this.lblCreationDate = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblCodedIn = new System.Windows.Forms.Label();
            this.txtDisplaySupport = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(80, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(463, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Software Support (FULL PROGRAM MANUAL):";
            // 
            // lblCreationDate
            // 
            this.lblCreationDate.AutoSize = true;
            this.lblCreationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreationDate.Location = new System.Drawing.Point(12, 60);
            this.lblCreationDate.Name = "lblCreationDate";
            this.lblCreationDate.Size = new System.Drawing.Size(185, 20);
            this.lblCreationDate.TabIndex = 1;
            this.lblCreationDate.Text = "Project Started: 14/11/17";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(245, 60);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(170, 20);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "Program Version: 2.1.1";
            // 
            // lblCodedIn
            // 
            this.lblCodedIn.AutoSize = true;
            this.lblCodedIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodedIn.Location = new System.Drawing.Point(472, 60);
            this.lblCodedIn.Name = "lblCodedIn";
            this.lblCodedIn.Size = new System.Drawing.Size(144, 20);
            this.lblCodedIn.TabIndex = 3;
            this.lblCodedIn.Text = "Programmed in: C#";
            // 
            // txtDisplaySupport
            // 
            this.txtDisplaySupport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplaySupport.Location = new System.Drawing.Point(12, 98);
            this.txtDisplaySupport.Name = "txtDisplaySupport";
            this.txtDisplaySupport.Size = new System.Drawing.Size(604, 523);
            this.txtDisplaySupport.TabIndex = 4;
            this.txtDisplaySupport.Text = "";
            // 
            // frmAboutProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 633);
            this.Controls.Add(this.txtDisplaySupport);
            this.Controls.Add(this.lblCodedIn);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblCreationDate);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAboutProgram";
            this.Text = "frmAboutProgram";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblCreationDate;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblCodedIn;
        private System.Windows.Forms.RichTextBox txtDisplaySupport;
    }
}