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
        private Car currentCar;
        public frmDynamicAddOrUpdateCar(string formName, Car car = null)
        {
            InitializeComponent();

            //  Update form information:

            this.Text = formName;
            this.lblHeader.Text = formName;
            this.dtpLastServiced.MaxDate = DateTime.Today; // Limit max date to today

            currentCar = car;

            // Load pre-loaded information if the user wants to edit:
            if (formName == "Update Car Information") // Load in current car's information
            {
                this.txtCarID.Text = Convert.ToString(car.GetId());
                this.txtCarMake.Text = car.GetMake();
                this.txtCarModel.Text = car.GetModel();
                this.txtCarReg.Text = car.GetReg();
                if (car.GetFuelType().ToUpper() == "UNLEADED")
                {
                    this.radPetrol.Select();
                }
                else if (car.GetFuelType().ToUpper() == "DIESEL")
                {
                    this.radDiesel.Select();
                }
                this.dtpLastServiced.Value = DateTime.Today; 
                this.txtComments.Text = car.GetComments();
            }

            // Apply color change:
            this.colorForm();
        }

        // Method used to apply correct color scheme to form
        private void colorForm()
        {
            // #EAEAEA = Light Grey
            // #333 = Graphite
            // #ffffff = White
            // #31708E = Light Blue

            this.BackColor = ColorTranslator.FromHtml("#EAEAEA");
            foreach (Label l in Controls.OfType<Label>())
            {
                l.ForeColor = ColorTranslator.FromHtml("#333");
            }

            foreach (Button b in Controls.OfType<Button>())
            {
                b.ForeColor = ColorTranslator.FromHtml("#ffffff");
                b.BackColor = ColorTranslator.FromHtml("#31708E");
            }

            foreach (RadioButton r in Controls.OfType<RadioButton>())
            {
                r.ForeColor = ColorTranslator.FromHtml("#333");
            }
        }

        // Button Controls:

        private void btnSaveAndUpdate_Click(object sender, EventArgs e)
        {
            frmMain mainForm = (frmMain)this.Owner;

            // Gather user inputs and catch any exceptions:
            int newCarId = 0;
            string newCarMake = "";
            string newCarModel = "";
            string newCarReg = "";
            string newCarFuelType = "";
            DateTime newDateLastServiced = new DateTime();
            string newComments = "";

            bool isValid = true;

            try
            {
                newCarId = Convert.ToInt32(this.txtCarID.Text);
                newCarMake = this.txtCarMake.Text;
                newCarModel = this.txtCarModel.Text;
                newCarReg = this.txtCarReg.Text;
                if (this.radPetrol.Checked)
                {
                    newCarFuelType = "petrol";
                }
                else if (this.radDiesel.Checked)
                {
                    newCarFuelType = "diesel";
                }
                newDateLastServiced = this.dtpLastServiced.Value;
                newComments = this.txtComments.Text;
            }
            catch (Exception err)
            {
                isValid = false;
                
                MessageBox.Show(err.Message);
            }

            if (isValid)
            {

                if (this.Text == "Add New Car") // Add new company 
                {
                    bool added = mainForm.AddNewCar(new Car(newCarId, newCarMake, newCarModel, newCarReg, newCarFuelType, newDateLastServiced, newComments));

                    if (added)
                    {
                        this.Close(); // Close the form after adding new car details
                    }
                }
                else if (this.Text == "Update Car Information") // Edit previous company 
                {
                    bool updated = mainForm.UpdateCar(currentCar, newCarId, newCarMake, newCarModel, newCarReg, newCarFuelType, newDateLastServiced, newComments);

                    if (updated)
                    {
                        this.Close(); // Close the form after updating car details
                    }
                }
            }
        }

        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form and cancel all actions
        }
    }
}
