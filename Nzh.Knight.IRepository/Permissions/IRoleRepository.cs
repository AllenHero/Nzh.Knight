using Nzh.Knight.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nzh.Knight.IRepository
{
    public interface IRoleRepository : IBaseRepository<RoleModel>
    {
        IEnumerable<RoleModel> GetRoleList();
        /// <summary>
        /// 删除角色时,同时删除t_menu_role_action记录
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        bool DeleteRoleAllByRoleId(int roleId);
    }
}
