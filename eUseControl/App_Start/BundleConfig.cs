using System.Web.Optimization;

namespace eUseControl
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {   //Styles
            bundles.Add(new StyleBundle("~/bundles/tanysher/css").Include("~/Content/bootstrap.min.css",
                "~/Content/font-awesome.min.css",
                "~/assets/css/styles.css",
                "~/assets/css/header/header.css",
                "~/assets/css/footer/footer.css"));
            bundles.Add(new StyleBundle("~/bundles/assets/css/index").Include("~/assets/css/index/index.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/assets/css/register").Include("~/assets/css/register/register.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/assets/css/logout").Include("~/assets/css/logout/logout.css", new CssRewriteUrlTransform()));


            //Scripts
            bundles.Add(new ScriptBundle("~/bundles/tanysher/js").Include("~/Scripts/jquery-{version}.js",
                "~/Scripts/bootstrap.min.js",
                "~/assets/js/main.js"));

            /*ADMIN******************************************************************************/
            bundles.Add(new StyleBundle("~/bundles/tsAdmin/css").Include("~/Content/bootstrap.min.css",
                "~/assets/css/admin/icons.min.css",
                "~/assets/css/admin/app.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/tsAdmin/js").Include("~/assets/js/admin/vendor.min.js",
                "~/assets/js/admin/libs/jquery-knob/jquery.knob.min.js",
                "~/assets/js/admin/libs/peity/jquery.peity.min.js",
                "~/assets/js/admin/libs/jquery-sparkline/jquery.sparkline.min.js",
                "~/assets/js/admin/pages/dashboard-1.init.js",
                "~/assets/js/admin/app.min.js"));
        }
    }
}
