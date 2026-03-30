namespace MediaTekDocuments.model
{
    /// <summary>
    /// Point d'accès statique à l'utilisateur authentifié pendant l'exécution de l'application.
    /// </summary>
    public static class UtilisateurConnecte
    {
        /// <summary>
        /// Obtient ou définit l'utilisateur actuellement connecté, ou <c>null</c> si aucune session n'est ouverte.
        /// </summary>
        public static Utilisateur Instance { get; set; }
    }
}
