using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;

namespace Virus_Checker
{
    public partial class Formhome : Form
    {
   
        public Formhome()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
                        
        }

        
        private void btn_Home_Click(object sender, EventArgs e)
        {
            
        }

        // Closes the application
        private void btn_exit_Click(object sender, EventArgs e)
        {
            // Declare a DialogResult variable
            DialogResult drReply = MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drReply == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Minimizes the application
        private void btn_mim_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_menu_pwned_Click(object sender, EventArgs e)
        {
            Hide();
            Email_Check f1 = new Email_Check();
            f1.ShowDialog();
            Close();

        }

        private void findBreachesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        // about us
        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutbox = new AboutBox1();
            aboutbox.ShowDialog();
        }

        private void btn_Pass_Click(object sender, EventArgs e)
        {
            Hide();
            password f3 = new password();
            f3.ShowDialog();
        }

        private void btn_menu_info_Click(object sender, EventArgs e)
        {
            Hide();
            staysafe f4 = new staysafe();
            f4.ShowDialog();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            credits newcredits = new credits();
            newcredits.ShowDialog();
        }

        private void Formhome_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                e.Cancel = MessageBox.Show(@"Do you really want to close the form?",
                                           Application.ProductName,
                                           MessageBoxButtons.YesNo) == DialogResult.No;
        }

        private void Formhome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void reportABugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/dansailorsav1/chekit/issues");
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
    }
}