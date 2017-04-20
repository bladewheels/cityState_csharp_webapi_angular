using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;

namespace WebAppWithDapperOverWideWorldImporters.Models
{
    internal class CityDao
    {
        public IEnumerable<City> GetAll()
        {
            const string sql = "SELECT CityId, CityName, StateProvinceId FROM Application.Cities";
            using (var connection = SqlHelper.GetOpenConnection())
            {
                return connection.Query<City>(sql);
            }
        }

        public IEnumerable<City> GetByStateProvince(int id)
        {
            const string sql = "SELECT CityId, CityName, StateProvinceId FROM Application.Cities WHERE StateProvinceId = @ID";
            using (var connection = SqlHelper.GetOpenConnection())
            {
                return connection.Query<City>(sql, new { ID = id });
            }
        }
    }
}