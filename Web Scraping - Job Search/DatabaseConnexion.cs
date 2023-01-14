using System;
using System.Diagnostics;
using MySqlConnector;


namespace DatabaseMySQL
{
    public class DatabaseConnexion
    {
        /// <summary>
        /// This function creates a connection between the C# program and the MySQL database 
        /// on the job offer table.
        /// </summary>
        /// 

        public string connectionDatabase;
        public string dataBaseConnexion()
        {
            // To change according to what you have chosen.

            string server = "localhost";
            string database = "joboffer";
            string user = "root";
            string password = "salutaumecquipasseparla148";

            // We create a string that allow us to create a connexion between us and the database.

            connectionDatabase = $"server={server};database={database};user={user};password={password}";


            return connectionDatabase;
        }
    }
}
