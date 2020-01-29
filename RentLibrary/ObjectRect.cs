using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentLibrary
{
    public class ObjectRect
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string CNo { get; set; } // кадастровый номер здания
        // Географическое положение объекта для отображения на карте ?? на карте можно найти по адресу

        public string Lat { get; set; } // широта
        public string Lon { get; set; } // долгота
    }
}
