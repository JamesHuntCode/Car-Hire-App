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

            updateList(0, companies);
        }

        private void updateList(int startFrom, List<Company> list) // Method used to loop over the contents of the companies list and display all contents
        {
            for (int i = startFrom; i < list.Count; i++)
            {
                this.lstAllCompanies.Items.Add(list[i].PrintSummary());
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
            this.companies.Add(new Company(companyID, companyName, companyAddress, companyPostcode)); // Add a new company to the array list of companies

            // Re-display the updated contents of the companies list:

            updateList((companies.Count - 2), companies);
        }

        private void btnUpdateCompany_Click(object sender, EventArgs e)
        {
            // Generate a new dynamic for allowing the user to edit a previous company's information:

            frmDynamicAddOrUpdate popup = new frmDynamicAddOrUpdate("Update Company Information");
            popup.ShowDialog(this);
        }

        public void UpdateCompany()
        {
            
        }

        private void btnOpenCompany_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveCompany_Click(object sender, EventArgs e)
        {

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
