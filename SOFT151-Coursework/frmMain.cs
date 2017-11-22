﻿using System;
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

        // Set up StreamReader / StreamWriter:

        StreamReader mySR;
        StreamWriter mySW;

        #endregion

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set up a timer to display the current time to the user:

            Timer myTimer = new Timer();
            myTimer.Interval = 100;
            myTimer.Tick += new EventHandler(timer_Tick);
            myTimer.Start();

            // Import test data:

            #region generate a few hard coded cars and companies to work with

            for (int i = 0; i < 30; i++)
            {
                companies.Add(new Company(i + 1, "Company " + (i + 1), "Example address", "Example postcode"));

                for (int j = 0; j < 30; j++)
                {
                    companies[i].AddNewCar(new Car(j + 1, "Random Make", "Random Model", "123456", "petrol", new DateTime(), "No comments yet"));
                }
            }

            updateCompaniesList(companies);

            #endregion

            // Read initial data into program:

            #region read initial file data into program

            /*string filePath = Environment.CurrentDirectory + @"\exampleFile.txt"; // Location of the file

            bool isValid = this.checkFile(filePath, mySR, null);

            if (isValid) // No exceptions have been thrown - safe to continue
            {
                using (mySR)
                {
                    while (mySR.Peek() >= 0) // Check for remaining data (chars) in the file
                    {
                        // Load comoany data:
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
                            string carMake = mySR.ReadLine();
                            string carModel = mySR.ReadLine();
                            string carReg = mySR.ReadLine();
                            string fuelType = mySR.ReadLine();
                            DateTime lastServiced = Convert.ToDateTime(mySR.ReadLine());
                            string comments = mySR.ReadLine();

                            // Add new car to company 
                            Car newCar = new Car(carID, carMake, carModel, carReg, fuelType, lastServiced, comments);
                            newCompany.AddNewCar(newCar);
                        }
                        // Add new company to list of companies
                        this.companies.Add(newCompany);
                    }
                }
                // Display company 
                updateCompaniesList(companies);
            }*/

            #endregion

            // Prepare page for load:

            this.radNotificationsOff.Select();
            this.Height = 707; // Full height is 941 / shortened height is 707

            this.lblDisplayDate.Text = Convert.ToString(DateTime.Today.ToShortDateString());
            this.lstRecentActivity.Items.Add("You currently have no recent activities recorded.");

            // Set up the color layout of the form - (#333 = graphite):

            this.BackColor = ColorTranslator.FromHtml("#333"); 

            foreach (Label l in Controls.OfType<Label>()) 
            {
                l.ForeColor = Color.DarkOrange;
            }

            /*foreach(Button b in Controls.OfType<Button>())
            {
                b.BackColor = ColorTranslator.FromHtml("#333");
                b.ForeColor = Color.White;
            }*/
        }

        #region code dealing with reading from / writing to files

        // Method used to error handle files
        private bool checkFile(string path, StreamReader SR = null, StreamWriter SW = null)
        {
            try
            {
                if (SR != null)
                {
                    SR = new StreamReader(path);
                }
                else if (SW != null)
                {
                    SW = new StreamWriter(path);
                }
            }
            catch (FileNotFoundException err)
            {
                MessageBox.Show("Your file has not been found! Error Message: " + err.Message);
                return false;
            }
            catch (DirectoryNotFoundException err)
            {
                MessageBox.Show("Your directory has not been found! Error Message: " + err.Message);
                return false;
            }
            catch (PathTooLongException err)
            {
                MessageBox.Show("Your specified file path is too long! Error Message: " + err.Message);
                return false;
            }
            catch (Exception err)
            {
                MessageBox.Show("There has been an error! Error Message: " + err.Message);
                return false;
            }
            return true;
        }

        // Method used to write to files
        public void WriteFile(string path)
        {
            string filePath = Environment.CurrentDirectory + @"\exampleFile.txt";

            bool isValid = this.checkFile(filePath, null, mySW);

            if (isValid)
            {
                using (mySW)
                {

                }
            }
        }

        // User is interacting with the different features of the program (buttons):
        private void btnAddNewCompany_Click(object sender, EventArgs e)
        {
            // Generate a new dynamic form allowing the user to add a new company:
            frmDynamicAddOrUpdate popup = new frmDynamicAddOrUpdate("Add New Company");
            popup.ShowDialog(this);
        }

        #endregion

        #region code dealing with the companies

        // BUTTON CLICKS:

        private void btnUpdateCompany_Click(object sender, EventArgs e)
        {
            string companySummary = "";

            // Make sure the user has selected a company to update:
            if (this.lstAllCompanies.SelectedIndex == -1) // User has not selected a company
            {
                MessageBox.Show("Make sure you select a company to edit."); // Alert the user
            }
            else
            {
                companySummary = companySummary = this.lstAllCompanies.Items[this.lstAllCompanies.SelectedIndex].ToString();

                int matchedIndex = this.locateCorrectCompany(companySummary, this.companies);

                // Generate a new dynamic for allowing the user to edit a previous company's information:
                frmDynamicAddOrUpdate popup = new frmDynamicAddOrUpdate("Update Company Information", companies[matchedIndex]);
                popup.ShowDialog(this);
            }
        }

        private void btnRemoveCompany_Click(object sender, EventArgs e)
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

                // Push notification to the user's recent activity:
                this.CreateNotification("company", "remove", companies[matchedIndex].GetName(), DateTime.Now.ToShortTimeString());

                // Proceed with deletion of selected company:
                this.companies.Remove(companies[matchedIndex]);

                //Display the updated company information:
                this.lstAllCompanies.Items.Clear();
                this.updateCompaniesList(companies);

                // Clear the deleted company's cars:
                this.lstCars.Items.Clear();
            }
        }

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
            }
        }

        private void btnRefreshCompanies_Click(object sender, EventArgs e)
        {
            this.lstAllCompanies.Items.Clear();
            this.companySearchResults.Clear();
            this.txtSearchCompanies.Text = "";

            for (int i = 0; i < this.companies.Count; i++)
            {
                this.lstAllCompanies.Items.Add(this.companies[i].PrintSummary());
            }
        }

        // METHODS:

        // Method used to loop over the contents of the companies list and display all contents
        private void updateCompaniesList(List<Company> list)
        {
            this.lstAllCompanies.Items.Clear();

            for (int i = 0; i < list.Count; i++)
            {
                this.lstAllCompanies.Items.Add(list[i].PrintSummary());
            }

            if (this.companies.Count == 0)
            {
                this.lstAllCompanies.Items.Add("You currently have no companies in your records.");
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

                // Re-display the updated contents of the companies list:
                this.lstAllCompanies.Items.Clear();
                this.updateCompaniesList(companies);

                // Push notification to the user's recent activity:
                this.CreateNotification("company", "add", companyName, DateTime.Now.ToShortTimeString());
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
                // Update old records:
                oldRecord.SetId(newCompanyID);
                oldRecord.SetName(newCompanyName);
                oldRecord.SetAddress(newCompanyAddress);
                oldRecord.SetPostcode(newCompanyPostcode);

                //Display the updated company information:
                this.lstAllCompanies.Items.Clear();
                this.updateCompaniesList(companies);

                // Push notification to the user's recent activity:
                this.CreateNotification("company", "update", oldRecord.GetName(), DateTime.Now.ToShortTimeString());
                return true;
            }
            else
            {
                MessageBox.Show("It looks like you already have a company with that name or ID stored!"); // Alert the user that they may have a duplicate entry 
                return false;
            }
        }

        #endregion

        #region code dealing with the cars

        // Method used to bring up company car information
        private void lstAllCompanies_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < this.companies[this.lstAllCompanies.SelectedIndex].GetNumberOfCars(); i++)
            {
                this.lstCars.Items.Add(this.companies[this.lstAllCompanies.SelectedIndex].GetAllCars()[i].PrintSummary());
            }

            this.CreateNotification("company", "view-info", this.companies[this.lstAllCompanies.SelectedIndex].GetName(), DateTime.Now.ToShortTimeString());
        }

        // BUTTON CLICKS:

        private void btnSearchCar_Click(object sender, EventArgs e)
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
                this.searchCar(userInput, this.currentSelectedCompany.GetAllCars(), this.lstCars); // Search for a matching element

                // Push notification to the user's recent activity: 

                this.CreateNotification("car", "search", userInput, DateTime.Now.ToShortTimeString(), this.currentSelectedCompany.GetName());
            }
        }

        private void btnRefreshCars_Click(object sender, EventArgs e)
        {
            this.lstCars.Items.Clear();
            this.carSearchResults.Clear();
            this.txtSearchCars.Text = "";

            for (int i = 0; i < this.currentSelectedCompany.GetAllCars().Count; i++)
            {
                this.lstCars.Items.Add(this.currentSelectedCompany.GetAllCars()[i].PrintSummary());
            }
        }

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

        private void btnUpdateCar_Click(object sender, EventArgs e)
        {
            string carSummary = "";

            if (this.lstAllCompanies.SelectedIndex == -1)
            {
                MessageBox.Show("Make sure you select the company you want to add a car to."); // Alert the user
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
                //this.lblCarCount.Text = "Cars rented: " + Convert.ToString(this.currentSelectedCompany.GetNumberOfCars());  COME BACK TO THIS

                //Display the updated company information:

                this.lstCars.Items.Clear();
                this.updateCarList(this.currentSelectedCompany.GetAllCars());
            }
        }

        // METHODS:

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
        private void updateCarList(List<Car> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                this.lstCars.Items.Add(list[i].PrintSummary());
            }

            if (list.Count == 0)
            {
                this.lstCars.Items.Add("This company currently has no cars.");
            }
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
                //this.lblCarCount.Text = "Cars rented: " + Convert.ToString(this.currentSelectedCompany.GetNumberOfCars()); COME BACK TO THIS

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
                // Update old records:
                oldCar.SetId(newCarId);
                oldCar.SetMake(newCarMake);
                oldCar.SetModel(newCarModel);
                oldCar.SetRegistration(newCarReg);
                oldCar.SetFuelType(newFuelType);
                oldCar.SetDateLastServiced(newLastServiced);
                oldCar.SetComments(newComments);

                //Display the updated company information:

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

        #endregion

        #region code dealing with the notification system

        // Turn notifications on
        private void radNotificationsOn_CheckedChanged(object sender, EventArgs e)
        {
            this.Height = 941;
        }

        // Turn notifications off
        private void radNotificationsOff_CheckedChanged(object sender, EventArgs e)
        {
            this.Height = 707;
        }

        // Method used to add notifications to the users' recent activity tab
        public void CreateNotification(string notificationType, string action, string affectedElement, string theTime, string affectedElement2 = null)
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
                        generatedNotification = "You updated '" + affectedElement + "' in your company records @ " + theTime + ".";
                    }
                    else
                    {
                        generatedNotification = "You updated a car (ID: " + affectedElement + ") which belongs to '" + affectedElement2 + "' @ " + theTime + ".";
                    }

                    break;
                case "view-info": // View company / car

                    if (notificationType == "company")
                    {
                        generatedNotification = "You viewed the full profile of '" + affectedElement + "' @ " + theTime + ".";
                    }
                    else
                    {
                        generatedNotification = "You viewed the full profile of a car which belongs to '" + affectedElement + "' @ " + theTime + ".";
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
        public void UpdateNotifications(List<string> list)
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

        private void timer_Tick(object sender, EventArgs e)
        {
            this.lblTheTime.Text = Convert.ToString(DateTime.Now.ToShortTimeString());
        }

        public void RemoveAllData()
        {
            this.companies.Clear();
            this.updateCompaniesList(this.companies);
        }

        private void btnClearAllCompanies_Click(object sender, EventArgs e)
        {
            frmConfirmation confirm = new frmConfirmation();
            confirm.ShowDialog(this);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAboutProgram popup = new frmAboutProgram();
            popup.ShowDialog(this);
        }

        #endregion
    }
}

