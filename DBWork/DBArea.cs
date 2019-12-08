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
            context.Value.RentAreas.Add(new RentArea() { Layer = dbl, Name = area.AreaName, X = area.x1, Y=area.y1, Width = width , Height  = height });
            context.Value.SaveChanges();
        }

        public List<AreaRect> GetLayerAreas(LayerRect layer)
        {
            var dbl = context.Value.RentLayers.Where(x => x.Name == layer.Name && x.LayerFileName == layer.FileName).FirstOrDefault();

            List<AreaRect> ar = new List<AreaRect>();

            ar = context.Value.RentAreas
                .Where(x => x.Layer.Name.Contains(dbl.Name)&&x.Layer.LayerFileName.Contains(dbl.LayerFileName))
                .Select(x => new AreaRect() { AreaName = x.Name, x1 = x.X, y1 = x.Y, x2 = Math.Abs(x.Width-x.X), y2 = Math.Abs(x.Height - x.Y)}).ToList();

            return ar;
        }


    }
}
