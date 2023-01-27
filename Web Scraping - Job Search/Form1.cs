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
using System.Diagnostics;
using WishList;
using System.Reflection.Emit;

namespace Web_Scraping___Job_Search
{
    
    public partial class Form1 : Form
    {
        
        URLDataFinder newURLDataFinder = new URLDataFinder();
        JobSearchInformation jobSearch = new JobSearchInformation();
        JobResultForm JobResultFormJob = new JobResultForm();
        JobHistoryForm jobHistoryForm = new JobHistoryForm();
        ShowJobInformation showJobInfo = new ShowJobInformation();
        WishListForm wishListForm = new WishListForm();


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

            pictureBoxSearch.Image = Image.FromFile("ressources..\\..\\..\\..\\..\\ressources\\icons\\search-interface-symbol.png");
            pictureBoxSearch.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBoxLoc.Image = Image.FromFile("ressources..\\..\\..\\..\\..\\ressources\\icons\\location.png");
            pictureBoxLoc.SizeMode = PictureBoxSizeMode.StretchImage;



            WhatJobTextBox.Text = "What ? Job Title or Keywords";
            WhatLocationTextBox.Text = "Where ? Job location";

            WhatLocationTextBox.Click += (sender, e) =>
            {
                WhatLocationTextBox.Clear();
            };


            textBoxFromSalary.Click += (sender, e) =>
            {
                textBoxFromSalary.Clear();
            };



            WhatJobTextBox.Click += new EventHandler(WhatJobRichBox_Click);


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

            StringBuilder advancedLink = new StringBuilder(string.Format("https://starjobsearch.co.uk/jobs/job-search-results/lc-{0}/lcr-50/kw-{1}/co-225/", newURLDataFinder.locationJob, newURLDataFinder.categoryJob));

            // Verification of the advanced job search.

            newURLDataFinder.inputUserURL = checkTextBoxSalary(advancedLink, textBoxFromSalary.Text).ToString();
            newURLDataFinder.inputUserURL = checkBoxCheck(advancedLink).ToString(); 

            Debug.WriteLine("The link is : " + advancedLink.ToString());



            bool nodeBool = newURLDataFinder.SearchInformationJob();

            if(nodeBool)
            {

                showJobInfo.ShowJobInformationData(JobResultFormJob);
                showJobInfo.offset = 0;



                this.Hide();
                JobResultFormJob.Show();
             
            }
            else
            {
                MessageBox.Show("No job offers were found based on your search criteria. Please try adjusting your search parameters and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine("NO NODE");
            }



        }

        private void RecentSearchButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            jobHistoryForm.Show();
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            groupBox1.FlatStyle = FlatStyle.Flat;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelAdJob_Paint(object sender, PaintEventArgs e)
        {
            panelAdJob.BorderStyle = BorderStyle.None;
            panelAdJob.BackColor = Color.White;
        }

        private void panelAdJob2_Paint(object sender, PaintEventArgs e)
        {
            panelAdJob2.BorderStyle = BorderStyle.None;
            panelAdJob2.BackColor = Color.White;
        }

        private void checkBoxContract_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxFullTime_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxPartTime_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxPermanentJob_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxTemporaryJob_CheckedChanged(object sender, EventArgs e)
        {

        }
        private StringBuilder checkTextBoxSalary(StringBuilder advancedLink, String From)
        {

            // We check first if the salary "From and To" are int.

            if(From != "From")
            {
                // We check first if the salary "From" are a int.

                if (int.TryParse((From), out int resultFrom)){

                    advancedLink.Append("sa-" + resultFrom + "~0~5/");
                    return advancedLink;
                }
                else
                {
                    MessageBox.Show("Invalid input. Please enter a integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return advancedLink;
                }


            }
            else
            {
                return advancedLink;
            }
            
            
        }
        private StringBuilder checkBoxCheck(StringBuilder advancedLink)
        {
            if (checkBoxFullTime.Checked)
            {
                advancedLink.Append("wh-3/");
            }
            else
            {
                // If that none is not checked or have been unchecked.

                int index = advancedLink.ToString().IndexOf("wh-3/");

                // If we found the wh-3/ we remove it.

                if (index != -1)
                {
                    advancedLink.Remove(index, 5); // Remove "wh-3/".
                }
            }


            // We do the same here but for "wh-2/".


            if (checkBoxPartTime.Checked)
            {
                advancedLink.Append("wh-2/");
            }
            else
            {
                int index = advancedLink.ToString().IndexOf("wh-2/");

                if (index != -1)
                {
                    advancedLink.Remove(index, 5);
                }
            }

            // Same.

            if (checkBoxContractJob.Checked)
            {
                advancedLink.Append("jt-1/");
            }
            else
            {
                int index = advancedLink.ToString().IndexOf("jt-1/");

                if (index != -1)
                {
                    advancedLink.Remove(index, 5);
                }
            }

            // Same.

            if (checkBoxPermanentJob.Checked)
            {
                advancedLink.Append("jt-2/");
            }
            else
            {
                int index = advancedLink.ToString().IndexOf("jt-2/");

                if(index != -1)
                {
                    advancedLink.Remove(index, 5);
                }
            }

            // Same.

            if (checkBoxTemporaryJob.Checked)
            {
                advancedLink.Append("jt-3/");
            }
            else
            {
                int index = advancedLink.ToString().IndexOf("jt-3/");

                if (index != -1)
                {
                    advancedLink.Remove(index, 5);
                }
            }


            return advancedLink;
        }

        private void wishListButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            wishListForm.Show();
        }
    }
}