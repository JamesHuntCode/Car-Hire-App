namespace SOFT151_Coursework
{
    partial class frmDynamicAddOrUpdateCar
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
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(292, 31);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Add or Update Header:";
            // 
            // btnCancelUpdate
            // 
            this.btnCancelUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelUpdate.Location = new System.Drawing.Point(218, 394);
            this.btnCancelUpdate.Name = "btnCancelUpdate";
            this.btnCancelUpdate.Size = new System.Drawing.Size(188, 74);
            this.btnCancelUpdate.TabIndex = 22;
            this.btnCancelUpdate.Text = "Cancel Update";
            this.btnCancelUpdate.UseVisualStyleBackColor = true;
            this.btnCancelUpdate.Click += new System.EventHandler(this.btnCancelUpdate_Click);
            // 
            // btnSaveAndUpdate
            // 
            this.btnSaveAndUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAndUpdate.Location = new System.Drawing.Point(12, 394);
            this.btnSaveAndUpdate.Name = "btnSaveAndUpdate";
            this.btnSaveAndUpdate.Size = new System.Drawing.Size(188, 74);
            this.btnSaveAndUpdate.TabIndex = 21;
            this.btnSaveAndUpdate.Text = "Save and Update";
            this.btnSaveAndUpdate.UseVisualStyleBackColor = true;
            this.btnSaveAndUpdate.Click += new System.EventHandler(this.btnSaveAndUpdate_Click);
            // 
            // txtCarMake
            // 
            this.txtCarMake.Location = new System.Drawing.Point(185, 108);
            this.txtCarMake.Name = "txtCarMake";
            this.txtCarMake.Size = new System.Drawing.Size(221, 20);
            this.txtCarMake.TabIndex = 20;
            // 
            // txtCarReg
            // 
            this.txtCarReg.Location = new System.Drawing.Point(185, 174);
            this.txtCarReg.Name = "txtCarReg";
            this.txtCarReg.Size = new System.Drawing.Size(221, 20);
            this.txtCarReg.TabIndex = 19;
            // 
            // txtCarModel
            // 
            this.txtCarModel.Location = new System.Drawing.Point(185, 141);
            this.txtCarModel.Name = "txtCarModel";
            this.txtCarModel.Size = new System.Drawing.Size(221, 20);
            this.txtCarModel.TabIndex = 18;
            // 
            // txtCarID
            // 
            this.txtCarID.Location = new System.Drawing.Point(185, 76);
            this.txtCarID.Name = "txtCarID";
            this.txtCarID.Size = new System.Drawing.Size(221, 20);
            this.txtCarID.TabIndex = 17;
            // 
            // lblCarMake
            // 
            this.lblCarMake.AutoSize = true;
            this.lblCarMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarMake.Location = new System.Drawing.Point(14, 106);
            this.lblCarMake.Name = "lblCarMake";
            this.lblCarMake.Size = new System.Drawing.Size(137, 20);
            this.lblCarMake.TabIndex = 16;
            this.lblCarMake.Text = "Car Manufacturer:";
            // 
            // lblCarModel
            // 
            this.lblCarModel.AutoSize = true;
            this.lblCarModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarModel.Location = new System.Drawing.Point(14, 139);
            this.lblCarModel.Name = "lblCarModel";
            this.lblCarModel.Size = new System.Drawing.Size(85, 20);
            this.lblCarModel.TabIndex = 15;
            this.lblCarModel.Text = "Car Model:";
            // 
            // lblCarReg
            // 
            this.lblCarReg.AutoSize = true;
            this.lblCarReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarReg.Location = new System.Drawing.Point(14, 172);
            this.lblCarReg.Name = "lblCarReg";
            this.lblCarReg.Size = new System.Drawing.Size(128, 20);
            this.lblCarReg.TabIndex = 14;
            this.lblCarReg.Text = "Car Registration:";
            // 
            // lblCarId
            // 
            this.lblCarId.AutoSize = true;
            this.lblCarId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarId.Location = new System.Drawing.Point(14, 74);
            this.lblCarId.Name = "lblCarId";
            this.lblCarId.Size = new System.Drawing.Size(59, 20);
            this.lblCarId.TabIndex = 13;
            this.lblCarId.Text = "Car ID:";
            // 
            // lblCarFuelType
            // 
            this.lblCarFuelType.AutoSize = true;
            this.lblCarFuelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarFuelType.Location = new System.Drawing.Point(14, 207);
            this.lblCarFuelType.Name = "lblCarFuelType";
            this.lblCarFuelType.Size = new System.Drawing.Size(111, 20);
            this.lblCarFuelType.TabIndex = 24;
            this.lblCarFuelType.Text = "Car Fuel Type:";
            // 
            // lblLastService
            // 
            this.lblLastService.AutoSize = true;
            this.lblLastService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastService.Location = new System.Drawing.Point(14, 240);
            this.lblLastService.Name = "lblLastService";
            this.lblLastService.Size = new System.Drawing.Size(138, 20);
            this.lblLastService.TabIndex = 23;
            this.lblLastService.Text = "Car Last Serviced:";
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComments.Location = new System.Drawing.Point(14, 316);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(90, 20);
            this.lblComments.TabIndex = 27;
            this.lblComments.Text = "Comments:";
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(186, 281);
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(221, 86);
            this.txtComments.TabIndex = 28;
            this.txtComments.Text = "";
            // 
            // dtpLastServiced
            // 
            this.dtpLastServiced.Location = new System.Drawing.Point(186, 240);
            this.dtpLastServiced.Name = "dtpLastServiced";
            this.dtpLastServiced.Size = new System.Drawing.Size(220, 20);
            this.dtpLastServiced.TabIndex = 29;
            // 
            // radDiesel
            // 
            this.radDiesel.AutoSize = true;
            this.radDiesel.ForeColor = System.Drawing.Color.Orange;
            this.radDiesel.Location = new System.Drawing.Point(185, 207);
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
            this.radPetrol.ForeColor = System.Drawing.Color.Orange;
            this.radPetrol.Location = new System.Drawing.Point(245, 207);
            this.radPetrol.Name = "radPetrol";
            this.radPetrol.Size = new System.Drawing.Size(71, 17);
            this.radPetrol.TabIndex = 31;
            this.radPetrol.Text = "Unleaded";
            this.radPetrol.UseVisualStyleBackColor = true;
            // 
            // frmDynamicAddOrUpdateCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 480);
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
            this.Name = "frmDynamicAddOrUpdateCar";
            this.Text = "frmDynamicAddOrUpdateCar";
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
    }
}