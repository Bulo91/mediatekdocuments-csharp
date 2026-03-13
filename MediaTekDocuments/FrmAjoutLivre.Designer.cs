namespace MediaTekDocuments.view
{
	partial class FrmAjoutLivre
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
			this.lblId = new System.Windows.Forms.Label();
			this.txbId = new System.Windows.Forms.TextBox();
			this.lblTitre = new System.Windows.Forms.Label();
			this.txbTitre = new System.Windows.Forms.TextBox();
			this.lblAuteur = new System.Windows.Forms.Label();
			this.txbAuteur = new System.Windows.Forms.TextBox();
			this.lblIsbn = new System.Windows.Forms.Label();
			this.txbIsbn = new System.Windows.Forms.TextBox();
			this.lblGenre = new System.Windows.Forms.Label();
			this.cbxGenre = new System.Windows.Forms.ComboBox();
			this.lblPublic = new System.Windows.Forms.Label();
			this.cbxPublic = new System.Windows.Forms.ComboBox();
			this.lblRayon = new System.Windows.Forms.Label();
			this.cbxRayon = new System.Windows.Forms.ComboBox();
			this.btnValider = new System.Windows.Forms.Button();
			this.btnAnnuler = new System.Windows.Forms.Button();
			this.SuspendLayout();
			//
			// lblId
			//
			this.lblId.AutoSize = true;
			this.lblId.Location = new System.Drawing.Point(30, 30);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(18, 13);
			this.lblId.TabIndex = 0;
			this.lblId.Text = "Id";
			//
			// txbId
			//
			this.txbId.Location = new System.Drawing.Point(120, 27);
			this.txbId.Name = "txbId";
			this.txbId.Size = new System.Drawing.Size(200, 20);
			this.txbId.TabIndex = 1;
			//
			// lblTitre
			//
			this.lblTitre.AutoSize = true;
			this.lblTitre.Location = new System.Drawing.Point(30, 60);
			this.lblTitre.Name = "lblTitre";
			this.lblTitre.Size = new System.Drawing.Size(28, 13);
			this.lblTitre.TabIndex = 2;
			this.lblTitre.Text = "Titre";
			//
			// txbTitre
			//
			this.txbTitre.Location = new System.Drawing.Point(120, 57);
			this.txbTitre.Name = "txbTitre";
			this.txbTitre.Size = new System.Drawing.Size(200, 20);
			this.txbTitre.TabIndex = 3;
			//
			// lblAuteur
			//
			this.lblAuteur.AutoSize = true;
			this.lblAuteur.Location = new System.Drawing.Point(30, 90);
			this.lblAuteur.Name = "lblAuteur";
			this.lblAuteur.Size = new System.Drawing.Size(38, 13);
			this.lblAuteur.TabIndex = 4;
			this.lblAuteur.Text = "Auteur";
			//
			// txbAuteur
			//
			this.txbAuteur.Location = new System.Drawing.Point(120, 87);
			this.txbAuteur.Name = "txbAuteur";
			this.txbAuteur.Size = new System.Drawing.Size(200, 20);
			this.txbAuteur.TabIndex = 5;
			//
			// lblIsbn
			//
			this.lblIsbn.AutoSize = true;
			this.lblIsbn.Location = new System.Drawing.Point(30, 120);
			this.lblIsbn.Name = "lblIsbn";
			this.lblIsbn.Size = new System.Drawing.Size(32, 13);
			this.lblIsbn.TabIndex = 6;
			this.lblIsbn.Text = "ISBN";
			//
			// txbIsbn
			//
			this.txbIsbn.Location = new System.Drawing.Point(120, 117);
			this.txbIsbn.Name = "txbIsbn";
			this.txbIsbn.Size = new System.Drawing.Size(200, 20);
			this.txbIsbn.TabIndex = 7;
			//
			// lblGenre
			//
			this.lblGenre.AutoSize = true;
			this.lblGenre.Location = new System.Drawing.Point(30, 150);
			this.lblGenre.Name = "lblGenre";
			this.lblGenre.Size = new System.Drawing.Size(36, 13);
			this.lblGenre.TabIndex = 8;
			this.lblGenre.Text = "Genre";
			//
			// cbxGenre
			//
			this.cbxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxGenre.FormattingEnabled = true;
			this.cbxGenre.Location = new System.Drawing.Point(120, 147);
			this.cbxGenre.Name = "cbxGenre";
			this.cbxGenre.Size = new System.Drawing.Size(200, 21);
			this.cbxGenre.TabIndex = 9;
			//
			// lblPublic
			//
			this.lblPublic.AutoSize = true;
			this.lblPublic.Location = new System.Drawing.Point(30, 180);
			this.lblPublic.Name = "lblPublic";
			this.lblPublic.Size = new System.Drawing.Size(36, 13);
			this.lblPublic.TabIndex = 10;
			this.lblPublic.Text = "Public";
			//
			// cbxPublic
			//
			this.cbxPublic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxPublic.FormattingEnabled = true;
			this.cbxPublic.Location = new System.Drawing.Point(120, 177);
			this.cbxPublic.Name = "cbxPublic";
			this.cbxPublic.Size = new System.Drawing.Size(200, 21);
			this.cbxPublic.TabIndex = 11;
			//
			// lblRayon
			//
			this.lblRayon.AutoSize = true;
			this.lblRayon.Location = new System.Drawing.Point(30, 210);
			this.lblRayon.Name = "lblRayon";
			this.lblRayon.Size = new System.Drawing.Size(38, 13);
			this.lblRayon.TabIndex = 12;
			this.lblRayon.Text = "Rayon";
			//
			// cbxRayon
			//
			this.cbxRayon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxRayon.FormattingEnabled = true;
			this.cbxRayon.Location = new System.Drawing.Point(120, 207);
			this.cbxRayon.Name = "cbxRayon";
			this.cbxRayon.Size = new System.Drawing.Size(200, 21);
			this.cbxRayon.TabIndex = 13;
			//
			// btnValider
			//
			this.btnValider.Location = new System.Drawing.Point(120, 260);
			this.btnValider.Name = "btnValider";
			this.btnValider.Size = new System.Drawing.Size(90, 30);
			this.btnValider.TabIndex = 14;
			this.btnValider.Text = "Valider";
			this.btnValider.UseVisualStyleBackColor = true;
			this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
			//
			// btnAnnuler
			//
			this.btnAnnuler.Location = new System.Drawing.Point(230, 260);
			this.btnAnnuler.Name = "btnAnnuler";
			this.btnAnnuler.Size = new System.Drawing.Size(90, 30);
			this.btnAnnuler.TabIndex = 15;
			this.btnAnnuler.Text = "Annuler";
			this.btnAnnuler.UseVisualStyleBackColor = true;
			this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
			//
			// FrmAjoutLivre
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(400, 330);
			this.Controls.Add(this.btnAnnuler);
			this.Controls.Add(this.btnValider);
			this.Controls.Add(this.cbxRayon);
			this.Controls.Add(this.lblRayon);
			this.Controls.Add(this.cbxPublic);
			this.Controls.Add(this.lblPublic);
			this.Controls.Add(this.cbxGenre);
			this.Controls.Add(this.lblGenre);
			this.Controls.Add(this.txbIsbn);
			this.Controls.Add(this.lblIsbn);
			this.Controls.Add(this.txbAuteur);
			this.Controls.Add(this.lblAuteur);
			this.Controls.Add(this.txbTitre);
			this.Controls.Add(this.lblTitre);
			this.Controls.Add(this.txbId);
			this.Controls.Add(this.lblId);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmAjoutLivre";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Ajouter un livre";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Label lblId;
		private System.Windows.Forms.TextBox txbId;
		private System.Windows.Forms.Label lblTitre;
		private System.Windows.Forms.TextBox txbTitre;
		private System.Windows.Forms.Label lblAuteur;
		private System.Windows.Forms.TextBox txbAuteur;
		private System.Windows.Forms.Label lblIsbn;
		private System.Windows.Forms.TextBox txbIsbn;
		private System.Windows.Forms.Label lblGenre;
		private System.Windows.Forms.ComboBox cbxGenre;
		private System.Windows.Forms.Label lblPublic;
		private System.Windows.Forms.ComboBox cbxPublic;
		private System.Windows.Forms.Label lblRayon;
		private System.Windows.Forms.ComboBox cbxRayon;
		private System.Windows.Forms.Button btnValider;
		private System.Windows.Forms.Button btnAnnuler;
	}
}