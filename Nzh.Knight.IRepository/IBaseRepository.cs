using Nzh.Knight.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nzh.Knight.IRepository
{
    public interface IBaseRepository<T> where T : class, new()
    {
        int Create(T model);

        T Read(int Id);

        int Update(T model);

        int Update(T model, string updateFields);

        int Delete(int Id);

        int DeleteByWhere(string where);

        IEnumerable<T> GetByPage(SearchFilter filter, out long total);

        IEnumerable<T> GetByPageUnite(SearchFilter filter, out long total);

        IEnumerable<T> GetAll(string returnFields = null, string orderby = null);

        IEnumerable<T> GetByWhere(string where = null, object param = null, string returnFields = null, string orderby = null);

        long GetTotal(SearchFilter filter);
    }
}
