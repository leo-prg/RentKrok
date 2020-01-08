using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentLibrary
{
    public class LayerRect
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FileName { get; set; }
        public byte[] LayerFile { get; set; }
    }

}
