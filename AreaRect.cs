using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentKrok
{
    public class AreaRect
    {
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
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public class LayerRect
    {
        public string Name { get; set; }
        public string FileName { get; set; }
        public byte[] LayerFile { get; set; }
    }

    public class RenterRect
    {
        public string RenterName { get; set; }
        public string Contract { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ContactPerson { get; set; }
        public string ContactPhone { get; set; }
        public string Annotation { get; set; }

    }
}
