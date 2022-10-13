using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Permets l'utilisation des utilitaires de base de données
using System.Data.Common;
using System.Data.OleDb;
//Permets l'utilisation du fichier de config
using System.Configuration;
//Permets l'utilisation des fonctions d'impression
using System.Drawing.Printing;
using System.Threading; //Va permette de mettre en pause le temps que la supression des données se fasse.

namespace TPI
{
    public partial class Scores : Form
    {
        public Scores()
        {
            InitializeComponent();
            this.pdImpression.PrintPage += new PrintPageEventHandler(this.pdImpression_PrintPage);
        }
        //Va permettre l'impression
        PrintDocument pdImpression = new PrintDocument();
        DataGridViewPrinter dgvPrinter; //Objet permettant l'impression
        string strMessageErreur = "";

        private void dataGridViewData(object sender, EventArgs e)
        {
            if (tbx_Temps.Text != "-")
            {
                string Temps = tbx_Temps.Value.ToString();
                //Construction de la requête selon les options choisies par l'utilisateur
                string Requete = "SELECT tbl_Personnes.Nom_Utilisateur, tbl_Personnes.Prenom_Utilisateur, tbl_Performances.ResultatTotal, tbl_Performances.Jour, tbl_Performances.Mois, tbl_Performances.Annee, tbl_Performances.Temps, tbl_Performances.Heure" + " FROM tbl_Personnes" + " INNER JOIN tbl_Performances ON tbl_Personnes.ID = tbl_Performances.num_tbl_Personnes";
                Requete += " WHERE tbl_Performances.Temps=" + tbx_Temps.Value;
                Requete += " AND tbl_Performances.Difficulte=" + cbxDifficulte.SelectedIndex + "";
                //Test si l'utilisateur veux tout le monde ou uniquement ses résultats
                if (rbtn_Personnel.Checked)
                {
                    Requete += " AND (tbl_Personnes.ID = " + Params.Default.iID.ToString() + " )";
                }
                Requete += " ORDER BY tbl_Performances.ResultatTotal ASC";
                DbDataReader oRdr = BaseDonnee.Request(Requete);
                DataTable dt = new DataTable();
                //Création de la datatable pour des résultats d'un utilisateur
                if (rbtn_Personnel.Checked)
                {
                    dt.Columns.Add("Résultat", Type.GetType("System.Int32"));
                    dt.Columns.Add("Date", Type.GetType("System.String"));
                    dt.Columns.Add("Heure", Type.GetType("System.String"));
                    //Peuple la datatable
                    try //Le Try-Catch Evite les erreurs si l'utilisateur rentre trop vite des frappes au clavier dans le formulaire Scores ( A Cause de l'evenement TextChanged du numericUpDown)
                    {
                        while (oRdr.Read())
                        {
                            DataRow r = dt.NewRow();
                            r["Résultat"] = oRdr["ResultatTotal"].ToString();
                            r["Date"] = oRdr["Jour"] + " / " + oRdr["Mois"] + " / " + oRdr["Annee"];
                            r["Heure"] = oRdr["Heure"].ToString();
                            dt.Rows.Add(r);
                        }
                    }
                    catch 
                    {

                    }
                }
                else
                {
                    //création de datatable pour plusieurs utilisateurs   
                    dt.Columns.Add("Nom", Type.GetType("System.String"));
                    dt.Columns.Add("Prenom", Type.GetType("System.String"));
                    dt.Columns.Add("Résultat", Type.GetType("System.Int32"));
                    dt.Columns.Add("Date", Type.GetType("System.String"));
                    dt.Columns.Add("Heure", Type.GetType("System.String"));
                    //Peuple la datatable
                    try //Le Try-Catch Evite les erreurs si l'utilisateur rentre trop vite des frappes au clavier dans le formulaire Scores ( A Cause de l'evenement TextChanged du numericUpDown)
                    {
                        while (oRdr.Read())
                        {
                            DataRow r = dt.NewRow();
                            r["Nom"] = oRdr["Nom_Utilisateur"].ToString();
                            r["Prenom"] = oRdr["Prenom_Utilisateur"].ToString();
                            r["Résultat"] = oRdr["ResultatTotal"].ToString();
                            r["Date"] = oRdr["Jour"] + " / " + oRdr["Mois"] + " / " + oRdr["Annee"];
                            r["Heure"] = oRdr["Heure"].ToString();
                            dt.Rows.Add(r);
                        }
                    }
                    catch
                    {
                        
                    }

                }
                //Affiche la DataTable dans le DataGridView
                dataGridView.DataSource = dt;
                if (rbtn_Personnel.Checked)
                {
                    //Donne l'ordre dans lequel les colonnes doivent être afficher
                    dataGridView.Columns["Résultat"].DisplayIndex = 0;
                    dataGridView.Columns["Date"].DisplayIndex = 1;
                    dataGridView.Columns["Heure"].DisplayIndex = 2;
                }
                else
                {
                    dataGridView.Columns["Nom"].DisplayIndex = 0;
                    dataGridView.Columns["Prenom"].DisplayIndex = 1;
                    dataGridView.Columns["Résultat"].DisplayIndex = 2;
                    dataGridView.Columns["Date"].DisplayIndex = 3;
                    dataGridView.Columns["Heure"].DisplayIndex = 4;
                }
                dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells); //Permet de faire que la largueur de chaque colonne s'ajuste automatiquement.
            }
            else
            {
                strMessageErreur = "Le caractère \"-\" est interdit";
            }


            //Affichage de l'erreur s'il y en a une
            if (strMessageErreur != "")
            {
                MessageBox.Show(strMessageErreur, "Erreur de saisie");
            }
        }

        private void Scores_Load(object sender, EventArgs e)
        {
            tsbSupressionScoresUtilisateur.Text = "Vider les scores pour \n" + Params.Default.strNom + " " + Params.Default.strPrenom;
            cbxDifficulte.SelectedIndex = Params.Default.iDifficulte; //Affiche la valeur de la difficulté en cours par défaut, sinon il apparaît vide.
            rbtn_Personnel.Text = Params.Default.strNom + " " + Params.Default.strPrenom;
            tbx_Temps.Value = Params.Default.iTempsPartie;
        }

        private void tsbImprimer_Click(object sender, EventArgs e)
        {
            if(print() == true)
            {
                pdImpression.Print(); //Va finaliser l'impression
            }
        }

        private bool print()
        {
            //Ouverture d'une boite de dialogue d'impression
            PrintDialog MyPrintDialog = new PrintDialog();
            if (MyPrintDialog.ShowDialog() != DialogResult.OK)
                return false;

            //Affectation des options selectionnées dans la boite de dialogue d'impression
            pdImpression.DocumentName = "Résultats";
            pdImpression.PrinterSettings = MyPrintDialog.PrinterSettings;
            pdImpression.DefaultPageSettings = MyPrintDialog.PrinterSettings.DefaultPageSettings;

            //Création du contenu du titre de l'impression
            string strTitre = "";
            if (rbtn_Personnel.Checked)
                strTitre = "Résultats pour :\n" + Params.Default.strNom + " " + Params.Default.strPrenom + " \n " + Params.Default.strJourNaissance + " " + Params.Default.strMoisNaissance + " " + Params.Default.strAnneeNaissance +"\nDifficulté supplémentaire : " + Params.Default.iDifficulte.ToString() + "/3 \nTemps: " + Params.Default.iTempsPartie+" secondes";
            else
                strTitre = "Classement\n\n\nDifficulté supplémentaire : " + Params.Default.iDifficulte.ToString() + "/3 \nTemps: " + Params.Default.iTempsPartie+" secondes";

            //Création de l'objet à imprimer
            dgvPrinter = new DataGridViewPrinter(dataGridView,
            pdImpression, true, true, strTitre, new Font("Microsoft sans serif", 20,
            FontStyle.Bold, GraphicsUnit.Point), Color.Black, true);

            return true;
        }

        // L'évenement d'impression de l'objet MyPrintDocument
        private void pdImpression_PrintPage(object sender, PrintPageEventArgs e)
        {
            bool more = dgvPrinter.DrawDataGridView(e.Graphics); //Détecte s'il reste d'autres pages
            if (more == true)
                e.HasMorePages = true;
        }

        private void tsbQuitter_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Jeu = new Jeu();
            Jeu.Show();
        }

        private void Scores_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0); //Fermture propre au cas où l'utilisateur arriverait à fermer le formulaire, bien que la controlbox ne soit plus présente.
        }

        private void tsbSupressionScoresTout_Click(object sender, EventArgs e)
        {
            DialogResult drConfirmation = MessageBox.Show("Êtes-vous sûr de vouloir supprimer tout les résulats ?",
            "Attention",
            MessageBoxButtons.YesNo,
		    MessageBoxIcon.Question,
		    MessageBoxDefaultButton.Button2); //Le bouton non aura le focus par défaut.

            if (drConfirmation == DialogResult.Yes)
            {
                string Requete = "DELETE FROM tbl_Performances"; //Vu qu'il n'y a pas de clause WHERE, toute la table sera vidée. (Truncate ne fonctionne apparemment pas dans une base Access).
                DbDataReader oRdr = BaseDonnee.Request(Requete);
                Thread.Sleep(3000);  //Pour qu'au performClick, toute action se soit déjà terminée.
                rbtn_Tous.PerformClick(); //Clique sur le bouton pour afficher les scores personnels, vu qu'on viens de supprimer tout les résulats de l'utilisateur en cours. ( Afin de rafraîchir)
            }
        }

        private void tsbSupressionScoresUtilisateur_Click(object sender, EventArgs e)
        {
            DialogResult drConfirmation = MessageBox.Show("Êtes-vous sûr de vouloir supprimer tout les résulats pour "+Params.Default.strNom+" "+Params.Default.strPrenom+" ?",
            "Attention",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2); //Le bouton non aura le focus par défaut.

            if (drConfirmation == DialogResult.Yes) //Supression des résultats liés à l'utilisateur en cours
            {
                string Requete = "DELETE tbl_Performances.* FROM tbl_Performances INNER JOIN tbl_Personnes ON tbl_Personnes.ID = tbl_Performances.num_tbl_Personnes"; //Vu qu'il n'y a pas de clause WHERE, toute la tabel sera vidée. (Truncate ne fonctionne apparemment pas dans une base Access).
                Requete += " WHERE " + "(tbl_Personnes.ID = " + Params.Default.iID.ToString() + " );";
                DbDataReader oRdr = BaseDonnee.Request(Requete);
                Thread.Sleep(3000);
                rbtn_Personnel.PerformClick(); //Clique sur le bouton pour afficher les scores personnels, vu qu'on viens de supprimer tout les résulats de l'utilisateur en cours. ( Afin de rafraîchir)
            }
        }

        private void update(object sender, KeyPressEventArgs e)
        { //Vérifie l'entrée clavier faite par l'utilisateur afin d'en retirer les caractères non désirés dans un numericUpDown
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            Thread.Sleep(100);
            dataGridViewData(sender, e);
        }
    }
}
