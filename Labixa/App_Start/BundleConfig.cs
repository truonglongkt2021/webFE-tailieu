using System.Web;
using System.Web.Optimization;

namespace Labixa
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //CSS for authen admin
            bundles.Add(new StyleBundle("~/Style/AssetsAuthen").Include("~/Areas/Admin/Contents/assets/css/bootstrap.min.css",
                "~/Areas/Admin/Contents/assets/font-awesome/4.5.0/css/font-awesome.min.css",
                "~/Areas/Admin/Contents/assets/css/fonts.googleapis.com.css",
                "~/Areas/Admin/Contents/assets/css/ace.min.css",
                "~/Areas/Admin/Contents/assets/css/ace-rtl.min.css"
                ));
            //JS for authen admin
            bundles.Add(new ScriptBundle("~/Scripts/AssetsAuthen").Include(
                "~/Areas/Admin/Contents/assets/js/jquery-2.1.4.min.js"
                ));
            //CSS for  Ace admin
            bundles.Add(new StyleBundle("~/Style/Common").Include(
     "~/Content/admin/css/bootstrap.min.css",
      "~/Content/admin/css/font-awesome.min.css",
       "~/Content/admin/css/ace.min.css",
       "~/Content/admin/css/ace-rtl.min.css",
         "~/Content/admin/css/ace-skins.min.css",
         "~/Content/admin/css/ace-fonts.css",
          "~/Content/admin/css/datepicker.css",
          "~/Content/admin/css/font-awesome.min.css",
         "~/Content/admin/admincustom.css"
            ));

            //Scipts for  Ace admin
            bundles.Add(new ScriptBundle("~/Scripts/Common").Include(
    "~/Content/admin/js/jquery-2.0.3.min.js",
    "~/Content/admin/js/bootstrap.min.js",
    "~/Content/admin/js/jquery-ui-1.10.3.full.min.js",
    "~/Content/admin/js/date-time/bootstrap-datepicker.min.js",
                    "~/Content/assets/js/ace-elements.min.js",
    "~/Content/admin/js/ace.min.js",
    "~/Content/admin/js/ace-extra.min.js",
    "~/Content/admin/vpn/adminvpn.js"
            ));
        }
    }
}
