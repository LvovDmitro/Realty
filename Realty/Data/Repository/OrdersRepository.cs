using Realty.Data.interfaces;
using Realty.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Realty.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDBContent appDBContent;
        private readonly RealtyFlat realtyFlat;

        public OrdersRepository(AppDBContent appDBContent, RealtyFlat realtyFlat)
        {
            this.appDBContent = appDBContent;
            this.realtyFlat = realtyFlat;
        }

        public void createOrder(Order order)
        {
            order.orderTime = DateTime.Now;
            appDBContent.Order.Add(order);
            appDBContent.SaveChanges();
            var items = realtyFlat.listRealtyItems;

            foreach(var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    flatID = el.flat.id,
                    orderID = order.id,
                    price = el.flat.price
                };
                appDBContent.OrderDetail.Add(orderDetail);
   
            }
            appDBContent.SaveChanges();

        }
    }
}
