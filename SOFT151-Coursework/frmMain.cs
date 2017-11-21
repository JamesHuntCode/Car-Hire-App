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
        // Set up lists:

        private List<Company> companies = new List<Company>(); 

        private List<string> notifications = new List<string>(); 

        private List<Company> companySearchResults = new List<Company>(); 

        private List<string> recentActivitySearchResults = new List<string>(); 

        // Set up StreamReader / StreamWriter:

        StreamReader mySR;
        StreamWriter mySW;

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set up a timer to display the current time to the user:

            Timer myTimer = new Timer();
            myTimer.Interval = 1000;
            myTimer.Tick += new EventHandler(timer_Tick);
            myTimer.Start();

            // Import test data:

            #region generate a few hard coded cars and companies to work with:

            /*for (int i = 0; i < 30; i++)
            {
                companies.Add(new Company(i + 1, "Company " + (i + 1), "Example address", "Example postcode"));

                for (int j = 0; j < 30; j++)
                {
                    companies[i].AddNewCar(new Car(j + 1, "Random Make", "Random Model", "123456", "petrol", new DateTime(), "No comments yet"));
                }
            }

            updateCompaniesList(companies);*/

            #endregion

            // Read initial data into program:

            #region prepare to read from a file:

            string filePath = Environment.CurrentDirectory + @"\exampleFile.txt"; // Location of the file (example name used)

            bool isValid = true;

            // Retrieve file from specified path or catch error if one becomes present:

            try
            {
                mySR = new StreamReader(filePath);
            }
            catch (FileNotFoundException err) 
            {
                MessageBox.Show("Your file has not been found! Error Message: " + err.Message);
                isValid = false;
            }
            catch (DirectoryNotFoundException err) 
            {
                MessageBox.Show("Your directory has not been found! Error Message: " + err.Message);
                isValid = false;
            }
            catch (PathTooLongException err)
            {
                MessageBox.Show("Your specified file path is too long! Error Message: " + err.Message);
                isValid = false;
            }
            catch (Exception err) // Catch general exception if it is not one of the above
            {
                MessageBox.Show("There has been an error! Error Message: " + err.Message);
                isValid = false;
            }

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
            }
     
            #endregion

            // Prepare page for load:

            this.lblDisplayDate.Text = Convert.ToString(DateTime.Today.ToShortDateString());
            this.lstRecentActivity.Items.Add("You currently have no recent activities recorded.");

            // Set up the color layout of the form - (#333 = graphite):

            this.BackColor = ColorTranslator.FromHtml("#333"); 

            foreach (Label l in Controls.OfType<Label>()) 
            {
                l.ForeColor = Color.DarkOrange;
            }

            foreach(Button b in Controls.OfType<Button>())
            {
                b.BackColor = ColorTranslator.FromHtml("#333");
                b.ForeColor = Color.White;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.lblTheTime.Text = Convert.ToString(DateTime.Now.ToShortTimeString());
        }

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

        // Method used to error handle files
        private bool checkFile(string path)
        {
            // Come back to this
            return true;
        }

        // Method used to write to files
        public void WriteFile(string path) 
        {
            string filePath = Environment.CurrentDirectory + @"\exampleFile.txt";

            bool isValid = true;

            try
            {
                mySW = new StreamWriter(filePath);
            }
            catch (FileNotFoundException err)
            {
                MessageBox.Show("Your file has not been found! Error Message: " + err.Message);
                isValid = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("There has been an error! Error Message: " + err.Message);
                isValid = false;
            }

            if (isValid) // Everything checked - proceed to write to the specified file
            {

            }
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

        // User is interacting with the different features of the program (buttons):
        private void btnAddNewCompany_Click(object sender, EventArgs e)
        {
            // Generate a new dynamic form allowing the user to add a new company:
            frmDynamicAddOrUpdate popup = new frmDynamicAddOrUpdate("Add New Company");
            popup.ShowDialog(this);
        }

        // Method used to add new company 
        public bool AddNew(int companyID, string companyName, string companyAddress, string companyPostcode) 
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

                int matchedIndex = this.locateCorrectTarget(companySummary, this.companies);

                // Generate a new dynamic for allowing the user to edit a previous company's information:
                frmDynamicAddOrUpdate popup = new frmDynamicAddOrUpdate("Update Company Information", companies[matchedIndex]);
                popup.ShowDialog(this);
            }
        }

        // Method used to update company 
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

        private void btnOpenCompany_Click(object sender, EventArgs e)
        {
            string companySummary = "";

            // Make sure the user has selected a company to view:
            if (this.lstAllCompanies.SelectedIndex == -1) // User has not selected a compay's profile to view 
            {
                MessageBox.Show("Make sure you select a company to view."); // Alert the user
            }
            else 
            {
                companySummary = this.lstAllCompanies.Items[this.lstAllCompanies.SelectedIndex].ToString();

                int matchedIndex = this.locateCorrectTarget(companySummary, this.companies);

                // Push notification to user's recent activity:
                this.CreateNotification("company", "view-info", this.companies[matchedIndex].GetName(), DateTime.Now.ToShortTimeString());

                // Generate form allowing the user to view the selected company's full profile:
                frmCompanyProfile popup = new frmCompanyProfile(companies[matchedIndex]);
                popup.Show(this);
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

                int matchedIndex = this.locateCorrectTarget(companySummary, this.companies);

                // Push notification to the user's recent activity:
                this.CreateNotification("company", "remove", companies[matchedIndex].GetName(), DateTime.Now.ToShortTimeString());

                // Proceed with deletion of selected company:
                this.companies.Remove(companies[matchedIndex]);

                //Display the updated company information:
                this.lstAllCompanies.Items.Clear();
                this.updateCompaniesList(companies);
            }
        }

        // Method used to locate the correct company in the list of companies
        private int locateCorrectTarget(string checkFor, List<Company> list)
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

        // Method used to search through the companies list and dispay results
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

        // Method used to search for a company 
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

        // Method used to search through notifications
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

        // Method used to refresh list of companies
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

        // Method used to wipe all imported data
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

        // Clear all user recent activity 
        private void btnClearAllNotifications_Click(object sender, EventArgs e) 
        {
            this.notifications.Clear();
            this.UpdateNotifications(this.notifications);
        }

        private void btnAbout_Click(object sender, EventArgs e) 
        {
            frmAboutProgram popup = new frmAboutProgram();
            popup.ShowDialog(this);
        }
    }
}
