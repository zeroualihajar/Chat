using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WS
{
    public class Outil
    {
        static DCDataContext bd = new DCDataContext();

        static public List<participant> participants = new List<participant>();
        static public List<Message> messages = new List<Message>();

        //---- Liste des participants
        static public List<participant> GetParticipants()
        {
            participants = bd.participant.ToList();
            return participants;
        }

        //---- Liste des messsages
        static public List<Message> GetMessages()
        {
            messages = bd.Message.ToList();
            return messages;
        }

        /*static public bool Exists(string pseudo)
        {
            participants = GetParticipants();

            foreach (participant pr in participants)
            {
                if (pr.pseudo.Equals(pseudo)) return true;
            }
            return false;
        }*/


        static public bool Exists(string pseudo)
        {
            string ps;

            // ----Creer  la connexion vers la base des données
            SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-7N0GOOF; Initial Catalog=Chat; Integrated Security =True");

            //---- ouvrir la connexion
            connect.Open();

            //---- Declarer la requete de Liberation du chambre
            SqlCommand cmd = new SqlCommand("SELECT * FROM participant WHERE pseudo = '" + pseudo + "'", connect);

            //---- Exécuter la  commande sur la base de données 
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ps = (string)reader.GetValue(1);
                if (ps.Equals(pseudo)) return true;
            }

            reader.Close();
            //---- Fermer la connexion
            connect.Close();

            return false;
        }

        static public void insertParticipant(string pseudo)
        {
            // ----Creer  la connexion vers la base des données
            SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-7N0GOOF; Initial Catalog=Chat; Integrated Security =True");

            //---- ouvrir la connexion
            connect.Open();

            //---- Declarer la requete d'insertion du client
            SqlCommand cmd = new SqlCommand("INSERT INTO participant VALUES ('" + pseudo + "')", connect);

            //---- Executer la commande
            cmd.ExecuteNonQuery();

            //---- Fermer la connexion
            connect.Close();
        }


        static public void deleteFromMessage(int id)
        {
            // ----Creer  la connexion vers la base des données
            SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-7N0GOOF; Initial Catalog=Chat; Integrated Security =True");

            //---- ouvrir la connexion
            connect.Open();

            //---- Declarer la requete de Liberation du chambre
            SqlCommand cmd = new SqlCommand("DELETE From Message  WHERE idparticipant = '" + id + "'", connect);

            //---- Executer la commande
            cmd.ExecuteNonQuery();

            //---- Fermer la connexion
            connect.Close();
        }
        static public void delete(string pseudo, int id)
        {
            deleteFromMessage(id);
            // ----Creer  la connexion vers la base des données
            SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-7N0GOOF; Initial Catalog=Chat; Integrated Security =True");

            //---- ouvrir la connexion
            connect.Open();

            //---- Declarer la requete de Liberation du chambre
            SqlCommand cmd = new SqlCommand("DELETE From participant  WHERE pseudo = '" + pseudo + "'", connect);
            
            //---- Executer la commande
            cmd.ExecuteNonQuery();

            //---- Fermer la connexion
            connect.Close();

        }

        static public void Insert(string message, int id)
        {
            // ----Creer  la connexion vers la base des données
            SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-7N0GOOF; Initial Catalog=Chat; Integrated Security =True");

            //---- ouvrir la connexion
            connect.Open();

            //---- Declarer la requete de Liberation du chambre
            SqlCommand cmd = new SqlCommand("INSERT INTO Message VALUES ('" + message + "', '"+ id+"')", connect);
           
            //---- Executer la commande
            cmd.ExecuteNonQuery();

            //---- Fermer la connexion
            connect.Close();

        }

        static public int getByPseudo(string pseudo)
        {
            int id = 0;
            // ----Creer  la connexion vers la base des données
            SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-7N0GOOF; Initial Catalog=Chat; Integrated Security =True");

            //---- ouvrir la connexion
            connect.Open();

            //---- Declarer la requete de Liberation du chambre
            SqlCommand cmd = new SqlCommand("SELECT * FROM participant WHERE pseudo = '" +pseudo+"'", connect);

            //---- Exécuter la  commande sur la base de données 
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                id = int.Parse(reader.GetValue(0).ToString());
                break;
            }

            reader.Close();
            //---- Fermer la connexion
            connect.Close();
            return id;

        }


        static public string getById(int id)
        {
            string pseudo = "";
            // ----Creer  la connexion vers la base des données
            SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-7N0GOOF; Initial Catalog=Chat; Integrated Security =True");

            //---- ouvrir la connexion
            connect.Open();

            //---- Declarer la requete de Liberation du chambre
            SqlCommand cmd = new SqlCommand("SELECT * FROM participant WHERE idparticipant = '" + id + "'", connect);

            //---- Exécuter la  commande sur la base de données 
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                pseudo = (string)reader.GetValue(1);
                break;
            }

            reader.Close();
            
            //---- Fermer la connexion
            connect.Close();
            return pseudo;

        }

    }
}