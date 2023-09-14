using Realty.Data.interfaces;
using Realty.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Realty.Data.mocks
{
    public class MockFlats : IAllFlats
    {
        private readonly IFlatsCategory _categoryFlats = new MockCategory();
        public IEnumerable<Flat> Flats
        {
            get
            {
                return new List<Flat>
                {
                    new Flat {name="ЖК Квартал Сюита",
                        shortDesc="3-комн. квартира, 52,32 м²",
                        longDesc="ЖК Квартал Сюита расположился в центральной части Казани, на пересечении улиц Павлюхина и Шаляпина, с видами на здание филармонии и знаменитый Серый дом.",
                        img="/img/3-flat1.jpg",
                        price=12349130,
                        isFavourite=true,
                        available=true,
                        Category=_categoryFlats.AllCategories.First(c => c.categoryName == "Трехкомнатная квартира")},
                    new Flat {name="ID 828310",
                        shortDesc="3-комн. квартира, 128,6 м²",
                        longDesc="Продаётся светлая, уютная трёхкомнатная квартира по ул. Патриса Лумумбы, 64. ",
                        img="/img/3-flat2.jpg",
                        price=12500000,
                        isFavourite=false,
                        available=true,
                        Category=_categoryFlats.AllCategories.First(c => c.categoryName == "Трехкомнатная квартира")},
                    new Flat {name="ЖК Сиберово",
                        shortDesc="3-комн. квартира, 65,7 м²",
                        longDesc="Продаётся 3-комн. квартира площадью 65,7 кв.м на 2 этаже 24 этажного дома (Корпус 1, Секция 1) проекта ПИК Сиберово",
                        img="/img/3-flat3.jpg",
                        price=8338118,
                        isFavourite=true,
                        available=true,
                        Category=_categoryFlats.AllCategories.First(c => c.categoryName == "Трехкомнатная квартира")},
                    new Flat {name="ЖК Квартал Сюита",
                        shortDesc="2-комн. квартира, 43,97 м²",
                        longDesc="Продается квартира 197, по адресу Татарстан, г. Казань, Приволжский район, ул. Павлюхина, корпус 1 очередь в ЖК Квартал Сюита на 8 этаже, с площадью 43.97 м2.",
                        img="/img/2-flat1.jpg",
                        price=11076845,
                        isFavourite=false,
                        available=true,
                        Category=_categoryFlats.AllCategories.First(c => c.categoryName == "Двухкомнатная квартира")},
                    new Flat {name="ЖК 21век",
                        shortDesc="2-комн. квартира, 72,7 м²",
                        longDesc="Продаю 2х комнатную (евро трешка) квартиру общей площадью 73/41/11 на 6/16 этажного кирпичного дома 2008 г постройки по адресу ЖК 21век ул. Габдуллы Кариева, 8 Советский район.",
                        img="/img/2-flat2.jpg",
                        price=9990000,
                        isFavourite=true,
                        available=true,
                        Category=_categoryFlats.AllCategories.First(c => c.categoryName == "Двухкомнатная квартира")},
                    new Flat {name="ЖК Квартал Сюита",
                        shortDesc="1-комн. квартира, 34,98 м²",
                        longDesc="Продается квартира 194, по адресу Татарстан, г. Казань, Приволжский район, ул. Павлюхина, корпус 1 очередь в ЖК Квартал Сюита на 8 этаже, с площадью 34.98 м2.",
                        img="/img/1-flat1.jpg",
                        price=9311784,
                        isFavourite=false,
                        available=true,
                        Category=_categoryFlats.AllCategories.First(c => c.categoryName == "Однокомнатная квартира")},
                    new Flat {name="Домино",
                        shortDesc="1-комн. квартира, 42,1 м²",
                        longDesc="Продаю 1-комнатную квартиру в Советском районе г. Казани по ул. Минская дом 50, расположенную на 4/16 этажного монолитного дома. ",
                        img="/img/1-flat2.jpg",
                        price=5300000,
                        isFavourite=true,
                        available=true,
                        Category=_categoryFlats.AllCategories.First(c => c.categoryName == "Однокомнатная квартира")},
                    new Flat {name=" ЖК Сиберово",
                        shortDesc="Студия, 21,4 м²",
                        longDesc="Продаётся квартира-студия площадью 21,4 кв.м на 2 этаже 16 этажного дома (Корпус 1, Секция 7) проекта ПИК Сиберово. ",
                        img="/img/studia-flat.jpg",
                        price=4540224,
                        isFavourite=true,
                        available=true,
                        Category=_categoryFlats.AllCategories.First(c => c.categoryName == "Студия")},
                    new Flat {name="ЖК Радужный-2",
                        shortDesc="1-комн. квартира, 19,15 м²",
                        longDesc="Продаётся студия в строящемся доме (Дом 6), срок сдачи: III-кв. 2024, общей площадью 19.15 кв.м., на 1 этаже.",
                        img="/img/gost-flat.jpg",
                        price=3260000,
                        isFavourite=false,
                        available=false,
                        Category=_categoryFlats.AllCategories.First(c => c.categoryName == "Гостинка")},
                    new Flat {name="ЖК Яналиф",
                        shortDesc="1-комн. квартира, 30 м²",
                        longDesc="Жилой комплекс Яналиф  это уникальный проект на берегу Волги, объединяющий искусство и технологичность в многофункциональное пространство. ",
                        img="/img/polgost-flat.jpg",
                        price=8712903,
                        isFavourite=false,
                        available=false,
                        Category=_categoryFlats.AllCategories.First(c => c.categoryName == "Полугостинка")},
                    new Flat {name="Домино",
                        shortDesc="Комната, 68/13,1 м²",
                        longDesc="Продаю комнату 13 кв.м. в 3-х комнатной квартире общей площадью 68/43/8кв.м. на 6/9 этажного панельного дома. ",
                        img="/img/komm-flat.jpg",
                        price=1699000,
                        isFavourite=false,
                        available=false,
                        Category=_categoryFlats.AllCategories.First(c => c.categoryName == "Коммунальная квартира")}

                };
            }
        }

        public IEnumerable<Flat> getFavFlats { get; set; }

        public Flat getObjectFlat(int flatId)
        {
            throw new NotImplementedException();
        }
    }

}
