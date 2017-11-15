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
    public partial class Form1 : Form
    {
        List<Company> companies = new List<Company>(); // List of all companies

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Generate some random companies to work with (dev purposes):

            for (int i = 0; i < 10; i++)
            {
                companies.Add(new Company(i + 1, "Company " + (i + 1), "Example address", "Example postcode"));
            }

            // Display these new values to the list box displaying all companies:

            updateList(companies);
        }

        private void updateList(List<Company> list) // Method used to loop over the contents of the companies list and display all contents
        {
            for (int i = 0; i < list.Count; i++)
            {
                this.lstAllCompanies.Items.Add(list[i].PrintSummary());
            }
        }

        // Method used to add notifications to the users' recent activity tab:

        private void createCompanyBasedNotification(string action) 
        {
            switch (action)
            {
                case "add":
                    this.lstRecentActivity.Items.Add("You added a new company to your records.");
                    break;
                case "update":
                    this.lstRecentActivity.Items.Add("You updated a company's information.");
                    break;
                case "view-info":
                    this.lstRecentActivity.Items.Add("You viewed a company's full information profile.");
                    break;
                case "remove":
                    this.lstRecentActivity.Items.Add("You removed a company from your records.");
                    break;
            }
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
                if (companies[i].GetName() == companyName)
                {
                    match = true;
                }
            }

            if (!match) // There is not a match - safe to proceed with upload of new company
            {
                this.companies.Add(new Company(companyID, companyName, companyAddress, companyPostcode)); // Add a new company to the array list of companies

                // Re-display the updated contents of the companies list:

                this.lstAllCompanies.Items.Clear();
                updateList(companies);

                // Push notification to the user's recent activity:

                createCompanyBasedNotification("add");
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

            createCompanyBasedNotification("update");
        }

        private void btnOpenCompany_Click(object sender, EventArgs e)
        {

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
                // Proceed with deletion of selected company:

                this.companies.Remove(companies[this.lstAllCompanies.SelectedIndex]);

                //Display the updated company information:

                this.lstAllCompanies.Items.Clear();
                updateList(companies);

                // Push notification to the user's recent activity:

                createCompanyBasedNotification("remove");
            }
        }

        // User is searching for a company or reading through their recent activity:

        private void txtSearchCompany_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchRecentActivity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
