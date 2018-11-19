namespace App
{
    partial class Inscription
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
            this.buttonValider = new System.Windows.Forms.Button();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxMdp = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(223, 141);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(75, 23);
            this.buttonValider.TabIndex = 9;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(128, 101);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(77, 13);
            this.labelPass.TabIndex = 8;
            this.labelPass.Text = "Mot de passe :";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(146, 72);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(59, 13);
            this.labelLogin.TabIndex = 7;
            this.labelLogin.Text = "Identifiant :";
            // 
            // textBoxMdp
            // 
            this.textBoxMdp.Location = new System.Drawing.Point(211, 98);
            this.textBoxMdp.Name = "textBoxMdp";
            this.textBoxMdp.Size = new System.Drawing.Size(100, 20);
            this.textBoxMdp.TabIndex = 6;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(211, 69);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 5;
            // 
            // Inscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 233);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxMdp);
            this.Controls.Add(this.textBoxId);
            this.Name = "Inscription";
            this.Text = "Inscription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxMdp;
        private System.Windows.Forms.TextBox textBoxId;
    }
}