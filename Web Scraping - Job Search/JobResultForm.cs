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
using ShowInformation;
using static System.Windows.Forms.DataFormats;

namespace Web_Scraping___Job_Search
{
    public partial class JobResultForm : Form
    {
        ShowJobInformation showJobInfo = new ShowJobInformation();
        JobHistoryForm jobHistory = new JobHistoryForm();
        List<Label> labelListInformationJob;



        public JobResultForm()
        {
            InitializeComponent();
        }

        private void JobResultForm_Load(object sender, EventArgs e)
        {
            showJobInfo.offset = 3;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            string iconFile = "ressources..\\..\\..\\..\\..\\ressources\\icons\\fingerprint.circ";
            this.Icon = new Icon(iconFile);

            pictureBoxLogo.Image = Image.FromFile("ressources..\\..\\..\\..\\..\\ressources\\logo\\find_job_logo.jpg");
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;

            ButtonInteractJob2.BackgroundImage = Image.FromFile("ressources..\\..\\..\\..\\..\\ressources\\icons\\right-chevron.png");
            ButtonInteractJob2.BackgroundImageLayout = ImageLayout.Stretch;

            ButtonInteractJob1.BackgroundImage = Image.FromFile("ressources..\\..\\..\\..\\..\\ressources\\icons\\left-chevron.png");
            ButtonInteractJob1.BackgroundImageLayout = ImageLayout.Stretch;

            this.AutoScroll = true;

            foreach (Control control in this.Controls)
            {
                // Check if the control is a Button
                if (control is Button && control.Name.StartsWith("TitleButton"))
                {

                    control.Click += new EventHandler(TitleJobButton_Click);
                }
            }
        }


        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void ButtonNextJob_Click_1(object sender, EventArgs e)
        {
            
            if(showJobInfo.offset < 0)
            {
                showJobInfo.offset = 0;
            }
            


            foreach (Label label in this.Controls.OfType<Label>())
            {
                this.Controls.Remove(label);
            }

            if (labelListInformationJob != null)
            {
                foreach (Label label in labelListInformationJob)
                {
                    label.Text = "";
                    this.Controls.Remove(label);
                }
            }

            foreach (Button button in this.Controls.OfType<Button>())
            {
                
                if (button.Name.StartsWith("ButtonInteractJob"))
                {
                    // Do nothing.

                }
                else
                {
                    this.Controls.Remove(button);
                }
            }

            showJobInfo.offset += 3;
            showJobInfo.ShowJobInformationData(this);
            

            foreach (Control control in this.Controls)
            {
                // Check if the control is a Button
                if (control is Button && control.Name.StartsWith("TitleButton"))
                {

                    control.Click += new EventHandler(TitleJobButton_Click);
                }
            }
        }

        private void ButtonPreviousJob_Click(object sender, EventArgs e)
        {



            foreach (Label label in this.Controls.OfType<Label>())
            {
                this.Controls.Remove(label);
            }

            if (labelListInformationJob != null)
            {
                foreach (Label label in labelListInformationJob)
                {
                    label.Text = "";
                    this.Controls.Remove(label);
                }
            }

            foreach (Button button in this.Controls.OfType<Button>())
            {

                if (button.Name.StartsWith("ButtonInteractJob"))
                {
                    // Do nothing.

                }
                else
                {
                    this.Controls.Remove(button);
                }
            }

            showJobInfo.offset -= 3;

            if (showJobInfo.offset < 0)
            {
                showJobInfo.offset = 0;
            }
            showJobInfo.ShowJobInformationData(this);


            foreach (Control control in this.Controls)
            {
                // Check if the control is a Button
                if (control is Button && control.Name.StartsWith("TitleButton"))
                {

                    control.Click += new EventHandler(TitleJobButton_Click);
                }
            }
        }


        private void TitleJobButton_Click(object sender, EventArgs e)
        {

            // If another button title is click we remove everything.

            if(labelListInformationJob != null)
            {
                foreach (Label label in labelListInformationJob)
                {
                    label.Text = "";
                    this.Controls.Remove(label);
                }

                foreach(Button buttonApply in this.Controls.OfType<Button>())
                {
                    if (buttonApply.Name.StartsWith("ButtonApply"))
                    {
                        this.Controls.Remove(buttonApply);
                    }

                    else if (buttonApply.Name.StartsWith("ButtonWish"))
                    {
                        this.Controls.Remove(buttonApply);
                    }
                }
            }


            Button button = sender as Button;
            string lastChar = button.Name.Substring(button.Name.Length - 1);


            labelListInformationJob = showJobInfo.ShowMoreInformationJob(this, lastChar);
        }

        private void recentSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            jobHistory.Show();
        }

        private void findJobsButton_Click(object sender, EventArgs e)
        {
            Form1 jobSearch = new Form1();

            this.Hide();
            jobSearch.Show();
        }

        private void resultSearch_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            Form1 jobSearch = new Form1();

            this.Hide();
            jobSearch.Show();
        }

        private void wishListButton_Click(object sender, EventArgs e)
        {
            WishListForm wishList = new WishListForm();

            this.Hide();
            wishList.Show();
        }
    }
}
