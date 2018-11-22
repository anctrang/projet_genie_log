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
            this.buttonAjouterCourse = new System.Windows.Forms.Button();
            this.buttonNouveauCoureur = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewCoureurs = new System.Windows.Forms.DataGridView();
            this.Numero_licence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_naissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabCoureurs.SuspendLayout();
            this.tabCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoureurs)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(590, 35);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "S\'identifier";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.Location = new System.Drawing.Point(671, 35);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(75, 23);
            this.buttonSignUp.TabIndex = 1;
            this.buttonSignUp.Text = "S\'inscrire";
            this.buttonSignUp.UseVisualStyleBackColor = true;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // buttonDeconnexion
            // 
            this.buttonDeconnexion.Location = new System.Drawing.Point(609, 35);
            this.buttonDeconnexion.Name = "buttonDeconnexion";
            this.buttonDeconnexion.Size = new System.Drawing.Size(118, 23);
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
            this.TabCoureurs.Location = new System.Drawing.Point(12, 83);
            this.TabCoureurs.Name = "TabCoureurs";
            this.TabCoureurs.SelectedIndex = 0;
            this.TabCoureurs.Size = new System.Drawing.Size(548, 359);
            this.TabCoureurs.TabIndex = 3;
            // 
            // tabCourses
            // 
            this.tabCourses.Controls.Add(this.dataGridViewCourses);
            this.tabCourses.Location = new System.Drawing.Point(4, 22);
            this.tabCourses.Name = "tabCourses";
            this.tabCourses.Padding = new System.Windows.Forms.Padding(3);
            this.tabCourses.Size = new System.Drawing.Size(540, 333);
            this.tabCourses.TabIndex = 0;
            this.tabCourses.Text = "Courses";
            this.tabCourses.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCourses
            // 
            this.dataGridViewCourses.AllowUserToOrderColumns = true;
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
            this.dataGridViewCourses.Size = new System.Drawing.Size(534, 327);
            this.dataGridViewCourses.TabIndex = 0;
            this.dataGridViewCourses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // buttonAjouterCourse
            // 
            this.buttonAjouterCourse.Location = new System.Drawing.Point(590, 126);
            this.buttonAjouterCourse.Name = "buttonAjouterCourse";
            this.buttonAjouterCourse.Size = new System.Drawing.Size(105, 23);
            this.buttonAjouterCourse.TabIndex = 4;
            this.buttonAjouterCourse.Text = "Nouvelle course";
            this.buttonAjouterCourse.UseVisualStyleBackColor = true;
            this.buttonAjouterCourse.Click += new System.EventHandler(this.buttonAjouterCourse_Click);
            // 
            // buttonNouveauCoureur
            // 
            this.buttonNouveauCoureur.Location = new System.Drawing.Point(590, 156);
            this.buttonNouveauCoureur.Name = "buttonNouveauCoureur";
            this.buttonNouveauCoureur.Size = new System.Drawing.Size(105, 23);
            this.buttonNouveauCoureur.TabIndex = 5;
            this.buttonNouveauCoureur.Text = "Nouveau coureur";
            this.buttonNouveauCoureur.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewCoureurs);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(540, 333);
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
            this.dataGridViewCoureurs.Size = new System.Drawing.Size(534, 327);
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
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 477);
            this.Controls.Add(this.buttonNouveauCoureur);
            this.Controls.Add(this.buttonAjouterCourse);
            this.Controls.Add(this.TabCoureurs);
            this.Controls.Add(this.buttonDeconnexion);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.buttonLogin);
            this.Name = "Accueil";
            this.Text = "Form1";
            this.TabCoureurs.ResumeLayout(false);
            this.tabCourses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoureurs)).EndInit();
            this.ResumeLayout(false);

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
    }
}

