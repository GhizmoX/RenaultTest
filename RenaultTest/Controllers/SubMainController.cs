using System.Web.Mvc;

namespace RenaultTest.Controllers
{
    public class SubMainController : Controller
    {
        [HttpGet]
        public ActionResult Index() => View();

        [HttpGet]
        public ActionResult Delete() => View();

        [HttpGet]
        public ActionResult Edit() => View();
    }
}