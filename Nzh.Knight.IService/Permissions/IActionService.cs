using Nzh.Knight.Common;
using Nzh.Knight.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nzh.Knight.IService
{
    public interface IActionService : IBaseService<ActionModel>
    {
        string GetActionListHtmlByRoleId(int roleId, int menuId);

        IEnumerable<ActionModel> GetActionListByMenuId(int menuId);

        IEnumerable<ActionModel> GetActionListByMenuIdRoleId(int menuId, int roleId, PositionEnum position);

        bool DeleteActionAllByActionId(int actionId);
    }
}
