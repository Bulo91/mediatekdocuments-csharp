using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MediaTekDocuments.model;

namespace MediaTekDocuments.view
{
    /// <summary>
    /// Fenêtre d'alerte : abonnements de revues se terminant dans moins de 30 jours (lecture seule).
    /// </summary>
    public partial class FrmAlertAbonnementsRevues : Form
    {
        /// <summary>
        /// Initialise la fenêtre d'alerte et remplit la grille avec les abonnements concernés.
        /// </summary>
        /// <param name="alertes">Liste des revues à risque (titre et date de fin d'abonnement).</param>
        public FrmAlertAbonnementsRevues(List<AlerteAbonnementRevue> alertes)
        {
            InitializeComponent();

            dgvAlertes.AutoGenerateColumns = false;
            dgvAlertes.ReadOnly = true;
            dgvAlertes.AllowUserToAddRows = false;
            dgvAlertes.AllowUserToDeleteRows = false;
            dgvAlertes.AllowUserToResizeRows = false;
            dgvAlertes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlertes.RowHeadersVisible = false;
            dgvAlertes.MultiSelect = false;

            foreach (var a in alertes.OrderBy(x => x.DateFinAbonnement))
            {
                dgvAlertes.Rows.Add(a.Titre ?? "", a.DateFinAbonnement.ToString("dd/MM/yyyy"));
            }

            dgvAlertes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
