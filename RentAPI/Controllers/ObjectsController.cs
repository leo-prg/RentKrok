using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RentDB;
using RentLibrary;

namespace RentAPI.Controllers
{
    public class ObjectsController : ApiController
    {
        DBObject dbo = new DBObject();

        // GET: api/Objects
        public IEnumerable<ObjectRect> Get()
        {
            //return new string[] { "value1", "value2" };
            return dbo.GetAllObjects();
        }

        // GET: api/Objects/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Objects
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Objects/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Objects/5
        public void Delete(int id)
        {
        }
    }
}
