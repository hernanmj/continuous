namespace ContinuousApp.Controllers
{
    using System.Web.Mvc;

    using ContinuousApp.Models;

    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var model = new HomeViewModel { Message = "Hola MeetUp!" };
            return this.View(model);
        }
    }
}