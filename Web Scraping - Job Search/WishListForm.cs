using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WishList;

namespace Web_Scraping___Job_Search
{
    public partial class WishListForm : Form
    {
        public WishListForm()
        {
            InitializeComponent();
        }

        private void WishListForm_Load(object sender, EventArgs e)
        {

            whistList whish = new whistList(); 

            string iconFile = "ressources..\\..\\..\\..\\..\\ressources\\icons\\fingerprint.circ";
            this.Icon = new Icon(iconFile);

            pictureBoxLogo.Image = Image.FromFile("ressources..\\..\\..\\..\\..\\ressources\\logo\\find_job_logo.jpg");
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;


            dataGridViewWishList.Columns.Add("title", "Job title");
            dataGridViewWishList.Columns.Add("location", "Job location");
            dataGridViewWishList.Columns.Add("salary", "Job salary");
            dataGridViewWishList.Columns.Add("link", "Apply Link");



            // We had a button to the datagrid.




            whish.getAllInformationWishListDatabase(dataGridViewWishList);

        }

        private void findJobsButton_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();

            this.Hide();
            form.Show();
        }

        private void clearRowButton_Click(object sender, EventArgs e)
        {

            whistList wish = new whistList();
            // If there is a row that is selected.

            if (dataGridViewWishList.CurrentRow != null){

                int indexRow = dataGridViewWishList.CurrentRow.Index;

                string selectedRow = dataGridViewWishList.Rows[indexRow].Cells["title"].Value.ToString();
                dataGridViewWishList.Rows.RemoveAt(indexRow);

                wish.deleteWishDatabase(selectedRow);


            }
        }
    }
}
