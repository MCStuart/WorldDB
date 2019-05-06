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
     List <Country> countries = Country.GetCountries();
      return View();
   }

   // [HttpGet("/categories/{categoryId}/items/{itemId}")]
   // public ActionResult Show(int categoryId, int itemId)
   // {
   //   Item item = Item.Find(itemId);
   //   Dictionary<string, object> model = new Dictionary<string, object>();
   //   Category category = Category.Find(categoryId);
   //   model.Add("item", item);
   //   model.Add("category", category);
   //   return View(model);
   // }
   //
   // [HttpPost("/items/delete")]
   // public ActionResult DeleteAll()
   // {
   //   Item.ClearAll();
   //   return View();
   // }

 }
}
