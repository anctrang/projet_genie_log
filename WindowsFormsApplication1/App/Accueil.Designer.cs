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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabCourses = new System.Windows.Forms.TabPage();
            this.tabParticipants = new System.Windows.Forms.TabPage();
            this.dataGridViewCourses = new System.Windows.Forms.DataGridView();
            this.Numéro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nb_Participants = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.tabCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).BeginInit();
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
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabCourses);
            this.tabControl.Controls.Add(this.tabParticipants);
            this.tabControl.Location = new System.Drawing.Point(12, 83);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(548, 359);
            this.tabControl.TabIndex = 3;
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
            // tabParticipants
            // 
            this.tabParticipants.Location = new System.Drawing.Point(4, 22);
            this.tabParticipants.Name = "tabParticipants";
            this.tabParticipants.Padding = new System.Windows.Forms.Padding(3);
            this.tabParticipants.Size = new System.Drawing.Size(615, 259);
            this.tabParticipants.TabIndex = 1;
            this.tabParticipants.Text = "Participants";
            this.tabParticipants.UseVisualStyleBackColor = true;
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
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 435);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.buttonDeconnexion);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.buttonLogin);
            this.Name = "Accueil";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabCourses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button buttonLogin;
        public System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.Button buttonDeconnexion;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabCourses;
        private System.Windows.Forms.DataGridView dataGridViewCourses;
        private System.Windows.Forms.TabPage tabParticipants;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numéro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nb_Participants;
    }
}

