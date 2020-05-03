using ServiceStore.Data.Interfaces;
using ServiceStore.Data.Models;
using System.Collections.Generic;


namespace ServiceStore.Data.Mocks
{
    public class mockService : IAllServices
    {
        public IEnumerable<Service> Services
        {
            get
            {
                return new List<Service>
                {
                    new Service
                    {
                        Name ="",
                        Desc="Формирование первичной учетной документации по выполненным строительно-монтажным работам",
                        Img="/img/services/smeta1.jpg",
                        Price= "от 500",
                       
                        Id=1 
                    },

                    new Service
                    {
                        Name = "",
                        Desc = "Определение стоимости материально-технических ресурсов, используемых при производстве строительно-монтажных работ",
                        Img ="/img/services/smeta2.png",
                        Price = "от 500",
                        Id=2
                    },

                    new Service
                    {
                        Name = "",
                        Desc = " Подготовка результатов выполненных строительных работ на объекте строительства к сдаче заказчику",
                        Img = "/img/services/smeta3.jpg",
                        Price = "от 500",
                        Id=3
                    },

                    new Service
                    {
                        Name = "",
                        Desc = "Контроль расходования сметных и плановых лимитов материально-технических и финансовых ресурсов при производстве работ на участке строительства",
                        Img = "/img/services/smeta4.jpg",
                        Price = "от 500",
                        Id=4
                    },

                    new Service
                    {
                        Name = "",
                        Desc = "Контроль расходования сметных и плановых лимитов материально-технических и финансовых ресурсов в процессе строительного производства",
                        Img = "/img/services/smeta5.jpg",
                        Price = "от 500",
                        Id=5
                    },

                    new Service
                    {
                        Name = "",
                        Desc = "Руководство работниками, осуществляющими планово-экономическое обеспечение строительного производства",
                        Img = "/img/services/smeta6.jpg",
                        Price = "от 500",
                        Id=6
                    },

                    new Service
                    {
                        Name = "",
                        Desc = "Проведение вспомогательных работ при определении стоимостей строительства",
                        Img = "/img/services/smeta7.jpg",
                        Price = "от 500",
                        Id=7
                    },

                    new Service
                    {
                        Name = "",
                        Desc = "Определение сметной стоимости строительства",
                        Img = "/img/services/smeta8.jpg",
                        Price = "от 500",
                        Id=8
                    },

                    new Service
                    {
                        Name = "",
                        Desc = "Расчет себестоимости строительно-монтажных работ",
                        Img = "/img/services/smeta9.jpg",
                        Price = "от 500",
                        Id=9
                    },

                    new Service
                    {
                        Name = "",
                        Desc = "Определение элементов сметной стоимости строительства",
                        Img = "/img/services/smeta10.jpg",
                        Price = "от 500",
                        Id=10
                    },

                    new Service
                    {
                        Name = "",
                        Desc = "Формирование фактической стоимости строительства",
                        Img = "/img/services/smeta11.jpg",
                        Price = "от 500",
                        Id=11
                    },

                    new Service
                    {
                        Name = "",
                        Desc = "Определение контрактной стоимости строительства",
                        Img = "/img/services/smeta12.jpg",
                        Price = "от 500",
                        Id=12
                    },

                    new Service
                    {
                        Name = "",
                        Desc = "Составление смет на дополнительные строительно-монтажные работы",
                        Img = "/img/services/smeta13.jpg",
                        Price = "от 500",
                        Id=13
                    },

                     new Service
                    {
                        Name = "",
                        Desc = "Сдача заказчику результатов строительных работ",
                        Img = "/img/services/smeta14.jpg",
                        Price = "от 500",
                        Id=14
                    },

                        new Service
                    {
                        Name = "",
                        Desc = "Формирование фактической стоимости строительства",
                        Img = "/img/services/smeta15.jpg",
                        Price = "от 500",
                        Id=15
                    },

                        new Service
                    {
                        Name = "",
                        Desc = "Определение инвестиционной стоимости строительства",
                        Img = "/img/services/smeta16.jpg",
                        Price = "от 500",
                        Id=16
                    },

                        new Service
                    {
                        Name = "",
                        Desc = "Подготовка участка для производства строительных работ",
                        Img = "/img/services/smeta17.jpg",
                        Price = "от 500",
                        Id=17
                    },

                         new Service
                    {
                        Name = "",
                        Desc = "Материально-техническое обеспечение производства  работ",
                        Img = "/img/services/smeta18.jpg",
                        Price = "от 500",
                        Id=18
                    },

                        new Service
                    {
                        Name = "",
                        Desc = "Определение контрактной стоимости строительства",
                        Img = "/img/services/smeta19.jpg",
                        Price = "от 500",
                        Id=19
                    },

                        new Service
                    {
                        Name = "",
                        Desc = "Руководство работниками участка производства работ",
                        Img = "/img/services/smeta20.jpg",
                        Price = "от 500",
                        Id=20
                    },

                        new Service
                    {
                        Name = "",
                        Desc = "Организация производства строительных работ на объекте  строительства",
                        Img = "/img/services/smeta21.jpg",
                        Price = "от 500",
                        Id=21
                    },

                        new Service
                    {
                        Name = "",
                        Desc = "Разработка сметной документации",
                        Img = "/img/services/smeta22.jpg",
                        Price = "от 500",
                        Id=22
                    },

                        new Service
                    {
                        Name = "",
                        Desc = "Управление производством работ",
                        Img = "/img/services/smeta23.jpg",
                        Price = "от 500",
                        Id=23
                    },

                        new Service
                    {
                        Name = "",
                        Desc = "Подготовка ведомости объемов работ",
                        Img = "/img/services/smeta24.jpg",
                        Price = "от 500",
                        Id=24
                    },
                };
            }

        }
    }
}
