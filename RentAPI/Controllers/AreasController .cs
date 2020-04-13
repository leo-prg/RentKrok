using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using RentDB;
using RentLibrary;

namespace RentAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class AreasController : ApiController
    {
        Lazy<DBArea> dba = new Lazy<DBArea>();
        // GET: api/Areas
        public AreaRect Get(int id, int x, int y)
        {
            //return new string[] { "value1", "value2" };
            return dba.Value.FindAreaInfoByPoint(id, x, y);
        }



        // GET: api/Areas/5
        public RenterRect Get(int id)
        {
            //return "value";
            return dba.Value.GetAreaRenter(id);

        }

        // POST: api/Renters
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Renters/5
        public void Put(AreaRect area, [FromBody]string value)
        {
        }

        // DELETE: api/Renters/5
        public void Delete(int id)
        {
        }
    }
}
