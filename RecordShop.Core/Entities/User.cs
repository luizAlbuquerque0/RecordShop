using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordShop.Core.Entities
{
    public class User : BaseEntity
    {
        public User(string name, string cPF, string email, string password, string phone, string adress)
        {
            Name = name;
            CPF = cPF;
            Email = email;
            Password = password;
            BirthDate = DateTime.Now;
            Phone = phone;
            Adress = adress;
        }

        public string Name { get; private set; }
        public string CPF { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Phone { get; private set; }
        public string Adress { get; private set; }
        public Order Order { get; private set; }
        public List<Order> Orders { get; private set; }
    }
}
