using Nzh.Knight.Controllers;
using Nzh.Knight.IService;
using Nzh.Knight.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nzh.Knight.Areas.Permissions.Controllers
{
    public class MenuActionController : BaseController
    {
        private readonly IMenuActionService service;
        public MenuActionController(IMenuActionService _service)
        {
            service = _service;
        }
        [HttpPost]
        public ActionResult InsertBatch(IEnumerable<MenuActionModel> list, int menuId)
        {
            var result = service.SavePermission(list, menuId) > 0 ? SuccessTip() : ErrorTip();
            return Json(result);
        }
    }
}