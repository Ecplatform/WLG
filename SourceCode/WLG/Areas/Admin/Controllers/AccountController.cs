using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WLG.Model;

namespace WLG.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Admin/Account/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

    }
}
