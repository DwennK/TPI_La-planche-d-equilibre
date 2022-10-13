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
    public partial class Resultat : Form
    {
        int iGauche;
        int iDroite;
        public Resultat(int iTouchesGauche, int iTouchesDroit)
        {
            InitializeComponent();
            iGauche = iTouchesGauche;
            iDroite = iTouchesDroit;
        }

        private void Resultat_Load(object sender, EventArgs e)
        {
            tbxDifficulte.Text = Params.Default.iDifficulte.ToString()+"/3";
            tbxTempsPartie.Text = Params.Default.iTempsPartie.ToString()+" secondes";
            tbxTouchesTotaux.Text = (iGauche + iDroite).ToString();
            tbxTouchesGauche.Text = iGauche.ToString();
            tbxTouchesDroit.Text = iDroite.ToString();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Hide();
            Form Jeu = new Jeu();
            Jeu.Show();
        }
    }
}
