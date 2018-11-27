namespace App
{
    partial class InformationsCoureurs
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
            this.groupBoxInfosCoureur = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IDCourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistanceCourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllureMoyenne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VitesseMoyenne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonFermer = new System.Windows.Forms.Button();
            this.labelNumLicence = new System.Windows.Forms.Label();
            this.labelSexe = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxInfosCoureur.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCourse,
            this.DateCourse,
            this.DistanceCourse,
            this.Classement,
            this.AllureMoyenne,
            this.VitesseMoyenne});
            this.dataGridView1.Location = new System.Drawing.Point(47, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 200);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBoxInfosCoureur
            // 
            this.groupBoxInfosCoureur.Controls.Add(this.labelAge);
            this.groupBoxInfosCoureur.Controls.Add(this.labelNumLicence);
            this.groupBoxInfosCoureur.Controls.Add(this.labelSexe);
            this.groupBoxInfosCoureur.Location = new System.Drawing.Point(455, 12);
            this.groupBoxInfosCoureur.Name = "groupBoxInfosCoureur";
            this.groupBoxInfosCoureur.Size = new System.Drawing.Size(200, 100);
            this.groupBoxInfosCoureur.TabIndex = 1;
            this.groupBoxInfosCoureur.TabStop = false;
            this.groupBoxInfosCoureur.Text = "Informations générales";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom et prenom coureur";
            // 
            // IDCourse
            // 
            this.IDCourse.HeaderText = "Course";
            this.IDCourse.Name = "IDCourse";
            // 
            // DateCourse
            // 
            this.DateCourse.HeaderText = "Date";
            this.DateCourse.Name = "DateCourse";
            // 
            // DistanceCourse
            // 
            this.DistanceCourse.HeaderText = "Distance";
            this.DistanceCourse.Name = "DistanceCourse";
            // 
            // Classement
            // 
            this.Classement.HeaderText = "Classement";
            this.Classement.Name = "Classement";
            // 
            // AllureMoyenne
            // 
            this.AllureMoyenne.HeaderText = "Allure Moyenne";
            this.AllureMoyenne.Name = "AllureMoyenne";
            // 
            // VitesseMoyenne
            // 
            this.VitesseMoyenne.HeaderText = "Vitesse Moyenne";
            this.VitesseMoyenne.Name = "VitesseMoyenne";
            // 
            // buttonFermer
            // 
            this.buttonFermer.Location = new System.Drawing.Point(361, 359);
            this.buttonFermer.Name = "buttonFermer";
            this.buttonFermer.Size = new System.Drawing.Size(75, 23);
            this.buttonFermer.TabIndex = 3;
            this.buttonFermer.Text = "Fermer";
            this.buttonFermer.UseVisualStyleBackColor = true;
            // 
            // labelNumLicence
            // 
            this.labelNumLicence.AutoSize = true;
            this.labelNumLicence.Location = new System.Drawing.Point(16, 19);
            this.labelNumLicence.Name = "labelNumLicence";
            this.labelNumLicence.Size = new System.Drawing.Size(63, 13);
            this.labelNumLicence.TabIndex = 4;
            this.labelNumLicence.Text = "N° Licence:";
            // 
            // labelSexe
            // 
            this.labelSexe.AutoSize = true;
            this.labelSexe.Location = new System.Drawing.Point(16, 50);
            this.labelSexe.Name = "labelSexe";
            this.labelSexe.Size = new System.Drawing.Size(31, 13);
            this.labelSexe.TabIndex = 0;
            this.labelSexe.Text = "Sexe";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(19, 81);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(29, 13);
            this.labelAge.TabIndex = 5;
            this.labelAge.Text = "Age ";
            // 
            // InformationsCoureurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFermer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxInfosCoureur);
            this.Controls.Add(this.dataGridView1);
            this.Name = "InformationsCoureurs";
            this.Text = "InformationsCoureurs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxInfosCoureur.ResumeLayout(false);
            this.groupBoxInfosCoureur.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistanceCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classement;
        private System.Windows.Forms.DataGridViewTextBoxColumn AllureMoyenne;
        private System.Windows.Forms.DataGridViewTextBoxColumn VitesseMoyenne;
        private System.Windows.Forms.GroupBox groupBoxInfosCoureur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFermer;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelNumLicence;
        private System.Windows.Forms.Label labelSexe;
    }
}