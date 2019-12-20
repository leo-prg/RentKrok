using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentKrok.DataModel
{
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
        public float Square { get; set; }
        public float Price { get; set; }
        public float Cost { get; set; }
        public virtual Renter? Renter { get; set; }
    }

}
