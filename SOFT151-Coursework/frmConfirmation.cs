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

            Color myBG = ColorTranslator.FromHtml("#333"); // Change background color to graphite

            this.BackColor = myBG;

            this.lblHeader.ForeColor = Color.DarkOrange;
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
