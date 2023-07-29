using Realty.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Realty.Data.interfaces
{
    public interface IAllFlats
    {
        IEnumerable<Flat> Flats { get; }
        IEnumerable<Flat> getFavFlats { get;}
        Flat getObjectFlat(int flatId);
    }
}
