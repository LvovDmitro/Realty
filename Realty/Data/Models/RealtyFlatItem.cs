using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Realty.Data.Models
{
    public class RealtyFlatItem
    {
        public int id { get; set; }
        public Flat flat { get; set; }
        public uint price { get; set; }
        public string RealtyFlatId { get; set; }
    }
}
