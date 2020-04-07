using Nzh.Knight;
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
    public class MenuRoleActionController : BaseController
    {
        private readonly IMenuRoleActionService service;

        public MenuRoleActionController(IMenuRoleActionService _service)
        {
            service = _service;
        }

        [HttpPost]
        public ActionResult InsertBatch(IEnumerable<MenuRoleActionModel> list, int roleId)
        {
            var result = service.SavePermission(list, roleId) > 0 ? SuccessTip() : ErrorTip();
            return Json(result);
        }
    }
}