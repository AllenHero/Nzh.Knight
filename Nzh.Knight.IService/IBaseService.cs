﻿using Nzh.Knight.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nzh.Knight.IService
{
    public interface IBaseService<T> where T : class, new()
    {
        bool CreateModel(T model);

        T ReadModel(int Id);

        bool UpdateModel(T model);

        bool UpdateModel(T model, string updateFields);

        bool DeleteModel(int Id);

        bool DeleteByWhere(string where);

        IEnumerable<T> GetAll(string returnFields = null, string orderby = null);

        dynamic GetListByFilter(T filter, PageInfo pageInfo);

        IEnumerable<T> GetByWhere(string where = null, object param = null, string returnFields = null, string orderby = null);
    }
}
