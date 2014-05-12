using System.Web;
using System.Web.Optimization;

namespace MvcApplication1
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));


            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));
            bundles.Add(new ScriptBundle("~/bundles/boxgrid").Include("~/Scripts/customScripts/boxgrid.js",
                                                                     "~/Scripts/customScripts/jquery.fittext.js",
                                                                     "~/Scripts/customScripts/modernizr.custom.js"));
            
            bundles.Add(new ScriptBundle("~/bundles/ThumbnailGridTransition").Include("~/Scripts/customScripts/ThumbnailGridTransition.js",
                                                                                      "~/Scripts/customScripts/modernizr.custom.js"));

            bundles.Add(new ScriptBundle("~/bundles/FullscreenLayoutPageTransitions").Include("~/Scripts/customScripts/FullscreenLayoutPageTransitions.js",
                                                                          "~/Scripts/customScripts/modernizr.custom.js"));


            
          //  bundles.UseCdn = true;   //enable CDN support

            //add link to jquery on the CDN
            //var d3JsCdnPath = "http://d3js.org/d3.v3.min.js";

            //bundles.Add(new ScriptBundle("~/bundles/d3Js",
            //            d3JsCdnPath).Include(
            //            "~/Scripts/customScripts/d3.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/d3Js").Include("~/Scripts/customScripts/d3.js"));

            bundles.Add(new ScriptBundle("~/bundles/crossfilter").Include("~/Scripts/customScripts/crossfilter.js"));

            bundles.Add(new ScriptBundle("~/bundles/dcJs").Include("~/Scripts/customScripts/dc.js"));
            bundles.Add(new ScriptBundle("~/bundles/ScrollingJs").Include("~/Scripts/customScripts/ScrollingJs.js"));
            bundles.Add(new ScriptBundle("~/bundles/skrollr").Include("~/Scripts/customScripts/skrollr.js"));
        }
       

       
    }
}