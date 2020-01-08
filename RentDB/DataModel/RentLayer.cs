using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentDB
{
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
}
