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
        private List<Car> carSearchResults = new List<Car>();

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

            currentCompany = company;

            // Display all of the companies cars:

            for (int i = 0; i < this.currentCompany.GetAllCars().Count; i++)
            {
                this.lstListCompanyCars.Items.Add(this.currentCompany.GetAllCars()[i].PrintSummary());
            }


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

        private int locateCorrectTarget(string checkFor, List<Car> list) // Method used to locate the correct car in the list of this compay's cars
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (checkFor == list[i].PrintSummary())
                {
                    return i; // Return the matched index
                }
            }

            return 0;
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
                this.updateList(this.currentCompany.GetAllCars());

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
            string carSummary = "";

            // Make sure the user has selected a company to update:

            if (this.lstListCompanyCars.SelectedIndex == -1) // User has not selected a company
            {
                MessageBox.Show("Make sure you select a car to edit."); // Alert the user
            }
            else
            {
                carSummary = this.lstListCompanyCars.Items[this.lstListCompanyCars.SelectedIndex].ToString();

                int matchedIndex = this.locateCorrectTarget(carSummary, this.currentCompany.GetAllCars());

                // Generate a new dynamic form allowing the user to add a new car:

                frmDynamicAddOrUpdateCar popup = new frmDynamicAddOrUpdateCar("Update Car Information", currentCompany.GetAllCars()[matchedIndex]);
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

                mainForm.CreateNotification("car", "update", Convert.ToString(oldCar.GetId()), DateTime.Now.ToShortTimeString(), currentCompany.GetName());
            }
            else
            {
                MessageBox.Show("It looks like you already have a car with that ID stored!"); // Alert the user that they may have a duplicate entry 
            }
        }

        private void btnDeleteCar_Click(object sender, EventArgs e) // User wants to remove a car from the company's records
        {
            string carSummary = "";

            // Make sure the user has selected a car to remove:

            if (this.lstListCompanyCars.SelectedIndex == -1) // User has not selected a car
            {
                MessageBox.Show("Make sure you select a car to remove."); // Alert the user
            }
            else
            {
                carSummary = this.lstListCompanyCars.Items[this.lstListCompanyCars.SelectedIndex].ToString();

                int matchedIndex = this.locateCorrectTarget(carSummary, this.currentCompany.GetAllCars());

                // Push notification to the user's recent activity:

                mainForm = (frmMain)this.Owner;

                this.mainForm.CreateNotification("car", "remove", Convert.ToString(this.currentCompany.GetAllCars()[matchedIndex].GetId()), DateTime.Now.ToShortTimeString(), currentCompany.GetName());

                // Proceed with deletion of selected company:

                this.currentCompany.removeCar(this.currentCompany.GetAllCars()[matchedIndex]);

                //Display the updated company information:

                this.lstListCompanyCars.Items.Clear();
                updateList(this.currentCompany.GetAllCars());
            }
        }

        private void btnViewCarInfo_Click(object sender, EventArgs e) // User wants to see a car's full information breakdown
        {
            string carSummary = "";

            // Make sure the user has selected a car to remove:

            if (this.lstListCompanyCars.SelectedIndex == -1) // User has not selected a car
            {
                MessageBox.Show("Make sure you select a car to view."); // Alert the user
            }
            else
            {
                carSummary = this.lstListCompanyCars.Items[this.lstListCompanyCars.SelectedIndex].ToString();

                int matchedIndex = this.locateCorrectTarget(carSummary, this.currentCompany.GetAllCars());
                
                // Generate form allowing the user to view the selected car's full profile:

                frmCarProfile popup = new frmCarProfile(this.currentCompany.GetAllCars()[matchedIndex]);
                popup.ShowDialog(this);

                // Push notification to the user's recent activity:

                mainForm = (frmMain)this.Owner;

                mainForm.CreateNotification("car", "view-info", currentCompany.GetName(), DateTime.Now.ToShortTimeString());
            }
        }

        private void searchCar(string userInput, List<Car> list, ListBox lstBox) // Method used to search through the company's list of cars and display a result (if present)
        {
            this.carSearchResults.Clear();

            bool match = false;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].GetMake().ToUpper() == userInput.ToUpper() || Convert.ToString(list[i].GetId()) == userInput || list[i].GetModel().ToUpper() == userInput.ToUpper())
                {
                    match = true;

                    this.carSearchResults.Add(list[i]);
                }
            }

            if (!match) // Dispay no results message (there has not been a match)
            {
                lstBox.Items.Clear();

                lstBox.Items.Add("Oops! No cars found! Click refresh and try again.");
            }
            else
            {
                lstBox.Items.Clear();

                for (int j = 0; j < this.carSearchResults.Count; j++)
                {
                    lstBox.Items.Add(this.carSearchResults[j].PrintSummary());
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e) // User wants to search through company's car record
        {
            string userInput = "";

            try
            {
                userInput = this.txtSearchCars.Text;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            if (userInput == "") // Validate user input
            {
                MessageBox.Show("Make sure to type in what you want to search for.");
            }
            else
            {
                this.searchCar(userInput, this.currentCompany.GetAllCars(), this.lstListCompanyCars); // Search for a matching element

                // Push notification to the user's recent activity: 

                mainForm = (frmMain)this.Owner;

                mainForm.CreateNotification("car", "search", userInput, DateTime.Now.ToShortTimeString(), this.currentCompany.GetName());
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e) // User wants to bring back up the whole list of cars
        {
            this.lstListCompanyCars.Items.Clear();
            this.carSearchResults.Clear();

            for (int i = 0; i < this.currentCompany.GetAllCars().Count; i++)
            {
                this.lstListCompanyCars.Items.Add(this.currentCompany.GetAllCars()[i].PrintSummary());
            }
        }
    }
}
