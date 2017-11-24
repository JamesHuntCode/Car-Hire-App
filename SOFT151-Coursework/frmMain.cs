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

        #endregion

        public frmMain()
        {
            InitializeComponent();
            this.FormClosing += this.frmMain_FormClosing;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Read initial data into program
            this.readFile(Environment.CurrentDirectory + @"\exampleFile.txt");

            // Prepare program for load
            this.initiateProgram();
        }

        #region code dealing with reading from / writing to files

        // Method used to error handle files
        private bool checkFile(string path, string action)
        {
            try
            {
                if (action == "read")
                {
                    StreamReader tstRead = new StreamReader(path);
                    tstRead.Close();
                }
                else
                {
                    StreamWriter tstWrite = new StreamWriter(path);
                    tstWrite.Close();
                }
            }
            catch (FileNotFoundException err)
            {
                MessageBox.Show("Your file has not been found! Error Message: " + err.Message + "\nSorry for any inconvenience caused.");
                return false;
            }
            catch (DirectoryNotFoundException err)
            {
                MessageBox.Show("Your directory has not been found! Error Message: " + err.Message + "\nSorry for any inconvenience caused.");
                return false;
            }
            catch (PathTooLongException err)
            {
                MessageBox.Show("Your specified file path is too long! Error Message: " + err.Message + "\nSorry for any inconvenience caused.");
                return false;
            }
            catch (Exception err)
            {
                MessageBox.Show("There has been an error! Error Message: " + err.Message + "\nSorry for any inconvenience caused.");
                return false;
            }
            return true;
        }

        // Method used to read from file
        private void readFile(string filePath)
        {
            bool isValid = this.checkFile(filePath, "read");

            if (isValid)
            {
                using (StreamReader mySR = new StreamReader(filePath))
                {
                    while (mySR.Peek() > -1)
                    {
                        // Load company data:
                        int companyID = Convert.ToInt32(mySR.ReadLine());
                        string companyName = mySR.ReadLine();
                        string companyAddress = mySR.ReadLine();
                        string companyPostcode = mySR.ReadLine();
                        int numberOfCars = Convert.ToInt32(mySR.ReadLine());

                        Company newCompany = new Company(companyID, companyName, companyAddress, companyPostcode);

                        // Load car data:
                        for (int i = 0; i < numberOfCars; i++)
                        {
                            int carID = Convert.ToInt32(mySR.ReadLine());

                            // Split the car make from the model 
                            string[] carMakeAndModel = mySR.ReadLine().Split(null);
                            string carMake = carMakeAndModel[0];
                            string carModel = carMakeAndModel[1];

                            string carReg = mySR.ReadLine();
                            string fuelType = mySR.ReadLine();
                            DateTime lastServiced = Convert.ToDateTime(mySR.ReadLine());
                            string comments = mySR.ReadLine();

                            // Add new car to company 
                            Car newCar = new Car(carID, carMake, carModel, carReg, fuelType, lastServiced, comments);
                            newCompany.AddNewCar(newCar);
                        }
                        this.companies.Add(newCompany);
                    }
                }
                this.updateCompaniesList(companies);
            }
        }

        // Method used to write to files
        private bool writeFile(string filePath)
        {
            bool isValid = this.checkFile(filePath, "write");

            if (isValid)
            {
                using (StreamWriter mySW = new StreamWriter(filePath))
                {
                    for (int i = 0; i < this.companies.Count; i++)
                    {
                        // Write all company based information:
                        mySW.WriteLine(this.companies[i].GetId());
                        mySW.WriteLine(this.companies[i].GetName());
                        mySW.WriteLine(this.companies[i].GetAddress());
                        mySW.WriteLine(this.companies[i].GetPostcode());
                        mySW.WriteLine(this.companies[i].GetNumberOfCars());

                        for (int j = 0; j < this.companies[i].GetAllCars().Count; j++)
                        {
                            // Write all car based information:
                            mySW.WriteLine(this.companies[i].GetAllCars()[j].GetId());
                            mySW.WriteLine(this.companies[i].GetAllCars()[j].GetMake() + " " + this.companies[i].GetAllCars()[j].GetModel());
                            mySW.WriteLine(this.companies[i].GetAllCars()[j].GetReg());
                            mySW.WriteLine(this.companies[i].GetAllCars()[j].GetFuelType());
                            mySW.WriteLine(this.companies[i].GetAllCars()[j].GetDateLastServiced());
                            mySW.WriteLine(this.companies[i].GetAllCars()[j].GetComments());
                        }
                    }
                    return true;
                }
            }
            return false;
        }

        // Method to save user work (when clicked)
        private void btnSaveWork_Click(object sender, EventArgs e)
        {
            bool hasSaved = this.writeFile(Environment.CurrentDirectory + @"\exampleFile.txt");
            
            if (hasSaved)
            {
                this.CreateNotification("self-saved", "save", "exampleFile.txt", DateTime.Now.ToShortTimeString());
            }
        }

        // Method used to check data has been saved (prompt user if not)
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.save();
            }
            
            // Autosave work if error becomes present
            if (e.CloseReason == CloseReason.WindowsShutDown)
            {
                this.save();
            }

            if (e.CloseReason == CloseReason.TaskManagerClosing)
            {
                this.save();
            }
        }

        private void save()
        {
            this.autoSave();
            MessageBox.Show("All of your work has been saved.");
        }

        // Method used to autosave user data (called every 5 minutes)
        private void autoSave()
        {
            bool hasSaved = this.writeFile(Environment.CurrentDirectory + @"\exampleFile.txt");

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
            frmDynamicAddOrUpdate popup = new frmDynamicAddOrUpdate("Add New Company");
            popup.ShowDialog(this);
        }

        // Update an existing company 
        private void btnUpdateCompany_Click(object sender, EventArgs e)
        {
            if (this.lstAllCompanies.Items[0].ToString() != "No companies have been found!")
            {
                string companySummary = "";

                // Make sure the user has selected a company to update:
                if (this.lstAllCompanies.SelectedIndex == -1) // User has not selected a company
                {
                    MessageBox.Show("Make sure you select a company to edit."); // Alert the user
                }
                else
                {
                    companySummary = this.lstAllCompanies.Items[this.lstAllCompanies.SelectedIndex].ToString();

                    int matchedIndex = this.locateCorrectCompany(companySummary, this.companies);

                    // Generate a new dynamic for allowing the user to edit a previous company's information:
                    frmDynamicAddOrUpdate popup = new frmDynamicAddOrUpdate("Update Company Information", companies[matchedIndex]);
                    popup.ShowDialog(this);
                }
            }
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
        private void displayCompanyInformation(Company selectedCompany, int ID, string name, string address, string postcode, int numCars)
        {
            this.lblCompID.Text = "ID: " + Convert.ToString(ID);
            this.lblCompName.Text = "Name: " + name;
            this.lblCompAddress.Text = "Address: " + address;
            this.lblCompPostcode.Text = "Postcode: " + postcode;
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
                MessageBox.Show("It looks like you already have a company with that name or ID stored!"); // Alert the user that they may have a duplicate entry 
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

            if (!match) // There is not a match - safe to proceed with update of company information
            {
                // Finilize the update:
                this.completeCompanyUpdate(oldRecord, newCompanyID, newCompanyName, newCompanyAddress, newCompanyPostcode);

                this.lstAllCompanies.Items.Clear();
                this.updateCompaniesList(companies);

                this.displayCompanyInformation(null, newCompanyID, newCompanyName, newCompanyAddress, newCompanyPostcode, this.currentSelectedCompany.GetNumberOfCars());

                this.lstCars.Items.Clear();

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

                this.displayCompanyInformation(this.currentSelectedCompany, this.currentSelectedCompany.GetId(), this.currentSelectedCompany.GetName(), this.currentSelectedCompany.GetAddress(), this.currentSelectedCompany.GetPostcode(), this.currentSelectedCompany.GetNumberOfCars());
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

                frmDynamicAddOrUpdateCar popup = new frmDynamicAddOrUpdateCar("Add New Car");
                popup.ShowDialog(this);
            }
        }

        // Update an existing car
        private void btnUpdateCar_Click(object sender, EventArgs e)
        {
            string carSummary = "";

            if (this.lstCars.SelectedIndex == -1)
            {
                MessageBox.Show("Make sure you select which car you want to update."); // Alert the user
            }
            else
            {
                this.currentSelectedCompany = this.companies[this.lstAllCompanies.SelectedIndex];

                carSummary = this.lstCars.Items[this.lstCars.SelectedIndex].ToString();

                int matchedIndex = this.locateCorrectCar(carSummary, this.currentSelectedCompany.GetAllCars());

                // Generate a new dynamic form allowing the user to add a new car:

                frmDynamicAddOrUpdateCar popup = new frmDynamicAddOrUpdateCar("Update Car Information", this.currentSelectedCompany.GetAllCars()[matchedIndex]);
                popup.ShowDialog(this);
            }
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

        // Method used to display selected car summary
        private void displayCarInformation(Car selectedCar, int ID, string make, string model, string reg, string fuel, DateTime lastServiced, string comments)
        {
            this.lblCarID.Text = "ID: " + Convert.ToString(ID);
            this.lblCarMake.Text = "Make: " + make;
            this.lblCarModel.Text = "Model: " + model;
            this.lblCarReg.Text = "Registration: " + reg;
            this.lblFuelType.Text = "Fuel Type: " + fuel;
            this.lblLastServiced.Text = "Last Serviced: " + lastServiced;
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

            if (!match) // There is not a match - safe to proceed with upload of new car information
            {
                // Finilize the update
                this.completeCarUpdate(oldCar, newCarId, newCarMake, newCarModel, newCarReg, newFuelType, newLastServiced, newComments);

                // Display the updated car information:
                this.displayCarInformation(null, newCarId, newCarMake, newCarModel, newCarReg, newFuelType, newLastServiced, newComments);
                this.lstCars.Items.Clear();
                updateCarList(this.currentSelectedCompany.GetAllCars());

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

        // Clear all user recent activity 
        private void btnClearAllNotifications_Click(object sender, EventArgs e)
        {
            this.notifications.Clear();
            this.UpdateNotifications(this.notifications);
        }

        // Method used to refresh all notifiations
        private void btnRefreshNotifications_Click(object sender, EventArgs e)
        {
            this.lstRecentActivity.Items.Clear();
            this.recentActivitySearchResults.Clear();
            this.txtSearchRecentActivity.Text = "";

            for (int i = 0; i < this.notifications.Count; i++)
            {
                this.lstRecentActivity.Items.Add(this.notifications[i]);
            }
        }
        private void btnSearchRecentActivity_Click(object sender, EventArgs e)
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
            // Timer to display the current time to the user & check fields:
            Timer timeAndCheckFields = new Timer();
            timeAndCheckFields.Interval = 100;
            timeAndCheckFields.Tick += new EventHandler(check_Timer_Tick);
            timeAndCheckFields.Start();

            // Timer to autosave user's work:
            Timer autoSaveWork = new Timer();
            autoSaveWork.Interval = ((1000 * 60) * 5); // every 5 mins
            autoSaveWork.Tick += new EventHandler(autoSave_Timer_Tick);
            autoSaveWork.Start();

            // Prepare page for load:
            this.Height = 887;
            this.Width = 1404;
            this.lstAllCompanies.SetSelected(0, true);
            this.lstCars.SetSelected(0, true);
            this.notifications.Clear();
            this.lstRecentActivity.Items.Clear();
            this.lblDisplayDate.Text = Convert.ToString(DateTime.Today.ToShortDateString());
            this.lstRecentActivity.Items.Add("You currently have no recent activities recorded.");

            // Set up the color layout of the form - (#333 = graphite):
            this.BackColor = ColorTranslator.FromHtml("#333");
            foreach (Label l in Controls.OfType<Label>())
            {
                l.ForeColor = Color.DarkOrange;
            }

            // Optional code (run if in Smeaton)

            /*foreach (Button b in Controls.OfType<Button>())
            {
                b.ForeColor = Color.White;
            }*/
        }
        private void check_Timer_Tick(object sender, EventArgs e)
        {
            // Display time (top right corner of app)
            this.lblTheTime.Text = Convert.ToString(DateTime.Now.ToShortTimeString());

            // Auto check selectable fields
            if (this.lstAllCompanies.SelectedIndex == -1)
            {
                this.displayCompanyInformation(null, Convert.ToInt32(null), null, null, null, Convert.ToInt32(null));
            }

            if (this.lstCars.SelectedIndex == -1)
            {
                this.displayCarInformation(null, Convert.ToInt32(null), null, null, null, null, Convert.ToDateTime(null), null);
            }
        }

        // Method used to invoke auto-save method every 5 minutes
        private void autoSave_Timer_Tick(object sender, EventArgs e)
        {
            this.autoSave();
        }

        // Method used to remove all user data
        public void RemoveAllData()
        {
            this.companies.Clear();
            this.updateCompaniesList(this.companies);
            this.lstCars.Items.Clear();

            this.nullAllFields();
        }

        private void btnClearAllCompanies_Click(object sender, EventArgs e)
        {
            frmConfirmation confirm = new frmConfirmation();
            confirm.ShowDialog(this);
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
            this.displayCompanyInformation(null, Convert.ToInt32(null), null, null, null, Convert.ToInt32(null));
            this.lstCars.Items.Clear();
        }

        #endregion

    }
}

