using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordShop.Core.Entities
{
    public class Order : BaseEntity
    {
        public Order(int idClient, int idStore, decimal totalCost, string paymentMethod, string observation)
        {
            IdClient = idClient;
            IdStore = idStore;
            TotalCost = totalCost;
            PaymentMethod = paymentMethod;
            Observation = observation;
            
        }

        public int IdClient { get; private set; }
        public int IdStore { get; private set; }
        public decimal TotalCost { get; private set; }
        public DateTime Date { get; private set; }
        public string PaymentMethod { get; private set; }
        public string PaymentStatus { get; private set; }
        public string Observation { get; private set; }
        public List<RecordSale> Records { get; private set; }
        public User User { get; private set; }
        public Store Store { get; private set; }
    }
}
