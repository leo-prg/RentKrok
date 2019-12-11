using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentKrok
{
    public class Renter
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
