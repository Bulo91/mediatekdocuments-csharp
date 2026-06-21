using System;
using Newtonsoft.Json.Linq;
class T {
  static void Main() {
    var retour = JObject.Parse("{\"code\":200,\"message\":\"OK\",\"result\":[{\"id\":\"U0001\",\"login\":\"tout\",\"idService\":\"SVC01\",\"libelleService\":\"Direction\",\"accesDocuments\":1,\"accesCommandes\":1,\"accesExemplaires\":1,\"actif\":1}]}");
    try {
      String code = (String)retour["code"];
      Console.WriteLine("code cast: " + code);
      Console.WriteLine("equals 200: " + code.Equals("200"));
    } catch (Exception e) {
      Console.WriteLine("CAST ERROR: " + e.GetType().Name + " - " + e.Message);
    }
  }
}
