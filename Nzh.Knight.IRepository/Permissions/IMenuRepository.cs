using Nzh.Knight.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nzh.Knight.IRepository
{
    public interface IMenuRepository : IBaseRepository<MenuModel>
    {
        MenuModel GetParentMenu(string sql, int Id);

        IEnumerable<MenuModel> GetAvailableMenuList(string sql);

        IEnumerable<MenuModel> GetMenuListByRoleId(string sql, int roleId);

        bool DeleteMenuAllByMenuId(int menuId);
    }
}
