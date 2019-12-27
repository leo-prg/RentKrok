using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentKrok
{
    public class AreaRect
    {
        public int Id { get; set; }
        public string AreaName { get; set; }
        public int x1 { get; set; }
        public int y1 { get; set; }
        public int x2 { get; set; }
        public int y2 { get; set; }
        public float Square { get; set; }
        public float Price { get; set; }
        public float Cost { get; set; }
        public bool isRented { get;  set; }
    }

    public class ObjectRect
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string CNo { get; set; } // кадастровый номер здания
        // Географическое положение объекта для отображения на карте ?? на карте можно найти по адресу

        //public int Lat { get; set; } // широта
        //public int Lon { get; set; } // долгота
    }

    public class LayerRect
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FileName { get; set; }
        public byte[] LayerFile { get; set; }
    }

    public class RenterRect
    {
        public int Id { get; set; }
        public string RenterName { get; set; }
        public string Contract { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ContactPerson { get; set; }
        public string ContactPhone { get; set; }
        public string Annotation { get; set; }

    }
}
