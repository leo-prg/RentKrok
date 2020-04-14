using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentCommon;
using RentLibrary;

namespace RentDB
{
    public class DBArea
    {
        readonly Lazy<RentModel> context = new Lazy<RentModel>();

        public void AddLayerArea(LayerRect layer, AreaRect area)
        {
            var dbl = context.Value.RentLayers.Where(x => x.Id == layer.Id).FirstOrDefault();
            Transform.PointsToDimensions(area.x1, area.y1, area.x2, area.y2, out int width, out int height);
            context.Value.RentAreas.Add(new RentArea() { Layer = dbl, Name = area.AreaName,
                                                         X = area.x1, Y = area.y1, Width = width, Height = height,
                                                         Square = area.Square, Price = area.Price, Cost = area.Cost });
            context.Value.SaveChanges();
        }

        public List<AreaRect> GetLayerAreas(LayerRect layer)
        {
            var dbl = context.Value.RentLayers.Where(x => x.Id == layer.Id).FirstOrDefault();
            return context.Value.RentAreas
                .Where(x => x.Layer.Id == dbl.Id)
                .Select(x => new AreaRect()
                {
                    Id = x.Id,
                    AreaName = x.Name,
                    x1 = x.X,
                    y1 = x.Y,
                    x2 = Math.Abs(x.Width + x.X),
                    y2 = Math.Abs(x.Height + x.Y),
                    Square = x.Square,
                    Price = x.Price,
                    Cost = x.Cost,
                    isRented = x.Renter != null
                }).ToList();
        }

        public List<AreaRect> GetObjectAreas(int id)
        {
            
            return context.Value.RentAreas
                .Where(x => x.Layer.Object.Id == id)
                .Select(x => new AreaRect()
                {
                    Id = x.Id,
                    AreaName = x.Name,
                    x1 = x.X,
                    y1 = x.Y,
                    x2 = Math.Abs(x.Width + x.X),
                    y2 = Math.Abs(x.Height + x.Y),
                    Square = x.Square,
                    Price = x.Price,
                    Cost = x.Cost,
                    isRented = x.Renter != null
                }).ToList();
        }


        public string FindAreaByPoint(LayerRect layer ,int x, int y)
        {
            return context.Value.RentAreas
                .Where(a => x >= a.X && x <= (a.X + a.Width) && y >= a.Y && y <= (a.Y + a.Height) && a.Layer.Id == layer.Id)
                .Select(a => a.Name).FirstOrDefault(); 
        }

        public AreaRect FindAreaInfoByPoint(int id, int x, int y)
        {
            return context.Value.RentAreas
                .Where(a => x >= a.X && x <= (a.X + a.Width) && y >= a.Y && y <= (a.Y + a.Height) && a.Layer.Id == id)
                .Select(a => new AreaRect()
                {
                    Id = a.Id,
                    AreaName = a.Name,
                    x1 = a.X,
                    y1 = a.Y,
                    x2 = (a.X + a.Width),
                    y2 = (a.Y + a.Height),
                    Square = a.Square,
                    Price = a.Price,
                    Cost = a.Cost, 
                    isRented = (a.Renter!=null)

                }).FirstOrDefault();
        }


        public AreaRect FindAreaByName(string name)
        {
            return context.Value.RentAreas
                .Where(a => a.Name == name)
                .Select(a => new AreaRect() { Id = a.Id, AreaName = name, x1 = a.X, y1 = a.Y, x2 = (a.X + a.Width), y2 = (a.Y + a.Height),
                   Square = a.Square,
                    Price = a.Price,
                    Cost = a.Cost
                }).FirstOrDefault();
        }

        public void AddRenterToArea(AreaRect area, RenterRect renter)
        {
            var ar = context.Value.RentAreas.Where(a => a.Id == area.Id).Select(c => c).FirstOrDefault();
            if (renter != null)
            {
                var rent = context.Value.Renters.Where(r => r.Id == renter.Id).Select(c => c).FirstOrDefault();
                ar.Renter = rent;
            }
            else 
            {
                context.Value.Entry(ar).Reference(r => r.Renter).CurrentValue = null;
            }
            context.Value.SaveChanges();
        }

        public RenterRect GetAreaRenter(AreaRect area)
        {
            return context.Value.RentAreas
                .Where(a => a.Id == area.Id)
                .Select(r => new RenterRect()
                {
                    RenterName = r.Renter.RenterName,
                    Contract = r.Renter.Contract,
                    StartDate = (DateTime?)r.Renter.StartDate ?? DateTime.Now,
                    EndDate = (DateTime?)r.Renter.EndDate ?? DateTime.Now,
                    ContactPerson = r.Renter.ContactPerson,
                    ContactPhone = r.Renter.ContactPhone,
                    Annotation = r.Renter.Annotation
                }).FirstOrDefault();
        }


        public RenterRect GetAreaRenter(int id)
        {
                RenterRect rr = context.Value.RentAreas
                      .Where(a => a.Id == id)
                      .Select(r => new RenterRect()
                      {
                          Id = r.Renter.Id,
                          RenterName = r.Renter.RenterName,
                          Contract = r.Renter.Contract,
                          StartDate = (DateTime?)r.Renter.StartDate ?? DateTime.Now,
                          EndDate = (DateTime?)r.Renter.EndDate ?? DateTime.Now,
                          ContactPerson = r.Renter.ContactPerson,
                          ContactPhone = r.Renter.ContactPhone,
                          Annotation = r.Renter.Annotation
                      }).FirstOrDefault();

                if (rr != null) { return rr; }
                else { return null; }
           
        } 

    
        public void UpdateAreaData(AreaRect old, AreaRect _new)
        {
            // найдем объект в базе с таким ид 
            var _old = context.Value.RentAreas.Where(x => x.Id == old.Id).FirstOrDefault();
            _old.Name = _new.AreaName;
            _old.Price = _new.Price;
            _old.Square = _new.Square;
            _old.Cost = _new.Cost;
            context.Value.SaveChanges();
        }

        public void DeleteArea(AreaRect old)
        {
            // найдем объект в базе с таким ид 
            context.Value.RentAreas.Remove(context.Value.RentAreas.Find(old.Id));
            context.Value.SaveChanges();
        }


    }
}
