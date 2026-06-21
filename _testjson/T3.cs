using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
class T {
  static void Main() {
    var retour = JObject.Parse("{\"code\":401,\"message\":\"authentification incorrecte\",\"result\":\"\"}");
    String code = (String)retour["code"];
    Console.WriteLine("code=" + code + " equals200=" + (code != null && code.Equals("200")));
    if (code.Equals("200")) {
      String resultString = JsonConvert.SerializeObject(retour["result"]);
      Console.WriteLine("resultString=" + resultString);
      try {
        var liste = JsonConvert.DeserializeObject<System.Collections.Generic.List<string>>(resultString);
      } catch (Exception e) {
        Console.WriteLine("DESER ERROR: " + e.GetType().Name + " " + e.Message);
      }
    } else {
      Console.WriteLine("not 200 branch");
    }
  }
}
