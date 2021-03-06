﻿using Nzh.Knight.Extension;
using Nzh.Knight.Extension.SQLExts.MySQLExt;
using Nzh.Knight.IRepository;
using Nzh.Knight.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nzh.Knight.Repository
{
    public class MenuRoleActionRepository : BaseRepository<MenuRoleActionModel>, IMenuRoleActionRepository
    {
        public int SavePermission(IEnumerable<MenuRoleActionModel> entitys, int roleId)
        {
            var result = 0;
            using (var conn = MySqlHelper.GetConnection())
            {
                IDbTransaction transaction = conn.BeginTransaction();
                try
                {
                    conn.DeleteByWhere<MenuRoleActionModel>(" where RoleId=@RoleId", new { RoleId = roleId }, transaction);
                    if (entitys != null)
                    {
                        conn.InsertBatch<MenuRoleActionModel>(entitys, transaction);
                    }
                    transaction.Commit();
                    result = 1;
                }
                catch (Exception)
                {
                    result = -1;
                    transaction.Rollback();
                }
            }
            return result;
        }
    }
}
