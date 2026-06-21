using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
class CustomBooleanJsonConverter : JsonConverter<bool> {
  public override bool ReadJson(JsonReader reader, Type objectType, bool existingValue, bool hasExistingValue, JsonSerializer serializer) {
    return Convert.ToBoolean(reader.ValueType == typeof(string) ? Convert.ToByte(reader.Value) : reader.Value);
  }
  public override void WriteJson(JsonWriter writer, bool value, JsonSerializer serializer) { serializer.Serialize(writer, value); }
}
class Utilisateur {
  [JsonProperty("id")] public string Id { get; set; }
  [JsonProperty("login")] public string Login { get; set; }
  [JsonProperty("idService")] public string IdService { get; set; }
  [JsonProperty("libelleService")] public string LibelleService { get; set; }
  [JsonProperty("accesDocuments")] public bool AccesDocuments { get; set; }
  [JsonProperty("accesCommandes")] public bool AccesCommandes { get; set; }
  [JsonProperty("accesExemplaires")] public bool AccesExemplaires { get; set; }
  [JsonProperty("actif")] public bool Actif { get; set; }
}
class T {
  static void Main() {
    try {
      var httpClient = new HttpClient() { BaseAddress = new Uri("https://mediatekdocuments.myartsonline.com/") };
      string credentials = Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes("mediatkuser:mediatkpwd"));
      httpClient.DefaultRequestHeaders.Add("Authorization", "Basic " + credentials);
      var obj = new { login = "tout", motDePasse = "ToutPwd_1" };
      string jsonChamps = JsonConvert.SerializeObject(obj);
      string message = "authentification/" + Uri.EscapeDataString(jsonChamps);
      Console.WriteLine("URL: " + httpClient.BaseAddress + message);
      var httpResponse = httpClient.GetAsync(message).Result;
      var json = httpResponse.Content.ReadAsStringAsync().Result;
      Console.WriteLine("Response: " + json);
      JObject retour = JObject.Parse(json);
      String code = (String)retour["code"];
      Console.WriteLine("code=" + code);
      if (code.Equals("200")) {
        String resultString = JsonConvert.SerializeObject(retour["result"]);
        var liste = JsonConvert.DeserializeObject<List<Utilisateur>>(resultString, new CustomBooleanJsonConverter());
        Console.WriteLine("OK user=" + liste[0].Login + " docs=" + liste[0].AccesDocuments);
      }
    } catch (Exception e) {
      Console.WriteLine("ERROR: " + e.GetType().FullName);
      Console.WriteLine(e.Message);
      Console.WriteLine(e.StackTrace);
    }
  }
}
