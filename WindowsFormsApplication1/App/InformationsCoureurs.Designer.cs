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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformationsCoureurs));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxInfosCoureur = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelNomPrenom = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelNumLicence = new System.Windows.Forms.Label();
            this.labelSexe = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonNouveauResultat = new System.Windows.Forms.Button();
            this.buttonModifierResultat = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NDossard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistanceCourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllureMoyenne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VitesseMoyenne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxInfosCoureur.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("DejaVu Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.IDCourse,
            this.DateCourse,
            this.Classement,
            this.NDossard,
            this.DistanceCourse,
            this.AllureMoyenne,
            this.VitesseMoyenne});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("DejaVu Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.Location = new System.Drawing.Point(179, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("DejaVu Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.Size = new System.Drawing.Size(786, 200);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBoxInfosCoureur
            // 
            this.groupBoxInfosCoureur.Controls.Add(this.labelAge);
            this.groupBoxInfosCoureur.Controls.Add(this.labelSexe);
            this.groupBoxInfosCoureur.Controls.Add(this.labelNumLicence);
            this.groupBoxInfosCoureur.Controls.Add(this.label7);
            this.groupBoxInfosCoureur.Controls.Add(this.label4);
            this.groupBoxInfosCoureur.Controls.Add(this.label6);
            this.groupBoxInfosCoureur.Location = new System.Drawing.Point(777, 63);
            this.groupBoxInfosCoureur.Name = "groupBoxInfosCoureur";
            this.groupBoxInfosCoureur.Size = new System.Drawing.Size(200, 100);
            this.groupBoxInfosCoureur.TabIndex = 1;
            this.groupBoxInfosCoureur.TabStop = false;
            this.groupBoxInfosCoureur.Enter += new System.EventHandler(this.groupBoxInfosCoureur_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("DejaVu Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Âge :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("DejaVu Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "N° Licence:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("DejaVu Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sexe :";
            // 
            // labelNomPrenom
            // 
            this.labelNomPrenom.AutoSize = true;
            this.labelNomPrenom.Font = new System.Drawing.Font("DejaVu Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomPrenom.Location = new System.Drawing.Point(175, 137);
            this.labelNomPrenom.Name = "labelNomPrenom";
            this.labelNomPrenom.Size = new System.Drawing.Size(270, 22);
            this.labelNomPrenom.TabIndex = 2;
            this.labelNomPrenom.Text = "Nom et prenom coureur";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonClose);
            this.groupBox1.Location = new System.Drawing.Point(158, -6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(819, 63);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // buttonClose
            // 
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonClose.Location = new System.Drawing.Point(775, 9);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(38, 35);
            this.buttonClose.TabIndex = 11;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelNumLicence
            // 
            this.labelNumLicence.AutoSize = true;
            this.labelNumLicence.Font = new System.Drawing.Font("DejaVu Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumLicence.Location = new System.Drawing.Point(102, 19);
            this.labelNumLicence.Name = "labelNumLicence";
            this.labelNumLicence.Size = new System.Drawing.Size(45, 15);
            this.labelNumLicence.TabIndex = 6;
            this.labelNumLicence.Text = "label1";
            // 
            // labelSexe
            // 
            this.labelSexe.AutoSize = true;
            this.labelSexe.Font = new System.Drawing.Font("DejaVu Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSexe.Location = new System.Drawing.Point(69, 50);
            this.labelSexe.Name = "labelSexe";
            this.labelSexe.Size = new System.Drawing.Size(45, 15);
            this.labelSexe.TabIndex = 7;
            this.labelSexe.Text = "label2";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("DejaVu Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAge.Location = new System.Drawing.Point(65, 81);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(45, 15);
            this.labelAge.TabIndex = 8;
            this.labelAge.Text = "label3";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.Controls.Add(this.buttonNouveauResultat);
            this.groupBox3.Controls.Add(this.buttonModifierResultat);
            this.groupBox3.Location = new System.Drawing.Point(-2, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(164, 422);
            this.groupBox3.TabIndex = 19;
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
            this.groupBox4.Location = new System.Drawing.Point(-2, -6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(164, 67);
            this.groupBox4.TabIndex = 17;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 30);
            this.label2.TabIndex = 20;
            this.label2.Text = "Résultats coureur";
            // 
            // Num
            // 
            this.Num.HeaderText = "Num";
            this.Num.Name = "Num";
            this.Num.Width = 40;
            // 
            // IDCourse
            // 
            this.IDCourse.HeaderText = "Lieu";
            this.IDCourse.Name = "IDCourse";
            // 
            // DateCourse
            // 
            this.DateCourse.HeaderText = "Date";
            this.DateCourse.Name = "DateCourse";
            // 
            // Classement
            // 
            this.Classement.HeaderText = "Classement";
            this.Classement.Name = "Classement";
            // 
            // NDossard
            // 
            this.NDossard.HeaderText = "N° Dossard";
            this.NDossard.Name = "NDossard";
            // 
            // DistanceCourse
            // 
            this.DistanceCourse.HeaderText = "Distance";
            this.DistanceCourse.Name = "DistanceCourse";
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
            // InformationsCoureurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(977, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelNomPrenom);
            this.Controls.Add(this.groupBoxInfosCoureur);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InformationsCoureurs";
            this.Text = "InformationsCoureurs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxInfosCoureur.ResumeLayout(false);
            this.groupBoxInfosCoureur.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxInfosCoureur;
        private System.Windows.Forms.Label labelNomPrenom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelSexe;
        private System.Windows.Forms.Label labelNumLicence;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonNouveauResultat;
        private System.Windows.Forms.Button buttonModifierResultat;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classement;
        private System.Windows.Forms.DataGridViewTextBoxColumn NDossard;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistanceCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn AllureMoyenne;
        private System.Windows.Forms.DataGridViewTextBoxColumn VitesseMoyenne;
    }
}