namespace MediaTekDocuments.model
{
    /// <summary>
    /// Stocke l'utilisateur authentifié pendant l'exécution de l'application.
    /// </summary>
    public static class UtilisateurConnecte
    {
        /// <summary>
        /// Utilisateur actuellement connecté, ou null si non authentifié.
        /// </summary>
        public static Utilisateur Instance { get; set; }
    }
}
