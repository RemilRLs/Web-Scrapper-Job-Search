using System.Net;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using HtmlAgilityPack;
using WebScrapper;
using JobCharacteristic;
using System.Xml.Linq;
using MySqlConnector;
using DatabaseMySQL;
using System.Text.RegularExpressions;
using System.Data;
using WebScrapper;
using Web_Scraping___Job_Search;

namespace JobSearchTool
{
    public class JobSearchInformation : URLDataFinder
    {
        
        //URLDataFinder newURLDataFinder = new URLDataFinder();
        public AutoCompleteStringCollection jobTitle = new AutoCompleteStringCollection();
        public AutoCompleteStringCollection jobCity = new AutoCompleteStringCollection();

        public bool GetJobInformation(HtmlAgilityPack.HtmlDocument document)
        {
            Form1 form = new Form1();
            JobResultForm jobResultForm = new JobResultForm();

            HtmlNode nodeMainDiv = document.DocumentNode.SelectSingleNode("//ol[@id='uxMainContent_uxResultsOL']");

            if(nodeMainDiv!= null )
            {
                GetAllInformationJob(nodeMainDiv);

                return true;
            }
            else
            {

                return false;
            }


        }

        public string GetApplyLinkJob(string applyLinkString)
        {
            inputUserURL = applyLinkString;
            HtmlAgilityPack.HtmlDocument document = SearchApplyJob();

            HtmlNode applyRedirectLinkNode = document.DocumentNode.SelectSingleNode("//div[@class='aside vacancy-aside']/div/div/a[@class='vacancy-apply']");
            string applyRedirectLink = "https://starjobsearch.co.uk/" + applyRedirectLinkNode.GetAttributeValue("href", "");

            return applyRedirectLink;
        }

        private void GetAllInformationJob(HtmlNode nodes)
        {
            int count = 0;

            // We reset the table of result.

            string sqlDelete = "TRUNCATE TABLE joboffer";
            PutJobInformationDatabase(sqlDelete);

            HtmlNodeCollection jobInformation = nodes.SelectNodes("//li[@id]");
            
            if(jobInformation != null){



                foreach(HtmlNode nodeInformation in jobInformation)
                {
                    var jobOffer = new JobOffer(); // We create a new object for each job offer.

                    // Create a unique ID for the Job.

                    jobOffer.id = count;

                    // Get Title of the Job.
                    if (nodeInformation.SelectSingleNode(".//div/h2/a") != null)
                    {
                        string jobTitle = nodeInformation.SelectSingleNode(".//div/h2/a").InnerText;
                        //Debug.WriteLine(jobTitle);
                        jobOffer.title = jobTitle;
                        
                    }
                    else
                    {
                        continue;
                    }

                    // Get Description of the Job.

                    if (nodeInformation.SelectSingleNode(".//p") != null)
                    {
                        string jobDescription = nodeInformation.SelectSingleNode(".//p").InnerText;
                        //Debug.WriteLine(jobDescription);
                        jobOffer.description = jobDescription;

                    }

                    // Get Salary of the Job.
                    if (nodeInformation.SelectSingleNode(".//div/dl/dd[@class='salary']") != null)
                    {
                        string salary = nodeInformation.SelectSingleNode(".//div/dl/dd[@class='salary']").InnerText;

                        salary = salary.Replace("&#163;", "£");

                        //Debug.WriteLine(salary);
                        jobOffer.salary = salary;
                    }

                    // Get the location of the Job.

                    if (nodeInformation.SelectSingleNode(".//div/dl/dd[@class='location']") != null)
                    {
                        string location = nodeInformation.SelectSingleNode(".//div/dl/dd[@class='location']").InnerText;

                        ///Debug.WriteLine(location);
                        jobOffer.location = location;
                    }

                    // Get image link of the Job.

                    if (nodeInformation.SelectSingleNode(".//div/div/a/img") != null)
                    {
                        

                        string jobImageLink = nodeInformation.SelectSingleNode(".//div/div/a/img").Attributes["src"].Value;
                        //Debug.WriteLine("Image src : " + jobImageLink);
                        jobOffer.jobImageLink = jobImageLink;
                    }

                    // Get Link Apply Now Job.

                    if (nodeInformation.SelectSingleNode(".//div/a[@class='view']") != null)
                    {
                        HtmlNode applyLinkElement = nodeInformation.SelectSingleNode(".//div/a[@class='view']");
                        string applyLinkString = "https://starjobsearch.co.uk/" + applyLinkElement.GetAttributeValue("href", "");

                        string applyLink =  GetApplyLinkJob(applyLinkString);

                        jobOffer.jobLinkApply = applyLink;
                    }
                    
                    string sqlCommand = $"INSERT INTO joboffer (title,salary,location, description, apply_link) VALUES ('{jobOffer.title}','{jobOffer.salary}','{jobOffer.location}', '{jobOffer.description}', '{jobOffer.jobLinkApply}')";
                    
                    PutJobInformationDatabase(sqlCommand);
                    count++;
                    
            }

            }
            else
            {
                Debug.WriteLine("[X] - No information was found in the HTML document (No job).");
            }
            
        }

        private void PutJobInformationDatabase(string commandSQLToQuery)
        {
            DatabaseConnexion database = new DatabaseConnexion();
            
            string databaseStringConnexion = database.dataBaseConnexion();

            using (var connection = new MySqlConnection(databaseStringConnexion))
            {
                // We check if there is no error of authentification.

                try
                {
                    connection.Open();

                    

                    using (var commandSQL = new MySqlCommand(commandSQLToQuery, connection))
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

        public void PutInformationCollectionJobTitle(string commandSQLToQuery)
        {
            DatabaseConnexion database = new DatabaseConnexion();
            
            

            string databaseStringConnexion = database.dataBaseConnexion();

            using (var connection = new MySqlConnection(databaseStringConnexion))
            {
                // We check if there is no error of authentification.

                try
                {
                    connection.Open();



                    using (MySqlCommand commandSQL = new MySqlCommand(commandSQLToQuery, connection))
                    {

                        // Read every rows of the column job title into the database.

                        using(MySqlDataReader readerJobTitle = commandSQL.ExecuteReader())
                        {
                            
                            while (readerJobTitle.Read())
                            {
                                //jobTitle.Add((string)readerJobTitle["title"]);
                                string test = (string)readerJobTitle["jobtitle"];


                                 
                                jobTitle.Add((string)readerJobTitle["jobtitle"]);

                            }

                        }

                    }

                }
                catch (Exception error)
                {
                    Debug.WriteLine("Error: " + error.Message);

                }

            }

        }

        public void PutInformationCollectionJobCity(string commandSQLToQuery)
        {
            DatabaseConnexion database = new DatabaseConnexion();



            string databaseStringConnexion = database.dataBaseConnexion();

            using (var connection = new MySqlConnection(databaseStringConnexion))
            {
                // We check if there is no error of authentification.

                try
                {
                    connection.Open();



                    using (MySqlCommand commandSQL = new MySqlCommand(commandSQLToQuery, connection))
                    {

                        // Read every rows of the column job city into the database.

                        using (MySqlDataReader readerJobTitle = commandSQL.ExecuteReader())
                        {

                            while (readerJobTitle.Read())
                            {
                                //jobTitle.Add((string)readerJobTitle["title"]);
                                string test = (string)readerJobTitle["city"];



                                jobCity.Add((string)readerJobTitle["city"]);

                            }

                        }

                    }

                }
                catch (Exception error)
                {
                    Debug.WriteLine("Error: " + error.Message);

                }

            }

        }

        public void PutLocationAndTitleJobDatabaseHistory(string titleJob, string localizationJob)
        {
            DatabaseConnexion database = new DatabaseConnexion();
            string databaseStringConnexion = database.dataBaseConnexion();

            using (var connexion = new MySqlConnection(databaseStringConnexion))
            {
                try
                {
                    connexion.Open();
                    string queryDatabase = $"INSERT INTO job_titles_history (title_job, job_localization_id) VALUES ('{titleJob}', (SELECT id FROM research_information_jobcity WHERE city = '{localizationJob}' LIMIT 1 OFFSET 0))";

                    using (MySqlCommand commandSQL = new MySqlCommand(queryDatabase, connexion))
                    {
                        commandSQL.ExecuteNonQuery();
                    }
                }
                catch (Exception error)
                {
                    Debug.WriteLine($"Error: {error.Message}");
                }
            }
        }
    }
}
    