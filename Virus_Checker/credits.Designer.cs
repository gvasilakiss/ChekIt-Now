namespace Virus_Checker
{
    partial class credits
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(credits));
            this.lblcredits = new System.Windows.Forms.Label();
            this.lbl_links = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblcredits
            // 
            this.lblcredits.AutoSize = true;
            this.lblcredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcredits.Location = new System.Drawing.Point(12, 82);
            this.lblcredits.Name = "lblcredits";
            this.lblcredits.Size = new System.Drawing.Size(177, 140);
            this.lblcredits.TabIndex = 0;
            this.lblcredits.Text = "Email chek API:\r\n\r\nPassword check API:\r\n\r\nMore Email info API:\r\n\r\nMain API: ";
            // 
            // lbl_links
            // 
            this.lbl_links.AutoSize = true;
            this.lbl_links.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_links.Location = new System.Drawing.Point(195, 82);
            this.lbl_links.Name = "lbl_links";
            this.lbl_links.Size = new System.Drawing.Size(393, 140);
            this.lbl_links.TabIndex = 1;
            this.lbl_links.Text = "https://github.com/akamsteeg/AtleX.HaveIBeenPwned\r\n\r\nhttps://github.com/akamsteeg" +
    "/AtleX.HaveIBeenPwned\r\n\r\nhttps://github.com/sublime-security/emailrep.io\r\n\r\nhttp" +
    "s://haveibeenpwned.com/";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(32, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(524, 36);
            this.lbl_Title.TabIndex = 2;
            this.lbl_Title.Text = "We would like to say thank you too...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(697, 84);
            this.label1.TabIndex = 3;
            this.label1.Text = "The use of open source tools is vital to keep us doing what we love. \r\nWe will al" +
    "ways keep this tool open source. \r\nDan and George @ www.chekitnow.co.uk";
            // 
            // credits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 431);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.lbl_links);
            this.Controls.Add(this.lblcredits);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "credits";
            this.Text = "Chekit Now - Credits";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcredits;
        private System.Windows.Forms.Label lbl_links;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label label1;
    }
}