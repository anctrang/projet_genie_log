namespace App
{
    partial class InformationsCourse
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFermer = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Classement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDossard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courriel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vitesseMoyenne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allureMoyenne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numLicence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Classement,
            this.numDossard,
            this.nom,
            this.prenom,
            this.courriel,
            this.vitesseMoyenne,
            this.allureMoyenne,
            this.sexe,
            this.age,
            this.numLicence});
            this.dataGridView1.Location = new System.Drawing.Point(29, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 283);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom de la course ";
            // 
            // buttonFermer
            // 
            this.buttonFermer.Location = new System.Drawing.Point(307, 415);
            this.buttonFermer.Name = "buttonFermer";
            this.buttonFermer.Size = new System.Drawing.Size(75, 23);
            this.buttonFermer.TabIndex = 2;
            this.buttonFermer.Text = "Fermer";
            this.buttonFermer.UseVisualStyleBackColor = true;
            this.buttonFermer.Click += new System.EventHandler(this.buttonFermer_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(572, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lieu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date";
            // 
            // Classement
            // 
            this.Classement.HeaderText = "Classement";
            this.Classement.Name = "Classement";
            // 
            // numDossard
            // 
            this.numDossard.HeaderText = "N° Dossard";
            this.numDossard.Name = "numDossard";
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            // 
            // prenom
            // 
            this.prenom.HeaderText = "Prénom";
            this.prenom.Name = "prenom";
            // 
            // courriel
            // 
            this.courriel.HeaderText = "Courriel";
            this.courriel.Name = "courriel";
            // 
            // vitesseMoyenne
            // 
            this.vitesseMoyenne.HeaderText = "Vitesse moyenne";
            this.vitesseMoyenne.Name = "vitesseMoyenne";
            // 
            // allureMoyenne
            // 
            this.allureMoyenne.HeaderText = "Allure Moyenne";
            this.allureMoyenne.Name = "allureMoyenne";
            // 
            // sexe
            // 
            this.sexe.HeaderText = "Sexe";
            this.sexe.Name = "sexe";
            // 
            // age
            // 
            this.age.HeaderText = "Âge";
            this.age.Name = "age";
            // 
            // numLicence
            // 
            this.numLicence.HeaderText = "N° Licence";
            this.numLicence.Name = "numLicence";
            // 
            // InformationsCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFermer);
            this.Controls.Add(this.dataGridView1);
            this.Name = "InformationsCourse";
            this.Text = "InformationsCourse";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFermer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classement;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDossard;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn courriel;
        private System.Windows.Forms.DataGridViewTextBoxColumn vitesseMoyenne;
        private System.Windows.Forms.DataGridViewTextBoxColumn allureMoyenne;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexe;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn numLicence;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}