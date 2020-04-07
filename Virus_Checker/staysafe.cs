using System;
using System.Windows.Forms;
using System.Threading;

namespace Virus_Checker
{
    public partial class staysafe : Form
    {
        
        public staysafe()
        {
            InitializeComponent();
            
        }

        

        private void staysafe_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            // screen move
           
            // Loop the circle to end at the percentage block
            for (int i = 1; i < 78; i++)
            {
                circlepro_One.Value = i;
                circlepro_One.Update();
                

            }

            for (int i = 1; i < 56; i++)
            {
                circlepro_Two.Value = i;
                circlepro_Two.Update();
                

            }

            for (int i = 1; i < 68; i++)
            {
                circlepro_Three.Value = i;
                circlepro_Three.Update();
                

            }
        }

        

        // menu item
        private void btn_Home_Click(object sender, EventArgs e)
        {
            Hide();
            Formhome f2 = new Formhome();
            f2.ShowDialog();
            Close();
        }
        // menu item
        private void btn_Pass_Click(object sender, EventArgs e)
        {
            Hide();
            password f3 = new password();
            f3.ShowDialog();
        }
        // menu item
        private void btn_menu_pwned_Click(object sender, EventArgs e)
        {
            Hide();
            Email_Check f1 = new Email_Check();
            f1.ShowDialog();
        }
        
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutbox = new AboutBox1();
            aboutbox.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            // Declare a DialogResult variable
            DialogResult drReply = MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drReply == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        
        // This is the bottom left exit, for some reason the name won't update.
        private void button4_Click(object sender, EventArgs e)
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

        private void staysafe_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                e.Cancel = MessageBox.Show(@"Do you really want to close the form?",
                                           Application.ProductName,
                                           MessageBoxButtons.YesNo) == DialogResult.No;
        }

        private void staysafe_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void reportABugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/dansailorsav1/chekit/issues");
        }

        private void btnSite_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://chekitnow.co.uk");
        }
    }
}