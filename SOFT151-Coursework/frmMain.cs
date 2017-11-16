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
    public partial class frmMain : Form
    {
        private List<Company> companies = new List<Company>(); // List of all companies

        private List<string> notifications = new List<string>(); // List of all notifications

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region generate a few hard coded cars and companies to work with:

            for (int i = 0; i < 10; i++)
            {
                companies.Add(new Company(i + 1, "Company " + (i + 1), "Example address", "Example postcode")); 

                for (int j = 0; j < 10; j++) 
                {
                    companies[i].AddNewCar(new Car(j + 1, "Random Make", "Random Model", "123456", "Petrol", new DateTime(), "No comments yet"));
                }
            }

            updateList(companies);

            #endregion
        }

        private void updateList(List<Company> list) // Method used to loop over the contents of the companies list and display all contents
        {
            for (int i = 0; i < list.Count; i++)
            {
                this.lstAllCompanies.Items.Add(list[i].PrintSummary());
            }
        }

        public void UpdateNotifications(List<string> list) // Method used to update the notifications and keep the user up to date
        {
            this.lstRecentActivity.Items.Clear();

            for (int i = 0; i < notifications.Count; i++)
            {
                this.lstRecentActivity.Items.Add(list[i]);
            }
        }

        // Method used to add notifications to the users' recent activity tab:

        public void CreateNotification(string notificationType, string action, string affectedElement)
        {
            string generatedNotification = "";

            switch (action)
            {
                case "add": // User has added a new company / car
                    if (notificationType == "company")
                    {
                        generatedNotification = "You added '" + affectedElement + "' to your company records.";
                    }
                    else
                    {
                        generatedNotification = "You added a new car to '" + affectedElement + "'.";
                    }
                    break;
                case "update": // User has updated a company / car
                    if (notificationType == "company")
                    {
                        generatedNotification = "You updated '" + affectedElement + "' in your company records.";
                    }
                    else
                    {
                        generatedNotification = "You updated a car which belongs to '" + affectedElement + "'.";
                    }
                    break;
                case "view-info": // User has viewed a company's / car's full profile
                    if (notificationType == "company")
                    {
                        generatedNotification = "You viewed the full profile of '" + affectedElement + "'.";
                    }
                    else
                    {
                        generatedNotification = "You viewed the full profile of a car which belongs to '" + affectedElement + "'.";
                    }
                    break;
                case "remove": // User has removed a company / car
                    if (notificationType == "company")
                    {
                        generatedNotification = "You removed '" + affectedElement + "' from your company records.";
                    }
                    else
                    {
                        generatedNotification = "You removed a car from the records of '" + affectedElement + "'.";
                    }
                    break;
                default: // Action performed by the user is unknown
                    generatedNotification = "Unidentified action performed.";
                    break;
            }

            notifications.Add(generatedNotification); // Push the new notification into the implemented list

            UpdateNotifications(notifications); // Refresh the list 
        }

        // User is interacting with the different features of the program (buttons):

        private void btnAddNewCompany_Click(object sender, EventArgs e)
        {
            // Generate a new dynamic form allowing the user to add a new company:

            frmDynamicAddOrUpdate popup = new frmDynamicAddOrUpdate("Add New Company");
            popup.ShowDialog(this);
        }

        public void AddNew(int companyID, string companyName, string companyAddress, string companyPostcode) 
        {
            // Check to see if the list already contains that company:

            bool match = false;

            for (int i = 0; i < companies.Count; i++)
            {
                if (companies[i].GetName().ToUpper() == companyName.ToUpper()) // User has entered a company name that already exists
                {
                    match = true;
                }
            }

            if (!match) // There is not a match - safe to proceed with upload of new company
            {
                this.companies.Add(new Company(companyID, companyName, companyAddress, companyPostcode)); // Add a new company to the list of companies

                // Re-display the updated contents of the companies list:

                this.lstAllCompanies.Items.Clear();
                updateList(companies);

                // Push notification to the user's recent activity:

                CreateNotification("company", "add", companyName);
            }
            else
            {
                MessageBox.Show("It looks like you already have a company with that name stored!"); // Alert the user that they may have a duplicate entry 
            }
        }

        private void btnUpdateCompany_Click(object sender, EventArgs e)
        {
            // Make sure the user has selected a company to update:

            if (this.lstAllCompanies.SelectedIndex == -1) // User has not selected a company
            {
                MessageBox.Show("Make sure you select a company to edit."); // Alert the user
            }
            else
            {
                // Generate a new dynamic for allowing the user to edit a previous company's information:

                frmDynamicAddOrUpdate popup = new frmDynamicAddOrUpdate("Update Company Information", companies[lstAllCompanies.SelectedIndex]);
                popup.ShowDialog(this);
            }
        }

        public void UpdateCompany(Company oldRecord, int newCompanyID, string newCompanyName, string newCompanyAddress, string newCompanyPostcode)
        {
            // Update old records:

            oldRecord.SetId(newCompanyID);
            oldRecord.SetName(newCompanyName);
            oldRecord.SetAddress(newCompanyAddress);
            oldRecord.SetPostcode(newCompanyPostcode);

            //Display the updated company information:

            this.lstAllCompanies.Items.Clear();
            updateList(companies);

            // Push notification to the user's recent activity:

            CreateNotification("company", "update", oldRecord.GetName());
        }

        private void btnOpenCompany_Click(object sender, EventArgs e)
        {
            if (this.lstAllCompanies.SelectedIndex == -1) // User has not selected a compay's profile to view 
            {
                MessageBox.Show("Make sure you select a company to view."); // Alert the user
            }
            else 
            {
                // Push notification to user's recent activity:

                CreateNotification("company", "view-info", companies[this.lstAllCompanies.SelectedIndex].GetName());

                // Generate form allowing the user to view the selected company's full profile:

                frmCompanyProfile popup = new frmCompanyProfile(companies[this.lstAllCompanies.SelectedIndex]);
                popup.Show(this);
            }
        }

        private void btnRemoveCompany_Click(object sender, EventArgs e)
        {
            // Make sure the user has selected a company to remove:

            if (this.lstAllCompanies.SelectedIndex == -1) // User has not selected a company
            {
                MessageBox.Show("Make sure you select a company to remove."); // Alert the user
            }
            else
            {
                // Push notification to the user's recent activity:

                CreateNotification("company", "remove", companies[this.lstAllCompanies.SelectedIndex].GetName());

                // Proceed with deletion of selected company:

                this.companies.Remove(companies[this.lstAllCompanies.SelectedIndex]);

                //Display the updated company information:

                this.lstAllCompanies.Items.Clear();
                updateList(companies);
            }
        }

        private void search(string userInput, List<Company> list, ListBox lstBox)
        {
            bool match = false; 

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].GetName().ToUpper() == userInput)
                {
                    match = true;
                }
            }

            // CARRY ON FROM HERE
        }

        private void btnSearchCompanies_Click(object sender, EventArgs e) // User wants to search for a company
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

            this.search(userInput, this.companies, this.lstAllCompanies); // Search for a matching element
        }

        private void btnSearchRecentActivity_Click(object sender, EventArgs e) // User wants to search through their recent activity 
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

            this.search(userInput, this.companies, this.lstRecentActivity); // Search for a matching element
        }
    }
}
