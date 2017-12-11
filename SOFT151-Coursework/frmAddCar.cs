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
    public partial class frmAddCar : Form
    {
        public frmAddCar()
        {
            InitializeComponent();
            this.Text = "Add New Car";
            this.lblHeader.Text = "Add New Car:";
            this.radDiesel.Select();
            this.dtpLastServiced.MaxDate = DateTime.Today; // Limit max date to today

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
            if (this.txtCarID.Text.Length < 1 || this.txtCarMake.Text.Length < 3 || this.txtCarModel.Text.Length < 3 || this.txtCarReg.Text.Length < 3 || (!this.radDiesel.Checked && !this.radPetrol.Checked))
            {
                this.btnSaveAndUpdate.Enabled = false;
                this.btnSaveAndUpdate.BackColor = Color.FromArgb(75, ColorTranslator.FromHtml("#31708E"));
            }
            else
            {
                this.btnSaveAndUpdate.Enabled = true;
                this.btnSaveAndUpdate.BackColor = ColorTranslator.FromHtml("#31708E");
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
            if (this.txtCarID.Text.Length >= 1)
            {
                this.highlightGreen(this.picID);
            }
            else
            {
                this.nullImage(this.picID);
            }

            // Make field
            if (this.txtCarMake.Text.Length >= 3)
            {
                this.highlightGreen(this.picManufacturer);
            }
            else if (this.txtCarMake.Text.Length != 0 && this.txtCarMake.Text.Length < 3)
            {
                this.highlightRed(this.picManufacturer);
            }
            else
            {
                this.nullImage(this.picManufacturer);
            }

            // Model field
            if (this.txtCarModel.Text.Length >= 3) 
            {
                this.highlightGreen(this.picModel);
            }
            else if (this.txtCarModel.Text.Length != 0 && this.txtCarModel.Text.Length < 3)
            {
                this.highlightRed(this.picModel);
            }
            else
            {
                this.nullImage(this.picModel);
            }

            // Reg field
            if (this.txtCarReg.Text.Length >= 3)
            {
                this.highlightGreen(this.picReg);
            }
            else if (this.txtCarReg.Text.Length != 0 && this.txtCarReg.Text.Length < 3)
            {
                this.highlightRed(this.picReg);
            }
            else
            {
                this.nullImage(this.picReg);
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

            foreach (RadioButton r in Controls.OfType<RadioButton>())
            {
                r.ForeColor = ColorTranslator.FromHtml("#333");
            }
        }

        // Button Controls:

        private void btnSaveAndUpdate_Click(object sender, EventArgs e)
        {
            frmMain mainForm = (frmMain)this.Owner;

            // Gather user inputs and catch any exceptions:
            int newCarId = 0;
            string newCarMake = "";
            string newCarModel = "";
            string newCarReg = "";
            string newCarFuelType = "";
            DateTime newDateLastServiced = new DateTime();
            string newComments = "";

            bool isValid = true;

            try
            {
                newCarId = Convert.ToInt32(this.txtCarID.Text);
                newCarMake = this.txtCarMake.Text;
                newCarModel = this.txtCarModel.Text;
                newCarReg = this.txtCarReg.Text;
                if (this.radPetrol.Checked)
                {
                    newCarFuelType = "petrol";
                }
                else if (this.radDiesel.Checked)
                {
                    newCarFuelType = "diesel";
                }
                newDateLastServiced = this.dtpLastServiced.Value;
                newComments = this.txtComments.Text;
            }
            catch (Exception err)
            {
                isValid = false;
                
                MessageBox.Show(err.Message);
            }

            if (isValid)
            {
                bool added = mainForm.AddNewCar(new Car(newCarId, newCarMake, newCarModel, newCarReg, newCarFuelType, newDateLastServiced, newComments));

                if (added)
                {
                    this.Close(); // Close the form after adding new car details
                }
            }
        }

        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form and cancel all actions
        }
    }
}
