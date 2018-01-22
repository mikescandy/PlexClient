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

namespace Plex
{
    public partial class FrmLogin : Form
    {
        static MyPlex plex;
        static User user;
        //string usernamePlaceholder = "Username", passwordPlaceholder = "Password";
        public FrmLogin()
        {
            InitializeComponent();
            BtnSignin.BackColor = Color.FromArgb(251, 207, 77);
        }
        private void BtnSignin_Click(object sender, EventArgs e)
        {
            // TODO un-enable sign in button after debugging
            BtnSignin.Text = "Loading...";
            BtnSignin.BackColor = Color.LightGray;
            /*
             * Logs in too quickly to make much use of this but I spend too much time on it to delete it.
            FrmLoading loadscreen = new FrmLoading();
            loadscreen.Show();
            */
            plex = new MyPlex();
            user = plex.Authenticate(TxtUsername.Text, TxtPassword.Text);
            if(user.email == null)
            {
                //loadscreen.Dispose();
                MessageBox.Show("Invalid credentials. Please try again.");
                TxtUsername.Text = "";
                TxtPassword.Text = "";
                BtnSignin.Text = "Sign In";
                BtnSignin.BackColor = Color.FromArgb(251, 207, 77);
            }
            else
            {
                FrmHome home = new FrmHome(user);
                //loadscreen.Dispose();
                home.Show();
                this.Hide();
            }
        }

        /*
        txtUsername.GotFocus += new EventHandler(userTextboxFocus);
        txtUsername.LostFocus += new EventHandler(userTextboxLostFocus);
        txtPassword.GotFocus += new EventHandler(userTextboxFocus);
        txtPassword.LostFocus += new EventHandler(userTextboxLostFocus);
        */

        // TODO combine redundant event handlers
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if((TxtUsername.Text.Length > 0) && (TxtPassword.Text.Length > 7))
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
        /*
private void userTextboxFocus(Object sender, EventArgs e)
{
txtUsername.Text = "";
}
private void userTextboxLostFocus(Object sender, EventArgs e)
{
if (string.IsNullOrWhiteSpace(txtUsername.Text))
{
txtUsername.Text = usernamePlaceholder;
}
}
private void pwTextboxFocus(Object sender, EventArgs e)
{
txtPassword.PasswordChar = '•';
txtPassword.Text = "";
}
private void pwTextboxLostFocus(Object sender, EventArgs e)
{
if (string.IsNullOrWhiteSpace(txtPassword.Text))
{
txtPassword.PasswordChar = '\0';
txtPassword.Text = passwordPlaceholder;
}
}
*/
    }
}
