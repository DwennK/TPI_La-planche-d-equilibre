namespace TPI
{
    partial class Resultat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resultat));
            this.btnFermer = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblTouchesTotaux = new System.Windows.Forms.Label();
            this.lblTouchesGauche = new System.Windows.Forms.Label();
            this.lblTouchesDroit = new System.Windows.Forms.Label();
            this.lblTempsPartie = new System.Windows.Forms.Label();
            this.lblDifficulte = new System.Windows.Forms.Label();
            this.tbxTouchesTotaux = new System.Windows.Forms.TextBox();
            this.tbxTouchesGauche = new System.Windows.Forms.TextBox();
            this.tbxDifficulte = new System.Windows.Forms.TextBox();
            this.tbxTouchesDroit = new System.Windows.Forms.TextBox();
            this.tbxTempsPartie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFermer
            // 
            this.btnFermer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFermer.Location = new System.Drawing.Point(54, 189);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(149, 26);
            this.btnFermer.TabIndex = 11;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(41, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(175, 13);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Partie terminée, voici votre résultat :";
            // 
            // lblTouchesTotaux
            // 
            this.lblTouchesTotaux.AutoSize = true;
            this.lblTouchesTotaux.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTouchesTotaux.Location = new System.Drawing.Point(9, 45);
            this.lblTouchesTotaux.Name = "lblTouchesTotaux";
            this.lblTouchesTotaux.Size = new System.Drawing.Size(103, 13);
            this.lblTouchesTotaux.TabIndex = 1;
            this.lblTouchesTotaux.Text = "Touchés totaux :";
            // 
            // lblTouchesGauche
            // 
            this.lblTouchesGauche.AutoSize = true;
            this.lblTouchesGauche.Location = new System.Drawing.Point(9, 73);
            this.lblTouchesGauche.Name = "lblTouchesGauche";
            this.lblTouchesGauche.Size = new System.Drawing.Size(94, 13);
            this.lblTouchesGauche.TabIndex = 3;
            this.lblTouchesGauche.Text = "Touchés gauche :";
            // 
            // lblTouchesDroit
            // 
            this.lblTouchesDroit.AutoSize = true;
            this.lblTouchesDroit.Location = new System.Drawing.Point(9, 101);
            this.lblTouchesDroit.Name = "lblTouchesDroit";
            this.lblTouchesDroit.Size = new System.Drawing.Size(78, 13);
            this.lblTouchesDroit.TabIndex = 5;
            this.lblTouchesDroit.Text = "Touchés droit :";
            // 
            // lblTempsPartie
            // 
            this.lblTempsPartie.AutoSize = true;
            this.lblTempsPartie.Location = new System.Drawing.Point(9, 129);
            this.lblTempsPartie.Name = "lblTempsPartie";
            this.lblTempsPartie.Size = new System.Drawing.Size(74, 13);
            this.lblTempsPartie.TabIndex = 7;
            this.lblTempsPartie.Text = "Temps partie :";
            // 
            // lblDifficulte
            // 
            this.lblDifficulte.AutoSize = true;
            this.lblDifficulte.Location = new System.Drawing.Point(12, 157);
            this.lblDifficulte.Name = "lblDifficulte";
            this.lblDifficulte.Size = new System.Drawing.Size(54, 13);
            this.lblDifficulte.TabIndex = 9;
            this.lblDifficulte.Text = "Difficulté :";
            // 
            // tbxTouchesTotaux
            // 
            this.tbxTouchesTotaux.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTouchesTotaux.Location = new System.Drawing.Point(116, 42);
            this.tbxTouchesTotaux.Name = "tbxTouchesTotaux";
            this.tbxTouchesTotaux.ReadOnly = true;
            this.tbxTouchesTotaux.Size = new System.Drawing.Size(120, 20);
            this.tbxTouchesTotaux.TabIndex = 2;
            // 
            // tbxTouchesGauche
            // 
            this.tbxTouchesGauche.Location = new System.Drawing.Point(116, 70);
            this.tbxTouchesGauche.Name = "tbxTouchesGauche";
            this.tbxTouchesGauche.ReadOnly = true;
            this.tbxTouchesGauche.Size = new System.Drawing.Size(120, 20);
            this.tbxTouchesGauche.TabIndex = 4;
            // 
            // tbxDifficulte
            // 
            this.tbxDifficulte.Location = new System.Drawing.Point(116, 154);
            this.tbxDifficulte.Name = "tbxDifficulte";
            this.tbxDifficulte.ReadOnly = true;
            this.tbxDifficulte.Size = new System.Drawing.Size(120, 20);
            this.tbxDifficulte.TabIndex = 10;
            // 
            // tbxTouchesDroit
            // 
            this.tbxTouchesDroit.Location = new System.Drawing.Point(116, 98);
            this.tbxTouchesDroit.Name = "tbxTouchesDroit";
            this.tbxTouchesDroit.ReadOnly = true;
            this.tbxTouchesDroit.Size = new System.Drawing.Size(120, 20);
            this.tbxTouchesDroit.TabIndex = 6;
            // 
            // tbxTempsPartie
            // 
            this.tbxTempsPartie.Location = new System.Drawing.Point(116, 126);
            this.tbxTempsPartie.Name = "tbxTempsPartie";
            this.tbxTempsPartie.ReadOnly = true;
            this.tbxTempsPartie.Size = new System.Drawing.Size(120, 20);
            this.tbxTempsPartie.TabIndex = 8;
            // 
            // Resultat
            // 
            this.AcceptButton = this.btnFermer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 227);
            this.ControlBox = false;
            this.Controls.Add(this.tbxTempsPartie);
            this.Controls.Add(this.tbxTouchesDroit);
            this.Controls.Add(this.tbxDifficulte);
            this.Controls.Add(this.tbxTouchesGauche);
            this.Controls.Add(this.tbxTouchesTotaux);
            this.Controls.Add(this.lblDifficulte);
            this.Controls.Add(this.lblTempsPartie);
            this.Controls.Add(this.lblTouchesDroit);
            this.Controls.Add(this.lblTouchesGauche);
            this.Controls.Add(this.lblTouchesTotaux);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnFermer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Resultat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "La planche d\'équilibre - Résultat";
            this.Load += new System.EventHandler(this.Resultat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblTouchesTotaux;
        private System.Windows.Forms.Label lblTouchesGauche;
        private System.Windows.Forms.Label lblTouchesDroit;
        private System.Windows.Forms.Label lblTempsPartie;
        private System.Windows.Forms.Label lblDifficulte;
        private System.Windows.Forms.TextBox tbxTouchesTotaux;
        private System.Windows.Forms.TextBox tbxTouchesGauche;
        private System.Windows.Forms.TextBox tbxDifficulte;
        private System.Windows.Forms.TextBox tbxTouchesDroit;
        private System.Windows.Forms.TextBox tbxTempsPartie;
    }
}