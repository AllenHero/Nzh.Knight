using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nzh.Knight.Controllers
{
    public class HomeController : BaseController
    {
        public override ActionResult Index(int? id)
        {
            ViewBag.RealName = Operator == null ? "" : Operator.RealName;
            ViewBag.HeadShot = Operator == null ? "" : Operator.HeadShot;
            return View(GetWebSiteInfo());
        }

        public ActionResult Main()
        {
            return View();
        }
    }
}