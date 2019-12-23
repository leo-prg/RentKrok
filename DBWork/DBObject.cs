using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentKrok.DataModel;

namespace RentKrok.DBWork
{
    public class DBObject
    {
        Lazy<RentModel> context = new Lazy<RentModel>();
        public bool AddObject(ObjectRect obj)
        {

            context.Value.RentObjects.Add(new RentObject(){ Name = obj.Name, Address = obj.Address });
            context.Value.SaveChanges();

            return true;
        }

        public bool UpdateObject(ObjectRect oldO, ObjectRect newO)
        {

            var ro = context.Value.RentObjects.Where(r=>r.Id == oldO.Id).Select(ro=>ro).FirstOrDefault();
            ro.Name = newO.Name;
            ro.Address = newO.Address;
            context.Value.SaveChanges();

            return true;
        }



        //public List<RentObject> GetAllObjects()
        public List<ObjectRect> GetAllObjects()
        {
            List<ObjectRect> or = new List<ObjectRect>();

            or = context.Value.RentObjects.Select(x => new ObjectRect() { Id = x.Id, Name = x.Name, Address = x.Address }).ToList();

            //foreach (var o in context.Value.RentObjects)
            //{
            //    or.Add(new ObjectRect() { Name = o.Name, Address = o.Address });
            //}

            return or;
        }

    }
}
