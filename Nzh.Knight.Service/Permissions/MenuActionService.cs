using Nzh.Knight.IRepository;
using Nzh.Knight.IService;
using Nzh.Knight.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nzh.Knight.Service
{
    public class MenuActionService : BaseService<MenuActionModel>, IMenuActionService
    {
        public IMenuActionRepository repository { get; set; }

        public int SavePermission(IEnumerable<MenuActionModel> entitys, int menuId)
        {
            return repository.SavePermission(entitys, menuId);
        }

        public dynamic GetListByFilter(MenuActionModel filter, PageInfo pageInfo)
        {
            return GetListByFilter(filter, pageInfo, "");
        }
    }
}
