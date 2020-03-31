using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentLibrary;

namespace RentDB
{
    public class DBLayer
    {
        readonly Lazy<RentModel> context = new Lazy<RentModel>();
        public void AddObjectLayer(ObjectRect oRect, LayerRect lRect)
        {
            // найдем объект в базе с таким адресом и названием и в него будем добавлять введенный пользователем слой;
            var dbo = context.Value.RentObjects.Where(x => x.Id == oRect.Id).FirstOrDefault();
            context.Value.RentLayers.Add(new RentLayer() { Name = lRect.Name, LayerFileName = lRect.FileName,  Object = dbo, LayerFile = lRect.LayerFile,
                Height = lRect.Height, Width = lRect.Width });
            context.Value.SaveChanges();

        }

        public void UpdateObjectLayer(LayerRect oldL, LayerRect newL)
        {
            // найдем объект в базе с таким ид и в него будем добавлять введенный пользователем слой;
            var old_layer = context.Value.RentLayers.Where(x => x.Id == oldL.Id).FirstOrDefault();
            old_layer.Name = newL.Name;
            old_layer.LayerFileName = newL.FileName;
            old_layer.LayerFile = newL.LayerFile;
            old_layer.Width = newL.Width;
            old_layer.Height = newL.Height;
            // нужно удалить все связанные площади при замене файла слоя ????
            context.Value.SaveChanges();
        }

        public List<LayerRect> GetLayersOfObject(ObjectRect oRect)
        {
            var dbo = context.Value.RentObjects.Where(x => x.Id == oRect.Id).FirstOrDefault();
            return context.Value.RentLayers
                .Where(x => x.Object.Id == dbo.Id)
                .Select(x => new LayerRect() { Id = x.Id, Name = x.Name, FileName = x.LayerFileName, LayerFile = x.LayerFile, Width = x.Width, Height = x.Height }).ToList(); ;
        }

        public List<LayerRect> GetLayersOfObject(int id)
        {
            var dbo = context.Value.RentObjects.Where(x => x.Id == id).FirstOrDefault();
            return context.Value.RentLayers
                .Where(x => x.Object.Id == dbo.Id)
                .Select(x => new LayerRect() { Id = x.Id, Name = x.Name, FileName = x.LayerFileName, LayerFile = x.LayerFile,
                    Width = x.Width, Height = x.Height }).ToList();         
        }

        public void DeleteLayer(LayerRect lRect)
        {
            // найдем объект в базе с таким ид 
            context.Value.RentLayers.Remove(context.Value.RentLayers.Find(lRect.Id));
            context.Value.SaveChanges();
        }

    }
}
