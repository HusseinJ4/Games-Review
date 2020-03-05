using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GamesReview.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        public ActionResult Index()
        {
            return View("Shop Index");
        }

        public string Product( int id)
        {
            return "Product page =" + id.ToString();
        }
    }
}