using System;
using System.Net;
using System.Net.Http;
using System.Text;
class T {
  static void PrintEx(Exception e, int d) {
    Console.WriteLine(new string(' ', d*2) + e.GetType().FullName + ": " + e.Message);
    if (e.InnerException != null) PrintEx(e.InnerException, d+1);
  }
  static void Main() {
    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
    try {
      var c = new HttpClient() { BaseAddress = new Uri("https://mediatekdocuments.myartsonline.com/") };
      string cred = Convert.ToBase64String(Encoding.ASCII.GetBytes("mediatkuser:mediatkpwd"));
      c.DefaultRequestHeaders.Add("Authorization", "Basic " + cred);
      var r = c.GetAsync("genre").Result;
      Console.WriteLine("Status: " + r.StatusCode);
      Console.WriteLine(r.Content.ReadAsStringAsync().Result.Substring(0, 80));
    } catch (Exception e) { PrintEx(e, 0); }
  }
}
