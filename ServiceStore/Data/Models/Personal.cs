using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceStore.Data.Models
{
    public class Personal
    {
        public int Id { set; get; }  // айди клиента

        public string Login {get; set;} //имя акк

        public string Passwrord { get; set; } //пароль от акк

        public string Name { set; get; }  //имя клиента

        public string LastName { set; get; }  //фамилия клиента

        public string SurName { set; get; }  //отчество клиента

        public string Age { set; get; } //возраст клиента

        public string Email { set; get; }  //мыло клиента

        public bool Admin { set; get; } //указатель на особые возможности

        public bool Buy { set; get; } //осуществлена ли покупка

        public string CategoryId { set; get; }  //айди заказа клиента

        public string Phone { set; get; }   //номер телефона клиента
        
    }
}
