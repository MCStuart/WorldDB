using Microsoft.AspNetCore.Mvc;
using WorldDB.Models;
using System.Collections.Generic;

namespace WorldDB.Controllers
{
 public class CountryController : Controller
 {

   [HttpGet("/countries")]
   public ActionResult Index()
   {
     List<Country> countries = Country.GetCountries();
     return View(countries);
   }


 }
}
