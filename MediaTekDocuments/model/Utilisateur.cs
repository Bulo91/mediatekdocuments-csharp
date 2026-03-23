using Newtonsoft.Json;

namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe métier Utilisateur : identifie un utilisateur connecté et ses droits liés au service.
    /// </summary>
    public class Utilisateur
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("idService")]
        public string IdService { get; set; }

        [JsonProperty("libelleService")]
        public string LibelleService { get; set; }

        [JsonProperty("accesDocuments")]
        public bool AccesDocuments { get; set; }

        [JsonProperty("accesCommandes")]
        public bool AccesCommandes { get; set; }

        [JsonProperty("accesExemplaires")]
        public bool AccesExemplaires { get; set; }

        [JsonProperty("actif")]
        public bool Actif { get; set; }
    }
}
