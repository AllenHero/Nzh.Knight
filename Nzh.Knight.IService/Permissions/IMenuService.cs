using Nzh.Knight.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nzh.Knight.IService
{
    public interface IMenuService : IBaseService<MenuModel>
    {
        dynamic GetMenusList(bool isIndex, int roleId);

        string GetParentMenuName(int Id);

        IEnumerable<MenuModel> GetAvailableMenuList(int roleId);

        bool DeleteMenuAllByMenuId(int menuId);
    }
}
