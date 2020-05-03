using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceStore.Data.Models
{
    public class Service
    {
        public int Id { set; get; }  // айди услуги

        public string Name { set; get; }  //имя услуги

        public string Desc { set; get; }  //описание услуги

        public string Img { set; get; }  //картинка услуги

        public string Price { set; get; }  //цена услуги

        public string CategoryId { set; get; }  //айди категории

        public string FullDesc1 { set; get; }   //подробное описание услуги
        public string FullDesc2 { set; get; }   //подробное описание услуги
        public string FullDesc3 { set; get; }   //подробное описание услуги
        public string FullDesc4 { set; get; }   //подробное описание услуги
        public string FullDesc5 { set; get; }   //подробное описание услуги
        public string FullDesc6 { set; get; }   //подробное описание услуги
        public string FullDesc7 { set; get; }   //подробное описание услуги
        public string FullDesc8 { set; get; }   //подробное описание услуги

    }
}
