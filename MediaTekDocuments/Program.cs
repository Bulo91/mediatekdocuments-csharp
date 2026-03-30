using MediaTekDocuments.view;
using System;
using System.Windows.Forms;

namespace MediaTekDocuments
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal : active les styles visuels, affiche la connexion puis le formulaire principal si succès.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var frmConnexion = new FrmConnexion())
            {
                if (frmConnexion.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new FrmMediatek());
                }
            }
        }
    }
}
