using Newtonsoft.Json;

namespace MediaTekDocuments.model
{
    /// <summary>
    /// Représente un utilisateur de l'application : identité, service et droits d'accès aux fonctionnalités.
    /// </summary>
    public class Utilisateur
    {
        /// <summary>
        /// Obtient ou définit l'identifiant de l'utilisateur (JSON : id).
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Obtient ou définit le nom de connexion (JSON : login).
        /// </summary>
        [JsonProperty("login")]
        public string Login { get; set; }

        /// <summary>
        /// Obtient ou définit l'identifiant du service (JSON : idService).
        /// </summary>
        [JsonProperty("idService")]
        public string IdService { get; set; }

        /// <summary>
        /// Obtient ou définit le libellé du service (JSON : libelleService).
        /// </summary>
        [JsonProperty("libelleService")]
        public string LibelleService { get; set; }

        /// <summary>
        /// Obtient ou définit une valeur indiquant si l'utilisateur peut gérer les documents (JSON : accesDocuments).
        /// </summary>
        [JsonProperty("accesDocuments")]
        public bool AccesDocuments { get; set; }

        /// <summary>
        /// Obtient ou définit une valeur indiquant si l'utilisateur peut gérer les commandes (JSON : accesCommandes).
        /// </summary>
        [JsonProperty("accesCommandes")]
        public bool AccesCommandes { get; set; }

        /// <summary>
        /// Obtient ou définit une valeur indiquant si l'utilisateur peut gérer les exemplaires (JSON : accesExemplaires).
        /// </summary>
        [JsonProperty("accesExemplaires")]
        public bool AccesExemplaires { get; set; }

        /// <summary>
        /// Obtient ou définit une valeur indiquant si le compte est actif (JSON : actif).
        /// </summary>
        [JsonProperty("actif")]
        public bool Actif { get; set; }
    }
}
