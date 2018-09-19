using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlexAPI;
using Test;

namespace Plex
{
    public partial class FrmLogin : Form
    {
        static MyPlex myplex;
        static User user;

        public FrmLogin()
        {
            InitializeComponent();
        }

		// Sign in button handler
        private void BtnSignin_Click(object sender, EventArgs e)
        {
            myplex = new MyPlex();
            user = myplex.Authenticate(TxtUsername.Text, TxtPassword.Text);
			// API will return a user object with a non-null email if the login was successful
            if(user.email == null)
            {
                MessageBox.Show("Invalid credentials. Please try again.");
                TxtUsername.Text = "";
            }
            else
            {
                FrmHome home = new FrmHome(user);
                home.Show();
                this.Hide();
            }
        }
		
		// Sign in button only enabled if username and password fields are not empty
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if((TxtUsername.Text.Length > 0) && (TxtPassword.Text.Length > 0))
            {
                BtnSignin.Enabled = true;
            }
            else
            {
                BtnSignin.Enabled = false;
            }
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if ((TxtUsername.Text.Length > 0) && (TxtPassword.Text.Length > 7))
            {
                BtnSignin.Enabled = true;
            }
            else
            {
                BtnSignin.Enabled = false;
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
	}
}
