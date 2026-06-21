using System;
using System.Configuration;
using MediaTekDocuments.dal;
using MediaTekDocuments.controller;

class AuthTest
{
    static int Main()
    {
        try
        {
            var controller = new FrmMediatekController();
            var user = controller.AuthentifierUtilisateur("tout", "ToutPwd_1");
            if (user == null)
            {
                Console.WriteLine("FAIL: utilisateur null");
                return 1;
            }
            Console.WriteLine("OK: login=" + user.Login + " service=" + user.LibelleService);
            Console.WriteLine("AccesDocuments=" + user.AccesDocuments);
            return 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine("EXCEPTION: " + ex.GetType().Name + " - " + ex.Message);
            var inner = ex.InnerException;
            while (inner != null)
            {
                Console.WriteLine("  INNER: " + inner.GetType().Name + " - " + inner.Message);
                inner = inner.InnerException;
            }
            return 2;
        }
    }
}
