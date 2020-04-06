using Nzh.Knight.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nzh.Knight.IRepository
{
    public interface IMenuRoleActionRepository : IBaseRepository<MenuRoleActionModel>
    {
        /// <summary>
        /// 保存菜单角色权限配置
        /// </summary>
        /// <param name="entitys">菜单角色权限列表</param>
        /// <param name="roleId">角色Id</param>
        /// <returns></returns>
        int SavePermission(IEnumerable<MenuRoleActionModel> entitys, int roleId);
    }
}
