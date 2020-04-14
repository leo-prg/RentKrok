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
        Lazy<DBRenter> dbr = new Lazy<DBRenter>();
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
            if (id > 0)
            { 
                return dba.Value.GetAreaRenter(id); 
            }
            else return null;

        }

        // POST: api/Renters
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Renters/5
        public void Put(AreaRect area)
        {
            dba.Value.UpdateAreaData(area, area);
        }

        // DELETE: api/Renters/5
        // удаляем не площадь а арендатора - высвобождаем
        public void Delete(int id)
        {
          
        }

        [HttpPut]
        public void NoRenter(string name)
        {
            AreaRect area = dba.Value.FindAreaByName(name);
            dba.Value.AddRenterToArea(area, null);
        }
      
        [HttpPut]
        
        public void AddRenter(string name, int id)
        {
            AreaRect area = dba.Value.FindAreaByName(name);
            RenterRect renter = dbr.Value.GetRenterById(id);
            dba.Value.AddRenterToArea(area, renter);
        }


    }
}
