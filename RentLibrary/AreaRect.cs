using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentLibrary
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

  

  
  
}
