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
        // 2D array list containing cars within specific companies:

        List<Company> companies = new List<Company>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Generate some random companies to work with (dev purposes):

            for (int i = 0; i < 10; i++)
            {
                companies.Add(new Company(i + 1, "Company: " + (i + 1), "Example address", "Example postcode"));
            }

            // Display these new values to the list box displaying all companies:

            for (int i = 0; i < companies.Count; i++)
            {
                this.lstAllCompanies.Items.Add(companies[i].PrintSummary());
            }
        }

        // User is interacting with the different features of the program (buttons):

        private void btnAddNewCompany_Click(object sender, EventArgs e)
        {

        }

        public void AddNew()
        {

        }

        private void btnUpdateCompany_Click(object sender, EventArgs e)
        {

        }

        public void Update()
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
