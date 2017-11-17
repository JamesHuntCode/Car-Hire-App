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
    public partial class frmCompanyProfile : Form
    {
        private Company currentCompany;

        private frmMain mainForm;

        public frmCompanyProfile(Company company)
        {
            InitializeComponent();

            // Display correct compay details in the form:

            this.Text = company.GetName() + " Full Profile.";
            this.lblCompanyName.Text = "Name: " + company.GetName();
            this.lblCompanyId.Text = "ID: " + Convert.ToString(company.GetId());
            this.lblCompanyAddress.Text = "Address: " + company.GetAddress();
            this.lblCarCount.Text = "Cars rented: " + Convert.ToString(company.GetNumberOfCars());
            this.lblCompanyPostcode.Text = "Postcode: " + company.GetPostcode();

            // Display all of the companies cars:

            List<Car> companyCars = company.GetAllCars();

            for (int i = 0; i < companyCars.Count; i++)
            {
                this.lstListCompanyCars.Items.Add(companyCars[i].PrintSummary());
            }

            currentCompany = company;

            // Set up the color layout of the form:

            Color myBG = ColorTranslator.FromHtml("#333");

            this.BackColor = myBG;

            foreach (Label l in Controls.OfType<Label>())
            {
                l.ForeColor = Color.Orange;
            }
        }

        private void updateList(List<Car> list) // Method used to loop over the contents of the companies list and display all contents
        {
            for (int i = 0; i < list.Count; i++)
            {
                this.lstListCompanyCars.Items.Add(list[i].PrintSummary());
            }
        }

        // User is interacting with the buttons on the form:

        private void btnAddNewCar_Click(object sender, EventArgs e) // User wants to add a new car to the company's records
        {
            // Generate a new dynamic form allowing the user to add a new car:

            frmDynamicAddOrUpdateCar popup = new frmDynamicAddOrUpdateCar("Add New Car");
            popup.ShowDialog(this);
        }

        public void AddNew(Car car)
        {
            // Check to see if a car with the same ID already exists:

            bool match = false;

            for (int i = 0; i < this.currentCompany.GetAllCars().Count; i++)
            {
                if (this.currentCompany.GetAllCars()[i].GetId() == car.GetId())
                {
                    match = true;
                }
            }

            if (!match) // There is not a match - safe to proceed with upload of new car
            {
                this.currentCompany.AddNewCar(car); // Add the new car to the company's list of cars

                // Re-display the updated contents of the company's car list:

                this.lstListCompanyCars.Items.Clear();
                updateList(this.currentCompany.GetAllCars());

                // Push notification to the user's recent activity:

                mainForm = (frmMain)this.Owner;

                mainForm.CreateNotification("car", "add", currentCompany.GetName(), DateTime.Now.ToShortTimeString());
            }
            else
            {
                MessageBox.Show("It looks like you already have a car with that ID stored!"); // Alert the user that they may have a duplicate entry 
            }
        }

        private void btnUpdateCar_Click(object sender, EventArgs e) // User wants to update a car's details
        { 
            // Make sure the user has selected a company to update:

            if (this.lstListCompanyCars.SelectedIndex == -1) // User has not selected a company
            {
                MessageBox.Show("Make sure you select a car to edit."); // Alert the user
            }
            else
            {
                // Generate a new dynamic form allowing the user to add a new car:
                
                frmDynamicAddOrUpdateCar popup = new frmDynamicAddOrUpdateCar("Update Car Information", currentCompany.GetAllCars()[this.lstListCompanyCars.SelectedIndex]);
                popup.ShowDialog(this);
            }
        }

        public void UpdateCar(Car oldCar, int newCarId, string newCarMake, string newCarModel, string newCarReg, string newFuelType, DateTime newLastServiced, string newComments)
        {
            // Check to see if a car with the same ID already exists:

            bool match = false;

            for (int i = 0; i < this.currentCompany.GetAllCars().Count; i++)
            {
                if (this.currentCompany.GetAllCars()[i].GetId() == newCarId && newCarId != oldCar.GetId())
                {
                    match = true;
                }
            }

            if (!match) // There is not a match - safe to proceed with upload of new car information
            {
                // Update old records:

                oldCar.SetId(newCarId);
                oldCar.SetMake(newCarMake);
                oldCar.SetModel(newCarModel);
                oldCar.SetRegistration(newCarReg);
                oldCar.SetFuelType(newFuelType);
                oldCar.SetDateLastServiced(newLastServiced);
                oldCar.SetComments(newComments);

                //Display the updated company information:

                this.lstListCompanyCars.Items.Clear();
                updateList(this.currentCompany.GetAllCars());

                // Push notification to the user's recent activity:

                mainForm = (frmMain)this.Owner;

                mainForm.CreateNotification("car", "update", currentCompany.GetName(), DateTime.Now.ToShortTimeString());
            }
            else
            {
                MessageBox.Show("It looks like you already have a car with that ID stored!"); // Alert the user that they may have a duplicate entry 
            }
        }

        private void btnDeleteCar_Click(object sender, EventArgs e) // User wants to remove a car from the company's records
        {
            // Make sure the user has selected a car to remove:

            if (this.lstListCompanyCars.SelectedIndex == -1) // User has not selected a car
            {
                MessageBox.Show("Make sure you select a car to remove."); // Alert the user
            }
            else
            {
                // Push notification to the user's recent activity:

                mainForm = (frmMain)this.Owner;

                this.mainForm.CreateNotification("car", "remove", this.currentCompany.GetName(), DateTime.Now.ToShortTimeString());

                // Proceed with deletion of selected company:

                this.currentCompany.removeCar(this.currentCompany.GetAllCars()[this.lstListCompanyCars.SelectedIndex]);

                //Display the updated company information:

                this.lstListCompanyCars.Items.Clear();
                updateList(this.currentCompany.GetAllCars());
            }
        }

        private void btnViewCarInfo_Click(object sender, EventArgs e) // User wants to see a car's full information breakdown
        {
            // Make sure the user has selected a car to remove:

            if (this.lstListCompanyCars.SelectedIndex == -1) // User has not selected a car
            {
                MessageBox.Show("Make sure you select a car to view."); // Alert the user
            }
            else
            {
                // Generate form allowing the user to view the selected car's full profile:

                frmCarProfile popup = new frmCarProfile(this.currentCompany.GetAllCars()[this.lstListCompanyCars.SelectedIndex]);
                popup.ShowDialog(this);

                // Push notification to the user's recent activity:

                mainForm = (frmMain)this.Owner;

                mainForm.CreateNotification("car", "view-info", currentCompany.GetName(), DateTime.Now.ToShortTimeString());
            }
        }
    }
}
