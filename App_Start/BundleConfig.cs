﻿using System.Web;
using System.Web.Optimization;

namespace WebHamburgueria
{
    public class BundleConfig
    {
        // Para obter mais informações sobre o agrupamento, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use a versão em desenvolvimento do Modernizr para desenvolver e aprender com ela. Após isso, quando você estiver
            // pronto para a produção, utilize a ferramenta de build em https://modernizr.com para escolher somente os testes que precisa.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));



            bundles.Add(new ScriptBundle("~/lib/bootstrap/dist").Include(
                      "~/js/bootstrap.js"));

            bundles.Add(new StyleBundle("~/lib/bootstrap/dist").Include(
                      "~/css/bootstrap.css",
                      "~/css/site.css"));
        
            bundles.Add(new StyleBundle("~/Content/bootswatch").Include(
          "~/zephyr/bootstrap.css"));
        }
    }
}
