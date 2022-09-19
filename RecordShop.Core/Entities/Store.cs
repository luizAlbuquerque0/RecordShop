using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordShop.Core.Entities
{
    public class Store : BaseEntity
    {
        public Store(string name, string email, string password, string phone, string adress)
        {
            Name = name;
            Email = email;
            Password = password;
            Phone = phone;
            Adress = adress;
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string Phone { get; private set; }
        public string Adress { get; private set; }
        public List<Record> Records { get; private set; }
        public List<Order> Sales { get; private set; }
    }
}
