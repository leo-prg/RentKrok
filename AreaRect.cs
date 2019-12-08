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

}
