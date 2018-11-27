namespace App
{
    partial class NouvelleCourse
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
            this.textBoxLieu = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBoxDist = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBoxDesc = new System.Windows.Forms.RichTextBox();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.dataGridViewLicencies = new System.Windows.Forms.DataGridView();
            this.numLicence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAjouterParticipant = new System.Windows.Forms.Button();
            this.dataGridViewParticipants = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonRetirerParticipant = new System.Windows.Forms.Button();
            this.buttonImport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLicencies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipants)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxLieu
            // 
            this.textBoxLieu.Location = new System.Drawing.Point(69, 107);
            this.textBoxLieu.Name = "textBoxLieu";
            this.textBoxLieu.Size = new System.Drawing.Size(200, 20);
            this.textBoxLieu.TabIndex = 0;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(69, 159);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 1;
            // 
            // textBoxDist
            // 
            this.textBoxDist.Location = new System.Drawing.Point(69, 133);
            this.textBoxDist.Name = "textBoxDist";
            this.textBoxDist.Size = new System.Drawing.Size(200, 20);
            this.textBoxDist.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lieu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Distance :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date :";
            // 
            // richTextBoxDesc
            // 
            this.richTextBoxDesc.Location = new System.Drawing.Point(69, 185);
            this.richTextBoxDesc.Name = "richTextBoxDesc";
            this.richTextBoxDesc.Size = new System.Drawing.Size(200, 104);
            this.richTextBoxDesc.TabIndex = 8;
            this.richTextBoxDesc.Text = "";
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(343, 372);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(75, 23);
            this.buttonAjouter.TabIndex = 9;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // dataGridViewLicencies
            // 
            this.dataGridViewLicencies.AllowUserToOrderColumns = true;
            this.dataGridViewLicencies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLicencies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numLicence,
            this.nom});
            this.dataGridViewLicencies.Location = new System.Drawing.Point(334, 107);
            this.dataGridViewLicencies.Name = "dataGridViewLicencies";
            this.dataGridViewLicencies.Size = new System.Drawing.Size(205, 224);
            this.dataGridViewLicencies.TabIndex = 10;
            // 
            // numLicence
            // 
            this.numLicence.HeaderText = "N° Licence";
            this.numLicence.Name = "numLicence";
            this.numLicence.Width = 80;
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            this.nom.Width = 80;
            // 
            // buttonAjouterParticipant
            // 
            this.buttonAjouterParticipant.Location = new System.Drawing.Point(545, 215);
            this.buttonAjouterParticipant.Name = "buttonAjouterParticipant";
            this.buttonAjouterParticipant.Size = new System.Drawing.Size(28, 26);
            this.buttonAjouterParticipant.TabIndex = 11;
            this.buttonAjouterParticipant.Text = ">>";
            this.buttonAjouterParticipant.UseVisualStyleBackColor = true;
            this.buttonAjouterParticipant.Click += new System.EventHandler(this.buttonAjouterParticipant_Click);
            // 
            // dataGridViewParticipants
            // 
            this.dataGridViewParticipants.AllowUserToOrderColumns = true;
            this.dataGridViewParticipants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParticipants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridViewParticipants.Location = new System.Drawing.Point(579, 107);
            this.dataGridViewParticipants.Name = "dataGridViewParticipants";
            this.dataGridViewParticipants.Size = new System.Drawing.Size(205, 224);
            this.dataGridViewParticipants.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "N° Licence";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // buttonRetirerParticipant
            // 
            this.buttonRetirerParticipant.Location = new System.Drawing.Point(545, 247);
            this.buttonRetirerParticipant.Name = "buttonRetirerParticipant";
            this.buttonRetirerParticipant.Size = new System.Drawing.Size(28, 26);
            this.buttonRetirerParticipant.TabIndex = 13;
            this.buttonRetirerParticipant.Text = "<<";
            this.buttonRetirerParticipant.UseVisualStyleBackColor = true;
            this.buttonRetirerParticipant.Click += new System.EventHandler(this.buttonRetirerParticipant_Click);
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(644, 46);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(111, 23);
            this.buttonImport.TabIndex = 14;
            this.buttonImport.Text = "Importer";
            this.buttonImport.UseVisualStyleBackColor = true;
            // 
            // NouvelleCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonImport);
            this.Controls.Add(this.buttonRetirerParticipant);
            this.Controls.Add(this.dataGridViewParticipants);
            this.Controls.Add(this.buttonAjouterParticipant);
            this.Controls.Add(this.dataGridViewLicencies);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.richTextBoxDesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDist);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.textBoxLieu);
            this.Name = "NouvelleCourse";
            this.Text = "NouvelleCourse";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLicencies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLieu;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox textBoxDist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBoxDesc;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.DataGridView dataGridViewLicencies;
        private System.Windows.Forms.DataGridViewTextBoxColumn numLicence;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.Button buttonAjouterParticipant;
        private System.Windows.Forms.DataGridView dataGridViewParticipants;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button buttonRetirerParticipant;
        private System.Windows.Forms.Button buttonImport;
    }
}