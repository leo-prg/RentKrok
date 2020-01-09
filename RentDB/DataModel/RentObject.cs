using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentDB
{
    [Table("RentObjects")]
    public class RentObject
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(150)]
        public string Address { get; set; }
        [StringLength(50)]
        public string CNo { get; set; }

        public virtual List<RentLayer> RentLayers { get; set; }

        public RentObject()
        {
            RentLayers = new List<RentLayer>();
        }
    }
}
