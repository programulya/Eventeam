using System.Collections.Generic;
using System.Web.Optimization;

namespace Eventeam
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/plugins").Include(
                "~/Scripts/scrolltopcontrol.js"));

            bundles.Add(new ScriptBundle("~/bundles/custom") {Orderer = new AsDefinedBundleOrderer()}.Include(
                "~/Scripts/app/custom.js",
                "~/Scripts/app/index.js"));

            bundles.Add(new ScriptBundle("~/bundles/home") {Orderer = new AsDefinedBundleOrderer()}.Include(
                "~/Scripts/jQuerySimpleCounter.js",
                "~/Scripts/app/home.js"));

            bundles.Add(new ScriptBundle("~/bundles/portfolio") {Orderer = new AsDefinedBundleOrderer()}.Include(
                "~/Scripts/app/portfolio.js"));

            bundles.Add(new ScriptBundle("~/bundles/portfolioItem") {Orderer = new AsDefinedBundleOrderer()}.Include(
                "~/Scripts/app/portfolioItem.js"));

            bundles.Add(new ScriptBundle("~/bundles/platforms") {Orderer = new AsDefinedBundleOrderer()}.Include(
                "~/Scripts/app/platforms.js"));

            bundles.Add(new StyleBundle("~/Content/site") {Orderer = new AsDefinedBundleOrderer()}.Include(
                "~/Content/style.css",
                "~/Content/animate.css",
                "~/Content/site.css",
                "~/Content/lightbox.css"));
        }

        private class AsDefinedBundleOrderer : IBundleOrderer
        {
            public IEnumerable<BundleFile> OrderFiles(BundleContext context, IEnumerable<BundleFile> files)
            {
                return files;
            }
        }
    }
}