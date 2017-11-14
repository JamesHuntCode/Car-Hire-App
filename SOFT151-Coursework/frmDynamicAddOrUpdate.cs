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
        public frmDynamicAddOrUpdate(string formName)
        {
            InitializeComponent();

            //  Update form information:

            this.Text = formName;
            this.lblHeader.Text = formName;
        }

        private void frmDynamicAddOrUpdate_Load(object sender, EventArgs e)
        {
            
        }

        // Button Controls:

        private void btnSaveAndUpdate_Click(object sender, EventArgs e) // User wants to update a company
        {
            Form1 frmMain = (Form1)this.Owner; // Set main form as parent form

            // Gather user inputs and catch any exceptions:

            int newCompanyId = 0;
            string newCompanyName = "";
            string newCompanyAddress = "";
            string newCompanyPostcode = "";

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
            }

            frmMain.AddNew(newCompanyId, newCompanyName, newCompanyAddress, newCompanyPostcode);

            this.Close(); // Close the form after adding new company details
        }

        private void btnCancelUpdate_Click(object sender, EventArgs e) // User wants to cancel their choice to update a company's record
        {
            this.Close(); // Close the form and cancel the update
        }
    }
}
