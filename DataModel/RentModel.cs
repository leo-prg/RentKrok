namespace RentKrok.DataModel
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;

    public class RentModel : DbContext
    {
        // Контекст настроен для использования строки подключения "RentModel" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "RentKrok.DataModel.RentModel" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "RentModel" 
        // в файле конфигурации приложения.
        public RentModel()
            : base("name=RentModel")
        {
            
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<RentObject> RentObjects { get; set; }
        public virtual DbSet<RentLayer> RentLayers { get; set; }
        public virtual DbSet<RentArea> RentAreas { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RentObject>().HasMany(c => c.RentLayers).WithRequired(x => x.Object);
            modelBuilder.Entity<RentLayer>().HasMany(c => c.RentAreas).WithRequired(x => x.Layer);
        }

    }

    [Table("RentObjects")]
    public class RentObject
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(150)]
        public string Address { get; set; }

        public virtual List<RentLayer> RentLayers { get; set; }

        public RentObject()
        {
            RentLayers = new List<RentLayer>();
        }
}
    [Table("RentLayers")]
    public class RentLayer
    {
        [Key]
        public int Id { get; set; }
        public RentObject Object { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(255)]
        public string LayerFileName { get; set; }
        public byte[] LayerFile { get; set; }
        public virtual List<RentArea> RentAreas { get; set; }
        public RentLayer()
        {
            RentAreas = new List<RentArea>();
        }
    }

    [Table("RentAreas")]
    public class RentArea
    {
        public int Id { get; set; }
        public RentLayer Layer { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }


  



}