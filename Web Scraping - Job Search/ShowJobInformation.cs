using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using DatabaseMySQL;
using System.Diagnostics;
using Web_Scraping___Job_Search;

namespace ShowInformation
{
    public class ShowJobInformation
    {
        public int offset = 0;

        private int count = 0;
        
        public void ShowJobInformationData(JobResultForm form)
        {
            DatabaseConnexion database = new DatabaseConnexion();
            string databaseStringConnexion = database.dataBaseConnexion();
            int locationHeightOffset = 150;
            count = 0;
            
            foreach (Button button in form.Controls.OfType<Button>())
            {
                if (button.Text.StartsWith("Next"))
                {
                    // Do nothing.
                }
                else if (button.Text.StartsWith("See"))
                {
                    // Do nothing to.
                }
                else
                {
                    form.Controls.Remove(button);
                }
            }
            foreach(Label label in form.Controls.OfType<Label>())
            {
                form.Controls.Remove(label);
            }
            

            // We going to read 3 by 3 rows.


            MySqlConnection databaseConnexion = new MySqlConnection(databaseStringConnexion);

            try
            {
                databaseConnexion.Open();

                string queryGetJob = "SELECT location, title, salary, description, apply_link FROM joboffer LIMIT 3 OFFSET " + offset;
                Debug.WriteLine("The offset value is : " + offset);

                var databaseCommandQuery = new MySqlCommand(queryGetJob, databaseConnexion);


                MySqlDataReader readerJobInformation = databaseCommandQuery.ExecuteReader();


                while (readerJobInformation.Read())
                {


                    Debug.WriteLine(readerJobInformation["title"] + " - " + readerJobInformation["salary"] + " - " + readerJobInformation["location"] + " - " + readerJobInformation["description"]);
                    Button titleJobButton = new Button();

                    titleJobButton.AutoSize = true;
                    titleJobButton.Location = new Point(30, (locationHeightOffset + 0));  // Adjust this as needed to position the label.
                    titleJobButton.ForeColor = Color.Black;
                    titleJobButton.Font = new Font("Arial", 12, FontStyle.Bold);
                    titleJobButton.FlatAppearance.BorderSize = 0;
                    titleJobButton.Name = "TitleButton" + count.ToString();

                    titleJobButton.Text = readerJobInformation["title"] + "";
                    form.Controls.Add(titleJobButton);

                    Label locationJobLabel = new Label();

                    locationJobLabel.AutoSize = true;
                    locationJobLabel.Location = new Point(29, (locationHeightOffset + 25));  // Adjust this as needed to position the label.
                    locationJobLabel.ForeColor = Color.Black;
                    locationJobLabel.Font = new Font("Arial", 10);
                    locationJobLabel.Name = "Location" + count.ToString();

                    locationJobLabel.Text = readerJobInformation["location"] + "";
                    form.Controls.Add(locationJobLabel);

                    Button salaryJobButton = new Button();

                    salaryJobButton.AutoSize = true;
                    salaryJobButton.Location = new Point(30, (locationHeightOffset + 55));
                    salaryJobButton.BackColor = Color.FromArgb(0xF3, 0xF2, 0xF1);
                    salaryJobButton.ForeColor = Color.Black;
                    salaryJobButton.Font = new Font("Arial", 10, FontStyle.Bold);
                    salaryJobButton.Enabled = false;
                    salaryJobButton.Name = "Salary" + count.ToString();
    

                    salaryJobButton.Text = readerJobInformation["salary"] + "";
                    form.Controls.Add(salaryJobButton);

                    Label descriptionJobLabel = new Label();
                    descriptionJobLabel.AutoSize = true;
                    descriptionJobLabel.MaximumSize = new Size(300, 0);
                    descriptionJobLabel.Location = new Point(30, (locationHeightOffset + 100));
                    descriptionJobLabel.Name = "Description" + count.ToString();

                    descriptionJobLabel.Text = readerJobInformation["description"] + "";
                    form.Controls.Add(descriptionJobLabel);

                    Label applyLinkLabel = new Label();
                    
                    applyLinkLabel.Text = readerJobInformation["apply_link"] + "";
                    applyLinkLabel.Visible = false;
                    applyLinkLabel.Name = "ApplyLink" + count.ToString();


                    form.Controls.Add(applyLinkLabel);

                    locationHeightOffset += 300;
                    count++;
                }


            }
            catch(Exception ex)
            {
                Debug.WriteLine("Erreur" + ex.ToString());
            }

        }

        public List<Label> ShowMoreInformationJob(JobResultForm form, string index)
        {
            List<Label> labelListJobInformation = new List<Label>();

            foreach (Button buttonApply in form.Controls.OfType<Button>())
            {
                if (buttonApply.Name.StartsWith("ButtonApply"))
                {
                    form.Controls.Remove(buttonApply);
                }
            }

            foreach (Control control in form.Controls)
            {
                if (control.Name.Contains("Description" + index))
                {
                    Debug.WriteLine(control.Text);

                    Label descriptionJobLabel = new Label();
                    descriptionJobLabel.AutoSize = true;
                    descriptionJobLabel.Location = new Point(550,370);
                    descriptionJobLabel.MaximumSize = new Size(450, 0);
                    descriptionJobLabel.Name = "JobOverviewDesc";
                    descriptionJobLabel.Text = control.Text;

                    labelListJobInformation.Add(descriptionJobLabel);


                    form.Controls.Add(descriptionJobLabel);
                    
                }
                if (control.Name.Contains("Location" + index))
                {
                    Debug.WriteLine(control.Text);

                    Label locationJobLabel = new Label();
                    locationJobLabel.AutoSize = true;
                    locationJobLabel.Location = new Point(550, 189);
                    locationJobLabel.Name = "JobLocalisation";
                    locationJobLabel.Text = control.Text;

                    labelListJobInformation.Add(locationJobLabel);

                    form.Controls.Add(locationJobLabel);
 
                }
                if (control.Name.Contains("Salary" + index))
                {
                    Debug.WriteLine(control.Text);

                    Label jobSalaryLabel = new Label();
                    jobSalaryLabel.AutoSize = true;
                    jobSalaryLabel.Location = new Point(550, 290);
                    jobSalaryLabel.Name = "SalaryInfo"; 
                    jobSalaryLabel.Text = control.Text;

                    labelListJobInformation.Add(jobSalaryLabel);

                    form.Controls.Add(jobSalaryLabel);
                }
                if(control.Name.Contains("TitleButton" + index))
                {
                    Debug.WriteLine(control.Text);

                    Label titleJobLabel = new Label();
                    titleJobLabel.AutoSize = true;
                    titleJobLabel.Font = new Font("Arial", 13, FontStyle.Bold);
                    titleJobLabel.Location = new Point(550, 150);
                    titleJobLabel.Name = "TitleInfo";
                    titleJobLabel.Text = control.Text;

                    labelListJobInformation.Add(titleJobLabel);

                    form.Controls.Add(titleJobLabel);
                }

                if(control.Name.Contains("ApplyLink" + index))
                {

                    Button jobApply = new Button();
                    jobApply.AutoSize = true;
                    jobApply.Font = new Font(jobApply.Font, FontStyle.Bold);
                    jobApply.Location = new Point(550, 220);
                    jobApply.BackColor = Color.FromArgb(0x25, 0x57, 0xA7);
                    jobApply.ForeColor = Color.White;
                    jobApply.Text = "Apply Now";
                    jobApply.Name = "ButtonApply";


                    Debug.WriteLine("Apply link : " + control.Text + "Index : " + index);

                    jobApply.Click += (sender, e) =>
                    {
                        Debug.WriteLine("Apply link 2 : " + control.Text);

                        System.Diagnostics.Process.Start("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe", control.Text);
                    };


                    form.Controls.Add(jobApply);
                }

            }

            Label jobDetailTitleLabel = new Label();
            jobDetailTitleLabel.AutoSize = true;
            jobDetailTitleLabel.Font = new Font("Arial", 11, FontStyle.Bold);
            jobDetailTitleLabel.Location = new Point(550, 260);
            jobDetailTitleLabel.Name = "JobDetailTitle";
            jobDetailTitleLabel.Text = "Job details";

            labelListJobInformation.Add(jobDetailTitleLabel);

            form.Controls.Add(jobDetailTitleLabel);

            Label jobFullDetailOverviewLabel = new Label();
            jobFullDetailOverviewLabel.AutoSize = true;
            jobFullDetailOverviewLabel.Font = new Font("Arial", 11, FontStyle.Bold);
            jobFullDetailOverviewLabel.Location = new Point(550, 340);
            jobFullDetailOverviewLabel.Name = "JobOverview";
            jobFullDetailOverviewLabel.Text = "Job Overview";

            labelListJobInformation.Add(jobFullDetailOverviewLabel);

            form.Controls.Add(jobFullDetailOverviewLabel);

            return labelListJobInformation;
        }
    }
}
