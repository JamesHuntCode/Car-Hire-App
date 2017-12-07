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
    public partial class frmAddCompany : Form
    {
        public frmAddCompany()
        {
            InitializeComponent();
            this.Text = "Add New Company";
            this.lblHeader.Text = "Add New Company:";
     
            // Apply color change:
            this.colorForm();
        }

        // Method used to apply correct color scheme to form
        private void colorForm()
        {
            // #EAEAEA = Light Grey
            // #333 = Graphite
            // #ffffff = White
            // #31708E = Light Blue

            this.BackColor = ColorTranslator.FromHtml("#EAEAEA");
            foreach (Label l in Controls.OfType<Label>())
            {
                l.ForeColor = ColorTranslator.FromHtml("#333");
            }

            foreach (Button b in Controls.OfType<Button>())
            {
                b.ForeColor = ColorTranslator.FromHtml("#ffffff");
                b.BackColor = ColorTranslator.FromHtml("#31708E");
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
                MessageBox.Show(err.Message); 

                isValid = false;
            }

            if (isValid)
            {
                bool added = frmMain.AddNewCompany(newCompanyId, newCompanyName, newCompanyAddress, newCompanyPostcode);

                if (added)
                {
                    this.Close(); // Close the form after adding new company details
                }
            }
        }

        private void btnCancelUpdate_Click(object sender, EventArgs e) // User wants to cancel their choice to update a company's record
        {
            this.Close(); // Close the form and cancel all actions
        }
    }
}
