using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JobHistoryCheck;
using WebScrapper;
using JobSearchTool;
using ShowInformation;
using System.Text.RegularExpressions;

namespace Web_Scraping___Job_Search
{
    public partial class JobHistoryForm : Form
    {

        public JobHistoryForm()
        {
            InitializeComponent();
            foreach (Button button in this.Controls.OfType<Button>()){

                button.Click += new EventHandler(Button_Click);
                Debug.WriteLine("RJEIORJEZIOJREIOZ : " + button.Text);
            }
        }

        private void JobHistoryForm_Load(object sender, EventArgs e)
        {
            JobHistory jobHistory = new JobHistory();
            this.AutoScroll = true;

            jobHistory.GetHistoryJob(this);


            foreach (Control control in this.Controls)
            {
                // Check if the control is a Button
                if (control is Button && control.Name.StartsWith("HistoryButton"))
                {

                    control.Click += new EventHandler(HistoryButton_Click);
                }
            }


        }

        private void Button_Click(object sender, EventArgs e)
        {

            if (sender is Button button)
            {
                // Check the EventArgs object to confirm that the Click event was raised
                if (e is MouseEventArgs mouseEvent)
                {
                    // The button was clicked
                    //Debug.WriteLine("RJEIORJEZIOJREIOZ : " + button.Text);


                }
            }
        }

        private void HistoryButton_Click(object sender, EventArgs e)
        {
            URLDataFinder newURLDataFinder = new URLDataFinder();
            ShowJobInformation showJobInfo = new ShowJobInformation();
            JobResultForm JobResultFormJob = new JobResultForm();

            Button buttonHistory = sender as Button;
            string[] outputHistoryTextButton = null;
            string inputHistoryTextButton = null;

            if (buttonHistory != null)
            {
                // Text processing.

                inputHistoryTextButton = buttonHistory.Text;
                inputHistoryTextButton = inputHistoryTextButton.Replace("\r", "");
                inputHistoryTextButton = inputHistoryTextButton.Replace("\n", "");
                outputHistoryTextButton = Regex.Split(inputHistoryTextButton, @"(?<=)in ");

                Debug.WriteLine("A : " + outputHistoryTextButton[0] + " B : " + outputHistoryTextButton[1]);

            }
            else
            {
                Debug.WriteLine("No button was found.");
            }


            newURLDataFinder.inputUserURL = string.Format("https://starjobsearch.co.uk/jobs/job-search-results/lc-{0}/lcr-50/kw-{1}/co-225/", outputHistoryTextButton[1], outputHistoryTextButton[0]);
            
            newURLDataFinder.SearchInformationJob();

            showJobInfo.ShowJobInformationData(JobResultFormJob);
            showJobInfo.offset += 3;

            JobResultFormJob.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            JobResultForm JobResultFormJob = new JobResultForm();

            JobResultFormJob.Show();
            this.Hide();
        }
    }
}
