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
    public partial class frmAboutProgram : Form
    {
        FileServices myServices = new FileServices();

        public frmAboutProgram()
        {
            InitializeComponent();

            // Apply color change:
            this.colorForm();
            this.displaySupportDocument();
            this.txtDisplaySupport.ReadOnly = true;
            this.txtDisplaySupport.SelectionAlignment = HorizontalAlignment.Center;
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

        // Read software support manual into program
        private void displaySupportDocument()
        {
            if (File.Exists(Environment.CurrentDirectory + @"/SoftwareSupport.txt"))
            {
                try
                {
                    string[] softwareSupportDocumentText = File.ReadAllLines(Environment.CurrentDirectory + @"/SoftwareSupport.txt");

                    for (int i = 0; i < softwareSupportDocumentText.Length; i++)
                    {
                        this.txtDisplaySupport.Text += softwareSupportDocumentText[i];
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("An error has occured. Error Code: " + err.Message + " We apologise for an inconveniences this may have caused you.");
                }
            }
            else
            {
                MessageBox.Show("Oops! It looks like your software support manual cannot be located. We apologise for any inconveniences caused.");
            }
        }
    }
}
