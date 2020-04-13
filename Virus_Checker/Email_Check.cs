using AtleX.HaveIBeenPwned;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Virus_Checker
{
    public partial class Email_Check : Form
    {
      
        public Email_Check()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            // screen move
            //this.Location = Screen.AllScreens[1].WorkingArea.Location;
        }

        // Check if email is pawned
        private async void button1_Click_1(object sender, EventArgs e)
        {
            // clear, hide or show: lbl, combobox, list depending on button option
            lbl_Result.ResetText();
            lstAddBreaches.Show();
            lstAddBreaches.Items.Clear();

            var settings = new HaveIBeenPwnedClientSettings()
            {
                // API Key for HaveIBeenPwned 
                ApiKey = "8018ed49965e45dfb536601dd806ee60",
                ApplicationName = "ChekIt-Now",
            };

            using (var client = new HaveIBeenPwnedClient(settings))
            {
                try
                {
                    if (txtBox_pwned_Email.Text == "")
                    {
                        lbl_Result.ForeColor = System.Drawing.Color.FromArgb(234, 75, 46);
                        lbl_Result.Text = @"Input can't be empty, enter email to continue";
                    }
                    else if (!txtBox_pwned_Email.Text.Contains("@"))
                    {
                        lbl_Result.ForeColor = System.Drawing.Color.FromArgb(234, 75, 46);
                        lbl_Result.Text = @"Input is not in correct format, try again";
                    }
                    else
                    {
                        var breaches = await client.GetBreachesAsync(txtBox_pwned_Email.Text);
                        lbl_Result.Text = @"If your email has been pawned then you can find the name in the box below";

                        foreach (Breach breach in breaches)
                        {
                            // Convert JSON Object to string ?
                            var breachesString = JsonConvert.SerializeObject(breach);

                            // I don't know what this does, but it works :)
                            GetBreachName getOnlyName = JsonConvert.DeserializeObject<GetBreachName>(breachesString);

                            // Add items to list
                            lstAddBreaches.Items.Add("Website: " + getOnlyName.Name);
                        }

                        // Enable save button if list contains links
                        if (lstAddBreaches.Items.Count >= 1)
                        {
                            saveToolStripMenuItem.Enabled = true;
                        }

                        if (lstAddBreaches.Items.Count == 0)
                        {
                            MessageBox.Show("Your email is secure!", "Breach Info", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            // Clear the text box once the code has ran. This makes it clear for the next input
            txtBox_pwned_Email.Clear();

            // Disable save button
            saveToolStripMenuItem.Enabled = false;
        }

        private async void btnGetPaste_Click(object sender, EventArgs e)
        {
            // clear, hide or show: lbl, combobox, list depending on button option
            lbl_Result.ResetText();
            lstAddBreaches.Show();
            lstAddBreaches.Items.Clear();

            var settings = new HaveIBeenPwnedClientSettings()
            {
                // API Key for HaveIBeenPwned 
                ApiKey = "8018ed49965e45dfb536601dd806ee60",
                ApplicationName = "ChekIt-Now",
            };

            using (var client = new HaveIBeenPwnedClient(settings))
            {
                try
                {
                    if (txtBox_pwned_Email.Text == "")
                    {
                        lbl_Result.ForeColor = System.Drawing.Color.FromArgb(234, 75, 46);
                        lbl_Result.Text = @"Input can't be empty, enter email to continue";
                    }
                    else if (!txtBox_pwned_Email.Text.Contains("@"))
                    {
                        lbl_Result.ForeColor = System.Drawing.Color.FromArgb(234, 75, 46);
                        lbl_Result.Text = @"Input is not in correct format, try again";
                    }
                    else
                    {
                        lbl_Result.Text = @"If your email has been pasted then you can find the website in the box below" + System.Environment.NewLine + "You can save your results by going to file";

                        var pastes = await client.GetPastesAsync(txtBox_pwned_Email.Text);

                        foreach (Paste paste in pastes)
                        {
                            // Convert JSON Object to string ?
                            var getPasteString = JsonConvert.SerializeObject(paste);

                            // I don't know what this does, but it works :)
                            GetPastes getPastes = JsonConvert.DeserializeObject<GetPastes>(getPasteString);

                            // Return only valid url starting with http or https
                            if (getPastes.Id.StartsWith("http"))
                            {
                                // Add websites to the list
                                lstAddBreaches.Items.Add("Link: " + getPastes.Id);
                            }
                        }

                        // Enable save button if list contains links
                        if (lstAddBreaches.Items.Count >= 1)
                        {
                            saveToolStripMenuItem.Enabled = true;
                        }

                        if (lstAddBreaches.Items.Count == 0)
                        {
                            MessageBox.Show("Your email is secure!", "Pasted Info", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            // Clear the text box once the code has ran. This makes it clear for the next input
            txtBox_pwned_Email.Clear();

            // Disable save button
            saveToolStripMenuItem.Enabled = false;
        }

        private void btnSaveList_Click(object sender, EventArgs e)
        {
            // Prompt user to select folder and name to save the file to txt format
            var saveFile = new SaveFileDialog();
            saveFile.Filter = @"Text (*.txt)|*.txt";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (var sw = new StreamWriter(saveFile.FileName, false))
                    foreach (var item in lstAddBreaches.Items)
                        sw.Write(item + Environment.NewLine);

                MessageBox.Show(@"File saved successfully", "List saved",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Calls function to check the email
        private void bttEmailRep_Click_1(object sender, EventArgs e)
        {
            lbl_Result.ResetText();
            lstAddBreaches.Show();
            lstAddBreaches.Items.Clear();


            string input = "https://emailrep.io/" + txtBox_pwned_Email.Text;

            if (txtBox_pwned_Email.Text == "")
            {
                lbl_Result.ForeColor = System.Drawing.Color.FromArgb(234, 75, 46);
                lbl_Result.Text = @"Input can't be empty, enter email to continue";
            }
            else if (!txtBox_pwned_Email.Text.Contains("@"))
            {
                lbl_Result.ForeColor = System.Drawing.Color.FromArgb(234, 75, 46);
                lbl_Result.Text = @"Input is not in correct format, try again";
            }
            else
            {
                // Clears text box and resets label value
                lbl_Result.ResetText();
                WebRequest(input);
                txtBox_pwned_Email.Clear();
            }
        }

        // Checks the reputation of an email using the API from emailrep.io
        private static void WebRequest(string input)
        {
            // Initialize GET request
            string webserviceUrl = input;

            try
            {
                HttpWebRequest webRequest = (HttpWebRequest)System.Net.WebRequest.Create(webserviceUrl);

                webRequest.Method = "GET";
                webRequest.Timeout = 12000;
                webRequest.ContentType = "application/json";
                // 45dpfxecbjk2124tpxibbia9b9fh32oc9hkc3aphdjwcm0pj - MAIN API
                webRequest.Headers["Key"] = "ip1rd56y7rwnx29n6mksm3xogomtt9nzx5s84etyhjrt52yb";
                webRequest.UserAgent = "ChekIt-Now";

                // Read all data from the response and print it to MessageBox - For now
                using (Stream s = webRequest.GetResponse().GetResponseStream())
                {
                    using (StreamReader sr = new StreamReader(s))
                    {
                        // Read all the lines and display only the data that are declared in the class GetRepMail
                        var jsonResponse = sr.ReadToEnd();

                        // Converts HTTPWebResponse response to JSON Deserialized Object
                        GetRepMail getRepMailValues = JsonConvert.DeserializeObject<GetRepMail>(jsonResponse);

                        // Get all profiles properly
                        string profiles = (string.Join(", ", getRepMailValues.details.profiles));

                        MessageBox.Show($"Email: {getRepMailValues.email} \n" +
                                        $"Reputation: {getRepMailValues.reputation} \n" +
                                        $"Suspicious: {getRepMailValues.suspicious} \n" +
                                        $"References: {getRepMailValues.references} \n",
                            "Email info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        DialogResult drMoreDetailShow = MessageBox.Show("Do you want to see more details for this email?", "View More Details",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

                        if (drMoreDetailShow == DialogResult.Yes)
                        {
                            MessageBox.Show("More Info" + Environment.NewLine + Environment.NewLine +
                                                          "Blacklisted: " + getRepMailValues.details.blacklisted + Environment.NewLine +
                                                          "Malicious_activity: " + getRepMailValues.details.malicious_activity + Environment.NewLine +
                                                          "Malicious_activity_recent: " + getRepMailValues.details.malicious_activity_recent + Environment.NewLine +
                                                          "Credentials_leaked: " + getRepMailValues.details.credentials_leaked + Environment.NewLine +
                                                          "Credentials_leaked_recent: " + getRepMailValues.details.credentials_leaked_recent + Environment.NewLine +
                                                          "Data_breach: " + getRepMailValues.details.data_breach + Environment.NewLine +
                                                          "First_seen: " + getRepMailValues.details.first_seen + Environment.NewLine +
                                                          "Last_seen: " + getRepMailValues.details.last_seen + Environment.NewLine +
                                                          "Domain_exists: " + getRepMailValues.details.domain_exists + Environment.NewLine +
                                                          "Domain_reputation: " + getRepMailValues.details.domain_reputation + Environment.NewLine +
                                                          "New_domain: " + getRepMailValues.details.new_domain + Environment.NewLine +
                                                          "Days_since_domain_creation: " + getRepMailValues.details.days_since_domain_creation + Environment.NewLine +
                                                          "Suspicious_tld: " + getRepMailValues.details.suspicious_tld + Environment.NewLine +
                                                          "Spam: " + getRepMailValues.details.spam + Environment.NewLine +
                                                          "Free_provider: " + getRepMailValues.details.free_provider + Environment.NewLine +
                                                          "Disposable: " + getRepMailValues.details.disposable + Environment.NewLine +
                                                          "Deliverable: " + getRepMailValues.details.deliverable + Environment.NewLine +
                                                          "Accept_all: " + getRepMailValues.details.accept_all + Environment.NewLine +
                                                          "Valid_mx: " + getRepMailValues.details.valid_mx + Environment.NewLine +
                                                          "Spoofable: " + getRepMailValues.details.spoofable + Environment.NewLine +
                                                          "Spf_strict: " + getRepMailValues.details.spf_strict + Environment.NewLine +
                                                          "Dmarc_enforced: " + getRepMailValues.details.dmarc_enforced + Environment.NewLine +
                                                          "Profiles: " + profiles, "Email info",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        // Prompt user to save findings into a text file
                        DialogResult drResult = MessageBox.Show("Do you want to save the results?", "Save results",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

                        // Get only first 4 details saved to file
                        if (drResult == DialogResult.Yes && drMoreDetailShow == DialogResult.No)
                        {
                            // Prompt user to select folder and name to save the file to txt format
                            var saveFile = new SaveFileDialog();
                            saveFile.Filter = @"Text (*.txt)|*.txt";
                            if (saveFile.ShowDialog() == DialogResult.OK)
                            {
                                using (var sw = new StreamWriter(saveFile.FileName, false))
                                {
                                    sw.Write("Information for " + getRepMailValues.email + Environment.NewLine + Environment.NewLine);
                                    sw.Write("Email:" + getRepMailValues.email + Environment.NewLine);
                                    sw.Write("Reputation:" + getRepMailValues.reputation + Environment.NewLine);
                                    sw.Write("Suspicious:" + getRepMailValues.suspicious + Environment.NewLine);
                                    sw.Write("References:" + getRepMailValues.references);
                                }

                                MessageBox.Show(@"File saved successfully", "List saved",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                        // Get more details saved to file
                        else if (drResult == DialogResult.Yes && drMoreDetailShow == DialogResult.Yes)
                        {
                            // Prompt user to select folder and name to save the file to txt format
                            var saveFile = new SaveFileDialog();
                            saveFile.Filter = @"Text (*.txt)|*.txt";
                            if (saveFile.ShowDialog() == DialogResult.OK)
                            {
                                using (var sw = new StreamWriter(saveFile.FileName, false))
                                {
                                    sw.Write("Information for " + getRepMailValues.email + Environment.NewLine + Environment.NewLine);
                                    sw.Write("Email:" + getRepMailValues.email + Environment.NewLine);
                                    sw.Write("Reputation:" + getRepMailValues.reputation + Environment.NewLine);
                                    sw.Write("Suspicious:" + getRepMailValues.suspicious + Environment.NewLine);
                                    sw.Write("References:" + getRepMailValues.references + Environment.NewLine + Environment.NewLine);

                                    sw.Write("*****More Details*****" + Environment.NewLine + Environment.NewLine);
                                    sw.Write("Blacklisted: " + getRepMailValues.details.blacklisted + Environment.NewLine);
                                    sw.Write("Malicious_activity: " + getRepMailValues.details.malicious_activity + Environment.NewLine);
                                    sw.Write("Malicious_activity_recent: " + getRepMailValues.details.malicious_activity_recent + Environment.NewLine);
                                    sw.Write("Credentials_leaked: " + getRepMailValues.details.credentials_leaked + Environment.NewLine);
                                    sw.Write("Credentials_leaked_recent: " + getRepMailValues.details.credentials_leaked_recent + Environment.NewLine);
                                    sw.Write("Data_breach: " + getRepMailValues.details.data_breach + Environment.NewLine);
                                    sw.Write("First_seen: " + getRepMailValues.details.first_seen + Environment.NewLine);
                                    sw.Write("Last_seen: " + getRepMailValues.details.last_seen + Environment.NewLine);
                                    sw.Write("Domain_exists: " + getRepMailValues.details.domain_exists + Environment.NewLine);
                                    sw.Write("Domain_reputation: " + getRepMailValues.details.domain_reputation + Environment.NewLine);
                                    sw.Write("New_domain: " + getRepMailValues.details.new_domain + Environment.NewLine);
                                    sw.Write("Days_since_domain_creation: " + getRepMailValues.details.days_since_domain_creation + Environment.NewLine);
                                    sw.Write("Suspicious_tld: " + getRepMailValues.details.suspicious_tld + Environment.NewLine);
                                    sw.Write("Spam: " + getRepMailValues.details.spam + Environment.NewLine);
                                    sw.Write("Free_provider: " + getRepMailValues.details.free_provider + Environment.NewLine);
                                    sw.Write("Disposable: " + getRepMailValues.details.disposable + Environment.NewLine);
                                    sw.Write("Deliverable: " + getRepMailValues.details.deliverable + Environment.NewLine);
                                    sw.Write("Accept_all: " + getRepMailValues.details.accept_all + Environment.NewLine);
                                    sw.Write("Valid_mx: " + getRepMailValues.details.valid_mx + Environment.NewLine);
                                    sw.Write("Spoofable: " + getRepMailValues.details.spoofable + Environment.NewLine);
                                    sw.Write("Spf_strict: " + getRepMailValues.details.spf_strict + Environment.NewLine);
                                    sw.Write("Dmarc_enforced: " + getRepMailValues.details.dmarc_enforced + Environment.NewLine);
                                    sw.Write("Profiles: " + profiles);
                                }

                                MessageBox.Show(@"File saved successfully", "List saved",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // Get the details from the emailrep.io API
        public class GetRepMailDetails
        {
            public bool accept_all { get; set; }
            public bool blacklisted { get; set; }
            public bool credentials_leaked { get; set; }
            public bool credentials_leaked_recent { get; set; }
            public bool data_breach { get; set; }
            public int days_since_domain_creation { get; set; }
            public bool deliverable { get; set; }
            public bool disposable { get; set; }
            public bool dmarc_enforced { get; set; }
            public bool domain_exists { get; set; }
            public string domain_reputation { get; set; }
            public string first_seen { get; set; }
            public bool free_provider { get; set; }
            public string last_seen { get; set; }
            public bool malicious_activity { get; set; }
            public bool malicious_activity_recent { get; set; }
            public bool new_domain { get; set; }
            public List<string> profiles { get; set; }
            public bool spam { get; set; }
            public bool spf_strict { get; set; }
            public bool spoofable { get; set; }
            public bool suspicious_tld { get; set; }
            public bool valid_mx { get; set; }
        }

        public class GetRepMail
        {
            public GetRepMailDetails details { get; set; }
            public string email { get; set; }
            public int references { get; set; }
            public string reputation { get; set; }
            public bool suspicious { get; set; }
        }

        // I don't know what that does too, but it works
        public class GetBreachName
        {
            public string Name { get; set; }
        }

        // I don't know either
        public class GetPastes
        {
            public string Source { get; set; }
            public string Id { get; set; }
            public string Title { get; set; }
            public string Date { get; set; }
            public string EmailCount { get; set; }
        }

        // Closes current form and opens the new one
        private void btn_Home_Click(object sender, EventArgs e)
        {
            // clear the label for results and the list box upon clicking buttons
            lbl_Result.ResetText();
            Hide();
            Formhome f2 = new Formhome();
            f2.ShowDialog();
            Close();
        }

        // Closes the application
        private void button1_Click(object sender, EventArgs e)
        {
            // Declare a DialogResult variable
            DialogResult drReply = MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drReply == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveFile = new SaveFileDialog();
            saveFile.Filter = @"Text (*.txt)|*.txt";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (var sw = new StreamWriter(saveFile.FileName, false))
                    foreach (var item in lstAddBreaches.Items)
                        sw.Write(item + Environment.NewLine);

                MessageBox.Show(@"File saved successfully");
            }
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

        private void lstAddBreaches_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutbox = new AboutBox1();
            aboutbox.ShowDialog();
        }

        private void btn_Home_Click_1(object sender, EventArgs e)
        {
            Hide();
            Formhome f2 = new Formhome();
            f2.ShowDialog();
            Close();
        }

        private void btn_Pass_Click(object sender, EventArgs e)
        {
            Hide();
            password f3 = new password();
            f3.ShowDialog();
        }

        private void btn_menu_pwned_Click(object sender, EventArgs e)
        {
        }

        private void btn_menu_info_Click(object sender, EventArgs e)
        {
            Hide();
            staysafe f4 = new staysafe();
            f4.ShowDialog();
        }

        
        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            credits newcredits = new credits();
            newcredits.ShowDialog();
        }

        private void Email_Check_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                e.Cancel = MessageBox.Show(@"Do you really want to close the form?",
                                           Application.ProductName,
                                           MessageBoxButtons.YesNo) == DialogResult.No;
        }

        private void Email_Check_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void creditsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            credits newcredits = new credits();
            newcredits.ShowDialog();
        }

        private void reportABugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/gvasilakiss/ChekIt-Now/issues/new");
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
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