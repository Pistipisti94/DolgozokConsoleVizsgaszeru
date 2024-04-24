using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace DolgozokConsole
{
    internal class Adatbazis
    {
        MySqlCommand command;
        MySqlConnection connection; 
        public Adatbazis() 
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Database = "dolgozok";
            builder.Password = "";

            connection = new MySqlConnection(builder.ConnectionString);
            command = connection.CreateCommand();
            try
            {
                KapcsolatNyit();
                KapcsolatZar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                Environment.Exit(0);
            }

        }

        private void KapcsolatZar()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        private void KapcsolatNyit()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }

        internal List<Dolgozok> getAllDolgozo()
        {
            List<Dolgozok> dolgozoks = new List<Dolgozok>();

            return dolgozoks;
        }
    }
}
