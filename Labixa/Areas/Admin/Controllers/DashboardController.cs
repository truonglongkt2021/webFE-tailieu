using System.Web.Mvc;

namespace Labixa.Areas.Admin.Controllers
{
    [Authorize(Roles ="Admin, Manager, Employee")]
    public class DashboardController : Controller
    {

       
        //
        // GET: /Admin/Dashboard/
        public ActionResult Index()
        {
            return View();
        }
	}
}