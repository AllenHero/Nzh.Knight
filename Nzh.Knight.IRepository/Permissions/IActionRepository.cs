﻿using Nzh.Knight.Common;
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
        /// <summary>
        /// 删除按钮时,同时删除t_menu_action和t_menu_role_action记录
        /// </summary>
        /// <param name="actionId"></param>
        /// <returns></returns>
        bool DeleteActionAllByActionId(int actionId);
    }
}
