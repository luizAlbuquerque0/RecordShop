using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordShop.Core.Entities
{
    public class Record : BaseEntity
    {
        public Record(int idStore, string name, decimal price, string band, string album, int amount)
        {
            IdStore = idStore;
            Name = name;
            Price = price;
            Band = band;
            Album = album;
            Amount = amount;
        }

        public int IdStore { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public string Band { get; private set; }
        public string Album { get; private set; }
        public int Amount { get; private set; }


    }
}
