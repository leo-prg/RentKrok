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
            var dbo = context.Value.RentObjects.Where(x => x.Id == oRect.Id).FirstOrDefault();
            context.Value.RentLayers.Add(new RentLayer() { Name = lRect.Name, LayerFileName = lRect.FileName,  Object = dbo, LayerFile = lRect.LayerFile });
            context.Value.SaveChanges();

        }

        public void UpdateObjectLayer(LayerRect oldL, LayerRect newL)
        {
            // найдем объект в базе с таким ид и в него будем добавлять введенный пользователем слой;
            var old_layer = context.Value.RentLayers.Where(x => x.Id == oldL.Id).FirstOrDefault();
            old_layer.Name = newL.Name;
            old_layer.LayerFileName = newL.FileName;
            // нужно удалить все связанные площади при замене файла слоя ????
            context.Value.SaveChanges();
        }

        public List<LayerRect> GetLayersOfObject(ObjectRect oRect)
        {
            var dbo = context.Value.RentObjects.Where(x => x.Id == oRect.Id).FirstOrDefault();
            return context.Value.RentLayers
                .Where(x => x.Object.Id == dbo.Id)
                .Select(x => new LayerRect() { Id = x.Id, Name = x.Name, FileName = x.LayerFileName, LayerFile = x.LayerFile }).ToList(); ;
        }


    }
}
