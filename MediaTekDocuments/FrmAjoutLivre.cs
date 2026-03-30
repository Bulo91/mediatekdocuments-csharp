using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MediaTekDocuments.model;

namespace MediaTekDocuments.view
{
	/// <summary>
	/// Formulaire modal de saisie ou de modification d'un livre (identifiant, titre, ISBN, auteur, genre, public, rayon).
	/// </summary>
	public partial class FrmAjoutLivre : Form
	{
		/// <summary>
		/// Obtient l'identifiant saisi pour le livre.
		/// </summary>
		public string IdLivre => txbId.Text.Trim();
		/// <summary>
		/// Obtient le titre saisi.
		/// </summary>
		public string TitreLivre => txbTitre.Text.Trim();
		/// <summary>
		/// Obtient l'auteur saisi.
		/// </summary>
		public string AuteurLivre => txbAuteur.Text.Trim();
		/// <summary>
		/// Obtient le numéro ISBN saisi.
		/// </summary>
		public string IsbnLivre => txbIsbn.Text.Trim();

		/// <summary>
		/// Obtient le genre sélectionné dans la liste déroulante.
		/// </summary>
		public Categorie GenreSelectionne => cbxGenre.SelectedItem as Categorie;
		/// <summary>
		/// Obtient le public sélectionné dans la liste déroulante.
		/// </summary>
		public Categorie PublicSelectionne => cbxPublic.SelectedItem as Categorie;
		/// <summary>
		/// Obtient le rayon sélectionné dans la liste déroulante.
		/// </summary>
		public Categorie RayonSelectionne => cbxRayon.SelectedItem as Categorie;

		/// <summary>
		/// Initialise le formulaire en mode création d'un livre.
		/// </summary>
		/// <param name="genres">Liste des genres pour le combo.</param>
		/// <param name="publics">Liste des publics pour le combo.</param>
		/// <param name="rayons">Liste des rayons pour le combo.</param>
		public FrmAjoutLivre(List<Categorie> genres, List<Categorie> publics, List<Categorie> rayons)
			: this(genres, publics, rayons, null)
		{
		}

		/// <summary>
		/// Initialise le formulaire en mode création ou modification. Si <paramref name="livreToEdit"/> est renseigné, l'identifiant devient en lecture seule.
		/// </summary>
		/// <param name="genres">Liste des genres pour le combo.</param>
		/// <param name="publics">Liste des publics pour le combo.</param>
		/// <param name="rayons">Liste des rayons pour le combo.</param>
		/// <param name="livreToEdit">Livre à modifier, ou <c>null</c> pour un ajout.</param>
		public FrmAjoutLivre(List<Categorie> genres, List<Categorie> publics, List<Categorie> rayons, Livre livreToEdit)
		{
			InitializeComponent();

			cbxGenre.DataSource = genres;
			cbxPublic.DataSource = publics;
			cbxRayon.DataSource = rayons;

			cbxGenre.DisplayMember = "Libelle";
			cbxPublic.DisplayMember = "Libelle";
			cbxRayon.DisplayMember = "Libelle";

			if (livreToEdit != null)
			{
				this.Text = "Modifier un livre";
				txbId.Text = livreToEdit.Id;
				txbId.ReadOnly = true;
				txbTitre.Text = livreToEdit.Titre;
				txbAuteur.Text = livreToEdit.Auteur ?? "";
				txbIsbn.Text = livreToEdit.Isbn ?? "";
				cbxGenre.SelectedItem = genres.FirstOrDefault(g => g.Id == livreToEdit.IdGenre);
				cbxPublic.SelectedItem = publics.FirstOrDefault(p => p.Id == livreToEdit.IdPublic);
				cbxRayon.SelectedItem = rayons.FirstOrDefault(r => r.Id == livreToEdit.IdRayon);
			}
			else
			{
				cbxGenre.SelectedIndex = -1;
				cbxPublic.SelectedIndex = -1;
				cbxRayon.SelectedIndex = -1;
			}
		}

		/// <summary>
		/// Valide la saisie (champs obligatoires) et ferme le formulaire avec OK si les données sont cohérentes.
		/// </summary>
		/// <param name="sender">Source de l'événement.</param>
		/// <param name="e">Données de l'événement.</param>
		private void btnValider_Click(object sender, EventArgs e)
		{
			if (txbId.Text.Trim() == "")
			{
				MessageBox.Show("L'id est obligatoire.");
				txbId.Focus();
				return;
			}

			if (txbTitre.Text.Trim() == "")
			{
				MessageBox.Show("Le titre est obligatoire.");
				txbTitre.Focus();
				return;
			}

			if (cbxGenre.SelectedIndex < 0 || cbxPublic.SelectedIndex < 0 || cbxRayon.SelectedIndex < 0)
			{
				MessageBox.Show("Genre, public et rayon sont obligatoires.");
				return;
			}

			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		/// <summary>
		/// Ferme le formulaire avec le résultat Cancel sans enregistrer.
		/// </summary>
		/// <param name="sender">Source de l'événement.</param>
		/// <param name="e">Données de l'événement.</param>
		private void btnAnnuler_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}
}
