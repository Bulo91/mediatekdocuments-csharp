using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class CustomBooleanJsonConverter : JsonConverter<bool> {
  public override bool ReadJson(JsonReader reader, Type objectType, bool existingValue, bool hasExistingValue, JsonSerializer serializer) {
    return Convert.ToBoolean(reader.ValueType == typeof(string) ? Convert.ToByte(reader.Value) : reader.Value);
  }
  public override void WriteJson(JsonWriter writer, bool value, JsonSerializer serializer) { serializer.Serialize(writer, value); }
}

// Simplified copies - same structure as project
namespace MediaTekDocuments.model {
  public class Document {
    public string Id { get; }
    public string Titre { get; }
    public string Image { get; }
    public string IdGenre { get; }
    public string Genre { get; }
    public string IdPublic { get; }
    public string Public { get; }
    public string IdRayon { get; }
    public string Rayon { get; }
    public Document(string id, string titre, string image, string idGenre, string genre, string idPublic, string lePublic, string idRayon, string rayon) {
      Id = id; Titre = titre; Image = image; IdGenre = idGenre; Genre = genre;
      IdPublic = idPublic; Public = lePublic; IdRayon = idRayon; Rayon = rayon;
    }
  }
  public abstract class LivreDvd : Document {
    protected LivreDvd(string id, string titre, string image, string idGenre, string genre, string idPublic, string lePublic, string idRayon, string rayon)
      : base(id, titre, image, idGenre, genre, idPublic, lePublic, idRayon, rayon) {}
  }
  public class Livre : LivreDvd {
    public string Isbn { get; }
    public string Auteur { get; }
    public string Collection { get; }
    public Livre(string id, string titre, string image, string isbn, string auteur, string collection, string idGenre, string genre, string idPublic, string lePublic, string idRayon, string rayon)
      : base(id, titre, image, idGenre, genre, idPublic, lePublic, idRayon, rayon) {
      Isbn = isbn; Auteur = auteur; Collection = collection;
    }
  }
}

class T {
  static void Main() {
    var retour = JObject.Parse(File.ReadAllText(@"c:\Slam\mediatekdocuments\_testjson\livre.json"));
    String resultString = JsonConvert.SerializeObject(retour["result"]);
    try {
      var liste = JsonConvert.DeserializeObject<List<MediaTekDocuments.model.Livre>>(resultString, new CustomBooleanJsonConverter());
      Console.WriteLine("OK count=" + liste.Count + " titre=" + liste[0].Titre);
    } catch (Exception e) {
      Console.WriteLine("ERROR: " + e.GetType().FullName);
      Console.WriteLine(e.Message);
    }
  }
}
