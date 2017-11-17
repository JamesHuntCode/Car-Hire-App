﻿using System;
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

        private List<Company> companySearchResults = new List<Company>(); // List of all search results (company based)

        private List<string> recentActivitySearchResults = new List<string>(); // List of all search results (notifications)

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

            // Set up the color layout of the application:

            System.Drawing.Color myBG = System.Drawing.ColorTranslator.FromHtml("#333");

            this.BackColor = myBG;

            foreach (Label l in Controls.OfType<Label>())
            {
                l.ForeColor = Color.Orange;
            }
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

            for (int i = 0; i < this.notifications.Count; i++)
            {
                this.lstRecentActivity.Items.Add(list[i]);
            }
        }

        // Method used to add notifications to the users' recent activity tab:

        public void CreateNotification(string notificationType, string action, string affectedElement, string theTime)
        {
            string generatedNotification = "";

            switch (action)
            {
                case "add": // User has added a new company / car
                    if (notificationType == "company")
                    {
                        generatedNotification = "You added '" + affectedElement + "' to your company records @ " + theTime + ".";
                    }
                    else
                    {
                        generatedNotification = "You added a new car to '" + affectedElement + "' @ " + theTime + ".";
                    }
                    break;
                case "update": // User has updated a company / car
                    if (notificationType == "company")
                    {
                        generatedNotification = "You updated '" + affectedElement + "' in your company records @ " + theTime + ".";
                    }
                    else
                    {
                        generatedNotification = "You updated a car which belongs to '" + affectedElement + "' @ " + theTime + ".";
                    }
                    break;
                case "view-info": // User has viewed a company's / car's full profile
                    if (notificationType == "company")
                    {
                        generatedNotification = "You viewed the full profile of '" + affectedElement + "' @ " + theTime + ".";
                    }
                    else
                    {
                        generatedNotification = "You viewed the full profile of a car which belongs to '" + affectedElement + "' @ " + theTime + ".";
                    }
                    break;
                case "remove": // User has removed a company / car
                    if (notificationType == "company")
                    {
                        generatedNotification = "You removed '" + affectedElement + "' from your company records @ " + theTime + ".";
                    }
                    else
                    {
                        generatedNotification = "You removed a car from the records of '" + affectedElement + "'.";
                    }
                    break;
                default: // Action performed by the user is unknown
                    generatedNotification = "Unidentified action performed @ " + theTime + ".";
                    break;
            }

            this.notifications.Add(generatedNotification); // Push the new notification into the implemented list

            this.UpdateNotifications(notifications); // Refresh the list 
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

            for (int i = 0; i < this.companies.Count; i++)
            {
                if (this.companies[i].GetName().ToUpper() == companyName.ToUpper()) // User has entered a company name that already exists
                {
                    match = true;
                }
            }

            if (!match) // There is not a match - safe to proceed with upload of new company
            {
                this.companies.Add(new Company(companyID, companyName, companyAddress, companyPostcode)); // Add a new company to the list of companies

                // Re-display the updated contents of the companies list:

                this.lstAllCompanies.Items.Clear();
                this.updateList(companies);

                // Push notification to the user's recent activity:

                this.CreateNotification("company", "add", companyName, DateTime.Now.ToShortTimeString());
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

            this.CreateNotification("company", "update", oldRecord.GetName(), DateTime.Now.ToShortTimeString());
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

                CreateNotification("company", "view-info", this.companies[this.lstAllCompanies.SelectedIndex].GetName(), DateTime.Now.ToShortTimeString());

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

                this.CreateNotification("company", "remove", companies[this.lstAllCompanies.SelectedIndex].GetName(), DateTime.Now.ToShortTimeString());

                // Proceed with deletion of selected company:

                this.companies.Remove(companies[this.lstAllCompanies.SelectedIndex]);

                //Display the updated company information:

                this.lstAllCompanies.Items.Clear();
                this.updateList(companies);
            }
        }

        private void searchCompanies(string userInput, List<Company> list, ListBox lstBox) // Method used to search through the companies list and dispay results
        {
            this.companySearchResults.Clear();

            bool match = false;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].GetName().ToUpper() == userInput.ToUpper())
                {
                    match = true;

                    this.companySearchResults.Add(list[i]);
                }
            }

            if (!match) // Dispay no results message (there has not been a match)
            {
                lstBox.Items.Clear();

                lstBox.Items.Add("Oops! No companies found! Click refresh and try again.");
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

        private void searchNotifications(string userInput, List<string> list, ListBox lstBox) // Method used to search through the notifications list and display results
        {
            this.recentActivitySearchResults.Clear();

            bool match = false;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Contains(userInput))
                {
                    match = true;

                    this.recentActivitySearchResults.Add(list[i]);
                }
            }

            if (!match)
            {
                lstBox.Items.Clear();

                lstBox.Items.Add("Oops! No recent activity like that has been found! Click refresh and try again.");
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

            this.searchCompanies(userInput, this.companies, this.lstAllCompanies); // Search for a matching element
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

            this.searchNotifications(userInput, this.notifications, this.lstRecentActivity); // Search for a matching element
        }

        private void btnRefreshCompanies_Click(object sender, EventArgs e) // User wants to refresh their list of companies
        {
            this.lstAllCompanies.Items.Clear();
            this.companySearchResults.Clear();

            for (int i = 0; i < this.companies.Count; i++)
            {
                this.lstAllCompanies.Items.Add(this.companies[i].PrintSummary());
            }
        }

        private void btnRefreshNotifications_Click(object sender, EventArgs e) // User wants to refresh their notifications tab
        {
            this.lstRecentActivity.Items.Clear();
            this.recentActivitySearchResults.Clear();

            for (int i = 0; i < this.notifications.Count; i++)
            {
                this.lstRecentActivity.Items.Add(this.notifications[i]);
            }
        }
    }
}
