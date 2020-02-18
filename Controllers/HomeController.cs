using Microsoft.AspNetCore.Mvc;

namespace CnRedirect.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string android = "0")
        {
            if (android == "1" && Request.Headers["User-Agent"].ToString().ToLower().Contains("micromessenger"))
            {
                Response.Headers.Add("Content-Disposition", "attachment; filename='openDefaultBrowser.pdf'");
                Response.ContentType = "application/pdf";
            }

            ViewBag.TargetUrl = "https://play.99168.fun";

            return View();
        }
    }
}
