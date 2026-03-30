using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MediaTekDocuments.model;

namespace MediaTekDocuments.view
{
	/// <summary>
	/// Formulaire modal de saisie ou de modification d'une revue (périodicité, délai de mise à disposition, classifications).
	/// </summary>
	public partial class FrmAjoutRevue : Form
	{
		/// <summary>
		/// Obtient l'identifiant saisi pour la revue.
		/// </summary>
		public string IdRevue => txbId.Text.Trim();
		/// <summary>
		/// Obtient le titre saisi.
		/// </summary>
		public string TitreRevue => txbTitre.Text.Trim();
		/// <summary>
		/// Obtient la périodicité saisie.
		/// </summary>
		public string PeriodiciteRevue => txbPeriodicite.Text.Trim();
		/// <summary>
		/// Obtient le délai de mise à disposition en jours (0 si la saisie n'est pas un entier valide).
		/// </summary>
		public int DelaiMiseADispoRevue
		{
			get
			{
				int d;
				return int.TryParse(txbDelaiMiseADispo.Text.Trim(), out d) ? d : 0;
			}
		}

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
		/// Initialise le formulaire en mode création d'une revue.
		/// </summary>
		/// <param name="genres">Liste des genres pour le combo.</param>
		/// <param name="publics">Liste des publics pour le combo.</param>
		/// <param name="rayons">Liste des rayons pour le combo.</param>
		public FrmAjoutRevue(List<Categorie> genres, List<Categorie> publics, List<Categorie> rayons)
			: this(genres, publics, rayons, null)
		{
		}

		/// <summary>
		/// Initialise le formulaire en mode création ou modification. Si <paramref name="revueToEdit"/> est renseigné, l'identifiant devient en lecture seule.
		/// </summary>
		/// <param name="genres">Liste des genres pour le combo.</param>
		/// <param name="publics">Liste des publics pour le combo.</param>
		/// <param name="rayons">Liste des rayons pour le combo.</param>
		/// <param name="revueToEdit">Revue à modifier, ou <c>null</c> pour un ajout.</param>
		public FrmAjoutRevue(List<Categorie> genres, List<Categorie> publics, List<Categorie> rayons, Revue revueToEdit)
		{
			InitializeComponent();

			cbxGenre.DataSource = genres;
			cbxPublic.DataSource = publics;
			cbxRayon.DataSource = rayons;

			cbxGenre.DisplayMember = "Libelle";
			cbxPublic.DisplayMember = "Libelle";
			cbxRayon.DisplayMember = "Libelle";

			if (revueToEdit != null)
			{
				this.Text = "Modifier une revue";
				txbId.Text = revueToEdit.Id;
				txbId.ReadOnly = true;
				txbTitre.Text = revueToEdit.Titre;
				txbPeriodicite.Text = revueToEdit.Periodicite ?? "";
				txbDelaiMiseADispo.Text = revueToEdit.DelaiMiseADispo.ToString();
				cbxGenre.SelectedItem = genres.FirstOrDefault(g => g.Id == revueToEdit.IdGenre);
				cbxPublic.SelectedItem = publics.FirstOrDefault(p => p.Id == revueToEdit.IdPublic);
				cbxRayon.SelectedItem = rayons.FirstOrDefault(r => r.Id == revueToEdit.IdRayon);
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

			if (txbPeriodicite.Text.Trim() == "")
			{
				MessageBox.Show("La périodicité est obligatoire.");
				txbPeriodicite.Focus();
				return;
			}

			if (txbDelaiMiseADispo.Text.Trim() == "" || DelaiMiseADispoRevue < 0)
			{
				MessageBox.Show("Le délai de mise à disposition doit être un nombre entier positif ou nul.");
				txbDelaiMiseADispo.Focus();
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
