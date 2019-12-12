using System;
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
            var dbl = context.Value.RentLayers.Where(x => x.Name == layer.Name && x.LayerFile == layer.LayerFile).FirstOrDefault();
            Transform.PointsToDimensions(area.x1, area.y1, area.x2, area.y2, out int width, out int height);
            context.Value.RentAreas.Add(new RentArea() { Layer = dbl, Name = area.AreaName,
                                                         X = area.x1, Y = area.y1, Width = width, Height = height,
                                                         Square = area.Square, Price = area.Price, Cost = area.Cost });
            context.Value.SaveChanges();
        }

        public List<AreaRect> GetLayerAreas(LayerRect layer)
        {
            var dbl = context.Value.RentLayers.Where(x => x.Name == layer.Name && x.LayerFileName == layer.FileName).FirstOrDefault();

            List<AreaRect> ar = new List<AreaRect>();

            ar = context.Value.RentAreas
                .Where(x => x.Layer.Name.Contains(dbl.Name) && x.Layer.LayerFileName.Contains(dbl.LayerFileName))
                .Select(x => new AreaRect() { AreaName = x.Name, x1 = x.X, y1 = x.Y, x2 = Math.Abs(x.Width + x.X), 
                                             y2 = Math.Abs(x.Height + x.Y), Square = x.Square, Price = x.Price, Cost = x.Cost,
                                               isRented = x.Renter!=null })
                                            .ToList();

            return ar;
        }

        public string FindAreaByPoint(LayerRect layer ,int x, int y)
        {
            return context.Value.RentAreas
                .Where(a => x >= a.X && x <= (a.X + a.Width) && y >= a.Y && y <= (a.Y + a.Height) && a.Layer.Name.Contains(layer.Name))
                .Select(a => a.Name).FirstOrDefault(); 
        }

        public AreaRect FindAreaByName(string name)
        {
            return context.Value.RentAreas
                .Where(a => a.Name == name)
                .Select(a => new AreaRect() { AreaName = name, x1 = a.X, y1 = a.Y, x2 = (a.X + a.Width), y2 = (a.Y + a.Height),
                   Square = a.Square,
                    Price = a.Price,
                    Cost = a.Cost
                }).FirstOrDefault();
        }

    }
}
