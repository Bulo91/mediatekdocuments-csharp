namespace MediaTekDocuments.view
{
    partial class FrmConnexion
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblLogin = new System.Windows.Forms.Label();
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.lblMotDePasse = new System.Windows.Forms.Label();
            this.txbMotDePasse = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lblLogin
            //
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(12, 20);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(39, 13);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login :";
            //
            // txbLogin
            //
            this.txbLogin.Location = new System.Drawing.Point(120, 17);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(200, 20);
            this.txbLogin.TabIndex = 1;
            //
            // lblMotDePasse
            //
            this.lblMotDePasse.AutoSize = true;
            this.lblMotDePasse.Location = new System.Drawing.Point(12, 55);
            this.lblMotDePasse.Name = "lblMotDePasse";
            this.lblMotDePasse.Size = new System.Drawing.Size(77, 13);
            this.lblMotDePasse.TabIndex = 2;
            this.lblMotDePasse.Text = "Mot de passe :";
            //
            // txbMotDePasse
            //
            this.txbMotDePasse.Location = new System.Drawing.Point(120, 52);
            this.txbMotDePasse.Name = "txbMotDePasse";
            this.txbMotDePasse.PasswordChar = '*';
            this.txbMotDePasse.Size = new System.Drawing.Size(200, 20);
            this.txbMotDePasse.TabIndex = 3;
            this.txbMotDePasse.UseSystemPasswordChar = true;
            //
            // btnValider
            //
            this.btnValider.Location = new System.Drawing.Point(164, 90);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 4;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.BtnValider_Click);
            //
            // btnAnnuler
            //
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(245, 90);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 5;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            //
            // FrmConnexion
            //
            this.AcceptButton = this.btnValider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(334, 131);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txbMotDePasse);
            this.Controls.Add(this.lblMotDePasse);
            this.Controls.Add(this.txbLogin);
            this.Controls.Add(this.lblLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txbLogin;
        private System.Windows.Forms.Label lblMotDePasse;
        private System.Windows.Forms.TextBox txbMotDePasse;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
    }
}
