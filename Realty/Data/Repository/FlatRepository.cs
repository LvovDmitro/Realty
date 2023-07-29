using Microsoft.EntityFrameworkCore;
using Realty.Data.interfaces;
using Realty.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Realty.Data.Repository
{
    public class FlatRepository : IAllFlats
    {
        private readonly AppDBContent appDBContent;

        public FlatRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Flat> Flats => appDBContent.Flat.Include(c => c.Category);

        public IEnumerable<Flat> getFavFlats => appDBContent.Flat.Where(p => p.isFavourite).Include(c => c.Category);

        public Flat getObjectFlat(int flatId) => appDBContent.Flat.FirstOrDefault(p => p.id == flatId);
    }
}
