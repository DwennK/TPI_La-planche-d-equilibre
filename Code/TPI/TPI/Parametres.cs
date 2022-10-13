using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TPI
{
    public partial class Parametres : Form
    {
        public Parametres()
        {
            InitializeComponent();
        }

        private void Parametres_Load(object sender, EventArgs e)
        {
            //Peuple les Textbox, la Combobox et la checkbox depuis le fichier Params.settings
            tbxMillisecondes.Text = Params.Default.iMillisecondes.ToString();
            tbxTempsPartie.Text = Params.Default.iTempsPartie.ToString();
            cbxDifficulte.SelectedIndex = Params.Default.iDifficulte;
            checkEntrainement.Checked = Params.Default.bEntrainement;

            //Permet d'appuyer sur le bouton appliquer lorsque l'utilisateur appuie sur la touche "Enter"
            this.AcceptButton = btnAppliquer;
        }

        private void btnAppliquer_Click(object sender, EventArgs e)
        {
            //Déclaration et reset du message contenant les erreurs
            string strMessageErreur = "";

            //Test des valeurs entrées par l'utilisateur
            if (tbxMillisecondes.Text != "" && tbxTempsPartie.Text != "" && cbxDifficulte.Text != "") //Si les trois champs ne sont pas vides
            {
                int iTemp;
                bool bValide = false;

                //Teste la valeur entrée pour les millisecondes
                bValide = int.TryParse(tbxMillisecondes.Value.ToString(), out iTemp);
                if (iTemp < 0)
                {
                    strMessageErreur += "Le nombre de millisecondes doit être positif\n";
                    
                }
                if (iTemp > tbxMillisecondes.Maximum)
                {
                    strMessageErreur += "Le nombre de millisecondes doit être inférieur à " + tbxMillisecondes.Maximum + "\n";
                    
                }

                //Teste la valeur entrée pour le temps de la partie
                bValide = int.TryParse(tbxTempsPartie.Value.ToString(), out iTemp);
                if (iTemp < 0)
                {
                    strMessageErreur += "Le temps par concours doit être positif\n";
                }
                if (iTemp > tbxTempsPartie.Maximum)
                {
                    strMessageErreur += "Le temps par concours doit être inférieur à " + tbxTempsPartie.ToString() + "\n";
                }
            }
            else //Si un des champs est vide
            {
                strMessageErreur += "Tout les champs doivent être remplis";
            }

            //Affichage de l'erreur s'il y en a une
            if (strMessageErreur != "")
            {
                MessageBox.Show(strMessageErreur, "Erreur de saisie");
            }
            else //Si tout les champs sont remplis correctement
            {
                this.Hide();
                Form Jeu = new Jeu();
                Jeu.Show();

                //Teste si le mode entraînement est activé ou non
                if (checkEntrainement.Checked)
                {
                    Params.Default.bEntrainement = true;
                }
                else
                {
                    Params.Default.bEntrainement = false;
                }

                Params.Default.iMillisecondes = Convert.ToInt32(tbxMillisecondes.Text);
                Params.Default.iTempsPartie = Convert.ToInt32(tbxTempsPartie.Text);
                Params.Default.iDifficulte = (cbxDifficulte.SelectedIndex);

                Params.Default.Save(); //Sauvegarde les modifications.
            }
        }

        private void Parametres_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0); //Fermture propre au cas où l'utilisateur arriverait à fermer le formulaire, bien que la controlbox ne soit plus présente.
        }

        private void tbxMillisecondes_KeyPress(object sender, KeyPressEventArgs e)
        {//Vérifie l'entrée clavier faite par l'utilisateur afin d'en retirer les caractères non désirés dans un numericUpDown
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbxTempsPartie_KeyPress(object sender, KeyPressEventArgs e)
        {//Vérifie l'entrée clavier faite par l'utilisateur afin d'en retirer les caractères non désirés dans un numericUpDown
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
