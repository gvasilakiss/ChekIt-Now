using AtleX.HaveIBeenPwned;
using System;
using System.Drawing;
using System.Windows.Forms;
using Virus_Checker.Properties;

namespace Virus_Checker
{
    public partial class password : Form
    {
        
        public password()
        {
            InitializeComponent();
        }

        private void email_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            // screen move
            //this.Location = Screen.AllScreens[1].WorkingArea.Location;
        }

        // Closes current form and opens the new one
        private void btn_Home_Click_1(object sender, EventArgs e)
        {
            Hide();
            Formhome f2 = new Formhome();
            f2.ShowDialog();
            Close();
        }
        // menu item
        private void btn_menu_pwned_Click_1(object sender, EventArgs e)
        {
            Hide();
            Email_Check f1 = new Email_Check();
            f1.ShowDialog();
            Close();
        }

        //about us 
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutbox = new AboutBox1();
            aboutbox.ShowDialog();
        }

        private async void btnPassCheck_ClickAsync(object sender, EventArgs e)
        {
            // clear, hide or show: lbl, combobox, list depending on button option
            txtBox_pwned_password.UseSystemPasswordChar = true;
            lbl_Result.ResetText();
            lstAddBreaches.Show();
            lstAddBreaches.Items.Clear();

            // Create the client
            var settings = new HaveIBeenPwnedClientSettings
            {
                ApiKey = "d91cb625d970470989710abfb88241fb",
                ApplicationName = "Virus_Finder"
            };

            using (var client = new HaveIBeenPwnedClient(settings))
            {
                // Verify whether password is Pawned or not
                try
                {
                    var isPwned = await client.IsPwnedPasswordAsync(txtBox_pwned_password.Text);

                    switch (isPwned)
                    {
                        case true:
                            // picDisplay.Image = Virus_Checker.Properties.Resources.virus1;
                            lbl_Result.ForeColor = Color.FromArgb(234, 75, 46);
                            lbl_Result.Text = @"Your password HAS been leaked online";
                            // MessageBox.Show("You password has been pawned!");
                            break;

                        default:
                            lbl_Result.ForeColor = Color.FromArgb(67, 186, 100);
                            lbl_Result.Text = @"Your password has NOT been leaked online";
                            // MessageBox.Show("You password is secure.");
                            break;
                    }
                }
                catch (Exception)
                {
                    if (txtBox_pwned_password.Text == "")
                    {
                        lbl_Result.ForeColor = Color.FromArgb(234, 75, 46);
                        lbl_Result.Text = @"Input can't be empty, enter your password to continue";
                    }
                }

                // Clear the text box once the code has ran. This makes it clear for the next input
                txtBox_pwned_password.Clear();
            }
        }

        private void btn_menu_info_Click(object sender, EventArgs e)
        {
            Hide();
            staysafe f4 = new staysafe();
            f4.ShowDialog();
        }

   
        // version box
        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutbox = new AboutBox1();
            aboutbox.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Declare a DialogResult variable
            DialogResult drReply = MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drReply == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            credits newcredits = new credits();
            newcredits.ShowDialog();
        }

        private void password_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                e.Cancel = MessageBox.Show(@"Do you really want to close the form?",
                                           Application.ProductName,
                                           MessageBoxButtons.YesNo) == DialogResult.No;
        }

        private void password_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void reportABugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/dansailorsav1/chekit/issues");
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}