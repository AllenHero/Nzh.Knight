using Nzh.Knight.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nzh.Knight.IRepository
{
    public interface IUserRepository : IBaseRepository<UserModel>
    {
        UserModel GetDetail(int Id);
        UserModel CheckLogin(string username, string password);
        int ModifyPwd(PassWordModel model);
    }
}
