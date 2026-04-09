using System;
using System.Collections.Generic;
using System.Windows.Forms;
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
            try
            {
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
            }
            catch (MySqlException)
            {
                MessageBox.Show("Es konnte keine Verbindung zur Datenbank hergestellt werden. Bitte überprüfe ob der Server erreichbar ist.");
            }
            return liste;
        }

        public void AddWorkshop(string titel)
        {
            if (titel.Length > 255)
            {
                MessageBox.Show("Der Titel ist zu lang. Bitte maximal 255 Zeichen eingeben.");
                return;
            }
            try
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
            catch (MySqlException)
            {
                MessageBox.Show("Es konnte keine Verbindung zur Datenbank hergestellt werden. Bitte überprüfe ob der Server erreichbar ist.");
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