using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace _22_AspNetMvcBundles.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //CSS-StyleBundle
            bundles.Add(new StyleBundle("~/css/all").Include(
                "~/Content/bootstrap.css",
                "~/Content/bootstrap-theme.css",
                "~/Content/Site.css"));


            bundles.Add(new StyleBundle("~/css/basic").Include(
              "~/Content/bootstrap.css",
              "~/Content/Site.css"));
            

            ////JS - ScriptBundle
            //bundles.Add(new ScriptBundle("~/js/all").IncludeDirectory(
            //    "~/Scripts", "*.js", true));   //uzantisi .js olan tüm scriptleri ekler. Include Directory ile sub klasorlerdekini de buldu.


            //JS-ScriptBundle-CDN kullanimi
            bundles.UseCdn = true;
            string jQcdn = "https://code.jquery.com/jquery-2.2.44.js";

            bundles.Add(new ScriptBundle("~/js/all",jQcdn).Include(
                "~/Scripts/jquery-{version}.js"));


            ////JS-ScriptBundle
            //bundles.Add(new ScriptBundle("~/js/all").Include(
            //    "~/Scripts/jquery-{version}.js",
            //    "~/Scripts/bootstrap.js",
            //    "~/Scripts/modernizr-{version}.js"));

            /*BundleTable.EnableOptimizations = false; *///olusturulan paketlerin minimize edilerek tek dosya olusturularak sayfaya eklenmesini saglar.
        }
    }
}