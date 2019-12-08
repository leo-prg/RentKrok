using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentKrok.DataModel;

namespace RentKrok.DBWork
{
    public class DBLayer
    {
        Lazy<RentModel> context = new Lazy<RentModel>();

        public void AddObjectLayer(ObjectRect oRect, LayerRect lRect)
        {
            // найдем объект в базе с таким адресом и названием и в него будем добавлять введенный пользователем слой;

            var dbo = context.Value.RentObjects.Where(x => x.Name == oRect.Name && x.Address== oRect.Address).FirstOrDefault();
            context.Value.RentLayers.Add(new RentLayer() { Name = lRect.Name, LayerFileName = lRect.FileName,  Object = dbo, LayerFile = lRect.LayerFile });
            context.Value.SaveChanges();

        }

        public List<LayerRect> GetLayersOfObject(ObjectRect oRect)
        {
            var dbo = context.Value.RentObjects.Where(x => x.Name == oRect.Name && x.Address == oRect.Address).FirstOrDefault();

            List<LayerRect> lr = new List<LayerRect>();

            lr = context.Value.RentLayers
                .Where(x=> x.Object.Name.Contains(dbo.Name)&& x.Object.Address.Contains(dbo.Address))
                .Select(x => new LayerRect() { Name = x.Name, FileName = x.LayerFileName, LayerFile = x.LayerFile}).ToList();

            return lr;
        }


    }
}
