namespace TPI
{
    partial class Scores
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scores));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.rbtn_Personnel = new System.Windows.Forms.RadioButton();
            this.rbtn_Tous = new System.Windows.Forms.RadioButton();
            this.lblTemps = new System.Windows.Forms.Label();
            this.lblDifficulte = new System.Windows.Forms.Label();
            this.tbx_Temps = new System.Windows.Forms.NumericUpDown();
            this.contextMenuVide = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gbParametres = new System.Windows.Forms.GroupBox();
            this.cbxDifficulte = new System.Windows.Forms.ComboBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbQuitter = new System.Windows.Forms.ToolStripButton();
            this.tsbImprimer = new System.Windows.Forms.ToolStripButton();
            this.tsbSupressionScoresTout = new System.Windows.Forms.ToolStripButton();
            this.tsbSupressionScoresUtilisateur = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_Temps)).BeginInit();
            this.gbParametres.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 120);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView.ShowEditingIcon = false;
            this.dataGridView.Size = new System.Drawing.Size(458, 358);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewData);
            // 
            // rbtn_Personnel
            // 
            this.rbtn_Personnel.AutoSize = true;
            this.rbtn_Personnel.Location = new System.Drawing.Point(21, 15);
            this.rbtn_Personnel.Name = "rbtn_Personnel";
            this.rbtn_Personnel.Size = new System.Drawing.Size(78, 17);
            this.rbtn_Personnel.TabIndex = 1;
            this.rbtn_Personnel.Text = "xxxxx xxxxx";
            this.rbtn_Personnel.UseVisualStyleBackColor = true;
            this.rbtn_Personnel.Click += new System.EventHandler(this.dataGridViewData);
            // 
            // rbtn_Tous
            // 
            this.rbtn_Tous.AutoSize = true;
            this.rbtn_Tous.Checked = true;
            this.rbtn_Tous.Location = new System.Drawing.Point(21, 39);
            this.rbtn_Tous.Name = "rbtn_Tous";
            this.rbtn_Tous.Size = new System.Drawing.Size(115, 17);
            this.rbtn_Tous.TabIndex = 2;
            this.rbtn_Tous.TabStop = true;
            this.rbtn_Tous.Text = "Tout les utilisateurs";
            this.rbtn_Tous.UseVisualStyleBackColor = true;
            this.rbtn_Tous.Click += new System.EventHandler(this.dataGridViewData);
            // 
            // lblTemps
            // 
            this.lblTemps.AutoSize = true;
            this.lblTemps.Location = new System.Drawing.Point(231, 16);
            this.lblTemps.Name = "lblTemps";
            this.lblTemps.Size = new System.Drawing.Size(114, 13);
            this.lblTemps.TabIndex = 4;
            this.lblTemps.Text = "Temps par lequel trier :";
            // 
            // lblDifficulte
            // 
            this.lblDifficulte.AutoSize = true;
            this.lblDifficulte.Location = new System.Drawing.Point(231, 41);
            this.lblDifficulte.Name = "lblDifficulte";
            this.lblDifficulte.Size = new System.Drawing.Size(131, 13);
            this.lblDifficulte.TabIndex = 6;
            this.lblDifficulte.Text = "Difficulté par laquelle trier :";
            // 
            // tbx_Temps
            // 
            this.tbx_Temps.ContextMenuStrip = this.contextMenuVide;
            this.tbx_Temps.Location = new System.Drawing.Point(368, 13);
            this.tbx_Temps.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.tbx_Temps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbx_Temps.Name = "tbx_Temps";
            this.tbx_Temps.Size = new System.Drawing.Size(68, 20);
            this.tbx_Temps.TabIndex = 8;
            this.tbx_Temps.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbx_Temps.ValueChanged += new System.EventHandler(this.dataGridViewData);
            this.tbx_Temps.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewData);
            this.tbx_Temps.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.update);
            this.tbx_Temps.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridViewData);
            // 
            // contextMenuVide
            // 
            this.contextMenuVide.Name = "contextMenuVide";
            this.contextMenuVide.Size = new System.Drawing.Size(61, 4);
            // 
            // gbParametres
            // 
            this.gbParametres.Controls.Add(this.cbxDifficulte);
            this.gbParametres.Controls.Add(this.rbtn_Personnel);
            this.gbParametres.Controls.Add(this.rbtn_Tous);
            this.gbParametres.Controls.Add(this.lblDifficulte);
            this.gbParametres.Controls.Add(this.tbx_Temps);
            this.gbParametres.Controls.Add(this.lblTemps);
            this.gbParametres.Location = new System.Drawing.Point(12, 50);
            this.gbParametres.Name = "gbParametres";
            this.gbParametres.Size = new System.Drawing.Size(458, 68);
            this.gbParametres.TabIndex = 1;
            this.gbParametres.TabStop = false;
            this.gbParametres.Text = "Scores";
            // 
            // cbxDifficulte
            // 
            this.cbxDifficulte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDifficulte.FormattingEnabled = true;
            this.cbxDifficulte.Items.AddRange(new object[] {
            "Aucune",
            "1",
            "2",
            "3"});
            this.cbxDifficulte.Location = new System.Drawing.Point(368, 38);
            this.cbxDifficulte.Name = "cbxDifficulte";
            this.cbxDifficulte.Size = new System.Drawing.Size(68, 21);
            this.cbxDifficulte.TabIndex = 9;
            this.cbxDifficulte.TextChanged += new System.EventHandler(this.dataGridViewData);
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbQuitter,
            this.tsbImprimer,
            this.tsbSupressionScoresTout,
            this.tsbSupressionScoresUtilisateur});
            this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.MaximumSize = new System.Drawing.Size(0, 40);
            this.toolStrip.MinimumSize = new System.Drawing.Size(410, 52);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip.Size = new System.Drawing.Size(482, 52);
            this.toolStrip.TabIndex = 0;
            // 
            // tsbQuitter
            // 
            this.tsbQuitter.AutoSize = false;
            this.tsbQuitter.Image = ((System.Drawing.Image)(resources.GetObject("tsbQuitter.Image")));
            this.tsbQuitter.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbQuitter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbQuitter.Name = "tsbQuitter";
            this.tsbQuitter.Size = new System.Drawing.Size(105, 50);
            this.tsbQuitter.Text = "Fenêtre principale";
            this.tsbQuitter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbQuitter.ToolTipText = "Revenir au menu principal";
            this.tsbQuitter.Click += new System.EventHandler(this.tsbQuitter_Click);
            // 
            // tsbImprimer
            // 
            this.tsbImprimer.AutoSize = false;
            this.tsbImprimer.Image = ((System.Drawing.Image)(resources.GetObject("tsbImprimer.Image")));
            this.tsbImprimer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbImprimer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImprimer.Name = "tsbImprimer";
            this.tsbImprimer.Size = new System.Drawing.Size(60, 50);
            this.tsbImprimer.Text = "Imprimer";
            this.tsbImprimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbImprimer.ToolTipText = "Imprimer les résultats affichés.";
            this.tsbImprimer.Click += new System.EventHandler(this.tsbImprimer_Click);
            // 
            // tsbSupressionScoresTout
            // 
            this.tsbSupressionScoresTout.AutoSize = false;
            this.tsbSupressionScoresTout.Image = ((System.Drawing.Image)(resources.GetObject("tsbSupressionScoresTout.Image")));
            this.tsbSupressionScoresTout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSupressionScoresTout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSupressionScoresTout.Name = "tsbSupressionScoresTout";
            this.tsbSupressionScoresTout.Size = new System.Drawing.Size(119, 50);
            this.tsbSupressionScoresTout.Text = "Vider tout les scores ";
            this.tsbSupressionScoresTout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSupressionScoresTout.ToolTipText = "Vider tout les scores de tout les utilisateurs.";
            this.tsbSupressionScoresTout.Click += new System.EventHandler(this.tsbSupressionScoresTout_Click);
            // 
            // tsbSupressionScoresUtilisateur
            // 
            this.tsbSupressionScoresUtilisateur.AutoSize = false;
            this.tsbSupressionScoresUtilisateur.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbSupressionScoresUtilisateur.Image = ((System.Drawing.Image)(resources.GetObject("tsbSupressionScoresUtilisateur.Image")));
            this.tsbSupressionScoresUtilisateur.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSupressionScoresUtilisateur.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSupressionScoresUtilisateur.Name = "tsbSupressionScoresUtilisateur";
            this.tsbSupressionScoresUtilisateur.Size = new System.Drawing.Size(148, 50);
            this.tsbSupressionScoresUtilisateur.Text = "Vider scores pour xxxx xxxx";
            this.tsbSupressionScoresUtilisateur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSupressionScoresUtilisateur.ToolTipText = "Vider les scores propres à l\'utilisateur en cours.";
            this.tsbSupressionScoresUtilisateur.Click += new System.EventHandler(this.tsbSupressionScoresUtilisateur_Click);
            // 
            // Scores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 486);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.gbParametres);
            this.Controls.Add(this.dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Scores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "La planche d\'équilibre - Tableau des scores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Scores_FormClosing);
            this.Load += new System.EventHandler(this.Scores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbx_Temps)).EndInit();
            this.gbParametres.ResumeLayout(false);
            this.gbParametres.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.RadioButton rbtn_Personnel;
        private System.Windows.Forms.RadioButton rbtn_Tous;
        private System.Windows.Forms.Label lblTemps;
        private System.Windows.Forms.Label lblDifficulte;
        private System.Windows.Forms.NumericUpDown tbx_Temps;
        private System.Windows.Forms.GroupBox gbParametres;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tsbImprimer;
        private System.Windows.Forms.ToolStripButton tsbQuitter;
        private System.Windows.Forms.ToolStripButton tsbSupressionScoresTout;
        private System.Windows.Forms.ToolStripButton tsbSupressionScoresUtilisateur;
        private System.Windows.Forms.ContextMenuStrip contextMenuVide;
        private System.Windows.Forms.ComboBox cbxDifficulte;
    }
}