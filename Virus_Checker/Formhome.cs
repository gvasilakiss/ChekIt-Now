using System;
using System.Windows.Forms;

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
            EmailCheck f1 = new EmailCheck();
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
            Password f3 = new Password();
            f3.ShowDialog();
        }

        private void btn_menu_info_Click(object sender, EventArgs e)
        {
            Hide();
            Staysafe f4 = new Staysafe();
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
            System.Diagnostics.Process.Start("https://github.com/gvasilakiss/ChekIt-Now/issues/new");
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