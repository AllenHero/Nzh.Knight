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
        int SavePermission(IEnumerable<MenuRoleActionModel> entitys, int roleId);
    }
}
