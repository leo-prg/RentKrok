﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentKrok.DataModel;
using RentKrok.Common;

namespace RentKrok.DBWork
{
    public class DBArea
    {
        Lazy<RentModel> context = new Lazy<RentModel>();

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

        public string FindAreaByPoint(LayerRect layer ,int x, int y)
        {
            return context.Value.RentAreas
                .Where(a => x >= a.X && x <= (a.X + a.Width) && y >= a.Y && y <= (a.Y + a.Height) && a.Layer.Id == layer.Id)
                .Select(a => a.Name).FirstOrDefault(); 
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
            var rent = context.Value.Renters.Where(r => r.Id == renter.Id).Select(c => c).FirstOrDefault();
            ar.Renter = rent;
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
                    StartDate = r.Renter.StartDate,
                    EndDate = r.Renter.EndDate,
                    ContactPerson = r.Renter.ContactPerson,
                    ContactPhone = r.Renter.ContactPhone,
                    Annotation = r.Renter.Annotation
                }).FirstOrDefault();
        }
    }
}
