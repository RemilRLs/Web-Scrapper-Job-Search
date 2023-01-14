namespace Web_Scraping___Job_Search
{
    partial class JobResultForm
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ButtonNextJob = new System.Windows.Forms.Button();
            this.SeeHistoryButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.findJobsButton = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ButtonNextJob
            // 
            this.ButtonNextJob.Location = new System.Drawing.Point(325, 105);
            this.ButtonNextJob.Name = "ButtonNextJob";
            this.ButtonNextJob.Size = new System.Drawing.Size(94, 29);
            this.ButtonNextJob.TabIndex = 1;
            this.ButtonNextJob.Text = "Next";
            this.ButtonNextJob.UseVisualStyleBackColor = true;
            this.ButtonNextJob.Click += new System.EventHandler(this.ButtonNextJob_Click_1);
            // 
            // SeeHistoryButton
            // 
            this.SeeHistoryButton.Location = new System.Drawing.Point(472, 105);
            this.SeeHistoryButton.Name = "SeeHistoryButton";
            this.SeeHistoryButton.Size = new System.Drawing.Size(94, 29);
            this.SeeHistoryButton.TabIndex = 2;
            this.SeeHistoryButton.Text = "See history";
            this.SeeHistoryButton.UseVisualStyleBackColor = true;
            this.SeeHistoryButton.Click += new System.EventHandler(this.SeeHistoryButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.findJobsButton);
            this.panel1.Controls.Add(this.panelLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1317, 70);
            this.panel1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(666, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 70);
            this.button2.TabIndex = 3;
            this.button2.Text = "Recent searches";
            this.button2.UseVisualStyleBackColor = true;
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
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 70);
            this.panelLogo.TabIndex = 0;
            // 
            // JobResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 524);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SeeHistoryButton);
            this.Controls.Add(this.ButtonNextJob);
            this.Name = "JobResultForm";
            this.Text = "JobResultForm";
            this.Load += new System.EventHandler(this.JobResultForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private Button ButtonNextJob;
        private Button SeeHistoryButton;
        private Panel panel1;
        private Button button2;
        private Button button1;
        private Button findJobsButton;
        private Panel panelLogo;
    }
}