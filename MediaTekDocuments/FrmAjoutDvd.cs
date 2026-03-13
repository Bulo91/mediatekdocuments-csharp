using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MediaTekDocuments.model;

namespace MediaTekDocuments.view
{
	public partial class FrmAjoutDvd : Form
	{
		public string IdDvd => txbId.Text.Trim();
		public string TitreDvd => txbTitre.Text.Trim();
		public int DureeDvd
		{
			get
			{
				int d;
				return int.TryParse(txbDuree.Text.Trim(), out d) ? d : 0;
			}
		}
		public string RealisateurDvd => txbRealisateur.Text.Trim();
		public string SynopsisDvd => txbSynopsis.Text.Trim();

		public Categorie GenreSelectionne => cbxGenre.SelectedItem as Categorie;
		public Categorie PublicSelectionne => cbxPublic.SelectedItem as Categorie;
		public Categorie RayonSelectionne => cbxRayon.SelectedItem as Categorie;

		/// <summary>
		/// Constructeur pour ajout d'un DVD
		/// </summary>
		public FrmAjoutDvd(List<Categorie> genres, List<Categorie> publics, List<Categorie> rayons)
			: this(genres, publics, rayons, null)
		{
		}

		/// <summary>
		/// Constructeur pour ajout ou modification. Si dvdToEdit est fourni, mode modification (Id non modifiable).
		/// </summary>
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

		private void btnAnnuler_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}
}
