using System.Web;
using System.Web.Optimization;

namespace Projet_Turquoise
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                     "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/_references.js",
                      "~/Scripts/autosize.min.js",
                      "~/Scripts/bootstrap-progressbar.min.js",
                      "~/Scripts/bootstrap-wysiwyg.min.js",
                      "~/Scripts/daterangepicker.js",
                      "~/Scripts/custom.min.js",
                      "~/Scripts/easing.js",
                      "~/Scripts/fastclick.js",
                      "~/Scripts/icheck.js",
                      "~/Scripts/imagezoom.js",
                      "~/Scripts/jquery-1.10.2.intellisense.js",
                      "~/Scripts/megamenu.js",
                      "~/Scripts/menu_jquery.js",
                      "~/Scripts/scripts.js",
                      "~/Scripts/jquery-1.10.2.min.js",
                      "~/Scripts/jquery-1.10.2.min.map",
                      "~/Scripts/jquery-1.11.1.min.js",
                      "~/Scripts/jquery.autocomplete.min.js",
                      "~/Scripts/jquery.flexisel.js",
                      "~/Scripts/jquery.flexislider.js",
                      "~/Scripts/jquery.hotkeys.js",
                      "~/Scripts/jquery.jscrollpane.min.js",
                      "~/Scripts/jquery.tagsinput.js",
                      "~/Scripts/jquery.validate-vsdoc.js",
                      "~/Scripts/jquery.validate.js",
                      "~/Scripts/jquery.validate.unobtrosive.js",
                      "~/Scripts/modernizr-2.6.2.js",
                      "~/Scripts/moments.js",
                      "~/Scripts/move-top.js",
                      "~/Scripts/nprogress.js",
                      "~/Scripts/prettify.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/starrr.js",
                      "~/Scripts/select2.full.min.js",
                      "~/Scripts/switchery.min.js",
                      "~/Scripts/parsley.min.js"

                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                     // "~/Content/animate.min.css",
                     // "~/Content/custom.min.css",
                          "~/Content/animate.css",
                      "~/Content/custom.css",
                      "~/Content/daterangepiker.css",
                      "~/Content/flexslider.css",
                      //   "~/Content/font-awesome.min.css",
                        "~/Content/font-awesome.css",
                      "~/Content/green.css",
                      "~/Content/megamenu.css",
                      "~/Content/nprogress.css",
                      //  "~/Content/prettify.min.css",
                      //  "~/Content/select2.min.css",
                       "~/Content/prettify.css",
                        "~/Content/select2.css",
                      "~/Content/Site.css"));
           
        }
       
    }
}
