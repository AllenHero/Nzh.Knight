using Nzh.Knight.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nzh.Knight.IService
{
    public interface IRoleService : IBaseService<RoleModel>
    {
        IEnumerable<RoleModel> GetRoleList();

        bool DeleteRoleAllByRoleId(int roleId);
    }
}
