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
        public void AddObject(ObjectRect obj)
        {
            context.Value.RentObjects.Add(new RentObject(){ Name = obj.Name, Address = obj.Address });
            context.Value.SaveChanges();
        }

        public void UpdateObject(ObjectRect oldO, ObjectRect newO)
        {
            var ro = context.Value.RentObjects.Where(r=>r.Id == oldO.Id).Select(ro=>ro).FirstOrDefault();
            ro.Name = newO.Name;
            ro.Address = newO.Address;
            context.Value.SaveChanges();
        }

        public List<ObjectRect> GetAllObjects()
        {
            return context.Value.RentObjects.Select(x => new ObjectRect() { Id = x.Id, Name = x.Name, Address = x.Address }).ToList();
        }

    }
}
