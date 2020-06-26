using System;
using System.IO;
using System.Collections;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            ArrayList memberlist = new ArrayList();

            if (File.Exists("Member.txt"))
            {
                try
                {
                    StreamReader reader = new StreamReader("Member.txt");

                    string name, ic, email, gender, id, password;
                    string points;
                    bool found = false;     

                    name = reader.ReadLine();
                    do
                    {
                        ic = reader.ReadLine();
                        email = reader.ReadLine();
                        gender = reader.ReadLine();
                        id = reader.ReadLine();
                        password = reader.ReadLine();
                        points = reader.ReadLine();

                        if (tbxPassword.Text == password && tbxID.Text == id)
                        {
                            found = true;
                            memberlist.Add(new MemberWithoutPurchased(name, ic, email, gender, id, password, Convert.ToInt32(points)));

                            MemberWithoutPurchased memberwithoutpurchased = (MemberWithoutPurchased)memberlist[memberlist.Count - 1];

                            MessageBox.Show("Welcome " + memberwithoutpurchased.Name);

                            btnLogin.Enabled = false;
                            tbxID.Enabled = false;
                            tbxPassword.Enabled = false;

                        }
                        name = reader.ReadLine();
                    } while ((name = reader.ReadLine()) != null);

                    if (found == true)
                    {
                        reader.Close();

                        (this.Owner as StartForm).Hide();

                        MenuForm menu = new MenuForm();
                        menu.receive_info(memberlist);
                        menu.Show();
                        Close();
                    }

                    if (found == false)
                    {
                        tbxID.Clear();
                        tbxPassword.Clear();
                        MessageBox.Show("Invalid UserID or Password");
                    }
                }

                catch (IOException exc)
                {
                    MessageBox.Show("File error:" + exc.Message);
                }
            }

            else
            {
                MessageBox.Show("File does not exists.");
            }
        }
    }
}
