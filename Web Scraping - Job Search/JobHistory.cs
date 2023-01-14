using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using DatabaseMySQL;
using System.Diagnostics;
using System.Windows.Forms;

namespace JobHistoryCheck
{
    public class JobHistory
    {
        public void GetHistoryJob(Form histoForm)
        {
            DatabaseConnexion database = new DatabaseConnexion();
            string databaseStringConnexion = database.dataBaseConnexion();
            int offsetButton = 150;

            MySqlConnection connexion = new MySqlConnection(databaseStringConnexion);

            try
            {
                connexion.Open();
                string queryDatabase = "SELECT DISTINCT city, title_job FROM joboffer.research_information_jobcity JOIN joboffer.job_titles_history ON joboffer.job_titles_history.job_localization_id = joboffer.research_information_jobcity.id";

                MySqlCommand command = new MySqlCommand(queryDatabase, connexion);

                MySqlDataReader readHistoryInformation = command.ExecuteReader();

                while (readHistoryInformation.Read())
                {
                    Debug.WriteLine(readHistoryInformation["city"]);
                    Debug.WriteLine(readHistoryInformation["title_job"]);

                    Button historyButton = new Button();

                    historyButton.Width = 250;
                    historyButton.Height = 60;
                    //historyButton.Location = new Point(30, offsetButton);  // Adjust this as needed to position the label.
                    historyButton.ForeColor = Color.Black;
                    historyButton.Font = new Font("Arial", 10);

                    historyButton.Left = (histoForm.ClientSize.Width / 2) - (historyButton.Width / 2);
                    historyButton.Top = offsetButton;


                    historyButton.Text = readHistoryInformation["title_job"] + "\nin " + readHistoryInformation["city"] + "";

                    historyButton.Name = "HistoryButton";
                    histoForm.Controls.Add(historyButton);


                    /*
                     * Selection de l'id dans la base de données cette  id sera link to a button to delete l'historique
                    */


                    offsetButton += 70;
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine("Error : ", ex.Message);
            }
        }
    }
}
