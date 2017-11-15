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
    public partial class frmCompanyProfile : Form
    {
        Company viewMe;

        public frmCompanyProfile(Company company)
        {
            InitializeComponent();

            // Display correct compay details in the form:

            this.Text = company.GetName() + " Full Profile.";
            this.lblCompanyName.Text = "Name: " + company.GetName();
            this.lblCompanyId.Text = "ID: " + Convert.ToString(company.GetId());
            this.lblCompanyAddress.Text = "Address: " + company.GetAddress();
            this.lblCarCount.Text = "Cars rented: " + Convert.ToString(company.GetNumberOfCars());
            this.lblCompanyPostcode.Text = "Postcode: " + company.GetPostcode();

            // Display all of the companies cars:

            List<Car> companyCars = company.GetAllCars();

            for (int i = 0; i < companyCars.Count; i++)
            {
                this.lstListCompanyCars.Items.Add(companyCars[i].PrintSummary());
            }

            viewMe = company;
        }

        // User is interacting with the buttons on the form:

        private void btnAddNewCar_Click(object sender, EventArgs e) // User wants to add a new car to the company's records
        {

        }

        private void btnUpdateCar_Click(object sender, EventArgs e) // User wants to update a car's details
        {

        }

        private void btnDeleteCar_Click(object sender, EventArgs e) // User wants to remove a car from the company's records
        {

        }

        private void btnMakeComments_Click(object sender, EventArgs e) // User wants to make comments about a specific car
        {

        }
    }
}
