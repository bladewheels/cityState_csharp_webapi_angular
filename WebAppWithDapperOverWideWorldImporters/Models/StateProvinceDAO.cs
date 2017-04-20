using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;

namespace WebAppWithDapperOverWideWorldImporters.Models
{
    internal class StateProvinceDao
    {
        public IEnumerable<StateProvince> GetAll()
        {
            const string sql = "SELECT StateProvinceId, StateProvinceCode, StateProvinceName FROM Application.StateProvinces";
            using (var connection = SqlHelper.GetOpenConnection())
            {
                return connection.Query<StateProvince>(sql);
            }
        }

        public IEnumerable<StateProvince> GetById(int id)
        {
            const string sql = "SELECT StateProvinceId, StateProvinceCode, StateProvinceName FROM Application.StateProvinces WHERE StateProvinceId = @ID";
            using (var connection = SqlHelper.GetOpenConnection())
            {
                return connection.Query<StateProvince>(sql, new { ID = id });
            }
        }
    }
}