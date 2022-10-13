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

namespace TPI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        bool bDateValide = false;
        private void btnAppliquer_Click(object sender, EventArgs e)
        {
            controleDate(sender, e);
            if (tbxNom.Text == "" || tbxPrenom.Text == "" || cbxJour.Text == "" || cbxMois.Text  == "" || cbxAnnee.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs", "Champs vides", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string strDate = cbxJour.Text + "/" + (cbxMois.SelectedIndex + 1).ToString() + "/" + cbxAnnee.Text;
                if (bDateValide == true) //Si la date est valide
                {
                    int NbUser = 0;
                    DbDataReader oRdr;
                    //Cette requête va retourner le nombre de personne qui ont ce nom/prenom dans la base de données
                    oRdr = BaseDonnee.Request("SELECT COUNT(Nom_Utilisateur) FROM tbl_Personnes WHERE Nom_Utilisateur='" + (tbxNom.Text).Replace("'", "''") + "' AND Prenom_Utilisateur='" + (tbxPrenom.Text).Replace("'", "''") + "' AND Jour_Naissance_Utilisateur='" + (cbxJour.Text).Replace("'", "''") + "' AND Mois_Naissance_Utilisateur='" + (cbxMois.Text).Replace("'", "''") + "' AND Annee_Naissance_Utilisateur='" + (cbxAnnee.Text).Replace("'", "''") + "';");
                    while (oRdr.Read())
                    {
                        NbUser = (int)oRdr[0];
                    }

                    //Si il n'y a personne sous ce nom, l'utilisateur va être ajouté dans la base
                    if (NbUser == 0)
                    {
                        //Cette requête va ajouter l'utilisateur en fonction des textbox et combobox
                        BaseDonnee.Request("INSERT INTO tbl_Personnes(Nom_Utilisateur,Prenom_Utilisateur,Jour_Naissance_Utilisateur,Mois_Naissance_Utilisateur,Annee_Naissance_Utilisateur) VALUES ('" + tbxNom.Text.Replace("'", "''") + "','" + tbxPrenom.Text.Replace("'", "''") + "','" + cbxJour.Text.Replace("'", "''") + "','" + cbxMois.Text.Replace("'", "''") + "','" + cbxAnnee.Text.Replace("'", "''") + "');");
                        MessageBox.Show("Vous avez été correctement enregistré(e), amusez-vous bien!", "Inscription validée", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ActiveForm.Hide(); //Cache le formulaire de Login
                    Jeu Jeu = new Jeu();
                    Jeu.Show(); //Affiche le formulaire de Jeu
                    Params.Default.strNom = tbxNom.Text;
                    Params.Default.strPrenom = tbxPrenom.Text;
                    Params.Default.strJourNaissance = cbxJour.Text;
                    Params.Default.strMoisNaissance = cbxMois.Text;
                    Params.Default.strAnneeNaissance = cbxAnnee.Text;
                }
            }
            DbDataReader iD;
            iD = BaseDonnee.Request("SELECT tbl_Personnes.ID FROM tbl_Personnes WHERE Nom_Utilisateur='" + (tbxNom.Text).Replace("'", "''") + "' AND Prenom_Utilisateur='" + (tbxPrenom.Text).Replace("'", "''") + "' AND Jour_Naissance_Utilisateur='" + (cbxJour.Text).Replace("'", "''") + "' AND Mois_Naissance_Utilisateur='" + (cbxMois.Text).Replace("'", "''") + "' AND Annee_Naissance_Utilisateur='" + (cbxAnnee.Text).Replace("'", "''") + "';");
            while (iD.Read())
            {
                Params.Default.iID = Convert.ToInt32(iD["ID"]);
                Params.Default.Save();
            }
        }

        private void controleDate(object sender, EventArgs e)
        {
            lblDatenaissance.ForeColor = Color.Black; //Remet la couleur par défaut (noir) au label
            DateTime dt;
            string strDate = cbxJour.Text + "/" + (cbxMois.SelectedIndex + 1).ToString() + "/" + cbxAnnee.Text;
            if (DateTime.TryParse(strDate, out dt)) //Si la date est valide
            {
                if (dt.CompareTo(DateTime.Now) < 1) //Si la date n'est pas dans le futur
                {
                    pbxErreur.ImageLocation = @"";
                    bDateValide = true;
                    btnAppliquer.Enabled = true;
                }
                else //Si la date est dans le futurs
                {
                    pbxErreur.ImageLocation = @"error.png";
                    bDateValide = false;
                    lblDatenaissance.ForeColor = Color.Red;
                    btnAppliquer.Enabled = false;
                }
            }
            else  //Si la date n'est pas valide.
            {
                if (cbxJour.Text != "" && cbxMois.Text != "" && cbxAnnee.Text != "")
                {
                    pbxErreur.ImageLocation = @"error.png";
                    bDateValide = false;
                    lblDatenaissance.ForeColor = Color.Red;
                    btnAppliquer.Enabled = false;
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //Peuple la liste déroulante des années, afin que lorsque l'on passe à une nouvelle année, la liste se mette à jour d'elle même.
            cbxAnnee.Items.Clear();
            int[] iAnnee;
            int iAnneeDepart = 1940;
            iAnnee = new int[(Convert.ToInt32(DateTime.Now.Year + 1) - iAnneeDepart)];

            for (int iCpt = 0; iCpt < (Convert.ToInt32(DateTime.Now.Year + 1) - iAnneeDepart); iCpt++)
            {
                iAnnee[iCpt] = (iAnneeDepart + iCpt);
                cbxAnnee.Items.Add(iAnnee[iCpt]);
            }
        }

        private void tbxKeyPress(object sender, KeyPressEventArgs e) //N'accepte que les lettres, les espaces, le caractère "-", le caractère "'".
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar) && e.KeyChar != Convert.ToChar("-") && e.KeyChar != Convert.ToChar("'");
        }
    }
}
