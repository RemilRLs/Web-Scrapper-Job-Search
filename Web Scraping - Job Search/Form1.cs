using System.Net;
using System.Text;
using System.IO;
using static System.Net.WebRequestMethods;
using WebScrapper;
using System.Drawing;
using System.Windows.Forms;
using JobSearchTool;
using ShowInformation;
using JobHistoryCheck;
using static System.Windows.Forms.DataFormats;

namespace Web_Scraping___Job_Search
{
    
    public partial class Form1 : Form
    {
        
        URLDataFinder newURLDataFinder = new URLDataFinder();
        JobSearchInformation jobSearch = new JobSearchInformation();
        JobResultForm JobResultFormJob = new JobResultForm();
        JobHistoryForm jobHistoryForm = new JobHistoryForm();
        ShowJobInformation showJobInfo = new ShowJobInformation();

       
        public Form1()
        {


            InitializeComponent();
            // https://thales.wd3.myworkdayjobs.com/fr-FR/Careers/jobs?q=thalium

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            string iconFile = "ressources..\\..\\..\\..\\..\\ressources\\icons\\fingerprint.circ";
            this.Icon = new Icon(iconFile);

            pictureBoxLogo.Image = Image.FromFile("ressources..\\..\\..\\..\\..\\ressources\\logo\\find_job_logo.jpg");
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;


            WhatJobTextBox.Text = "What ? Job Title or Keywords";
            WhatLocationTextBox.Text = "Where ? Job location";

            WhatLocationTextBox.Click += (sender, e) =>
            {
                WhatLocationTextBox.Clear();
            };

            WhatJobTextBox.Click += new EventHandler(WhatJobRichBox_Click);

            ButtonFindJobs.Click += (sender, e) =>
            {
                this.Hide();
                JobResultFormJob.Show();
            };

            AutoCompleteStringCollection customSourceJobTitle = new AutoCompleteStringCollection();
            AutoCompleteStringCollection customSourceJobCity = new AutoCompleteStringCollection();

            // Suggestion generation for the Job Title.

            jobSearch.PutInformationCollectionJobTitle("SELECT jobtitle FROM research_information_jobtitle");
            customSourceJobTitle = jobSearch.jobTitle;
            
            WhatJobTextBox.AutoCompleteCustomSource= customSourceJobTitle;

            // Suggestion generation for the Job City.

            jobSearch.PutInformationCollectionJobCity("SELECT city FROM research_information_jobcity");
            customSourceJobCity = jobSearch.jobCity;

            WhatLocationTextBox.AutoCompleteCustomSource = customSourceJobCity;
        }

        // Handler for the Rich Text Box.
        private void WhatJobRichBox_Click(object sender, EventArgs e)
        {
            WhatJobTextBox.Clear();
        }


        private void WhatJobRichBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void WhatLocationTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonFindJobs_Click(object sender, EventArgs e)
        {
            jobSearch.PutLocationAndTitleJobDatabaseHistory(WhatJobTextBox.Text, WhatLocationTextBox.Text);
            if (WhatLocationTextBox.Text.Contains("\r"))
            {
                WhatLocationTextBox.Text = WhatLocationTextBox.Text.Replace("\r", "");
            }
            if (WhatJobTextBox.Text.Contains("\r"))
            {
                WhatJobTextBox.Text = WhatJobTextBox.Text.Replace("\r", "");
            }

            newURLDataFinder.categoryJob = WhatJobTextBox.Text;
            newURLDataFinder.locationJob = WhatLocationTextBox.Text;

            newURLDataFinder.inputUserURL = string.Format("https://starjobsearch.co.uk/jobs/job-search-results/lc-{0}/lcr-50/kw-{1}/co-225/", newURLDataFinder.locationJob, newURLDataFinder.categoryJob);
            newURLDataFinder.SearchInformationJob();

            showJobInfo.ShowJobInformationData(JobResultFormJob);
            showJobInfo.offset += 3;

        }

        private void RecentSearchButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            jobHistoryForm.Show();
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }
    }
}