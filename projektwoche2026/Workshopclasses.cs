using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Projektwoche2026
{
    public class Workshop
    {
        public int WorkshopID;
        public string Titel;
    }

    public class WorkshopModel
    {
        string connStr = "server=127.0.0.1;uid=root;pwd=;database=projektwoche2026;";

        public List<Workshop> GetTitel()
        {
            List<Workshop> liste = new List<Workshop>();
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT workshopID, titel FROM workshop";
                conn.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Workshop w = new Workshop();
                        w.WorkshopID = Convert.ToInt32(reader["workshopID"]);
                        w.Titel = reader["titel"].ToString();
                        liste.Add(w);
                    }
                }
            }
            return liste;
        }

        public void AddWorkshop(string titel)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO workshop (titel) VALUES (@titel)";
                cmd.Parameters.AddWithValue("@titel", titel);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }

    public class WorkshopController
    {
        WorkshopModel model = new WorkshopModel();

        public List<Workshop> LadeTitel()
        {
            return model.GetTitel();
        }

        public void NeuerWorkshop(string titel)
        {
            model.AddWorkshop(titel);
        }
    }
}