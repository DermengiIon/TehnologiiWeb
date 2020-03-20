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
        }
    }
}
