using System;
using System.Windows.Forms;
using MediaTekDocuments.model;
using MediaTekDocuments.controller;
using MediaTekDocuments.dal;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.IO;

namespace MediaTekDocuments.view

{
    /// <summary>
    /// Classe d'affichage
    /// </summary>
    public partial class FrmMediatek : Form
    {
        #region Commun
        private readonly FrmMediatekController controller;
        private readonly BindingSource bdgGenres = new BindingSource();
        private readonly BindingSource bdgPublics = new BindingSource();
        private readonly BindingSource bdgRayons = new BindingSource();

        /// <summary>
        /// Constructeur : création du contrôleur lié à ce formulaire
        /// </summary>
        internal FrmMediatek()
        {
            InitializeComponent();
            this.controller = new FrmMediatekController();

			btnModifierLivre.Enabled = false;
			btnSupprimerLivre.Enabled = false;
		}

        /// <summary>
        /// Au démarrage : alerte si des abonnements de revues expirent dans moins de 30 jours.
        /// </summary>
        private void FrmMediatek_Load(object sender, EventArgs e)
        {
            var alertes = controller.GetAbonnementsRevuesFinProche()
                .OrderBy(a => a.DateFinAbonnement)
                .ToList();
            if (alertes.Count > 0)
            {
                using (FrmAlertAbonnementsRevues frm = new FrmAlertAbonnementsRevues(alertes))
                {
                    frm.ShowDialog(this);
                }
            }
        }

        /// <summary>
        /// Rempli un des 3 combo (genre, public, rayon)
        /// </summary>
        /// <param name="lesCategories">liste des objets de type Genre ou Public ou Rayon</param>
        /// <param name="bdg">bindingsource contenant les informations</param>
        /// <param name="cbx">combobox à remplir</param>
        public void RemplirComboCategorie(List<Categorie> lesCategories, BindingSource bdg, ComboBox cbx)
        {
            bdg.DataSource = lesCategories;
            cbx.DataSource = bdg;
            if (cbx.Items.Count > 0)
            {
                cbx.SelectedIndex = -1;
            }
        }
        #endregion

        #region Onglet Livres
        private readonly BindingSource bdgLivresListe = new BindingSource();
        private readonly BindingSource bdgLivresExemplairesListe = new BindingSource();
        private List<Livre> lesLivres = new List<Livre>();
        private List<Exemplaire> lesLivresExemplaires = new List<Exemplaire>();
        private List<Etat> lesEtatsLivres = new List<Etat>();

        /// <summary>
        /// Ouverture de l'onglet Livres : 
        /// appel des méthodes pour remplir le datagrid des livres et des combos (genre, rayon, public)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabLivres_Enter(object sender, EventArgs e)
        {
            lesLivres = controller.GetAllLivres();
            RemplirComboCategorie(controller.GetAllGenres(), bdgGenres, cbxLivresGenres);
            RemplirComboCategorie(controller.GetAllPublics(), bdgPublics, cbxLivresPublics);
            RemplirComboCategorie(controller.GetAllRayons(), bdgRayons, cbxLivresRayons);
            lesEtatsLivres = controller.GetAllEtats();
            cbxLivresExemplaireEtat.DataSource = lesEtatsLivres;
            cbxLivresExemplaireEtat.SelectedIndex = -1;
            RemplirLivresListeComplete();
            RemplirLivresExemplairesListe(null);
            ActiverGestionEtatLivre(false);
        }

        /// <summary>
        /// Remplit le dategrid avec la liste reçue en paramètre
        /// </summary>
        /// <param name="livres">liste de livres</param>
        private void RemplirLivresListe(List<Livre> livres)
        {
            bdgLivresListe.DataSource = livres;
            dgvLivresListe.DataSource = bdgLivresListe;
            dgvLivresListe.Columns["isbn"].Visible = false;
            dgvLivresListe.Columns["idRayon"].Visible = false;
            dgvLivresListe.Columns["idGenre"].Visible = false;
            dgvLivresListe.Columns["idPublic"].Visible = false;
            dgvLivresListe.Columns["image"].Visible = false;
            dgvLivresListe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvLivresListe.Columns["id"].DisplayIndex = 0;
            dgvLivresListe.Columns["titre"].DisplayIndex = 1;
        }

        /// <summary>
        /// Recherche et affichage du livre dont on a saisi le numéro.
        /// Si non trouvé, affichage d'un MessageBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLivresNumRecherche_Click(object sender, EventArgs e)
        {
            if (!txbLivresNumRecherche.Text.Equals(""))
            {
                txbLivresTitreRecherche.Text = "";
                cbxLivresGenres.SelectedIndex = -1;
                cbxLivresRayons.SelectedIndex = -1;
                cbxLivresPublics.SelectedIndex = -1;
                Livre livre = lesLivres.Find(x => x.Id.Equals(txbLivresNumRecherche.Text));
                if (livre != null)
                {
                    List<Livre> livres = new List<Livre>() { livre };
                    RemplirLivresListe(livres);
                }
                else
                {
                    MessageBox.Show("numéro introuvable");
                    RemplirLivresListeComplete();
                }
            }
            else
            {
                RemplirLivresListeComplete();
            }
        }

        /// <summary>
        /// Recherche et affichage des livres dont le titre matche acec la saisie.
        /// Cette procédure est exécutée à chaque ajout ou suppression de caractère
        /// dans le textBox de saisie.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxbLivresTitreRecherche_TextChanged(object sender, EventArgs e)
        {
            if (!txbLivresTitreRecherche.Text.Equals(""))
            {
                cbxLivresGenres.SelectedIndex = -1;
                cbxLivresRayons.SelectedIndex = -1;
                cbxLivresPublics.SelectedIndex = -1;
                txbLivresNumRecherche.Text = "";
                List<Livre> lesLivresParTitre;
                lesLivresParTitre = lesLivres.FindAll(x => x.Titre.ToLower().Contains(txbLivresTitreRecherche.Text.ToLower()));
                RemplirLivresListe(lesLivresParTitre);
            }
            else
            {
                // si la zone de saisie est vide et aucun élément combo sélectionné, réaffichage de la liste complète
                if (cbxLivresGenres.SelectedIndex < 0 && cbxLivresPublics.SelectedIndex < 0 && cbxLivresRayons.SelectedIndex < 0
                    && txbLivresNumRecherche.Text.Equals(""))
                {
                    RemplirLivresListeComplete();
                }
            }
        }

        /// <summary>
        /// Affichage des informations du livre sélectionné
        /// </summary>
        /// <param name="livre">le livre</param>
        private void AfficheLivresInfos(Livre livre)
        {
            txbLivresAuteur.Text = livre.Auteur;
            txbLivresCollection.Text = livre.Collection;
            txbLivresImage.Text = livre.Image;
            txbLivresIsbn.Text = livre.Isbn;
            txbLivresNumero.Text = livre.Id;
            txbLivresGenre.Text = livre.Genre;
            txbLivresPublic.Text = livre.Public;
            txbLivresRayon.Text = livre.Rayon;
            txbLivresTitre.Text = livre.Titre;
            string image = livre.Image;
            try
            {
                pcbLivresImage.Image = Image.FromFile(image);
            }
            catch
            {
                pcbLivresImage.Image = null;
            }
        }

        /// <summary>
        /// Vide les zones d'affichage des informations du livre
        /// </summary>
        private void VideLivresInfos()
        {
            txbLivresAuteur.Text = "";
            txbLivresCollection.Text = "";
            txbLivresImage.Text = "";
            txbLivresIsbn.Text = "";
            txbLivresNumero.Text = "";
            txbLivresGenre.Text = "";
            txbLivresPublic.Text = "";
            txbLivresRayon.Text = "";
            txbLivresTitre.Text = "";
            pcbLivresImage.Image = null;
        }

        /// <summary>
        /// Filtre sur le genre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxLivresGenres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxLivresGenres.SelectedIndex >= 0)
            {
                txbLivresTitreRecherche.Text = "";
                txbLivresNumRecherche.Text = "";
                Genre genre = (Genre)cbxLivresGenres.SelectedItem;
                List<Livre> livres = lesLivres.FindAll(x => x.Genre.Equals(genre.Libelle));
                RemplirLivresListe(livres);
                cbxLivresRayons.SelectedIndex = -1;
                cbxLivresPublics.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Filtre sur la catégorie de public
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxLivresPublics_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxLivresPublics.SelectedIndex >= 0)
            {
                txbLivresTitreRecherche.Text = "";
                txbLivresNumRecherche.Text = "";
                Public lePublic = (Public)cbxLivresPublics.SelectedItem;
                List<Livre> livres = lesLivres.FindAll(x => x.Public.Equals(lePublic.Libelle));
                RemplirLivresListe(livres);
                cbxLivresRayons.SelectedIndex = -1;
                cbxLivresGenres.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Filtre sur le rayon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxLivresRayons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxLivresRayons.SelectedIndex >= 0)
            {
                txbLivresTitreRecherche.Text = "";
                txbLivresNumRecherche.Text = "";
                Rayon rayon = (Rayon)cbxLivresRayons.SelectedItem;
                List<Livre> livres = lesLivres.FindAll(x => x.Rayon.Equals(rayon.Libelle));
                RemplirLivresListe(livres);
                cbxLivresGenres.SelectedIndex = -1;
                cbxLivresPublics.SelectedIndex = -1;
            }
        }

		/// <summary>
		/// Sur la sélection d'une ligne ou cellule dans le grid
		/// affichage des informations du livre
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DgvLivresListe_SelectionChanged(object sender, EventArgs e)
		{
			if (dgvLivresListe.CurrentCell != null)
			{
				btnModifierLivre.Enabled = true;
				btnSupprimerLivre.Enabled = true;

				try
				{
					Livre livre = (Livre)bdgLivresListe.List[bdgLivresListe.Position];
					AfficheLivresInfos(livre);
                    ChargerExemplairesLivreSelectionne(livre);
				}
				catch
				{
					VideLivresZones();
					btnModifierLivre.Enabled = false;
					btnSupprimerLivre.Enabled = false;
                    RemplirLivresExemplairesListe(null);
                    ActiverGestionEtatLivre(false);
				}
			}
			else
			{
				VideLivresInfos();
				btnModifierLivre.Enabled = false;
				btnSupprimerLivre.Enabled = false;
                RemplirLivresExemplairesListe(null);
                ActiverGestionEtatLivre(false);
			}
		}

		/// <summary>
		/// Sur le clic du bouton d'annulation, affichage de la liste complète des livres
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnLivresAnnulPublics_Click(object sender, EventArgs e)
        {
            RemplirLivresListeComplete();
        }

        /// <summary>
        /// Sur le clic du bouton d'annulation, affichage de la liste complète des livres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLivresAnnulRayons_Click(object sender, EventArgs e)
        {
            RemplirLivresListeComplete();
        }

        /// <summary>
        /// Sur le clic du bouton d'annulation, affichage de la liste complète des livres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLivresAnnulGenres_Click(object sender, EventArgs e)
        {
            RemplirLivresListeComplete();
        }

        /// <summary>
        /// Affichage de la liste complète des livres
        /// et annulation de toutes les recherches et filtres
        /// </summary>
        private void RemplirLivresListeComplete()
        {
            RemplirLivresListe(lesLivres);
            VideLivresZones();
        }

        /// <summary>
        /// vide les zones de recherche et de filtre
        /// </summary>
        private void VideLivresZones()
        {
            cbxLivresGenres.SelectedIndex = -1;
            cbxLivresRayons.SelectedIndex = -1;
            cbxLivresPublics.SelectedIndex = -1;
            txbLivresNumRecherche.Text = "";
            txbLivresTitreRecherche.Text = "";
        }

        /// <summary>
        /// Tri sur les colonnes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvLivresListe_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            VideLivresZones();
            string titreColonne = dgvLivresListe.Columns[e.ColumnIndex].HeaderText;
            List<Livre> sortedList = new List<Livre>();
            switch (titreColonne)
            {
                case "Id":
                    sortedList = lesLivres.OrderBy(o => o.Id).ToList();
                    break;
                case "Titre":
                    sortedList = lesLivres.OrderBy(o => o.Titre).ToList();
                    break;
                case "Collection":
                    sortedList = lesLivres.OrderBy(o => o.Collection).ToList();
                    break;
                case "Auteur":
                    sortedList = lesLivres.OrderBy(o => o.Auteur).ToList();
                    break;
                case "Genre":
                    sortedList = lesLivres.OrderBy(o => o.Genre).ToList();
                    break;
                case "Public":
                    sortedList = lesLivres.OrderBy(o => o.Public).ToList();
                    break;
                case "Rayon":
                    sortedList = lesLivres.OrderBy(o => o.Rayon).ToList();
                    break;
            }
            RemplirLivresListe(sortedList);
        }

        /// <summary>
        /// Charge les exemplaires du livre sélectionné.
        /// </summary>
        /// <param name="livre">Livre sélectionné</param>
        private void ChargerExemplairesLivreSelectionne(Livre livre)
        {
            lesLivresExemplaires = controller.GetExemplairesDocument(livre.Id);
            RemplirLivresExemplairesListe(lesLivresExemplaires.OrderByDescending(x => x.DateAchat).ToList());
            ActiverGestionEtatLivre(false);
        }

        /// <summary>
        /// Remplit la liste des exemplaires de livre.
        /// </summary>
        /// <param name="exemplaires">Liste d'exemplaires</param>
        private void RemplirLivresExemplairesListe(List<Exemplaire> exemplaires)
        {
            if (exemplaires == null)
            {
                bdgLivresExemplairesListe.DataSource = null;
                dgvLivresExemplairesListe.DataSource = bdgLivresExemplairesListe;
                return;
            }

            bdgLivresExemplairesListe.DataSource = exemplaires;
            dgvLivresExemplairesListe.DataSource = bdgLivresExemplairesListe;
            dgvLivresExemplairesListe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            if (dgvLivresExemplairesListe.Columns["Id"] != null) dgvLivresExemplairesListe.Columns["Id"].Visible = false;
            if (dgvLivresExemplairesListe.Columns["Photo"] != null) dgvLivresExemplairesListe.Columns["Photo"].Visible = false;
            if (dgvLivresExemplairesListe.Columns["IdEtat"] != null) dgvLivresExemplairesListe.Columns["IdEtat"].Visible = false;

            if (dgvLivresExemplairesListe.Columns["Numero"] != null) dgvLivresExemplairesListe.Columns["Numero"].DisplayIndex = 0;
            if (dgvLivresExemplairesListe.Columns["DateAchat"] != null) dgvLivresExemplairesListe.Columns["DateAchat"].DisplayIndex = 1;
            if (dgvLivresExemplairesListe.Columns["LibelleEtat"] != null) dgvLivresExemplairesListe.Columns["LibelleEtat"].DisplayIndex = 2;
        }

        /// <summary>
        /// Active ou désactive la zone de changement d'état (livres).
        /// </summary>
        /// <param name="actif">true pour activer</param>
        private void ActiverGestionEtatLivre(bool actif)
        {
            cbxLivresExemplaireEtat.Enabled = actif;
            btnLivresExemplaireModifierEtat.Enabled = actif;
            btnLivresExemplaireSupprimer.Enabled = actif;
            if (!actif)
            {
                cbxLivresExemplaireEtat.SelectedIndex = -1;
            }
        }

        private void dgvLivresExemplairesListe_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLivresExemplairesListe.CurrentCell == null || bdgLivresExemplairesListe.Position < 0)
            {
                ActiverGestionEtatLivre(false);
                return;
            }

            Exemplaire exemplaire = (Exemplaire)bdgLivresExemplairesListe.List[bdgLivresExemplairesListe.Position];
            Etat etat = lesEtatsLivres.Find(x => x.Id.Equals(exemplaire.IdEtat));
            if (etat != null)
            {
                cbxLivresExemplaireEtat.SelectedItem = etat;
            }
            else
            {
                cbxLivresExemplaireEtat.SelectedIndex = -1;
            }
            ActiverGestionEtatLivre(true);
        }

        private void dgvLivresExemplairesListe_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (lesLivresExemplaires == null || lesLivresExemplaires.Count == 0) return;

            string titreColonne = dgvLivresExemplairesListe.Columns[e.ColumnIndex].HeaderText;
            List<Exemplaire> sortedList = new List<Exemplaire>(lesLivresExemplaires);
            switch (titreColonne)
            {
                case "Numero":
                    sortedList = sortedList.OrderByDescending(o => o.Numero).ToList();
                    break;
                case "DateAchat":
                    sortedList = sortedList.OrderByDescending(o => o.DateAchat).ToList();
                    break;
                case "LibelleEtat":
                    sortedList = sortedList.OrderBy(o => o.LibelleEtat).ToList();
                    break;
            }
            RemplirLivresExemplairesListe(sortedList);
        }

        private void btnLivresExemplaireModifierEtat_Click(object sender, EventArgs e)
        {
            if (bdgLivresListe.Position < 0 || bdgLivresExemplairesListe.Position < 0 || cbxLivresExemplaireEtat.SelectedItem == null)
            {
                return;
            }
            Livre livre = (Livre)bdgLivresListe.List[bdgLivresListe.Position];
            Exemplaire exemplaire = (Exemplaire)bdgLivresExemplairesListe.List[bdgLivresExemplairesListe.Position];
            Etat etat = (Etat)cbxLivresExemplaireEtat.SelectedItem;

            bool ok = controller.ModifierEtatExemplaire(livre.Id, exemplaire.Numero, etat.Id);
            if (ok)
            {
                ChargerExemplairesLivreSelectionne(livre);
            }
            else
            {
                MessageBox.Show("Erreur lors de la modification de l'état.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLivresExemplaireSupprimer_Click(object sender, EventArgs e)
        {
            if (bdgLivresListe.Position < 0 || bdgLivresExemplairesListe.Position < 0)
            {
                MessageBox.Show("Veuillez sélectionner un exemplaire à supprimer.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Livre livre = (Livre)bdgLivresListe.List[bdgLivresListe.Position];
            Exemplaire exemplaire = (Exemplaire)bdgLivresExemplairesListe.List[bdgLivresExemplairesListe.Position];

            if (MessageBox.Show(
                "Êtes-vous sûr de vouloir supprimer l'exemplaire n°" + exemplaire.Numero + " ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            Access.ResultatSuppression resultat = controller.SupprimerExemplaire(livre.Id, exemplaire.Numero);
            switch (resultat)
            {
                case Access.ResultatSuppression.Succes:
                    MessageBox.Show("Exemplaire supprimé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ChargerExemplairesLivreSelectionne(livre);
                    break;
                case Access.ResultatSuppression.RefuseCommande:
                case Access.ResultatSuppression.Erreur:
                default:
                    MessageBox.Show("Erreur lors de la suppression de l'exemplaire.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
        #endregion

        #region Onglet Dvd
        private readonly BindingSource bdgDvdListe = new BindingSource();
        private readonly BindingSource bdgDvdExemplairesListe = new BindingSource();
        private List<Dvd> lesDvd = new List<Dvd>();
        private List<Exemplaire> lesDvdExemplaires = new List<Exemplaire>();
        private List<Etat> lesEtatsDvd = new List<Etat>();

        /// <summary>
        /// Ouverture de l'onglet Dvds : 
        /// appel des méthodes pour remplir le datagrid des dvd et des combos (genre, rayon, public)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabDvd_Enter(object sender, EventArgs e)
        {
            lesDvd = controller.GetAllDvd();
            RemplirComboCategorie(controller.GetAllGenres(), bdgGenres, cbxDvdGenres);
            RemplirComboCategorie(controller.GetAllPublics(), bdgPublics, cbxDvdPublics);
            RemplirComboCategorie(controller.GetAllRayons(), bdgRayons, cbxDvdRayons);
            lesEtatsDvd = controller.GetAllEtats();
            cbxDvdExemplaireEtat.DataSource = lesEtatsDvd;
            cbxDvdExemplaireEtat.SelectedIndex = -1;
            RemplirDvdListeComplete();
            RemplirDvdExemplairesListe(null);
            ActiverGestionEtatDvd(false);
        }

        /// <summary>
        /// Remplit le dategrid avec la liste reçue en paramètre
        /// </summary>
        /// <param name="Dvds">liste de dvd</param>
        private void RemplirDvdListe(List<Dvd> Dvds)
        {
            bdgDvdListe.DataSource = Dvds;
            dgvDvdListe.DataSource = bdgDvdListe;
            dgvDvdListe.Columns["idRayon"].Visible = false;
            dgvDvdListe.Columns["idGenre"].Visible = false;
            dgvDvdListe.Columns["idPublic"].Visible = false;
            dgvDvdListe.Columns["image"].Visible = false;
            dgvDvdListe.Columns["synopsis"].Visible = false;
            dgvDvdListe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDvdListe.Columns["id"].DisplayIndex = 0;
            dgvDvdListe.Columns["titre"].DisplayIndex = 1;
        }

        /// <summary>
        /// Recherche et affichage du Dvd dont on a saisi le numéro.
        /// Si non trouvé, affichage d'un MessageBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDvdNumRecherche_Click(object sender, EventArgs e)
        {
            if (!txbDvdNumRecherche.Text.Equals(""))
            {
                txbDvdTitreRecherche.Text = "";
                cbxDvdGenres.SelectedIndex = -1;
                cbxDvdRayons.SelectedIndex = -1;
                cbxDvdPublics.SelectedIndex = -1;
                Dvd dvd = lesDvd.Find(x => x.Id.Equals(txbDvdNumRecherche.Text));
                if (dvd != null)
                {
                    List<Dvd> Dvd = new List<Dvd>() { dvd };
                    RemplirDvdListe(Dvd);
                }
                else
                {
                    MessageBox.Show("numéro introuvable");
                    RemplirDvdListeComplete();
                }
            }
            else
            {
                RemplirDvdListeComplete();
            }
        }

        /// <summary>
        /// Recherche et affichage des Dvd dont le titre matche acec la saisie.
        /// Cette procédure est exécutée à chaque ajout ou suppression de caractère
        /// dans le textBox de saisie.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbDvdTitreRecherche_TextChanged(object sender, EventArgs e)
        {
            if (!txbDvdTitreRecherche.Text.Equals(""))
            {
                cbxDvdGenres.SelectedIndex = -1;
                cbxDvdRayons.SelectedIndex = -1;
                cbxDvdPublics.SelectedIndex = -1;
                txbDvdNumRecherche.Text = "";
                List<Dvd> lesDvdParTitre;
                lesDvdParTitre = lesDvd.FindAll(x => x.Titre.ToLower().Contains(txbDvdTitreRecherche.Text.ToLower()));
                RemplirDvdListe(lesDvdParTitre);
            }
            else
            {
                // si la zone de saisie est vide et aucun élément combo sélectionné, réaffichage de la liste complète
                if (cbxDvdGenres.SelectedIndex < 0 && cbxDvdPublics.SelectedIndex < 0 && cbxDvdRayons.SelectedIndex < 0
                    && txbDvdNumRecherche.Text.Equals(""))
                {
                    RemplirDvdListeComplete();
                }
            }
        }

        /// <summary>
        /// Affichage des informations du dvd sélectionné
        /// </summary>
        /// <param name="dvd">le dvd</param>
        private void AfficheDvdInfos(Dvd dvd)
        {
            txbDvdRealisateur.Text = dvd.Realisateur;
            txbDvdSynopsis.Text = dvd.Synopsis;
            txbDvdImage.Text = dvd.Image;
            txbDvdDuree.Text = dvd.Duree.ToString();
            txbDvdNumero.Text = dvd.Id;
            txbDvdGenre.Text = dvd.Genre;
            txbDvdPublic.Text = dvd.Public;
            txbDvdRayon.Text = dvd.Rayon;
            txbDvdTitre.Text = dvd.Titre;
            string image = dvd.Image;
            try
            {
                pcbDvdImage.Image = Image.FromFile(image);
            }
            catch
            {
                pcbDvdImage.Image = null;
            }
        }

        /// <summary>
        /// Vide les zones d'affichage des informations du dvd
        /// </summary>
        private void VideDvdInfos()
        {
            txbDvdRealisateur.Text = "";
            txbDvdSynopsis.Text = "";
            txbDvdImage.Text = "";
            txbDvdDuree.Text = "";
            txbDvdNumero.Text = "";
            txbDvdGenre.Text = "";
            txbDvdPublic.Text = "";
            txbDvdRayon.Text = "";
            txbDvdTitre.Text = "";
            pcbDvdImage.Image = null;
        }

        /// <summary>
        /// Filtre sur le genre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxDvdGenres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDvdGenres.SelectedIndex >= 0)
            {
                txbDvdTitreRecherche.Text = "";
                txbDvdNumRecherche.Text = "";
                Genre genre = (Genre)cbxDvdGenres.SelectedItem;
                List<Dvd> Dvd = lesDvd.FindAll(x => x.Genre.Equals(genre.Libelle));
                RemplirDvdListe(Dvd);
                cbxDvdRayons.SelectedIndex = -1;
                cbxDvdPublics.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Filtre sur la catégorie de public
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxDvdPublics_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDvdPublics.SelectedIndex >= 0)
            {
                txbDvdTitreRecherche.Text = "";
                txbDvdNumRecherche.Text = "";
                Public lePublic = (Public)cbxDvdPublics.SelectedItem;
                List<Dvd> Dvd = lesDvd.FindAll(x => x.Public.Equals(lePublic.Libelle));
                RemplirDvdListe(Dvd);
                cbxDvdRayons.SelectedIndex = -1;
                cbxDvdGenres.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Filtre sur le rayon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxDvdRayons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDvdRayons.SelectedIndex >= 0)
            {
                txbDvdTitreRecherche.Text = "";
                txbDvdNumRecherche.Text = "";
                Rayon rayon = (Rayon)cbxDvdRayons.SelectedItem;
                List<Dvd> Dvd = lesDvd.FindAll(x => x.Rayon.Equals(rayon.Libelle));
                RemplirDvdListe(Dvd);
                cbxDvdGenres.SelectedIndex = -1;
                cbxDvdPublics.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Sur la sélection d'une ligne ou cellule dans le grid
        /// affichage des informations du dvd
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDvdListe_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDvdListe.CurrentCell != null)
            {
                btnModifierDvd.Enabled = true;
                btnSupprimerDvd.Enabled = true;
                try
                {
                    Dvd dvd = (Dvd)bdgDvdListe.List[bdgDvdListe.Position];
                    AfficheDvdInfos(dvd);
                    ChargerExemplairesDvdSelectionne(dvd);
                }
                catch
                {
                    VideDvdInfos();
                    btnModifierDvd.Enabled = false;
                    btnSupprimerDvd.Enabled = false;
                    RemplirDvdExemplairesListe(null);
                    ActiverGestionEtatDvd(false);
                }
            }
            else
            {
                VideDvdInfos();
                btnModifierDvd.Enabled = false;
                btnSupprimerDvd.Enabled = false;
                RemplirDvdExemplairesListe(null);
                ActiverGestionEtatDvd(false);
            }
        }

        /// <summary>
        /// Sur le clic du bouton d'annulation, affichage de la liste complète des Dvd
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDvdAnnulPublics_Click(object sender, EventArgs e)
        {
            RemplirDvdListeComplete();
        }

        /// <summary>
        /// Sur le clic du bouton d'annulation, affichage de la liste complète des Dvd
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDvdAnnulRayons_Click(object sender, EventArgs e)
        {
            RemplirDvdListeComplete();
        }

        /// <summary>
        /// Sur le clic du bouton d'annulation, affichage de la liste complète des Dvd
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDvdAnnulGenres_Click(object sender, EventArgs e)
        {
            RemplirDvdListeComplete();
        }

        /// <summary>
        /// Affichage de la liste complète des Dvd
        /// et annulation de toutes les recherches et filtres
        /// </summary>
        private void RemplirDvdListeComplete()
        {
            RemplirDvdListe(lesDvd);
            VideDvdZones();
        }

        /// <summary>
        /// vide les zones de recherche et de filtre
        /// </summary>
        private void VideDvdZones()
        {
            cbxDvdGenres.SelectedIndex = -1;
            cbxDvdRayons.SelectedIndex = -1;
            cbxDvdPublics.SelectedIndex = -1;
            txbDvdNumRecherche.Text = "";
            txbDvdTitreRecherche.Text = "";
        }

        /// <summary>
        /// Tri sur les colonnes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDvdListe_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            VideDvdZones();
            string titreColonne = dgvDvdListe.Columns[e.ColumnIndex].HeaderText;
            List<Dvd> sortedList = new List<Dvd>();
            switch (titreColonne)
            {
                case "Id":
                    sortedList = lesDvd.OrderBy(o => o.Id).ToList();
                    break;
                case "Titre":
                    sortedList = lesDvd.OrderBy(o => o.Titre).ToList();
                    break;
                case "Duree":
                    sortedList = lesDvd.OrderBy(o => o.Duree).ToList();
                    break;
                case "Realisateur":
                    sortedList = lesDvd.OrderBy(o => o.Realisateur).ToList();
                    break;
                case "Genre":
                    sortedList = lesDvd.OrderBy(o => o.Genre).ToList();
                    break;
                case "Public":
                    sortedList = lesDvd.OrderBy(o => o.Public).ToList();
                    break;
                case "Rayon":
                    sortedList = lesDvd.OrderBy(o => o.Rayon).ToList();
                    break;
            }
            RemplirDvdListe(sortedList);
        }

        /// <summary>
        /// Charge les exemplaires du DVD sélectionné.
        /// </summary>
        /// <param name="dvd">DVD sélectionné</param>
        private void ChargerExemplairesDvdSelectionne(Dvd dvd)
        {
            lesDvdExemplaires = controller.GetExemplairesDocument(dvd.Id);
            RemplirDvdExemplairesListe(lesDvdExemplaires.OrderByDescending(x => x.DateAchat).ToList());
            ActiverGestionEtatDvd(false);
        }

        /// <summary>
        /// Remplit la liste des exemplaires de DVD.
        /// </summary>
        /// <param name="exemplaires">Liste d'exemplaires</param>
        private void RemplirDvdExemplairesListe(List<Exemplaire> exemplaires)
        {
            if (exemplaires == null)
            {
                bdgDvdExemplairesListe.DataSource = null;
                dgvDvdExemplairesListe.DataSource = bdgDvdExemplairesListe;
                return;
            }

            bdgDvdExemplairesListe.DataSource = exemplaires;
            dgvDvdExemplairesListe.DataSource = bdgDvdExemplairesListe;
            dgvDvdExemplairesListe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            if (dgvDvdExemplairesListe.Columns["Id"] != null) dgvDvdExemplairesListe.Columns["Id"].Visible = false;
            if (dgvDvdExemplairesListe.Columns["Photo"] != null) dgvDvdExemplairesListe.Columns["Photo"].Visible = false;
            if (dgvDvdExemplairesListe.Columns["IdEtat"] != null) dgvDvdExemplairesListe.Columns["IdEtat"].Visible = false;

            if (dgvDvdExemplairesListe.Columns["Numero"] != null) dgvDvdExemplairesListe.Columns["Numero"].DisplayIndex = 0;
            if (dgvDvdExemplairesListe.Columns["DateAchat"] != null) dgvDvdExemplairesListe.Columns["DateAchat"].DisplayIndex = 1;
            if (dgvDvdExemplairesListe.Columns["LibelleEtat"] != null) dgvDvdExemplairesListe.Columns["LibelleEtat"].DisplayIndex = 2;
        }

        /// <summary>
        /// Active ou désactive la zone de changement d'état (DVD).
        /// </summary>
        /// <param name="actif">true pour activer</param>
        private void ActiverGestionEtatDvd(bool actif)
        {
            cbxDvdExemplaireEtat.Enabled = actif;
            btnDvdExemplaireModifierEtat.Enabled = actif;
            btnDvdExemplaireSupprimer.Enabled = actif;
            if (!actif)
            {
                cbxDvdExemplaireEtat.SelectedIndex = -1;
            }
        }

        private void dgvDvdExemplairesListe_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDvdExemplairesListe.CurrentCell == null || bdgDvdExemplairesListe.Position < 0)
            {
                ActiverGestionEtatDvd(false);
                return;
            }

            Exemplaire exemplaire = (Exemplaire)bdgDvdExemplairesListe.List[bdgDvdExemplairesListe.Position];
            Etat etat = lesEtatsDvd.Find(x => x.Id.Equals(exemplaire.IdEtat));
            if (etat != null)
            {
                cbxDvdExemplaireEtat.SelectedItem = etat;
            }
            else
            {
                cbxDvdExemplaireEtat.SelectedIndex = -1;
            }
            ActiverGestionEtatDvd(true);
        }

        private void dgvDvdExemplairesListe_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (lesDvdExemplaires == null || lesDvdExemplaires.Count == 0) return;

            string titreColonne = dgvDvdExemplairesListe.Columns[e.ColumnIndex].HeaderText;
            List<Exemplaire> sortedList = new List<Exemplaire>(lesDvdExemplaires);
            switch (titreColonne)
            {
                case "Numero":
                    sortedList = sortedList.OrderByDescending(o => o.Numero).ToList();
                    break;
                case "DateAchat":
                    sortedList = sortedList.OrderByDescending(o => o.DateAchat).ToList();
                    break;
                case "LibelleEtat":
                    sortedList = sortedList.OrderBy(o => o.LibelleEtat).ToList();
                    break;
            }
            RemplirDvdExemplairesListe(sortedList);
        }

        private void btnDvdExemplaireModifierEtat_Click(object sender, EventArgs e)
        {
            if (bdgDvdListe.Position < 0 || bdgDvdExemplairesListe.Position < 0 || cbxDvdExemplaireEtat.SelectedItem == null)
            {
                return;
            }
            Dvd dvd = (Dvd)bdgDvdListe.List[bdgDvdListe.Position];
            Exemplaire exemplaire = (Exemplaire)bdgDvdExemplairesListe.List[bdgDvdExemplairesListe.Position];
            Etat etat = (Etat)cbxDvdExemplaireEtat.SelectedItem;

            bool ok = controller.ModifierEtatExemplaire(dvd.Id, exemplaire.Numero, etat.Id);
            if (ok)
            {
                ChargerExemplairesDvdSelectionne(dvd);
            }
            else
            {
                MessageBox.Show("Erreur lors de la modification de l'état.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDvdExemplaireSupprimer_Click(object sender, EventArgs e)
        {
            if (bdgDvdListe.Position < 0 || bdgDvdExemplairesListe.Position < 0)
            {
                MessageBox.Show("Veuillez sélectionner un exemplaire à supprimer.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Dvd dvd = (Dvd)bdgDvdListe.List[bdgDvdListe.Position];
            Exemplaire exemplaire = (Exemplaire)bdgDvdExemplairesListe.List[bdgDvdExemplairesListe.Position];

            if (MessageBox.Show(
                "Êtes-vous sûr de vouloir supprimer l'exemplaire n°" + exemplaire.Numero + " ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            Access.ResultatSuppression resultat = controller.SupprimerExemplaire(dvd.Id, exemplaire.Numero);
            switch (resultat)
            {
                case Access.ResultatSuppression.Succes:
                    MessageBox.Show("Exemplaire supprimé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ChargerExemplairesDvdSelectionne(dvd);
                    break;
                case Access.ResultatSuppression.RefuseCommande:
                case Access.ResultatSuppression.Erreur:
                default:
                    MessageBox.Show("Erreur lors de la suppression de l'exemplaire.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        /// <summary>
        /// Modification du DVD sélectionné : ouvre le formulaire prérempli puis PUT vers l'API
        /// </summary>
        private void btnModifierDvd_Click(object sender, EventArgs e)
        {
            if (bdgDvdListe.Current == null)
            {
                MessageBox.Show("Veuillez sélectionner un DVD à modifier.");
                return;
            }

            Dvd dvdSelectionne = (Dvd)bdgDvdListe.Current;

            FrmAjoutDvd frm = new FrmAjoutDvd(
                controller.GetAllGenres(),
                controller.GetAllPublics(),
                controller.GetAllRayons(),
                dvdSelectionne
            );

            if (frm.ShowDialog() == DialogResult.OK)
            {
                Categorie genre = frm.GenreSelectionne;
                Categorie lePublic = frm.PublicSelectionne;
                Categorie rayon = frm.RayonSelectionne;

                Dvd dvdModifie = new Dvd(
                    dvdSelectionne.Id,
                    frm.TitreDvd,
                    dvdSelectionne.Image ?? "",
                    frm.DureeDvd,
                    frm.RealisateurDvd,
                    frm.SynopsisDvd,
                    genre.Id,
                    genre.Libelle,
                    lePublic.Id,
                    lePublic.Libelle,
                    rayon.Id,
                    rayon.Libelle
                );

                bool ok = controller.ModifierDvd(dvdModifie);

                if (ok)
                {
                    MessageBox.Show("DVD modifié avec succès.");
                    lesDvd = new List<Dvd>(controller.GetAllDvd());
                    VideDvdZones();
                    RemplirDvdListe(lesDvd);
                    dgvDvdListe.Refresh();
                }
                else
                {
                    MessageBox.Show("Erreur lors de la modification du DVD.");
                }
            }
        }

        /// <summary>
        /// Suppression du DVD sélectionné : confirmation puis DELETE vers l'API
        /// </summary>
        private void btnSupprimerDvd_Click(object sender, EventArgs e)
        {
            if (bdgDvdListe.Current == null)
            {
                MessageBox.Show("Veuillez sélectionner un DVD à supprimer.");
                return;
            }

            Dvd dvdSelectionne = (Dvd)bdgDvdListe.Current;

            DialogResult confirmation = MessageBox.Show(
                "Êtes-vous sûr de vouloir supprimer le DVD \"" + dvdSelectionne.Titre + "\" ?",
                "Confirmer la suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmation != DialogResult.Yes)
                return;

            Access.ResultatSuppression resultat = controller.SupprimerDvd(dvdSelectionne.Id);

            switch (resultat)
            {
                case Access.ResultatSuppression.Succes:
                    MessageBox.Show("DVD supprimé avec succès.");
                    lesDvd = new List<Dvd>(controller.GetAllDvd());
                    VideDvdZones();
                    RemplirDvdListe(lesDvd);
                    dgvDvdListe.Refresh();
                    break;
                case Access.ResultatSuppression.RefuseCommande:
                    MessageBox.Show(
                        "Ce DVD ne peut pas être supprimé car il possède des commandes rattachées.",
                        "Suppression refusée",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    break;
                case Access.ResultatSuppression.Erreur:
                default:
                    MessageBox.Show(
                        "Erreur technique lors de la suppression du DVD.",
                        "Erreur",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    break;
            }
        }

        /// <summary>
        /// Ajout d'un DVD : ouvre le formulaire de saisie puis POST vers l'API
        /// </summary>
        private void btnAjouterDvd_Click(object sender, EventArgs e)
        {
            FrmAjoutDvd frm = new FrmAjoutDvd(
                controller.GetAllGenres(),
                controller.GetAllPublics(),
                controller.GetAllRayons()
            );

            if (frm.ShowDialog() == DialogResult.OK)
            {
                Categorie genre = frm.GenreSelectionne;
                Categorie lePublic = frm.PublicSelectionne;
                Categorie rayon = frm.RayonSelectionne;

                Dvd dvd = new Dvd(
                    frm.IdDvd,
                    frm.TitreDvd,
                    "",
                    frm.DureeDvd,
                    frm.RealisateurDvd,
                    frm.SynopsisDvd,
                    genre.Id,
                    genre.Libelle,
                    lePublic.Id,
                    lePublic.Libelle,
                    rayon.Id,
                    rayon.Libelle
                );

                bool ok = controller.CreerDvd(dvd);

                if (ok)
                {
                    MessageBox.Show("DVD ajouté avec succès.");
                    lesDvd = new List<Dvd>(controller.GetAllDvd());
                    VideDvdZones();
                    RemplirDvdListe(lesDvd);
                    dgvDvdListe.Refresh();
                }
                else
                {
                    MessageBox.Show("Erreur lors de l'ajout du DVD.");
                }
            }
        }
        #endregion

        #region Onglet Revues
        private readonly BindingSource bdgRevuesListe = new BindingSource();
        private List<Revue> lesRevues = new List<Revue>();

        /// <summary>
        /// Ouverture de l'onglet Revues : 
        /// appel des méthodes pour remplir le datagrid des revues et des combos (genre, rayon, public)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabRevues_Enter(object sender, EventArgs e)
        {
            lesRevues = controller.GetAllRevues();
            RemplirComboCategorie(controller.GetAllGenres(), bdgGenres, cbxRevuesGenres);
            RemplirComboCategorie(controller.GetAllPublics(), bdgPublics, cbxRevuesPublics);
            RemplirComboCategorie(controller.GetAllRayons(), bdgRayons, cbxRevuesRayons);
            RemplirRevuesListeComplete();
        }

        /// <summary>
        /// Remplit le dategrid avec la liste reçue en paramètre
        /// </summary>
        /// <param name="revues"></param>
        private void RemplirRevuesListe(List<Revue> revues)
        {
            bdgRevuesListe.DataSource = revues;
            dgvRevuesListe.DataSource = bdgRevuesListe;
            dgvRevuesListe.Columns["idRayon"].Visible = false;
            dgvRevuesListe.Columns["idGenre"].Visible = false;
            dgvRevuesListe.Columns["idPublic"].Visible = false;
            dgvRevuesListe.Columns["image"].Visible = false;
            dgvRevuesListe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvRevuesListe.Columns["id"].DisplayIndex = 0;
            dgvRevuesListe.Columns["titre"].DisplayIndex = 1;
        }

        /// <summary>
        /// Recherche et affichage de la revue dont on a saisi le numéro.
        /// Si non trouvé, affichage d'un MessageBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRevuesNumRecherche_Click(object sender, EventArgs e)
        {
            if (!txbRevuesNumRecherche.Text.Equals(""))
            {
                txbRevuesTitreRecherche.Text = "";
                cbxRevuesGenres.SelectedIndex = -1;
                cbxRevuesRayons.SelectedIndex = -1;
                cbxRevuesPublics.SelectedIndex = -1;
                Revue revue = lesRevues.Find(x => x.Id.Equals(txbRevuesNumRecherche.Text));
                if (revue != null)
                {
                    List<Revue> revues = new List<Revue>() { revue };
                    RemplirRevuesListe(revues);
                }
                else
                {
                    MessageBox.Show("numéro introuvable");
                    RemplirRevuesListeComplete();
                }
            }
            else
            {
                RemplirRevuesListeComplete();
            }
        }

        /// <summary>
        /// Recherche et affichage des revues dont le titre matche acec la saisie.
        /// Cette procédure est exécutée à chaque ajout ou suppression de caractère
        /// dans le textBox de saisie.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbRevuesTitreRecherche_TextChanged(object sender, EventArgs e)
        {
            if (!txbRevuesTitreRecherche.Text.Equals(""))
            {
                cbxRevuesGenres.SelectedIndex = -1;
                cbxRevuesRayons.SelectedIndex = -1;
                cbxRevuesPublics.SelectedIndex = -1;
                txbRevuesNumRecherche.Text = "";
                List<Revue> lesRevuesParTitre;
                lesRevuesParTitre = lesRevues.FindAll(x => x.Titre.ToLower().Contains(txbRevuesTitreRecherche.Text.ToLower()));
                RemplirRevuesListe(lesRevuesParTitre);
            }
            else
            {
                // si la zone de saisie est vide et aucun élément combo sélectionné, réaffichage de la liste complète
                if (cbxRevuesGenres.SelectedIndex < 0 && cbxRevuesPublics.SelectedIndex < 0 && cbxRevuesRayons.SelectedIndex < 0
                    && txbRevuesNumRecherche.Text.Equals(""))
                {
                    RemplirRevuesListeComplete();
                }
            }
        }

        /// <summary>
        /// Affichage des informations de la revue sélectionné
        /// </summary>
        /// <param name="revue">la revue</param>
        private void AfficheRevuesInfos(Revue revue)
        {
            txbRevuesPeriodicite.Text = revue.Periodicite;
            txbRevuesImage.Text = revue.Image;
            txbRevuesDateMiseADispo.Text = revue.DelaiMiseADispo.ToString();
            txbRevuesNumero.Text = revue.Id;
            txbRevuesGenre.Text = revue.Genre;
            txbRevuesPublic.Text = revue.Public;
            txbRevuesRayon.Text = revue.Rayon;
            txbRevuesTitre.Text = revue.Titre;
            string image = revue.Image;
            try
            {
                pcbRevuesImage.Image = Image.FromFile(image);
            }
            catch
            {
                pcbRevuesImage.Image = null;
            }
        }

        /// <summary>
        /// Vide les zones d'affichage des informations de la reuve
        /// </summary>
        private void VideRevuesInfos()
        {
            txbRevuesPeriodicite.Text = "";
            txbRevuesImage.Text = "";
            txbRevuesDateMiseADispo.Text = "";
            txbRevuesNumero.Text = "";
            txbRevuesGenre.Text = "";
            txbRevuesPublic.Text = "";
            txbRevuesRayon.Text = "";
            txbRevuesTitre.Text = "";
            pcbRevuesImage.Image = null;
        }

        /// <summary>
        /// Filtre sur le genre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxRevuesGenres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxRevuesGenres.SelectedIndex >= 0)
            {
                txbRevuesTitreRecherche.Text = "";
                txbRevuesNumRecherche.Text = "";
                Genre genre = (Genre)cbxRevuesGenres.SelectedItem;
                List<Revue> revues = lesRevues.FindAll(x => x.Genre.Equals(genre.Libelle));
                RemplirRevuesListe(revues);
                cbxRevuesRayons.SelectedIndex = -1;
                cbxRevuesPublics.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Filtre sur la catégorie de public
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxRevuesPublics_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxRevuesPublics.SelectedIndex >= 0)
            {
                txbRevuesTitreRecherche.Text = "";
                txbRevuesNumRecherche.Text = "";
                Public lePublic = (Public)cbxRevuesPublics.SelectedItem;
                List<Revue> revues = lesRevues.FindAll(x => x.Public.Equals(lePublic.Libelle));
                RemplirRevuesListe(revues);
                cbxRevuesRayons.SelectedIndex = -1;
                cbxRevuesGenres.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Filtre sur le rayon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxRevuesRayons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxRevuesRayons.SelectedIndex >= 0)
            {
                txbRevuesTitreRecherche.Text = "";
                txbRevuesNumRecherche.Text = "";
                Rayon rayon = (Rayon)cbxRevuesRayons.SelectedItem;
                List<Revue> revues = lesRevues.FindAll(x => x.Rayon.Equals(rayon.Libelle));
                RemplirRevuesListe(revues);
                cbxRevuesGenres.SelectedIndex = -1;
                cbxRevuesPublics.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Sur la sélection d'une ligne ou cellule dans le grid
        /// affichage des informations de la revue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvRevuesListe_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRevuesListe.CurrentCell != null)
            {
                btnModifierRevue.Enabled = true;
                btnSupprimerRevue.Enabled = true;
                try
                {
                    Revue revue = (Revue)bdgRevuesListe.List[bdgRevuesListe.Position];
                    AfficheRevuesInfos(revue);
                }
                catch
                {
                    VideRevuesZones();
                    btnModifierRevue.Enabled = false;
                    btnSupprimerRevue.Enabled = false;
                }
            }
            else
            {
                VideRevuesInfos();
                btnModifierRevue.Enabled = false;
                btnSupprimerRevue.Enabled = false;
            }
        }

        /// <summary>
        /// Sur le clic du bouton d'annulation, affichage de la liste complète des revues
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRevuesAnnulPublics_Click(object sender, EventArgs e)
        {
            RemplirRevuesListeComplete();
        }

        /// <summary>
        /// Sur le clic du bouton d'annulation, affichage de la liste complète des revues
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRevuesAnnulRayons_Click(object sender, EventArgs e)
        {
            RemplirRevuesListeComplete();
        }

        /// <summary>
        /// Sur le clic du bouton d'annulation, affichage de la liste complète des revues
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRevuesAnnulGenres_Click(object sender, EventArgs e)
        {
            RemplirRevuesListeComplete();
        }

        /// <summary>
        /// Affichage de la liste complète des revues
        /// et annulation de toutes les recherches et filtres
        /// </summary>
        private void RemplirRevuesListeComplete()
        {
            RemplirRevuesListe(lesRevues);
            VideRevuesZones();
        }

        /// <summary>
        /// vide les zones de recherche et de filtre
        /// </summary>
        private void VideRevuesZones()
        {
            cbxRevuesGenres.SelectedIndex = -1;
            cbxRevuesRayons.SelectedIndex = -1;
            cbxRevuesPublics.SelectedIndex = -1;
            txbRevuesNumRecherche.Text = "";
            txbRevuesTitreRecherche.Text = "";
        }

        /// <summary>
        /// Tri sur les colonnes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvRevuesListe_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            VideRevuesZones();
            string titreColonne = dgvRevuesListe.Columns[e.ColumnIndex].HeaderText;
            List<Revue> sortedList = new List<Revue>();
            switch (titreColonne)
            {
                case "Id":
                    sortedList = lesRevues.OrderBy(o => o.Id).ToList();
                    break;
                case "Titre":
                    sortedList = lesRevues.OrderBy(o => o.Titre).ToList();
                    break;
                case "Periodicite":
                    sortedList = lesRevues.OrderBy(o => o.Periodicite).ToList();
                    break;
                case "DelaiMiseADispo":
                    sortedList = lesRevues.OrderBy(o => o.DelaiMiseADispo).ToList();
                    break;
                case "Genre":
                    sortedList = lesRevues.OrderBy(o => o.Genre).ToList();
                    break;
                case "Public":
                    sortedList = lesRevues.OrderBy(o => o.Public).ToList();
                    break;
                case "Rayon":
                    sortedList = lesRevues.OrderBy(o => o.Rayon).ToList();
                    break;
            }
            RemplirRevuesListe(sortedList);
        }

        /// <summary>
        /// Suppression de la revue sélectionnée : confirmation puis DELETE vers l'API
        /// </summary>
        private void btnSupprimerRevue_Click(object sender, EventArgs e)
        {
            if (bdgRevuesListe.Current == null)
            {
                MessageBox.Show("Veuillez sélectionner une revue à supprimer.");
                return;
            }

            Revue revueSelectionnee = (Revue)bdgRevuesListe.Current;

            DialogResult confirmation = MessageBox.Show(
                "Êtes-vous sûr de vouloir supprimer la revue \"" + revueSelectionnee.Titre + "\" ?",
                "Confirmer la suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmation != DialogResult.Yes)
                return;

            Access.ResultatSuppression resultat = controller.SupprimerRevue(revueSelectionnee.Id);

            switch (resultat)
            {
                case Access.ResultatSuppression.Succes:
                    MessageBox.Show("Revue supprimée avec succès.");
                    lesRevues = new List<Revue>(controller.GetAllRevues());
                    VideRevuesZones();
                    RemplirRevuesListe(lesRevues);
                    dgvRevuesListe.Refresh();
                    break;
                case Access.ResultatSuppression.RefuseCommande:
                    MessageBox.Show(
                        "Cette revue ne peut pas être supprimée car elle possède des exemplaires.",
                        "Suppression refusée",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    break;
                case Access.ResultatSuppression.Erreur:
                default:
                    MessageBox.Show(
                        "Erreur technique lors de la suppression de la revue.",
                        "Erreur",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    break;
            }
        }

        /// <summary>
        /// Modification de la revue sélectionnée : ouvre le formulaire prérempli puis PUT vers l'API
        /// </summary>
        private void btnModifierRevue_Click(object sender, EventArgs e)
        {
            if (bdgRevuesListe.Current == null)
            {
                MessageBox.Show("Veuillez sélectionner une revue à modifier.");
                return;
            }

            Revue revueSelectionnee = (Revue)bdgRevuesListe.Current;

            FrmAjoutRevue frm = new FrmAjoutRevue(
                controller.GetAllGenres(),
                controller.GetAllPublics(),
                controller.GetAllRayons(),
                revueSelectionnee
            );

            if (frm.ShowDialog() == DialogResult.OK)
            {
                Categorie genre = frm.GenreSelectionne;
                Categorie lePublic = frm.PublicSelectionne;
                Categorie rayon = frm.RayonSelectionne;

                Revue revueModifiee = new Revue(
                    revueSelectionnee.Id,
                    frm.TitreRevue,
                    revueSelectionnee.Image ?? "",
                    genre.Id,
                    genre.Libelle,
                    lePublic.Id,
                    lePublic.Libelle,
                    rayon.Id,
                    rayon.Libelle,
                    frm.PeriodiciteRevue,
                    frm.DelaiMiseADispoRevue
                );

                bool ok = controller.ModifierRevue(revueModifiee);

                if (ok)
                {
                    MessageBox.Show("Revue modifiée avec succès.");
                    lesRevues = new List<Revue>(controller.GetAllRevues());
                    VideRevuesZones();
                    RemplirRevuesListe(lesRevues);
                    dgvRevuesListe.Refresh();
                }
                else
                {
                    MessageBox.Show("Erreur lors de la modification de la revue.");
                }
            }
        }

        /// <summary>
        /// Ajout d'une revue : ouvre le formulaire de saisie puis POST vers l'API
        /// </summary>
        private void btnAjouterRevue_Click(object sender, EventArgs e)
        {
            FrmAjoutRevue frm = new FrmAjoutRevue(
                controller.GetAllGenres(),
                controller.GetAllPublics(),
                controller.GetAllRayons()
            );

            if (frm.ShowDialog() == DialogResult.OK)
            {
                Categorie genre = frm.GenreSelectionne;
                Categorie lePublic = frm.PublicSelectionne;
                Categorie rayon = frm.RayonSelectionne;

                Revue revue = new Revue(
                    frm.IdRevue,
                    frm.TitreRevue,
                    "",
                    genre.Id,
                    genre.Libelle,
                    lePublic.Id,
                    lePublic.Libelle,
                    rayon.Id,
                    rayon.Libelle,
                    frm.PeriodiciteRevue,
                    frm.DelaiMiseADispoRevue
                );

                bool ok = controller.CreerRevue(revue);

                if (ok)
                {
                    MessageBox.Show("Revue ajoutée avec succès.");
                    lesRevues = new List<Revue>(controller.GetAllRevues());
                    VideRevuesZones();
                    RemplirRevuesListe(lesRevues);
                    dgvRevuesListe.Refresh();
                }
                else
                {
                    MessageBox.Show("Erreur lors de l'ajout de la revue.");
                }
            }
        }
        #endregion

        #region Onglet Commandes Livres
        private readonly BindingSource bdgCommandesLivresListe = new BindingSource();
        private List<Livre> lesLivresCommandes = new List<Livre>();

        private static readonly (string Id, string Libelle)[] Suivis = new[]
        {
            ("00001", "en cours"),
            ("00002", "relancée"),
            ("00003", "livrée"),
            ("00004", "réglée")
        };

        /// <summary>
        /// Ouverture de l'onglet Commandes Livres : récupère les livres et vide les champs.
        /// </summary>
        private void tabCommandesLivres_Enter(object sender, EventArgs e)
        {
            lesLivresCommandes = controller.GetAllLivres();
            VideCommandesLivresZones();
            RemplirComboSuiviValeurs();
        }

        /// <summary>
        /// Vide les zones de l'onglet Commandes Livres.
        /// </summary>
        private void VideCommandesLivresZones()
        {
            txbCommandesLivresNumero.Text = "";
            txbCommandesLivresTitre.Text = "";
            txbCommandesLivresGenre.Text = "";
            txbCommandesLivresPublic.Text = "";
            txbCommandesLivresRayon.Text = "";
            VideCommandesLivresNouvelleCommande();
            RemplirCommandesLivresListe(new List<CommandeDocument>());
            cmbCommandesLivresSuivi.DataSource = null;
            cmbCommandesLivresSuivi.Enabled = false;
            btnModifierSuiviCommande.Enabled = false;
            btnSupprimerCommande.Enabled = false;
        }

        /// <summary>
        /// Remplit le ComboBox des suivi avec les valeurs connues (00001 à 00004).
        /// </summary>
        private void RemplirComboSuiviValeurs()
        {
            cmbCommandesLivresSuivi.DisplayMember = "Libelle";
            cmbCommandesLivresSuivi.ValueMember = "Id";
            cmbCommandesLivresSuivi.DataSource = Suivis.Select(s => new { s.Id, s.Libelle }).ToList();
        }

        /// <summary>
        /// Vide les champs du groupbox "Nouvelle commande".
        /// </summary>
        private void VideCommandesLivresNouvelleCommande()
        {
            dtpCommandesLivresDateCommande.Value = DateTime.Now;
            txbCommandesLivresMontant.Text = "";
            txbCommandesLivresNbExemplaire.Text = "";
        }

        /// <summary>
        /// Si le numéro de document est modifié, les infos et la liste des commandes sont effacées.
        /// </summary>
        private void txbCommandesLivresNumero_TextChanged(object sender, EventArgs e)
        {
            txbCommandesLivresTitre.Text = "";
            txbCommandesLivresGenre.Text = "";
            txbCommandesLivresPublic.Text = "";
            txbCommandesLivresRayon.Text = "";
            RemplirCommandesLivresListe(new List<CommandeDocument>());
        }

        /// <summary>
        /// Recherche d'un livre par numéro, affichage des infos et de la liste des commandes.
        /// </summary>
        private void btnCommandesLivresRechercher_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbCommandesLivresNumero.Text))
                return;

            Livre livre = lesLivresCommandes.Find(x => x.Id.Equals(txbCommandesLivresNumero.Text.Trim()));
            if (livre != null)
            {
                AfficheCommandesLivresInfos(livre);
            }
            else
            {
                MessageBox.Show("numéro introuvable");
                VideCommandesLivresZones();
            }
        }

        /// <summary>
        /// Affiche les informations du livre sélectionné et charge ses commandes.
        /// </summary>
        /// <param name="livre">Le livre</param>
        private void AfficheCommandesLivresInfos(Livre livre)
        {
            txbCommandesLivresNumero.Text = livre.Id;
            txbCommandesLivresTitre.Text = livre.Titre;
            txbCommandesLivresGenre.Text = livre.Genre;
            txbCommandesLivresPublic.Text = livre.Public;
            txbCommandesLivresRayon.Text = livre.Rayon;

            List<CommandeDocument> commandes = controller.GetCommandesDocument(livre.Id);
            commandes = commandes.OrderByDescending(c => c.DateCommande).ToList();
            RemplirCommandesLivresListe(commandes);
        }

        /// <summary>
        /// Remplit le DataGridView des commandes avec la liste reçue.
        /// </summary>
        /// <param name="commandes">Liste des commandes (triée par date DESC)</param>
        private void RemplirCommandesLivresListe(List<CommandeDocument> commandes)
        {
            bdgCommandesLivresListe.DataSource = commandes;
            dgvCommandesLivres.DataSource = bdgCommandesLivresListe;
            if (dgvCommandesLivres.Columns.Contains("Id"))
                dgvCommandesLivres.Columns["Id"].Visible = false;
            if (dgvCommandesLivres.Columns.Contains("IdLivreDvd"))
                dgvCommandesLivres.Columns["IdLivreDvd"].Visible = false;
            if (dgvCommandesLivres.Columns.Contains("IdSuivi"))
                dgvCommandesLivres.Columns["IdSuivi"].Visible = false;
            dgvCommandesLivres.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// Tri des colonnes de la liste des commandes de livres.
        /// </summary>
        private void dgvCommandesLivres_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var commandesActuelles = bdgCommandesLivresListe.List?.Cast<CommandeDocument>().ToList();
            if (commandesActuelles == null || commandesActuelles.Count == 0)
            {
                return;
            }

            string titreColonne = dgvCommandesLivres.Columns[e.ColumnIndex].HeaderText;
            List<CommandeDocument> sortedList;

            switch (titreColonne)
            {
                case "DateCommande":
                    // Du plus récent au plus ancien
                    sortedList = commandesActuelles
                        .OrderByDescending(c => c.DateCommande)
                        .ToList();
                    break;
                case "Montant":
                    sortedList = commandesActuelles
                        .OrderBy(c => c.Montant)
                        .ToList();
                    break;
                case "NbExemplaire":
                    sortedList = commandesActuelles
                        .OrderBy(c => c.NbExemplaire)
                        .ToList();
                    break;
                case "Suivi":
                    sortedList = commandesActuelles
                        .OrderBy(c => c.Suivi)
                        .ToList();
                    break;
                default:
                    // Colonne non gérée : ne rien faire
                    return;
            }

            RemplirCommandesLivresListe(sortedList);
        }

        /// <summary>
        /// Retourne les transitions de suivi autorisées selon les règles métier.
        /// - Livrée ou réglée : ne peut pas revenir en arrière.
        /// - Réglée : uniquement depuis livrée.
        /// </summary>
        private static string[] GetTransitionsSuiviAutorisees(string idSuiviActuel)
        {
            if (string.IsNullOrEmpty(idSuiviActuel)) return new string[0];
            switch (idSuiviActuel)
            {
                case "00001": return new[] { "00002", "00003" }; // en cours -> relancée, livrée
                case "00002": return new[] { "00001", "00003" }; // relancée -> en cours, livrée
                case "00003": return new[] { "00004" };          // livrée -> réglée
                case "00004": return new string[0];              // réglée -> aucune
                default: return new string[0];
            }
        }

        /// <summary>
        /// Sélection d'une commande : affiche le suivi actuel et les transitions possibles.
        /// </summary>
        private void dgvCommandesLivres_SelectionChanged(object sender, EventArgs e)
        {
            CommandeDocument cmd = dgvCommandesLivres.SelectedRows.Count > 0 ? dgvCommandesLivres.SelectedRows[0].DataBoundItem as CommandeDocument : null;
            if (cmd == null)
            {
                cmbCommandesLivresSuivi.Enabled = false;
                btnModifierSuiviCommande.Enabled = false;
                btnSupprimerCommande.Enabled = false;
                return;
            }

            string idSuiviActuel = cmd.IdSuivi ?? "";
            string[] transitions = GetTransitionsSuiviAutorisees(idSuiviActuel);

            cmbCommandesLivresSuivi.DisplayMember = "Libelle";
            cmbCommandesLivresSuivi.ValueMember = "Id";
            var choix = Suivis.Where(s => transitions.Contains(s.Id)).Select(s => new { s.Id, s.Libelle }).ToList();
            cmbCommandesLivresSuivi.DataSource = choix;

            if (choix.Count > 0)
            {
                cmbCommandesLivresSuivi.Enabled = true;
                cmbCommandesLivresSuivi.SelectedIndex = 0;
                btnModifierSuiviCommande.Enabled = true;
            }
            else
            {
                cmbCommandesLivresSuivi.Enabled = false;
                btnModifierSuiviCommande.Enabled = false;
            }

            // Suppression autorisée uniquement si "en cours" (00001) ou "relancée" (00002)
            btnSupprimerCommande.Enabled = idSuiviActuel == "00001" || idSuiviActuel == "00002";
        }

        /// <summary>
        /// Modification du suivi de la commande sélectionnée (après validation des règles métier).
        /// </summary>
        private void btnModifierSuiviCommande_Click(object sender, EventArgs e)
        {
            if (bdgCommandesLivresListe.Current == null || !(bdgCommandesLivresListe.Current is CommandeDocument cmd))
            {
                MessageBox.Show("Veuillez sélectionner une commande.", "Aucune commande sélectionnée", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(cmd.Id))
            {
                MessageBox.Show("Identifiant de la commande manquant. L'API doit retourner l'Id des commandes.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbCommandesLivresSuivi.SelectedValue == null)
            {
                MessageBox.Show("Veuillez choisir un nouveau suivi.", "Choix requis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nouveauIdSuivi = cmbCommandesLivresSuivi.SelectedValue.ToString();
            string idSuiviActuel = cmd.IdSuivi ?? "";

            string[] transitions = GetTransitionsSuiviAutorisees(idSuiviActuel);
            if (!transitions.Contains(nouveauIdSuivi))
            {
                MessageBox.Show("Cette modification n'est pas autorisée : une commande livrée ou réglée ne peut pas revenir à une étape précédente ; une commande ne peut pas être réglée si elle n'est pas livrée.", "Règle métier", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idLivre = txbCommandesLivresNumero.Text?.Trim();
            if (string.IsNullOrEmpty(idLivre))
            {
                MessageBox.Show("Livre non identifié.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                bool ok = controller.ModifierSuiviCommandeDocument(cmd.Id, nouveauIdSuivi);
                if (ok)
                {
                    MessageBox.Show("Suivi modifié avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    List<CommandeDocument> commandes = controller.GetCommandesDocument(idLivre);
                    commandes = commandes.OrderByDescending(c => c.DateCommande).ToList();
                    RemplirCommandesLivresListe(commandes);
                }
                else
                {
                    MessageBox.Show("Erreur lors de la modification du suivi.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Erreur technique", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Suppression de la commande sélectionnée (autorisée uniquement si suivi = en cours ou relancée).
        /// </summary>
        private void btnSupprimerCommande_Click(object sender, EventArgs e)
        {
            if (bdgCommandesLivresListe.Current == null || !(bdgCommandesLivresListe.Current is CommandeDocument cmd))
            {
                MessageBox.Show("Veuillez sélectionner une commande.", "Aucune commande sélectionnée", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(cmd.Id))
            {
                MessageBox.Show("Identifiant de la commande manquant.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string idSuiviActuel = cmd.IdSuivi ?? "";
            if (idSuiviActuel == "00003" || idSuiviActuel == "00004")
            {
                MessageBox.Show("Impossible de supprimer une commande déjà livrée ou réglée.", "Suppression interdite", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idLivre = txbCommandesLivresNumero.Text?.Trim();
            if (string.IsNullOrEmpty(idLivre))
            {
                MessageBox.Show("Livre non identifié.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var resultat = controller.SupprimerCommandeDocument(cmd.Id);
                if (resultat == Access.ResultatSuppression.Succes)
                {
                    MessageBox.Show("Commande supprimée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    List<CommandeDocument> commandes = controller.GetCommandesDocument(idLivre);
                    commandes = commandes.OrderByDescending(c => c.DateCommande).ToList();
                    RemplirCommandesLivresListe(commandes);
                }
                else if (resultat == Access.ResultatSuppression.RefuseCommande)
                {
                    MessageBox.Show("La suppression a été refusée : une commande livrée ou réglée ne peut pas être supprimée.", "Suppression refusée", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Erreur lors de la suppression de la commande.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Erreur technique", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Clic sur Ajouter : vérifie les champs, crée la commande et l'envoie à l'API.
        /// </summary>
        private void btnAjouterCommandeLivre_Click(object sender, EventArgs e)
        {
            string idLivre = txbCommandesLivresNumero.Text?.Trim();
            if (string.IsNullOrEmpty(idLivre))
            {
                MessageBox.Show("Veuillez sélectionner un livre (saisir le numéro et cliquer sur Rechercher).", "Aucun livre sélectionné", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Livre livre = lesLivresCommandes.Find(x => x.Id.Equals(idLivre));
            if (livre == null)
            {
                MessageBox.Show("Le livre sélectionné n'est pas valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txbCommandesLivresMontant.Text))
            {
                MessageBox.Show("Le montant est obligatoire.", "Champ requis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbCommandesLivresMontant.Focus();
                return;
            }

            if (!double.TryParse(txbCommandesLivresMontant.Text.Replace(",", "."), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double montant) || montant < 0)
            {
                MessageBox.Show("Le montant doit être un nombre positif.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbCommandesLivresMontant.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txbCommandesLivresNbExemplaire.Text))
            {
                MessageBox.Show("Le nombre d'exemplaires est obligatoire.", "Champ requis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbCommandesLivresNbExemplaire.Focus();
                return;
            }

            if (!int.TryParse(txbCommandesLivresNbExemplaire.Text, out int nbExemplaire) || nbExemplaire <= 0)
            {
                MessageBox.Show("Le nombre d'exemplaires doit être un entier strictement positif.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbCommandesLivresNbExemplaire.Focus();
                return;
            }

            DateTime dateCommande = dtpCommandesLivresDateCommande.Value;
            const string idSuiviEnCours = "00001";

            CommandeDocument commande = new CommandeDocument(dateCommande, montant, nbExemplaire, livre.Id, idSuiviEnCours);

            try
            {
                bool ok = controller.CreerCommandeDocument(commande);
                if (ok)
                {
                    MessageBox.Show("Commande enregistrée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    List<CommandeDocument> commandes = controller.GetCommandesDocument(livre.Id);
                    commandes = commandes.OrderByDescending(c => c.DateCommande).ToList();
                    RemplirCommandesLivresListe(commandes);
                    VideCommandesLivresNouvelleCommande();
                }
                else
                {
                    MessageBox.Show("Erreur lors de l'enregistrement de la commande.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Onglet Commandes DVD
        private readonly BindingSource bdgCommandesDvdListe = new BindingSource();
        private List<Dvd> lesDvdCommandes = new List<Dvd>();

        /// <summary>
        /// Ouverture de l'onglet Commandes DVD : récupère les DVD et vide les champs.
        /// </summary>
        private void tabCommandesDvd_Enter(object sender, EventArgs e)
        {
            lesDvdCommandes = controller.GetAllDvd();
            VideCommandesDvdZones();
            RemplirComboSuiviValeursDvd();
        }

        /// <summary>
        /// Vide les zones de l'onglet Commandes DVD.
        /// </summary>
        private void VideCommandesDvdZones()
        {
            txbCommandesDvdNumero.Text = "";
            txbCommandesDvdTitre.Text = "";
            txbCommandesDvdGenre.Text = "";
            txbCommandesDvdPublic.Text = "";
            txbCommandesDvdRayon.Text = "";
            VideCommandesDvdNouvelleCommande();
            RemplirCommandesDvdListe(new List<CommandeDocument>());
            cmbCommandesDvdSuivi.DataSource = null;
            cmbCommandesDvdSuivi.Enabled = false;
            btnCommandesDvdModifierSuivi.Enabled = false;
            btnCommandesDvdSupprimer.Enabled = false;
        }

        /// <summary>
        /// Remplit le ComboBox des suivi avec les valeurs connues (00001 à 00004).
        /// </summary>
        private void RemplirComboSuiviValeursDvd()
        {
            cmbCommandesDvdSuivi.DisplayMember = "Libelle";
            cmbCommandesDvdSuivi.ValueMember = "Id";
            cmbCommandesDvdSuivi.DataSource = Suivis.Select(s => new { s.Id, s.Libelle }).ToList();
        }

        /// <summary>
        /// Vide les champs du groupbox "Nouvelle commande".
        /// </summary>
        private void VideCommandesDvdNouvelleCommande()
        {
            dtpCommandesDvdDateCommande.Value = DateTime.Now;
            txbCommandesDvdMontant.Text = "";
            txbCommandesDvdNbExemplaire.Text = "";
        }

        /// <summary>
        /// Si le numéro de document est modifié, les infos et la liste des commandes sont effacées.
        /// </summary>
        private void txbCommandesDvdNumero_TextChanged(object sender, EventArgs e)
        {
            txbCommandesDvdTitre.Text = "";
            txbCommandesDvdGenre.Text = "";
            txbCommandesDvdPublic.Text = "";
            txbCommandesDvdRayon.Text = "";
            RemplirCommandesDvdListe(new List<CommandeDocument>());
        }

        /// <summary>
        /// Recherche d'un DVD par numéro, affichage des infos et de la liste des commandes.
        /// </summary>
        private void btnCommandesDvdRechercher_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbCommandesDvdNumero.Text))
                return;

            Dvd dvd = lesDvdCommandes.Find(x => x.Id.Equals(txbCommandesDvdNumero.Text.Trim()));
            if (dvd != null)
            {
                AfficheCommandesDvdInfos(dvd);
            }
            else
            {
                MessageBox.Show("numéro introuvable");
                VideCommandesDvdZones();
            }
        }

        /// <summary>
        /// Affiche les informations du DVD sélectionné et charge ses commandes.
        /// </summary>
        /// <param name="dvd">Le DVD</param>
        private void AfficheCommandesDvdInfos(Dvd dvd)
        {
            txbCommandesDvdNumero.Text = dvd.Id;
            txbCommandesDvdTitre.Text = dvd.Titre;
            txbCommandesDvdGenre.Text = dvd.Genre;
            txbCommandesDvdPublic.Text = dvd.Public;
            txbCommandesDvdRayon.Text = dvd.Rayon;

            List<CommandeDocument> commandes = controller.GetCommandesDocument(dvd.Id);
            commandes = commandes.OrderByDescending(c => c.DateCommande).ToList();
            RemplirCommandesDvdListe(commandes);
        }

        /// <summary>
        /// Remplit le DataGridView des commandes DVD avec la liste reçue.
        /// </summary>
        /// <param name="commandes">Liste des commandes (triée par date DESC)</param>
        private void RemplirCommandesDvdListe(List<CommandeDocument> commandes)
        {
            bdgCommandesDvdListe.DataSource = commandes;
            dgvCommandesDvd.DataSource = bdgCommandesDvdListe;
            if (dgvCommandesDvd.Columns.Contains("Id"))
                dgvCommandesDvd.Columns["Id"].Visible = false;
            if (dgvCommandesDvd.Columns.Contains("IdLivreDvd"))
                dgvCommandesDvd.Columns["IdLivreDvd"].Visible = false;
            if (dgvCommandesDvd.Columns.Contains("IdSuivi"))
                dgvCommandesDvd.Columns["IdSuivi"].Visible = false;
            dgvCommandesDvd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// Tri des colonnes de la liste des commandes DVD.
        /// </summary>
        private void dgvCommandesDvd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var commandesActuelles = bdgCommandesDvdListe.List?.Cast<CommandeDocument>().ToList();
            if (commandesActuelles == null || commandesActuelles.Count == 0)
            {
                return;
            }

            string titreColonne = dgvCommandesDvd.Columns[e.ColumnIndex].HeaderText;
            List<CommandeDocument> sortedList;

            switch (titreColonne)
            {
                case "DateCommande":
                    sortedList = commandesActuelles
                        .OrderByDescending(c => c.DateCommande)
                        .ToList();
                    break;
                case "Montant":
                    sortedList = commandesActuelles
                        .OrderBy(c => c.Montant)
                        .ToList();
                    break;
                case "NbExemplaire":
                    sortedList = commandesActuelles
                        .OrderBy(c => c.NbExemplaire)
                        .ToList();
                    break;
                case "Suivi":
                    sortedList = commandesActuelles
                        .OrderBy(c => c.Suivi)
                        .ToList();
                    break;
                default:
                    return;
            }

            RemplirCommandesDvdListe(sortedList);
        }

        /// <summary>
        /// Sélection d'une commande DVD : affiche le suivi actuel et les transitions possibles.
        /// </summary>
        private void dgvCommandesDvd_SelectionChanged(object sender, EventArgs e)
        {
            CommandeDocument cmd = dgvCommandesDvd.SelectedRows.Count > 0 ? dgvCommandesDvd.SelectedRows[0].DataBoundItem as CommandeDocument : null;
            if (cmd == null)
            {
                cmbCommandesDvdSuivi.Enabled = false;
                btnCommandesDvdModifierSuivi.Enabled = false;
                btnCommandesDvdSupprimer.Enabled = false;
                return;
            }

            string idSuiviActuel = cmd.IdSuivi ?? "";
            string[] transitions = GetTransitionsSuiviAutorisees(idSuiviActuel);

            cmbCommandesDvdSuivi.DisplayMember = "Libelle";
            cmbCommandesDvdSuivi.ValueMember = "Id";
            var choix = Suivis.Where(s => transitions.Contains(s.Id)).Select(s => new { s.Id, s.Libelle }).ToList();
            cmbCommandesDvdSuivi.DataSource = choix;

            if (choix.Count > 0)
            {
                cmbCommandesDvdSuivi.Enabled = true;
                cmbCommandesDvdSuivi.SelectedIndex = 0;
                btnCommandesDvdModifierSuivi.Enabled = true;
            }
            else
            {
                cmbCommandesDvdSuivi.Enabled = false;
                btnCommandesDvdModifierSuivi.Enabled = false;
            }

            btnCommandesDvdSupprimer.Enabled = idSuiviActuel == "00001" || idSuiviActuel == "00002";
        }

        /// <summary>
        /// Modification du suivi de la commande DVD sélectionnée.
        /// </summary>
        private void btnCommandesDvdModifierSuivi_Click(object sender, EventArgs e)
        {
            if (bdgCommandesDvdListe.Current == null || !(bdgCommandesDvdListe.Current is CommandeDocument cmd))
            {
                MessageBox.Show("Veuillez sélectionner une commande.", "Aucune commande sélectionnée", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(cmd.Id))
            {
                MessageBox.Show("Identifiant de la commande manquant. L'API doit retourner l'Id des commandes.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbCommandesDvdSuivi.SelectedValue == null)
            {
                MessageBox.Show("Veuillez choisir un nouveau suivi.", "Choix requis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nouveauIdSuivi = cmbCommandesDvdSuivi.SelectedValue.ToString();
            string idSuiviActuel = cmd.IdSuivi ?? "";

            string[] transitions = GetTransitionsSuiviAutorisees(idSuiviActuel);
            if (!transitions.Contains(nouveauIdSuivi))
            {
                MessageBox.Show("Cette modification n'est pas autorisée : une commande livrée ou réglée ne peut pas revenir à une étape précédente ; une commande ne peut pas être réglée si elle n'est pas livrée.", "Règle métier", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idDvd = txbCommandesDvdNumero.Text?.Trim();
            if (string.IsNullOrEmpty(idDvd))
            {
                MessageBox.Show("DVD non identifié.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                bool ok = controller.ModifierSuiviCommandeDocument(cmd.Id, nouveauIdSuivi);
                if (ok)
                {
                    MessageBox.Show("Suivi modifié avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    List<CommandeDocument> commandes = controller.GetCommandesDocument(idDvd);
                    commandes = commandes.OrderByDescending(c => c.DateCommande).ToList();
                    RemplirCommandesDvdListe(commandes);
                }
                else
                {
                    MessageBox.Show("Erreur lors de la modification du suivi.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Erreur technique", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Suppression de la commande DVD sélectionnée (autorisée uniquement si suivi = en cours ou relancée).
        /// </summary>
        private void btnCommandesDvdSupprimer_Click(object sender, EventArgs e)
        {
            if (bdgCommandesDvdListe.Current == null || !(bdgCommandesDvdListe.Current is CommandeDocument cmd))
            {
                MessageBox.Show("Veuillez sélectionner une commande.", "Aucune commande sélectionnée", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(cmd.Id))
            {
                MessageBox.Show("Identifiant de la commande manquant.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string idSuiviActuel = cmd.IdSuivi ?? "";
            if (idSuiviActuel == "00003" || idSuiviActuel == "00004")
            {
                MessageBox.Show("Impossible de supprimer une commande déjà livrée ou réglée.", "Suppression interdite", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idDvd = txbCommandesDvdNumero.Text?.Trim();
            if (string.IsNullOrEmpty(idDvd))
            {
                MessageBox.Show("DVD non identifié.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var resultat = controller.SupprimerCommandeDocument(cmd.Id);
                if (resultat == Access.ResultatSuppression.Succes)
                {
                    MessageBox.Show("Commande supprimée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    List<CommandeDocument> commandes = controller.GetCommandesDocument(idDvd);
                    commandes = commandes.OrderByDescending(c => c.DateCommande).ToList();
                    RemplirCommandesDvdListe(commandes);
                }
                else if (resultat == Access.ResultatSuppression.RefuseCommande)
                {
                    MessageBox.Show("La suppression a été refusée : une commande livrée ou réglée ne peut pas être supprimée.", "Suppression refusée", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Erreur lors de la suppression de la commande.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Erreur technique", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Clic sur Ajouter : vérifie les champs, crée la commande DVD et l'envoie à l'API.
        /// </summary>
        private void btnAjouterCommandeDvd_Click(object sender, EventArgs e)
        {
            string idDvd = txbCommandesDvdNumero.Text?.Trim();
            if (string.IsNullOrEmpty(idDvd))
            {
                MessageBox.Show("Veuillez sélectionner un DVD (saisir le numéro et cliquer sur Rechercher).", "Aucun DVD sélectionné", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Dvd dvd = lesDvdCommandes.Find(x => x.Id.Equals(idDvd));
            if (dvd == null)
            {
                MessageBox.Show("Le DVD sélectionné n'est pas valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txbCommandesDvdMontant.Text))
            {
                MessageBox.Show("Le montant est obligatoire.", "Champ requis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbCommandesDvdMontant.Focus();
                return;
            }

            if (!double.TryParse(txbCommandesDvdMontant.Text.Replace(",", "."), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double montant) || montant < 0)
            {
                MessageBox.Show("Le montant doit être un nombre positif.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbCommandesDvdMontant.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txbCommandesDvdNbExemplaire.Text))
            {
                MessageBox.Show("Le nombre d'exemplaires est obligatoire.", "Champ requis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbCommandesDvdNbExemplaire.Focus();
                return;
            }

            if (!int.TryParse(txbCommandesDvdNbExemplaire.Text, out int nbExemplaire) || nbExemplaire <= 0)
            {
                MessageBox.Show("Le nombre d'exemplaires doit être un entier strictement positif.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbCommandesDvdNbExemplaire.Focus();
                return;
            }

            DateTime dateCommande = dtpCommandesDvdDateCommande.Value;
            const string idSuiviEnCours = "00001";

            CommandeDocument commande = new CommandeDocument(dateCommande, montant, nbExemplaire, dvd.Id, idSuiviEnCours);

            try
            {
                bool ok = controller.CreerCommandeDocument(commande);
                if (ok)
                {
                    MessageBox.Show("Commande enregistrée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    List<CommandeDocument> commandes = controller.GetCommandesDocument(dvd.Id);
                    commandes = commandes.OrderByDescending(c => c.DateCommande).ToList();
                    RemplirCommandesDvdListe(commandes);
                    VideCommandesDvdNouvelleCommande();
                }
                else
                {
                    MessageBox.Show("Erreur lors de l'enregistrement de la commande.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Onglet Commandes Revues
        private readonly BindingSource bdgCommandesRevuesListe = new BindingSource();
        private List<Revue> lesRevuesCommandes = new List<Revue>();

        private void tabCommandesRevues_Enter(object sender, EventArgs e)
        {
            lesRevuesCommandes = controller.GetAllRevues();
            txbCommandesRevuesNumero.Text = "";
            VideCommandesRevuesZones();
            VideCommandesRevuesNouvelleCommande();
        }

        private void VideCommandesRevuesZones()
        {
            txbCommandesRevuesTitre.Text = "";
            txbCommandesRevuesGenre.Text = "";
            txbCommandesRevuesPublic.Text = "";
            txbCommandesRevuesRayon.Text = "";
            RemplirCommandesRevuesListe(new List<AbonnementRevue>());
            btnSupprimerCommandeRevue.Enabled = false;
        }

        private void VideCommandesRevuesNouvelleCommande()
        {
            dtpCommandesRevuesDateCommande.Value = DateTime.Now;
            txbCommandesRevuesMontant.Text = "";
            dtpCommandesRevuesDateFinAbonnement.Value = DateTime.Now.AddYears(1);
        }

        private void txbCommandesRevuesNumero_TextChanged(object sender, EventArgs e)
        {
            txbCommandesRevuesTitre.Text = "";
            txbCommandesRevuesGenre.Text = "";
            txbCommandesRevuesPublic.Text = "";
            txbCommandesRevuesRayon.Text = "";
            RemplirCommandesRevuesListe(new List<AbonnementRevue>());
            btnSupprimerCommandeRevue.Enabled = false;
        }

        private void btnCommandesRevuesRechercher_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbCommandesRevuesNumero.Text))
                return;

            Revue revue = lesRevuesCommandes.Find(x => x.Id.Equals(txbCommandesRevuesNumero.Text.Trim()));
            if (revue != null)
            {
                AfficheCommandesRevuesInfos(revue);
            }
            else
            {
                MessageBox.Show("numéro introuvable");
                VideCommandesRevuesZones();
            }
        }

        private void AfficheCommandesRevuesInfos(Revue revue)
        {
            txbCommandesRevuesNumero.Text = revue.Id;
            txbCommandesRevuesTitre.Text = revue.Titre;
            txbCommandesRevuesGenre.Text = revue.Genre;
            txbCommandesRevuesPublic.Text = revue.Public;
            txbCommandesRevuesRayon.Text = revue.Rayon;

            List<AbonnementRevue> commandes = controller.GetCommandesRevue(revue.Id);
            commandes = commandes.OrderByDescending(c => c.DateCommande).ToList();
            RemplirCommandesRevuesListe(commandes);
        }

        private void RemplirCommandesRevuesListe(List<AbonnementRevue> commandes)
        {
            bdgCommandesRevuesListe.DataSource = commandes;
            dgvCommandesRevues.DataSource = bdgCommandesRevuesListe;
            if (dgvCommandesRevues.Columns.Contains("Id"))
                dgvCommandesRevues.Columns["Id"].Visible = false;
            if (dgvCommandesRevues.Columns.Contains("IdRevue"))
                dgvCommandesRevues.Columns["IdRevue"].Visible = false;
            dgvCommandesRevues.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dgvCommandesRevues_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var commandesActuelles = bdgCommandesRevuesListe.List?.Cast<AbonnementRevue>().ToList();
            if (commandesActuelles == null || commandesActuelles.Count == 0)
                return;

            string titreColonne = dgvCommandesRevues.Columns[e.ColumnIndex].HeaderText;
            List<AbonnementRevue> sortedList;
            switch (titreColonne)
            {
                case "DateCommande":
                    sortedList = commandesActuelles.OrderByDescending(c => c.DateCommande).ToList();
                    break;
                case "Montant":
                    sortedList = commandesActuelles.OrderBy(c => c.Montant).ToList();
                    break;
                case "DateFinAbonnement":
                    sortedList = commandesActuelles.OrderByDescending(c => c.DateFinAbonnement).ToList();
                    break;
                default:
                    return;
            }
            RemplirCommandesRevuesListe(sortedList);
        }

        private void dgvCommandesRevues_SelectionChanged(object sender, EventArgs e)
        {
            AbonnementRevue abo = dgvCommandesRevues.SelectedRows.Count > 0 ? dgvCommandesRevues.SelectedRows[0].DataBoundItem as AbonnementRevue : null;
            btnSupprimerCommandeRevue.Enabled = abo != null;
        }

        private void btnSupprimerCommandeRevue_Click(object sender, EventArgs e)
        {
            if (bdgCommandesRevuesListe.Current == null || !(bdgCommandesRevuesListe.Current is AbonnementRevue abo))
            {
                MessageBox.Show("Veuillez sélectionner une commande à supprimer.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(abo.Id))
            {
                MessageBox.Show("Identifiant de la commande manquant.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string idRevue = txbCommandesRevuesNumero.Text?.Trim();
            if (string.IsNullOrEmpty(idRevue))
            {
                MessageBox.Show("Revue non identifiée.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var resultat = controller.SupprimerCommandeRevue(abo.Id);
                if (resultat == Access.ResultatSuppression.Succes)
                {
                    MessageBox.Show("Commande supprimée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    List<AbonnementRevue> commandes = controller.GetCommandesRevue(idRevue);
                    commandes = commandes.OrderByDescending(c => c.DateCommande).ToList();
                    RemplirCommandesRevuesListe(commandes);
                }
                else if (resultat == Access.ResultatSuppression.RefuseCommande)
                {
                    MessageBox.Show("La suppression a été refusée (règle métier).", "Suppression refusée", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Erreur lors de la suppression de la commande.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Erreur technique", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAjouterCommandeRevue_Click(object sender, EventArgs e)
        {
            string idRevue = txbCommandesRevuesNumero.Text?.Trim();
            if (string.IsNullOrEmpty(idRevue))
            {
                MessageBox.Show("Veuillez sélectionner une revue (saisir le numéro et cliquer sur Rechercher).", "Aucune revue sélectionnée", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Revue revue = lesRevuesCommandes.Find(x => x.Id.Equals(idRevue));
            if (revue == null)
            {
                MessageBox.Show("La revue sélectionnée n'est pas valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txbCommandesRevuesMontant.Text))
            {
                MessageBox.Show("Le montant est obligatoire.", "Champ requis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbCommandesRevuesMontant.Focus();
                return;
            }
            if (!double.TryParse(txbCommandesRevuesMontant.Text.Replace(",", "."), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double montant) || montant < 0)
            {
                MessageBox.Show("Le montant doit être un nombre positif.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbCommandesRevuesMontant.Focus();
                return;
            }
            DateTime dateCommande = dtpCommandesRevuesDateCommande.Value;
            DateTime dateFinAbonnement = dtpCommandesRevuesDateFinAbonnement.Value;
            if (dateFinAbonnement <= dateCommande)
            {
                MessageBox.Show("La date de fin d'abonnement doit être postérieure à la date de commande.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AbonnementRevue abonnement = new AbonnementRevue(dateCommande, montant, dateFinAbonnement, revue.Id);
            try
            {
                bool ok = controller.CreerCommandeRevue(abonnement);
                if (ok)
                {
                    MessageBox.Show("Commande enregistrée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    List<AbonnementRevue> commandes = controller.GetCommandesRevue(revue.Id);
                    commandes = commandes.OrderByDescending(c => c.DateCommande).ToList();
                    RemplirCommandesRevuesListe(commandes);
                    VideCommandesRevuesNouvelleCommande();
                }
                else
                {
                    MessageBox.Show("Erreur lors de l'enregistrement de la commande.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Onglet Paarutions
        private readonly BindingSource bdgExemplairesListe = new BindingSource();
        private List<Exemplaire> lesExemplaires = new List<Exemplaire>();
        private List<Etat> lesEtatsReception = new List<Etat>();
        const string ETATNEUF = "00001";

        /// <summary>
        /// Ouverture de l'onglet : récupère les revues, les états et vide tous les champs.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabReceptionRevue_Enter(object sender, EventArgs e)
        {
            lesRevues = controller.GetAllRevues();
            lesEtatsReception = controller.GetAllEtats();
            cbxReceptionExemplaireEtat.DataSource = lesEtatsReception;
            cbxReceptionExemplaireEtat.SelectedIndex = -1;
            txbReceptionRevueNumero.Text = "";
        }

        /// <summary>
        /// Remplit le dategrid des exemplaires avec la liste reçue en paramètre
        /// </summary>
        /// <param name="exemplaires">liste d'exemplaires</param>
        private void RemplirReceptionExemplairesListe(List<Exemplaire> exemplaires)
        {
            if (exemplaires != null)
            {
                bdgExemplairesListe.DataSource = exemplaires;
                dgvReceptionExemplairesListe.DataSource = bdgExemplairesListe;
                dgvReceptionExemplairesListe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                if (dgvReceptionExemplairesListe.Columns["Id"] != null) dgvReceptionExemplairesListe.Columns["Id"].Visible = false;
                if (dgvReceptionExemplairesListe.Columns["Photo"] != null) dgvReceptionExemplairesListe.Columns["Photo"].Visible = false;
                if (dgvReceptionExemplairesListe.Columns["IdEtat"] != null) dgvReceptionExemplairesListe.Columns["IdEtat"].Visible = false;
                if (dgvReceptionExemplairesListe.Columns["Numero"] != null) dgvReceptionExemplairesListe.Columns["Numero"].DisplayIndex = 0;
                if (dgvReceptionExemplairesListe.Columns["DateAchat"] != null) dgvReceptionExemplairesListe.Columns["DateAchat"].DisplayIndex = 1;
                if (dgvReceptionExemplairesListe.Columns["LibelleEtat"] != null) dgvReceptionExemplairesListe.Columns["LibelleEtat"].DisplayIndex = 2;
            }
            else
            {
                bdgExemplairesListe.DataSource = null;
                dgvReceptionExemplairesListe.DataSource = bdgExemplairesListe;
                ActiverGestionEtatReception(false);
            }
        }

        /// <summary>
        /// Active ou désactive la zone de changement d'état et suppression (Parutions).
        /// </summary>
        /// <param name="actif">true pour activer</param>
        private void ActiverGestionEtatReception(bool actif)
        {
            cbxReceptionExemplaireEtat.Enabled = actif;
            btnReceptionExemplaireModifierEtat.Enabled = actif;
            btnReceptionExemplaireSupprimer.Enabled = actif;
            if (!actif)
            {
                cbxReceptionExemplaireEtat.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Recherche d'un numéro de revue et affiche ses informations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReceptionRechercher_Click(object sender, EventArgs e)
        {
            if (!txbReceptionRevueNumero.Text.Equals(""))
            {
                Revue revue = lesRevues.Find(x => x.Id.Equals(txbReceptionRevueNumero.Text));
                if (revue != null)
                {
                    AfficheReceptionRevueInfos(revue);
                }
                else
                {
                    MessageBox.Show("numéro introuvable");
                }
            }
        }

        /// <summary>
        /// Si le numéro de revue est modifié, la zone de l'exemplaire est vidée et inactive
        /// les informations de la revue son aussi effacées
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbReceptionRevueNumero_TextChanged(object sender, EventArgs e)
        {
            txbReceptionRevuePeriodicite.Text = "";
            txbReceptionRevueImage.Text = "";
            txbReceptionRevueDelaiMiseADispo.Text = "";
            txbReceptionRevueGenre.Text = "";
            txbReceptionRevuePublic.Text = "";
            txbReceptionRevueRayon.Text = "";
            txbReceptionRevueTitre.Text = "";
            pcbReceptionRevueImage.Image = null;
            RemplirReceptionExemplairesListe(null);
            AccesReceptionExemplaireGroupBox(false);
        }

        /// <summary>
        /// Affichage des informations de la revue sélectionnée et les exemplaires
        /// </summary>
        /// <param name="revue">la revue</param>
        private void AfficheReceptionRevueInfos(Revue revue)
        {
            // informations sur la revue
            txbReceptionRevuePeriodicite.Text = revue.Periodicite;
            txbReceptionRevueImage.Text = revue.Image;
            txbReceptionRevueDelaiMiseADispo.Text = revue.DelaiMiseADispo.ToString();
            txbReceptionRevueNumero.Text = revue.Id;
            txbReceptionRevueGenre.Text = revue.Genre;
            txbReceptionRevuePublic.Text = revue.Public;
            txbReceptionRevueRayon.Text = revue.Rayon;
            txbReceptionRevueTitre.Text = revue.Titre;
            string image = revue.Image;
            try
            {
                pcbReceptionRevueImage.Image = Image.FromFile(image);
            }
            catch
            {
                pcbReceptionRevueImage.Image = null;
            }
            // affiche la liste des exemplaires de la revue
            AfficheReceptionExemplairesRevue();
        }

        /// <summary>
        /// Récupère et affiche les exemplaires d'une revue
        /// </summary>
        private void AfficheReceptionExemplairesRevue()
        {
            string idDocuement = txbReceptionRevueNumero.Text;
            lesExemplaires = controller.GetExemplairesRevue(idDocuement);
            RemplirReceptionExemplairesListe(lesExemplaires);
            AccesReceptionExemplaireGroupBox(true);
        }

        /// <summary>
        /// Permet ou interdit l'accès à la gestion de la réception d'un exemplaire
        /// et vide les objets graphiques
        /// </summary>
        /// <param name="acces">true ou false</param>
        private void AccesReceptionExemplaireGroupBox(bool acces)
        {
            grpReceptionExemplaire.Enabled = acces;
            txbReceptionExemplaireImage.Text = "";
            txbReceptionExemplaireNumero.Text = "";
            pcbReceptionExemplaireImage.Image = null;
            dtpReceptionExemplaireDate.Value = DateTime.Now;
        }

        /// <summary>
        /// Recherche image sur disque (pour l'exemplaire à insérer)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReceptionExemplaireImage_Click(object sender, EventArgs e)
        {
            string filePath = "";
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                // positionnement à la racine du disque où se trouve le dossier actuel
                InitialDirectory = Path.GetPathRoot(Environment.CurrentDirectory),
                Filter = "Files|*.jpg;*.bmp;*.jpeg;*.png;*.gif"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
            }
            txbReceptionExemplaireImage.Text = filePath;
            try
            {
                pcbReceptionExemplaireImage.Image = Image.FromFile(filePath);
            }
            catch
            {
                pcbReceptionExemplaireImage.Image = null;
            }
        }

        /// <summary>
        /// Enregistrement du nouvel exemplaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReceptionExemplaireValider_Click(object sender, EventArgs e)
        {
            if (!txbReceptionExemplaireNumero.Text.Equals(""))
            {
                try
                {
                    int numero = int.Parse(txbReceptionExemplaireNumero.Text);
                    DateTime dateAchat = dtpReceptionExemplaireDate.Value;
                    string photo = txbReceptionExemplaireImage.Text;
                    string idEtat = ETATNEUF;
                    string idDocument = txbReceptionRevueNumero.Text;
                    Exemplaire exemplaire = new Exemplaire(numero, dateAchat, photo, idEtat, idDocument);
                    if (controller.CreerExemplaire(exemplaire))
                    {
                        AfficheReceptionExemplairesRevue();
                    }
                    else
                    {
                        MessageBox.Show("numéro de publication déjà existant", "Erreur");
                    }
                }
                catch
                {
                    MessageBox.Show("le numéro de parution doit être numérique", "Information");
                    txbReceptionExemplaireNumero.Text = "";
                    txbReceptionExemplaireNumero.Focus();
                }
            }
            else
            {
                MessageBox.Show("numéro de parution obligatoire", "Information");
            }
        }

        /// <summary>
        /// Tri sur une colonne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvExemplairesListe_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (lesExemplaires == null || lesExemplaires.Count == 0) return;

            string titreColonne = dgvReceptionExemplairesListe.Columns[e.ColumnIndex].HeaderText;
            List<Exemplaire> sortedList = new List<Exemplaire>(lesExemplaires);
            switch (titreColonne)
            {
                case "Numero":
                    sortedList = sortedList.OrderByDescending(o => o.Numero).ToList();
                    break;
                case "DateAchat":
                    sortedList = sortedList.OrderByDescending(o => o.DateAchat).ToList();
                    break;
                case "LibelleEtat":
                    sortedList = sortedList.OrderBy(o => o.LibelleEtat).ToList();
                    break;
            }
            RemplirReceptionExemplairesListe(sortedList);
        }

        /// <summary>
        /// affichage de l'image de l'exemplaire suite à la sélection d'un exemplaire dans la liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvReceptionExemplairesListe_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvReceptionExemplairesListe.CurrentCell != null && bdgExemplairesListe.Position >= 0 && bdgExemplairesListe.List != null)
            {
                Exemplaire exemplaire = (Exemplaire)bdgExemplairesListe.List[bdgExemplairesListe.Position];
                string image = exemplaire.Photo;
                try
                {
                    pcbReceptionExemplaireRevueImage.Image = Image.FromFile(image);
                }
                catch
                {
                    pcbReceptionExemplaireRevueImage.Image = null;
                }
                Etat etat = lesEtatsReception.Find(x => x.Id.Equals(exemplaire.IdEtat));
                if (etat != null)
                {
                    cbxReceptionExemplaireEtat.SelectedItem = etat;
                }
                else
                {
                    cbxReceptionExemplaireEtat.SelectedIndex = -1;
                }
                ActiverGestionEtatReception(true);
            }
            else
            {
                pcbReceptionExemplaireRevueImage.Image = null;
                ActiverGestionEtatReception(false);
            }
        }

        private void btnReceptionExemplaireModifierEtat_Click(object sender, EventArgs e)
        {
            if (bdgExemplairesListe.Position < 0 || cbxReceptionExemplaireEtat.SelectedItem == null || string.IsNullOrEmpty(txbReceptionRevueNumero.Text))
            {
                return;
            }
            string idDocument = txbReceptionRevueNumero.Text;
            Exemplaire exemplaire = (Exemplaire)bdgExemplairesListe.List[bdgExemplairesListe.Position];
            Etat etat = (Etat)cbxReceptionExemplaireEtat.SelectedItem;

            bool ok = controller.ModifierEtatExemplaire(idDocument, exemplaire.Numero, etat.Id);
            if (ok)
            {
                AfficheReceptionExemplairesRevue();
            }
            else
            {
                MessageBox.Show("Erreur lors de la modification de l'état.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReceptionExemplaireSupprimer_Click(object sender, EventArgs e)
        {
            if (bdgExemplairesListe.Position < 0 || bdgExemplairesListe.List == null || string.IsNullOrEmpty(txbReceptionRevueNumero.Text))
            {
                MessageBox.Show("Veuillez sélectionner un exemplaire à supprimer.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string idDocument = txbReceptionRevueNumero.Text;
            Exemplaire exemplaire = (Exemplaire)bdgExemplairesListe.List[bdgExemplairesListe.Position];

            if (MessageBox.Show(
                "Êtes-vous sûr de vouloir supprimer la parution n°" + exemplaire.Numero + " ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            Access.ResultatSuppression resultat = controller.SupprimerExemplaire(idDocument, exemplaire.Numero);
            switch (resultat)
            {
                case Access.ResultatSuppression.Succes:
                    MessageBox.Show("Parution supprimée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AfficheReceptionExemplairesRevue();
                    break;
                case Access.ResultatSuppression.RefuseCommande:
                case Access.ResultatSuppression.Erreur:
                default:
                    MessageBox.Show("Erreur lors de la suppression de la parution.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
		#endregion

		/// <summary>
		/// Ajout d'un livre : ouvre le formulaire de saisie puis POST vers l'API (guide CNED + format API PHP)

		/// <summary>
		/// Modification du livre sélectionné : ouvre le formulaire prérempli puis PUT vers l'API
		/// </summary>

		/// <summary>
		/// Suppression du livre sélectionné : confirmation puis DELETE vers l'API (champs id)
		/// </summary>
	

		private void dgvLivresListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			// Sélection gérée par DgvLivresListe_SelectionChanged
		}

		private void btnAjouterLivre_Click(object sender, EventArgs e)
		{
			FrmAjoutLivre frm = new FrmAjoutLivre(
				controller.GetAllGenres(),
				controller.GetAllPublics(),
				controller.GetAllRayons()
			);

			if (frm.ShowDialog() == DialogResult.OK)
			{
				Categorie genre = frm.GenreSelectionne;
				Categorie lePublic = frm.PublicSelectionne;
				Categorie rayon = frm.RayonSelectionne;

				Livre livre = new Livre(
					frm.IdLivre,
					frm.TitreLivre,
					"",
					frm.IsbnLivre,
					frm.AuteurLivre,
					"",
					genre.Id,
					genre.Libelle,
					lePublic.Id,
					lePublic.Libelle,
					rayon.Id,
					rayon.Libelle
				);

				bool ok = controller.CreerLivre(livre);

				if (ok)
				{
					MessageBox.Show("Livre ajouté avec succès.");
					lesLivres = new List<Livre>(controller.GetAllLivres());
					VideLivresZones();
					RemplirLivresListe(lesLivres);
					dgvLivresListe.Refresh();
				}
				else
				{
					MessageBox.Show("Erreur lors de l'ajout du livre.");
				}
			}
		}
		/// <summary>
		/// Modification du livre sélectionné : ouvre le formulaire prérempli puis PUT vers l'API
		/// </summary>
		private void btnModifierLivre_Click(object sender, EventArgs e)
		{
			if (bdgLivresListe.Current == null)
			{
				MessageBox.Show("Veuillez sélectionner un livre à modifier.");
				return;
			}

			Livre livreSelectionne = (Livre)bdgLivresListe.Current;

			FrmAjoutLivre frm = new FrmAjoutLivre(
				controller.GetAllGenres(),
				controller.GetAllPublics(),
				controller.GetAllRayons(),
				livreSelectionne
			);

			if (frm.ShowDialog() == DialogResult.OK)
			{
				Categorie genre = frm.GenreSelectionne;
				Categorie lePublic = frm.PublicSelectionne;
				Categorie rayon = frm.RayonSelectionne;

				Livre livreModifie = new Livre(
					livreSelectionne.Id,
					frm.TitreLivre,
					livreSelectionne.Image ?? "",
					frm.IsbnLivre,
					frm.AuteurLivre,
					livreSelectionne.Collection ?? "",
					genre.Id,
					genre.Libelle,
					lePublic.Id,
					lePublic.Libelle,
					rayon.Id,
					rayon.Libelle
				);

				bool ok = controller.ModifierLivre(livreModifie);

				if (ok)
				{
					MessageBox.Show("Livre modifié avec succès.");
					lesLivres = new List<Livre>(controller.GetAllLivres());
					VideLivresZones();
					RemplirLivresListe(lesLivres);
					dgvLivresListe.Refresh();
				}
				else
				{
					MessageBox.Show("Erreur lors de la modification du livre.");
				}
			}
		}

		/// <summary>
		/// Suppression du livre sélectionné : confirmation puis DELETE vers l'API
		/// </summary>
		private void btnSupprimerLivre_Click(object sender, EventArgs e)
		{
			if (bdgLivresListe.Current == null)
			{
				MessageBox.Show("Veuillez sélectionner un livre à supprimer.");
				return;
			}

			Livre livreSelectionne = (Livre)bdgLivresListe.Current;

			DialogResult confirmation = MessageBox.Show(
				"Êtes-vous sûr de vouloir supprimer le livre \"" + livreSelectionne.Titre + "\" ?",
				"Confirmer la suppression",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question
			);

			if (confirmation != DialogResult.Yes)
				return;

			Access.ResultatSuppression resultat = controller.SupprimerLivre(livreSelectionne.Id);

			switch (resultat)
			{
				case Access.ResultatSuppression.Succes:
					MessageBox.Show("Livre supprimé avec succès.");
					lesLivres = new List<Livre>(controller.GetAllLivres());
					VideLivresZones();
					RemplirLivresListe(lesLivres);
					dgvLivresListe.Refresh();
					break;
				case Access.ResultatSuppression.RefuseCommande:
					MessageBox.Show(
						"Ce livre ne peut pas être supprimé car il possède des commandes rattachées.",
						"Suppression refusée",
						MessageBoxButtons.OK,
						MessageBoxIcon.Warning
					);
					break;
				case Access.ResultatSuppression.Erreur:
				default:
					MessageBox.Show(
						"Erreur technique lors de la suppression du livre.",
						"Erreur",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error
					);
					break;
			}
		}
	}
}
