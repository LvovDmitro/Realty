using Microsoft.AspNetCore.Mvc;
using Realty.Data.interfaces;
using Realty.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Realty.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllFlats _flatRep;

        public HomeController(IAllFlats flatRep)
        {
            _flatRep = flatRep;
        }

        public ViewResult Index()
        {
            var homeFlats = new HomeViewModel
            {
                favFlats = _flatRep.getFavFlats
            };

            return View(homeFlats);
        }
    }
}
