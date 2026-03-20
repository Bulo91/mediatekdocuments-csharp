
namespace MediaTekDocuments.view
{
    partial class FrmMediatek
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
			this.tabOngletsApplication = new System.Windows.Forms.TabControl();
			this.tabLivres = new System.Windows.Forms.TabPage();
			this.tabCommandesLivres = new System.Windows.Forms.TabPage();
			this.tabCommandesDvd = new System.Windows.Forms.TabPage();
			this.tabCommandesRevues = new System.Windows.Forms.TabPage();
			this.grpCommandesRevuesNouvelle = new System.Windows.Forms.GroupBox();
			this.btnAjouterCommandeRevue = new System.Windows.Forms.Button();
			this.dtpCommandesRevuesDateFinAbonnement = new System.Windows.Forms.DateTimePicker();
			this.labelCommandesRevuesDateFinAbonnement = new System.Windows.Forms.Label();
			this.txbCommandesRevuesMontant = new System.Windows.Forms.TextBox();
			this.labelCommandesRevuesMontant = new System.Windows.Forms.Label();
			this.dtpCommandesRevuesDateCommande = new System.Windows.Forms.DateTimePicker();
			this.labelCommandesRevuesDateCommande = new System.Windows.Forms.Label();
			this.grpCommandesRevues = new System.Windows.Forms.GroupBox();
			this.btnSupprimerCommandeRevue = new System.Windows.Forms.Button();
			this.btnCommandesRevuesRechercher = new System.Windows.Forms.Button();
			this.dgvCommandesRevues = new System.Windows.Forms.DataGridView();
			this.colCommandesRevuesDateCommande = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCommandesRevuesMontant = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCommandesRevuesDateFinAbonnement = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txbCommandesRevuesRayon = new System.Windows.Forms.TextBox();
			this.txbCommandesRevuesPublic = new System.Windows.Forms.TextBox();
			this.txbCommandesRevuesGenre = new System.Windows.Forms.TextBox();
			this.txbCommandesRevuesTitre = new System.Windows.Forms.TextBox();
			this.txbCommandesRevuesNumero = new System.Windows.Forms.TextBox();
			this.labelCommandesRevuesRayon = new System.Windows.Forms.Label();
			this.labelCommandesRevuesPublic = new System.Windows.Forms.Label();
			this.labelCommandesRevuesGenre = new System.Windows.Forms.Label();
			this.labelCommandesRevuesTitre = new System.Windows.Forms.Label();
			this.labelCommandesRevuesNumero = new System.Windows.Forms.Label();
			this.grpCommandesLivresNouvelle = new System.Windows.Forms.GroupBox();
			this.btnAjouterCommandeLivre = new System.Windows.Forms.Button();
			this.txbCommandesLivresNbExemplaire = new System.Windows.Forms.TextBox();
			this.labelCommandesLivresNbExemplaire = new System.Windows.Forms.Label();
			this.txbCommandesLivresMontant = new System.Windows.Forms.TextBox();
			this.labelCommandesLivresMontant = new System.Windows.Forms.Label();
			this.dtpCommandesLivresDateCommande = new System.Windows.Forms.DateTimePicker();
			this.labelCommandesLivresDateCommande = new System.Windows.Forms.Label();
			this.grpCommandesLivres = new System.Windows.Forms.GroupBox();
			this.btnCommandesLivresRechercher = new System.Windows.Forms.Button();
			this.dgvCommandesLivres = new System.Windows.Forms.DataGridView();
			this.colDateCommande = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colMontant = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colNbExemplaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSuivi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txbCommandesLivresRayon = new System.Windows.Forms.TextBox();
			this.txbCommandesLivresPublic = new System.Windows.Forms.TextBox();
			this.txbCommandesLivresGenre = new System.Windows.Forms.TextBox();
			this.txbCommandesLivresTitre = new System.Windows.Forms.TextBox();
			this.txbCommandesLivresNumero = new System.Windows.Forms.TextBox();
			this.labelCommandesLivresRayon = new System.Windows.Forms.Label();
			this.labelCommandesLivresPublic = new System.Windows.Forms.Label();
			this.labelCommandesLivresGenre = new System.Windows.Forms.Label();
			this.labelCommandesLivresTitre = new System.Windows.Forms.Label();
			this.labelCommandesLivresNumero = new System.Windows.Forms.Label();
			this.labelCommandesLivresSuivi = new System.Windows.Forms.Label();
			this.cmbCommandesLivresSuivi = new System.Windows.Forms.ComboBox();
			this.btnModifierSuiviCommande = new System.Windows.Forms.Button();
			this.btnSupprimerCommande = new System.Windows.Forms.Button();
			this.grpCommandesDvdNouvelle = new System.Windows.Forms.GroupBox();
			this.btnAjouterCommandeDvd = new System.Windows.Forms.Button();
			this.txbCommandesDvdNbExemplaire = new System.Windows.Forms.TextBox();
			this.labelCommandesDvdNbExemplaire = new System.Windows.Forms.Label();
			this.txbCommandesDvdMontant = new System.Windows.Forms.TextBox();
			this.labelCommandesDvdMontant = new System.Windows.Forms.Label();
			this.dtpCommandesDvdDateCommande = new System.Windows.Forms.DateTimePicker();
			this.labelCommandesDvdDateCommande = new System.Windows.Forms.Label();
			this.grpCommandesDvd = new System.Windows.Forms.GroupBox();
			this.btnCommandesDvdSupprimer = new System.Windows.Forms.Button();
			this.btnCommandesDvdModifierSuivi = new System.Windows.Forms.Button();
			this.cmbCommandesDvdSuivi = new System.Windows.Forms.ComboBox();
			this.labelCommandesDvdSuivi = new System.Windows.Forms.Label();
			this.btnCommandesDvdRechercher = new System.Windows.Forms.Button();
			this.dgvCommandesDvd = new System.Windows.Forms.DataGridView();
			this.colDateCommandeDvd = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colMontantDvd = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colNbExemplaireDvd = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSuiviDvd = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txbCommandesDvdRayon = new System.Windows.Forms.TextBox();
			this.txbCommandesDvdPublic = new System.Windows.Forms.TextBox();
			this.txbCommandesDvdGenre = new System.Windows.Forms.TextBox();
			this.txbCommandesDvdTitre = new System.Windows.Forms.TextBox();
			this.txbCommandesDvdNumero = new System.Windows.Forms.TextBox();
			this.labelCommandesDvdRayon = new System.Windows.Forms.Label();
			this.labelCommandesDvdPublic = new System.Windows.Forms.Label();
			this.labelCommandesDvdGenre = new System.Windows.Forms.Label();
			this.labelCommandesDvdTitre = new System.Windows.Forms.Label();
			this.labelCommandesDvdNumero = new System.Windows.Forms.Label();
			this.grpLivresInfos = new System.Windows.Forms.GroupBox();
			this.label59 = new System.Windows.Forms.Label();
			this.txbLivresIsbn = new System.Windows.Forms.TextBox();
			this.txbLivresImage = new System.Windows.Forms.TextBox();
			this.txbLivresRayon = new System.Windows.Forms.TextBox();
			this.txbLivresPublic = new System.Windows.Forms.TextBox();
			this.txbLivresGenre = new System.Windows.Forms.TextBox();
			this.txbLivresCollection = new System.Windows.Forms.TextBox();
			this.txbLivresAuteur = new System.Windows.Forms.TextBox();
			this.txbLivresTitre = new System.Windows.Forms.TextBox();
			this.txbLivresNumero = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.pcbLivresImage = new System.Windows.Forms.PictureBox();
			this.label19 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.grpLivresRecherche = new System.Windows.Forms.GroupBox();
			this.btnSupprimerLivre = new System.Windows.Forms.Button();
			this.btnModifierLivre = new System.Windows.Forms.Button();
			this.btnAjouterLivre = new System.Windows.Forms.Button();
			this.btnLivresAnnulRayons = new System.Windows.Forms.Button();
			this.btnlivresAnnulPublics = new System.Windows.Forms.Button();
			this.btnLivresNumRecherche = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.txbLivresNumRecherche = new System.Windows.Forms.TextBox();
			this.btnLivresAnnulGenres = new System.Windows.Forms.Button();
			this.cbxLivresRayons = new System.Windows.Forms.ComboBox();
			this.label21 = new System.Windows.Forms.Label();
			this.cbxLivresPublics = new System.Windows.Forms.ComboBox();
			this.label20 = new System.Windows.Forms.Label();
			this.cbxLivresGenres = new System.Windows.Forms.ComboBox();
			this.label14 = new System.Windows.Forms.Label();
			this.dgvLivresListe = new System.Windows.Forms.DataGridView();
			this.label6 = new System.Windows.Forms.Label();
			this.txbLivresTitreRecherche = new System.Windows.Forms.TextBox();
			this.grpLivresExemplaires = new System.Windows.Forms.GroupBox();
			this.btnLivresExemplaireSupprimer = new System.Windows.Forms.Button();
			this.btnLivresExemplaireModifierEtat = new System.Windows.Forms.Button();
			this.cbxLivresExemplaireEtat = new System.Windows.Forms.ComboBox();
			this.labelLivresExemplaireEtat = new System.Windows.Forms.Label();
			this.dgvLivresExemplairesListe = new System.Windows.Forms.DataGridView();
			this.tabDvd = new System.Windows.Forms.TabPage();
			this.grpDvdInfos = new System.Windows.Forms.GroupBox();
			this.label58 = new System.Windows.Forms.Label();
			this.txbDvdDuree = new System.Windows.Forms.TextBox();
			this.txbDvdImage = new System.Windows.Forms.TextBox();
			this.txbDvdRayon = new System.Windows.Forms.TextBox();
			this.txbDvdPublic = new System.Windows.Forms.TextBox();
			this.txbDvdGenre = new System.Windows.Forms.TextBox();
			this.txbDvdSynopsis = new System.Windows.Forms.TextBox();
			this.txbDvdRealisateur = new System.Windows.Forms.TextBox();
			this.txbDvdTitre = new System.Windows.Forms.TextBox();
			this.txbDvdNumero = new System.Windows.Forms.TextBox();
			this.label23 = new System.Windows.Forms.Label();
			this.pcbDvdImage = new System.Windows.Forms.PictureBox();
			this.label24 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.label29 = new System.Windows.Forms.Label();
			this.label30 = new System.Windows.Forms.Label();
			this.label31 = new System.Windows.Forms.Label();
			this.grpDvdRecherche = new System.Windows.Forms.GroupBox();
			this.btnSupprimerDvd = new System.Windows.Forms.Button();
			this.btnModifierDvd = new System.Windows.Forms.Button();
			this.btnAjouterDvd = new System.Windows.Forms.Button();
			this.btnDvdAnnulRayons = new System.Windows.Forms.Button();
			this.btnDvdAnnulPublics = new System.Windows.Forms.Button();
			this.btnDvdNumRecherche = new System.Windows.Forms.Button();
			this.label38 = new System.Windows.Forms.Label();
			this.txbDvdNumRecherche = new System.Windows.Forms.TextBox();
			this.btnDvdAnnulGenres = new System.Windows.Forms.Button();
			this.cbxDvdRayons = new System.Windows.Forms.ComboBox();
			this.label39 = new System.Windows.Forms.Label();
			this.cbxDvdPublics = new System.Windows.Forms.ComboBox();
			this.label40 = new System.Windows.Forms.Label();
			this.cbxDvdGenres = new System.Windows.Forms.ComboBox();
			this.label41 = new System.Windows.Forms.Label();
			this.dgvDvdListe = new System.Windows.Forms.DataGridView();
			this.label42 = new System.Windows.Forms.Label();
			this.txbDvdTitreRecherche = new System.Windows.Forms.TextBox();
			this.grpDvdExemplaires = new System.Windows.Forms.GroupBox();
			this.btnDvdExemplaireSupprimer = new System.Windows.Forms.Button();
			this.btnDvdExemplaireModifierEtat = new System.Windows.Forms.Button();
			this.cbxDvdExemplaireEtat = new System.Windows.Forms.ComboBox();
			this.labelDvdExemplaireEtat = new System.Windows.Forms.Label();
			this.dgvDvdExemplairesListe = new System.Windows.Forms.DataGridView();
			this.tabRevues = new System.Windows.Forms.TabPage();
			this.grpRevuesInfos = new System.Windows.Forms.GroupBox();
			this.label57 = new System.Windows.Forms.Label();
			this.txbRevuesImage = new System.Windows.Forms.TextBox();
			this.txbRevuesRayon = new System.Windows.Forms.TextBox();
			this.txbRevuesPublic = new System.Windows.Forms.TextBox();
			this.txbRevuesGenre = new System.Windows.Forms.TextBox();
			this.txbRevuesDateMiseADispo = new System.Windows.Forms.TextBox();
			this.txbRevuesPeriodicite = new System.Windows.Forms.TextBox();
			this.txbRevuesTitre = new System.Windows.Forms.TextBox();
			this.txbRevuesNumero = new System.Windows.Forms.TextBox();
			this.label35 = new System.Windows.Forms.Label();
			this.pcbRevuesImage = new System.Windows.Forms.PictureBox();
			this.label36 = new System.Windows.Forms.Label();
			this.label37 = new System.Windows.Forms.Label();
			this.label43 = new System.Windows.Forms.Label();
			this.label44 = new System.Windows.Forms.Label();
			this.label45 = new System.Windows.Forms.Label();
			this.label46 = new System.Windows.Forms.Label();
			this.label47 = new System.Windows.Forms.Label();
			this.grpRevuesRecherche = new System.Windows.Forms.GroupBox();
			this.btnSupprimerRevue = new System.Windows.Forms.Button();
			this.btnModifierRevue = new System.Windows.Forms.Button();
			this.btnAjouterRevue = new System.Windows.Forms.Button();
			this.btnRevuesAnnulRayons = new System.Windows.Forms.Button();
			this.btnRevuesAnnulPublics = new System.Windows.Forms.Button();
			this.btnRevuesNumRecherche = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txbRevuesNumRecherche = new System.Windows.Forms.TextBox();
			this.btnRevuesAnnulGenres = new System.Windows.Forms.Button();
			this.cbxRevuesRayons = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cbxRevuesPublics = new System.Windows.Forms.ComboBox();
			this.label32 = new System.Windows.Forms.Label();
			this.cbxRevuesGenres = new System.Windows.Forms.ComboBox();
			this.label33 = new System.Windows.Forms.Label();
			this.dgvRevuesListe = new System.Windows.Forms.DataGridView();
			this.label34 = new System.Windows.Forms.Label();
			this.txbRevuesTitreRecherche = new System.Windows.Forms.TextBox();
			this.tabReceptionRevue = new System.Windows.Forms.TabPage();
			this.grpReceptionExemplaire = new System.Windows.Forms.GroupBox();
			this.label55 = new System.Windows.Forms.Label();
			this.btnReceptionExemplaireImage = new System.Windows.Forms.Button();
			this.pcbReceptionExemplaireImage = new System.Windows.Forms.PictureBox();
			this.btnReceptionExemplaireValider = new System.Windows.Forms.Button();
			this.txbReceptionExemplaireImage = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.txbReceptionExemplaireNumero = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.dtpReceptionExemplaireDate = new System.Windows.Forms.DateTimePicker();
			this.label16 = new System.Windows.Forms.Label();
			this.grpReceptionRevue = new System.Windows.Forms.GroupBox();
			this.label48 = new System.Windows.Forms.Label();
			this.label56 = new System.Windows.Forms.Label();
			this.pcbReceptionExemplaireRevueImage = new System.Windows.Forms.PictureBox();
			this.label13 = new System.Windows.Forms.Label();
			this.dgvReceptionExemplairesListe = new System.Windows.Forms.DataGridView();
			this.txbReceptionRevueImage = new System.Windows.Forms.TextBox();
			this.txbReceptionRevueRayon = new System.Windows.Forms.TextBox();
			this.txbReceptionRevuePublic = new System.Windows.Forms.TextBox();
			this.txbReceptionRevueGenre = new System.Windows.Forms.TextBox();
			this.txbReceptionRevueDelaiMiseADispo = new System.Windows.Forms.TextBox();
			this.txbReceptionRevuePeriodicite = new System.Windows.Forms.TextBox();
			this.txbReceptionRevueTitre = new System.Windows.Forms.TextBox();
			this.txbReceptionRevueNumero = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.pcbReceptionRevueImage = new System.Windows.Forms.PictureBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label49 = new System.Windows.Forms.Label();
			this.label50 = new System.Windows.Forms.Label();
			this.label51 = new System.Windows.Forms.Label();
			this.label52 = new System.Windows.Forms.Label();
			this.label53 = new System.Windows.Forms.Label();
			this.label54 = new System.Windows.Forms.Label();
			this.btnReceptionRechercher = new System.Windows.Forms.Button();
			this.labelReceptionExemplaireEtat = new System.Windows.Forms.Label();
			this.cbxReceptionExemplaireEtat = new System.Windows.Forms.ComboBox();
			this.btnReceptionExemplaireModifierEtat = new System.Windows.Forms.Button();
			this.btnReceptionExemplaireSupprimer = new System.Windows.Forms.Button();
			this.tabOngletsApplication.SuspendLayout();
			this.tabLivres.SuspendLayout();
			this.tabCommandesLivres.SuspendLayout();
			this.tabCommandesDvd.SuspendLayout();
			this.tabCommandesRevues.SuspendLayout();
			this.grpCommandesRevuesNouvelle.SuspendLayout();
			this.grpCommandesRevues.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCommandesRevues)).BeginInit();
			this.grpCommandesLivresNouvelle.SuspendLayout();
			this.grpCommandesLivres.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCommandesLivres)).BeginInit();
			this.grpCommandesDvdNouvelle.SuspendLayout();
			this.grpCommandesDvd.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCommandesDvd)).BeginInit();
			this.grpLivresInfos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcbLivresImage)).BeginInit();
			this.grpLivresRecherche.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvLivresListe)).BeginInit();
			this.grpLivresExemplaires.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvLivresExemplairesListe)).BeginInit();
			this.tabDvd.SuspendLayout();
			this.grpDvdInfos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcbDvdImage)).BeginInit();
			this.grpDvdRecherche.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDvdListe)).BeginInit();
			this.grpDvdExemplaires.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDvdExemplairesListe)).BeginInit();
			this.tabRevues.SuspendLayout();
			this.grpRevuesInfos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcbRevuesImage)).BeginInit();
			this.grpRevuesRecherche.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvRevuesListe)).BeginInit();
			this.tabReceptionRevue.SuspendLayout();
			this.grpReceptionExemplaire.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcbReceptionExemplaireImage)).BeginInit();
			this.grpReceptionRevue.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcbReceptionExemplaireRevueImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvReceptionExemplairesListe)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbReceptionRevueImage)).BeginInit();
			this.SuspendLayout();
			// 
			// tabOngletsApplication
			// 
			this.tabOngletsApplication.Controls.Add(this.tabLivres);
			this.tabOngletsApplication.Controls.Add(this.tabCommandesLivres);
			this.tabOngletsApplication.Controls.Add(this.tabCommandesDvd);
			this.tabOngletsApplication.Controls.Add(this.tabCommandesRevues);
			this.tabOngletsApplication.Controls.Add(this.tabDvd);
			this.tabOngletsApplication.Controls.Add(this.tabRevues);
			this.tabOngletsApplication.Controls.Add(this.tabReceptionRevue);
			this.tabOngletsApplication.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabOngletsApplication.ItemSize = new System.Drawing.Size(49, 18);
			this.tabOngletsApplication.Location = new System.Drawing.Point(0, 0);
			this.tabOngletsApplication.Name = "tabOngletsApplication";
			this.tabOngletsApplication.SelectedIndex = 0;
			this.tabOngletsApplication.Size = new System.Drawing.Size(883, 860);
			this.tabOngletsApplication.TabIndex = 0;
			// 
			// tabLivres
			// 
			this.tabLivres.Controls.Add(this.grpLivresExemplaires);
			this.tabLivres.Controls.Add(this.grpLivresInfos);
			this.tabLivres.Controls.Add(this.grpLivresRecherche);
			this.tabLivres.Location = new System.Drawing.Point(4, 22);
			this.tabLivres.Name = "tabLivres";
			this.tabLivres.Size = new System.Drawing.Size(875, 834);
			this.tabLivres.TabIndex = 2;
			this.tabLivres.Text = "Livres";
			this.tabLivres.UseVisualStyleBackColor = true;
			this.tabLivres.Enter += new System.EventHandler(this.TabLivres_Enter);
			// 
			// tabCommandesLivres
			// 
			this.tabCommandesLivres.Controls.Add(this.grpCommandesLivresNouvelle);
			this.tabCommandesLivres.Controls.Add(this.grpCommandesLivres);
			this.tabCommandesLivres.Location = new System.Drawing.Point(4, 22);
			this.tabCommandesLivres.Name = "tabCommandesLivres";
			this.tabCommandesLivres.Size = new System.Drawing.Size(875, 633);
			this.tabCommandesLivres.TabIndex = 4;
			this.tabCommandesLivres.Text = "Commandes Livres";
			this.tabCommandesLivres.UseVisualStyleBackColor = true;
			this.tabCommandesLivres.Enter += new System.EventHandler(this.tabCommandesLivres_Enter);
			// 
			// tabCommandesDvd
			// 
			this.tabCommandesDvd.Controls.Add(this.grpCommandesDvdNouvelle);
			this.tabCommandesDvd.Controls.Add(this.grpCommandesDvd);
			this.tabCommandesDvd.Location = new System.Drawing.Point(4, 22);
			this.tabCommandesDvd.Name = "tabCommandesDvd";
			this.tabCommandesDvd.Size = new System.Drawing.Size(875, 633);
			this.tabCommandesDvd.TabIndex = 5;
			this.tabCommandesDvd.Text = "Commandes DVD";
			this.tabCommandesDvd.UseVisualStyleBackColor = true;
			this.tabCommandesDvd.Enter += new System.EventHandler(this.tabCommandesDvd_Enter);
			// 
			// tabCommandesRevues
			// 
			this.tabCommandesRevues.Controls.Add(this.grpCommandesRevuesNouvelle);
			this.tabCommandesRevues.Controls.Add(this.grpCommandesRevues);
			this.tabCommandesRevues.Location = new System.Drawing.Point(4, 22);
			this.tabCommandesRevues.Name = "tabCommandesRevues";
			this.tabCommandesRevues.Size = new System.Drawing.Size(875, 633);
			this.tabCommandesRevues.TabIndex = 6;
			this.tabCommandesRevues.Text = "Commandes Revues";
			this.tabCommandesRevues.UseVisualStyleBackColor = true;
			this.tabCommandesRevues.Enter += new System.EventHandler(this.tabCommandesRevues_Enter);
			// 
			// grpCommandesRevuesNouvelle
			// 
			this.grpCommandesRevuesNouvelle.Controls.Add(this.btnAjouterCommandeRevue);
			this.grpCommandesRevuesNouvelle.Controls.Add(this.dtpCommandesRevuesDateFinAbonnement);
			this.grpCommandesRevuesNouvelle.Controls.Add(this.labelCommandesRevuesDateFinAbonnement);
			this.grpCommandesRevuesNouvelle.Controls.Add(this.txbCommandesRevuesMontant);
			this.grpCommandesRevuesNouvelle.Controls.Add(this.labelCommandesRevuesMontant);
			this.grpCommandesRevuesNouvelle.Controls.Add(this.dtpCommandesRevuesDateCommande);
			this.grpCommandesRevuesNouvelle.Controls.Add(this.labelCommandesRevuesDateCommande);
			this.grpCommandesRevuesNouvelle.Location = new System.Drawing.Point(8, 381);
			this.grpCommandesRevuesNouvelle.Name = "grpCommandesRevuesNouvelle";
			this.grpCommandesRevuesNouvelle.Size = new System.Drawing.Size(859, 120);
			this.grpCommandesRevuesNouvelle.TabIndex = 1;
			this.grpCommandesRevuesNouvelle.TabStop = false;
			this.grpCommandesRevuesNouvelle.Text = "Nouvelle commande";
			// 
			// btnAjouterCommandeRevue
			// 
			this.btnAjouterCommandeRevue.Location = new System.Drawing.Point(400, 70);
			this.btnAjouterCommandeRevue.Name = "btnAjouterCommandeRevue";
			this.btnAjouterCommandeRevue.Size = new System.Drawing.Size(100, 23);
			this.btnAjouterCommandeRevue.TabIndex = 6;
			this.btnAjouterCommandeRevue.Text = "Ajouter";
			this.btnAjouterCommandeRevue.UseVisualStyleBackColor = true;
			this.btnAjouterCommandeRevue.Click += new System.EventHandler(this.btnAjouterCommandeRevue_Click);
			// 
			// dtpCommandesRevuesDateFinAbonnement
			// 
			this.dtpCommandesRevuesDateFinAbonnement.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpCommandesRevuesDateFinAbonnement.Location = new System.Drawing.Point(150, 72);
			this.dtpCommandesRevuesDateFinAbonnement.Name = "dtpCommandesRevuesDateFinAbonnement";
			this.dtpCommandesRevuesDateFinAbonnement.Size = new System.Drawing.Size(100, 20);
			this.dtpCommandesRevuesDateFinAbonnement.TabIndex = 5;
			// 
			// labelCommandesRevuesDateFinAbonnement
			// 
			this.labelCommandesRevuesDateFinAbonnement.AutoSize = true;
			this.labelCommandesRevuesDateFinAbonnement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCommandesRevuesDateFinAbonnement.Location = new System.Drawing.Point(6, 75);
			this.labelCommandesRevuesDateFinAbonnement.Name = "labelCommandesRevuesDateFinAbonnement";
			this.labelCommandesRevuesDateFinAbonnement.Size = new System.Drawing.Size(130, 13);
			this.labelCommandesRevuesDateFinAbonnement.TabIndex = 4;
			this.labelCommandesRevuesDateFinAbonnement.Text = "Date fin abonnement :";
			// 
			// txbCommandesRevuesMontant
			// 
			this.txbCommandesRevuesMontant.Location = new System.Drawing.Point(150, 47);
			this.txbCommandesRevuesMontant.Name = "txbCommandesRevuesMontant";
			this.txbCommandesRevuesMontant.Size = new System.Drawing.Size(100, 20);
			this.txbCommandesRevuesMontant.TabIndex = 3;
			// 
			// labelCommandesRevuesMontant
			// 
			this.labelCommandesRevuesMontant.AutoSize = true;
			this.labelCommandesRevuesMontant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCommandesRevuesMontant.Location = new System.Drawing.Point(6, 50);
			this.labelCommandesRevuesMontant.Name = "labelCommandesRevuesMontant";
			this.labelCommandesRevuesMontant.Size = new System.Drawing.Size(64, 13);
			this.labelCommandesRevuesMontant.TabIndex = 2;
			this.labelCommandesRevuesMontant.Text = "Montant :";
			// 
			// dtpCommandesRevuesDateCommande
			// 
			this.dtpCommandesRevuesDateCommande.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpCommandesRevuesDateCommande.Location = new System.Drawing.Point(150, 22);
			this.dtpCommandesRevuesDateCommande.Name = "dtpCommandesRevuesDateCommande";
			this.dtpCommandesRevuesDateCommande.Size = new System.Drawing.Size(100, 20);
			this.dtpCommandesRevuesDateCommande.TabIndex = 1;
			// 
			// labelCommandesRevuesDateCommande
			// 
			this.labelCommandesRevuesDateCommande.AutoSize = true;
			this.labelCommandesRevuesDateCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCommandesRevuesDateCommande.Location = new System.Drawing.Point(6, 25);
			this.labelCommandesRevuesDateCommande.Name = "labelCommandesRevuesDateCommande";
			this.labelCommandesRevuesDateCommande.Size = new System.Drawing.Size(124, 13);
			this.labelCommandesRevuesDateCommande.TabIndex = 0;
			this.labelCommandesRevuesDateCommande.Text = "Date de commande :";
			// 
			// grpCommandesRevues
			// 
			this.grpCommandesRevues.Controls.Add(this.btnSupprimerCommandeRevue);
			this.grpCommandesRevues.Controls.Add(this.btnCommandesRevuesRechercher);
			this.grpCommandesRevues.Controls.Add(this.dgvCommandesRevues);
			this.grpCommandesRevues.Controls.Add(this.txbCommandesRevuesRayon);
			this.grpCommandesRevues.Controls.Add(this.txbCommandesRevuesPublic);
			this.grpCommandesRevues.Controls.Add(this.txbCommandesRevuesGenre);
			this.grpCommandesRevues.Controls.Add(this.txbCommandesRevuesTitre);
			this.grpCommandesRevues.Controls.Add(this.txbCommandesRevuesNumero);
			this.grpCommandesRevues.Controls.Add(this.labelCommandesRevuesRayon);
			this.grpCommandesRevues.Controls.Add(this.labelCommandesRevuesPublic);
			this.grpCommandesRevues.Controls.Add(this.labelCommandesRevuesGenre);
			this.grpCommandesRevues.Controls.Add(this.labelCommandesRevuesTitre);
			this.grpCommandesRevues.Controls.Add(this.labelCommandesRevuesNumero);
			this.grpCommandesRevues.Location = new System.Drawing.Point(8, 13);
			this.grpCommandesRevues.Name = "grpCommandesRevues";
			this.grpCommandesRevues.Size = new System.Drawing.Size(859, 362);
			this.grpCommandesRevues.TabIndex = 0;
			this.grpCommandesRevues.TabStop = false;
			this.grpCommandesRevues.Text = "Sélection revue";
			// 
			// btnSupprimerCommandeRevue
			// 
			this.btnSupprimerCommandeRevue.Location = new System.Drawing.Point(9, 338);
			this.btnSupprimerCommandeRevue.Name = "btnSupprimerCommandeRevue";
			this.btnSupprimerCommandeRevue.Size = new System.Drawing.Size(130, 23);
			this.btnSupprimerCommandeRevue.TabIndex = 14;
			this.btnSupprimerCommandeRevue.Text = "Supprimer commande";
			this.btnSupprimerCommandeRevue.UseVisualStyleBackColor = true;
			this.btnSupprimerCommandeRevue.Click += new System.EventHandler(this.btnSupprimerCommandeRevue_Click);
			// 
			// btnCommandesRevuesRechercher
			// 
			this.btnCommandesRevuesRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCommandesRevuesRechercher.Location = new System.Drawing.Point(261, 19);
			this.btnCommandesRevuesRechercher.Name = "btnCommandesRevuesRechercher";
			this.btnCommandesRevuesRechercher.Size = new System.Drawing.Size(96, 22);
			this.btnCommandesRevuesRechercher.TabIndex = 11;
			this.btnCommandesRevuesRechercher.Text = "Rechercher";
			this.btnCommandesRevuesRechercher.UseVisualStyleBackColor = true;
			this.btnCommandesRevuesRechercher.Click += new System.EventHandler(this.btnCommandesRevuesRechercher_Click);
			// 
			// dgvCommandesRevues
			// 
			this.dgvCommandesRevues.AllowUserToAddRows = false;
			this.dgvCommandesRevues.AllowUserToDeleteRows = false;
			this.dgvCommandesRevues.AllowUserToResizeColumns = false;
			this.dgvCommandesRevues.AllowUserToResizeRows = false;
			this.dgvCommandesRevues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCommandesRevues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCommandesRevuesDateCommande,
            this.colCommandesRevuesMontant,
            this.colCommandesRevuesDateFinAbonnement});
			this.dgvCommandesRevues.Location = new System.Drawing.Point(9, 150);
			this.dgvCommandesRevues.MultiSelect = false;
			this.dgvCommandesRevues.Name = "dgvCommandesRevues";
			this.dgvCommandesRevues.ReadOnly = true;
			this.dgvCommandesRevues.RowHeadersVisible = false;
			this.dgvCommandesRevues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCommandesRevues.Size = new System.Drawing.Size(844, 185);
			this.dgvCommandesRevues.TabIndex = 10;
			this.dgvCommandesRevues.SelectionChanged += new System.EventHandler(this.dgvCommandesRevues_SelectionChanged);
			this.dgvCommandesRevues.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCommandesRevues_ColumnHeaderMouseClick);
			// 
			// colCommandesRevuesDateCommande
			// 
			this.colCommandesRevuesDateCommande.DataPropertyName = "DateCommande";
			this.colCommandesRevuesDateCommande.HeaderText = "DateCommande";
			this.colCommandesRevuesDateCommande.Name = "colCommandesRevuesDateCommande";
			this.colCommandesRevuesDateCommande.ReadOnly = true;
			this.colCommandesRevuesDateCommande.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// colCommandesRevuesMontant
			// 
			this.colCommandesRevuesMontant.DataPropertyName = "Montant";
			this.colCommandesRevuesMontant.HeaderText = "Montant";
			this.colCommandesRevuesMontant.Name = "colCommandesRevuesMontant";
			this.colCommandesRevuesMontant.ReadOnly = true;
			this.colCommandesRevuesMontant.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// colCommandesRevuesDateFinAbonnement
			// 
			this.colCommandesRevuesDateFinAbonnement.DataPropertyName = "DateFinAbonnement";
			this.colCommandesRevuesDateFinAbonnement.HeaderText = "DateFinAbonnement";
			this.colCommandesRevuesDateFinAbonnement.Name = "colCommandesRevuesDateFinAbonnement";
			this.colCommandesRevuesDateFinAbonnement.ReadOnly = true;
			this.colCommandesRevuesDateFinAbonnement.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// txbCommandesRevuesRayon
			// 
			this.txbCommandesRevuesRayon.Location = new System.Drawing.Point(150, 120);
			this.txbCommandesRevuesRayon.Name = "txbCommandesRevuesRayon";
			this.txbCommandesRevuesRayon.ReadOnly = true;
			this.txbCommandesRevuesRayon.Size = new System.Drawing.Size(207, 20);
			this.txbCommandesRevuesRayon.TabIndex = 9;
			// 
			// txbCommandesRevuesPublic
			// 
			this.txbCommandesRevuesPublic.Location = new System.Drawing.Point(150, 95);
			this.txbCommandesRevuesPublic.Name = "txbCommandesRevuesPublic";
			this.txbCommandesRevuesPublic.ReadOnly = true;
			this.txbCommandesRevuesPublic.Size = new System.Drawing.Size(207, 20);
			this.txbCommandesRevuesPublic.TabIndex = 8;
			// 
			// txbCommandesRevuesGenre
			// 
			this.txbCommandesRevuesGenre.Location = new System.Drawing.Point(150, 70);
			this.txbCommandesRevuesGenre.Name = "txbCommandesRevuesGenre";
			this.txbCommandesRevuesGenre.ReadOnly = true;
			this.txbCommandesRevuesGenre.Size = new System.Drawing.Size(207, 20);
			this.txbCommandesRevuesGenre.TabIndex = 7;
			// 
			// txbCommandesRevuesTitre
			// 
			this.txbCommandesRevuesTitre.Location = new System.Drawing.Point(150, 45);
			this.txbCommandesRevuesTitre.Name = "txbCommandesRevuesTitre";
			this.txbCommandesRevuesTitre.ReadOnly = true;
			this.txbCommandesRevuesTitre.Size = new System.Drawing.Size(391, 20);
			this.txbCommandesRevuesTitre.TabIndex = 6;
			// 
			// txbCommandesRevuesNumero
			// 
			this.txbCommandesRevuesNumero.Location = new System.Drawing.Point(150, 20);
			this.txbCommandesRevuesNumero.Name = "txbCommandesRevuesNumero";
			this.txbCommandesRevuesNumero.Size = new System.Drawing.Size(100, 20);
			this.txbCommandesRevuesNumero.TabIndex = 5;
			this.txbCommandesRevuesNumero.TextChanged += new System.EventHandler(this.txbCommandesRevuesNumero_TextChanged);
			// 
			// labelCommandesRevuesRayon
			// 
			this.labelCommandesRevuesRayon.AutoSize = true;
			this.labelCommandesRevuesRayon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCommandesRevuesRayon.Location = new System.Drawing.Point(6, 123);
			this.labelCommandesRevuesRayon.Name = "labelCommandesRevuesRayon";
			this.labelCommandesRevuesRayon.Size = new System.Drawing.Size(51, 13);
			this.labelCommandesRevuesRayon.TabIndex = 4;
			this.labelCommandesRevuesRayon.Text = "Rayon :";
			// 
			// labelCommandesRevuesPublic
			// 
			this.labelCommandesRevuesPublic.AutoSize = true;
			this.labelCommandesRevuesPublic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCommandesRevuesPublic.Location = new System.Drawing.Point(6, 98);
			this.labelCommandesRevuesPublic.Name = "labelCommandesRevuesPublic";
			this.labelCommandesRevuesPublic.Size = new System.Drawing.Size(50, 13);
			this.labelCommandesRevuesPublic.TabIndex = 3;
			this.labelCommandesRevuesPublic.Text = "Public :";
			// 
			// labelCommandesRevuesGenre
			// 
			this.labelCommandesRevuesGenre.AutoSize = true;
			this.labelCommandesRevuesGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCommandesRevuesGenre.Location = new System.Drawing.Point(6, 73);
			this.labelCommandesRevuesGenre.Name = "labelCommandesRevuesGenre";
			this.labelCommandesRevuesGenre.Size = new System.Drawing.Size(49, 13);
			this.labelCommandesRevuesGenre.TabIndex = 2;
			this.labelCommandesRevuesGenre.Text = "Genre :";
			// 
			// labelCommandesRevuesTitre
			// 
			this.labelCommandesRevuesTitre.AutoSize = true;
			this.labelCommandesRevuesTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCommandesRevuesTitre.Location = new System.Drawing.Point(6, 48);
			this.labelCommandesRevuesTitre.Name = "labelCommandesRevuesTitre";
			this.labelCommandesRevuesTitre.Size = new System.Drawing.Size(41, 13);
			this.labelCommandesRevuesTitre.TabIndex = 1;
			this.labelCommandesRevuesTitre.Text = "Titre :";
			// 
			// labelCommandesRevuesNumero
			// 
			this.labelCommandesRevuesNumero.AutoSize = true;
			this.labelCommandesRevuesNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCommandesRevuesNumero.Location = new System.Drawing.Point(6, 23);
			this.labelCommandesRevuesNumero.Name = "labelCommandesRevuesNumero";
			this.labelCommandesRevuesNumero.Size = new System.Drawing.Size(135, 13);
			this.labelCommandesRevuesNumero.TabIndex = 0;
			this.labelCommandesRevuesNumero.Text = "Saisir le numéro du document :";
			// 
			// grpCommandesDvdNouvelle
			// 
			this.grpCommandesDvdNouvelle.Controls.Add(this.btnAjouterCommandeDvd);
			this.grpCommandesDvdNouvelle.Controls.Add(this.txbCommandesDvdNbExemplaire);
			this.grpCommandesDvdNouvelle.Controls.Add(this.labelCommandesDvdNbExemplaire);
			this.grpCommandesDvdNouvelle.Controls.Add(this.txbCommandesDvdMontant);
			this.grpCommandesDvdNouvelle.Controls.Add(this.labelCommandesDvdMontant);
			this.grpCommandesDvdNouvelle.Controls.Add(this.dtpCommandesDvdDateCommande);
			this.grpCommandesDvdNouvelle.Controls.Add(this.labelCommandesDvdDateCommande);
			this.grpCommandesDvdNouvelle.Location = new System.Drawing.Point(8, 381);
			this.grpCommandesDvdNouvelle.Name = "grpCommandesDvdNouvelle";
			this.grpCommandesDvdNouvelle.Size = new System.Drawing.Size(859, 120);
			this.grpCommandesDvdNouvelle.TabIndex = 1;
			this.grpCommandesDvdNouvelle.TabStop = false;
			this.grpCommandesDvdNouvelle.Text = "Nouvelle commande";
			// 
			// btnAjouterCommandeDvd
			// 
			this.btnAjouterCommandeDvd.Location = new System.Drawing.Point(400, 70);
			this.btnAjouterCommandeDvd.Name = "btnAjouterCommandeDvd";
			this.btnAjouterCommandeDvd.Size = new System.Drawing.Size(100, 23);
			this.btnAjouterCommandeDvd.TabIndex = 6;
			this.btnAjouterCommandeDvd.Text = "Ajouter";
			this.btnAjouterCommandeDvd.UseVisualStyleBackColor = true;
			this.btnAjouterCommandeDvd.Click += new System.EventHandler(this.btnAjouterCommandeDvd_Click);
			// 
			// txbCommandesDvdNbExemplaire
			// 
			this.txbCommandesDvdNbExemplaire.Location = new System.Drawing.Point(150, 72);
			this.txbCommandesDvdNbExemplaire.Name = "txbCommandesDvdNbExemplaire";
			this.txbCommandesDvdNbExemplaire.Size = new System.Drawing.Size(100, 20);
			this.txbCommandesDvdNbExemplaire.TabIndex = 5;
			// 
			// labelCommandesDvdNbExemplaire
			// 
			this.labelCommandesDvdNbExemplaire.AutoSize = true;
			this.labelCommandesDvdNbExemplaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCommandesDvdNbExemplaire.Location = new System.Drawing.Point(6, 75);
			this.labelCommandesDvdNbExemplaire.Name = "labelCommandesDvdNbExemplaire";
			this.labelCommandesDvdNbExemplaire.Size = new System.Drawing.Size(120, 13);
			this.labelCommandesDvdNbExemplaire.TabIndex = 4;
			this.labelCommandesDvdNbExemplaire.Text = "Nb d\'exemplaires :";
			// 
			// txbCommandesDvdMontant
			// 
			this.txbCommandesDvdMontant.Location = new System.Drawing.Point(150, 47);
			this.txbCommandesDvdMontant.Name = "txbCommandesDvdMontant";
			this.txbCommandesDvdMontant.Size = new System.Drawing.Size(100, 20);
			this.txbCommandesDvdMontant.TabIndex = 3;
			// 
			// labelCommandesDvdMontant
			// 
			this.labelCommandesDvdMontant.AutoSize = true;
			this.labelCommandesDvdMontant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCommandesDvdMontant.Location = new System.Drawing.Point(6, 50);
			this.labelCommandesDvdMontant.Name = "labelCommandesDvdMontant";
			this.labelCommandesDvdMontant.Size = new System.Drawing.Size(64, 13);
			this.labelCommandesDvdMontant.TabIndex = 2;
			this.labelCommandesDvdMontant.Text = "Montant :";
			// 
			// dtpCommandesDvdDateCommande
			// 
			this.dtpCommandesDvdDateCommande.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpCommandesDvdDateCommande.Location = new System.Drawing.Point(150, 22);
			this.dtpCommandesDvdDateCommande.Name = "dtpCommandesDvdDateCommande";
			this.dtpCommandesDvdDateCommande.Size = new System.Drawing.Size(100, 20);
			this.dtpCommandesDvdDateCommande.TabIndex = 1;
			// 
			// labelCommandesDvdDateCommande
			// 
			this.labelCommandesDvdDateCommande.AutoSize = true;
			this.labelCommandesDvdDateCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCommandesDvdDateCommande.Location = new System.Drawing.Point(6, 25);
			this.labelCommandesDvdDateCommande.Name = "labelCommandesDvdDateCommande";
			this.labelCommandesDvdDateCommande.Size = new System.Drawing.Size(124, 13);
			this.labelCommandesDvdDateCommande.TabIndex = 0;
			this.labelCommandesDvdDateCommande.Text = "Date de commande :";
			// 
			// grpCommandesDvd
			// 
			this.grpCommandesDvd.Controls.Add(this.btnCommandesDvdSupprimer);
			this.grpCommandesDvd.Controls.Add(this.btnCommandesDvdModifierSuivi);
			this.grpCommandesDvd.Controls.Add(this.cmbCommandesDvdSuivi);
			this.grpCommandesDvd.Controls.Add(this.labelCommandesDvdSuivi);
			this.grpCommandesDvd.Controls.Add(this.btnCommandesDvdRechercher);
			this.grpCommandesDvd.Controls.Add(this.dgvCommandesDvd);
			this.grpCommandesDvd.Controls.Add(this.txbCommandesDvdRayon);
			this.grpCommandesDvd.Controls.Add(this.txbCommandesDvdPublic);
			this.grpCommandesDvd.Controls.Add(this.txbCommandesDvdGenre);
			this.grpCommandesDvd.Controls.Add(this.txbCommandesDvdTitre);
			this.grpCommandesDvd.Controls.Add(this.txbCommandesDvdNumero);
			this.grpCommandesDvd.Controls.Add(this.labelCommandesDvdRayon);
			this.grpCommandesDvd.Controls.Add(this.labelCommandesDvdPublic);
			this.grpCommandesDvd.Controls.Add(this.labelCommandesDvdGenre);
			this.grpCommandesDvd.Controls.Add(this.labelCommandesDvdTitre);
			this.grpCommandesDvd.Controls.Add(this.labelCommandesDvdNumero);
			this.grpCommandesDvd.Location = new System.Drawing.Point(8, 13);
			this.grpCommandesDvd.Name = "grpCommandesDvd";
			this.grpCommandesDvd.Size = new System.Drawing.Size(859, 362);
			this.grpCommandesDvd.TabIndex = 0;
			this.grpCommandesDvd.TabStop = false;
			this.grpCommandesDvd.Text = "Sélection du DVD";
			// 
			// dgvCommandesDvd
			// 
			this.dgvCommandesDvd.AllowUserToAddRows = false;
			this.dgvCommandesDvd.AllowUserToDeleteRows = false;
			this.dgvCommandesDvd.AllowUserToResizeColumns = false;
			this.dgvCommandesDvd.AllowUserToResizeRows = false;
			this.dgvCommandesDvd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCommandesDvd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDateCommandeDvd,
            this.colMontantDvd,
            this.colNbExemplaireDvd,
            this.colSuiviDvd});
			this.dgvCommandesDvd.Location = new System.Drawing.Point(9, 150);
			this.dgvCommandesDvd.MultiSelect = false;
			this.dgvCommandesDvd.Name = "dgvCommandesDvd";
			this.dgvCommandesDvd.ReadOnly = true;
			this.dgvCommandesDvd.RowHeadersVisible = false;
			this.dgvCommandesDvd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCommandesDvd.Size = new System.Drawing.Size(844, 185);
			this.dgvCommandesDvd.TabIndex = 10;
			this.dgvCommandesDvd.SelectionChanged += new System.EventHandler(this.dgvCommandesDvd_SelectionChanged);
			this.dgvCommandesDvd.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCommandesDvd_ColumnHeaderMouseClick);
			// 
			// colDateCommandeDvd
			// 
			this.colDateCommandeDvd.DataPropertyName = "DateCommande";
			this.colDateCommandeDvd.HeaderText = "DateCommande";
			this.colDateCommandeDvd.Name = "colDateCommandeDvd";
			this.colDateCommandeDvd.ReadOnly = true;
			this.colDateCommandeDvd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// colMontantDvd
			// 
			this.colMontantDvd.DataPropertyName = "Montant";
			this.colMontantDvd.HeaderText = "Montant";
			this.colMontantDvd.Name = "colMontantDvd";
			this.colMontantDvd.ReadOnly = true;
			this.colMontantDvd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// colNbExemplaireDvd
			// 
			this.colNbExemplaireDvd.DataPropertyName = "NbExemplaire";
			this.colNbExemplaireDvd.HeaderText = "NbExemplaire";
			this.colNbExemplaireDvd.Name = "colNbExemplaireDvd";
			this.colNbExemplaireDvd.ReadOnly = true;
			this.colNbExemplaireDvd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// colSuiviDvd
			// 
			this.colSuiviDvd.DataPropertyName = "Suivi";
			this.colSuiviDvd.HeaderText = "Suivi";
			this.colSuiviDvd.Name = "colSuiviDvd";
			this.colSuiviDvd.ReadOnly = true;
			this.colSuiviDvd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// labelCommandesDvdSuivi
			// 
			this.labelCommandesDvdSuivi.AutoSize = true;
			this.labelCommandesDvdSuivi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCommandesDvdSuivi.Location = new System.Drawing.Point(9, 343);
			this.labelCommandesDvdSuivi.Name = "labelCommandesDvdSuivi";
			this.labelCommandesDvdSuivi.Size = new System.Drawing.Size(90, 13);
			this.labelCommandesDvdSuivi.TabIndex = 11;
			this.labelCommandesDvdSuivi.Text = "Modifier suivi :";
			// 
			// cmbCommandesDvdSuivi
			// 
			this.cmbCommandesDvdSuivi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCommandesDvdSuivi.FormattingEnabled = true;
			this.cmbCommandesDvdSuivi.Location = new System.Drawing.Point(105, 340);
			this.cmbCommandesDvdSuivi.Name = "cmbCommandesDvdSuivi";
			this.cmbCommandesDvdSuivi.Size = new System.Drawing.Size(150, 21);
			this.cmbCommandesDvdSuivi.TabIndex = 12;
			// 
			// btnCommandesDvdModifierSuivi
			// 
			this.btnCommandesDvdModifierSuivi.Location = new System.Drawing.Point(270, 338);
			this.btnCommandesDvdModifierSuivi.Name = "btnCommandesDvdModifierSuivi";
			this.btnCommandesDvdModifierSuivi.Size = new System.Drawing.Size(100, 23);
			this.btnCommandesDvdModifierSuivi.TabIndex = 13;
			this.btnCommandesDvdModifierSuivi.Text = "Modifier suivi";
			this.btnCommandesDvdModifierSuivi.UseVisualStyleBackColor = true;
			this.btnCommandesDvdModifierSuivi.Click += new System.EventHandler(this.btnCommandesDvdModifierSuivi_Click);
			// 
			// btnCommandesDvdSupprimer
			// 
			this.btnCommandesDvdSupprimer.Location = new System.Drawing.Point(380, 338);
			this.btnCommandesDvdSupprimer.Name = "btnCommandesDvdSupprimer";
			this.btnCommandesDvdSupprimer.Size = new System.Drawing.Size(130, 23);
			this.btnCommandesDvdSupprimer.TabIndex = 14;
			this.btnCommandesDvdSupprimer.Text = "Supprimer commande";
			this.btnCommandesDvdSupprimer.UseVisualStyleBackColor = true;
			this.btnCommandesDvdSupprimer.Click += new System.EventHandler(this.btnCommandesDvdSupprimer_Click);
			// 
			// txbCommandesDvdRayon
			// 
			this.txbCommandesDvdRayon.Location = new System.Drawing.Point(150, 120);
			this.txbCommandesDvdRayon.Name = "txbCommandesDvdRayon";
			this.txbCommandesDvdRayon.ReadOnly = true;
			this.txbCommandesDvdRayon.Size = new System.Drawing.Size(207, 20);
			this.txbCommandesDvdRayon.TabIndex = 9;
			// 
			// txbCommandesDvdPublic
			// 
			this.txbCommandesDvdPublic.Location = new System.Drawing.Point(150, 95);
			this.txbCommandesDvdPublic.Name = "txbCommandesDvdPublic";
			this.txbCommandesDvdPublic.ReadOnly = true;
			this.txbCommandesDvdPublic.Size = new System.Drawing.Size(207, 20);
			this.txbCommandesDvdPublic.TabIndex = 8;
			// 
			// txbCommandesDvdGenre
			// 
			this.txbCommandesDvdGenre.Location = new System.Drawing.Point(150, 70);
			this.txbCommandesDvdGenre.Name = "txbCommandesDvdGenre";
			this.txbCommandesDvdGenre.ReadOnly = true;
			this.txbCommandesDvdGenre.Size = new System.Drawing.Size(207, 20);
			this.txbCommandesDvdGenre.TabIndex = 7;
			// 
			// txbCommandesDvdTitre
			// 
			this.txbCommandesDvdTitre.Location = new System.Drawing.Point(150, 45);
			this.txbCommandesDvdTitre.Name = "txbCommandesDvdTitre";
			this.txbCommandesDvdTitre.ReadOnly = true;
			this.txbCommandesDvdTitre.Size = new System.Drawing.Size(391, 20);
			this.txbCommandesDvdTitre.TabIndex = 6;
			// 
			// txbCommandesDvdNumero
			// 
			this.txbCommandesDvdNumero.Location = new System.Drawing.Point(150, 20);
			this.txbCommandesDvdNumero.Name = "txbCommandesDvdNumero";
			this.txbCommandesDvdNumero.Size = new System.Drawing.Size(100, 20);
			this.txbCommandesDvdNumero.TabIndex = 5;
			this.txbCommandesDvdNumero.TextChanged += new System.EventHandler(this.txbCommandesDvdNumero_TextChanged);
			// 
			// labelCommandesDvdRayon
			// 
			this.labelCommandesDvdRayon.AutoSize = true;
			this.labelCommandesDvdRayon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCommandesDvdRayon.Location = new System.Drawing.Point(6, 123);
			this.labelCommandesDvdRayon.Name = "labelCommandesDvdRayon";
			this.labelCommandesDvdRayon.Size = new System.Drawing.Size(51, 13);
			this.labelCommandesDvdRayon.TabIndex = 4;
			this.labelCommandesDvdRayon.Text = "Rayon :";
			// 
			// labelCommandesDvdPublic
			// 
			this.labelCommandesDvdPublic.AutoSize = true;
			this.labelCommandesDvdPublic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCommandesDvdPublic.Location = new System.Drawing.Point(6, 98);
			this.labelCommandesDvdPublic.Name = "labelCommandesDvdPublic";
			this.labelCommandesDvdPublic.Size = new System.Drawing.Size(50, 13);
			this.labelCommandesDvdPublic.TabIndex = 3;
			this.labelCommandesDvdPublic.Text = "Public :";
			// 
			// labelCommandesDvdGenre
			// 
			this.labelCommandesDvdGenre.AutoSize = true;
			this.labelCommandesDvdGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCommandesDvdGenre.Location = new System.Drawing.Point(6, 73);
			this.labelCommandesDvdGenre.Name = "labelCommandesDvdGenre";
			this.labelCommandesDvdGenre.Size = new System.Drawing.Size(49, 13);
			this.labelCommandesDvdGenre.TabIndex = 2;
			this.labelCommandesDvdGenre.Text = "Genre :";
			// 
			// labelCommandesDvdTitre
			// 
			this.labelCommandesDvdTitre.AutoSize = true;
			this.labelCommandesDvdTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCommandesDvdTitre.Location = new System.Drawing.Point(6, 48);
			this.labelCommandesDvdTitre.Name = "labelCommandesDvdTitre";
			this.labelCommandesDvdTitre.Size = new System.Drawing.Size(41, 13);
			this.labelCommandesDvdTitre.TabIndex = 1;
			this.labelCommandesDvdTitre.Text = "Titre :";
			// 
			// labelCommandesDvdNumero
			// 
			this.labelCommandesDvdNumero.AutoSize = true;
			this.labelCommandesDvdNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCommandesDvdNumero.Location = new System.Drawing.Point(6, 23);
			this.labelCommandesDvdNumero.Name = "labelCommandesDvdNumero";
			this.labelCommandesDvdNumero.Size = new System.Drawing.Size(135, 13);
			this.labelCommandesDvdNumero.TabIndex = 0;
			this.labelCommandesDvdNumero.Text = "Saisir le numéro du document :";
			// 
			// btnCommandesDvdRechercher
			// 
			this.btnCommandesDvdRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCommandesDvdRechercher.Location = new System.Drawing.Point(261, 19);
			this.btnCommandesDvdRechercher.Name = "btnCommandesDvdRechercher";
			this.btnCommandesDvdRechercher.Size = new System.Drawing.Size(96, 22);
			this.btnCommandesDvdRechercher.TabIndex = 11;
			this.btnCommandesDvdRechercher.Text = "Rechercher";
			this.btnCommandesDvdRechercher.UseVisualStyleBackColor = true;
			this.btnCommandesDvdRechercher.Click += new System.EventHandler(this.btnCommandesDvdRechercher_Click);
			// 
			// grpCommandesLivresNouvelle
			// 
			this.grpCommandesLivresNouvelle.Controls.Add(this.btnAjouterCommandeLivre);
			this.grpCommandesLivresNouvelle.Controls.Add(this.txbCommandesLivresNbExemplaire);
			this.grpCommandesLivresNouvelle.Controls.Add(this.labelCommandesLivresNbExemplaire);
			this.grpCommandesLivresNouvelle.Controls.Add(this.txbCommandesLivresMontant);
			this.grpCommandesLivresNouvelle.Controls.Add(this.labelCommandesLivresMontant);
			this.grpCommandesLivresNouvelle.Controls.Add(this.dtpCommandesLivresDateCommande);
			this.grpCommandesLivresNouvelle.Controls.Add(this.labelCommandesLivresDateCommande);
			this.grpCommandesLivresNouvelle.Location = new System.Drawing.Point(8, 381);
			this.grpCommandesLivresNouvelle.Name = "grpCommandesLivresNouvelle";
			this.grpCommandesLivresNouvelle.Size = new System.Drawing.Size(859, 120);
			this.grpCommandesLivresNouvelle.TabIndex = 1;
			this.grpCommandesLivresNouvelle.TabStop = false;
			this.grpCommandesLivresNouvelle.Text = "Nouvelle commande";
			// 
			// btnAjouterCommandeLivre
			// 
			this.btnAjouterCommandeLivre.Location = new System.Drawing.Point(400, 70);
			this.btnAjouterCommandeLivre.Name = "btnAjouterCommandeLivre";
			this.btnAjouterCommandeLivre.Size = new System.Drawing.Size(100, 23);
			this.btnAjouterCommandeLivre.TabIndex = 6;
			this.btnAjouterCommandeLivre.Text = "Ajouter";
			this.btnAjouterCommandeLivre.UseVisualStyleBackColor = true;
			this.btnAjouterCommandeLivre.Click += new System.EventHandler(this.btnAjouterCommandeLivre_Click);
			// 
			// txbCommandesLivresNbExemplaire
			// 
			this.txbCommandesLivresNbExemplaire.Location = new System.Drawing.Point(150, 72);
			this.txbCommandesLivresNbExemplaire.Name = "txbCommandesLivresNbExemplaire";
			this.txbCommandesLivresNbExemplaire.Size = new System.Drawing.Size(100, 20);
			this.txbCommandesLivresNbExemplaire.TabIndex = 5;
			// 
			// labelCommandesLivresNbExemplaire
			// 
			this.labelCommandesLivresNbExemplaire.AutoSize = true;
			this.labelCommandesLivresNbExemplaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCommandesLivresNbExemplaire.Location = new System.Drawing.Point(6, 75);
			this.labelCommandesLivresNbExemplaire.Name = "labelCommandesLivresNbExemplaire";
			this.labelCommandesLivresNbExemplaire.Size = new System.Drawing.Size(120, 13);
			this.labelCommandesLivresNbExemplaire.TabIndex = 4;
			this.labelCommandesLivresNbExemplaire.Text = "Nb d\'exemplaires :";
			// 
			// txbCommandesLivresMontant
			// 
			this.txbCommandesLivresMontant.Location = new System.Drawing.Point(150, 47);
			this.txbCommandesLivresMontant.Name = "txbCommandesLivresMontant";
			this.txbCommandesLivresMontant.Size = new System.Drawing.Size(100, 20);
			this.txbCommandesLivresMontant.TabIndex = 3;
			// 
			// labelCommandesLivresMontant
			// 
			this.labelCommandesLivresMontant.AutoSize = true;
			this.labelCommandesLivresMontant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCommandesLivresMontant.Location = new System.Drawing.Point(6, 50);
			this.labelCommandesLivresMontant.Name = "labelCommandesLivresMontant";
			this.labelCommandesLivresMontant.Size = new System.Drawing.Size(64, 13);
			this.labelCommandesLivresMontant.TabIndex = 2;
			this.labelCommandesLivresMontant.Text = "Montant :";
			// 
			// dtpCommandesLivresDateCommande
			// 
			this.dtpCommandesLivresDateCommande.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpCommandesLivresDateCommande.Location = new System.Drawing.Point(150, 22);
			this.dtpCommandesLivresDateCommande.Name = "dtpCommandesLivresDateCommande";
			this.dtpCommandesLivresDateCommande.Size = new System.Drawing.Size(100, 20);
			this.dtpCommandesLivresDateCommande.TabIndex = 1;
			// 
			// labelCommandesLivresDateCommande
			// 
			this.labelCommandesLivresDateCommande.AutoSize = true;
			this.labelCommandesLivresDateCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCommandesLivresDateCommande.Location = new System.Drawing.Point(6, 25);
			this.labelCommandesLivresDateCommande.Name = "labelCommandesLivresDateCommande";
			this.labelCommandesLivresDateCommande.Size = new System.Drawing.Size(124, 13);
			this.labelCommandesLivresDateCommande.TabIndex = 0;
			this.labelCommandesLivresDateCommande.Text = "Date de commande :";
			// 
			// grpCommandesLivres
			// 
			this.grpCommandesLivres.Controls.Add(this.btnSupprimerCommande);
			this.grpCommandesLivres.Controls.Add(this.btnModifierSuiviCommande);
			this.grpCommandesLivres.Controls.Add(this.cmbCommandesLivresSuivi);
			this.grpCommandesLivres.Controls.Add(this.labelCommandesLivresSuivi);
			this.grpCommandesLivres.Controls.Add(this.btnCommandesLivresRechercher);
			this.grpCommandesLivres.Controls.Add(this.dgvCommandesLivres);
			this.grpCommandesLivres.Controls.Add(this.txbCommandesLivresRayon);
			this.grpCommandesLivres.Controls.Add(this.txbCommandesLivresPublic);
			this.grpCommandesLivres.Controls.Add(this.txbCommandesLivresGenre);
			this.grpCommandesLivres.Controls.Add(this.txbCommandesLivresTitre);
			this.grpCommandesLivres.Controls.Add(this.txbCommandesLivresNumero);
			this.grpCommandesLivres.Controls.Add(this.labelCommandesLivresRayon);
			this.grpCommandesLivres.Controls.Add(this.labelCommandesLivresPublic);
			this.grpCommandesLivres.Controls.Add(this.labelCommandesLivresGenre);
			this.grpCommandesLivres.Controls.Add(this.labelCommandesLivresTitre);
			this.grpCommandesLivres.Controls.Add(this.labelCommandesLivresNumero);
			this.grpCommandesLivres.Location = new System.Drawing.Point(8, 13);
			this.grpCommandesLivres.Name = "grpCommandesLivres";
			this.grpCommandesLivres.Size = new System.Drawing.Size(859, 362);
			this.grpCommandesLivres.TabIndex = 0;
			this.grpCommandesLivres.TabStop = false;
			this.grpCommandesLivres.Text = "Sélection du livre";
			// 
			// dgvCommandesLivres
			// 
			this.dgvCommandesLivres.AllowUserToAddRows = false;
			this.dgvCommandesLivres.AllowUserToDeleteRows = false;
			this.dgvCommandesLivres.AllowUserToResizeColumns = false;
			this.dgvCommandesLivres.AllowUserToResizeRows = false;
			this.dgvCommandesLivres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCommandesLivres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDateCommande,
            this.colMontant,
            this.colNbExemplaire,
            this.colSuivi});
			this.dgvCommandesLivres.Location = new System.Drawing.Point(9, 150);
			this.dgvCommandesLivres.MultiSelect = false;
			this.dgvCommandesLivres.Name = "dgvCommandesLivres";
			this.dgvCommandesLivres.ReadOnly = true;
			this.dgvCommandesLivres.RowHeadersVisible = false;
			this.dgvCommandesLivres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCommandesLivres.Size = new System.Drawing.Size(844, 185);
			this.dgvCommandesLivres.TabIndex = 10;
			this.dgvCommandesLivres.SelectionChanged += new System.EventHandler(this.dgvCommandesLivres_SelectionChanged);
			this.dgvCommandesLivres.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCommandesLivres_ColumnHeaderMouseClick);
			// 
			// colDateCommande
			// 
			this.colDateCommande.DataPropertyName = "DateCommande";
			this.colDateCommande.HeaderText = "DateCommande";
			this.colDateCommande.Name = "colDateCommande";
			this.colDateCommande.ReadOnly = true;
			this.colDateCommande.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// colMontant
			// 
			this.colMontant.DataPropertyName = "Montant";
			this.colMontant.HeaderText = "Montant";
			this.colMontant.Name = "colMontant";
			this.colMontant.ReadOnly = true;
			this.colMontant.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// colNbExemplaire
			// 
			this.colNbExemplaire.DataPropertyName = "NbExemplaire";
			this.colNbExemplaire.HeaderText = "NbExemplaire";
			this.colNbExemplaire.Name = "colNbExemplaire";
			this.colNbExemplaire.ReadOnly = true;
			this.colNbExemplaire.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// colSuivi
			// 
			this.colSuivi.DataPropertyName = "Suivi";
			this.colSuivi.HeaderText = "Suivi";
			this.colSuivi.Name = "colSuivi";
			this.colSuivi.ReadOnly = true;
			this.colSuivi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// labelCommandesLivresSuivi
			// 
			this.labelCommandesLivresSuivi.AutoSize = true;
			this.labelCommandesLivresSuivi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCommandesLivresSuivi.Location = new System.Drawing.Point(9, 343);
			this.labelCommandesLivresSuivi.Name = "labelCommandesLivresSuivi";
			this.labelCommandesLivresSuivi.Size = new System.Drawing.Size(90, 13);
			this.labelCommandesLivresSuivi.TabIndex = 11;
			this.labelCommandesLivresSuivi.Text = "Modifier suivi :";
			// 
			// cmbCommandesLivresSuivi
			// 
			this.cmbCommandesLivresSuivi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCommandesLivresSuivi.FormattingEnabled = true;
			this.cmbCommandesLivresSuivi.Location = new System.Drawing.Point(105, 340);
			this.cmbCommandesLivresSuivi.Name = "cmbCommandesLivresSuivi";
			this.cmbCommandesLivresSuivi.Size = new System.Drawing.Size(150, 21);
			this.cmbCommandesLivresSuivi.TabIndex = 12;
			// 
			// btnModifierSuiviCommande
			// 
			this.btnModifierSuiviCommande.Location = new System.Drawing.Point(270, 338);
			this.btnModifierSuiviCommande.Name = "btnModifierSuiviCommande";
			this.btnModifierSuiviCommande.Size = new System.Drawing.Size(100, 23);
			this.btnModifierSuiviCommande.TabIndex = 13;
			this.btnModifierSuiviCommande.Text = "Modifier suivi";
			this.btnModifierSuiviCommande.UseVisualStyleBackColor = true;
			this.btnModifierSuiviCommande.Click += new System.EventHandler(this.btnModifierSuiviCommande_Click);
			// 
			// btnSupprimerCommande
			// 
			this.btnSupprimerCommande.Location = new System.Drawing.Point(380, 338);
			this.btnSupprimerCommande.Name = "btnSupprimerCommande";
			this.btnSupprimerCommande.Size = new System.Drawing.Size(130, 23);
			this.btnSupprimerCommande.TabIndex = 14;
			this.btnSupprimerCommande.Text = "Supprimer commande";
			this.btnSupprimerCommande.UseVisualStyleBackColor = true;
			this.btnSupprimerCommande.Click += new System.EventHandler(this.btnSupprimerCommande_Click);
			// 
			// txbCommandesLivresRayon
			// 
			this.txbCommandesLivresRayon.Location = new System.Drawing.Point(150, 120);
			this.txbCommandesLivresRayon.Name = "txbCommandesLivresRayon";
			this.txbCommandesLivresRayon.ReadOnly = true;
			this.txbCommandesLivresRayon.Size = new System.Drawing.Size(207, 20);
			this.txbCommandesLivresRayon.TabIndex = 9;
			// 
			// txbCommandesLivresPublic
			// 
			this.txbCommandesLivresPublic.Location = new System.Drawing.Point(150, 95);
			this.txbCommandesLivresPublic.Name = "txbCommandesLivresPublic";
			this.txbCommandesLivresPublic.ReadOnly = true;
			this.txbCommandesLivresPublic.Size = new System.Drawing.Size(207, 20);
			this.txbCommandesLivresPublic.TabIndex = 8;
			// 
			// txbCommandesLivresGenre
			// 
			this.txbCommandesLivresGenre.Location = new System.Drawing.Point(150, 70);
			this.txbCommandesLivresGenre.Name = "txbCommandesLivresGenre";
			this.txbCommandesLivresGenre.ReadOnly = true;
			this.txbCommandesLivresGenre.Size = new System.Drawing.Size(207, 20);
			this.txbCommandesLivresGenre.TabIndex = 7;
			// 
			// txbCommandesLivresTitre
			// 
			this.txbCommandesLivresTitre.Location = new System.Drawing.Point(150, 45);
			this.txbCommandesLivresTitre.Name = "txbCommandesLivresTitre";
			this.txbCommandesLivresTitre.ReadOnly = true;
			this.txbCommandesLivresTitre.Size = new System.Drawing.Size(391, 20);
			this.txbCommandesLivresTitre.TabIndex = 6;
			// 
			// txbCommandesLivresNumero
			// 
			this.txbCommandesLivresNumero.Location = new System.Drawing.Point(150, 20);
			this.txbCommandesLivresNumero.Name = "txbCommandesLivresNumero";
			this.txbCommandesLivresNumero.Size = new System.Drawing.Size(100, 20);
			this.txbCommandesLivresNumero.TabIndex = 5;
			this.txbCommandesLivresNumero.TextChanged += new System.EventHandler(this.txbCommandesLivresNumero_TextChanged);
			// 
			// labelCommandesLivresRayon
			// 
			this.labelCommandesLivresRayon.AutoSize = true;
			this.labelCommandesLivresRayon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCommandesLivresRayon.Location = new System.Drawing.Point(6, 123);
			this.labelCommandesLivresRayon.Name = "labelCommandesLivresRayon";
			this.labelCommandesLivresRayon.Size = new System.Drawing.Size(51, 13);
			this.labelCommandesLivresRayon.TabIndex = 4;
			this.labelCommandesLivresRayon.Text = "Rayon :";
			// 
			// labelCommandesLivresPublic
			// 
			this.labelCommandesLivresPublic.AutoSize = true;
			this.labelCommandesLivresPublic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCommandesLivresPublic.Location = new System.Drawing.Point(6, 98);
			this.labelCommandesLivresPublic.Name = "labelCommandesLivresPublic";
			this.labelCommandesLivresPublic.Size = new System.Drawing.Size(50, 13);
			this.labelCommandesLivresPublic.TabIndex = 3;
			this.labelCommandesLivresPublic.Text = "Public :";
			// 
			// labelCommandesLivresGenre
			// 
			this.labelCommandesLivresGenre.AutoSize = true;
			this.labelCommandesLivresGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCommandesLivresGenre.Location = new System.Drawing.Point(6, 73);
			this.labelCommandesLivresGenre.Name = "labelCommandesLivresGenre";
			this.labelCommandesLivresGenre.Size = new System.Drawing.Size(49, 13);
			this.labelCommandesLivresGenre.TabIndex = 2;
			this.labelCommandesLivresGenre.Text = "Genre :";
			// 
			// labelCommandesLivresTitre
			// 
			this.labelCommandesLivresTitre.AutoSize = true;
			this.labelCommandesLivresTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCommandesLivresTitre.Location = new System.Drawing.Point(6, 48);
			this.labelCommandesLivresTitre.Name = "labelCommandesLivresTitre";
			this.labelCommandesLivresTitre.Size = new System.Drawing.Size(41, 13);
			this.labelCommandesLivresTitre.TabIndex = 1;
			this.labelCommandesLivresTitre.Text = "Titre :";
			// 
			// labelCommandesLivresNumero
			// 
			this.labelCommandesLivresNumero.AutoSize = true;
			this.labelCommandesLivresNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCommandesLivresNumero.Location = new System.Drawing.Point(6, 23);
			this.labelCommandesLivresNumero.Name = "labelCommandesLivresNumero";
			this.labelCommandesLivresNumero.Size = new System.Drawing.Size(135, 13);
			this.labelCommandesLivresNumero.TabIndex = 0;
			this.labelCommandesLivresNumero.Text = "Saisir le numéro du document :";
			// 
			// btnCommandesLivresRechercher
			// 
			this.btnCommandesLivresRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCommandesLivresRechercher.Location = new System.Drawing.Point(261, 19);
			this.btnCommandesLivresRechercher.Name = "btnCommandesLivresRechercher";
			this.btnCommandesLivresRechercher.Size = new System.Drawing.Size(96, 22);
			this.btnCommandesLivresRechercher.TabIndex = 11;
			this.btnCommandesLivresRechercher.Text = "Rechercher";
			this.btnCommandesLivresRechercher.UseVisualStyleBackColor = true;
			this.btnCommandesLivresRechercher.Click += new System.EventHandler(this.btnCommandesLivresRechercher_Click);
			// 
			// grpLivresInfos
			// 
			this.grpLivresInfos.Controls.Add(this.label59);
			this.grpLivresInfos.Controls.Add(this.txbLivresIsbn);
			this.grpLivresInfos.Controls.Add(this.txbLivresImage);
			this.grpLivresInfos.Controls.Add(this.txbLivresRayon);
			this.grpLivresInfos.Controls.Add(this.txbLivresPublic);
			this.grpLivresInfos.Controls.Add(this.txbLivresGenre);
			this.grpLivresInfos.Controls.Add(this.txbLivresCollection);
			this.grpLivresInfos.Controls.Add(this.txbLivresAuteur);
			this.grpLivresInfos.Controls.Add(this.txbLivresTitre);
			this.grpLivresInfos.Controls.Add(this.txbLivresNumero);
			this.grpLivresInfos.Controls.Add(this.label22);
			this.grpLivresInfos.Controls.Add(this.pcbLivresImage);
			this.grpLivresInfos.Controls.Add(this.label19);
			this.grpLivresInfos.Controls.Add(this.label1);
			this.grpLivresInfos.Controls.Add(this.label10);
			this.grpLivresInfos.Controls.Add(this.label7);
			this.grpLivresInfos.Controls.Add(this.label11);
			this.grpLivresInfos.Controls.Add(this.label8);
			this.grpLivresInfos.Controls.Add(this.label12);
			this.grpLivresInfos.Controls.Add(this.label9);
			this.grpLivresInfos.Location = new System.Drawing.Point(8, 381);
			this.grpLivresInfos.Name = "grpLivresInfos";
			this.grpLivresInfos.Size = new System.Drawing.Size(859, 245);
			this.grpLivresInfos.TabIndex = 19;
			this.grpLivresInfos.TabStop = false;
			this.grpLivresInfos.Text = "Informations détaillées";
			// 
			// label59
			// 
			this.label59.AutoSize = true;
			this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label59.Location = new System.Drawing.Point(557, 11);
			this.label59.Name = "label59";
			this.label59.Size = new System.Drawing.Size(49, 13);
			this.label59.TabIndex = 33;
			this.label59.Text = "Image :";
			// 
			// txbLivresIsbn
			// 
			this.txbLivresIsbn.Location = new System.Drawing.Point(441, 20);
			this.txbLivresIsbn.Name = "txbLivresIsbn";
			this.txbLivresIsbn.ReadOnly = true;
			this.txbLivresIsbn.Size = new System.Drawing.Size(100, 20);
			this.txbLivresIsbn.TabIndex = 32;
			// 
			// txbLivresImage
			// 
			this.txbLivresImage.Location = new System.Drawing.Point(150, 195);
			this.txbLivresImage.Name = "txbLivresImage";
			this.txbLivresImage.ReadOnly = true;
			this.txbLivresImage.Size = new System.Drawing.Size(391, 20);
			this.txbLivresImage.TabIndex = 31;
			// 
			// txbLivresRayon
			// 
			this.txbLivresRayon.Location = new System.Drawing.Point(150, 170);
			this.txbLivresRayon.Name = "txbLivresRayon";
			this.txbLivresRayon.ReadOnly = true;
			this.txbLivresRayon.Size = new System.Drawing.Size(207, 20);
			this.txbLivresRayon.TabIndex = 30;
			// 
			// txbLivresPublic
			// 
			this.txbLivresPublic.Location = new System.Drawing.Point(150, 145);
			this.txbLivresPublic.Name = "txbLivresPublic";
			this.txbLivresPublic.ReadOnly = true;
			this.txbLivresPublic.Size = new System.Drawing.Size(207, 20);
			this.txbLivresPublic.TabIndex = 29;
			// 
			// txbLivresGenre
			// 
			this.txbLivresGenre.Location = new System.Drawing.Point(150, 120);
			this.txbLivresGenre.Name = "txbLivresGenre";
			this.txbLivresGenre.ReadOnly = true;
			this.txbLivresGenre.Size = new System.Drawing.Size(207, 20);
			this.txbLivresGenre.TabIndex = 28;
			// 
			// txbLivresCollection
			// 
			this.txbLivresCollection.Location = new System.Drawing.Point(150, 95);
			this.txbLivresCollection.Name = "txbLivresCollection";
			this.txbLivresCollection.ReadOnly = true;
			this.txbLivresCollection.Size = new System.Drawing.Size(391, 20);
			this.txbLivresCollection.TabIndex = 27;
			// 
			// txbLivresAuteur
			// 
			this.txbLivresAuteur.Location = new System.Drawing.Point(150, 70);
			this.txbLivresAuteur.Name = "txbLivresAuteur";
			this.txbLivresAuteur.ReadOnly = true;
			this.txbLivresAuteur.Size = new System.Drawing.Size(207, 20);
			this.txbLivresAuteur.TabIndex = 26;
			// 
			// txbLivresTitre
			// 
			this.txbLivresTitre.Location = new System.Drawing.Point(150, 45);
			this.txbLivresTitre.Name = "txbLivresTitre";
			this.txbLivresTitre.ReadOnly = true;
			this.txbLivresTitre.Size = new System.Drawing.Size(391, 20);
			this.txbLivresTitre.TabIndex = 25;
			// 
			// txbLivresNumero
			// 
			this.txbLivresNumero.Location = new System.Drawing.Point(150, 20);
			this.txbLivresNumero.Name = "txbLivresNumero";
			this.txbLivresNumero.ReadOnly = true;
			this.txbLivresNumero.Size = new System.Drawing.Size(100, 20);
			this.txbLivresNumero.TabIndex = 24;
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label22.Location = new System.Drawing.Point(6, 120);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(49, 13);
			this.label22.TabIndex = 22;
			this.label22.Text = "Genre :";
			// 
			// pcbLivresImage
			// 
			this.pcbLivresImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pcbLivresImage.Location = new System.Drawing.Point(560, 27);
			this.pcbLivresImage.Name = "pcbLivresImage";
			this.pcbLivresImage.Size = new System.Drawing.Size(284, 210);
			this.pcbLivresImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pcbLivresImage.TabIndex = 21;
			this.pcbLivresImage.TabStop = false;
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.Location = new System.Drawing.Point(6, 145);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(50, 13);
			this.label19.TabIndex = 19;
			this.label19.Text = "Public :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 170);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 13);
			this.label1.TabIndex = 17;
			this.label1.Text = "Rayon :";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(6, 45);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(41, 13);
			this.label10.TabIndex = 8;
			this.label10.Text = "Titre :";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(6, 20);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(135, 13);
			this.label7.TabIndex = 5;
			this.label7.Text = "Numéro de document :";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(6, 70);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(67, 13);
			this.label11.TabIndex = 9;
			this.label11.Text = "Auteur(e) :";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(6, 195);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(117, 13);
			this.label8.TabIndex = 6;
			this.label8.Text = "Chemin de l\'image :";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(6, 95);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(71, 13);
			this.label12.TabIndex = 10;
			this.label12.Text = "Collection :";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(357, 20);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(77, 13);
			this.label9.TabIndex = 7;
			this.label9.Text = "Code ISBN :";
			// 
			// grpLivresRecherche
			// 
			this.grpLivresRecherche.Controls.Add(this.btnSupprimerLivre);
			this.grpLivresRecherche.Controls.Add(this.btnModifierLivre);
			this.grpLivresRecherche.Controls.Add(this.btnAjouterLivre);
			this.grpLivresRecherche.Controls.Add(this.btnLivresAnnulRayons);
			this.grpLivresRecherche.Controls.Add(this.btnlivresAnnulPublics);
			this.grpLivresRecherche.Controls.Add(this.btnLivresNumRecherche);
			this.grpLivresRecherche.Controls.Add(this.label5);
			this.grpLivresRecherche.Controls.Add(this.txbLivresNumRecherche);
			this.grpLivresRecherche.Controls.Add(this.btnLivresAnnulGenres);
			this.grpLivresRecherche.Controls.Add(this.cbxLivresRayons);
			this.grpLivresRecherche.Controls.Add(this.label21);
			this.grpLivresRecherche.Controls.Add(this.cbxLivresPublics);
			this.grpLivresRecherche.Controls.Add(this.label20);
			this.grpLivresRecherche.Controls.Add(this.cbxLivresGenres);
			this.grpLivresRecherche.Controls.Add(this.label14);
			this.grpLivresRecherche.Controls.Add(this.dgvLivresListe);
			this.grpLivresRecherche.Controls.Add(this.label6);
			this.grpLivresRecherche.Controls.Add(this.txbLivresTitreRecherche);
			this.grpLivresRecherche.Location = new System.Drawing.Point(8, 13);
			this.grpLivresRecherche.Name = "grpLivresRecherche";
			this.grpLivresRecherche.Size = new System.Drawing.Size(859, 362);
			this.grpLivresRecherche.TabIndex = 18;
			this.grpLivresRecherche.TabStop = false;
			this.grpLivresRecherche.Text = "Recherches";
			// 
			// btnSupprimerLivre
			// 
			this.btnSupprimerLivre.Location = new System.Drawing.Point(231, 108);
			this.btnSupprimerLivre.Name = "btnSupprimerLivre";
			this.btnSupprimerLivre.Size = new System.Drawing.Size(75, 23);
			this.btnSupprimerLivre.TabIndex = 19;
			this.btnSupprimerLivre.Text = "Supprimer";
			this.btnSupprimerLivre.UseVisualStyleBackColor = true;
			this.btnSupprimerLivre.Click += new System.EventHandler(this.btnSupprimerLivre_Click);
			// 
			// btnModifierLivre
			// 
			this.btnModifierLivre.Enabled = false;
			this.btnModifierLivre.Location = new System.Drawing.Point(150, 108);
			this.btnModifierLivre.Name = "btnModifierLivre";
			this.btnModifierLivre.Size = new System.Drawing.Size(75, 23);
			this.btnModifierLivre.TabIndex = 18;
			this.btnModifierLivre.Text = "Modifier";
			this.btnModifierLivre.UseVisualStyleBackColor = true;
			this.btnModifierLivre.Click += new System.EventHandler(this.btnModifierLivre_Click);
			// 
			// btnAjouterLivre
			// 
			this.btnAjouterLivre.Location = new System.Drawing.Point(69, 108);
			this.btnAjouterLivre.Name = "btnAjouterLivre";
			this.btnAjouterLivre.Size = new System.Drawing.Size(75, 23);
			this.btnAjouterLivre.TabIndex = 17;
			this.btnAjouterLivre.Text = "Ajouter";
			this.btnAjouterLivre.UseVisualStyleBackColor = true;
			this.btnAjouterLivre.Click += new System.EventHandler(this.btnAjouterLivre_Click);
			// 
			// btnLivresAnnulRayons
			// 
			this.btnLivresAnnulRayons.Location = new System.Drawing.Point(833, 104);
			this.btnLivresAnnulRayons.Name = "btnLivresAnnulRayons";
			this.btnLivresAnnulRayons.Size = new System.Drawing.Size(22, 22);
			this.btnLivresAnnulRayons.TabIndex = 16;
			this.btnLivresAnnulRayons.Text = "X";
			this.btnLivresAnnulRayons.UseVisualStyleBackColor = true;
			this.btnLivresAnnulRayons.Click += new System.EventHandler(this.BtnLivresAnnulRayons_Click);
			// 
			// btnlivresAnnulPublics
			// 
			this.btnlivresAnnulPublics.Location = new System.Drawing.Point(833, 60);
			this.btnlivresAnnulPublics.Name = "btnlivresAnnulPublics";
			this.btnlivresAnnulPublics.Size = new System.Drawing.Size(22, 22);
			this.btnlivresAnnulPublics.TabIndex = 15;
			this.btnlivresAnnulPublics.Text = "X";
			this.btnlivresAnnulPublics.UseVisualStyleBackColor = true;
			this.btnlivresAnnulPublics.Click += new System.EventHandler(this.BtnLivresAnnulPublics_Click);
			// 
			// btnLivresNumRecherche
			// 
			this.btnLivresNumRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLivresNumRecherche.Location = new System.Drawing.Point(314, 59);
			this.btnLivresNumRecherche.Name = "btnLivresNumRecherche";
			this.btnLivresNumRecherche.Size = new System.Drawing.Size(96, 22);
			this.btnLivresNumRecherche.TabIndex = 14;
			this.btnLivresNumRecherche.Text = "Rechercher";
			this.btnLivresNumRecherche.UseVisualStyleBackColor = true;
			this.btnLivresNumRecherche.Click += new System.EventHandler(this.BtnLivresNumRecherche_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(6, 63);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(186, 13);
			this.label5.TabIndex = 13;
			this.label5.Text = "Saisir un numéro de document :";
			// 
			// txbLivresNumRecherche
			// 
			this.txbLivresNumRecherche.Location = new System.Drawing.Point(220, 60);
			this.txbLivresNumRecherche.Name = "txbLivresNumRecherche";
			this.txbLivresNumRecherche.Size = new System.Drawing.Size(67, 20);
			this.txbLivresNumRecherche.TabIndex = 12;
			// 
			// btnLivresAnnulGenres
			// 
			this.btnLivresAnnulGenres.Location = new System.Drawing.Point(833, 17);
			this.btnLivresAnnulGenres.Name = "btnLivresAnnulGenres";
			this.btnLivresAnnulGenres.Size = new System.Drawing.Size(22, 22);
			this.btnLivresAnnulGenres.TabIndex = 11;
			this.btnLivresAnnulGenres.Text = "X";
			this.btnLivresAnnulGenres.UseVisualStyleBackColor = true;
			this.btnLivresAnnulGenres.Click += new System.EventHandler(this.BtnLivresAnnulGenres_Click);
			// 
			// cbxLivresRayons
			// 
			this.cbxLivresRayons.FormattingEnabled = true;
			this.cbxLivresRayons.Location = new System.Drawing.Point(620, 105);
			this.cbxLivresRayons.Name = "cbxLivresRayons";
			this.cbxLivresRayons.Size = new System.Drawing.Size(207, 21);
			this.cbxLivresRayons.TabIndex = 10;
			this.cbxLivresRayons.SelectedIndexChanged += new System.EventHandler(this.CbxLivresRayons_SelectedIndexChanged);
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label21.Location = new System.Drawing.Point(458, 108);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(153, 13);
			this.label21.TabIndex = 9;
			this.label21.Text = "Ou sélectionner le rayon :";
			// 
			// cbxLivresPublics
			// 
			this.cbxLivresPublics.FormattingEnabled = true;
			this.cbxLivresPublics.Location = new System.Drawing.Point(620, 60);
			this.cbxLivresPublics.Name = "cbxLivresPublics";
			this.cbxLivresPublics.Size = new System.Drawing.Size(207, 21);
			this.cbxLivresPublics.TabIndex = 8;
			this.cbxLivresPublics.SelectedIndexChanged += new System.EventHandler(this.CbxLivresPublics_SelectedIndexChanged);
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label20.Location = new System.Drawing.Point(458, 63);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(156, 13);
			this.label20.TabIndex = 7;
			this.label20.Text = "Ou sélectionner le public :";
			// 
			// cbxLivresGenres
			// 
			this.cbxLivresGenres.FormattingEnabled = true;
			this.cbxLivresGenres.Location = new System.Drawing.Point(620, 18);
			this.cbxLivresGenres.Name = "cbxLivresGenres";
			this.cbxLivresGenres.Size = new System.Drawing.Size(207, 21);
			this.cbxLivresGenres.TabIndex = 6;
			this.cbxLivresGenres.SelectedIndexChanged += new System.EventHandler(this.CbxLivresGenres_SelectedIndexChanged);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(460, 21);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(154, 13);
			this.label14.TabIndex = 5;
			this.label14.Text = "Ou sélectionner le genre :";
			// 
			// dgvLivresListe
			// 
			this.dgvLivresListe.AllowUserToAddRows = false;
			this.dgvLivresListe.AllowUserToDeleteRows = false;
			this.dgvLivresListe.AllowUserToResizeColumns = false;
			this.dgvLivresListe.AllowUserToResizeRows = false;
			this.dgvLivresListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLivresListe.Location = new System.Drawing.Point(9, 150);
			this.dgvLivresListe.MultiSelect = false;
			this.dgvLivresListe.Name = "dgvLivresListe";
			this.dgvLivresListe.ReadOnly = true;
			this.dgvLivresListe.RowHeadersVisible = false;
			this.dgvLivresListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvLivresListe.Size = new System.Drawing.Size(844, 200);
			this.dgvLivresListe.TabIndex = 4;
			this.dgvLivresListe.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvLivresListe_ColumnHeaderMouseClick);
			this.dgvLivresListe.SelectionChanged += new System.EventHandler(this.DgvLivresListe_SelectionChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(6, 21);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(208, 13);
			this.label6.TabIndex = 2;
			this.label6.Text = "Saisir le titre ou la partie d\'un titre :";
			// 
			// txbLivresTitreRecherche
			// 
			this.txbLivresTitreRecherche.Location = new System.Drawing.Point(220, 18);
			this.txbLivresTitreRecherche.Name = "txbLivresTitreRecherche";
			this.txbLivresTitreRecherche.Size = new System.Drawing.Size(190, 20);
			this.txbLivresTitreRecherche.TabIndex = 3;
			this.txbLivresTitreRecherche.TextChanged += new System.EventHandler(this.TxbLivresTitreRecherche_TextChanged);
			// 
			// grpLivresExemplaires
			// 
			this.grpLivresExemplaires.Controls.Add(this.btnLivresExemplaireSupprimer);
			this.grpLivresExemplaires.Controls.Add(this.btnLivresExemplaireModifierEtat);
			this.grpLivresExemplaires.Controls.Add(this.cbxLivresExemplaireEtat);
			this.grpLivresExemplaires.Controls.Add(this.labelLivresExemplaireEtat);
			this.grpLivresExemplaires.Controls.Add(this.dgvLivresExemplairesListe);
			this.grpLivresExemplaires.Location = new System.Drawing.Point(8, 632);
			this.grpLivresExemplaires.Name = "grpLivresExemplaires";
			this.grpLivresExemplaires.Size = new System.Drawing.Size(859, 194);
			this.grpLivresExemplaires.TabIndex = 20;
			this.grpLivresExemplaires.TabStop = false;
			this.grpLivresExemplaires.Text = "Exemplaires";
			// 
			//
			// btnLivresExemplaireSupprimer
			//
			this.btnLivresExemplaireSupprimer.Enabled = false;
			this.btnLivresExemplaireSupprimer.Location = new System.Drawing.Point(350, 162);
			this.btnLivresExemplaireSupprimer.Name = "btnLivresExemplaireSupprimer";
			this.btnLivresExemplaireSupprimer.Size = new System.Drawing.Size(75, 23);
			this.btnLivresExemplaireSupprimer.TabIndex = 4;
			this.btnLivresExemplaireSupprimer.Text = "Supprimer";
			this.btnLivresExemplaireSupprimer.UseVisualStyleBackColor = true;
			this.btnLivresExemplaireSupprimer.Click += new System.EventHandler(this.btnLivresExemplaireSupprimer_Click);
			//
			// btnLivresExemplaireModifierEtat
			// 
			this.btnLivresExemplaireModifierEtat.Enabled = false;
			this.btnLivresExemplaireModifierEtat.Location = new System.Drawing.Point(691, 162);
			this.btnLivresExemplaireModifierEtat.Name = "btnLivresExemplaireModifierEtat";
			this.btnLivresExemplaireModifierEtat.Size = new System.Drawing.Size(153, 23);
			this.btnLivresExemplaireModifierEtat.TabIndex = 3;
			this.btnLivresExemplaireModifierEtat.Text = "Modifier l'état";
			this.btnLivresExemplaireModifierEtat.UseVisualStyleBackColor = true;
			this.btnLivresExemplaireModifierEtat.Click += new System.EventHandler(this.btnLivresExemplaireModifierEtat_Click);
			// 
			// cbxLivresExemplaireEtat
			// 
			this.cbxLivresExemplaireEtat.DisplayMember = "Libelle";
			this.cbxLivresExemplaireEtat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxLivresExemplaireEtat.Enabled = false;
			this.cbxLivresExemplaireEtat.FormattingEnabled = true;
			this.cbxLivresExemplaireEtat.Location = new System.Drawing.Point(485, 163);
			this.cbxLivresExemplaireEtat.Name = "cbxLivresExemplaireEtat";
			this.cbxLivresExemplaireEtat.Size = new System.Drawing.Size(200, 21);
			this.cbxLivresExemplaireEtat.TabIndex = 2;
			this.cbxLivresExemplaireEtat.ValueMember = "Id";
			// 
			// labelLivresExemplaireEtat
			// 
			this.labelLivresExemplaireEtat.AutoSize = true;
			this.labelLivresExemplaireEtat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelLivresExemplaireEtat.Location = new System.Drawing.Point(434, 167);
			this.labelLivresExemplaireEtat.Name = "labelLivresExemplaireEtat";
			this.labelLivresExemplaireEtat.Size = new System.Drawing.Size(39, 13);
			this.labelLivresExemplaireEtat.TabIndex = 1;
			this.labelLivresExemplaireEtat.Text = "Etat :";
			// 
			// dgvLivresExemplairesListe
			// 
			this.dgvLivresExemplairesListe.AllowUserToAddRows = false;
			this.dgvLivresExemplairesListe.AllowUserToDeleteRows = false;
			this.dgvLivresExemplairesListe.AllowUserToResizeColumns = false;
			this.dgvLivresExemplairesListe.AllowUserToResizeRows = false;
			this.dgvLivresExemplairesListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLivresExemplairesListe.Location = new System.Drawing.Point(9, 19);
			this.dgvLivresExemplairesListe.MultiSelect = false;
			this.dgvLivresExemplairesListe.Name = "dgvLivresExemplairesListe";
			this.dgvLivresExemplairesListe.ReadOnly = true;
			this.dgvLivresExemplairesListe.RowHeadersVisible = false;
			this.dgvLivresExemplairesListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvLivresExemplairesListe.Size = new System.Drawing.Size(844, 137);
			this.dgvLivresExemplairesListe.TabIndex = 0;
			this.dgvLivresExemplairesListe.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLivresExemplairesListe_ColumnHeaderMouseClick);
			this.dgvLivresExemplairesListe.SelectionChanged += new System.EventHandler(this.dgvLivresExemplairesListe_SelectionChanged);
			// 
			// tabDvd
			// 
			this.tabDvd.Controls.Add(this.grpDvdExemplaires);
			this.tabDvd.Controls.Add(this.grpDvdInfos);
			this.tabDvd.Controls.Add(this.grpDvdRecherche);
			this.tabDvd.Location = new System.Drawing.Point(4, 22);
			this.tabDvd.Name = "tabDvd";
			this.tabDvd.Size = new System.Drawing.Size(875, 834);
			this.tabDvd.TabIndex = 3;
			this.tabDvd.Text = "DVD";
			this.tabDvd.UseVisualStyleBackColor = true;
			this.tabDvd.Enter += new System.EventHandler(this.tabDvd_Enter);
			// 
			// grpDvdInfos
			// 
			this.grpDvdInfos.Controls.Add(this.label58);
			this.grpDvdInfos.Controls.Add(this.txbDvdDuree);
			this.grpDvdInfos.Controls.Add(this.txbDvdImage);
			this.grpDvdInfos.Controls.Add(this.txbDvdRayon);
			this.grpDvdInfos.Controls.Add(this.txbDvdPublic);
			this.grpDvdInfos.Controls.Add(this.txbDvdGenre);
			this.grpDvdInfos.Controls.Add(this.txbDvdSynopsis);
			this.grpDvdInfos.Controls.Add(this.txbDvdRealisateur);
			this.grpDvdInfos.Controls.Add(this.txbDvdTitre);
			this.grpDvdInfos.Controls.Add(this.txbDvdNumero);
			this.grpDvdInfos.Controls.Add(this.label23);
			this.grpDvdInfos.Controls.Add(this.pcbDvdImage);
			this.grpDvdInfos.Controls.Add(this.label24);
			this.grpDvdInfos.Controls.Add(this.label25);
			this.grpDvdInfos.Controls.Add(this.label26);
			this.grpDvdInfos.Controls.Add(this.label27);
			this.grpDvdInfos.Controls.Add(this.label28);
			this.grpDvdInfos.Controls.Add(this.label29);
			this.grpDvdInfos.Controls.Add(this.label30);
			this.grpDvdInfos.Controls.Add(this.label31);
			this.grpDvdInfos.Location = new System.Drawing.Point(8, 381);
			this.grpDvdInfos.Name = "grpDvdInfos";
			this.grpDvdInfos.Size = new System.Drawing.Size(859, 245);
			this.grpDvdInfos.TabIndex = 21;
			this.grpDvdInfos.TabStop = false;
			this.grpDvdInfos.Text = "Informations détaillées";
			// 
			// label58
			// 
			this.label58.AutoSize = true;
			this.label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label58.Location = new System.Drawing.Point(557, 11);
			this.label58.Name = "label58";
			this.label58.Size = new System.Drawing.Size(49, 13);
			this.label58.TabIndex = 33;
			this.label58.Text = "Image :";
			// 
			// txbDvdDuree
			// 
			this.txbDvdDuree.Location = new System.Drawing.Point(441, 20);
			this.txbDvdDuree.Name = "txbDvdDuree";
			this.txbDvdDuree.ReadOnly = true;
			this.txbDvdDuree.Size = new System.Drawing.Size(100, 20);
			this.txbDvdDuree.TabIndex = 32;
			// 
			// txbDvdImage
			// 
			this.txbDvdImage.Location = new System.Drawing.Point(150, 215);
			this.txbDvdImage.Name = "txbDvdImage";
			this.txbDvdImage.ReadOnly = true;
			this.txbDvdImage.Size = new System.Drawing.Size(391, 20);
			this.txbDvdImage.TabIndex = 31;
			// 
			// txbDvdRayon
			// 
			this.txbDvdRayon.Location = new System.Drawing.Point(150, 190);
			this.txbDvdRayon.Name = "txbDvdRayon";
			this.txbDvdRayon.ReadOnly = true;
			this.txbDvdRayon.Size = new System.Drawing.Size(207, 20);
			this.txbDvdRayon.TabIndex = 30;
			// 
			// txbDvdPublic
			// 
			this.txbDvdPublic.Location = new System.Drawing.Point(150, 165);
			this.txbDvdPublic.Name = "txbDvdPublic";
			this.txbDvdPublic.ReadOnly = true;
			this.txbDvdPublic.Size = new System.Drawing.Size(207, 20);
			this.txbDvdPublic.TabIndex = 29;
			// 
			// txbDvdGenre
			// 
			this.txbDvdGenre.Location = new System.Drawing.Point(150, 140);
			this.txbDvdGenre.Name = "txbDvdGenre";
			this.txbDvdGenre.ReadOnly = true;
			this.txbDvdGenre.Size = new System.Drawing.Size(207, 20);
			this.txbDvdGenre.TabIndex = 28;
			// 
			// txbDvdSynopsis
			// 
			this.txbDvdSynopsis.AcceptsReturn = true;
			this.txbDvdSynopsis.Location = new System.Drawing.Point(150, 95);
			this.txbDvdSynopsis.Multiline = true;
			this.txbDvdSynopsis.Name = "txbDvdSynopsis";
			this.txbDvdSynopsis.ReadOnly = true;
			this.txbDvdSynopsis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txbDvdSynopsis.Size = new System.Drawing.Size(391, 39);
			this.txbDvdSynopsis.TabIndex = 27;
			// 
			// txbDvdRealisateur
			// 
			this.txbDvdRealisateur.Location = new System.Drawing.Point(150, 70);
			this.txbDvdRealisateur.Name = "txbDvdRealisateur";
			this.txbDvdRealisateur.ReadOnly = true;
			this.txbDvdRealisateur.Size = new System.Drawing.Size(207, 20);
			this.txbDvdRealisateur.TabIndex = 26;
			// 
			// txbDvdTitre
			// 
			this.txbDvdTitre.Location = new System.Drawing.Point(150, 45);
			this.txbDvdTitre.Name = "txbDvdTitre";
			this.txbDvdTitre.ReadOnly = true;
			this.txbDvdTitre.Size = new System.Drawing.Size(391, 20);
			this.txbDvdTitre.TabIndex = 25;
			// 
			// txbDvdNumero
			// 
			this.txbDvdNumero.Location = new System.Drawing.Point(150, 20);
			this.txbDvdNumero.Name = "txbDvdNumero";
			this.txbDvdNumero.ReadOnly = true;
			this.txbDvdNumero.Size = new System.Drawing.Size(100, 20);
			this.txbDvdNumero.TabIndex = 24;
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label23.Location = new System.Drawing.Point(6, 140);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(49, 13);
			this.label23.TabIndex = 22;
			this.label23.Text = "Genre :";
			// 
			// pcbDvdImage
			// 
			this.pcbDvdImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pcbDvdImage.Location = new System.Drawing.Point(560, 27);
			this.pcbDvdImage.Name = "pcbDvdImage";
			this.pcbDvdImage.Size = new System.Drawing.Size(284, 210);
			this.pcbDvdImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pcbDvdImage.TabIndex = 21;
			this.pcbDvdImage.TabStop = false;
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label24.Location = new System.Drawing.Point(6, 165);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(50, 13);
			this.label24.TabIndex = 19;
			this.label24.Text = "Public :";
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label25.Location = new System.Drawing.Point(6, 190);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(51, 13);
			this.label25.TabIndex = 17;
			this.label25.Text = "Rayon :";
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label26.Location = new System.Drawing.Point(6, 45);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(41, 13);
			this.label26.TabIndex = 8;
			this.label26.Text = "Titre :";
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label27.Location = new System.Drawing.Point(6, 20);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(135, 13);
			this.label27.TabIndex = 5;
			this.label27.Text = "Numéro de document :";
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label28.Location = new System.Drawing.Point(6, 70);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(112, 13);
			this.label28.TabIndex = 9;
			this.label28.Text = "Réalisateur(trice) :";
			// 
			// label29
			// 
			this.label29.AutoSize = true;
			this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label29.Location = new System.Drawing.Point(6, 215);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(117, 13);
			this.label29.TabIndex = 6;
			this.label29.Text = "Chemin de l\'image :";
			// 
			// label30
			// 
			this.label30.AutoSize = true;
			this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label30.Location = new System.Drawing.Point(6, 95);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(65, 13);
			this.label30.TabIndex = 10;
			this.label30.Text = "Synopsis :";
			// 
			// label31
			// 
			this.label31.AutoSize = true;
			this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label31.Location = new System.Drawing.Point(357, 20);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(49, 13);
			this.label31.TabIndex = 7;
			this.label31.Text = "Durée :";
			// 
			// grpDvdRecherche
			// 
			this.grpDvdRecherche.Controls.Add(this.btnSupprimerDvd);
			this.grpDvdRecherche.Controls.Add(this.btnModifierDvd);
			this.grpDvdRecherche.Controls.Add(this.btnAjouterDvd);
			this.grpDvdRecherche.Controls.Add(this.btnDvdAnnulRayons);
			this.grpDvdRecherche.Controls.Add(this.btnDvdAnnulPublics);
			this.grpDvdRecherche.Controls.Add(this.btnDvdNumRecherche);
			this.grpDvdRecherche.Controls.Add(this.label38);
			this.grpDvdRecherche.Controls.Add(this.txbDvdNumRecherche);
			this.grpDvdRecherche.Controls.Add(this.btnDvdAnnulGenres);
			this.grpDvdRecherche.Controls.Add(this.cbxDvdRayons);
			this.grpDvdRecherche.Controls.Add(this.label39);
			this.grpDvdRecherche.Controls.Add(this.cbxDvdPublics);
			this.grpDvdRecherche.Controls.Add(this.label40);
			this.grpDvdRecherche.Controls.Add(this.cbxDvdGenres);
			this.grpDvdRecherche.Controls.Add(this.label41);
			this.grpDvdRecherche.Controls.Add(this.dgvDvdListe);
			this.grpDvdRecherche.Controls.Add(this.label42);
			this.grpDvdRecherche.Controls.Add(this.txbDvdTitreRecherche);
			this.grpDvdRecherche.Location = new System.Drawing.Point(8, 13);
			this.grpDvdRecherche.Name = "grpDvdRecherche";
			this.grpDvdRecherche.Size = new System.Drawing.Size(859, 362);
			this.grpDvdRecherche.TabIndex = 20;
			this.grpDvdRecherche.TabStop = false;
			this.grpDvdRecherche.Text = "Recherches";
			//
			// btnSupprimerDvd
			//
			this.btnSupprimerDvd.Enabled = false;
			this.btnSupprimerDvd.Location = new System.Drawing.Point(231, 108);
			this.btnSupprimerDvd.Name = "btnSupprimerDvd";
			this.btnSupprimerDvd.Size = new System.Drawing.Size(75, 23);
			this.btnSupprimerDvd.TabIndex = 19;
			this.btnSupprimerDvd.Text = "Supprimer";
			this.btnSupprimerDvd.UseVisualStyleBackColor = true;
			this.btnSupprimerDvd.Click += new System.EventHandler(this.btnSupprimerDvd_Click);
			//
			// btnModifierDvd
			//
			this.btnModifierDvd.Enabled = false;
			this.btnModifierDvd.Location = new System.Drawing.Point(150, 108);
			this.btnModifierDvd.Name = "btnModifierDvd";
			this.btnModifierDvd.Size = new System.Drawing.Size(75, 23);
			this.btnModifierDvd.TabIndex = 18;
			this.btnModifierDvd.Text = "Modifier";
			this.btnModifierDvd.UseVisualStyleBackColor = true;
			this.btnModifierDvd.Click += new System.EventHandler(this.btnModifierDvd_Click);
			// 
			// btnAjouterDvd
			// 
			this.btnAjouterDvd.Location = new System.Drawing.Point(69, 108);
			this.btnAjouterDvd.Name = "btnAjouterDvd";
			this.btnAjouterDvd.Size = new System.Drawing.Size(75, 23);
			this.btnAjouterDvd.TabIndex = 17;
			this.btnAjouterDvd.Text = "Ajouter";
			this.btnAjouterDvd.UseVisualStyleBackColor = true;
			this.btnAjouterDvd.Click += new System.EventHandler(this.btnAjouterDvd_Click);
			// 
			// btnDvdAnnulRayons
			// 
			this.btnDvdAnnulRayons.Location = new System.Drawing.Point(833, 104);
			this.btnDvdAnnulRayons.Name = "btnDvdAnnulRayons";
			this.btnDvdAnnulRayons.Size = new System.Drawing.Size(22, 22);
			this.btnDvdAnnulRayons.TabIndex = 16;
			this.btnDvdAnnulRayons.Text = "X";
			this.btnDvdAnnulRayons.UseVisualStyleBackColor = true;
			this.btnDvdAnnulRayons.Click += new System.EventHandler(this.btnDvdAnnulRayons_Click);
			// 
			// btnDvdAnnulPublics
			// 
			this.btnDvdAnnulPublics.Location = new System.Drawing.Point(833, 60);
			this.btnDvdAnnulPublics.Name = "btnDvdAnnulPublics";
			this.btnDvdAnnulPublics.Size = new System.Drawing.Size(22, 22);
			this.btnDvdAnnulPublics.TabIndex = 15;
			this.btnDvdAnnulPublics.Text = "X";
			this.btnDvdAnnulPublics.UseVisualStyleBackColor = true;
			this.btnDvdAnnulPublics.Click += new System.EventHandler(this.btnDvdAnnulPublics_Click);
			// 
			// btnDvdNumRecherche
			// 
			this.btnDvdNumRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDvdNumRecherche.Location = new System.Drawing.Point(314, 59);
			this.btnDvdNumRecherche.Name = "btnDvdNumRecherche";
			this.btnDvdNumRecherche.Size = new System.Drawing.Size(96, 22);
			this.btnDvdNumRecherche.TabIndex = 14;
			this.btnDvdNumRecherche.Text = "Rechercher";
			this.btnDvdNumRecherche.UseVisualStyleBackColor = true;
			this.btnDvdNumRecherche.Click += new System.EventHandler(this.btnDvdNumRecherche_Click);
			// 
			// label38
			// 
			this.label38.AutoSize = true;
			this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label38.Location = new System.Drawing.Point(6, 63);
			this.label38.Name = "label38";
			this.label38.Size = new System.Drawing.Size(186, 13);
			this.label38.TabIndex = 13;
			this.label38.Text = "Saisir un numéro de document :";
			// 
			// txbDvdNumRecherche
			// 
			this.txbDvdNumRecherche.Location = new System.Drawing.Point(220, 60);
			this.txbDvdNumRecherche.Name = "txbDvdNumRecherche";
			this.txbDvdNumRecherche.Size = new System.Drawing.Size(67, 20);
			this.txbDvdNumRecherche.TabIndex = 12;
			// 
			// btnDvdAnnulGenres
			// 
			this.btnDvdAnnulGenres.Location = new System.Drawing.Point(833, 17);
			this.btnDvdAnnulGenres.Name = "btnDvdAnnulGenres";
			this.btnDvdAnnulGenres.Size = new System.Drawing.Size(22, 22);
			this.btnDvdAnnulGenres.TabIndex = 11;
			this.btnDvdAnnulGenres.Text = "X";
			this.btnDvdAnnulGenres.UseVisualStyleBackColor = true;
			this.btnDvdAnnulGenres.Click += new System.EventHandler(this.btnDvdAnnulGenres_Click);
			// 
			// cbxDvdRayons
			// 
			this.cbxDvdRayons.FormattingEnabled = true;
			this.cbxDvdRayons.Location = new System.Drawing.Point(620, 105);
			this.cbxDvdRayons.Name = "cbxDvdRayons";
			this.cbxDvdRayons.Size = new System.Drawing.Size(207, 21);
			this.cbxDvdRayons.TabIndex = 10;
			this.cbxDvdRayons.SelectedIndexChanged += new System.EventHandler(this.cbxDvdRayons_SelectedIndexChanged);
			// 
			// label39
			// 
			this.label39.AutoSize = true;
			this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label39.Location = new System.Drawing.Point(458, 108);
			this.label39.Name = "label39";
			this.label39.Size = new System.Drawing.Size(153, 13);
			this.label39.TabIndex = 9;
			this.label39.Text = "Ou sélectionner le rayon :";
			// 
			// cbxDvdPublics
			// 
			this.cbxDvdPublics.FormattingEnabled = true;
			this.cbxDvdPublics.Location = new System.Drawing.Point(620, 60);
			this.cbxDvdPublics.Name = "cbxDvdPublics";
			this.cbxDvdPublics.Size = new System.Drawing.Size(207, 21);
			this.cbxDvdPublics.TabIndex = 8;
			this.cbxDvdPublics.SelectedIndexChanged += new System.EventHandler(this.cbxDvdPublics_SelectedIndexChanged);
			// 
			// label40
			// 
			this.label40.AutoSize = true;
			this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label40.Location = new System.Drawing.Point(458, 63);
			this.label40.Name = "label40";
			this.label40.Size = new System.Drawing.Size(156, 13);
			this.label40.TabIndex = 7;
			this.label40.Text = "Ou sélectionner le public :";
			// 
			// cbxDvdGenres
			// 
			this.cbxDvdGenres.FormattingEnabled = true;
			this.cbxDvdGenres.Location = new System.Drawing.Point(620, 18);
			this.cbxDvdGenres.Name = "cbxDvdGenres";
			this.cbxDvdGenres.Size = new System.Drawing.Size(207, 21);
			this.cbxDvdGenres.TabIndex = 6;
			this.cbxDvdGenres.SelectedIndexChanged += new System.EventHandler(this.cbxDvdGenres_SelectedIndexChanged);
			// 
			// label41
			// 
			this.label41.AutoSize = true;
			this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label41.Location = new System.Drawing.Point(460, 21);
			this.label41.Name = "label41";
			this.label41.Size = new System.Drawing.Size(154, 13);
			this.label41.TabIndex = 5;
			this.label41.Text = "Ou sélectionner le genre :";
			// 
			// dgvDvdListe
			// 
			this.dgvDvdListe.AllowUserToAddRows = false;
			this.dgvDvdListe.AllowUserToDeleteRows = false;
			this.dgvDvdListe.AllowUserToResizeColumns = false;
			this.dgvDvdListe.AllowUserToResizeRows = false;
			this.dgvDvdListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDvdListe.Location = new System.Drawing.Point(9, 150);
			this.dgvDvdListe.MultiSelect = false;
			this.dgvDvdListe.Name = "dgvDvdListe";
			this.dgvDvdListe.ReadOnly = true;
			this.dgvDvdListe.RowHeadersVisible = false;
			this.dgvDvdListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDvdListe.Size = new System.Drawing.Size(844, 200);
			this.dgvDvdListe.TabIndex = 4;
			this.dgvDvdListe.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDvdListe_ColumnHeaderMouseClick);
			this.dgvDvdListe.SelectionChanged += new System.EventHandler(this.dgvDvdListe_SelectionChanged);
			// 
			// label42
			// 
			this.label42.AutoSize = true;
			this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label42.Location = new System.Drawing.Point(6, 21);
			this.label42.Name = "label42";
			this.label42.Size = new System.Drawing.Size(208, 13);
			this.label42.TabIndex = 2;
			this.label42.Text = "Saisir le titre ou la partie d\'un titre :";
			// 
			// txbDvdTitreRecherche
			// 
			this.txbDvdTitreRecherche.Location = new System.Drawing.Point(220, 18);
			this.txbDvdTitreRecherche.Name = "txbDvdTitreRecherche";
			this.txbDvdTitreRecherche.Size = new System.Drawing.Size(190, 20);
			this.txbDvdTitreRecherche.TabIndex = 3;
			this.txbDvdTitreRecherche.TextChanged += new System.EventHandler(this.txbDvdTitreRecherche_TextChanged);
			// 
			// grpDvdExemplaires
			// 
			this.grpDvdExemplaires.Controls.Add(this.btnDvdExemplaireSupprimer);
			this.grpDvdExemplaires.Controls.Add(this.btnDvdExemplaireModifierEtat);
			this.grpDvdExemplaires.Controls.Add(this.cbxDvdExemplaireEtat);
			this.grpDvdExemplaires.Controls.Add(this.labelDvdExemplaireEtat);
			this.grpDvdExemplaires.Controls.Add(this.dgvDvdExemplairesListe);
			this.grpDvdExemplaires.Location = new System.Drawing.Point(8, 632);
			this.grpDvdExemplaires.Name = "grpDvdExemplaires";
			this.grpDvdExemplaires.Size = new System.Drawing.Size(859, 194);
			this.grpDvdExemplaires.TabIndex = 22;
			this.grpDvdExemplaires.TabStop = false;
			this.grpDvdExemplaires.Text = "Exemplaires";
			// 
			//
			// btnDvdExemplaireSupprimer
			//
			this.btnDvdExemplaireSupprimer.Enabled = false;
			this.btnDvdExemplaireSupprimer.Location = new System.Drawing.Point(350, 162);
			this.btnDvdExemplaireSupprimer.Name = "btnDvdExemplaireSupprimer";
			this.btnDvdExemplaireSupprimer.Size = new System.Drawing.Size(75, 23);
			this.btnDvdExemplaireSupprimer.TabIndex = 4;
			this.btnDvdExemplaireSupprimer.Text = "Supprimer";
			this.btnDvdExemplaireSupprimer.UseVisualStyleBackColor = true;
			this.btnDvdExemplaireSupprimer.Click += new System.EventHandler(this.btnDvdExemplaireSupprimer_Click);
			//
			// btnDvdExemplaireModifierEtat
			// 
			this.btnDvdExemplaireModifierEtat.Enabled = false;
			this.btnDvdExemplaireModifierEtat.Location = new System.Drawing.Point(691, 162);
			this.btnDvdExemplaireModifierEtat.Name = "btnDvdExemplaireModifierEtat";
			this.btnDvdExemplaireModifierEtat.Size = new System.Drawing.Size(153, 23);
			this.btnDvdExemplaireModifierEtat.TabIndex = 3;
			this.btnDvdExemplaireModifierEtat.Text = "Modifier l'état";
			this.btnDvdExemplaireModifierEtat.UseVisualStyleBackColor = true;
			this.btnDvdExemplaireModifierEtat.Click += new System.EventHandler(this.btnDvdExemplaireModifierEtat_Click);
			// 
			// cbxDvdExemplaireEtat
			// 
			this.cbxDvdExemplaireEtat.DisplayMember = "Libelle";
			this.cbxDvdExemplaireEtat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxDvdExemplaireEtat.Enabled = false;
			this.cbxDvdExemplaireEtat.FormattingEnabled = true;
			this.cbxDvdExemplaireEtat.Location = new System.Drawing.Point(485, 163);
			this.cbxDvdExemplaireEtat.Name = "cbxDvdExemplaireEtat";
			this.cbxDvdExemplaireEtat.Size = new System.Drawing.Size(200, 21);
			this.cbxDvdExemplaireEtat.TabIndex = 2;
			this.cbxDvdExemplaireEtat.ValueMember = "Id";
			// 
			// labelDvdExemplaireEtat
			// 
			this.labelDvdExemplaireEtat.AutoSize = true;
			this.labelDvdExemplaireEtat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDvdExemplaireEtat.Location = new System.Drawing.Point(434, 167);
			this.labelDvdExemplaireEtat.Name = "labelDvdExemplaireEtat";
			this.labelDvdExemplaireEtat.Size = new System.Drawing.Size(39, 13);
			this.labelDvdExemplaireEtat.TabIndex = 1;
			this.labelDvdExemplaireEtat.Text = "Etat :";
			// 
			// dgvDvdExemplairesListe
			// 
			this.dgvDvdExemplairesListe.AllowUserToAddRows = false;
			this.dgvDvdExemplairesListe.AllowUserToDeleteRows = false;
			this.dgvDvdExemplairesListe.AllowUserToResizeColumns = false;
			this.dgvDvdExemplairesListe.AllowUserToResizeRows = false;
			this.dgvDvdExemplairesListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDvdExemplairesListe.Location = new System.Drawing.Point(9, 19);
			this.dgvDvdExemplairesListe.MultiSelect = false;
			this.dgvDvdExemplairesListe.Name = "dgvDvdExemplairesListe";
			this.dgvDvdExemplairesListe.ReadOnly = true;
			this.dgvDvdExemplairesListe.RowHeadersVisible = false;
			this.dgvDvdExemplairesListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDvdExemplairesListe.Size = new System.Drawing.Size(844, 137);
			this.dgvDvdExemplairesListe.TabIndex = 0;
			this.dgvDvdExemplairesListe.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDvdExemplairesListe_ColumnHeaderMouseClick);
			this.dgvDvdExemplairesListe.SelectionChanged += new System.EventHandler(this.dgvDvdExemplairesListe_SelectionChanged);
			// 
			// tabRevues
			// 
			this.tabRevues.Controls.Add(this.grpRevuesInfos);
			this.tabRevues.Controls.Add(this.grpRevuesRecherche);
			this.tabRevues.Location = new System.Drawing.Point(4, 22);
			this.tabRevues.Name = "tabRevues";
			this.tabRevues.Padding = new System.Windows.Forms.Padding(3);
			this.tabRevues.Size = new System.Drawing.Size(875, 633);
			this.tabRevues.TabIndex = 1;
			this.tabRevues.Text = "Revues";
			this.tabRevues.UseVisualStyleBackColor = true;
			this.tabRevues.Enter += new System.EventHandler(this.tabRevues_Enter);
			// 
			// grpRevuesInfos
			// 
			this.grpRevuesInfos.Controls.Add(this.label57);
			this.grpRevuesInfos.Controls.Add(this.txbRevuesImage);
			this.grpRevuesInfos.Controls.Add(this.txbRevuesRayon);
			this.grpRevuesInfos.Controls.Add(this.txbRevuesPublic);
			this.grpRevuesInfos.Controls.Add(this.txbRevuesGenre);
			this.grpRevuesInfos.Controls.Add(this.txbRevuesDateMiseADispo);
			this.grpRevuesInfos.Controls.Add(this.txbRevuesPeriodicite);
			this.grpRevuesInfos.Controls.Add(this.txbRevuesTitre);
			this.grpRevuesInfos.Controls.Add(this.txbRevuesNumero);
			this.grpRevuesInfos.Controls.Add(this.label35);
			this.grpRevuesInfos.Controls.Add(this.pcbRevuesImage);
			this.grpRevuesInfos.Controls.Add(this.label36);
			this.grpRevuesInfos.Controls.Add(this.label37);
			this.grpRevuesInfos.Controls.Add(this.label43);
			this.grpRevuesInfos.Controls.Add(this.label44);
			this.grpRevuesInfos.Controls.Add(this.label45);
			this.grpRevuesInfos.Controls.Add(this.label46);
			this.grpRevuesInfos.Controls.Add(this.label47);
			this.grpRevuesInfos.Location = new System.Drawing.Point(8, 381);
			this.grpRevuesInfos.Name = "grpRevuesInfos";
			this.grpRevuesInfos.Size = new System.Drawing.Size(859, 245);
			this.grpRevuesInfos.TabIndex = 20;
			this.grpRevuesInfos.TabStop = false;
			this.grpRevuesInfos.Text = "Informations détaillées";
			// 
			// label57
			// 
			this.label57.AutoSize = true;
			this.label57.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label57.Location = new System.Drawing.Point(557, 11);
			this.label57.Name = "label57";
			this.label57.Size = new System.Drawing.Size(49, 13);
			this.label57.TabIndex = 32;
			this.label57.Text = "Image :";
			// 
			// txbRevuesImage
			// 
			this.txbRevuesImage.Location = new System.Drawing.Point(150, 195);
			this.txbRevuesImage.Name = "txbRevuesImage";
			this.txbRevuesImage.ReadOnly = true;
			this.txbRevuesImage.Size = new System.Drawing.Size(391, 20);
			this.txbRevuesImage.TabIndex = 31;
			// 
			// txbRevuesRayon
			// 
			this.txbRevuesRayon.Location = new System.Drawing.Point(150, 170);
			this.txbRevuesRayon.Name = "txbRevuesRayon";
			this.txbRevuesRayon.ReadOnly = true;
			this.txbRevuesRayon.Size = new System.Drawing.Size(207, 20);
			this.txbRevuesRayon.TabIndex = 30;
			// 
			// txbRevuesPublic
			// 
			this.txbRevuesPublic.Location = new System.Drawing.Point(150, 145);
			this.txbRevuesPublic.Name = "txbRevuesPublic";
			this.txbRevuesPublic.ReadOnly = true;
			this.txbRevuesPublic.Size = new System.Drawing.Size(207, 20);
			this.txbRevuesPublic.TabIndex = 29;
			// 
			// txbRevuesGenre
			// 
			this.txbRevuesGenre.Location = new System.Drawing.Point(150, 120);
			this.txbRevuesGenre.Name = "txbRevuesGenre";
			this.txbRevuesGenre.ReadOnly = true;
			this.txbRevuesGenre.Size = new System.Drawing.Size(207, 20);
			this.txbRevuesGenre.TabIndex = 28;
			// 
			// txbRevuesDateMiseADispo
			// 
			this.txbRevuesDateMiseADispo.Location = new System.Drawing.Point(150, 95);
			this.txbRevuesDateMiseADispo.Name = "txbRevuesDateMiseADispo";
			this.txbRevuesDateMiseADispo.ReadOnly = true;
			this.txbRevuesDateMiseADispo.Size = new System.Drawing.Size(100, 20);
			this.txbRevuesDateMiseADispo.TabIndex = 27;
			// 
			// txbRevuesPeriodicite
			// 
			this.txbRevuesPeriodicite.Location = new System.Drawing.Point(150, 70);
			this.txbRevuesPeriodicite.Name = "txbRevuesPeriodicite";
			this.txbRevuesPeriodicite.ReadOnly = true;
			this.txbRevuesPeriodicite.Size = new System.Drawing.Size(100, 20);
			this.txbRevuesPeriodicite.TabIndex = 26;
			// 
			// txbRevuesTitre
			// 
			this.txbRevuesTitre.Location = new System.Drawing.Point(150, 45);
			this.txbRevuesTitre.Name = "txbRevuesTitre";
			this.txbRevuesTitre.ReadOnly = true;
			this.txbRevuesTitre.Size = new System.Drawing.Size(391, 20);
			this.txbRevuesTitre.TabIndex = 25;
			// 
			// txbRevuesNumero
			// 
			this.txbRevuesNumero.Location = new System.Drawing.Point(150, 20);
			this.txbRevuesNumero.Name = "txbRevuesNumero";
			this.txbRevuesNumero.ReadOnly = true;
			this.txbRevuesNumero.Size = new System.Drawing.Size(100, 20);
			this.txbRevuesNumero.TabIndex = 24;
			// 
			// label35
			// 
			this.label35.AutoSize = true;
			this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label35.Location = new System.Drawing.Point(6, 120);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(49, 13);
			this.label35.TabIndex = 22;
			this.label35.Text = "Genre :";
			// 
			// pcbRevuesImage
			// 
			this.pcbRevuesImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pcbRevuesImage.Location = new System.Drawing.Point(560, 27);
			this.pcbRevuesImage.Name = "pcbRevuesImage";
			this.pcbRevuesImage.Size = new System.Drawing.Size(284, 210);
			this.pcbRevuesImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pcbRevuesImage.TabIndex = 21;
			this.pcbRevuesImage.TabStop = false;
			// 
			// label36
			// 
			this.label36.AutoSize = true;
			this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label36.Location = new System.Drawing.Point(6, 145);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(50, 13);
			this.label36.TabIndex = 19;
			this.label36.Text = "Public :";
			// 
			// label37
			// 
			this.label37.AutoSize = true;
			this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label37.Location = new System.Drawing.Point(6, 170);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(51, 13);
			this.label37.TabIndex = 17;
			this.label37.Text = "Rayon :";
			// 
			// label43
			// 
			this.label43.AutoSize = true;
			this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label43.Location = new System.Drawing.Point(6, 45);
			this.label43.Name = "label43";
			this.label43.Size = new System.Drawing.Size(41, 13);
			this.label43.TabIndex = 8;
			this.label43.Text = "Titre :";
			// 
			// label44
			// 
			this.label44.AutoSize = true;
			this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label44.Location = new System.Drawing.Point(6, 20);
			this.label44.Name = "label44";
			this.label44.Size = new System.Drawing.Size(135, 13);
			this.label44.TabIndex = 5;
			this.label44.Text = "Numéro de document :";
			// 
			// label45
			// 
			this.label45.AutoSize = true;
			this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label45.Location = new System.Drawing.Point(6, 70);
			this.label45.Name = "label45";
			this.label45.Size = new System.Drawing.Size(75, 13);
			this.label45.TabIndex = 9;
			this.label45.Text = "Périodicité :";
			// 
			// label46
			// 
			this.label46.AutoSize = true;
			this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label46.Location = new System.Drawing.Point(6, 195);
			this.label46.Name = "label46";
			this.label46.Size = new System.Drawing.Size(117, 13);
			this.label46.TabIndex = 6;
			this.label46.Text = "Chemin de l\'image :";
			// 
			// label47
			// 
			this.label47.AutoSize = true;
			this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label47.Location = new System.Drawing.Point(6, 95);
			this.label47.Name = "label47";
			this.label47.Size = new System.Drawing.Size(118, 13);
			this.label47.TabIndex = 10;
			this.label47.Text = "Délai mise à dispo :";
			// 
			// grpRevuesRecherche
			// 
			this.grpRevuesRecherche.Controls.Add(this.btnSupprimerRevue);
			this.grpRevuesRecherche.Controls.Add(this.btnModifierRevue);
			this.grpRevuesRecherche.Controls.Add(this.btnAjouterRevue);
			this.grpRevuesRecherche.Controls.Add(this.btnRevuesAnnulRayons);
			this.grpRevuesRecherche.Controls.Add(this.btnRevuesAnnulPublics);
			this.grpRevuesRecherche.Controls.Add(this.btnRevuesNumRecherche);
			this.grpRevuesRecherche.Controls.Add(this.label2);
			this.grpRevuesRecherche.Controls.Add(this.txbRevuesNumRecherche);
			this.grpRevuesRecherche.Controls.Add(this.btnRevuesAnnulGenres);
			this.grpRevuesRecherche.Controls.Add(this.cbxRevuesRayons);
			this.grpRevuesRecherche.Controls.Add(this.label4);
			this.grpRevuesRecherche.Controls.Add(this.cbxRevuesPublics);
			this.grpRevuesRecherche.Controls.Add(this.label32);
			this.grpRevuesRecherche.Controls.Add(this.cbxRevuesGenres);
			this.grpRevuesRecherche.Controls.Add(this.label33);
			this.grpRevuesRecherche.Controls.Add(this.dgvRevuesListe);
			this.grpRevuesRecherche.Controls.Add(this.label34);
			this.grpRevuesRecherche.Controls.Add(this.txbRevuesTitreRecherche);
			this.grpRevuesRecherche.Location = new System.Drawing.Point(8, 13);
			this.grpRevuesRecherche.Name = "grpRevuesRecherche";
			this.grpRevuesRecherche.Size = new System.Drawing.Size(859, 362);
			this.grpRevuesRecherche.TabIndex = 19;
			this.grpRevuesRecherche.TabStop = false;
			this.grpRevuesRecherche.Text = "Recherches";
			//
			// btnSupprimerRevue
			//
			this.btnSupprimerRevue.Enabled = false;
			this.btnSupprimerRevue.Location = new System.Drawing.Point(231, 108);
			this.btnSupprimerRevue.Name = "btnSupprimerRevue";
			this.btnSupprimerRevue.Size = new System.Drawing.Size(75, 23);
			this.btnSupprimerRevue.TabIndex = 19;
			this.btnSupprimerRevue.Text = "Supprimer";
			this.btnSupprimerRevue.UseVisualStyleBackColor = true;
			this.btnSupprimerRevue.Click += new System.EventHandler(this.btnSupprimerRevue_Click);
			//
			// btnModifierRevue
			//
			this.btnModifierRevue.Enabled = false;
			this.btnModifierRevue.Location = new System.Drawing.Point(150, 108);
			this.btnModifierRevue.Name = "btnModifierRevue";
			this.btnModifierRevue.Size = new System.Drawing.Size(75, 23);
			this.btnModifierRevue.TabIndex = 18;
			this.btnModifierRevue.Text = "Modifier";
			this.btnModifierRevue.UseVisualStyleBackColor = true;
			this.btnModifierRevue.Click += new System.EventHandler(this.btnModifierRevue_Click);
			//
			// btnAjouterRevue
			//
			this.btnAjouterRevue.Location = new System.Drawing.Point(69, 108);
			this.btnAjouterRevue.Name = "btnAjouterRevue";
			this.btnAjouterRevue.Size = new System.Drawing.Size(75, 23);
			this.btnAjouterRevue.TabIndex = 17;
			this.btnAjouterRevue.Text = "Ajouter";
			this.btnAjouterRevue.UseVisualStyleBackColor = true;
			this.btnAjouterRevue.Click += new System.EventHandler(this.btnAjouterRevue_Click);
			//
			// btnRevuesAnnulRayons
			//
			this.btnRevuesAnnulRayons.Location = new System.Drawing.Point(833, 104);
			this.btnRevuesAnnulRayons.Name = "btnRevuesAnnulRayons";
			this.btnRevuesAnnulRayons.Size = new System.Drawing.Size(22, 22);
			this.btnRevuesAnnulRayons.TabIndex = 16;
			this.btnRevuesAnnulRayons.Text = "X";
			this.btnRevuesAnnulRayons.UseVisualStyleBackColor = true;
			this.btnRevuesAnnulRayons.Click += new System.EventHandler(this.btnRevuesAnnulRayons_Click);
			// 
			// btnRevuesAnnulPublics
			// 
			this.btnRevuesAnnulPublics.Location = new System.Drawing.Point(833, 60);
			this.btnRevuesAnnulPublics.Name = "btnRevuesAnnulPublics";
			this.btnRevuesAnnulPublics.Size = new System.Drawing.Size(22, 22);
			this.btnRevuesAnnulPublics.TabIndex = 15;
			this.btnRevuesAnnulPublics.Text = "X";
			this.btnRevuesAnnulPublics.UseVisualStyleBackColor = true;
			this.btnRevuesAnnulPublics.Click += new System.EventHandler(this.btnRevuesAnnulPublics_Click);
			// 
			// btnRevuesNumRecherche
			// 
			this.btnRevuesNumRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRevuesNumRecherche.Location = new System.Drawing.Point(314, 59);
			this.btnRevuesNumRecherche.Name = "btnRevuesNumRecherche";
			this.btnRevuesNumRecherche.Size = new System.Drawing.Size(96, 22);
			this.btnRevuesNumRecherche.TabIndex = 14;
			this.btnRevuesNumRecherche.Text = "Rechercher";
			this.btnRevuesNumRecherche.UseVisualStyleBackColor = true;
			this.btnRevuesNumRecherche.Click += new System.EventHandler(this.btnRevuesNumRecherche_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(186, 13);
			this.label2.TabIndex = 13;
			this.label2.Text = "Saisir un numéro de document :";
			// 
			// txbRevuesNumRecherche
			// 
			this.txbRevuesNumRecherche.Location = new System.Drawing.Point(220, 60);
			this.txbRevuesNumRecherche.Name = "txbRevuesNumRecherche";
			this.txbRevuesNumRecherche.Size = new System.Drawing.Size(67, 20);
			this.txbRevuesNumRecherche.TabIndex = 12;
			// 
			// btnRevuesAnnulGenres
			// 
			this.btnRevuesAnnulGenres.Location = new System.Drawing.Point(833, 17);
			this.btnRevuesAnnulGenres.Name = "btnRevuesAnnulGenres";
			this.btnRevuesAnnulGenres.Size = new System.Drawing.Size(22, 22);
			this.btnRevuesAnnulGenres.TabIndex = 11;
			this.btnRevuesAnnulGenres.Text = "X";
			this.btnRevuesAnnulGenres.UseVisualStyleBackColor = true;
			this.btnRevuesAnnulGenres.Click += new System.EventHandler(this.btnRevuesAnnulGenres_Click);
			// 
			// cbxRevuesRayons
			// 
			this.cbxRevuesRayons.FormattingEnabled = true;
			this.cbxRevuesRayons.Location = new System.Drawing.Point(620, 105);
			this.cbxRevuesRayons.Name = "cbxRevuesRayons";
			this.cbxRevuesRayons.Size = new System.Drawing.Size(207, 21);
			this.cbxRevuesRayons.TabIndex = 10;
			this.cbxRevuesRayons.SelectedIndexChanged += new System.EventHandler(this.cbxRevuesRayons_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(458, 108);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(153, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Ou sélectionner le rayon :";
			// 
			// cbxRevuesPublics
			// 
			this.cbxRevuesPublics.FormattingEnabled = true;
			this.cbxRevuesPublics.Location = new System.Drawing.Point(620, 60);
			this.cbxRevuesPublics.Name = "cbxRevuesPublics";
			this.cbxRevuesPublics.Size = new System.Drawing.Size(207, 21);
			this.cbxRevuesPublics.TabIndex = 8;
			this.cbxRevuesPublics.SelectedIndexChanged += new System.EventHandler(this.cbxRevuesPublics_SelectedIndexChanged);
			// 
			// label32
			// 
			this.label32.AutoSize = true;
			this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label32.Location = new System.Drawing.Point(458, 63);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(156, 13);
			this.label32.TabIndex = 7;
			this.label32.Text = "Ou sélectionner le public :";
			// 
			// cbxRevuesGenres
			// 
			this.cbxRevuesGenres.FormattingEnabled = true;
			this.cbxRevuesGenres.Location = new System.Drawing.Point(620, 18);
			this.cbxRevuesGenres.Name = "cbxRevuesGenres";
			this.cbxRevuesGenres.Size = new System.Drawing.Size(207, 21);
			this.cbxRevuesGenres.TabIndex = 6;
			this.cbxRevuesGenres.SelectedIndexChanged += new System.EventHandler(this.cbxRevuesGenres_SelectedIndexChanged);
			// 
			// label33
			// 
			this.label33.AutoSize = true;
			this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label33.Location = new System.Drawing.Point(460, 21);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(154, 13);
			this.label33.TabIndex = 5;
			this.label33.Text = "Ou sélectionner le genre :";
			// 
			// dgvRevuesListe
			// 
			this.dgvRevuesListe.AllowUserToAddRows = false;
			this.dgvRevuesListe.AllowUserToDeleteRows = false;
			this.dgvRevuesListe.AllowUserToResizeColumns = false;
			this.dgvRevuesListe.AllowUserToResizeRows = false;
			this.dgvRevuesListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvRevuesListe.Location = new System.Drawing.Point(9, 150);
			this.dgvRevuesListe.MultiSelect = false;
			this.dgvRevuesListe.Name = "dgvRevuesListe";
			this.dgvRevuesListe.ReadOnly = true;
			this.dgvRevuesListe.RowHeadersVisible = false;
			this.dgvRevuesListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvRevuesListe.Size = new System.Drawing.Size(844, 200);
			this.dgvRevuesListe.TabIndex = 4;
			this.dgvRevuesListe.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRevuesListe_ColumnHeaderMouseClick);
			this.dgvRevuesListe.SelectionChanged += new System.EventHandler(this.dgvRevuesListe_SelectionChanged);
			// 
			// label34
			// 
			this.label34.AutoSize = true;
			this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label34.Location = new System.Drawing.Point(6, 21);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(208, 13);
			this.label34.TabIndex = 2;
			this.label34.Text = "Saisir le titre ou la partie d\'un titre :";
			// 
			// txbRevuesTitreRecherche
			// 
			this.txbRevuesTitreRecherche.Location = new System.Drawing.Point(220, 18);
			this.txbRevuesTitreRecherche.Name = "txbRevuesTitreRecherche";
			this.txbRevuesTitreRecherche.Size = new System.Drawing.Size(190, 20);
			this.txbRevuesTitreRecherche.TabIndex = 3;
			this.txbRevuesTitreRecherche.TextChanged += new System.EventHandler(this.txbRevuesTitreRecherche_TextChanged);
			// 
			// tabReceptionRevue
			// 
			this.tabReceptionRevue.Controls.Add(this.grpReceptionExemplaire);
			this.tabReceptionRevue.Controls.Add(this.grpReceptionRevue);
			this.tabReceptionRevue.Location = new System.Drawing.Point(4, 22);
			this.tabReceptionRevue.Name = "tabReceptionRevue";
			this.tabReceptionRevue.Size = new System.Drawing.Size(875, 633);
			this.tabReceptionRevue.TabIndex = 4;
			this.tabReceptionRevue.Text = "Parutions des revues";
			this.tabReceptionRevue.UseVisualStyleBackColor = true;
			this.tabReceptionRevue.Enter += new System.EventHandler(this.tabReceptionRevue_Enter);
			// 
			// grpReceptionExemplaire
			// 
			this.grpReceptionExemplaire.Controls.Add(this.label55);
			this.grpReceptionExemplaire.Controls.Add(this.btnReceptionExemplaireImage);
			this.grpReceptionExemplaire.Controls.Add(this.pcbReceptionExemplaireImage);
			this.grpReceptionExemplaire.Controls.Add(this.btnReceptionExemplaireValider);
			this.grpReceptionExemplaire.Controls.Add(this.txbReceptionExemplaireImage);
			this.grpReceptionExemplaire.Controls.Add(this.label18);
			this.grpReceptionExemplaire.Controls.Add(this.txbReceptionExemplaireNumero);
			this.grpReceptionExemplaire.Controls.Add(this.label17);
			this.grpReceptionExemplaire.Controls.Add(this.dtpReceptionExemplaireDate);
			this.grpReceptionExemplaire.Controls.Add(this.label16);
			this.grpReceptionExemplaire.Location = new System.Drawing.Point(8, 415);
			this.grpReceptionExemplaire.Name = "grpReceptionExemplaire";
			this.grpReceptionExemplaire.Size = new System.Drawing.Size(859, 244);
			this.grpReceptionExemplaire.TabIndex = 16;
			this.grpReceptionExemplaire.TabStop = false;
			this.grpReceptionExemplaire.Text = "Nouvelle parution réceptionnée pour cette revue";
			// 
			// label55
			// 
			this.label55.AutoSize = true;
			this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label55.Location = new System.Drawing.Point(557, 10);
			this.label55.Name = "label55";
			this.label55.Size = new System.Drawing.Size(113, 13);
			this.label55.TabIndex = 57;
			this.label55.Text = "Image exemplaire :";
			// 
			// btnReceptionExemplaireImage
			// 
			this.btnReceptionExemplaireImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReceptionExemplaireImage.Location = new System.Drawing.Point(446, 69);
			this.btnReceptionExemplaireImage.Name = "btnReceptionExemplaireImage";
			this.btnReceptionExemplaireImage.Size = new System.Drawing.Size(96, 22);
			this.btnReceptionExemplaireImage.TabIndex = 43;
			this.btnReceptionExemplaireImage.Text = "Rechercher";
			this.btnReceptionExemplaireImage.UseVisualStyleBackColor = true;
			this.btnReceptionExemplaireImage.Click += new System.EventHandler(this.btnReceptionExemplaireImage_Click);
			// 
			// pcbReceptionExemplaireImage
			// 
			this.pcbReceptionExemplaireImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pcbReceptionExemplaireImage.Location = new System.Drawing.Point(560, 26);
			this.pcbReceptionExemplaireImage.Name = "pcbReceptionExemplaireImage";
			this.pcbReceptionExemplaireImage.Size = new System.Drawing.Size(284, 210);
			this.pcbReceptionExemplaireImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pcbReceptionExemplaireImage.TabIndex = 42;
			this.pcbReceptionExemplaireImage.TabStop = false;
			// 
			// btnReceptionExemplaireValider
			// 
			this.btnReceptionExemplaireValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReceptionExemplaireValider.Location = new System.Drawing.Point(6, 95);
			this.btnReceptionExemplaireValider.Name = "btnReceptionExemplaireValider";
			this.btnReceptionExemplaireValider.Size = new System.Drawing.Size(535, 22);
			this.btnReceptionExemplaireValider.TabIndex = 17;
			this.btnReceptionExemplaireValider.Text = "Valider la réception";
			this.btnReceptionExemplaireValider.UseVisualStyleBackColor = true;
			this.btnReceptionExemplaireValider.Click += new System.EventHandler(this.btnReceptionExemplaireValider_Click);
			// 
			// txbReceptionExemplaireImage
			// 
			this.txbReceptionExemplaireImage.Location = new System.Drawing.Point(150, 70);
			this.txbReceptionExemplaireImage.Name = "txbReceptionExemplaireImage";
			this.txbReceptionExemplaireImage.ReadOnly = true;
			this.txbReceptionExemplaireImage.Size = new System.Drawing.Size(290, 20);
			this.txbReceptionExemplaireImage.TabIndex = 5;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.Location = new System.Drawing.Point(6, 70);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(127, 13);
			this.label18.TabIndex = 4;
			this.label18.Text = "Emplacement image :";
			// 
			// txbReceptionExemplaireNumero
			// 
			this.txbReceptionExemplaireNumero.Location = new System.Drawing.Point(150, 20);
			this.txbReceptionExemplaireNumero.Name = "txbReceptionExemplaireNumero";
			this.txbReceptionExemplaireNumero.Size = new System.Drawing.Size(100, 20);
			this.txbReceptionExemplaireNumero.TabIndex = 3;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(6, 45);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(110, 13);
			this.label17.TabIndex = 2;
			this.label17.Text = "Date de parution :";
			// 
			// dtpReceptionExemplaireDate
			// 
			this.dtpReceptionExemplaireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpReceptionExemplaireDate.Location = new System.Drawing.Point(150, 45);
			this.dtpReceptionExemplaireDate.Name = "dtpReceptionExemplaireDate";
			this.dtpReceptionExemplaireDate.Size = new System.Drawing.Size(100, 20);
			this.dtpReceptionExemplaireDate.TabIndex = 1;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(6, 20);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(129, 13);
			this.label16.TabIndex = 0;
			this.label16.Text = "Numéro réceptionné :";
			// 
			// grpReceptionRevue
			// 
			this.grpReceptionRevue.Controls.Add(this.labelReceptionExemplaireEtat);
			this.grpReceptionRevue.Controls.Add(this.cbxReceptionExemplaireEtat);
			this.grpReceptionRevue.Controls.Add(this.btnReceptionExemplaireModifierEtat);
			this.grpReceptionRevue.Controls.Add(this.btnReceptionExemplaireSupprimer);
			this.grpReceptionRevue.Controls.Add(this.label48);
			this.grpReceptionRevue.Controls.Add(this.label56);
			this.grpReceptionRevue.Controls.Add(this.pcbReceptionExemplaireRevueImage);
			this.grpReceptionRevue.Controls.Add(this.label13);
			this.grpReceptionRevue.Controls.Add(this.dgvReceptionExemplairesListe);
			this.grpReceptionRevue.Controls.Add(this.txbReceptionRevueImage);
			this.grpReceptionRevue.Controls.Add(this.txbReceptionRevueRayon);
			this.grpReceptionRevue.Controls.Add(this.txbReceptionRevuePublic);
			this.grpReceptionRevue.Controls.Add(this.txbReceptionRevueGenre);
			this.grpReceptionRevue.Controls.Add(this.txbReceptionRevueDelaiMiseADispo);
			this.grpReceptionRevue.Controls.Add(this.txbReceptionRevuePeriodicite);
			this.grpReceptionRevue.Controls.Add(this.txbReceptionRevueTitre);
			this.grpReceptionRevue.Controls.Add(this.txbReceptionRevueNumero);
			this.grpReceptionRevue.Controls.Add(this.label3);
			this.grpReceptionRevue.Controls.Add(this.pcbReceptionRevueImage);
			this.grpReceptionRevue.Controls.Add(this.label15);
			this.grpReceptionRevue.Controls.Add(this.label49);
			this.grpReceptionRevue.Controls.Add(this.label50);
			this.grpReceptionRevue.Controls.Add(this.label51);
			this.grpReceptionRevue.Controls.Add(this.label52);
			this.grpReceptionRevue.Controls.Add(this.label53);
			this.grpReceptionRevue.Controls.Add(this.label54);
			this.grpReceptionRevue.Controls.Add(this.btnReceptionRechercher);
			this.grpReceptionRevue.Location = new System.Drawing.Point(8, 13);
			this.grpReceptionRevue.Name = "grpReceptionRevue";
			this.grpReceptionRevue.Size = new System.Drawing.Size(859, 395);
			this.grpReceptionRevue.TabIndex = 15;
			this.grpReceptionRevue.TabStop = false;
			this.grpReceptionRevue.Text = "Recherche revue";
			// 
			// label48
			// 
			this.label48.AutoSize = true;
			this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label48.Location = new System.Drawing.Point(557, 127);
			this.label48.Name = "label48";
			this.label48.Size = new System.Drawing.Size(113, 13);
			this.label48.TabIndex = 56;
			this.label48.Text = "Image exemplaire :";
			// 
			// label56
			// 
			this.label56.AutoSize = true;
			this.label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label56.Location = new System.Drawing.Point(557, 20);
			this.label56.Name = "label56";
			this.label56.Size = new System.Drawing.Size(85, 13);
			this.label56.TabIndex = 55;
			this.label56.Text = "Image revue :";
			// 
			// pcbReceptionExemplaireRevueImage
			// 
			this.pcbReceptionExemplaireRevueImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pcbReceptionExemplaireRevueImage.Location = new System.Drawing.Point(560, 145);
			this.pcbReceptionExemplaireRevueImage.Name = "pcbReceptionExemplaireRevueImage";
			this.pcbReceptionExemplaireRevueImage.Size = new System.Drawing.Size(284, 210);
			this.pcbReceptionExemplaireRevueImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pcbReceptionExemplaireRevueImage.TabIndex = 54;
			this.pcbReceptionExemplaireRevueImage.TabStop = false;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(6, 220);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(68, 13);
			this.label13.TabIndex = 53;
			this.label13.Text = "Parutions :";
			// 
			// dgvReceptionExemplairesListe
			// 
			this.dgvReceptionExemplairesListe.AllowUserToAddRows = false;
			this.dgvReceptionExemplairesListe.AllowUserToDeleteRows = false;
			this.dgvReceptionExemplairesListe.AllowUserToResizeColumns = false;
			this.dgvReceptionExemplairesListe.AllowUserToResizeRows = false;
			this.dgvReceptionExemplairesListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvReceptionExemplairesListe.Location = new System.Drawing.Point(150, 221);
			this.dgvReceptionExemplairesListe.MultiSelect = false;
			this.dgvReceptionExemplairesListe.Name = "dgvReceptionExemplairesListe";
			this.dgvReceptionExemplairesListe.ReadOnly = true;
			this.dgvReceptionExemplairesListe.RowHeadersVisible = false;
			this.dgvReceptionExemplairesListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvReceptionExemplairesListe.Size = new System.Drawing.Size(391, 134);
			this.dgvReceptionExemplairesListe.TabIndex = 52;
			this.dgvReceptionExemplairesListe.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvExemplairesListe_ColumnHeaderMouseClick);
			this.dgvReceptionExemplairesListe.SelectionChanged += new System.EventHandler(this.dgvReceptionExemplairesListe_SelectionChanged);
			//
			// labelReceptionExemplaireEtat
			//
			this.labelReceptionExemplaireEtat.AutoSize = true;
			this.labelReceptionExemplaireEtat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelReceptionExemplaireEtat.Location = new System.Drawing.Point(150, 363);
			this.labelReceptionExemplaireEtat.Name = "labelReceptionExemplaireEtat";
			this.labelReceptionExemplaireEtat.Size = new System.Drawing.Size(39, 13);
			this.labelReceptionExemplaireEtat.TabIndex = 57;
			this.labelReceptionExemplaireEtat.Text = "Etat :";
			//
			// cbxReceptionExemplaireEtat
			//
			this.cbxReceptionExemplaireEtat.DisplayMember = "Libelle";
			this.cbxReceptionExemplaireEtat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxReceptionExemplaireEtat.Enabled = false;
			this.cbxReceptionExemplaireEtat.FormattingEnabled = true;
			this.cbxReceptionExemplaireEtat.Location = new System.Drawing.Point(195, 360);
			this.cbxReceptionExemplaireEtat.Name = "cbxReceptionExemplaireEtat";
			this.cbxReceptionExemplaireEtat.Size = new System.Drawing.Size(200, 21);
			this.cbxReceptionExemplaireEtat.TabIndex = 58;
			this.cbxReceptionExemplaireEtat.ValueMember = "Id";
			//
			// btnReceptionExemplaireModifierEtat
			//
			this.btnReceptionExemplaireModifierEtat.Enabled = false;
			this.btnReceptionExemplaireModifierEtat.Location = new System.Drawing.Point(401, 359);
			this.btnReceptionExemplaireModifierEtat.Name = "btnReceptionExemplaireModifierEtat";
			this.btnReceptionExemplaireModifierEtat.Size = new System.Drawing.Size(100, 23);
			this.btnReceptionExemplaireModifierEtat.TabIndex = 59;
			this.btnReceptionExemplaireModifierEtat.Text = "Modifier l'état";
			this.btnReceptionExemplaireModifierEtat.UseVisualStyleBackColor = true;
			this.btnReceptionExemplaireModifierEtat.Click += new System.EventHandler(this.btnReceptionExemplaireModifierEtat_Click);
			//
			// btnReceptionExemplaireSupprimer
			//
			this.btnReceptionExemplaireSupprimer.Enabled = false;
			this.btnReceptionExemplaireSupprimer.Location = new System.Drawing.Point(507, 359);
			this.btnReceptionExemplaireSupprimer.Name = "btnReceptionExemplaireSupprimer";
			this.btnReceptionExemplaireSupprimer.Size = new System.Drawing.Size(75, 23);
			this.btnReceptionExemplaireSupprimer.TabIndex = 60;
			this.btnReceptionExemplaireSupprimer.Text = "Supprimer";
			this.btnReceptionExemplaireSupprimer.UseVisualStyleBackColor = true;
			this.btnReceptionExemplaireSupprimer.Click += new System.EventHandler(this.btnReceptionExemplaireSupprimer_Click);
			//
			// txbReceptionRevueImage
			// 
			this.txbReceptionRevueImage.Location = new System.Drawing.Point(150, 195);
			this.txbReceptionRevueImage.Name = "txbReceptionRevueImage";
			this.txbReceptionRevueImage.ReadOnly = true;
			this.txbReceptionRevueImage.Size = new System.Drawing.Size(391, 20);
			this.txbReceptionRevueImage.TabIndex = 50;
			// 
			// txbReceptionRevueRayon
			// 
			this.txbReceptionRevueRayon.Location = new System.Drawing.Point(150, 170);
			this.txbReceptionRevueRayon.Name = "txbReceptionRevueRayon";
			this.txbReceptionRevueRayon.ReadOnly = true;
			this.txbReceptionRevueRayon.Size = new System.Drawing.Size(207, 20);
			this.txbReceptionRevueRayon.TabIndex = 49;
			// 
			// txbReceptionRevuePublic
			// 
			this.txbReceptionRevuePublic.Location = new System.Drawing.Point(150, 145);
			this.txbReceptionRevuePublic.Name = "txbReceptionRevuePublic";
			this.txbReceptionRevuePublic.ReadOnly = true;
			this.txbReceptionRevuePublic.Size = new System.Drawing.Size(207, 20);
			this.txbReceptionRevuePublic.TabIndex = 48;
			// 
			// txbReceptionRevueGenre
			// 
			this.txbReceptionRevueGenre.Location = new System.Drawing.Point(150, 120);
			this.txbReceptionRevueGenre.Name = "txbReceptionRevueGenre";
			this.txbReceptionRevueGenre.ReadOnly = true;
			this.txbReceptionRevueGenre.Size = new System.Drawing.Size(207, 20);
			this.txbReceptionRevueGenre.TabIndex = 47;
			// 
			// txbReceptionRevueDelaiMiseADispo
			// 
			this.txbReceptionRevueDelaiMiseADispo.Location = new System.Drawing.Point(150, 95);
			this.txbReceptionRevueDelaiMiseADispo.Name = "txbReceptionRevueDelaiMiseADispo";
			this.txbReceptionRevueDelaiMiseADispo.ReadOnly = true;
			this.txbReceptionRevueDelaiMiseADispo.Size = new System.Drawing.Size(100, 20);
			this.txbReceptionRevueDelaiMiseADispo.TabIndex = 46;
			// 
			// txbReceptionRevuePeriodicite
			// 
			this.txbReceptionRevuePeriodicite.Location = new System.Drawing.Point(150, 70);
			this.txbReceptionRevuePeriodicite.Name = "txbReceptionRevuePeriodicite";
			this.txbReceptionRevuePeriodicite.ReadOnly = true;
			this.txbReceptionRevuePeriodicite.Size = new System.Drawing.Size(100, 20);
			this.txbReceptionRevuePeriodicite.TabIndex = 45;
			// 
			// txbReceptionRevueTitre
			// 
			this.txbReceptionRevueTitre.Location = new System.Drawing.Point(150, 45);
			this.txbReceptionRevueTitre.Name = "txbReceptionRevueTitre";
			this.txbReceptionRevueTitre.ReadOnly = true;
			this.txbReceptionRevueTitre.Size = new System.Drawing.Size(391, 20);
			this.txbReceptionRevueTitre.TabIndex = 44;
			// 
			// txbReceptionRevueNumero
			// 
			this.txbReceptionRevueNumero.Location = new System.Drawing.Point(150, 20);
			this.txbReceptionRevueNumero.Name = "txbReceptionRevueNumero";
			this.txbReceptionRevueNumero.Size = new System.Drawing.Size(100, 20);
			this.txbReceptionRevueNumero.TabIndex = 43;
			this.txbReceptionRevueNumero.TextChanged += new System.EventHandler(this.txbReceptionRevueNumero_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(6, 120);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 13);
			this.label3.TabIndex = 42;
			this.label3.Text = "Genre :";
			// 
			// pcbReceptionRevueImage
			// 
			this.pcbReceptionRevueImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pcbReceptionRevueImage.Location = new System.Drawing.Point(690, 20);
			this.pcbReceptionRevueImage.Name = "pcbReceptionRevueImage";
			this.pcbReceptionRevueImage.Size = new System.Drawing.Size(154, 114);
			this.pcbReceptionRevueImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pcbReceptionRevueImage.TabIndex = 41;
			this.pcbReceptionRevueImage.TabStop = false;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(6, 145);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(50, 13);
			this.label15.TabIndex = 40;
			this.label15.Text = "Public :";
			// 
			// label49
			// 
			this.label49.AutoSize = true;
			this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label49.Location = new System.Drawing.Point(6, 170);
			this.label49.Name = "label49";
			this.label49.Size = new System.Drawing.Size(51, 13);
			this.label49.TabIndex = 39;
			this.label49.Text = "Rayon :";
			// 
			// label50
			// 
			this.label50.AutoSize = true;
			this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label50.Location = new System.Drawing.Point(6, 45);
			this.label50.Name = "label50";
			this.label50.Size = new System.Drawing.Size(41, 13);
			this.label50.TabIndex = 36;
			this.label50.Text = "Titre :";
			// 
			// label51
			// 
			this.label51.AutoSize = true;
			this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label51.Location = new System.Drawing.Point(6, 20);
			this.label51.Name = "label51";
			this.label51.Size = new System.Drawing.Size(94, 13);
			this.label51.TabIndex = 33;
			this.label51.Text = "Numéro revue :";
			// 
			// label52
			// 
			this.label52.AutoSize = true;
			this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label52.Location = new System.Drawing.Point(6, 70);
			this.label52.Name = "label52";
			this.label52.Size = new System.Drawing.Size(75, 13);
			this.label52.TabIndex = 37;
			this.label52.Text = "Périodicité :";
			// 
			// label53
			// 
			this.label53.AutoSize = true;
			this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label53.Location = new System.Drawing.Point(6, 195);
			this.label53.Name = "label53";
			this.label53.Size = new System.Drawing.Size(117, 13);
			this.label53.TabIndex = 34;
			this.label53.Text = "Chemin de l\'image :";
			// 
			// label54
			// 
			this.label54.AutoSize = true;
			this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label54.Location = new System.Drawing.Point(6, 95);
			this.label54.Name = "label54";
			this.label54.Size = new System.Drawing.Size(118, 13);
			this.label54.TabIndex = 38;
			this.label54.Text = "Délai mise à dispo :";
			// 
			// btnReceptionRechercher
			// 
			this.btnReceptionRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReceptionRechercher.Location = new System.Drawing.Point(261, 19);
			this.btnReceptionRechercher.Name = "btnReceptionRechercher";
			this.btnReceptionRechercher.Size = new System.Drawing.Size(96, 22);
			this.btnReceptionRechercher.TabIndex = 16;
			this.btnReceptionRechercher.Text = "Rechercher";
			this.btnReceptionRechercher.UseVisualStyleBackColor = true;
			this.btnReceptionRechercher.Click += new System.EventHandler(this.btnReceptionRechercher_Click);
			// 
			// FrmMediatek
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(883, 860);
			this.Controls.Add(this.tabOngletsApplication);
			this.Name = "FrmMediatek";
			this.Text = "Gestion des documents de la médiathèque";
			this.Load += new System.EventHandler(this.FrmMediatek_Load);
			this.tabOngletsApplication.ResumeLayout(false);
			this.tabLivres.ResumeLayout(false);
			this.grpLivresInfos.ResumeLayout(false);
			this.grpLivresInfos.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcbLivresImage)).EndInit();
			this.grpLivresRecherche.ResumeLayout(false);
			this.grpLivresRecherche.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvLivresListe)).EndInit();
			this.grpLivresExemplaires.ResumeLayout(false);
			this.grpLivresExemplaires.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvLivresExemplairesListe)).EndInit();
			this.tabDvd.ResumeLayout(false);
			this.grpDvdInfos.ResumeLayout(false);
			this.grpDvdInfos.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcbDvdImage)).EndInit();
			this.grpDvdRecherche.ResumeLayout(false);
			this.grpDvdRecherche.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDvdListe)).EndInit();
			this.grpDvdExemplaires.ResumeLayout(false);
			this.grpDvdExemplaires.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDvdExemplairesListe)).EndInit();
			this.tabRevues.ResumeLayout(false);
			this.grpRevuesInfos.ResumeLayout(false);
			this.grpRevuesInfos.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcbRevuesImage)).EndInit();
			this.grpRevuesRecherche.ResumeLayout(false);
			this.grpRevuesRecherche.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvRevuesListe)).EndInit();
			this.tabReceptionRevue.ResumeLayout(false);
			this.grpReceptionExemplaire.ResumeLayout(false);
			this.grpReceptionExemplaire.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcbReceptionExemplaireImage)).EndInit();
			this.grpReceptionRevue.ResumeLayout(false);
			this.grpReceptionRevue.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcbReceptionExemplaireRevueImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvReceptionExemplairesListe)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbReceptionRevueImage)).EndInit();
			this.tabCommandesLivres.ResumeLayout(false);
			this.grpCommandesLivresNouvelle.ResumeLayout(false);
			this.grpCommandesLivresNouvelle.PerformLayout();
			this.grpCommandesLivres.ResumeLayout(false);
			this.grpCommandesLivres.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCommandesLivres)).EndInit();
			this.tabCommandesDvd.ResumeLayout(false);
			this.grpCommandesDvdNouvelle.ResumeLayout(false);
			this.grpCommandesDvdNouvelle.PerformLayout();
			this.grpCommandesDvd.ResumeLayout(false);
			this.grpCommandesDvd.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCommandesDvd)).EndInit();
			this.tabCommandesRevues.ResumeLayout(false);
			this.grpCommandesRevuesNouvelle.ResumeLayout(false);
			this.grpCommandesRevuesNouvelle.PerformLayout();
			this.grpCommandesRevues.ResumeLayout(false);
			this.grpCommandesRevues.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCommandesRevues)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabOngletsApplication;
        private System.Windows.Forms.TabPage tabRevues;
        private System.Windows.Forms.TabPage tabLivres;
        private System.Windows.Forms.TabPage tabCommandesLivres;
        private System.Windows.Forms.TabPage tabCommandesDvd;
        private System.Windows.Forms.TabPage tabCommandesRevues;
        private System.Windows.Forms.TabPage tabDvd;
        private System.Windows.Forms.TextBox txbLivresTitreRecherche;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpLivresRecherche;
        private System.Windows.Forms.DataGridView dgvLivresListe;
        private System.Windows.Forms.TabPage tabReceptionRevue;
        private System.Windows.Forms.GroupBox grpLivresExemplaires;
        private System.Windows.Forms.DataGridView dgvLivresExemplairesListe;
        private System.Windows.Forms.Label labelLivresExemplaireEtat;
        private System.Windows.Forms.ComboBox cbxLivresExemplaireEtat;
        private System.Windows.Forms.Button btnLivresExemplaireModifierEtat;
        private System.Windows.Forms.Button btnLivresExemplaireSupprimer;
        private System.Windows.Forms.GroupBox grpReceptionExemplaire;
        private System.Windows.Forms.Button btnReceptionExemplaireValider;
        private System.Windows.Forms.Button btnReceptionExemplaireSupprimer;
        private System.Windows.Forms.Label labelReceptionExemplaireEtat;
        private System.Windows.Forms.ComboBox cbxReceptionExemplaireEtat;
        private System.Windows.Forms.Button btnReceptionExemplaireModifierEtat;
        private System.Windows.Forms.TextBox txbReceptionExemplaireImage;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txbReceptionExemplaireNumero;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtpReceptionExemplaireDate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox grpReceptionRevue;
        private System.Windows.Forms.ComboBox cbxLivresGenres;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbxLivresPublics;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cbxLivresRayons;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnLivresAnnulGenres;
        private System.Windows.Forms.GroupBox grpLivresInfos;
        private System.Windows.Forms.PictureBox pcbLivresImage;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLivresNumRecherche;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbLivresNumRecherche;
        private System.Windows.Forms.Button btnlivresAnnulPublics;
        private System.Windows.Forms.Button btnLivresAnnulRayons;
		private System.Windows.Forms.GroupBox grpDvdRecherche;
		private System.Windows.Forms.Button btnSupprimerDvd;
		private System.Windows.Forms.Button btnModifierDvd;
		private System.Windows.Forms.Button btnAjouterDvd;
		private System.Windows.Forms.Button btnDvdAnnulRayons;
        private System.Windows.Forms.Button btnDvdAnnulPublics;
        private System.Windows.Forms.Button btnDvdNumRecherche;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox txbDvdNumRecherche;
        private System.Windows.Forms.Button btnDvdAnnulGenres;
        private System.Windows.Forms.ComboBox cbxDvdRayons;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.ComboBox cbxDvdPublics;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.ComboBox cbxDvdGenres;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.DataGridView dgvDvdListe;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox txbDvdTitreRecherche;
        private System.Windows.Forms.GroupBox grpDvdExemplaires;
        private System.Windows.Forms.DataGridView dgvDvdExemplairesListe;
        private System.Windows.Forms.Label labelDvdExemplaireEtat;
        private System.Windows.Forms.ComboBox cbxDvdExemplaireEtat;
        private System.Windows.Forms.Button btnDvdExemplaireModifierEtat;
        private System.Windows.Forms.Button btnDvdExemplaireSupprimer;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txbLivresTitre;
        private System.Windows.Forms.TextBox txbLivresNumero;
        private System.Windows.Forms.TextBox txbLivresIsbn;
        private System.Windows.Forms.TextBox txbLivresImage;
        private System.Windows.Forms.TextBox txbLivresRayon;
        private System.Windows.Forms.TextBox txbLivresPublic;
        private System.Windows.Forms.TextBox txbLivresGenre;
        private System.Windows.Forms.TextBox txbLivresCollection;
        private System.Windows.Forms.TextBox txbLivresAuteur;
        private System.Windows.Forms.GroupBox grpDvdInfos;
        private System.Windows.Forms.TextBox txbDvdDuree;
        private System.Windows.Forms.TextBox txbDvdImage;
        private System.Windows.Forms.TextBox txbDvdRayon;
        private System.Windows.Forms.TextBox txbDvdPublic;
        private System.Windows.Forms.TextBox txbDvdGenre;
        private System.Windows.Forms.TextBox txbDvdSynopsis;
        private System.Windows.Forms.TextBox txbDvdRealisateur;
        private System.Windows.Forms.TextBox txbDvdTitre;
        private System.Windows.Forms.TextBox txbDvdNumero;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.PictureBox pcbDvdImage;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.GroupBox grpRevuesInfos;
        private System.Windows.Forms.TextBox txbRevuesImage;
        private System.Windows.Forms.TextBox txbRevuesRayon;
        private System.Windows.Forms.TextBox txbRevuesPublic;
        private System.Windows.Forms.TextBox txbRevuesGenre;
        private System.Windows.Forms.TextBox txbRevuesDateMiseADispo;
        private System.Windows.Forms.TextBox txbRevuesPeriodicite;
        private System.Windows.Forms.TextBox txbRevuesTitre;
        private System.Windows.Forms.TextBox txbRevuesNumero;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.PictureBox pcbRevuesImage;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.GroupBox grpRevuesRecherche;
        private System.Windows.Forms.Button btnSupprimerRevue;
        private System.Windows.Forms.Button btnModifierRevue;
        private System.Windows.Forms.Button btnAjouterRevue;
        private System.Windows.Forms.Button btnRevuesAnnulRayons;
        private System.Windows.Forms.Button btnRevuesAnnulPublics;
        private System.Windows.Forms.Button btnRevuesNumRecherche;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbRevuesNumRecherche;
        private System.Windows.Forms.Button btnRevuesAnnulGenres;
        private System.Windows.Forms.ComboBox cbxRevuesRayons;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxRevuesPublics;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ComboBox cbxRevuesGenres;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.DataGridView dgvRevuesListe;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox txbRevuesTitreRecherche;
        private System.Windows.Forms.Button btnReceptionRechercher;
        private System.Windows.Forms.TextBox txbReceptionRevueImage;
        private System.Windows.Forms.TextBox txbReceptionRevueRayon;
        private System.Windows.Forms.TextBox txbReceptionRevuePublic;
        private System.Windows.Forms.TextBox txbReceptionRevueGenre;
        private System.Windows.Forms.TextBox txbReceptionRevueDelaiMiseADispo;
        private System.Windows.Forms.TextBox txbReceptionRevuePeriodicite;
        private System.Windows.Forms.TextBox txbReceptionRevueTitre;
        private System.Windows.Forms.TextBox txbReceptionRevueNumero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pcbReceptionRevueImage;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.PictureBox pcbReceptionExemplaireImage;
        private System.Windows.Forms.Button btnReceptionExemplaireImage;
        private System.Windows.Forms.DataGridView dgvReceptionExemplairesListe;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pcbReceptionExemplaireRevueImage;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
		private System.Windows.Forms.Button btnSupprimerLivre;
		private System.Windows.Forms.Button btnModifierLivre;
		private System.Windows.Forms.Button btnAjouterLivre;
		private System.Windows.Forms.GroupBox grpCommandesLivresNouvelle;
		private System.Windows.Forms.Button btnAjouterCommandeLivre;
		private System.Windows.Forms.TextBox txbCommandesLivresNbExemplaire;
		private System.Windows.Forms.Label labelCommandesLivresNbExemplaire;
		private System.Windows.Forms.TextBox txbCommandesLivresMontant;
		private System.Windows.Forms.Label labelCommandesLivresMontant;
		private System.Windows.Forms.DateTimePicker dtpCommandesLivresDateCommande;
		private System.Windows.Forms.Label labelCommandesLivresDateCommande;
		private System.Windows.Forms.GroupBox grpCommandesLivres;
		private System.Windows.Forms.DataGridView dgvCommandesLivres;
		private System.Windows.Forms.TextBox txbCommandesLivresRayon;
		private System.Windows.Forms.TextBox txbCommandesLivresPublic;
		private System.Windows.Forms.TextBox txbCommandesLivresGenre;
		private System.Windows.Forms.TextBox txbCommandesLivresTitre;
		private System.Windows.Forms.TextBox txbCommandesLivresNumero;
		private System.Windows.Forms.Label labelCommandesLivresRayon;
		private System.Windows.Forms.Label labelCommandesLivresPublic;
		private System.Windows.Forms.Label labelCommandesLivresGenre;
		private System.Windows.Forms.Label labelCommandesLivresTitre;
		private System.Windows.Forms.Label labelCommandesLivresNumero;
		private System.Windows.Forms.Button btnCommandesLivresRechercher;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDateCommande;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMontant;
		private System.Windows.Forms.DataGridViewTextBoxColumn colNbExemplaire;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSuivi;
		private System.Windows.Forms.Label labelCommandesLivresSuivi;
		private System.Windows.Forms.ComboBox cmbCommandesLivresSuivi;
		private System.Windows.Forms.Button btnModifierSuiviCommande;
		private System.Windows.Forms.Button btnSupprimerCommande;
		private System.Windows.Forms.GroupBox grpCommandesDvdNouvelle;
		private System.Windows.Forms.Button btnAjouterCommandeDvd;
		private System.Windows.Forms.TextBox txbCommandesDvdNbExemplaire;
		private System.Windows.Forms.Label labelCommandesDvdNbExemplaire;
		private System.Windows.Forms.TextBox txbCommandesDvdMontant;
		private System.Windows.Forms.Label labelCommandesDvdMontant;
		private System.Windows.Forms.DateTimePicker dtpCommandesDvdDateCommande;
		private System.Windows.Forms.Label labelCommandesDvdDateCommande;
		private System.Windows.Forms.GroupBox grpCommandesDvd;
		private System.Windows.Forms.Button btnCommandesDvdSupprimer;
		private System.Windows.Forms.Button btnCommandesDvdModifierSuivi;
		private System.Windows.Forms.ComboBox cmbCommandesDvdSuivi;
		private System.Windows.Forms.Label labelCommandesDvdSuivi;
		private System.Windows.Forms.Button btnCommandesDvdRechercher;
		private System.Windows.Forms.DataGridView dgvCommandesDvd;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDateCommandeDvd;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMontantDvd;
		private System.Windows.Forms.DataGridViewTextBoxColumn colNbExemplaireDvd;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSuiviDvd;
		private System.Windows.Forms.TextBox txbCommandesDvdRayon;
		private System.Windows.Forms.TextBox txbCommandesDvdPublic;
		private System.Windows.Forms.TextBox txbCommandesDvdGenre;
		private System.Windows.Forms.TextBox txbCommandesDvdTitre;
		private System.Windows.Forms.TextBox txbCommandesDvdNumero;
		private System.Windows.Forms.Label labelCommandesDvdRayon;
		private System.Windows.Forms.Label labelCommandesDvdPublic;
		private System.Windows.Forms.Label labelCommandesDvdGenre;
		private System.Windows.Forms.Label labelCommandesDvdTitre;
		private System.Windows.Forms.Label labelCommandesDvdNumero;
		private System.Windows.Forms.GroupBox grpCommandesRevuesNouvelle;
		private System.Windows.Forms.Button btnAjouterCommandeRevue;
		private System.Windows.Forms.DateTimePicker dtpCommandesRevuesDateFinAbonnement;
		private System.Windows.Forms.Label labelCommandesRevuesDateFinAbonnement;
		private System.Windows.Forms.TextBox txbCommandesRevuesMontant;
		private System.Windows.Forms.Label labelCommandesRevuesMontant;
		private System.Windows.Forms.DateTimePicker dtpCommandesRevuesDateCommande;
		private System.Windows.Forms.Label labelCommandesRevuesDateCommande;
		private System.Windows.Forms.GroupBox grpCommandesRevues;
		private System.Windows.Forms.Button btnSupprimerCommandeRevue;
		private System.Windows.Forms.Button btnCommandesRevuesRechercher;
		private System.Windows.Forms.DataGridView dgvCommandesRevues;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCommandesRevuesDateCommande;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCommandesRevuesMontant;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCommandesRevuesDateFinAbonnement;
		private System.Windows.Forms.TextBox txbCommandesRevuesRayon;
		private System.Windows.Forms.TextBox txbCommandesRevuesPublic;
		private System.Windows.Forms.TextBox txbCommandesRevuesGenre;
		private System.Windows.Forms.TextBox txbCommandesRevuesTitre;
		private System.Windows.Forms.TextBox txbCommandesRevuesNumero;
		private System.Windows.Forms.Label labelCommandesRevuesRayon;
		private System.Windows.Forms.Label labelCommandesRevuesPublic;
		private System.Windows.Forms.Label labelCommandesRevuesGenre;
		private System.Windows.Forms.Label labelCommandesRevuesTitre;
		private System.Windows.Forms.Label labelCommandesRevuesNumero;
	}
}

