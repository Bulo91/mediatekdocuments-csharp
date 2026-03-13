using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MediaTekDocuments.model;

namespace MediaTekDocuments.view
{
	public partial class FrmAjoutRevue : Form
	{
		public string IdRevue => txbId.Text.Trim();
		public string TitreRevue => txbTitre.Text.Trim();
		public string PeriodiciteRevue => txbPeriodicite.Text.Trim();
		public int DelaiMiseADispoRevue
		{
			get
			{
				int d;
				return int.TryParse(txbDelaiMiseADispo.Text.Trim(), out d) ? d : 0;
			}
		}

		public Categorie GenreSelectionne => cbxGenre.SelectedItem as Categorie;
		public Categorie PublicSelectionne => cbxPublic.SelectedItem as Categorie;
		public Categorie RayonSelectionne => cbxRayon.SelectedItem as Categorie;

		/// <summary>
		/// Constructeur pour ajout d'une revue
		/// </summary>
		public FrmAjoutRevue(List<Categorie> genres, List<Categorie> publics, List<Categorie> rayons)
			: this(genres, publics, rayons, null)
		{
		}

		/// <summary>
		/// Constructeur pour ajout ou modification. Si revueToEdit est fourni, mode modification (Id non modifiable).
		/// </summary>
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

		private void btnAnnuler_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}
}
