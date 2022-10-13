namespace TPI
{
    partial class Jeu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jeu));
            this.tmrJeu = new System.Windows.Forms.Timer(this.components);
            this.lblGauche = new System.Windows.Forms.Label();
            this.lblDroite = new System.Windows.Forms.Label();
            this.lblNombreGauche = new System.Windows.Forms.Label();
            this.lblNombreDroit = new System.Windows.Forms.Label();
            this.pbxLeft = new System.Windows.Forms.PictureBox();
            this.btnJouer = new System.Windows.Forms.Button();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbConnecter = new System.Windows.Forms.ToolStripButton();
            this.tsbEjecter = new System.Windows.Forms.ToolStripButton();
            this.tsbParametres = new System.Windows.Forms.ToolStripButton();
            this.tsbChangerUtilisateur = new System.Windows.Forms.ToolStripButton();
            this.tsbScores = new System.Windows.Forms.ToolStripButton();
            this.pbxRight = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pnlJeu = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLeft)).BeginInit();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRight)).BeginInit();
            this.pnlJeu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrJeu
            // 
            this.tmrJeu.Interval = 10;
            this.tmrJeu.Tick += new System.EventHandler(this.tmrJeu_Tick);
            // 
            // lblGauche
            // 
            this.lblGauche.AutoSize = true;
            this.lblGauche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGauche.Location = new System.Drawing.Point(-1, 4);
            this.lblGauche.Name = "lblGauche";
            this.lblGauche.Size = new System.Drawing.Size(114, 16);
            this.lblGauche.TabIndex = 6;
            this.lblGauche.Text = "Touchés Gauche:";
            // 
            // lblDroite
            // 
            this.lblDroite.AutoSize = true;
            this.lblDroite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDroite.Location = new System.Drawing.Point(383, 4);
            this.lblDroite.Name = "lblDroite";
            this.lblDroite.Size = new System.Drawing.Size(98, 16);
            this.lblDroite.TabIndex = 7;
            this.lblDroite.Text = "Touchés Droit :";
            // 
            // lblNombreGauche
            // 
            this.lblNombreGauche.AutoSize = true;
            this.lblNombreGauche.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreGauche.Location = new System.Drawing.Point(43, 27);
            this.lblNombreGauche.Name = "lblNombreGauche";
            this.lblNombreGauche.Size = new System.Drawing.Size(25, 25);
            this.lblNombreGauche.TabIndex = 8;
            this.lblNombreGauche.Text = "0";
            // 
            // lblNombreDroit
            // 
            this.lblNombreDroit.AutoSize = true;
            this.lblNombreDroit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDroit.Location = new System.Drawing.Point(426, 27);
            this.lblNombreDroit.Name = "lblNombreDroit";
            this.lblNombreDroit.Size = new System.Drawing.Size(25, 25);
            this.lblNombreDroit.TabIndex = 9;
            this.lblNombreDroit.Text = "0";
            // 
            // pbxLeft
            // 
            this.pbxLeft.Location = new System.Drawing.Point(117, 4);
            this.pbxLeft.Name = "pbxLeft";
            this.pbxLeft.Size = new System.Drawing.Size(128, 128);
            this.pbxLeft.TabIndex = 14;
            this.pbxLeft.TabStop = false;
            // 
            // btnJouer
            // 
            this.btnJouer.Enabled = false;
            this.btnJouer.Image = ((System.Drawing.Image)(resources.GetObject("btnJouer.Image")));
            this.btnJouer.Location = new System.Drawing.Point(116, 50);
            this.btnJouer.Name = "btnJouer";
            this.btnJouer.Size = new System.Drawing.Size(262, 29);
            this.btnJouer.TabIndex = 1;
            this.btnJouer.Text = "Jouer !";
            this.btnJouer.UseVisualStyleBackColor = true;
            this.btnJouer.Click += new System.EventHandler(this.btnJouer_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(107, 35);
            this.toolStripButton1.Tag = "";
            this.toolStripButton1.Text = "Connecter la carte";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.ToolTipText = "Vous devez d\'abord connecter la carte avant de pouvoir jouer.";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.toolStripButton2.Enabled = false;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(87, 35);
            this.toolStripButton2.Text = "Ejecter la carte";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(70, 35);
            this.toolStripButton3.Text = "Paramètres";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton3.ToolTipText = "Permet de modifier différents paramètres afin de changer l\'expérience de jeu";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(110, 35);
            this.toolStripButton4.Text = "Tableau des scores";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton4.ToolTipText = "Affiche les performances triées par le score, le temps et le niveau de difficulté" +
                ".";
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbConnecter,
            this.tsbEjecter,
            this.tsbParametres,
            this.tsbChangerUtilisateur,
            this.tsbScores});
            this.toolStrip.Location = new System.Drawing.Point(0, -1);
            this.toolStrip.MinimumSize = new System.Drawing.Size(468, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(498, 38);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tsbConnecter
            // 
            this.tsbConnecter.Image = ((System.Drawing.Image)(resources.GetObject("tsbConnecter.Image")));
            this.tsbConnecter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConnecter.Name = "tsbConnecter";
            this.tsbConnecter.Size = new System.Drawing.Size(107, 35);
            this.tsbConnecter.Tag = "";
            this.tsbConnecter.Text = "Connecter la carte";
            this.tsbConnecter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbConnecter.ToolTipText = "Vous devez d\'abord connecter la carte avant de pouvoir jouer.";
            this.tsbConnecter.Click += new System.EventHandler(this.tsbConnecter_Click);
            // 
            // tsbEjecter
            // 
            this.tsbEjecter.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tsbEjecter.Enabled = false;
            this.tsbEjecter.Image = ((System.Drawing.Image)(resources.GetObject("tsbEjecter.Image")));
            this.tsbEjecter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEjecter.Name = "tsbEjecter";
            this.tsbEjecter.Size = new System.Drawing.Size(87, 35);
            this.tsbEjecter.Text = "Ejecter la carte";
            this.tsbEjecter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbEjecter.Click += new System.EventHandler(this.tsbEjecter_Click_1);
            // 
            // tsbParametres
            // 
            this.tsbParametres.Image = ((System.Drawing.Image)(resources.GetObject("tsbParametres.Image")));
            this.tsbParametres.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbParametres.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbParametres.Name = "tsbParametres";
            this.tsbParametres.Size = new System.Drawing.Size(70, 35);
            this.tsbParametres.Text = "Paramètres";
            this.tsbParametres.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbParametres.ToolTipText = "Permet de modifier différents paramètres afin de changer l\'expérience de jeu";
            this.tsbParametres.Click += new System.EventHandler(this.tsbParametres_Click_1);
            // 
            // tsbChangerUtilisateur
            // 
            this.tsbChangerUtilisateur.Image = ((System.Drawing.Image)(resources.GetObject("tsbChangerUtilisateur.Image")));
            this.tsbChangerUtilisateur.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbChangerUtilisateur.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbChangerUtilisateur.Name = "tsbChangerUtilisateur";
            this.tsbChangerUtilisateur.Size = new System.Drawing.Size(121, 35);
            this.tsbChangerUtilisateur.Text = "Changer d\'utilisateur";
            this.tsbChangerUtilisateur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbChangerUtilisateur.ToolTipText = "Réaffiche la fenêtre de login";
            this.tsbChangerUtilisateur.Click += new System.EventHandler(this.tsbChangerUtilisateur_Click);
            // 
            // tsbScores
            // 
            this.tsbScores.Image = ((System.Drawing.Image)(resources.GetObject("tsbScores.Image")));
            this.tsbScores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbScores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbScores.Name = "tsbScores";
            this.tsbScores.Size = new System.Drawing.Size(110, 35);
            this.tsbScores.Text = "Tableau des scores";
            this.tsbScores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbScores.ToolTipText = "Affiche les performances triées par le score, le temps et le niveau de difficulté" +
                ".";
            this.tsbScores.Click += new System.EventHandler(this.tsbScores_Click_1);
            // 
            // pbxRight
            // 
            this.pbxRight.Location = new System.Drawing.Point(249, 4);
            this.pbxRight.Name = "pbxRight";
            this.pbxRight.Size = new System.Drawing.Size(128, 128);
            this.pbxRight.TabIndex = 16;
            this.pbxRight.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar1.Location = new System.Drawing.Point(118, 134);
            this.progressBar1.MarqueeAnimationSpeed = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(262, 18);
            this.progressBar1.Step = 50;
            this.progressBar1.TabIndex = 17;
            // 
            // pnlJeu
            // 
            this.pnlJeu.Controls.Add(this.progressBar1);
            this.pnlJeu.Controls.Add(this.pbxRight);
            this.pnlJeu.Controls.Add(this.pbxLeft);
            this.pnlJeu.Controls.Add(this.lblNombreDroit);
            this.pnlJeu.Controls.Add(this.lblGauche);
            this.pnlJeu.Controls.Add(this.lblDroite);
            this.pnlJeu.Controls.Add(this.lblNombreGauche);
            this.pnlJeu.Location = new System.Drawing.Point(-2, 85);
            this.pnlJeu.Name = "pnlJeu";
            this.pnlJeu.Size = new System.Drawing.Size(498, 159);
            this.pnlJeu.TabIndex = 2;
            this.pnlJeu.Visible = false;
            // 
            // Jeu
            // 
            this.AcceptButton = this.btnJouer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 237);
            this.Controls.Add(this.pnlJeu);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.btnJouer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Jeu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "La planche d\'équilibre - Jeu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Jeu_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.Jeu_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLeft)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRight)).EndInit();
            this.pnlJeu.ResumeLayout(false);
            this.pnlJeu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrJeu;
        private System.Windows.Forms.Button btnJouer;
        private System.Windows.Forms.Label lblGauche;
        private System.Windows.Forms.Label lblDroite;
        private System.Windows.Forms.Label lblNombreGauche;
        private System.Windows.Forms.Label lblNombreDroit;
        private System.Windows.Forms.PictureBox pbxLeft;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tsbConnecter;
        private System.Windows.Forms.ToolStripButton tsbEjecter;
        private System.Windows.Forms.ToolStripButton tsbParametres;
        private System.Windows.Forms.ToolStripButton tsbScores;
        private System.Windows.Forms.PictureBox pbxRight;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStripButton tsbChangerUtilisateur;
        private System.Windows.Forms.Panel pnlJeu;
    }
}

