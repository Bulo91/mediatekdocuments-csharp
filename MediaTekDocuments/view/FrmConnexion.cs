using System;
using System.Windows.Forms;
using MediaTekDocuments.controller;
using MediaTekDocuments.model;

namespace MediaTekDocuments.view
{
    /// <summary>
    /// Fenêtre d'authentification : saisie login/mot de passe et validation.
    /// </summary>
    public partial class FrmConnexion : Form
    {
        private readonly FrmMediatekController controller;

        public FrmConnexion()
        {
            InitializeComponent();
            controller = new FrmMediatekController();
        }

        /// <summary>
        /// Clic sur Valider : authentifie l'utilisateur et ferme avec OK si succès.
        /// </summary>
        private void BtnValider_Click(object sender, EventArgs e)
        {
            string login = txbLogin.Text?.Trim() ?? "";
            string motDePasse = txbMotDePasse.Text ?? "";

            if (string.IsNullOrEmpty(login))
            {
                MessageBox.Show("Veuillez saisir le login.", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbLogin.Focus();
                return;
            }

            var utilisateur = controller.AuthentifierUtilisateur(login, motDePasse);
            if (utilisateur != null)
            {
                UtilisateurConnecte.Instance = utilisateur;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Identifiants incorrects.", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbMotDePasse.Clear();
                txbMotDePasse.Focus();
            }
        }

        /// <summary>
        /// Clic sur Annuler : ferme avec Cancel.
        /// </summary>
        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
