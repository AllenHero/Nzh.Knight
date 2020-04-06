using Nzh.Knight.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nzh.Knight.IRepository
{
    public interface IMenuActionRepository : IBaseRepository<MenuActionModel>
    {
        /// <summary>
        /// 保存菜单权限配置
        /// </summary>
        /// <param name="entitys">菜单权限列表</param>
        /// <param name="menuId"></param>
        /// <returns></returns>
        int SavePermission(IEnumerable<MenuActionModel> entitys, int menuId);
    }
}
