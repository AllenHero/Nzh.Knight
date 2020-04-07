using Nzh.Knight.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nzh.Knight.IService
{
    public interface IMenuRoleActionService : IBaseService<MenuRoleActionModel>
    {
        int SavePermission(IEnumerable<MenuRoleActionModel> entitys, int roleId);

        IEnumerable<MenuRoleActionModel> GetListByRoleIdMenuId(int roleId, int menuId);
    }
}
