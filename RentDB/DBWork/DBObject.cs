using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentLibrary;

namespace RentDB
{
    public class DBObject
    {
        Lazy<RentModel> context = new Lazy<RentModel>();
        public void AddObject(ObjectRect obj)
        {
            context.Value.RentObjects.Add(new RentObject() { Name = obj.Name, Address = obj.Address, CNo = obj.CNo, Lat = obj.Lat, Lon = obj.Lon }); ;
            context.Value.SaveChanges();
        }

        public void RemoveObject(ObjectRect obj)
        {
            var to_del = context.Value.RentObjects.Find(obj.Id);
            context.Value.RentObjects.Remove(to_del);
            context.Value.SaveChanges();
        }

        public void UpdateObject(ObjectRect oldO, ObjectRect newO)
        {
            // var ro = context.Value.RentObjects.Where(r=>r.Id == oldO.Id).Select(ro=>ro).FirstOrDefault();
            var ro = context.Value.RentObjects.Find(oldO.Id);
            ro.Name = newO.Name;
            ro.Address = newO.Address;
            ro.CNo = newO.CNo;
            ro.Lat = newO.Lat;
            ro.Lon = newO.Lon;
            context.Value.SaveChanges();
        }

        public List<ObjectRect> GetAllObjects()
        {
            return context.Value.RentObjects.Select(x => new ObjectRect()
            { Id = x.Id, Name = x.Name, Address = x.Address, 
              CNo = x.CNo, Lat = x.Lat, Lon = x.Lon }).ToList();
        }

    }
}
