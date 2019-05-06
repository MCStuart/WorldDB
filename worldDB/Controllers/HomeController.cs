using Microsoft.AspNetCore.Mvc;
using WorldDB.Models;

namespace WorldDB.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}
