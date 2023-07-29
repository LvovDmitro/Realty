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
    public class FlatsController : Controller {
        private readonly IAllFlats _allFlats;
        private readonly IFlatsCategory _allCategories;

        public FlatsController(IAllFlats iAllFlats, IFlatsCategory iFlatsCar)
        {
            _allFlats = iAllFlats;
            _allCategories = iFlatsCar;
        }

        [Route("Flats/List")]
        [Route("Flats/List/{category}")]

        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Flat> flats = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                flats = _allFlats.Flats.OrderBy(i => i.id);
            } else
            {
                if(string.Equals("threeroom", category, StringComparison.OrdinalIgnoreCase))
                {
                    flats = _allFlats.Flats.Where(i => i.Category.categoryName.Equals("Трехкомнатная квартира")).OrderBy(i => i.id);
                    currCategory = "Трехкомнатные квартиры";
                } else if(string.Equals("tworoom", category, StringComparison.OrdinalIgnoreCase))
                {
                    flats = _allFlats.Flats.Where(i => i.Category.categoryName.Equals("Двухкомнатная квартира")).OrderBy(i => i.id);
                    currCategory = "Двухкомнатные квартиры";
                }
                else if (string.Equals("oneroom", category, StringComparison.OrdinalIgnoreCase))
                {
                    flats = _allFlats.Flats.Where(i => i.Category.categoryName.Equals("Однокомнатная квартира")).OrderBy(i => i.id);
                    currCategory = "Однокомнатные квартиры";
                }
                else if (string.Equals("smallfamilyroom", category, StringComparison.OrdinalIgnoreCase))
                {
                    flats = _allFlats.Flats.Where(i => i.Category.categoryName.Equals("Малосемейка")).OrderBy(i => i.id);
                    currCategory = "Малосемейки";
                }
                else if (string.Equals("guestroom", category, StringComparison.OrdinalIgnoreCase))
                {
                    flats = _allFlats.Flats.Where(i => i.Category.categoryName.Equals("Гостинка")).OrderBy(i => i.id);
                    currCategory = "Гостинки";
                }
                else if (string.Equals("halfguestroom", category, StringComparison.OrdinalIgnoreCase))
                {
                    flats = _allFlats.Flats.Where(i => i.Category.categoryName.Equals("Полугостинка")).OrderBy(i => i.id);
                    currCategory = "Полугостинки";
                }
                else if (string.Equals("communalroom", category, StringComparison.OrdinalIgnoreCase))
                {
                    flats = _allFlats.Flats.Where(i => i.Category.categoryName.Equals("Коммунальная квартира")).OrderBy(i => i.id);
                    currCategory = "Коммунальные квартиры";
                }
            }

            var flatobj = new FlatsListViewModel
            {
                allFlats = flats,
                currCategory = currCategory
            };
            ViewBag.Title = "Страница с недвижимостью";

            return View(flatobj);
        }

    }
}
