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
        #region setting up arrays / classes required

        private List<Company> companies = new List<Company>(); 

        private List<Company> companySearchResults = new List<Company>(); 

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
                this.lblLastSaved.Text = "Last Saved: " + DateTime.Now.ToShortTimeString();
                MessageBox.Show("Your work has saved successfully.");
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
                MessageBox.Show("Auto-save has successfully saved your work.");
            }
        }

        #endregion

        #region code dealing with the companies

        // BUTTON CLICKS:

        // Search for a specific company 
        private void txtSearchCompanies_TextChanged(object sender, EventArgs e)
        {
            string userInput = "";

            try
            {
                // Filter companies
                userInput = this.txtSearchCompanies.Text;
                this.searchCompanies(userInput, this.companies, this.lstAllCompanies);
                this.nullAllFields();
                this.lstAllCompanies.SetSelected(0, true);

                // Display correct cars
                if (this.companySearchResults.Count > 0)
                {
                    this.lstCars.Items.Clear();
                    int matchedIndex = this.locateCorrectCompany(this.lstAllCompanies.Items[this.lstAllCompanies.SelectedIndex].ToString(), this.companies);

                    for (int i = 0; i < this.companies[matchedIndex].GetNumberOfCars(); i++)
                    {
                        this.lstCars.Items.Add(this.companies[matchedIndex].GetAllCars()[i].PrintSummary());
                    }

                    if (this.lstCars.Items.Count > 0)
                    {
                        this.lstCars.SetSelected(0, true);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
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
            if (this.lstAllCompanies.Items[this.lstAllCompanies.SelectedIndex].ToString() != "No companies have been found!")
            {
                this.companyEditingMode = true;
                string companySummary = this.lstAllCompanies.Items[this.lstAllCompanies.SelectedIndex].ToString();
            }
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
                    this.companies.Remove(companies[matchedIndex]);

                    //Display the updated company information:
                    this.lstAllCompanies.Items.Clear();
                    this.updateCompaniesList(companies);

                    if (this.lstAllCompanies.Items.Count > 0)
                    {
                        this.lstAllCompanies.SetSelected(0, true);
                    }
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
                if (list[i].PrintSummary().ToUpper().Contains(userInput.ToUpper()) || (list[i].GetAddress().ToUpper().Contains(userInput.ToUpper())) || (list[i].GetPostcode().ToUpper().Contains(userInput.ToUpper())))
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

                for (int i = 0; i < this.companies[this.lstAllCompanies.SelectedIndex].GetNumberOfCars(); i++)
                {
                    this.lstCars.Items.Add(this.companies[this.lstAllCompanies.SelectedIndex].GetAllCars()[i].PrintSummary());
                }

                if (this.lstCars.Items.Count > 0)
                {
                    this.lstCars.SetSelected(0, true);
                }
            }
        }

        // Method used to bring up summary of selected car
        private void lstCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            int matchedCompany = this.locateCorrectCompany(this.lstAllCompanies.Items[this.lstAllCompanies.SelectedIndex].ToString(), this.companies);
            this.currentSelectedCompany = this.companies[matchedCompany];

            // Open information for the correct car
            string carSummary = this.lstCars.Items[this.lstCars.SelectedIndex].ToString();
            int matchedIndex = this.locateCorrectCar(carSummary, this.currentSelectedCompany.GetAllCars());
            this.currentSelectedCar = this.currentSelectedCompany.GetAllCars()[matchedIndex];

            this.displayCarInformation(this.currentSelectedCar, this.currentSelectedCar.GetId(), this.currentSelectedCar.GetMake(), this.currentSelectedCar.GetModel(), this.currentSelectedCar.GetReg(), this.currentSelectedCar.GetFuelType(), Convert.ToDateTime(this.currentSelectedCar.GetDateLastServiced().ToShortDateString()), this.currentSelectedCar.GetComments());
        }

        // BUTTON CLICKS:

        // Search for a specific car
        private void txtSearchCars_TextChanged(object sender, EventArgs e)
        {
            string userInput = "";

            try
            {
                userInput = this.txtSearchCars.Text;
                int selectedCompany = this.locateCorrectCompany(this.lstAllCompanies.Items[this.lstAllCompanies.SelectedIndex].ToString(), this.companies);
                this.searchCar(userInput, this.companies[selectedCompany].GetAllCars(), this.lstCars);
                this.lstCars.SetSelected(0, true);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        
        // Add new car
        private void btnAddNewCar_Click(object sender, EventArgs e)
        {
            if (this.lstAllCompanies.SelectedIndex == -1 || this.lstAllCompanies.Items[this.lstAllCompanies.SelectedIndex].ToString() == "No companies have been found!")
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
            if (this.lstCars.Items[this.lstCars.SelectedIndex].ToString() != "No cars have been found!")
            {
                string companySummary = this.lstAllCompanies.Items[this.lstAllCompanies.SelectedIndex].ToString();
                this.carEditingMode = true;
            }
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
            if (this.lstCars.Items[this.lstCars.SelectedIndex].ToString() != "No cars have been found!")
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

                    // Proceed with deletion of selected company:

                    this.currentSelectedCompany.removeCar(this.currentSelectedCompany.GetAllCars()[matchedIndex]);

                    this.currentSelectedCompany.SetNumberOfCars(this.currentSelectedCompany.GetNumberOfCars() - 1);
                    this.lblCompCarCount.Text = "Cars Rented: " + Convert.ToString(this.currentSelectedCompany.GetNumberOfCars());

                    //Display the updated company information:

                    this.lstCars.Items.Clear();
                    this.updateCarList(this.currentSelectedCompany.GetAllCars());

                    if (this.lstCars.Items.Count > 0)
                    {
                        this.lstCars.SetSelected(0, true);
                    }
                }
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

        // Method used to display selected car summary
        private void displayCarInformation(Car selectedCar, int ID, string make, string model, string reg, string fuel, DateTime lastServiced, string comments)
        {
            this.txtCarID.Text = Convert.ToString(ID);
            this.txtCarMake.Text = make;
            this.txtCarModel.Text = model;
            this.txtCarReg.Text = reg;

            if (fuel != null)
            {
                if (fuel.ToUpper() == "PETROL")
                {
                    this.radUnleaded.Select();
                }
                else if (fuel.ToUpper() == "DIESEL")
                {
                    this.radDiesel.Select();
                }
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
                if (list[i].PrintSummary().ToUpper().Contains(userInput.ToUpper()) || (list[i].GetReg().ToUpper().Contains(userInput.ToUpper())) || (list[i].GetFuelType().ToUpper().Contains(userInput.ToUpper())))
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
                this.updateCarList(this.currentSelectedCompany.GetAllCars());
                this.lstCars.SetSelected(this.locateCorrectCar(this.currentSelectedCar.PrintSummary(), this.currentSelectedCompany.GetAllCars()), true);
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

        #region code dealing with loading form correctly

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
            this.radAutoSaveOn.Select();

            // Check items are present to select:
            if (this.lstAllCompanies.Items.Count > 0)
            {
                this.setSelectedFields();
            }

            this.lblLastSaved.Text = "Last Saved: " + DateTime.Now.ToShortTimeString();
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

        #region maintenance timer system checks

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

                // Check all criteria is met
                if (this.txtCompID.Text.Length < 1 || this.txtCompName.Text.Length < 2 || this.txtCompAddress.Text.Length < 7 || this.txtCompPostcode.Text.Length < 6)
                {
                    this.btnSaveCompanyChanges.Enabled = false;
                }
                else
                {
                    this.btnSaveCompanyChanges.Enabled = true;
                }

                // Code for changing ticks and crosses on main form
                this.checkCompanyFields();
            }
            else
            {
                this.limitCompanyFields();
                this.btnCancelCompanyUpdate.Enabled = false;
                this.btnSaveCompanyChanges.Enabled = false;

                // Null images when not editing
                this.nullField(this.picCompID);
                this.nullField(this.picCompName);
                this.nullField(this.picCompAddress);
                this.nullField(this.picCompPostcode);
            }

            // Check user is editing a car
            if (this.carEditingMode == true)
            {
                this.enableCarFields();
                this.btnCancelCarUpdate.Enabled = true;

                // Check all criteria is met
                if (this.txtCarID.Text.Length < 1 || this.txtCarMake.Text.Length < 3 || this.txtCarModel.Text.Length < 2 || this.txtCarReg.Text.Length < 3)
                {
                    this.btnSaveCarChanges.Enabled = false;
                }
                else
                {
                    this.btnSaveCarChanges.Enabled = true;
                }

                // Code for changing ticks and crosses on main form
                this.checkCarFields();
            }
            else
            {
                this.limitCarFields();
                this.btnCancelCarUpdate.Enabled = false;
                this.btnSaveCarChanges.Enabled = false;

                // Null images when not editing
                this.nullField(this.picCarID);
                this.nullField(this.picCarMake);
                this.nullField(this.picCarModel);
                this.nullField(this.picCarReg);
            }

            // Display correct button colors 
            foreach (Button b in Controls.OfType<Button>())
            {
                if (b.Enabled == true)
                {
                    b.ForeColor = ColorTranslator.FromHtml("#ffffff");
                    b.BackColor = ColorTranslator.FromHtml("#31708E");
                }
                else
                {
                    b.BackColor = Color.FromArgb(75, ColorTranslator.FromHtml("#31708E"));
                }
            }
        }

        #endregion

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

        // Change image to green tick
        private void approveField(PictureBox picBox)
        {
            picBox.Image = Image.FromFile("green-tick.png");
        }

        // Do not display image at all (textlength = 0)
        private void nullField(PictureBox picBox)
        {
            picBox.Image = null;
        }

        // Change image to red cross
        private void invalidField(PictureBox picBox)
        {
            picBox.Image = Image.FromFile("red-cross.png");
        }

        #region company image check

        // Method to check tick/cross for company input fields when editing
        private void checkCompanyFields()
        {
            // ID field
            if (this.txtCompID.Text.Length >= 1)
            {
                this.approveField(this.picCompID);
            }
            else
            {
                this.nullField(this.picCompID);
            }

            // Name field
            if (this.txtCompName.Text.Length >= 2)
            {
                this.approveField(this.picCompName);
            }
            else if (this.txtCompName.Text.Length != 0 && this.txtCompName.Text.Length < 2)
            {
                this.invalidField(this.picCompName);
            }
            else
            {
                this.nullField(this.picCompName);
            }

            // Address field
            if (this.txtCompAddress.Text.Length >= 7)
            {
                this.approveField(this.picCompAddress);
            }
            else if (this.txtCompAddress.Text.Length != 0 && this.txtCompAddress.Text.Length < 7)
            {
                this.invalidField(this.picCompAddress);
            }
            else
            {
                this.nullField(this.picCompAddress);
            }

            // Postcode field
            if (this.txtCompPostcode.Text.Length >= 6)
            {
                this.approveField(this.picCompPostcode);
            }
            else if (this.txtCompPostcode.Text.Length != 0 && this.txtCompPostcode.Text.Length < 6)
            {
                this.invalidField(this.picCompPostcode);
            }
            else
            {
                this.nullField(this.picCompPostcode);
            }
        }

        #endregion

        #region car image check

        // Method to check tick/cross for car input fields when editing
        private void checkCarFields()
        {
            // ID field
            if (this.txtCarID.Text.Length >= 1)
            {
                this.approveField(this.picCarID);
            }
            else
            {
                this.nullField(this.picCarID);
            }

            // Make field
            if (this.txtCarMake.Text.Length >= 3)
            {
                this.approveField(this.picCarMake);
            }
            else if (this.txtCarMake.Text.Length != 0 && this.txtCarMake.Text.Length < 3)
            {
                this.invalidField(this.picCarMake);
            }
            else
            {
                this.nullField(this.picCarMake);
            }

            // Model field
            if (this.txtCarModel.Text.Length >= 2)
            {
                this.approveField(this.picCarModel);
            }
            else if (this.txtCarModel.Text.Length != 0 && this.txtCarModel.Text.Length < 3)
            {
                this.invalidField(this.picCarModel);
            }
            else
            {
                this.nullField(this.picCarModel);
            }

            // Reg field
            if (this.txtCarReg.Text.Length >= 3)
            {
                this.approveField(this.picCarReg);
            }
            else if (this.txtCarReg.Text.Length != 0 && this.txtCarReg.Text.Length < 3)
            {
                this.invalidField(this.picCarReg);
            }
            else
            {
                this.nullField(this.picCarReg);
            }
        }

        #endregion

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

