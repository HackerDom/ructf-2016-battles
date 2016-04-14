using System;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ecuador.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			const string flag = "Pr0xysAreAwes0me";
			var request = HttpContext.Request;
			if (IsProperIp(request.UserHostAddress))
				return Content(String.Format("Your IP is {0} and here is your flag, buddy: {1}", request.UserHostAddress, flag));
			return Content(String.Format("Your IP is: {0} and this content is not available in your country", request.UserHostAddress));
		}

		private bool IsProperIp(string userHostAddress)
		{
			var russianIps = System.IO.File.ReadAllLines(Path.Combine(HttpRuntime.AppDomainAppPath,"ips.txt"));
			var parts = userHostAddress.Split('.');
			if (parts.Length > 0)
				if (russianIps.Select(ip => ip.Trim()).Contains(parts[0].Trim()))
					return false;
				else
				{
					return true;
				}
			return false;
		}
	}
}