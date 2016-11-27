using System;
using System.Web.Optimization;

namespace EduSim.Web
{
	public class BundleConfig
	{
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.IgnoreList.Clear();
			bundles.Add(new StyleBundle("~/Content/css")
						.Include("~/Content/bootstrap.css"));
			bundles.Add(new StyleBundle("~/Content/kendo/css").Include(
				"~/Content/kendo/kendo.common-bootstrap.min.css",
				"~/Content/kendo/kendo.bootstrap.min.css"));

			bundles.Add(new StyleBundle("~/Content/site").Include(
			   "~/Content/site.css"));

			bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
				"~/Scripts/jquery-3.1.1.min.js"));

			bundles.Add(new ScriptBundle("~/bundles/kendo").Include(
				"~/Scripts/kendo/kendo.all.min.js",

				"~/Scripts/kendo/kendo.aspnetmvc.min.js",
				"~/Scripts/kendo/jszip.min.js"));
		}
	}
}
