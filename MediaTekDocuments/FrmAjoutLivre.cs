using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MediaTekDocuments.model;

namespace MediaTekDocuments.view
{
	public partial class FrmAjoutLivre : Form
	{
		public string IdLivre => txbId.Text.Trim();
		public string TitreLivre => txbTitre.Text.Trim();
		public string AuteurLivre => txbAuteur.Text.Trim();
		public string IsbnLivre => txbIsbn.Text.Trim();

		public Categorie GenreSelectionne => cbxGenre.SelectedItem as Categorie;
		public Categorie PublicSelectionne => cbxPublic.SelectedItem as Categorie;
		public Categorie RayonSelectionne => cbxRayon.SelectedItem as Categorie;

		/// <summary>
		/// Constructeur pour ajout d'un livre
		/// </summary>
		public FrmAjoutLivre(List<Categorie> genres, List<Categorie> publics, List<Categorie> rayons)
			: this(genres, publics, rayons, null)
		{
		}

		/// <summary>
		/// Constructeur pour ajout ou modification. Si livreToEdit est fourni, mode modification (Id non modifiable).
		/// </summary>
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

		private void btnAnnuler_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}
}
