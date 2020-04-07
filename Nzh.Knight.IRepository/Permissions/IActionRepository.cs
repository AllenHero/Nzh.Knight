using Nzh.Knight.Common;
using Nzh.Knight.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nzh.Knight.IRepository
{
    public interface IActionRepository : IBaseRepository<ActionModel>
    {
        IEnumerable<ActionModel> GetActionListByRoleId(int roleId, int menuId, out IEnumerable<ActionModel> selectList);

        IEnumerable<ActionModel> GetActionListByMenuId(int menuId);

        IEnumerable<ActionModel> GetActionListByMenuIdRoleId(int menuId, int roleId, PositionEnum position);

        bool DeleteActionAllByActionId(int actionId);
    }
}
