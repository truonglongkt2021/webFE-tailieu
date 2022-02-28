using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Labixa.Controllers
{
    public class AccountController : BaseHomeController
    {
        //
        // GET: /Admin/Account/
        public ActionResult Login()
        {
            return View();
        }
	}
}