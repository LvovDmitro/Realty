using Realty.Data.interfaces;
using Realty.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Realty.Data.mocks
{
    public class MockCategory : IFlatsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category {categoryName = "Коммунальная квартира", description="Одна комната на семью"},
                    new Category {categoryName = "Полугостинка", description="Минимальная плошадь квартиры"},
                    new Category {categoryName = "Гостинка", description="Малогабаритная однокомнатная квартира"},
                    new Category {categoryName = "Малосемейка", description="Промежуточный тип между комнатами общежития и отдельными квартирами"},
                    new Category {categoryName = "Однокомнатная квартира", description="Отдельная квартира, имеющая одну жилую комнату различной площади"},
                    new Category {categoryName = "Двухкомнатная квартира", description="Отдельная квартира, имеющая две жилые комнаты различной площади"},
                    new Category {categoryName = "Трехкомнатная квартира", description="Отдельная квартира, имеющая три жилые комнаты различной площади"},

                };
            }
        }
    }



}
