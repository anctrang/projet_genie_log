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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformationsCourse));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelNouvelleCourse = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBoxInfosCoureur = new System.Windows.Forms.GroupBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelLieu = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonNouveauResultat = new System.Windows.Forms.Button();
            this.buttonModifierResultat = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Classement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDossard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numLicence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vitesseMoyenne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allureMoyenne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxInfosCoureur.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("DejaVu Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Classement,
            this.numDossard,
            this.numLicence,
            this.nom,
            this.prenom,
            this.vitesseMoyenne,
            this.allureMoyenne,
            this.sexe,
            this.age});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("DejaVu Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(200, 196);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("DejaVu Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(623, 214);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.labelNouvelleCourse);
            this.groupBox1.Controls.Add(this.buttonClose);
            this.groupBox1.Location = new System.Drawing.Point(161, -4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 59);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // labelNouvelleCourse
            // 
            this.labelNouvelleCourse.AutoSize = true;
            this.labelNouvelleCourse.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNouvelleCourse.Location = new System.Drawing.Point(255, 14);
            this.labelNouvelleCourse.Name = "labelNouvelleCourse";
            this.labelNouvelleCourse.Size = new System.Drawing.Size(175, 30);
            this.labelNouvelleCourse.TabIndex = 17;
            this.labelNouvelleCourse.Text = "Résultats course";
            // 
            // buttonClose
            // 
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonClose.Location = new System.Drawing.Point(636, 11);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(38, 35);
            this.buttonClose.TabIndex = 11;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // groupBoxInfosCoureur
            // 
            this.groupBoxInfosCoureur.Controls.Add(this.labelDate);
            this.groupBoxInfosCoureur.Controls.Add(this.labelLieu);
            this.groupBoxInfosCoureur.Controls.Add(this.label4);
            this.groupBoxInfosCoureur.Controls.Add(this.label6);
            this.groupBoxInfosCoureur.Location = new System.Drawing.Point(630, 84);
            this.groupBoxInfosCoureur.Name = "groupBoxInfosCoureur";
            this.groupBoxInfosCoureur.Size = new System.Drawing.Size(200, 100);
            this.groupBoxInfosCoureur.TabIndex = 19;
            this.groupBoxInfosCoureur.TabStop = false;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("DejaVu Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(69, 50);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(68, 15);
            this.labelDate.TabIndex = 7;
            this.labelDate.Text = "labelDate";
            // 
            // labelLieu
            // 
            this.labelLieu.AutoSize = true;
            this.labelLieu.Font = new System.Drawing.Font("DejaVu Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLieu.Location = new System.Drawing.Point(74, 19);
            this.labelLieu.Name = "labelLieu";
            this.labelLieu.Size = new System.Drawing.Size(63, 15);
            this.labelLieu.TabIndex = 6;
            this.labelLieu.Text = "labelLieu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("DejaVu Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lieu :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("DejaVu Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Date :";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.Controls.Add(this.buttonNouveauResultat);
            this.groupBox3.Controls.Add(this.buttonModifierResultat);
            this.groupBox3.Location = new System.Drawing.Point(3, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(164, 439);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            // 
            // buttonNouveauResultat
            // 
            this.buttonNouveauResultat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonNouveauResultat.BackgroundImage")));
            this.buttonNouveauResultat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonNouveauResultat.FlatAppearance.BorderSize = 0;
            this.buttonNouveauResultat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNouveauResultat.Font = new System.Drawing.Font("DejaVu Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNouveauResultat.ForeColor = System.Drawing.Color.White;
            this.buttonNouveauResultat.Location = new System.Drawing.Point(6, 27);
            this.buttonNouveauResultat.Name = "buttonNouveauResultat";
            this.buttonNouveauResultat.Size = new System.Drawing.Size(146, 55);
            this.buttonNouveauResultat.TabIndex = 5;
            this.buttonNouveauResultat.Text = "Nouveau résultat";
            this.buttonNouveauResultat.UseVisualStyleBackColor = true;
            this.buttonNouveauResultat.Click += new System.EventHandler(this.buttonNouveauResultat_Click);
            // 
            // buttonModifierResultat
            // 
            this.buttonModifierResultat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonModifierResultat.BackgroundImage")));
            this.buttonModifierResultat.FlatAppearance.BorderSize = 0;
            this.buttonModifierResultat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifierResultat.Font = new System.Drawing.Font("DejaVu Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifierResultat.ForeColor = System.Drawing.Color.White;
            this.buttonModifierResultat.Location = new System.Drawing.Point(6, 86);
            this.buttonModifierResultat.Name = "buttonModifierResultat";
            this.buttonModifierResultat.Size = new System.Drawing.Size(146, 55);
            this.buttonModifierResultat.TabIndex = 6;
            this.buttonModifierResultat.Text = "Modifier résultat";
            this.buttonModifierResultat.UseVisualStyleBackColor = true;
            this.buttonModifierResultat.Click += new System.EventHandler(this.buttonModifierResultat_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Location = new System.Drawing.Point(3, -4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(164, 59);
            this.groupBox4.TabIndex = 21;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(38, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "GestioCourse";
            // 
            // Classement
            // 
            this.Classement.FillWeight = 60F;
            this.Classement.HeaderText = "Classement";
            this.Classement.Name = "Classement";
            this.Classement.Width = 60;
            // 
            // numDossard
            // 
            this.numDossard.FillWeight = 30F;
            this.numDossard.HeaderText = "N° Dossard";
            this.numDossard.Name = "numDossard";
            this.numDossard.Width = 60;
            // 
            // numLicence
            // 
            this.numLicence.FillWeight = 30F;
            this.numLicence.HeaderText = "N° Licence";
            this.numLicence.Name = "numLicence";
            this.numLicence.Width = 60;
            // 
            // nom
            // 
            this.nom.FillWeight = 80F;
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            this.nom.Width = 80;
            // 
            // prenom
            // 
            this.prenom.FillWeight = 80F;
            this.prenom.HeaderText = "Prénom";
            this.prenom.Name = "prenom";
            this.prenom.Width = 80;
            // 
            // vitesseMoyenne
            // 
            this.vitesseMoyenne.FillWeight = 30F;
            this.vitesseMoyenne.HeaderText = "Vitesse moyenne";
            this.vitesseMoyenne.Name = "vitesseMoyenne";
            this.vitesseMoyenne.Width = 60;
            // 
            // allureMoyenne
            // 
            this.allureMoyenne.FillWeight = 30F;
            this.allureMoyenne.HeaderText = "Allure Moyenne";
            this.allureMoyenne.Name = "allureMoyenne";
            this.allureMoyenne.Width = 60;
            // 
            // sexe
            // 
            this.sexe.FillWeight = 30F;
            this.sexe.HeaderText = "Sexe";
            this.sexe.Name = "sexe";
            this.sexe.Width = 60;
            // 
            // age
            // 
            this.age.FillWeight = 30F;
            this.age.HeaderText = "Âge";
            this.age.Name = "age";
            this.age.Width = 60;
            // 
            // InformationsCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(842, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxInfosCoureur);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InformationsCourse";
            this.Text = "InformationsCourse";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxInfosCoureur.ResumeLayout(false);
            this.groupBoxInfosCoureur.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelNouvelleCourse;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBoxInfosCoureur;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelLieu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonNouveauResultat;
        private System.Windows.Forms.Button buttonModifierResultat;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classement;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDossard;
        private System.Windows.Forms.DataGridViewTextBoxColumn numLicence;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn vitesseMoyenne;
        private System.Windows.Forms.DataGridViewTextBoxColumn allureMoyenne;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexe;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
    }
}