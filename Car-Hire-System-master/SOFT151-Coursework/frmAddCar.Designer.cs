namespace SOFT151_Coursework
{
    partial class frmAddCar
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
            this.btnCancelUpdate = new System.Windows.Forms.Button();
            this.btnSaveAndUpdate = new System.Windows.Forms.Button();
            this.txtCarMake = new System.Windows.Forms.TextBox();
            this.txtCarReg = new System.Windows.Forms.TextBox();
            this.txtCarModel = new System.Windows.Forms.TextBox();
            this.txtCarID = new System.Windows.Forms.TextBox();
            this.lblCarMake = new System.Windows.Forms.Label();
            this.lblCarModel = new System.Windows.Forms.Label();
            this.lblCarReg = new System.Windows.Forms.Label();
            this.lblCarId = new System.Windows.Forms.Label();
            this.lblCarFuelType = new System.Windows.Forms.Label();
            this.lblLastService = new System.Windows.Forms.Label();
            this.lblComments = new System.Windows.Forms.Label();
            this.txtComments = new System.Windows.Forms.RichTextBox();
            this.dtpLastServiced = new System.Windows.Forms.DateTimePicker();
            this.radDiesel = new System.Windows.Forms.RadioButton();
            this.radPetrol = new System.Windows.Forms.RadioButton();
            this.picID = new System.Windows.Forms.PictureBox();
            this.picReg = new System.Windows.Forms.PictureBox();
            this.picModel = new System.Windows.Forms.PictureBox();
            this.picManufacturer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picManufacturer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(124, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(183, 31);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Add New Car:";
            // 
            // btnCancelUpdate
            // 
            this.btnCancelUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelUpdate.Location = new System.Drawing.Point(244, 381);
            this.btnCancelUpdate.Name = "btnCancelUpdate";
            this.btnCancelUpdate.Size = new System.Drawing.Size(198, 50);
            this.btnCancelUpdate.TabIndex = 22;
            this.btnCancelUpdate.Text = "Cancel";
            this.btnCancelUpdate.UseVisualStyleBackColor = true;
            this.btnCancelUpdate.Click += new System.EventHandler(this.btnCancelUpdate_Click);
            // 
            // btnSaveAndUpdate
            // 
            this.btnSaveAndUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAndUpdate.Location = new System.Drawing.Point(12, 381);
            this.btnSaveAndUpdate.Name = "btnSaveAndUpdate";
            this.btnSaveAndUpdate.Size = new System.Drawing.Size(223, 50);
            this.btnSaveAndUpdate.TabIndex = 21;
            this.btnSaveAndUpdate.Text = "Add Car";
            this.btnSaveAndUpdate.UseVisualStyleBackColor = true;
            this.btnSaveAndUpdate.Click += new System.EventHandler(this.btnSaveAndUpdate_Click);
            // 
            // txtCarMake
            // 
            this.txtCarMake.Location = new System.Drawing.Point(158, 95);
            this.txtCarMake.Name = "txtCarMake";
            this.txtCarMake.Size = new System.Drawing.Size(249, 20);
            this.txtCarMake.TabIndex = 20;
            // 
            // txtCarReg
            // 
            this.txtCarReg.Location = new System.Drawing.Point(158, 161);
            this.txtCarReg.Name = "txtCarReg";
            this.txtCarReg.Size = new System.Drawing.Size(249, 20);
            this.txtCarReg.TabIndex = 19;
            // 
            // txtCarModel
            // 
            this.txtCarModel.Location = new System.Drawing.Point(158, 128);
            this.txtCarModel.Name = "txtCarModel";
            this.txtCarModel.Size = new System.Drawing.Size(249, 20);
            this.txtCarModel.TabIndex = 18;
            // 
            // txtCarID
            // 
            this.txtCarID.Location = new System.Drawing.Point(158, 63);
            this.txtCarID.Name = "txtCarID";
            this.txtCarID.Size = new System.Drawing.Size(249, 20);
            this.txtCarID.TabIndex = 17;
            // 
            // lblCarMake
            // 
            this.lblCarMake.AutoSize = true;
            this.lblCarMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarMake.Location = new System.Drawing.Point(15, 93);
            this.lblCarMake.Name = "lblCarMake";
            this.lblCarMake.Size = new System.Drawing.Size(137, 20);
            this.lblCarMake.TabIndex = 16;
            this.lblCarMake.Text = "Car Manufacturer:";
            // 
            // lblCarModel
            // 
            this.lblCarModel.AutoSize = true;
            this.lblCarModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarModel.Location = new System.Drawing.Point(67, 126);
            this.lblCarModel.Name = "lblCarModel";
            this.lblCarModel.Size = new System.Drawing.Size(85, 20);
            this.lblCarModel.TabIndex = 15;
            this.lblCarModel.Text = "Car Model:";
            // 
            // lblCarReg
            // 
            this.lblCarReg.AutoSize = true;
            this.lblCarReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarReg.Location = new System.Drawing.Point(24, 159);
            this.lblCarReg.Name = "lblCarReg";
            this.lblCarReg.Size = new System.Drawing.Size(128, 20);
            this.lblCarReg.TabIndex = 14;
            this.lblCarReg.Text = "Car Registration:";
            // 
            // lblCarId
            // 
            this.lblCarId.AutoSize = true;
            this.lblCarId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarId.Location = new System.Drawing.Point(93, 61);
            this.lblCarId.Name = "lblCarId";
            this.lblCarId.Size = new System.Drawing.Size(59, 20);
            this.lblCarId.TabIndex = 13;
            this.lblCarId.Text = "Car ID:";
            // 
            // lblCarFuelType
            // 
            this.lblCarFuelType.AutoSize = true;
            this.lblCarFuelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarFuelType.Location = new System.Drawing.Point(41, 191);
            this.lblCarFuelType.Name = "lblCarFuelType";
            this.lblCarFuelType.Size = new System.Drawing.Size(111, 20);
            this.lblCarFuelType.TabIndex = 24;
            this.lblCarFuelType.Text = "Car Fuel Type:";
            // 
            // lblLastService
            // 
            this.lblLastService.AutoSize = true;
            this.lblLastService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastService.Location = new System.Drawing.Point(41, 227);
            this.lblLastService.Name = "lblLastService";
            this.lblLastService.Size = new System.Drawing.Size(109, 20);
            this.lblLastService.TabIndex = 23;
            this.lblLastService.Text = "Last Serviced:";
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComments.Location = new System.Drawing.Point(60, 298);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(90, 20);
            this.lblComments.TabIndex = 27;
            this.lblComments.Text = "Comments:";
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(158, 268);
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(281, 86);
            this.txtComments.TabIndex = 28;
            this.txtComments.Text = "";
            // 
            // dtpLastServiced
            // 
            this.dtpLastServiced.Location = new System.Drawing.Point(158, 227);
            this.dtpLastServiced.Name = "dtpLastServiced";
            this.dtpLastServiced.Size = new System.Drawing.Size(281, 20);
            this.dtpLastServiced.TabIndex = 29;
            // 
            // radDiesel
            // 
            this.radDiesel.AutoSize = true;
            this.radDiesel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radDiesel.Location = new System.Drawing.Point(158, 194);
            this.radDiesel.Name = "radDiesel";
            this.radDiesel.Size = new System.Drawing.Size(54, 17);
            this.radDiesel.TabIndex = 30;
            this.radDiesel.TabStop = true;
            this.radDiesel.Text = "Diesel";
            this.radDiesel.UseVisualStyleBackColor = true;
            // 
            // radPetrol
            // 
            this.radPetrol.AutoSize = true;
            this.radPetrol.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radPetrol.Location = new System.Drawing.Point(224, 194);
            this.radPetrol.Name = "radPetrol";
            this.radPetrol.Size = new System.Drawing.Size(71, 17);
            this.radPetrol.TabIndex = 31;
            this.radPetrol.Text = "Unleaded";
            this.radPetrol.UseVisualStyleBackColor = true;
            // 
            // picID
            // 
            this.picID.Location = new System.Drawing.Point(413, 63);
            this.picID.Name = "picID";
            this.picID.Size = new System.Drawing.Size(26, 20);
            this.picID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picID.TabIndex = 32;
            this.picID.TabStop = false;
            // 
            // picReg
            // 
            this.picReg.Location = new System.Drawing.Point(413, 161);
            this.picReg.Name = "picReg";
            this.picReg.Size = new System.Drawing.Size(26, 20);
            this.picReg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picReg.TabIndex = 33;
            this.picReg.TabStop = false;
            // 
            // picModel
            // 
            this.picModel.Location = new System.Drawing.Point(413, 128);
            this.picModel.Name = "picModel";
            this.picModel.Size = new System.Drawing.Size(26, 20);
            this.picModel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picModel.TabIndex = 34;
            this.picModel.TabStop = false;
            // 
            // picManufacturer
            // 
            this.picManufacturer.Location = new System.Drawing.Point(413, 95);
            this.picManufacturer.Name = "picManufacturer";
            this.picManufacturer.Size = new System.Drawing.Size(26, 20);
            this.picManufacturer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picManufacturer.TabIndex = 35;
            this.picManufacturer.TabStop = false;
            // 
            // frmAddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 440);
            this.Controls.Add(this.picManufacturer);
            this.Controls.Add(this.picModel);
            this.Controls.Add(this.picReg);
            this.Controls.Add(this.picID);
            this.Controls.Add(this.radPetrol);
            this.Controls.Add(this.radDiesel);
            this.Controls.Add(this.dtpLastServiced);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.lblCarFuelType);
            this.Controls.Add(this.lblLastService);
            this.Controls.Add(this.btnCancelUpdate);
            this.Controls.Add(this.btnSaveAndUpdate);
            this.Controls.Add(this.txtCarMake);
            this.Controls.Add(this.txtCarReg);
            this.Controls.Add(this.txtCarModel);
            this.Controls.Add(this.txtCarID);
            this.Controls.Add(this.lblCarMake);
            this.Controls.Add(this.lblCarModel);
            this.Controls.Add(this.lblCarReg);
            this.Controls.Add(this.lblCarId);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAddCar";
            this.Text = "frmDynamicAddOrUpdateCar";
            ((System.ComponentModel.ISupportInitialize)(this.picID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picManufacturer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnCancelUpdate;
        private System.Windows.Forms.Button btnSaveAndUpdate;
        private System.Windows.Forms.TextBox txtCarMake;
        private System.Windows.Forms.TextBox txtCarReg;
        private System.Windows.Forms.TextBox txtCarModel;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.Label lblCarMake;
        private System.Windows.Forms.Label lblCarModel;
        private System.Windows.Forms.Label lblCarReg;
        private System.Windows.Forms.Label lblCarId;
        private System.Windows.Forms.Label lblCarFuelType;
        private System.Windows.Forms.Label lblLastService;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.RichTextBox txtComments;
        private System.Windows.Forms.DateTimePicker dtpLastServiced;
        private System.Windows.Forms.RadioButton radDiesel;
        private System.Windows.Forms.RadioButton radPetrol;
        private System.Windows.Forms.PictureBox picID;
        private System.Windows.Forms.PictureBox picReg;
        private System.Windows.Forms.PictureBox picModel;
        private System.Windows.Forms.PictureBox picManufacturer;
    }
}