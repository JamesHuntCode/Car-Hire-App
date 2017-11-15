using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOFT151_Coursework
{
    public partial class frmDynamicAddOrUpdateCar : Form
    {
        Car currentCar;
        public frmDynamicAddOrUpdateCar(string formName, Car car = null)
        {
            InitializeComponent();

            //  Update form information:

            this.Text = formName;
            this.lblHeader.Text = formName;

            currentCar = car;

            // Load pre-loaded information if the user wants to edit:

            if (formName == "Update Car Information") // Load in current company's information
            {
                this.txtCarID.Text = Convert.ToString(car.GetId());
                this.txtCarMake.Text = car.GetMake();
                this.txtCarModel.Text = car.GetModel();
                this.txtCarReg.Text = car.GetReg();
                this.txtCarFuelType.Text = car.GetFuelType();
                //this.dtpLastServiced.Value = 
                this.txtComments.Text = car.GetComments();
            }
        }

        // Button Controls:

        private void btnSaveAndUpdate_Click(object sender, EventArgs e)
        {
            frmCompanyProfile frmViewCompanyInfo = (frmCompanyProfile)this.Owner; // Set company summary form as parent form

            // Gather user inputs and catch any exceptions:

            int newCarId = 0;
            string newCarMake = "";
            string newCarModel = "";
            string newCarReg = "";
            string newCarFuelType = "";
            //newDateLastServiced = new DateTime();
            string newComments = "";

            try
            {
                newCarId = Convert.ToInt32(this.txtCarID.Text);
                newCarMake = this.txtCarMake.Text;
                newCarModel = this.txtCarModel.Text;
                newCarReg = this.txtCarReg.Text;
                newCarFuelType = this.txtCarFuelType.Text;
                newDateLastServiced = this.dtpLastServiced.Value.Date;
                newComments = this.txtComments.Text;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message); // Display error message to the user

                this.Close(); // Close form to stop uploading incomplete information
            }

            if (this.Text == "Add New Car") // Add new company 
            {
                frmViewCompanyInfo.AddNew(new Car(newCarId, newCarMake, newCarModel, newCarReg, newCarFuelType, newDateLastServiced, newComments));

                this.Close(); // Close the form after adding new car details
            }
            else if (this.Text == "Update Car Information") // Edit previous company 
            {
                frmViewCompanyInfo.UpdateCar(currentCar, newCarId, newCarMake, newCarModel, newCarReg, newCarFuelType, newDateLastServiced, newComments);

                this.Close(); // Close the form after updating car details
            }
        }

        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form and cancel all actions
        }
    }
}
