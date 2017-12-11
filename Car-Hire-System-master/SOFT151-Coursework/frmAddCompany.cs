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
    public partial class frmAddCompany : Form
    {
        public frmAddCompany()
        {
            InitializeComponent();
            this.Text = "Add New Company";
            this.lblHeader.Text = "Add New Company:";
         
            Timer unlockButton = new Timer();
            unlockButton.Interval = 10;
            unlockButton.Tick += new EventHandler(unlockButton_Tick);
            unlockButton.Start();
     
            // Apply color change:
            this.colorForm();
        }

        // Timer used to check if all fields are populated
        private void unlockButton_Tick(object sender, EventArgs e)
        {
            // Enable / disable add button
            if (this.txtNewID.Text.Length < 1 || this.txtNewName.Text.Length < 2 || this.txtNewAddress.Text.Length < 7 || this.txtNewPostcode.Text.Length < 6)
            {
                this.btnSaveAndUpdate.Enabled = false;
            }
            else
            {
                this.btnSaveAndUpdate.Enabled = true;
            }

            // Color code fields
            this.colorFields();
        }

        // Display tick when field condition is met
        private void highlightGreen(PictureBox picBox)
        {
            picBox.Image = Image.FromFile("green-tick.png");
        }

        // Display cross when condition not met
        private void highlightRed(PictureBox picBox)
        {
            picBox.Image = Image.FromFile("red-cross.png");
        }

        // Display null image when text.length = 0
        private void nullImage(PictureBox picBox)
        {
            picBox.Image = null;
        }

        // Method to check input fields and inform user
        private void colorFields()
        {
            // ID field
            if (this.txtNewID.Text.Length >= 1)
            {
                this.highlightGreen(this.picID);
            }
            else
            {
                this.nullImage(this.picID);
            }

            // Name field
            if (this.txtNewName.Text.Length >= 2) 
            {
                this.highlightGreen(this.picName);
            }
            else if (this.txtNewName.Text.Length != 0 && this.txtNewName.Text.Length < 2)
            {
                this.highlightRed(this.picName);
            }
            else
            {
                this.nullImage(this.picName);
            }

            // Address field
            if (this.txtNewAddress.Text.Length >= 7)
            {
                this.highlightGreen(this.picAddress);
            }
            else if (this.txtNewAddress.Text.Length != 0 && this.txtNewAddress.Text.Length < 7)
            {
                this.highlightRed(this.picAddress);
            }
            else
            {
                this.nullImage(this.picAddress);
            }

            // Postcode field
            if (this.txtNewPostcode.Text.Length >= 6)
            {
                this.highlightGreen(this.picPostcode);
            }
            else if (this.txtNewPostcode.Text.Length != 0 && this.txtNewPostcode.Text.Length < 6)
            {
                this.highlightRed(this.picPostcode);
            }
            else
            {
                this.nullImage(this.picPostcode);
            }
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
