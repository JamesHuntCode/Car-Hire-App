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
    public partial class frmConfirmation : Form
    {
        public frmConfirmation()
        {
            InitializeComponent();

            // Set up the color layout of the form - (#333 = graphite):
            this.BackColor = ColorTranslator.FromHtml("#333");
            foreach (Label l in Controls.OfType<Label>())
            {
                l.ForeColor = Color.DarkOrange;
            }

            // Optional code (run if in Smeaton)

            /*foreach (Button b in Controls.OfType<Button>())
            {
                b.ForeColor = Color.White;
            }*/

            this.lblHeader.ForeColor = Color.DarkOrange;
            this.lblExtraInfo.ForeColor = Color.DarkOrange;
        }

        private void button1_Click(object sender, EventArgs e) // User wants to clear their data
        {
            frmMain frmMain = (frmMain)this.Owner; // Set main form as parent form

            frmMain.RemoveAllData(); 

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) // User does not want to lose any data
        {
            this.Close(); // Close form and do not remove any data
        }
    }
}
