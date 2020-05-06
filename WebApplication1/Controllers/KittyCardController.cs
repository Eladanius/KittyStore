using System;
using System.Collections.Generic;
using System.Linq;
using KittyStore.Mongo;
using System.Web.Mvc;

namespace KittyStore.Controllers
{
    public class KittyCardController : Controller
    {
        public ActionResult KittyCard(string id)
        {
            //ViewBag.kittyData = Service.GetAllKittiesData().Find(el => el.Id.Equals(id));
            return View();
        }
    }
}