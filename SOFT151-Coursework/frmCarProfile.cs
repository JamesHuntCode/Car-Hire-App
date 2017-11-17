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
    public partial class frmCarProfile : Form
    {
        private Car currentCar;
        public frmCarProfile(Car car)
        {
            InitializeComponent();

            // Display all of the car's information in the form:

            this.lblCarId.Text = "Car ID: " + Convert.ToString(car.GetId());
            this.lblCarMake.Text = "Car Make: " + car.GetMake();
            this.lblCarModel.Text = "Car Model: " + car.GetModel();
            this.lblCarReg.Text = "Car Registration: " + car.GetReg();
            this.lblCarFuelType.Text = "Fuel Type: " + car.GetFuelType();
            this.lblLastServiced.Text = "Last Serviced: " + Convert.ToString(car.GetDateLastServiced().ToShortDateString());
            this.txtComments.Text = car.GetComments();

            currentCar = car;

            // Set up the color layout of the form:

            Color myBG = ColorTranslator.FromHtml("#333");

            this.BackColor = myBG;

            foreach (Label l in Controls.OfType<Label>())
            {
                l.ForeColor = Color.Orange;
            }
        }
    }
}
