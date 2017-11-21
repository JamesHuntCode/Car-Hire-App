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
    public partial class frmDynamicAddOrUpdate : Form
    {
        Company currentCompany;
        public frmDynamicAddOrUpdate(string formName, Company company = null)
        {
            InitializeComponent();

            //  Update form information:

            this.Text = formName;
            this.lblHeader.Text = formName;

            currentCompany = company;

            // Load pre-loaded information if the user wants to edit:

            if (formName == "Update Company Information") // Load in current company's information
            {
                this.txtNewID.Text = Convert.ToString(company.GetId());
                this.txtNewName.Text = company.GetName();
                this.txtNewAddress.Text = company.GetAddress();
                this.txtNewPostcode.Text = company.GetPostcode();
            }

            // Set up the color layout of the form:

            this.BackColor = ColorTranslator.FromHtml("#333"); // Change background color to graphite

            foreach (Label l in Controls.OfType<Label>())
            {
                l.ForeColor = Color.DarkOrange;
            }
        }

        // Button Controls:

        private void btnSaveAndUpdate_Click(object sender, EventArgs e) // User wants to update a company
        {
            frmMain frmMain = (frmMain)this.Owner; // Set main form as parent form

            // Gather user inputs and catch any exceptions:

            int newCompanyId = 0;
            string newCompanyName = "";
            string newCompanyAddress = "";
            string newCompanyPostcode = "";

            bool isValid = true;

            try
            {
                newCompanyId = Convert.ToInt32(this.txtNewID.Text);
                newCompanyName = this.txtNewName.Text;
                newCompanyAddress = this.txtNewAddress.Text;
                newCompanyPostcode = this.txtNewPostcode.Text;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message); // Display error message to the user

                isValid = false;
            }

            if (isValid)
            {

                if (this.Text == "Add New Company") // Add new company 
                {
                   bool added = frmMain.AddNew(newCompanyId, newCompanyName, newCompanyAddress, newCompanyPostcode);

                    if (added)
                    {
                        this.Close(); // Close the form after adding new company details
                    }
                }
                else if (this.Text == "Update Company Information") // Edit previous company 
                {
                    bool updated = frmMain.UpdateCompany(currentCompany, newCompanyId, newCompanyName, newCompanyAddress, newCompanyPostcode);

                    if (updated)
                    {
                        this.Close(); // Close the form after updating company details
                    }
                }
            }
        }

        private void btnCancelUpdate_Click(object sender, EventArgs e) // User wants to cancel their choice to update a company's record
        {
            this.Close(); // Close the form and cancel all actions
        }
    }
}
