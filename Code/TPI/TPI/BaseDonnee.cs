using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Permets l'utilisation des utilitaires de base de données
using System.Data.Common;
using System.Data.OleDb;
//Permets l'utilisation du fichier de config
using System.Configuration;
using System.Threading;

namespace TPI
{
    public class BaseDonnee
    {
        public static DbDataReader Request(string Request)
        {
            DbProviderFactory dbpf = DbProviderFactories.GetFactory("System.Data.Oledb");
            DbConnection Connection = dbpf.CreateConnection();
            Connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data source=TPI.mdb; Persist Security Info=False;";
            DbCommand oCmd = Connection.CreateCommand();
            oCmd.CommandText = Request;
            DbDataReader oRdr = null;
            try { Connection.Open(); } //Le Try-Catch Evite les erreurs si l'utilisateur rentre trop vite des frappes au clavier dans le formulaire Scores. ( A Cause de l'evenement TextChanged du numericUpDown)
            catch {  }
            
            //Vérifie si la requête doit donner un retour
            if (Request.IndexOf("SELECT") > -1)
            {
                try { oRdr = oCmd.ExecuteReader(); } //Le Try-Catch Evite les erreurs si l'utilisateur rentre trop vite des frappes au clavier dans le formulaire Scores. ( A Cause de l'evenement TextChanged du numericUpDown)
                catch { }
                
            }
            else
            {
                oCmd.ExecuteNonQuery();
            }
            return oRdr;
        }
    }
}
