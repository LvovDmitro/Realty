using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Realty.Data.interfaces;
using Realty.Data.Models;
using Realty.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Realty.Controllers
{
    [Authorize]
    public class RealtyFlatController : Controller
    {
        private readonly IAllFlats _flatRep;
        private readonly RealtyFlat _realtyFlat;

        public RealtyFlatController(IAllFlats flatRep, RealtyFlat realtyFlat)
        {
            _flatRep = flatRep;
            _realtyFlat = realtyFlat;
        }

        public ViewResult Index()
        {
            var items = _realtyFlat.getRealtyItems();
            _realtyFlat.listRealtyItems = items;

            var obj = new RealtyFlatViewModel
            {
                realtyFlat = _realtyFlat
            };

            return View(obj);
        }

        public RedirectToActionResult addToFlat(int id)
        {
            var item = _flatRep.Flats.FirstOrDefault(i => i.id == id);
            if(item != null)
            {
                _realtyFlat.AddToFlat(item);
            }
            return RedirectToAction("Index");
        }

    }
}
