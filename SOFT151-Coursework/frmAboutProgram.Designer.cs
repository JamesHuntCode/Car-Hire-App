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
            this.lblCommits = new System.Windows.Forms.Label();
            this.lblCodedIn = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(63, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(208, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "About This Program:";
            // 
            // lblCreationDate
            // 
            this.lblCreationDate.AutoSize = true;
            this.lblCreationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreationDate.Location = new System.Drawing.Point(12, 60);
            this.lblCreationDate.Name = "lblCreationDate";
            this.lblCreationDate.Size = new System.Drawing.Size(126, 20);
            this.lblCreationDate.TabIndex = 1;
            this.lblCreationDate.Text = "Created in: 2017";
            // 
            // lblCommits
            // 
            this.lblCommits.AutoSize = true;
            this.lblCommits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommits.Location = new System.Drawing.Point(12, 98);
            this.lblCommits.Name = "lblCommits";
            this.lblCommits.Size = new System.Drawing.Size(213, 20);
            this.lblCommits.TabIndex = 2;
            this.lblCommits.Text = "GitHub Commits To Date: 40";
            // 
            // lblCodedIn
            // 
            this.lblCodedIn.AutoSize = true;
            this.lblCodedIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodedIn.Location = new System.Drawing.Point(12, 135);
            this.lblCodedIn.Name = "lblCodedIn";
            this.lblCodedIn.Size = new System.Drawing.Size(139, 20);
            this.lblCodedIn.TabIndex = 3;
            this.lblCodedIn.Text = "Progammed in: C#";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 4;
            // 
            // frmAboutProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 174);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCodedIn);
            this.Controls.Add(this.lblCommits);
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
        private System.Windows.Forms.Label lblCommits;
        private System.Windows.Forms.Label lblCodedIn;
        private System.Windows.Forms.Label label5;
    }
}