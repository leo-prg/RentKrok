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

    public class LayersController : ApiController
    {
        Lazy<DBLayer> dbl = new Lazy<DBLayer>();
        // GET: api/Layers
        public IEnumerable<LayerRect> Get(int id)
        {
            //return new string[] { "value1", "value2" };
            return dbl.Value.GetLayersOfObject(id);
        }

        // GET: api/Renters/5
        //public RenterRect Get(int id)
        //{
        //    //return "value";
        //    //return dbr.Value.GetRenterById(id);

        //}

        // POST: api/Renters
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Renters/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Renters/5
        public void Delete(int id)
        {
        }
    }
}
