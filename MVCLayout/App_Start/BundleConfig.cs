using System.Web;
using System.Web.Optimization;

namespace MVCLayout
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/custom").Include("~/Scripts/scripts.js"));
            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/styles.css"));
        }
    }
}
