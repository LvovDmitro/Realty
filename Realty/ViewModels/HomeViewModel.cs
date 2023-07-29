using Realty.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Realty.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Flat> favFlats { get; set; }
    }
}
