using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SOFT151_Coursework
{
    public partial class frmMain : Form
    {
        #region set up arrays / classes required

        private List<Company> companies = new List<Company>(); 

        private List<string> notifications = new List<string>(); 

        private List<Company> companySearchResults = new List<Company>(); 

        private List<string> recentActivitySearchResults = new List<string>();

        private List<Car> carSearchResults = new List<Car>(); 

        private Company currentSelectedCompany;
        private Car currentSelectedCar;

        private string defaultFile = Environment.CurrentDirectory + @"\exampleFile.txt";

        private bool carEditingMode = false;
        private bool companyEditingMode = false;

        FileServices myServices = new FileServices();

        #endregion

        #region frmLoading methods

        public frmMain()
        {
            InitializeComponent();
            this.FormClosing += this.frmMain_FormClosing;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Read initial data into program
            this.readFile(this.defaultFile);

            // Prepare program for load
            this.initiateProgram();
        }

        #endregion

        #region code dealing with reading from / writing to files

        // Method used to load user file into program
        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            bool isValid = myServices.checkFile(Environment.CurrentDirectory + @"\" + this.txtInputFileName.Text, "read");
            bool hasRead = false;

            if (isValid)
            {
                this.companies.Clear();
                hasRead = myServices.readFile(Environment.CurrentDirectory + @"\" + this.txtInputFileName.Text, this.companies);
            }
            
            if (hasRead)
            {
                this.updateCompaniesList(this.companies);

                // Check items are present to select:
                if (this.lstAllCompanies.Items.Count > 0)
                {
                    this.setSelectedFields();
                }

                this.notifications.Clear();
                this.UpdateNotifications(this.notifications);
            }
        }

        // Method used to read from file
        private void readFile(string filePath)
        {
            bool isValid = myServices.checkFile(filePath, "read");

            if (isValid)
            {
                myServices.readFile(filePath, this.companies);
                this.updateCompaniesList(companies);
            } 
        }

        // Method used to write to files
        private bool writeFile(string filePath)
        {
            bool isValid = myServices.checkFile(filePath, "write");

            if (isValid)
            {
                myServices.writeFile(filePath, this.companies);
            }
            return false;
        }

        // Method to save user work (when clicked)
        private void btnSaveWork_Click(object sender, EventArgs e)
        {
            string filePath = Environment.CurrentDirectory + @"\" + this.txtInputFileName.Text;
            bool hasSaved = myServices.writeFile(filePath, this.companies);
            
            if (hasSaved)
            {
                this.CreateNotification("self-saved", "save", this.txtInputFileName.Text, DateTime.Now.ToShortTimeString());
                this.lblLastSaved.Text = "Last Saved: " + DateTime.Now.ToShortTimeString();
            }
        }

        // Method used to check data has been saved (prompt user if not)
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Autosave work if error becomes present
            if (e.CloseReason == CloseReason.WindowsShutDown)
            {
                this.autoSave();
            }

            if (e.CloseReason == CloseReason.TaskManagerClosing)
            {
                this.autoSave();
            }
        }

        // Method used to autosave user data (called every 5 minutes)
        private void autoSave()
        {
            bool hasSaved = myServices.writeFile(Environment.CurrentDirectory + @"\" + this.txtInputFileName.Text, this.companies);

            if (hasSaved)
            {
                this.CreateNotification("auto-saved", "save", "exampleFile.txt", DateTime.Now.ToShortTimeString());
            }
        }

        #endregion

        #region code dealing with the companies

        // BUTTON CLICKS:

        // Search for a specific company 
        private void btnSearchCompanies_Click(object sender, EventArgs e)
        {
            string userInput = "";

            try
            {
                userInput = this.txtSearchCompanies.Text;
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
                this.searchCompanies(userInput, this.companies, this.lstAllCompanies);

                this.CreateNotification("company", "search", userInput, DateTime.Now.ToShortTimeString());

                this.nullAllFields();
            }
        }

        // Refresh the list of companies after a search
        private void btnRefreshCompanies_Click(object sender, EventArgs e)
        {
            this.lstAllCompanies.Items.Clear();
            this.companySearchResults.Clear();
            this.txtSearchCompanies.Text = "";

            this.nullAllFields();

            for (int i = 0; i < this.companies.Count; i++)
            {
                this.lstAllCompanies.Items.Add(this.companies[i].PrintSummary());
            }
        }

        // Add a new company 
        private void btnAddNewCompany_Click(object sender, EventArgs e)
        {
            // Generate a new dynamic form allowing the user to add a new company:
            frmAddCompany popup = new frmAddCompany();
            popup.ShowDialog(this);
        }

        // Update an existing company 
        private void btnUpdateCompany_Click(object sender, EventArgs e)
        {
            this.companyEditingMode = true;
        }

        // Save changes made to company
        private void btnSaveCompanyChanges_Click(object sender, EventArgs e)
        {
            // Set company to update
            string companySummary = "";

            // Gather user inputs and catch any exceptions thrown:
            int newCompanyId = 0;
            string newCompanyName = "";
            string newCompanyAddress = "";
            string newCompanyPostcode = "";

            bool isValid = true;

            try
            {
                newCompanyId = Convert.ToInt32(this.txtCompID.Text);
                newCompanyName = this.txtCompName.Text;
                newCompanyAddress = this.txtCompAddress.Text;
                newCompanyPostcode = this.txtCompPostcode.Text;
            }
            catch (Exception err)
            {
                MessageBox.Show("Error Detected! Error: " + err.Message + "\nSorry for any inconvenience caused.");
                isValid = false;
            }

            if (isValid)
            {
                companySummary = this.lstAllCompanies.Items[this.lstAllCompanies.SelectedIndex].ToString();
                int matchedIndex = this.locateCorrectCompany(companySummary, this.companies);

                bool updated = this.UpdateCompany(this.companies[matchedIndex], newCompanyId, newCompanyName, newCompanyAddress, newCompanyPostcode);

                if (updated)
                {
                    this.companyEditingMode = false;
                }
            }
        }

        // Cancel changes made to company
        private void btnCancelCompanyUpdate_Click(object sender, EventArgs e)
        {
            this.reDisplayOldCompanyData();
            this.companyEditingMode = false;
        }

        // Display old data when user cancels update
        private void reDisplayOldCompanyData()
        {
            int oldRecord = this.locateCorrectCompany(this.lstAllCompanies.Items[this.lstAllCompanies.SelectedIndex].ToString(), this.companies);
            this.displayCompanyInformation(this.companies[oldRecord].GetId(), this.companies[oldRecord].GetName(), this.companies[oldRecord].GetAddress(), this.companies[oldRecord].GetPostcode(), this.companies[oldRecord].GetNumberOfCars());
        }

        // Remove an existing company 
        private void btnRemoveCompany_Click(object sender, EventArgs e)
        {
            if (this.lstAllCompanies.Items[0].ToString() != "No companies have been found!")
            {
                string companySummary = "";

                // Make sure the user has selected a company to remove:
                if (this.lstAllCompanies.SelectedIndex == -1) // User has not selected a company
                {
                    MessageBox.Show("Make sure you select a company to remove."); // Alert the user
                }
                else
                {
                    companySummary = this.lstAllCompanies.Items[this.lstAllCompanies.SelectedIndex].ToString();

                    int matchedIndex = this.locateCorrectCompany(companySummary, this.companies);

                    this.nullAllFields();

                    this.CreateNotification("company", "remove", companies[matchedIndex].GetName(), DateTime.Now.ToShortTimeString());

                    this.companies.Remove(companies[matchedIndex]);

                    //Display the updated company information:
                    this.lstAllCompanies.Items.Clear();
                    this.updateCompaniesList(companies);
                }
            }
        }

        // METHODS:

        // Method to display the currently selected company summary
        private void displayCompanyInformation(int ID, string name, string address, string postcode, int numCars)
        {
            this.txtCompID.Text = Convert.ToString(ID);
            this.txtCompName.Text = name;
            this.txtCompAddress.Text = address;
            this.txtCompPostcode.Text = postcode;
            this.lblCompCarCount.Text = "Cars Rented: " + Convert.ToString(numCars);
        }

        // Blocks other fields from use during update
        private void isUpdatingCompany()
        {
            
        }

        // Allows other fields after update complete
        private void companyUpdateComplete()
        {

        }

        // Method used to loop over the contents of the companies list and display all contents
        private void updateCompaniesList(List<Company> list)
        {
            this.lstAllCompanies.Items.Clear();

            for (int i = 0; i < list.Count; i++)
            {
                this.lstAllCompanies.Items.Add(list[i].PrintSummary());
            }
        }

        // Method used to locate the correct company in the list of companies
        private int locateCorrectCompany(string checkFor, List<Company> list)
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

        // Method used to search and display a specific company
        private void searchCompanies(string userInput, List<Company> list, ListBox lstBox)
        {
            this.companySearchResults.Clear();

            bool match = false;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].GetName().ToUpper().Contains(userInput.ToUpper()))
                {
                    match = true;

                    this.companySearchResults.Add(list[i]);
                }
            }

            if (!match) // Dispay no results message (there has not been a match)
            {
                lstBox.Items.Clear();

                lstBox.Items.Add("No companies have been found!");
            }
            else
            {
                lstBox.Items.Clear();

                for (int j = 0; j < this.companySearchResults.Count; j++)
                {
                    lstBox.Items.Add(this.companySearchResults[j].PrintSummary());
                }
            }
        }

        // Method used to add new company to list of companies
        public bool AddNewCompany(int companyID, string companyName, string companyAddress, string companyPostcode)
        {
            bool match = false; // Check to see if the list already contains that company

            for (int i = 0; i < this.companies.Count; i++)
            {
                if (this.companies[i].GetName().ToUpper() == companyName.ToUpper() || this.companies[i].GetId() == companyID) // User has entered a company name or ID that already exists
                {
                    match = true;
                }
            }

            if (companyID < 0) // Only accept positive ID 
            {
                MessageBox.Show("Please enter a positive ID.");
                return false;
            }

            if (!match) // There is not a match - safe to proceed with upload of new company
            {
                this.companies.Add(new Company(companyID, companyName, companyAddress, companyPostcode)); // Add a new company to the list of companies

                this.lstAllCompanies.Items.Clear();
                this.updateCompaniesList(companies);

                this.CreateNotification("company", "add", companyName, DateTime.Now.ToShortTimeString());

                this.nullAllFields();
                
                return true;
            }
            else
            {
                MessageBox.Show("It looks like you already have a company with that name or ID stored!"); 
                return false;
            }
        }

        // Method used to update information belonging to an existing company
        public bool UpdateCompany(Company oldRecord, int newCompanyID, string newCompanyName, string newCompanyAddress, string newCompanyPostcode)
        {
            bool match = false; //Check to see if a company with that name or ID already exists

            for (int i = 0; i < companies.Count; i++)
            {
                if ((this.companies[i].GetName() == newCompanyName && newCompanyName != oldRecord.GetName()) || (this.companies[i].GetId() == newCompanyID && newCompanyID != oldRecord.GetId()))
                {
                    match = true;
                }
            }

            if (newCompanyID < 0) // Only accept positive ID 
            {
                MessageBox.Show("Please enter a positive ID.");
                return false;
            }

            if (!match) // There is not a match - safe to proceed with update of company information
            {
                // Finilize the update:
                this.completeCompanyUpdate(oldRecord, newCompanyID, newCompanyName, newCompanyAddress, newCompanyPostcode);

                this.lstAllCompanies.Items.Clear();
                this.updateCompaniesList(companies);

                this.displayCompanyInformation(newCompanyID, newCompanyName, newCompanyAddress, newCompanyPostcode, this.currentSelectedCompany.GetNumberOfCars());
                this.lstAllCompanies.SetSelected(this.locateCorrectCompany(this.currentSelectedCompany.PrintSummary(), this.companies), true);

                this.CreateNotification("company", "update", oldRecord.GetName(), DateTime.Now.ToShortTimeString());
                return true;
            }
            else
            {
                MessageBox.Show("It looks like you already have a company with that name or ID stored!"); // Alert the user that they may have a duplicate entry 
                return false;
            }
        }

        // Method implemented to finilize the update 
        private void completeCompanyUpdate(Company changeMe, int ID, string name, string address, string postcode)
        {
            // Update old records:
            changeMe.SetId(ID);
            changeMe.SetName(name);
            changeMe.SetAddress(address);
            changeMe.SetPostcode(postcode);
        }

        #endregion

        #region code dealing with the cars

        // Method used to bring up company car information
        private void lstAllCompanies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.companies.Count != 0 && this.lstAllCompanies.Items[0].ToString() != "No companies have been found!")
            {
                this.lstCars.Items.Clear();

                // Open information for the correct company
                string companySummary = this.lstAllCompanies.Items[this.lstAllCompanies.SelectedIndex].ToString();
                int matchedIndex = this.locateCorrectCompany(companySummary, this.companies);
                this.currentSelectedCompany = this.companies[matchedIndex];

                this.displayCompanyInformation(this.currentSelectedCompany.GetId(), this.currentSelectedCompany.GetName(), this.currentSelectedCompany.GetAddress(), this.currentSelectedCompany.GetPostcode(), this.currentSelectedCompany.GetNumberOfCars());
                this.CreateNotification("company", "view-info", this.companies[this.lstAllCompanies.SelectedIndex].GetName(), DateTime.Now.ToShortTimeString());

                for (int i = 0; i < this.companies[this.lstAllCompanies.SelectedIndex].GetNumberOfCars(); i++)
                {
                    this.lstCars.Items.Add(this.companies[this.lstAllCompanies.SelectedIndex].GetAllCars()[i].PrintSummary());
                }
            }
        }

        // Method used to bring up summary of selected car
        private void lstCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.currentSelectedCompany = this.companies[this.lstAllCompanies.SelectedIndex];

            // Open information for the correct car
            string carSummary = this.lstCars.Items[this.lstCars.SelectedIndex].ToString();
            int matchedIndex = this.locateCorrectCar(carSummary, this.currentSelectedCompany.GetAllCars());
            this.currentSelectedCar = this.currentSelectedCompany.GetAllCars()[matchedIndex];

            this.displayCarInformation(this.currentSelectedCar, this.currentSelectedCar.GetId(), this.currentSelectedCar.GetMake(), this.currentSelectedCar.GetModel(), this.currentSelectedCar.GetReg(), this.currentSelectedCar.GetFuelType(), Convert.ToDateTime(this.currentSelectedCar.GetDateLastServiced().ToShortDateString()), this.currentSelectedCar.GetComments());
            this.CreateNotification("car", "view-info", this.currentSelectedCompany.GetName(), DateTime.Now.ToShortTimeString());
        }

        // BUTTON CLICKS:

        // Search for a specific car
        private void btnSearchCar_Click(object sender, EventArgs e)
        {
            string userInput = "";

            bool proceed = true;

            if (this.lstAllCompanies.SelectedIndex == -1)
            {
                MessageBox.Show("Make sure to select a company before searching.");
                proceed = false;
            }

            if (proceed)
            {
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
                    this.currentSelectedCompany = this.companies[this.lstAllCompanies.SelectedIndex];
                    this.searchCar(userInput, this.currentSelectedCompany.GetAllCars(), this.lstCars); // Search for a matching element

                    // Push notification to the user's recent activity: 

                    this.CreateNotification("car", "search", userInput, DateTime.Now.ToShortTimeString(), this.currentSelectedCompany.GetName());
                }
            }
        }
        
        // Refresh the list of all company cars after a search
        private void btnRefreshCars_Click(object sender, EventArgs e)
        {
            this.lstCars.Items.Clear();
            this.carSearchResults.Clear();
            this.txtSearchCars.Text = "";

            if (this.lstAllCompanies.SelectedIndex != -1)
            {
                this.currentSelectedCompany = this.companies[this.lstAllCompanies.SelectedIndex];
                for (int i = 0; i < this.currentSelectedCompany.GetAllCars().Count; i++)
                {
                    this.lstCars.Items.Add(this.currentSelectedCompany.GetAllCars()[i].PrintSummary());
                }
            }
        }

        // Add new car
        private void btnAddNewCar_Click(object sender, EventArgs e)
        {
            if (this.lstAllCompanies.SelectedIndex == -1)
            {
                MessageBox.Show("Make sure you select the company you want to add a car to."); // Alert the user
            }
            else
            {
                this.currentSelectedCompany = this.companies[this.lstAllCompanies.SelectedIndex];

                // Generate a new dynamic form allowing the user to add a new car:

                frmAddCar popup = new frmAddCar();
                popup.ShowDialog(this);
            }
        }

        // Update an existing car
        private void btnUpdateCar_Click(object sender, EventArgs e)
        {
            this.carEditingMode = true;
        }

        // Save changes made to car
        private void btnSaveCarChanges_Click(object sender, EventArgs e)
        {
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
                if (this.radUnleaded.Checked)
                {
                    newCarFuelType = "petrol";
                }
                else if (this.radDiesel.Checked)
                {
                    newCarFuelType = "diesel";
                }
                newDateLastServiced = this.dtpLastServiced.Value;
                newComments = this.txtDisplayCarComments.Text;
            }
            catch (Exception err)
            {
                MessageBox.Show("Error Detected! Error: " + err.Message + "\nSorry for any inconvenience caused.");
                isValid = false;
            }

            if (isValid)
            {
                this.currentSelectedCompany = this.companies[this.locateCorrectCompany(this.lstAllCompanies.Items[this.lstAllCompanies.SelectedIndex].ToString(), this.companies)];
                int oldRecord = this.locateCorrectCar(this.lstCars.Items[this.lstCars.SelectedIndex].ToString(), this.currentSelectedCompany.GetAllCars());

                bool updated = this.UpdateCar(this.currentSelectedCompany.GetAllCars()[oldRecord], newCarId, newCarMake, newCarModel, newCarReg, newCarFuelType, newDateLastServiced, newComments);

                if (updated)
                {
                    this.carEditingMode = false;
                }
            }
        }

        // Cancel changes made to car
        private void btnCancelCarUpdate_Click(object sender, EventArgs e)
        {
            this.reDisplayOldCarData();
            this.carEditingMode = false;
        }

        // Remove existing car
        private void btnRemoveCar_Click(object sender, EventArgs e)
        {
            string carSummary = "";

            // Make sure the user has selected a car to remove:

            if (this.lstCars.SelectedIndex == -1) // User has not selected a car
            {
                MessageBox.Show("Make sure you select a car to remove."); // Alert the user
            }
            else
            {
                this.currentSelectedCompany = this.companies[this.lstAllCompanies.SelectedIndex];

                carSummary = this.lstCars.Items[this.lstCars.SelectedIndex].ToString();

                int matchedIndex = this.locateCorrectCar(carSummary, this.currentSelectedCompany.GetAllCars());

                // Push notification to the user's recent activity:

                this.CreateNotification("car", "remove", Convert.ToString(this.currentSelectedCompany.GetAllCars()[matchedIndex].GetId()), DateTime.Now.ToShortTimeString(), this.currentSelectedCompany.GetName());

                // Proceed with deletion of selected company:

                this.currentSelectedCompany.removeCar(this.currentSelectedCompany.GetAllCars()[matchedIndex]);

                this.currentSelectedCompany.SetNumberOfCars(this.currentSelectedCompany.GetNumberOfCars() - 1);
                this.lblCompCarCount.Text = "Cars Rented: " + Convert.ToString(this.currentSelectedCompany.GetNumberOfCars());

                //Display the updated company information:

                this.lstCars.Items.Clear();
                this.updateCarList(this.currentSelectedCompany.GetAllCars());
            }
        }

        // METHODS:

        // Display old data when user cancels update
        private void reDisplayOldCarData()
        {
            this.currentSelectedCompany = this.companies[this.locateCorrectCompany(this.lstAllCompanies.Items[this.lstAllCompanies.SelectedIndex].ToString(), this.companies)];
            int oldRecord = this.locateCorrectCar(this.lstCars.Items[this.lstCars.SelectedIndex].ToString(), this.currentSelectedCompany.GetAllCars());
            this.displayCarInformation(this.currentSelectedCompany.GetAllCars()[oldRecord], this.currentSelectedCompany.GetAllCars()[oldRecord].GetId(), this.currentSelectedCompany.GetAllCars()[oldRecord].GetMake(), this.currentSelectedCompany.GetAllCars()[oldRecord].GetModel(), this.currentSelectedCompany.GetAllCars()[oldRecord].GetReg(), this.currentSelectedCompany.GetAllCars()[oldRecord].GetFuelType(), this.currentSelectedCompany.GetAllCars()[oldRecord].GetDateLastServiced(), this.currentSelectedCompany.GetAllCars()[oldRecord].GetComments());
        }

        // Blocks other fields from use during update
        private void isUpdatingCar()
        {

        }

        // Allows other fields after update complete
        private void carUpdateComplete()
        {

        }

        // Method used to display selected car summary
        private void displayCarInformation(Car selectedCar, int ID, string make, string model, string reg, string fuel, DateTime lastServiced, string comments)
        {
            this.txtCarID.Text = Convert.ToString(ID);
            this.txtCarMake.Text = make;
            this.txtCarModel.Text = model;
            this.txtCarReg.Text = reg;

            if (fuel != null)
            {
                if (fuel.ToUpper() == "UNLEADED")
                {
                    this.radUnleaded.Select();
                }
                else if (fuel.ToUpper() == "DIESEL")
                {
                    this.radDiesel.Select();
                }
            }
            else
            {
                this.radUnleaded.Checked = false;
                this.radDiesel.Checked = false;
            }

            if (lastServiced == Convert.ToDateTime(null))
            {
                this.dtpLastServiced.Value = DateTime.Today;
            }
            else
            {
                this.dtpLastServiced.Value = lastServiced;
            }

            this.txtDisplayCarComments.Text = comments;
        }

        // Method used to re-display the list of cars (after a change)
        private void updateCarList(List<Car> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                this.lstCars.Items.Add(list[i].PrintSummary());
            }
        }

        // Method used to locate the correct car in the list of cars
        private int locateCorrectCar(string checkFor, List<Car> list)
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

        // Method used to search through the company's list of cars and display a result (if present)
        private void searchCar(string userInput, List<Car> list, ListBox lstBox)
        {
            this.carSearchResults.Clear();

            bool match = false;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].PrintSummary().ToUpper().Contains(userInput.ToUpper()))
                {
                    match = true;

                    this.carSearchResults.Add(list[i]);
                }
            }

            if (!match) // Dispay no results message (there has not been a match)
            {
                lstBox.Items.Clear();

                lstBox.Items.Add("No cars have been found!");
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

        // Method used to add new car to the list of cars
        public bool AddNewCar(Car car)
        {
            // Check to see if a car with the same ID already exists:

            bool match = false;

            for (int i = 0; i < this.currentSelectedCompany.GetAllCars().Count; i++)
            {
                if (this.currentSelectedCompany.GetAllCars()[i].GetId() == car.GetId())
                {
                    match = true;
                }
            }

            if (car.GetId() < 0) // Only accept positive ID 
            {
                MessageBox.Show("Please enter a positive ID.");
                return false;
            }

            if (!match) // There is not a match - safe to proceed with upload of new car
            {
                this.currentSelectedCompany.AddNewCar(car); // Add the new car to the company's list of cars

                this.currentSelectedCompany.SetNumberOfCars(this.currentSelectedCompany.GetNumberOfCars() + 1);
                this.lblCompCarCount.Text = "Cars Rented: " + Convert.ToString(this.currentSelectedCompany.GetNumberOfCars());

                // Re-display the updated contents of the company's car list:

                this.lstCars.Items.Clear();
                this.updateCarList(this.currentSelectedCompany.GetAllCars());

                // Push notification to the user's recent activity:

                this.CreateNotification("car", "add", currentSelectedCompany.GetName(), DateTime.Now.ToShortTimeString());
                return true;
            }
            else
            {
                MessageBox.Show("Error: Duplicate entry of ID."); // Alert the user of the issue
                return false;
            }
        }

        // Method used to update an existing car's data
        public bool UpdateCar(Car oldCar, int newCarId, string newCarMake, string newCarModel, string newCarReg, string newFuelType, DateTime newLastServiced, string newComments)
        {
            // Check to see if a car with the same ID already exists:
            bool match = false;

            for (int i = 0; i < this.currentSelectedCompany.GetAllCars().Count; i++)
            {
                if (this.currentSelectedCompany.GetAllCars()[i].GetId() == newCarId && newCarId != oldCar.GetId())
                {
                    match = true;
                }
            }

            if (newCarId < 0) // Only accept positive ID 
            {
                MessageBox.Show("Please enter a positive ID.");
                return false;
            }

            if (!match) // There is not a match - safe to proceed with upload of new car information
            {
                // Finilize the update
                this.completeCarUpdate(oldCar, newCarId, newCarMake, newCarModel, newCarReg, newFuelType, newLastServiced, newComments);

                // Display the updated car information:
                this.displayCarInformation(null, newCarId, newCarMake, newCarModel, newCarReg, newFuelType, newLastServiced, newComments);
                this.lstCars.Items.Clear();
                updateCarList(this.currentSelectedCompany.GetAllCars());
                this.lstCars.SetSelected(this.locateCorrectCar(this.currentSelectedCar.PrintSummary(), this.currentSelectedCompany.GetAllCars()), true);

                // Push notification to the user's recent activity:
                this.CreateNotification("car", "update", Convert.ToString(oldCar.GetId()), DateTime.Now.ToShortTimeString(), this.currentSelectedCompany.GetName());
                return true;
            }
            else
            {
                MessageBox.Show("It looks like you already have a car with that ID stored!"); // Alert the user that they may have a duplicate entry 
                return false;
            }
        }

        // Method implemented to finilaze the update
        private void completeCarUpdate(Car changeMe, int ID, string make, string model, string reg, string fuel, DateTime lastServiced, string comments)
        {
            changeMe.SetId(ID);
            changeMe.SetMake(make);
            changeMe.SetModel(model);
            changeMe.SetRegistration(reg);
            changeMe.SetFuelType(fuel);
            changeMe.SetDateLastServiced(lastServiced);
            changeMe.SetComments(comments);
        }

        #endregion

        #region code dealing with the notification system

        // Method used to add notifications to the users' recent activity tab
        private void CreateNotification(string notificationType, string action, string affectedElement, string theTime, string affectedElement2 = null)
        {
            string generatedNotification = "";

            switch (action)
            {
                case "add": // Add new company / car

                    if (notificationType == "company")
                    {
                        generatedNotification = "You added '" + affectedElement + "' to your company records @ " + theTime + ".";
                    }
                    else
                    {
                        generatedNotification = "You added a new car to '" + affectedElement + "' @ " + theTime + ".";
                    }

                    break;
                case "update": // Update company / car 

                    if (notificationType == "company")
                    {
                        generatedNotification = "You updated the records of '" + affectedElement + "' in your company records @ " + theTime + ".";
                    }
                    else
                    {
                        generatedNotification = "You updated a car (ID: " + affectedElement + ") which belongs to '" + affectedElement2 + "' @ " + theTime + ".";
                    }

                    break;
                case "view-info": // View company / car

                    if (notificationType == "company")
                    {
                        generatedNotification = "You viewed '" + affectedElement + "' @ " + theTime + ".";
                    }
                    else
                    {
                        generatedNotification = "You viewed a car which belongs to '" + affectedElement + "' @ " + theTime + ".";
                    }

                    break;
                case "remove": // Remove company / car

                    if (notificationType == "company")
                    {
                        generatedNotification = "You removed '" + affectedElement + "' from your company records @ " + theTime + ".";
                    }
                    else
                    {
                        generatedNotification = "You removed a car (ID: " + affectedElement + ") from the records of '" + affectedElement2 + "' @ " + theTime + ".";
                    }

                    break;
                case "search": // Search company / car 

                    if (notificationType == "company")
                    {
                        generatedNotification = "You searched for '" + affectedElement + "' in your list of companies @ " + theTime + ".";
                    }
                    else
                    {
                        generatedNotification = "You searched for '" + affectedElement + "' in the records of '" + affectedElement2 + "' @ " + theTime + ".";
                    }

                    break;
                case "save": // Save all work 

                    if (notificationType == "self-saved") // User has saved their work
                    {
                        generatedNotification = "Your work has successfully been saved to '" + affectedElement + "' @ " + theTime + ".";
                    }
                    else // User's work has been auto saved
                    {
                        generatedNotification = "Auto-save has successfully saved your work to '" + affectedElement + "' @ " + theTime + ".";
                    }

                    break;
                default: // Action unidentified

                    generatedNotification = "Unidentified action performed @ " + theTime + ".";

                    break;
            }

            this.notifications.Add(generatedNotification);

            this.UpdateNotifications(notifications);
        }

        // Method used to search through notifications
        private void btnSearchRecentActivity_Click_1(object sender, EventArgs e)
        {
            string userInput = "";

            try
            {
                userInput = this.txtSearchRecentActivity.Text;
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
                this.searchNotifications(userInput, this.notifications, this.lstRecentActivity);
            }
        }

        // Method used to re-display all notifications after search
        private void btnRefreshNotifications_Click_1(object sender, EventArgs e)
        {
            this.lstRecentActivity.Items.Clear();
            this.recentActivitySearchResults.Clear();
            this.txtSearchRecentActivity.Text = "";

            for (int i = 0; i < this.notifications.Count; i++)
            {
                this.lstRecentActivity.Items.Add(this.notifications[i]);
            }
        }

        // Method used to search through the notifications list and display results
        private void searchNotifications(string userInput, List<string> list, ListBox lstBox)
        {
            this.recentActivitySearchResults.Clear();

            bool match = false;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ToUpper().Contains(userInput.ToUpper()))
                {
                    match = true;

                    this.recentActivitySearchResults.Add(list[i]);
                }
            }

            if (!match)
            {
                lstBox.Items.Clear();

                lstBox.Items.Add("No recent activity like that has been found!");
            }
            else
            {
                lstBox.Items.Clear();

                for (int j = 0; j < this.recentActivitySearchResults.Count; j++)
                {
                    lstBox.Items.Add(this.recentActivitySearchResults[j]);
                }
            }
        }

        // Method used to update the notifications and keep the user up to date
        private void UpdateNotifications(List<string> list)
        {
            this.lstRecentActivity.Items.Clear();

            for (int i = 0; i < this.notifications.Count; i++)
            {
                this.lstRecentActivity.Items.Add(list[i]);
            }

            if (list.Count == 0)
            {
                this.lstRecentActivity.Items.Add("You currently have no recent activities recorded.");
            }
        }

        #endregion

        #region code dealing with extra features

        // Method called every 1/10 second to perform routine tasks

        // Method called on program load
        private void initiateProgram()
        {
            // Timer to check selected fields:
            Timer timeAndCheckFields = new Timer();
            timeAndCheckFields.Interval = 10;
            timeAndCheckFields.Tick += new EventHandler(check_Timer_Tick);
            timeAndCheckFields.Start();

            // Timer to autosave user's work:
            Timer autoSaveWork = new Timer();
            autoSaveWork.Interval = ((1000 * 60) * 5); // every 5 mins
            autoSaveWork.Tick += new EventHandler(autoSave_Timer_Tick);
            autoSaveWork.Start();

            // Prepare page for load:
            this.radNotificationsOff.Select();
            this.radAutoSaveOn.Select();
            this.notifications.Clear();

            // Check items are present to select:
            if (this.lstAllCompanies.Items.Count > 0)
            {
                this.setSelectedFields();
            }

            this.lstRecentActivity.Items.Clear();
            this.lblLastSaved.Text = "Last Saved: " + DateTime.Now.ToShortTimeString();
            this.lstRecentActivity.Items.Add("You currently have no recent activities recorded.");
            this.txtInputFileName.Text = "exampleFile.txt";

            // Apply color change:
            this.colorForm();
        }

        // Method used to apply correct color scheme to form
        private void colorForm()
        {
            // #EAEAEA = Light Grey
            // #0000000 = Black
            // #ffffff = White
            // #31708E = Light Blue

            this.BackColor = ColorTranslator.FromHtml("#EAEAEA");
            this.grpCompanySummary.ForeColor = ColorTranslator.FromHtml("#000000");
            this.grpCarSummary.ForeColor = ColorTranslator.FromHtml("#000000");
            foreach (Label l in Controls.OfType<Label>())
            {
                l.ForeColor = ColorTranslator.FromHtml("#000000");
            }

            foreach (Button b in Controls.OfType<Button>())
            {
                b.ForeColor = ColorTranslator.FromHtml("#ffffff");
                b.BackColor = ColorTranslator.FromHtml("#31708E");
            }

            foreach (RadioButton r in Controls.OfType<RadioButton>())
            {
                r.ForeColor = ColorTranslator.FromHtml("#000000");
            }
        }

        private void check_Timer_Tick(object sender, EventArgs e)
        {
            // Check selected company:
            if (this.lstAllCompanies.SelectedIndex == -1)
            {
                this.displayCompanyInformation(Convert.ToInt32(null), null, null, null, Convert.ToInt32(null));
                this.btnUpdateCompany.Enabled = false;
                this.btnRemoveCompany.Enabled = false;
                this.grpCompanySummary.Enabled = false;
                this.lstCars.Items.Clear();
            }
            else
            {
                this.btnUpdateCompany.Enabled = true;
                this.btnRemoveCompany.Enabled = true;
                this.grpCompanySummary.Enabled = true;
            }

            // Check selected car:
            if (this.lstCars.SelectedIndex == -1)
            {
                this.displayCarInformation(null, Convert.ToInt32(null), null, null, null, null, Convert.ToDateTime(null), null);
                this.btnUpdateCar.Enabled = false;
                this.btnRemoveCar.Enabled = false;
                this.grpCarSummary.Enabled = false;
            }
            else
            {
                this.btnUpdateCar.Enabled = true;
                this.btnRemoveCar.Enabled = true;
                this.grpCarSummary.Enabled = true;
            }

            // Check user is editing a company
            if (this.companyEditingMode == true)
            {
                this.enableCompanyFields();
                this.btnCancelCompanyUpdate.Enabled = true;
                this.btnSaveCompanyChanges.Enabled = true;
            }
            else
            {
                this.limitCompanyFields();
                this.btnCancelCompanyUpdate.Enabled = false;
                this.btnSaveCompanyChanges.Enabled = false;
            }

            // Check user is editing a car
            if (this.carEditingMode == true)
            {
                this.enableCarFields();
                this.btnCancelCarUpdate.Enabled = true;
                this.btnSaveCarChanges.Enabled = true;
            }
            else
            {
                this.limitCarFields();
                this.btnCancelCarUpdate.Enabled = false;
                this.btnSaveCarChanges.Enabled = false;
            }

            // Check if user wants to display notifications:
            if (!this.radNotificationsOn.Checked)
            {
                this.Width = 1373;
            }
            else
            {
                this.Width = 1835;
            }
        }

        // Method used to invoke auto-save method every 5 minutes
        private void autoSave_Timer_Tick(object sender, EventArgs e)
        {
            if (this.radAutoSaveOn.Checked)
            {
                this.autoSave();
                this.lblLastSaved.Text = "Last Saved: " + DateTime.Now.ToShortTimeString();
            }
        }

        // Method used to bring up a summary of the program
        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAboutProgram popup = new frmAboutProgram();
            popup.ShowDialog(this);
        }

        // Method used to null 'about' fields when not in use
        private void nullAllFields()
        { 
            this.displayCarInformation(null, Convert.ToInt32(null), null, null, null, null, Convert.ToDateTime(null), null);
            this.displayCompanyInformation(Convert.ToInt32(null), null, null, null, Convert.ToInt32(null));
            this.lstCars.Items.Clear();
        }

        // Method used to enable editable company fields
        private void enableCompanyFields()
        {
            this.txtCompID.Enabled = true;
            this.txtCompName.Enabled = true;
            this.txtCompAddress.Enabled = true;
            this.txtCompPostcode.Enabled = true;
        }

        // Method used to enable editable company fields
        private void enableCarFields()
        {
            this.txtCarID.Enabled = true;
            this.txtCarMake.Enabled = true;
            this.txtCarModel.Enabled = true;
            this.txtCarReg.Enabled = true;
            this.radDiesel.Enabled = true;
            this.radUnleaded.Enabled = true;
            this.dtpLastServiced.Enabled = true;
            this.txtDisplayCarComments.Enabled = true;
        }

        // Method used to disable editable company fields
        private void limitCompanyFields()
        {
            this.txtCompID.Enabled = false;
            this.txtCompName.Enabled = false;
            this.txtCompAddress.Enabled = false;
            this.txtCompPostcode.Enabled = false;
        }

        // Method used to disable editable company fields
        private void limitCarFields()
        {
            this.txtCarID.Enabled = false;
            this.txtCarMake.Enabled = false;
            this.txtCarModel.Enabled = false;
            this.txtCarReg.Enabled = false;
            this.radDiesel.Enabled = false;
            this.radUnleaded.Enabled = false;
            this.dtpLastServiced.Enabled = false;
            this.txtDisplayCarComments.Enabled = false;
        }

        // Method used to select index 0 in company / car list boxes
        private void setSelectedFields()
        {
            this.lstAllCompanies.SetSelected(0, true);
            this.lstCars.SetSelected(0, true);
        }

        #endregion

    }
}

