using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAppWithDapperOverWideWorldImporters.Models;

namespace WebAppWithDapperOverWideWorldImporters.Controllers
{
    public class CityController : ApiController
    {
        // GET: api/City
        public IEnumerable<City> Get()
        {
            return new CityDao().GetAll();
        }

        // GET: api/City/5
        public IEnumerable<City> Get(int id)
        {
            return new CityDao().GetByStateProvince(id);
        }

        // POST: api/City
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/City/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/City/5
        public void Delete(int id)
        {
        }
    }
}
