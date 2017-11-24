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
    public partial class frmAboutProgram : Form
    {
        public frmAboutProgram()
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
        }
    }
}
