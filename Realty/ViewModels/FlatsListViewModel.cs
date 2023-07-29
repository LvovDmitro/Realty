using Realty.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Realty.ViewModels
{
    public class FlatsListViewModel
    {
        public IEnumerable<Flat> allFlats { get; set; }
        public string currCategory { get; set; }
    }
}
