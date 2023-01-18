namespace Web_Scraping___Job_Search
{
    partial class JobHistoryForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.recentSearch = new System.Windows.Forms.Button();
            this.resultSearch = new System.Windows.Forms.Button();
            this.findJobsButton = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.wishListButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.wishListButton);
            this.panel1.Controls.Add(this.recentSearch);
            this.panel1.Controls.Add(this.resultSearch);
            this.panel1.Controls.Add(this.findJobsButton);
            this.panel1.Controls.Add(this.panelLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 70);
            this.panel1.TabIndex = 4;
            // 
            // recentSearch
            // 
            this.recentSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.recentSearch.FlatAppearance.BorderSize = 0;
            this.recentSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recentSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.recentSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.recentSearch.Location = new System.Drawing.Point(595, 0);
            this.recentSearch.Name = "recentSearch";
            this.recentSearch.Size = new System.Drawing.Size(175, 70);
            this.recentSearch.TabIndex = 3;
            this.recentSearch.Text = "Recent searches";
            this.recentSearch.UseVisualStyleBackColor = true;
            // 
            // resultSearch
            // 
            this.resultSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.resultSearch.FlatAppearance.BorderSize = 0;
            this.resultSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resultSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.resultSearch.Location = new System.Drawing.Point(432, 0);
            this.resultSearch.Name = "resultSearch";
            this.resultSearch.Size = new System.Drawing.Size(163, 70);
            this.resultSearch.TabIndex = 2;
            this.resultSearch.Text = "Result of the search";
            this.resultSearch.UseVisualStyleBackColor = true;
            this.resultSearch.Click += new System.EventHandler(this.resultSearch_Click);
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
            this.findJobsButton.Size = new System.Drawing.Size(182, 70);
            this.findJobsButton.TabIndex = 1;
            this.findJobsButton.Text = "Find jobs";
            this.findJobsButton.UseVisualStyleBackColor = true;
            this.findJobsButton.Click += new System.EventHandler(this.findJobsButton_Click);
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
            this.pictureBoxLogo.Location = new System.Drawing.Point(54, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(141, 70);
            this.pictureBoxLogo.TabIndex = 5;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // wishListButton
            // 
            this.wishListButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.wishListButton.FlatAppearance.BorderSize = 0;
            this.wishListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wishListButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.wishListButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.wishListButton.Location = new System.Drawing.Point(770, 0);
            this.wishListButton.Name = "wishListButton";
            this.wishListButton.Size = new System.Drawing.Size(118, 70);
            this.wishListButton.TabIndex = 5;
            this.wishListButton.Text = "Wishlist";
            this.wishListButton.UseVisualStyleBackColor = true;
            this.wishListButton.Click += new System.EventHandler(this.wishListButton_Click);
            // 
            // JobHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "JobHistoryForm";
            this.Text = "Job History";
            this.Load += new System.EventHandler(this.JobHistoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Button recentSearch;
        private Button resultSearch;
        private Button findJobsButton;
        private Panel panelLogo;
        private PictureBox pictureBoxLogo;
        private Button wishListButton;
    }
}