using Nzh.Knight.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nzh.Knight.IService
{
    public interface IUserService : IBaseService<UserModel>
    {
        UserModel GetDetail(int Id);

        UserModel CheckLogin(string username, string password);

        bool ModifyPwd(PassWordModel model);

        bool InitPwd(UserModel model);
    }
}
