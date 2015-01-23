using System.Web;
using System.Web.Optimization;

namespace Simorgh
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
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/main_scripts").Include(
                      "~/Scripts/new/js/jquery.min.js",
                      "~/Scripts/new/jquery-migrate-1.2.1.min.js",
                      "~/Scripts/new/bootstrap.min.js",
                      "~/Scripts/new/js/style-switcher/colorpicker.js",
                      "~/Scripts/new/js/style-switcher/jquery.cookie.js",
                      "~/Scripts/new/js/style-switcher/styleswitch.js",
                      "~/Scripts/new/js/style-switcher/switcher2.js",
                      "~/Scripts/new/js/jquery.customSelect.latest.min.js",
                      "~/Scripts/new/js/bootstrap-datepicker.js",
                      "~/Scripts/new/js/jquery-hoverIntent.js",
                      "~/Scripts/new/js/jquery.flexslider.js",
                      "~/Scripts/new/js/jquery.counterup.min.js",
                      "~/Scripts/new/js/waypoints.min.js",
                      "~/Scripts/new/js/jquery.prettyPhoto.js",
                      "~/Scripts/new/js/custom.js"));

//            bundles.Add(new StyleBundle("~/Content/css").Include(
//                      "~/Content/bootstrap.css",
//                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/new/googlefont.css",
                      "~/Content/new/bootstrap.min.css",
                      "~/Content/new/css/green/style.css",
                      "~/Content/new/css/datepicker.css",
                      "~/Content/new/font-awesome.min.css",
                      "~/Content/new/css/hover-min.css",
                      "~/Content/new/css/flexslider.css",
                      "~/Content/new/css/prettyPhoto.css",
                      "~/Content/new/css/style-switcher.css"));
        
        }
    }
}
