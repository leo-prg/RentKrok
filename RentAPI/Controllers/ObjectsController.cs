using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RentDB;
using RentLibrary;
using System.Web.Http.Cors;

namespace RentAPI.Controllers
{

    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ObjectsController : ApiController
    {
        Lazy<DBObject> dbo = new Lazy<DBObject>();

        // GET: api/Objects
        public IEnumerable<ObjectRect> Get()
        {
            //return new string[] { "value1", "value2" };
            return dbo.Value.GetAllObjects();
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
