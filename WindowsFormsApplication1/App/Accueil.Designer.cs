namespace App
{
    partial class Accueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.buttonDeconnexion = new System.Windows.Forms.Button();
            this.TabCoureurs = new System.Windows.Forms.TabControl();
            this.tabCourses = new System.Windows.Forms.TabPage();
            this.dataGridViewCourses = new System.Windows.Forms.DataGridView();
            this.Numéro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nb_Participants = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewCoureurs = new System.Windows.Forms.DataGridView();
            this.Numero_licence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_naissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAjouterCourse = new System.Windows.Forms.Button();
            this.buttonNouveauCoureur = new System.Windows.Forms.Button();
            this.buttonModifierCourse = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonImportResultats = new System.Windows.Forms.Button();
            this.buttonImportCoureurs = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNumLicence = new System.Windows.Forms.TextBox();
            this.buttonValider = new System.Windows.Forms.Button();
            this.TabCoureurs.SuspendLayout();
            this.tabCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoureurs)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("DejaVu Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(0, 9);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(93, 50);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "S\'identifier";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.FlatAppearance.BorderSize = 0;
            this.buttonSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignUp.Font = new System.Drawing.Font("DejaVu Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignUp.Location = new System.Drawing.Point(99, 12);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(93, 44);
            this.buttonSignUp.TabIndex = 1;
            this.buttonSignUp.Text = "S\'inscrire";
            this.buttonSignUp.UseVisualStyleBackColor = true;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // buttonDeconnexion
            // 
            this.buttonDeconnexion.FlatAppearance.BorderSize = 0;
            this.buttonDeconnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeconnexion.Font = new System.Drawing.Font("DejaVu Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeconnexion.Location = new System.Drawing.Point(0, 8);
            this.buttonDeconnexion.Name = "buttonDeconnexion";
            this.buttonDeconnexion.Size = new System.Drawing.Size(102, 45);
            this.buttonDeconnexion.TabIndex = 2;
            this.buttonDeconnexion.Text = "Se déconnecter";
            this.buttonDeconnexion.UseVisualStyleBackColor = true;
            this.buttonDeconnexion.Visible = false;
            this.buttonDeconnexion.Click += new System.EventHandler(this.buttonDeconnexion_Click);
            // 
            // TabCoureurs
            // 
            this.TabCoureurs.Controls.Add(this.tabCourses);
            this.TabCoureurs.Controls.Add(this.tabPage1);
            this.TabCoureurs.Font = new System.Drawing.Font("DejaVu Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabCoureurs.Location = new System.Drawing.Point(237, 106);
            this.TabCoureurs.Name = "TabCoureurs";
            this.TabCoureurs.SelectedIndex = 0;
            this.TabCoureurs.Size = new System.Drawing.Size(557, 359);
            this.TabCoureurs.TabIndex = 3;
            // 
            // tabCourses
            // 
            this.tabCourses.Controls.Add(this.dataGridViewCourses);
            this.tabCourses.Location = new System.Drawing.Point(4, 23);
            this.tabCourses.Name = "tabCourses";
            this.tabCourses.Padding = new System.Windows.Forms.Padding(3);
            this.tabCourses.Size = new System.Drawing.Size(549, 332);
            this.tabCourses.TabIndex = 0;
            this.tabCourses.Text = "Courses";
            this.tabCourses.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCourses
            // 
            this.dataGridViewCourses.AllowUserToOrderColumns = true;
            this.dataGridViewCourses.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewCourses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridViewCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numéro,
            this.Date,
            this.Lieu,
            this.Distance,
            this.Nb_Participants});
            this.dataGridViewCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCourses.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewCourses.Name = "dataGridViewCourses";
            this.dataGridViewCourses.Size = new System.Drawing.Size(543, 326);
            this.dataGridViewCourses.TabIndex = 0;
            
            // 
            // Numéro
            // 
            this.Numéro.HeaderText = "Numéro";
            this.Numéro.Name = "Numéro";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Lieu
            // 
            this.Lieu.HeaderText = "Lieu";
            this.Lieu.Name = "Lieu";
            // 
            // Distance
            // 
            this.Distance.HeaderText = "Distance";
            this.Distance.Name = "Distance";
            // 
            // Nb_Participants
            // 
            this.Nb_Participants.HeaderText = "Nombre de participants";
            this.Nb_Participants.Name = "Nb_Participants";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewCoureurs);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(552, 332);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Coureurs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCoureurs
            // 
            this.dataGridViewCoureurs.AllowUserToOrderColumns = true;
            this.dataGridViewCoureurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCoureurs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero_licence,
            this.Nom,
            this.prenom,
            this.date_naissance});
            this.dataGridViewCoureurs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCoureurs.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewCoureurs.Name = "dataGridViewCoureurs";
            this.dataGridViewCoureurs.Size = new System.Drawing.Size(546, 326);
            this.dataGridViewCoureurs.TabIndex = 0;
            // 
            // Numero_licence
            // 
            this.Numero_licence.HeaderText = "N° Licence";
            this.Numero_licence.Name = "Numero_licence";
            this.Numero_licence.Width = 130;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.Width = 130;
            // 
            // prenom
            // 
            this.prenom.HeaderText = "Prénom";
            this.prenom.Name = "prenom";
            this.prenom.Width = 130;
            // 
            // date_naissance
            // 
            this.date_naissance.HeaderText = "Date de naissance";
            this.date_naissance.Name = "date_naissance";
            this.date_naissance.Width = 130;
            // 
            // buttonAjouterCourse
            // 
            this.buttonAjouterCourse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAjouterCourse.BackgroundImage")));
            this.buttonAjouterCourse.FlatAppearance.BorderSize = 0;
            this.buttonAjouterCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouterCourse.ForeColor = System.Drawing.Color.White;
            this.buttonAjouterCourse.Location = new System.Drawing.Point(6, 78);
            this.buttonAjouterCourse.Name = "buttonAjouterCourse";
            this.buttonAjouterCourse.Size = new System.Drawing.Size(146, 57);
            this.buttonAjouterCourse.TabIndex = 4;
            this.buttonAjouterCourse.Text = "Nouvelle course";
            this.buttonAjouterCourse.UseVisualStyleBackColor = true;
            this.buttonAjouterCourse.Click += new System.EventHandler(this.buttonAjouterCourse_Click);
            // 
            // buttonNouveauCoureur
            // 
            this.buttonNouveauCoureur.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonNouveauCoureur.BackgroundImage")));
            this.buttonNouveauCoureur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonNouveauCoureur.FlatAppearance.BorderSize = 0;
            this.buttonNouveauCoureur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNouveauCoureur.Font = new System.Drawing.Font("DejaVu Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNouveauCoureur.ForeColor = System.Drawing.Color.White;
            this.buttonNouveauCoureur.Location = new System.Drawing.Point(6, 17);
            this.buttonNouveauCoureur.Name = "buttonNouveauCoureur";
            this.buttonNouveauCoureur.Size = new System.Drawing.Size(146, 55);
            this.buttonNouveauCoureur.TabIndex = 5;
            this.buttonNouveauCoureur.Text = "Nouveau coureur";
            this.buttonNouveauCoureur.UseVisualStyleBackColor = true;
            this.buttonNouveauCoureur.Click += new System.EventHandler(this.buttonNouveauCoureur_Click);
            // 
            // buttonModifierCourse
            // 
            this.buttonModifierCourse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonModifierCourse.BackgroundImage")));
            this.buttonModifierCourse.FlatAppearance.BorderSize = 0;
            this.buttonModifierCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifierCourse.Font = new System.Drawing.Font("DejaVu Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifierCourse.ForeColor = System.Drawing.Color.White;
            this.buttonModifierCourse.Location = new System.Drawing.Point(6, 141);
            this.buttonModifierCourse.Name = "buttonModifierCourse";
            this.buttonModifierCourse.Size = new System.Drawing.Size(146, 55);
            this.buttonModifierCourse.TabIndex = 6;
            this.buttonModifierCourse.Text = "Modifier course";
            this.buttonModifierCourse.UseVisualStyleBackColor = true;
            this.buttonModifierCourse.Click += new System.EventHandler(this.buttonModifierCourse_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.BackColor = System.Drawing.Color.Transparent;
            this.buttonInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonInfo.BackgroundImage")));
            this.buttonInfo.FlatAppearance.BorderSize = 0;
            this.buttonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo.ForeColor = System.Drawing.Color.White;
            this.buttonInfo.Location = new System.Drawing.Point(6, 202);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(146, 57);
            this.buttonInfo.TabIndex = 7;
            this.buttonInfo.Text = "Resultats";
            this.buttonInfo.UseVisualStyleBackColor = false;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.buttonClose);
            this.groupBox1.Controls.Add(this.buttonDeconnexion);
            this.groupBox1.Controls.Add(this.buttonLogin);
            this.groupBox1.Controls.Add(this.buttonSignUp);
            this.groupBox1.Location = new System.Drawing.Point(158, -6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 59);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // buttonClose
            // 
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonClose.Location = new System.Drawing.Point(645, 8);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(38, 35);
            this.buttonClose.TabIndex = 11;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.Controls.Add(this.buttonImportResultats);
            this.groupBox3.Controls.Add(this.buttonImportCoureurs);
            this.groupBox3.Controls.Add(this.buttonAjouterCourse);
            this.groupBox3.Controls.Add(this.buttonNouveauCoureur);
            this.groupBox3.Controls.Add(this.buttonModifierCourse);
            this.groupBox3.Controls.Add(this.buttonInfo);
            this.groupBox3.Location = new System.Drawing.Point(0, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(158, 437);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // buttonImportResultats
            // 
            this.buttonImportResultats.BackColor = System.Drawing.Color.Transparent;
            this.buttonImportResultats.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonImportResultats.BackgroundImage")));
            this.buttonImportResultats.FlatAppearance.BorderSize = 0;
            this.buttonImportResultats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImportResultats.ForeColor = System.Drawing.Color.White;
            this.buttonImportResultats.Location = new System.Drawing.Point(6, 328);
            this.buttonImportResultats.Name = "buttonImportResultats";
            this.buttonImportResultats.Size = new System.Drawing.Size(146, 57);
            this.buttonImportResultats.TabIndex = 9;
            this.buttonImportResultats.Text = "Importer résultats";
            this.buttonImportResultats.UseVisualStyleBackColor = false;
            this.buttonImportResultats.Click += new System.EventHandler(this.buttonImportResultats_Click);
            // 
            // buttonImportCoureurs
            // 
            this.buttonImportCoureurs.BackColor = System.Drawing.Color.Transparent;
            this.buttonImportCoureurs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonImportCoureurs.BackgroundImage")));
            this.buttonImportCoureurs.FlatAppearance.BorderSize = 0;
            this.buttonImportCoureurs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImportCoureurs.ForeColor = System.Drawing.Color.White;
            this.buttonImportCoureurs.Location = new System.Drawing.Point(6, 265);
            this.buttonImportCoureurs.Name = "buttonImportCoureurs";
            this.buttonImportCoureurs.Size = new System.Drawing.Size(146, 57);
            this.buttonImportCoureurs.TabIndex = 8;
            this.buttonImportCoureurs.Text = "Importer coureurs";
            this.buttonImportCoureurs.UseVisualStyleBackColor = false;
            this.buttonImportCoureurs.Click += new System.EventHandler(this.buttonImportCoureurs_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Location = new System.Drawing.Point(0, -6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(158, 59);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "GestioCourse";
            // 
            // textBoxNumLicence
            // 
            this.textBoxNumLicence.Location = new System.Drawing.Point(595, 76);
            this.textBoxNumLicence.Name = "textBoxNumLicence";
            this.textBoxNumLicence.Size = new System.Drawing.Size(119, 20);
            this.textBoxNumLicence.TabIndex = 11;
            this.textBoxNumLicence.Text = "N° Licence";
            // 
            // buttonValider
            // 
            this.buttonValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonValider.Font = new System.Drawing.Font("DejaVu Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValider.ForeColor = System.Drawing.Color.White;
            this.buttonValider.Location = new System.Drawing.Point(726, 74);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(108, 22);
            this.buttonValider.TabIndex = 43;
            this.buttonValider.Text = "Rechercher";
            this.buttonValider.UseVisualStyleBackColor = false;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(846, 477);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.textBoxNumLicence);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TabCoureurs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Accueil";
            this.Text = "Gestionnaire de courses";
            this.TabCoureurs.ResumeLayout(false);
            this.tabCourses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoureurs)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button buttonLogin;
        public System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.Button buttonDeconnexion;
        private System.Windows.Forms.TabControl TabCoureurs;
        private System.Windows.Forms.TabPage tabCourses;
        private System.Windows.Forms.DataGridView dataGridViewCourses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numéro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nb_Participants;
        private System.Windows.Forms.Button buttonAjouterCourse;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonNouveauCoureur;
        private System.Windows.Forms.DataGridView dataGridViewCoureurs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_licence;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_naissance;
        private System.Windows.Forms.Button buttonModifierCourse;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxNumLicence;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Button buttonImportCoureurs;
        private System.Windows.Forms.Button buttonImportResultats;
    }
}

