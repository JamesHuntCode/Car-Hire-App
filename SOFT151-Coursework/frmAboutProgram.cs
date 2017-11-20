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

            Color myBG = ColorTranslator.FromHtml("#333"); // Change background color to graphite

            this.BackColor = myBG;

            foreach (Label l in Controls.OfType<Label>()) // Change all label elements to orange
            {
                l.ForeColor = Color.DarkOrange;
            }
        }
    }
}
