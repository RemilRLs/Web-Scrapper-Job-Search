using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseMySQL;
using MySqlConnector;
using Web_Scraping___Job_Search;
using WishList;

namespace WishList
{
    public class whistList
    {

        public void PutInformationJobWish(string title, string location, string salary, string linkApply)
        {
            DatabaseConnexion database = new DatabaseConnexion();

            // Get the string of the connexion into the database.

            string databaseStringConnexion = database.dataBaseConnexion();
            string queryConstructor = "";

;            using (var connection = new MySqlConnection(databaseStringConnexion))
            {
                // We check if there is no error of authentification.

                try
                {
                    connection.Open();

                    queryConstructor = $"INSERT INTO wishlist (title, location, salary, link) VALUES ('{title}', '{location}', '{salary}', '{linkApply}')";


                    using (MySqlCommand commandSQL = new MySqlCommand(queryConstructor, connection))
                    {
                        commandSQL.ExecuteNonQuery();
                    }

                }
                catch (Exception error)
                {
                    Debug.WriteLine("Error: " + error.Message);

                }

            }
        }

        public void getAllInformationWishListDatabase(DataGridView dataGridWishList)
        {
            WishListForm wishListForm = new WishListForm();
            DatabaseConnexion database = new DatabaseConnexion();

            string databaseStringConnexion = database.dataBaseConnexion();
            MySqlConnection databaseConnexion = new MySqlConnection(databaseStringConnexion);

            DataGridViewButtonColumn applyLinkColumn = new DataGridViewButtonColumn();

            applyLinkColumn.HeaderText = "link";
            applyLinkColumn.Text = "Apply Now";
            applyLinkColumn.DefaultCellStyle.NullValue = "Apply Now";
            applyLinkColumn.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);

            applyLinkColumn.UseColumnTextForButtonValue = true;




            try
            {
                databaseConnexion.Open();

                string queryGetJob = "SELECT DISTINCT id, title, location, salary, link FROM wishlist";


                var databaseCommandQuery = new MySqlCommand(queryGetJob, databaseConnexion);


                MySqlDataReader readerWishInformation = databaseCommandQuery.ExecuteReader();


                while (readerWishInformation.Read())
                {

                    Debug.WriteLine(readerWishInformation["title"] + " - " + readerWishInformation["location"] + " - " + readerWishInformation["salary"]);
                    dataGridWishList.Rows.Add(readerWishInformation["title"], readerWishInformation["location"], readerWishInformation["salary"], readerWishInformation["link"]);


                }



                if (dataGridWishList.Columns.Contains("link"))
                {
                    dataGridWishList.Columns.Add(applyLinkColumn);

                    dataGridWishList.CellClick += (sender, e) =>
                    {
                        if (e.ColumnIndex == applyLinkColumn.Index)
                        {
                            string link = dataGridWishList.Rows[e.RowIndex].Cells["link"].Value.ToString();
                            System.Diagnostics.Process.Start("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe", link);
                        }
                    };
                }


            }
            catch (Exception ex)
            {
                Debug.WriteLine("Erreur" + ex.ToString());
            }

        }

        public void deleteWishDatabase(string selectedRowTitle)
        {
            DatabaseConnexion database = new DatabaseConnexion();

            // Get the string of the connexion into the database.

            string databaseStringConnexion = database.dataBaseConnexion();
            string queryConstructor = "";

            using (var connection = new MySqlConnection(databaseStringConnexion))
            {
                // We check if there is no error of authentification.

                try
                {
                    connection.Open();

                    queryConstructor = $"DELETE FROM wishlist WHERE title = '{selectedRowTitle}'";


                    using (MySqlCommand commandSQL = new MySqlCommand(queryConstructor, connection))
                    {
                        commandSQL.ExecuteNonQuery();
                    }

                }
                catch (Exception error)
                {
                    Debug.WriteLine("Error: " + error.Message);

                }

            }
        }
    }
}
