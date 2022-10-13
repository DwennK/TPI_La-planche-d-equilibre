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
    public partial class Jeu : Form
    {
        public Jeu()
        {
            InitializeComponent();
        }
        //Déclaration des variables permettant de compter le nombre de contacts lors d'un concours.
        int iGauche = 0;
        int iDroite = 0;
        //Déclaration des variable permettant de dénombrer deux touchers distincts.
        long lDebut; //Va permetre de compter le temps total de chaque concour afin de savoir quand l'arrêter.
        long lDernier = Environment.TickCount;
        long lNew;
        DateTime dateDebut = DateTime.Now;

        private void Jeu_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Permet de fermer correctement l'application sans causer d'erreurs
            //dûes au fait qu'il y ait une connexion en cours avec la Carte.
            K8055.CloseDevice();
            Params.Default.bIsAlreadyConnected = false; //Repasse à false pour la prochaine ouverture du programme
            Params.Default.Save();
            Environment.Exit(0); 
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            int iEtat = 0; //Permet de détecter si la Carte sera connectée.
            iEtat = K8055.OpenDevice(0); //Si iEtat = 0, carte connectée. Si iEtat = -1, carte non présente.
            if (iEtat != 0)
            {
                MessageBox.Show("Veuillez d'abord connecter la carte à l'ordinateur via le cable USB.");
            }
            else //Si la connection a réussi
            {
                inverserBoutons(); //Débloque les boutons.
            }
        }

        private void resetCompteur()
        {
            iGauche = 0;
            iDroite = 0;
            lblNombreDroit.Text = "0";
            lblNombreGauche.Text = "0";
        }

        private void tmrJeu_Tick(object sender, EventArgs e)
        {
            lNew = Environment.TickCount;
            if (K8055.ReadDigitalChannel(5) == true)
            {
                if (lNew - lDernier >= Params.Default.iMillisecondes)
                {
                    iDroite++;
                    lDernier = Environment.TickCount;
                }
                pbxRight.ImageLocation = @"right.png";
            }
            else if (K8055.ReadDigitalChannel(4) == true)
            {
                if (lNew - lDernier >= Params.Default.iMillisecondes)
                {
                    iGauche++;
                    lDernier = Environment.TickCount;
                }
                pbxLeft.ImageLocation = @"left.png";
            }
            else
            {
                pbxRight.ImageLocation = @"rightx.png";
                pbxLeft.ImageLocation = @"leftx.png";
            }
            

            lblNombreDroit.Text = iDroite.ToString();
            lblNombreGauche.Text = iGauche.ToString();

            if((Convert.ToInt32(lNew-lDebut) < progressBar1.Maximum))
            { 
                progressBar1.Value = Convert.ToInt32(lNew - lDebut); //Valeur souhaitée
                progressBar1.Value = Convert.ToInt32(lNew - lDebut - 1); //Valeur souhaitée -1
                progressBar1.Value = Convert.ToInt32(lNew - lDebut); //Valeur finale souhaitée. Ceci pour éviter l'animation sur les progressbar, car lors d'un temps cours, exemple 5 secondes, le temps que l'animation de la probgressbar finisse, la partie était deja temrinée, n'affichant jamais la fin. Ceci corrige le problème.
            }

            progressBar1.Refresh();
            using (Graphics gr = progressBar1.CreateGraphics())
            {
                gr.DrawString("Temps écoulé : " + (lNew - lDebut) / 1000 + " / " + Params.Default.iTempsPartie.ToString()+" seconde(s)",
                    SystemFonts.DefaultFont,
                    Brushes.Black,
                    new PointF(progressBar1.Width / 2 - (gr.MeasureString("Temps écoulé : " + (lNew - lDebut) / 1000 + " / " + Params.Default.iTempsPartie.ToString() + " seconde(s)",
                        SystemFonts.DefaultFont).Width / 2.0F),
                    progressBar1.Height / 2 - (gr.MeasureString("Temps écoulé : " + (lNew - lDebut) / 1000 + " / " + Params.Default.iTempsPartie.ToString() + " seconde(s)",
                        SystemFonts.DefaultFont).Height / 2.0F)));
            }
            //Teste si le concour est terminé (Nouveau temps - temps du debut)/1000 car c'est en millisecondes
            if ((lNew - lDebut) / 1000 >= Params.Default.iTempsPartie)
            {
                StopJeu();
            }   
        }

        private void inverserBoutons()
        {
            //Inverse la propriété enabled de tout les boutons.

            tsbConnecter.Enabled = !tsbConnecter.Enabled;
            tsbEjecter.Enabled = !tsbEjecter.Enabled;
            btnJouer.Enabled = !btnJouer.Enabled;
        }

        private void btnJouer_Click(object sender, EventArgs e)
        {
            //Timer de jeu.
            tmrJeu.Start();
            btnJouer.Enabled = false;
            lDebut = Environment.TickCount; //Va permettre de savoir quand terminer le concours.
            progressBar1.Maximum = Params.Default.iTempsPartie *1000; //x1000 pour que ce soit plus fluide lorsqu'il n'y a que 10 secondes par exemple, ce sera moins par "à-coup".
            pnlJeu.Visible = true;
        }

        private void StopJeu()
        {
            //Teste si la performance doit être sauvegardée
            if (Params.Default.bEntrainement == false) //Sauvegarde le concours seulement si l'utilisateur n'as pas coché l'option "Entraînement".
            {
                //Ajoute la performance
                BaseDonnee.Request("INSERT INTO tbl_Performances (num_tbl_Personnes,Jour,Mois,Annee,Difficulte,ResultatTotal,ResultatGauche,ResultatDroit,Temps,Heure) VALUES ('" + Params.Default.iID.ToString() + "','" + DateTime.Now.Day.ToString() + "','" + DateTime.Now.Month.ToString() + "','" + DateTime.Now.Year.ToString() + "','" + Params.Default.iDifficulte + "','" + (iGauche+iDroite) + "','" + iGauche + "','" + iDroite + "','" + Params.Default.iTempsPartie + "','" + DateTime.Now.ToString("HH:mm:ss") + "');");
            }

            tmrJeu.Stop();
            btnJouer.Enabled = true;

            pbxLeft.ImageLocation = @"";
            pbxRight.ImageLocation = @"";

            pnlJeu.Visible = false;

            //Va afficher les résultats
            this.Visible = false;
            this.Hide();
            Form Resultat = new Resultat(iGauche, iDroite);
            resetCompteur(); //Se fait après avoir passé les paramètres au formulaire Resultat que l'on va afficher, pour ne pas perdre les valeurs.
            Resultat.Show();
        }

        public void inverserCouleurMenu(ToolStripButton bouton1, ToolStripButton bouton2)
        {
            //Cette méthode va inverser la couleur des deux boutons passés en paramètres.
            bouton1.BackColor = bouton2.BackColor;
            bouton2.BackColor = Control.DefaultBackColor; //Remet la couleur de base du controle.
        }

        private void Jeu_VisibleChanged(object sender, EventArgs e)
        {
            if (Params.Default.bIsAlreadyConnected == true)
            {
                tsbConnecter.PerformClick(); //Permet de recliquer sur le bouton lorsque le formulaire se recharge alors que la carte est déjà connectée, exemple après être revenu du formulaire Paramètres.
            }
        }

        private void tsbConnecter_Click(object sender, EventArgs e)
        {
            tsbConnecter.Enabled = false;
            int iEtat = 0; //Permet de détecter si la Carte sera connectée.
            iEtat = K8055.OpenDevice(0); //Si iEtat = 0, carte connectée. Si iEtat = -1, carte non présente.
            tsbConnecter.Enabled = true;
            if (iEtat != 0)
            {
                MessageBox.Show("Veuillez d'abord connecter la carte à l'ordinateur via le cable USB.");
            }
            else //Si la connection a réussi
            {
                inverserBoutons();  //Débloque les boutons
                inverserCouleurMenu(tsbConnecter, tsbEjecter); //Inverse les couleurs du menu.
                Params.Default.bIsAlreadyConnected = true;
                Params.Default.Save();
            }
        }

        private void tsbEjecter_Click_1(object sender, EventArgs e)
        {
            K8055.CloseDevice();
            inverserBoutons();
            inverserCouleurMenu(tsbEjecter, tsbConnecter);
            Params.Default.bIsAlreadyConnected = false;
            Params.Default.Save();
            if(tmrJeu.Enabled)
            {//La partie n'est stoppée que si elle est en cours.
                StopJeu();
            }
            btnJouer.Enabled = false;
        }

        private void tsbParametres_Click_1(object sender, EventArgs e)
        {
            tmrJeu.Dispose(); //Stop net le timer de jeu, sans le laisser finir quoi que ce soit
            this.Visible = false;
            this.Hide();
            Form Parametres = new Parametres();
            Parametres.Show();
        }

        private void tsbScores_Click_1(object sender, EventArgs e)
        {
            tmrJeu.Dispose(); //Stop net le timer de jeu, sans le laisser finir quoi que ce soit
            this.Visible = false;
            this.Hide();
            Form Scores = new Scores();
            Scores.Show();
        }

        private void tsbChangerUtilisateur_Click(object sender, EventArgs e)
        {
            tmrJeu.Dispose(); //Stop net le timer de jeu, sans le laisser finir quoi que ce soit
            this.Visible = false;
            this.Hide();
            Form Login = new Login();
            Login.Show();
        }
    }
}