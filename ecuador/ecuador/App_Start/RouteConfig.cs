using System.Web.Mvc;
using System.Web.Routing;

namespace ecuador
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
			routes.RouteExistingFiles = false;

			routes.MapRoute(
				name: "Default",
				url: "",
				defaults: new { controller = "Home", action = "Index" }
			);
		}
	}
}
