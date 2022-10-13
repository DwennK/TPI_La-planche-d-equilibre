namespace TPI
{
    partial class Parametres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parametres));
            this.checkEntrainement = new System.Windows.Forms.CheckBox();
            this.lblEntrainement = new System.Windows.Forms.Label();
            this.tbxTempsPartie = new System.Windows.Forms.NumericUpDown();
            this.contextMenuVide = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbxMillisecondes = new System.Windows.Forms.NumericUpDown();
            this.cbxDifficulte = new System.Windows.Forms.ComboBox();
            this.lblDifficulte = new System.Windows.Forms.Label();
            this.lblTempsPartie = new System.Windows.Forms.Label();
            this.lblMillisecondes = new System.Windows.Forms.Label();
            this.btnAppliquer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbxTempsPartie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxMillisecondes)).BeginInit();
            this.SuspendLayout();
            // 
            // checkEntrainement
            // 
            this.checkEntrainement.Location = new System.Drawing.Point(202, 121);
            this.checkEntrainement.Name = "checkEntrainement";
            this.checkEntrainement.Size = new System.Drawing.Size(15, 14);
            this.checkEntrainement.TabIndex = 7;
            this.checkEntrainement.UseVisualStyleBackColor = true;
            // 
            // lblEntrainement
            // 
            this.lblEntrainement.AutoSize = true;
            this.lblEntrainement.Location = new System.Drawing.Point(19, 115);
            this.lblEntrainement.Name = "lblEntrainement";
            this.lblEntrainement.Size = new System.Drawing.Size(177, 26);
            this.lblEntrainement.TabIndex = 6;
            this.lblEntrainement.Text = "Mode entraînenement : \r\n( Le score ne sera pas sauvegardé )";
            // 
            // tbxTempsPartie
            // 
            this.tbxTempsPartie.ContextMenuStrip = this.contextMenuVide;
            this.tbxTempsPartie.Location = new System.Drawing.Point(199, 48);
            this.tbxTempsPartie.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.tbxTempsPartie.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbxTempsPartie.Name = "tbxTempsPartie";
            this.tbxTempsPartie.Size = new System.Drawing.Size(83, 20);
            this.tbxTempsPartie.TabIndex = 3;
            this.tbxTempsPartie.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.tbxTempsPartie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxTempsPartie_KeyPress);
            // 
            // contextMenuVide
            // 
            this.contextMenuVide.Name = "contextMenuVide";
            this.contextMenuVide.Size = new System.Drawing.Size(61, 4);
            // 
            // tbxMillisecondes
            // 
            this.tbxMillisecondes.ContextMenuStrip = this.contextMenuVide;
            this.tbxMillisecondes.Increment = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.tbxMillisecondes.Location = new System.Drawing.Point(199, 15);
            this.tbxMillisecondes.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.tbxMillisecondes.Name = "tbxMillisecondes";
            this.tbxMillisecondes.Size = new System.Drawing.Size(83, 20);
            this.tbxMillisecondes.TabIndex = 1;
            this.tbxMillisecondes.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.tbxMillisecondes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxMillisecondes_KeyPress);
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
            this.cbxDifficulte.Location = new System.Drawing.Point(199, 81);
            this.cbxDifficulte.Name = "cbxDifficulte";
            this.cbxDifficulte.Size = new System.Drawing.Size(83, 21);
            this.cbxDifficulte.TabIndex = 5;
            // 
            // lblDifficulte
            // 
            this.lblDifficulte.AutoSize = true;
            this.lblDifficulte.Location = new System.Drawing.Point(19, 85);
            this.lblDifficulte.Name = "lblDifficulte";
            this.lblDifficulte.Size = new System.Drawing.Size(125, 13);
            this.lblDifficulte.TabIndex = 4;
            this.lblDifficulte.Text = "Difficulté supplémentaire:";
            // 
            // lblTempsPartie
            // 
            this.lblTempsPartie.AutoSize = true;
            this.lblTempsPartie.Location = new System.Drawing.Point(19, 51);
            this.lblTempsPartie.Name = "lblTempsPartie";
            this.lblTempsPartie.Size = new System.Drawing.Size(155, 13);
            this.lblTempsPartie.TabIndex = 2;
            this.lblTempsPartie.Text = "Temps de la partie (secondes) :";
            // 
            // lblMillisecondes
            // 
            this.lblMillisecondes.AutoSize = true;
            this.lblMillisecondes.Location = new System.Drawing.Point(19, 17);
            this.lblMillisecondes.Name = "lblMillisecondes";
            this.lblMillisecondes.Size = new System.Drawing.Size(170, 13);
            this.lblMillisecondes.TabIndex = 0;
            this.lblMillisecondes.Text = "Millisecondes entre deux touchés :";
            // 
            // btnAppliquer
            // 
            this.btnAppliquer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAppliquer.Location = new System.Drawing.Point(76, 155);
            this.btnAppliquer.Name = "btnAppliquer";
            this.btnAppliquer.Size = new System.Drawing.Size(149, 26);
            this.btnAppliquer.TabIndex = 8;
            this.btnAppliquer.Text = "Appliquer et fermer";
            this.btnAppliquer.UseVisualStyleBackColor = true;
            this.btnAppliquer.Click += new System.EventHandler(this.btnAppliquer_Click);
            // 
            // Parametres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 193);
            this.ControlBox = false;
            this.Controls.Add(this.btnAppliquer);
            this.Controls.Add(this.lblEntrainement);
            this.Controls.Add(this.checkEntrainement);
            this.Controls.Add(this.tbxTempsPartie);
            this.Controls.Add(this.tbxMillisecondes);
            this.Controls.Add(this.cbxDifficulte);
            this.Controls.Add(this.lblDifficulte);
            this.Controls.Add(this.lblTempsPartie);
            this.Controls.Add(this.lblMillisecondes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Parametres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "La planche d\'équilibre - Paramètres";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Parametres_FormClosing);
            this.Load += new System.EventHandler(this.Parametres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbxTempsPartie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxMillisecondes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkEntrainement;
        private System.Windows.Forms.Label lblEntrainement;
        private System.Windows.Forms.NumericUpDown tbxTempsPartie;
        private System.Windows.Forms.NumericUpDown tbxMillisecondes;
        private System.Windows.Forms.ComboBox cbxDifficulte;
        private System.Windows.Forms.Label lblDifficulte;
        private System.Windows.Forms.Label lblTempsPartie;
        private System.Windows.Forms.Label lblMillisecondes;
        private System.Windows.Forms.Button btnAppliquer;
        private System.Windows.Forms.ContextMenuStrip contextMenuVide;
    }
}