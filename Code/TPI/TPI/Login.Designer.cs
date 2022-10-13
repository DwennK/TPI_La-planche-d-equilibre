namespace TPI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblDatenaissance = new System.Windows.Forms.Label();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.contextMenuVide = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbxPrenom = new System.Windows.Forms.TextBox();
            this.btnAppliquer = new System.Windows.Forms.Button();
            this.cbxJour = new System.Windows.Forms.ComboBox();
            this.cbxMois = new System.Windows.Forms.ComboBox();
            this.cbxAnnee = new System.Windows.Forms.ComboBox();
            this.pbxErreur = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxErreur)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(10, 25);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(38, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom : ";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(10, 61);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(49, 13);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "Prénom :";
            // 
            // lblDatenaissance
            // 
            this.lblDatenaissance.AutoSize = true;
            this.lblDatenaissance.Location = new System.Drawing.Point(10, 98);
            this.lblDatenaissance.Name = "lblDatenaissance";
            this.lblDatenaissance.Size = new System.Drawing.Size(102, 13);
            this.lblDatenaissance.TabIndex = 2;
            this.lblDatenaissance.Text = "Date de naissance :";
            // 
            // tbxNom
            // 
            this.tbxNom.ContextMenuStrip = this.contextMenuVide;
            this.tbxNom.Location = new System.Drawing.Point(118, 22);
            this.tbxNom.MaxLength = 12;
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.ShortcutsEnabled = false;
            this.tbxNom.Size = new System.Drawing.Size(180, 20);
            this.tbxNom.TabIndex = 3;
            this.tbxNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxKeyPress);
            // 
            // contextMenuVide
            // 
            this.contextMenuVide.Name = "contextMenuVide";
            this.contextMenuVide.Size = new System.Drawing.Size(61, 4);
            // 
            // tbxPrenom
            // 
            this.tbxPrenom.ContextMenuStrip = this.contextMenuVide;
            this.tbxPrenom.Location = new System.Drawing.Point(118, 58);
            this.tbxPrenom.MaxLength = 12;
            this.tbxPrenom.Name = "tbxPrenom";
            this.tbxPrenom.ShortcutsEnabled = false;
            this.tbxPrenom.Size = new System.Drawing.Size(180, 20);
            this.tbxPrenom.TabIndex = 4;
            this.tbxPrenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxKeyPress);
            // 
            // btnAppliquer
            // 
            this.btnAppliquer.Location = new System.Drawing.Point(85, 145);
            this.btnAppliquer.Name = "btnAppliquer";
            this.btnAppliquer.Size = new System.Drawing.Size(149, 26);
            this.btnAppliquer.TabIndex = 8;
            this.btnAppliquer.Text = "Appliquer et fermer";
            this.btnAppliquer.UseVisualStyleBackColor = true;
            this.btnAppliquer.Click += new System.EventHandler(this.btnAppliquer_Click);
            // 
            // cbxJour
            // 
            this.cbxJour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxJour.FormattingEnabled = true;
            this.cbxJour.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbxJour.Location = new System.Drawing.Point(118, 95);
            this.cbxJour.MaxDropDownItems = 31;
            this.cbxJour.Name = "cbxJour";
            this.cbxJour.Size = new System.Drawing.Size(38, 21);
            this.cbxJour.TabIndex = 5;
            this.cbxJour.TextChanged += new System.EventHandler(this.controleDate);
            // 
            // cbxMois
            // 
            this.cbxMois.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMois.FormattingEnabled = true;
            this.cbxMois.Items.AddRange(new object[] {
            "Janvier",
            "Février",
            "Mars",
            "Avril",
            "Mai",
            "Juin",
            "Juillet",
            "Août",
            "Septembre",
            "Octobre",
            "Novembre",
            "Décembre"});
            this.cbxMois.Location = new System.Drawing.Point(162, 95);
            this.cbxMois.Name = "cbxMois";
            this.cbxMois.Size = new System.Drawing.Size(77, 21);
            this.cbxMois.TabIndex = 6;
            this.cbxMois.TextChanged += new System.EventHandler(this.controleDate);
            // 
            // cbxAnnee
            // 
            this.cbxAnnee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAnnee.FormattingEnabled = true;
            this.cbxAnnee.Location = new System.Drawing.Point(243, 95);
            this.cbxAnnee.Name = "cbxAnnee";
            this.cbxAnnee.Size = new System.Drawing.Size(55, 21);
            this.cbxAnnee.TabIndex = 7;
            this.cbxAnnee.TextChanged += new System.EventHandler(this.controleDate);
            // 
            // pbxErreur
            // 
            this.pbxErreur.ErrorImage = null;
            this.pbxErreur.ImageLocation = "";
            this.pbxErreur.Location = new System.Drawing.Point(301, 97);
            this.pbxErreur.Name = "pbxErreur";
            this.pbxErreur.Size = new System.Drawing.Size(16, 16);
            this.pbxErreur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxErreur.TabIndex = 7;
            this.pbxErreur.TabStop = false;
            // 
            // Login
            // 
            this.AcceptButton = this.btnAppliquer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 183);
            this.Controls.Add(this.pbxErreur);
            this.Controls.Add(this.cbxAnnee);
            this.Controls.Add(this.cbxMois);
            this.Controls.Add(this.cbxJour);
            this.Controls.Add(this.btnAppliquer);
            this.Controls.Add(this.tbxPrenom);
            this.Controls.Add(this.tbxNom);
            this.Controls.Add(this.lblDatenaissance);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "La planche d\'équilibre - Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxErreur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblDatenaissance;
        private System.Windows.Forms.TextBox tbxNom;
        private System.Windows.Forms.TextBox tbxPrenom;
        private System.Windows.Forms.Button btnAppliquer;
        private System.Windows.Forms.ComboBox cbxJour;
        private System.Windows.Forms.ComboBox cbxMois;
        private System.Windows.Forms.ComboBox cbxAnnee;
        private System.Windows.Forms.PictureBox pbxErreur;
        private System.Windows.Forms.ContextMenuStrip contextMenuVide;
    }
}