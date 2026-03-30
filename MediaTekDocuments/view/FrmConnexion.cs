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
        /// <summary>
        /// Contrôleur utilisé pour l'authentification via la couche d'accès aux données.
        /// </summary>
        private readonly FrmMediatekController controller;

        /// <summary>
        /// Initialise la fenêtre de connexion et le contrôleur associé.
        /// </summary>
        public FrmConnexion()
        {
            InitializeComponent();
            controller = new FrmMediatekController();
        }

        /// <summary>
        /// Gère le clic sur Valider : authentifie l'utilisateur et ferme avec OK si succès.
        /// </summary>
        /// <param name="sender">Source de l'événement.</param>
        /// <param name="e">Données de l'événement.</param>
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
        /// Gère le clic sur Annuler : ferme la fenêtre avec le résultat Cancel.
        /// </summary>
        /// <param name="sender">Source de l'événement.</param>
        /// <param name="e">Données de l'événement.</param>
        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
