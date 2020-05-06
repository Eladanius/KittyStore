using System.Web.Mvc;
using KittyStore.Mongo;

namespace KittyStore.Controllers
{
    public class HomeController : Controller
    {
        KittyCardController kittyCardController = new KittyCardController();
        public ActionResult Home()
        {
            ViewBag.kittiesData = Service.GetAllKittiesData();
            return View();
        }

        [HttpGet]
        public void KittyCard(string id)
        {
            if (!string.IsNullOrEmpty(id))
                kittyCardController.KittyCard(id);
        }
    }
}