using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEOPARDAIR_SYSTEM
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        
            tbxID.Enabled = false;
            tbxPassword.Enabled = false;
            lblIC.Visible = false;
            lblEmail.Visible = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            try
            {
                if (tbxName.Text != "" &&
                    (tbxIC.Text.IndexOf("-") == 6) &&
                    (tbxIC.Text.LastIndexOf("-") == 9) &&
                    (tbxIC.Text.IndexOf("-") != -1) &&
                    (tbxEmail.Text.IndexOf("@") != -1) &&
                    (tbxEmail.Text.IndexOf(".") != -1) &&
                    (tbxEmail.Text.IndexOf("@") == tbxEmail.Text.LastIndexOf("@")) &&
                    (tbxEmail.Text.IndexOf(".") == tbxEmail.Text.LastIndexOf(".")) &&
                    (tbxEmail.Text.IndexOf("@") < tbxEmail.Text.LastIndexOf(".")) &&
                    (rbnMale.Checked || rbnFemale.Checked))

                {
                    StreamWriter writer = new StreamWriter("Member.txt", true);
                   
                    writer.WriteLine(tbxName.Text);
                    writer.WriteLine(tbxIC.Text);
                    writer.WriteLine(tbxEmail.Text);

                    if (rbnMale.Checked)
                        writer.WriteLine("Male");
                    if (rbnFemale.Checked)
                        writer.WriteLine("Female");

                    Random rand1 = new Random();
                    int num1 = rand1.Next(1000, 1110);
                    int num2 = rand1.Next(1111, 9999);

                    tbxID.Text = Convert.ToString(num1);
                    tbxPassword.Text = Convert.ToString(num2);
         
                    writer.WriteLine(tbxID.Text);
                    writer.WriteLine(tbxPassword.Text);

                    int points = 0;
                    writer.WriteLine(points);
                    writer.WriteLine("");

                    writer.Close();

                    MessageBox.Show("Submit successfully");
                    MessageBox.Show("Please collect your User ID and Password." +
                                    "\n\nUser ID\t : " + tbxID.Text +
                                    "\nPassword : " + tbxPassword.Text +
                                    "\n\nThank you.");

                    tbxName.Clear();
                    tbxIC.Clear();
                    tbxEmail.Clear();
                    rbnMale.Checked = false;
                    rbnFemale.Checked = false;
                    tbxID.Clear();
                    tbxPassword.Clear();
                }

                else
                {
                    if ((tbxEmail.Text.IndexOf("@") != tbxEmail.Text.LastIndexOf("@")) ||
                        (tbxEmail.Text.IndexOf(".") != tbxEmail.Text.LastIndexOf(".")) ||
                        (tbxEmail.Text.IndexOf("@") >= tbxEmail.Text.LastIndexOf(".")) ||
                        (tbxEmail.Text.IndexOf("@") == -1) ||
                        (tbxEmail.Text.IndexOf(".") == -1))
                    {
                        lblEmail.Visible = true;
                        tbxEmail.Clear();
                    }

                    if ((tbxIC.Text.IndexOf("-") != 6) &&
                        (tbxIC.Text.LastIndexOf("-") != 9))
                    {
                        lblIC.Visible = true;
                        tbxIC.Clear();
                    }

                    if (tbxName.Text == " " || tbxIC.Text == " " || tbxEmail.Text == " " || !(rbnMale.Checked || rbnFemale.Checked))
                        MessageBox.Show("Please fill in the form completely.");
                }
            }

            catch (IOException exc)
            {
                MessageBox.Show("File error: " + exc.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
}
