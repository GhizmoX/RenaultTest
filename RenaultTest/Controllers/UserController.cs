using System.Web.Mvc;

namespace RenaultTest.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Login() => View();
        public ActionResult Register() => View();
    }
}