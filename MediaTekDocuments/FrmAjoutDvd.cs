using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MediaTekDocuments.model;

namespace MediaTekDocuments.view
{
	/// <summary>
	/// Formulaire modal de saisie ou de modification d'un DVD (durée, réalisateur, synopsis, classifications).
	/// </summary>
	public partial class FrmAjoutDvd : Form
	{
		/// <summary>
		/// Obtient l'identifiant saisi pour le DVD.
		/// </summary>
		public string IdDvd => txbId.Text.Trim();
		/// <summary>
		/// Obtient le titre saisi.
		/// </summary>
		public string TitreDvd => txbTitre.Text.Trim();
		/// <summary>
		/// Obtient la durée en minutes (0 si la saisie n'est pas un entier valide).
		/// </summary>
		public int DureeDvd
		{
			get
			{
				int d;
				return int.TryParse(txbDuree.Text.Trim(), out d) ? d : 0;
			}
		}
		/// <summary>
		/// Obtient le nom du réalisateur saisi.
		/// </summary>
		public string RealisateurDvd => txbRealisateur.Text.Trim();
		/// <summary>
		/// Obtient le synopsis saisi.
		/// </summary>
		public string SynopsisDvd => txbSynopsis.Text.Trim();

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
		/// Initialise le formulaire en mode création d'un DVD.
		/// </summary>
		/// <param name="genres">Liste des genres pour le combo.</param>
		/// <param name="publics">Liste des publics pour le combo.</param>
		/// <param name="rayons">Liste des rayons pour le combo.</param>
		public FrmAjoutDvd(List<Categorie> genres, List<Categorie> publics, List<Categorie> rayons)
			: this(genres, publics, rayons, null)
		{
		}

		/// <summary>
		/// Initialise le formulaire en mode création ou modification. Si <paramref name="dvdToEdit"/> est renseigné, l'identifiant devient en lecture seule.
		/// </summary>
		/// <param name="genres">Liste des genres pour le combo.</param>
		/// <param name="publics">Liste des publics pour le combo.</param>
		/// <param name="rayons">Liste des rayons pour le combo.</param>
		/// <param name="dvdToEdit">DVD à modifier, ou <c>null</c> pour un ajout.</param>
		public FrmAjoutDvd(List<Categorie> genres, List<Categorie> publics, List<Categorie> rayons, Dvd dvdToEdit)
		{
			InitializeComponent();

			cbxGenre.DataSource = genres;
			cbxPublic.DataSource = publics;
			cbxRayon.DataSource = rayons;

			cbxGenre.DisplayMember = "Libelle";
			cbxPublic.DisplayMember = "Libelle";
			cbxRayon.DisplayMember = "Libelle";

			if (dvdToEdit != null)
			{
				this.Text = "Modifier un DVD";
				txbId.Text = dvdToEdit.Id;
				txbId.ReadOnly = true;
				txbTitre.Text = dvdToEdit.Titre;
				txbDuree.Text = dvdToEdit.Duree.ToString();
				txbRealisateur.Text = dvdToEdit.Realisateur ?? "";
				txbSynopsis.Text = dvdToEdit.Synopsis ?? "";
				cbxGenre.SelectedItem = genres.FirstOrDefault(g => g.Id == dvdToEdit.IdGenre);
				cbxPublic.SelectedItem = publics.FirstOrDefault(p => p.Id == dvdToEdit.IdPublic);
				cbxRayon.SelectedItem = rayons.FirstOrDefault(r => r.Id == dvdToEdit.IdRayon);
			}
			else
			{
				cbxGenre.SelectedIndex = -1;
				cbxPublic.SelectedIndex = -1;
				cbxRayon.SelectedIndex = -1;
			}
		}

		/// <summary>
		/// Valide la saisie et ferme le formulaire avec OK si les champs obligatoires sont renseignés.
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

			if (txbDuree.Text.Trim() == "" || DureeDvd <= 0)
			{
				MessageBox.Show("La durée doit être un nombre entier positif.");
				txbDuree.Focus();
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
