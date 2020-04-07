namespace Virus_Checker
{
    partial class Formhome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formhome));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Main_Toolbar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportABugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.btn_Pass = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.btn_menu_info = new System.Windows.Forms.Button();
            this.btn_menu_pwned = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.Main_Toolbar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnl_Menu.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_Toolbar
            // 
            this.Main_Toolbar.BackColor = System.Drawing.Color.White;
            this.Main_Toolbar.Controls.Add(this.panel2);
            this.Main_Toolbar.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            resources.ApplyResources(this.Main_Toolbar, "Main_Toolbar");
            this.Main_Toolbar.Name = "Main_Toolbar";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.menuStrip1);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Image = global::Virus_Checker.Properties.Resources.file_icon;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUsToolStripMenuItem,
            this.creditsToolStripMenuItem,
            this.reportABugToolStripMenuItem});
            this.helpToolStripMenuItem.Image = global::Virus_Checker.Properties.Resources.help_icon;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            resources.ApplyResources(this.aboutUsToolStripMenuItem, "aboutUsToolStripMenuItem");
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            resources.ApplyResources(this.creditsToolStripMenuItem, "creditsToolStripMenuItem");
            this.creditsToolStripMenuItem.Click += new System.EventHandler(this.creditsToolStripMenuItem_Click);
            // 
            // reportABugToolStripMenuItem
            // 
            this.reportABugToolStripMenuItem.Name = "reportABugToolStripMenuItem";
            resources.ApplyResources(this.reportABugToolStripMenuItem, "reportABugToolStripMenuItem");
            this.reportABugToolStripMenuItem.Click += new System.EventHandler(this.reportABugToolStripMenuItem_Click);
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.pnl_Menu.Controls.Add(this.btn_Pass);
            this.pnl_Menu.Controls.Add(this.panel4);
            this.pnl_Menu.Controls.Add(this.pcbLogo);
            this.pnl_Menu.Controls.Add(this.btn_menu_info);
            this.pnl_Menu.Controls.Add(this.btn_menu_pwned);
            this.pnl_Menu.Controls.Add(this.btn_Home);
            resources.ApplyResources(this.pnl_Menu, "pnl_Menu");
            this.pnl_Menu.Name = "pnl_Menu";
            // 
            // btn_Pass
            // 
            this.btn_Pass.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_Pass, "btn_Pass");
            this.btn_Pass.ForeColor = System.Drawing.Color.White;
            this.btn_Pass.Image = global::Virus_Checker.Properties.Resources._3;
            this.btn_Pass.Name = "btn_Pass";
            this.btn_Pass.UseVisualStyleBackColor = true;
            this.btn_Pass.Click += new System.EventHandler(this.btn_Pass_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button1);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Virus_Checker.Properties.Resources._5;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pcbLogo
            // 
            this.pcbLogo.Image = global::Virus_Checker.Properties.Resources.logo_final_white;
            resources.ApplyResources(this.pcbLogo, "pcbLogo");
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.TabStop = false;
            // 
            // btn_menu_info
            // 
            this.btn_menu_info.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_menu_info, "btn_menu_info");
            this.btn_menu_info.ForeColor = System.Drawing.Color.White;
            this.btn_menu_info.Image = global::Virus_Checker.Properties.Resources._4;
            this.btn_menu_info.Name = "btn_menu_info";
            this.btn_menu_info.UseVisualStyleBackColor = true;
            this.btn_menu_info.Click += new System.EventHandler(this.btn_menu_info_Click);
            // 
            // btn_menu_pwned
            // 
            this.btn_menu_pwned.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_menu_pwned, "btn_menu_pwned");
            this.btn_menu_pwned.ForeColor = System.Drawing.Color.White;
            this.btn_menu_pwned.Image = global::Virus_Checker.Properties.Resources._2;
            this.btn_menu_pwned.Name = "btn_menu_pwned";
            this.btn_menu_pwned.UseVisualStyleBackColor = true;
            this.btn_menu_pwned.Click += new System.EventHandler(this.btn_menu_pwned_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_Home, "btn_Home");
            this.btn_Home.ForeColor = System.Drawing.Color.White;
            this.btn_Home.Image = global::Virus_Checker.Properties.Resources._1;
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.UseVisualStyleBackColor = true;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.panel6.Controls.Add(this.lbl_Title);
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // lbl_Title
            // 
            resources.ApplyResources(this.lbl_Title, "lbl_Title");
            this.lbl_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(214)))), ((int)(((byte)(79)))));
            this.lbl_Title.Name = "lbl_Title";
            // 
            // Formhome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.Main_Toolbar);
            this.Controls.Add(this.pnl_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Formhome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Formhome_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Formhome_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Main_Toolbar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_Menu.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel Main_Toolbar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Button btn_menu_pwned;
        private System.Windows.Forms.Button btn_menu_info;
        private System.Windows.Forms.Panel pnl_Menu;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.Button btn_Pass;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportABugToolStripMenuItem;
    }
}

