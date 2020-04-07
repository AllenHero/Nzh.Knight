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
        int SavePermission(IEnumerable<MenuActionModel> entitys, int menuId);
    }
}
