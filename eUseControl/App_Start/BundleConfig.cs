using System.Web.Optimization;

namespace eUseControl
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {   //Styles
   /*         bundles.Add(new StyleBundle("~/bundles/tanysher/css").Include("~/Content/bootstrap.min.css",
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
                "~/assets/js/main.js"));*/

            /*ADMIN******************************************************************************/
            bundles.Add(new StyleBundle("~/bundles/app/css").Include(
                "~/Content/assets/css/bootstrap.min.css",
                "~/Content/assets/css/icons.min.css",
                "~/Content/assets/css/app.min.css"
            ));

            bundles.Add(new StyleBundle("~/bundles/footer/css").Include(
                "~/Content/assets/css/footer/footer.css"
            ));

            bundles.Add(new StyleBundle("~/bundles/footable/css").Include(
                "~/Content/assets/css/footable.core.min.css"
            ));

            bundles.Add(new StyleBundle("~/bundles/product/css").Include(
                "~/Content/assets/css/dropzone.min.css",
                "~/Content/assets/css/select2.min.css",
                "~/Content/assets/css/bootstrap-select.min.css"
            ));

            bundles.Add(new StyleBundle("~/bundles/products/css").Include(
                "~/Content/assets/css/magnific-popup.css"
            ));

            /*JS*/
            bundles.Add(new ScriptBundle("~/bundles/vendor/js").Include(
                "~/Content/assets/js/vendor.min.js"
            ));

            bundles.Add(new ScriptBundle("~/bundles/app/js").Include(
                "~/Content/assets/js/app.min.js"
            ));

            bundles.Add(new ScriptBundle("~/bundles/dashboard/js").Include(
                "~/Content/assets/js/jquery.knob.min.js",
                "~/Content/assets/js/jquery.peity.min.js",
                "~/Content/assets/js/jquery.sparkline.min.js",
                "~/Content/assets/js/dashboard-1.init.js"
            ));

            bundles.Add(new ScriptBundle("~/bundles/footable/js").Include(
                "~/Content/assets/js/footable.all.min.js",
                "~/Content/assets/js/foo-tables.init.js"
            ));

            bundles.Add(new ScriptBundle("~/bundles/product/js").Include(
                "~/Content/assets/js/dropzone.min.js",
                "~/Content/assets/js/form-fileuploads.init.js",
                "~/Content/assets/js/parsley.min.js",
                "~/Content/assets/js/form-validation.init.js",
                "~/Content/assets/js/jquery.multi-select.js",
                "~/Content/assets/js/select2.min.js",
                "~/Content/assets/js/bootstrap-select.min.js",
                "~/Content/assets/js/jquery.bootstrap-touchspin.min.js",
                "~/Content/assets/js/form-advanced.init.js"
            ));

            bundles.Add(new ScriptBundle("~/bundles/products/js").Include(
                "~/Content/assets/js/jquery.magnific-popup.min.js",
                "~/Content/assets/js/gallery.init.js"
            ));
        }
    }
}
