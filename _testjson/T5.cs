using System;
using System.Net.Http;
class T {
  static void PrintEx(Exception e, int depth) {
    Console.WriteLine(new string(' ', depth*2) + e.GetType().FullName + ": " + e.Message);
    if (e.InnerException != null) PrintEx(e.InnerException, depth+1);
  }
  static void Main() {
    try {
      var httpClient = new HttpClient() { BaseAddress = new Uri("https://mediatekdocuments.myartsonline.com/") };
      string credentials = Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes("mediatkuser:mediatkpwd"));
      httpClient.DefaultRequestHeaders.Add("Authorization", "Basic " + credentials);
      var obj = new { login = "tout", motDePasse = "ToutPwd_1" };
      string jsonChamps = Newtonsoft.Json.JsonConvert.SerializeObject(obj);
      string message = "authentification/" + Uri.EscapeDataString(jsonChamps);
      var httpResponse = httpClient.GetAsync(message).Result;
      var json = httpResponse.Content.ReadAsStringAsync().Result;
      Console.WriteLine("Response: " + json);
    } catch (Exception e) {
      PrintEx(e, 0);
    }
  }
}
