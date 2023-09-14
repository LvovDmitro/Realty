using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Realty.Data.interfaces;
using Realty.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Realty.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IAllOrders allOrders;
        private readonly RealtyFlat realtyFlat;

        public OrderController(IAllOrders allOrders, RealtyFlat realtyFlat)
        {
            this.allOrders = allOrders;
            this.realtyFlat = realtyFlat;
        }

        public IActionResult Checkout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            realtyFlat.listRealtyItems = realtyFlat.getRealtyItems();
            if (realtyFlat.listRealtyItems.Count == 0)
            {
                ModelState.AddModelError("","У вас пустой список");
            }

            if (ModelState.IsValid)
            {
                allOrders.createOrder(order);
                return RedirectToAction("Complete");
            }
            return View(order);
        }

        public IActionResult Complete()
        {
            ViewBag.Message = "Заказ обработан";
            return View();
        }
    }
}
