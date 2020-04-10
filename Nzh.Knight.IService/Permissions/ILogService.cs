using Nzh.Knight.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nzh.Knight.IService
{
    public interface ILogService : IBaseService<LogModel>
    {
        bool WriteDbLog(LogModel model);
    }
}
