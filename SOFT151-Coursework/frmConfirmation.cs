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

            foreach (RadioButton r in Controls.OfType<RadioButton>())
            {
                r.ForeColor = ColorTranslator.FromHtml("#333");
            }
        }

        private void button1_Click(object sender, EventArgs e) // User wants to clear their data
        {
            frmMain frmMain = (frmMain)this.Owner; 

            frmMain.RemoveAllData(); 

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) // User does not want to lose any data
        {
            this.Close(); // Close form and do not remove any data
        }
    }
}
