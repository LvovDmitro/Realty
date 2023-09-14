using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Realty.Data.Models
{
    public class OrderDetail
    {
        public int ID { get; set; }
        public int orderID { get; set; }
        public int flatID { get; set; }
        public uint price { get; set; }
        public virtual Flat flat { get; set; }
        public virtual Order order { get; set; }

    }
}
