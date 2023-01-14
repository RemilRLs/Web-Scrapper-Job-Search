namespace Web_Scraping___Job_Search
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.RecentSearchButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.findJobsButton = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.WhatJobTextBox = new System.Windows.Forms.TextBox();
            this.WhatLocationTextBox = new System.Windows.Forms.TextBox();
            this.ButtonFindJobs = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.RecentSearchButton);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.findJobsButton);
            this.panel1.Controls.Add(this.panelLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 70);
            this.panel1.TabIndex = 0;
            // 
            // RecentSearchButton
            // 
            this.RecentSearchButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.RecentSearchButton.FlatAppearance.BorderSize = 0;
            this.RecentSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RecentSearchButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RecentSearchButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RecentSearchButton.Location = new System.Drawing.Point(666, 0);
            this.RecentSearchButton.Name = "RecentSearchButton";
            this.RecentSearchButton.Size = new System.Drawing.Size(276, 70);
            this.RecentSearchButton.TabIndex = 3;
            this.RecentSearchButton.Text = "Recent searches";
            this.RecentSearchButton.UseVisualStyleBackColor = true;
            this.RecentSearchButton.Click += new System.EventHandler(this.RecentSearchButton_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(458, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 70);
            this.button1.TabIndex = 2;
            this.button1.Text = "Result of the search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // findJobsButton
            // 
            this.findJobsButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.findJobsButton.FlatAppearance.BorderSize = 0;
            this.findJobsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findJobsButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.findJobsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.findJobsButton.Location = new System.Drawing.Point(250, 0);
            this.findJobsButton.Name = "findJobsButton";
            this.findJobsButton.Size = new System.Drawing.Size(208, 70);
            this.findJobsButton.TabIndex = 1;
            this.findJobsButton.Text = "Find jobs";
            this.findJobsButton.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 70);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(52, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(141, 70);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // WhatJobTextBox
            // 
            this.WhatJobTextBox.AutoCompleteCustomSource.AddRange(new string[] {
            "it",
            "computer science",
            "cybersecurity"});
            this.WhatJobTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.WhatJobTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.WhatJobTextBox.Location = new System.Drawing.Point(214, 219);
            this.WhatJobTextBox.Name = "WhatJobTextBox";
            this.WhatJobTextBox.Size = new System.Drawing.Size(244, 27);
            this.WhatJobTextBox.TabIndex = 6;
            this.WhatJobTextBox.Text = "What ? Job title or Keyword";
            // 
            // WhatLocationTextBox
            // 
            this.WhatLocationTextBox.AutoCompleteCustomSource.AddRange(new string[] {
            "it",
            "computer science",
            "cybersecurity"});
            this.WhatLocationTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.WhatLocationTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.WhatLocationTextBox.Location = new System.Drawing.Point(622, 219);
            this.WhatLocationTextBox.Name = "WhatLocationTextBox";
            this.WhatLocationTextBox.Size = new System.Drawing.Size(244, 27);
            this.WhatLocationTextBox.TabIndex = 7;
            this.WhatLocationTextBox.Text = "Where ? City";
            this.WhatLocationTextBox.TextChanged += new System.EventHandler(this.WhatLocationTextBox_TextChanged);
            // 
            // ButtonFindJobs
            // 
            this.ButtonFindJobs.BackColor = System.Drawing.SystemColors.Highlight;
            this.ButtonFindJobs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonFindJobs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonFindJobs.Location = new System.Drawing.Point(279, 302);
            this.ButtonFindJobs.Name = "ButtonFindJobs";
            this.ButtonFindJobs.Size = new System.Drawing.Size(458, 53);
            this.ButtonFindJobs.TabIndex = 8;
            this.ButtonFindJobs.Text = "Find Jobs";
            this.ButtonFindJobs.UseVisualStyleBackColor = false;
            this.ButtonFindJobs.Click += new System.EventHandler(this.ButtonFindJobs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1040, 523);
            this.Controls.Add(this.ButtonFindJobs);
            this.Controls.Add(this.WhatLocationTextBox);
            this.Controls.Add(this.WhatJobTextBox);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form1";
            this.Text = "Job Search";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button RecentSearchButton;
        private Button button1;
        private Button findJobsButton;
        private Panel panelLogo;
        private TextBox WhatJobTextBox;
        private TextBox WhatLocationTextBox;
        private Button ButtonFindJobs;
        private PictureBox pictureBoxLogo;
    }
}