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

    public class RentersController : ApiController
    {
        Lazy<DBRenter> dbr = new Lazy<DBRenter>();
        // GET: api/Renters
        public IEnumerable<RenterRect> Get()
        {
            //return new string[] { "value1", "value2" };
            return dbr.Value.GetAllRenters();
        }

        // GET: api/Renters/5
        public RenterRect Get(int id)
        {
            //return "value";
            return dbr.Value.GetRenterById(id);

        }

        // POST: api/Renters
        public void Post(RenterRect newRenter)
        {
            dbr.Value.AddRenter(newRenter);
        }

        // PUT: api/Renters/5
        public void Put(RenterRect newRenter)
        {
           dbr.Value.UpdateRenter(newRenter, newRenter);
        }

        // DELETE: api/Renters/5
        public void Delete(int id)
        {
            RenterRect rr = dbr.Value.GetRenterById(id);
            dbr.Value.DropRenter(rr);
        }
    }
}
