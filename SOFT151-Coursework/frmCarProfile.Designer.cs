namespace SOFT151_Coursework
{
    partial class frmCarProfile
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
            this.lblCarId = new System.Windows.Forms.Label();
            this.lblCarMake = new System.Windows.Forms.Label();
            this.lblCarModel = new System.Windows.Forms.Label();
            this.lblCarReg = new System.Windows.Forms.Label();
            this.lblLastServiced = new System.Windows.Forms.Label();
            this.lblCarFuelType = new System.Windows.Forms.Label();
            this.txtComments = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCarId
            // 
            this.lblCarId.AutoSize = true;
            this.lblCarId.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarId.Location = new System.Drawing.Point(12, 9);
            this.lblCarId.Name = "lblCarId";
            this.lblCarId.Size = new System.Drawing.Size(101, 31);
            this.lblCarId.TabIndex = 0;
            this.lblCarId.Text = "Car ID:";
            // 
            // lblCarMake
            // 
            this.lblCarMake.AutoSize = true;
            this.lblCarMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarMake.Location = new System.Drawing.Point(14, 72);
            this.lblCarMake.Name = "lblCarMake";
            this.lblCarMake.Size = new System.Drawing.Size(137, 20);
            this.lblCarMake.TabIndex = 1;
            this.lblCarMake.Text = "Car Manufacturer:";
            // 
            // lblCarModel
            // 
            this.lblCarModel.AutoSize = true;
            this.lblCarModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarModel.Location = new System.Drawing.Point(14, 112);
            this.lblCarModel.Name = "lblCarModel";
            this.lblCarModel.Size = new System.Drawing.Size(85, 20);
            this.lblCarModel.TabIndex = 2;
            this.lblCarModel.Text = "Car Model:";
            // 
            // lblCarReg
            // 
            this.lblCarReg.AutoSize = true;
            this.lblCarReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarReg.Location = new System.Drawing.Point(14, 154);
            this.lblCarReg.Name = "lblCarReg";
            this.lblCarReg.Size = new System.Drawing.Size(72, 20);
            this.lblCarReg.TabIndex = 3;
            this.lblCarReg.Text = "Car Reg:";
            // 
            // lblLastServiced
            // 
            this.lblLastServiced.AutoSize = true;
            this.lblLastServiced.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastServiced.Location = new System.Drawing.Point(14, 243);
            this.lblLastServiced.Name = "lblLastServiced";
            this.lblLastServiced.Size = new System.Drawing.Size(148, 20);
            this.lblLastServiced.TabIndex = 5;
            this.lblLastServiced.Text = "Date Last Serviced:";
            // 
            // lblCarFuelType
            // 
            this.lblCarFuelType.AutoSize = true;
            this.lblCarFuelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarFuelType.Location = new System.Drawing.Point(14, 198);
            this.lblCarFuelType.Name = "lblCarFuelType";
            this.lblCarFuelType.Size = new System.Drawing.Size(82, 20);
            this.lblCarFuelType.TabIndex = 4;
            this.lblCarFuelType.Text = "Fuel Type:";
            // 
            // txtComments
            // 
            this.txtComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComments.Location = new System.Drawing.Point(12, 316);
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(367, 144);
            this.txtComments.TabIndex = 7;
            this.txtComments.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(138, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Comments:";
            // 
            // frmCarProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 471);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.lblLastServiced);
            this.Controls.Add(this.lblCarFuelType);
            this.Controls.Add(this.lblCarReg);
            this.Controls.Add(this.lblCarModel);
            this.Controls.Add(this.lblCarMake);
            this.Controls.Add(this.lblCarId);
            this.Name = "frmCarProfile";
            this.Text = "frmCarProfile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarId;
        private System.Windows.Forms.Label lblCarMake;
        private System.Windows.Forms.Label lblCarModel;
        private System.Windows.Forms.Label lblCarReg;
        private System.Windows.Forms.Label lblLastServiced;
        private System.Windows.Forms.Label lblCarFuelType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtComments;
    }
}