using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Realty.Data.Models
{
    public class RealtyFlat
    {
        private readonly AppDBContent appDBContent;

        public RealtyFlat(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public string RealtyFlatId { get; set; }
        public List<RealtyFlatItem> listRealtyItems { get; set; }

        public static RealtyFlat GetFlat(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;//создаем сессиию
            var context = services.GetService<AppDBContent>();
            string realtyFlatId = session.GetString("FlatId") ?? Guid.NewGuid().ToString(); //проверка на сущетсвование, создаем новый

            session.SetString("FlatId", realtyFlatId);

            return new RealtyFlat(context) { RealtyFlatId = realtyFlatId };
        }

        public void AddToFlat(Flat flat)
        {
            appDBContent.RealtyFlatItem.Add(new RealtyFlatItem
            {
                RealtyFlatId = RealtyFlatId,
                flat = flat,
                price = flat.price

            });
            appDBContent.SaveChanges();
        }

        public List<RealtyFlatItem> getRealtyItems()
        {
            return appDBContent.RealtyFlatItem.Where(c => c.RealtyFlatId == RealtyFlatId).Include(s => s.flat).ToList();
        }
    }
}
