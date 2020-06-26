using System;
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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            //this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
        }
        private void StartForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome To LeopardAir!");
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.ShowDialog();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Owner = this;
            login.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Thank you! Have a Nice Day!");
        }
    }
}
