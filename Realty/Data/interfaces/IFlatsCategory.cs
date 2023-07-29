using Realty.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Realty.Data.interfaces
{
   public interface IFlatsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
