using System.Web.Optimization;

namespace MGRescue_System
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

            bundles.Add(new StyleBundle("~/Content/Impact/css").Include(
                      "~/Content/Impact/bootstrap.min.css",
                      "~/Content/Impact/style.css",
                      "~/Content/Impact/animate.css",
                      "~/Content/Impact/font-awesome.min.css",
                      "~/Content/Impact/pre-icons.css",
                      "~/Content/Impact/prettyPhoto.css"));

            bundles.Add(new ScriptBundle("~/bundles/impact").Include(
                      "~/Scripts/Impact/html5shiv.js",
                      "~/Scripts/Impact/jquery.js",
                      "~/Scripts/Impact/respond.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/impact2").Include(
                      "~/Scripts/Impact/plugins.js",
                      "~/Scripts/Impact/bootstrap.min.js",
                      "~/Scripts/Impact/jquery.prettyPhoto.js",
                      "~/Scripts/Impact/init.js"));

            bundles.Add(new StyleBundle("~/Content/vendors_css/css").Include(
                      "~/Content/vendors_css/bootstrap.min.css",
                      "~/Content/vendors_css/custom.min.css",
                      "~/Content/vendors_css/green.css",
                      "~/Content/vendors_css/buttons.bootstrap.min.css",
                      "~/Content/vendors_css/dataTables.bootstrap.min.css",
                      "~/Content/vendors_css/fixedHeader.bootstrap.min.css",
                      "~/Content/vendors_css/nprogress.css",
                      "~/Content/vendors_css/responsive.bootstrap.min.css",
                      "~/Content/vendors_css/scroler.bootstrap.min.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/Impact/bootstrap.min.css",
                      "~/Content/Impact/custom.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/vendors").Include(
                      "~/Scripts/vendors_js/bootstrap-progressbar.min.js",
                      "~/Scripts/vendors_js/Chart.min.js",
                      "~/Scripts/vendors_js/curvedLines.js",
                      "~/Scripts/vendors_js/custom.min.js",
                      "~/Scripts/vendors_js/date.js",
                      "~/Scripts/vendors_js/daterangepicker.js",
                      "~/Scripts/vendors_js/fastclick.js",
                      "~/Scripts/vendors_js/gauge.min.js",
                      "~/Scripts/vendors_js/icheck.min.js",
                      "~/Scripts/vendors_js/jquery.flot.js",
                      "~/Scripts/vendors_js/jquery.flot.orderBars.js",
                      "~/Scripts/vendors_js/jquery.flot.pie.js",
                      "~/Scripts/vendors_js/jquery.flot.resize.js",
                      "~/Scripts/vendors_js/jquery.flot.spline.min.js",
                      "~/Scripts/vendors_js/jquery.flot.stack.js",
                      "~/Scripts/vendors_js/jquery.flot.time.js",
                      "~/Scripts/vendors_js/jquery.vmap.js",
                      "~/Scripts/vendors_js/jquery.vmap.sampledata.js",
                      "~/Scripts/vendors_js/jquery.vmap.world.js",
                      "~/Scripts/vendors_js/moment.min.js",
                      "~/Scripts/vendors_js/nprogress.js",
                      "~/Scripts/vendors_js/skycons.js"));

            bundles.Add(new ScriptBundle("~/bundles/dataTables").Include(
                      "~/Content/vendors/jquery/dist/jquery.min.js",
                      "~/Content/vendors/bootstrap/dist/js/bootstrap.min.js",
                      "~/Content/vendors/fastclick/lib/fastclick.js",
                      "~/Content/vendors/nprogress/nprogress.js",
                      "~/Content/vendors/iCheck/icheck.min.js",
                      "~/Content/vendors/datatables.net/js/jquery.dataTables.min.js",
                      "~/Content/vendors/datatables.net-bs/js/dataTables.bootstrap.min.js",
                      "~/Content/vendors/datatables.net-buttons/js/dataTables.buttons.min.js",
                      "~/Content/vendors/datatables.net-buttons-bs/js/buttons.bootstrap.min.js",
                      "~/Content/vendors/datatables.net-buttons/js/buttons.flash.min.js",
                      "~/Content/vendors/datatables.net-buttons/js/buttons.html5.min.js",
                      "~/Content/vendors/datatables.net-buttons/js/buttons.print.min.js",
                      "~/Content/vendors/datatables.net-fixedheader/js/dataTables.fixedHeader.min.js",
                      "~/Content/vendors/datatables.net-keytable/js/dataTables.keyTable.min.js",
                      "~/Content/vendors/datatables.net-responsive/js/dataTables.responsive.min.js",
                      "~/Content/vendors/datatables.net-responsive-bs/js/responsive.bootstrap.js",
                      "~/Content/vendors/datatables.net-scroller/js/dataTables.scroller.min.js",
                      "~/Content/vendors/jszip/dist/jszip.min.js",
                      "~/Content/vendors/pdfmake/build/pdfmake.min.js",
                      "~/Content/vendors/pdfmake/build/vfs_fonts.js",
                      "~/Content/vendors/custom.min.js"));
        }
    }
}
