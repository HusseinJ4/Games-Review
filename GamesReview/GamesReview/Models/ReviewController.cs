using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GamesReview.Models
{
    public class ReviewController : Controller
    {
        // GET: Review
        public ActionResult Index()
        {
            return View();
        }

    }
}