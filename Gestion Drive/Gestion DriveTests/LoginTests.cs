using Microsoft.VisualStudio.TestTools.UnitTesting;
using Gestion_Drive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Gestion_Drive.Tests
{
    [TestClass()]
    public class LoginTests
    {
        [TestMethod()]
        MySqlConnection con = new MySqlConnection("server = localhost; userid = root; password='' ; database=projet2");

        public void TestRole()
        {
            con.Open();
            string login = "Select * FROM user where ID_USER = '2'";
            MySqlCommand cmd = new MySqlCommand(login, con);

            MySqlDataReader reader = cmd.ExecuteReader();

            List<string> user = new List<string>();

            /**
             * permet de lire les informations de la bdd
             * 
            */

            while (reader.Read())
            {
                user.Add(reader["ID_USER"].ToString());
                user.Add(reader["ID_ROLE"].ToString());
                user.Add(reader["IDENTIFIANT"].ToString());
                user.Add(reader["motdepasse"].ToString());
            }
            if (user[1] == "1")
            {
                Console.WriteLine("Le test est bon");
            }
            else
            {
                Console.WriteLine("Le test est faux");
            }
        }
    }
}