using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAppWithDapperOverWideWorldImporters.Models;

namespace WebAppWithDapperOverWideWorldImporters.Controllers
{
    public class StateProvinceController : ApiController
    {
        // GET: api/StateProvince
        public IEnumerable<StateProvince> Get()
        {
            return new StateProvinceDao().GetAll();
        }

        // GET: api/StateProvince/5
        public IEnumerable<StateProvince> Get(int id)
        {
            return new StateProvinceDao().GetById(id);
        }

        // POST: api/StateProvince
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/StateProvince/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/StateProvince/5
        public void Delete(int id)
        {
        }
    }
}
