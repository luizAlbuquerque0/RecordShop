using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordShop.Application.ViewModels
{
    public class RecordViewModel
    {
        public RecordViewModel(string name, decimal price, int amount, string band, string album, string storeName)
        {
            Name = name;
            Price = price;
            Amount = amount;
            Band = band;
            Album = album;
            StoreName = storeName;
        }

        public string Name { get; private set; }
        public decimal Price { get; set; }
        public int Amount { get; private set; }
        public string Band { get; private set; }
        public string Album { get; private set; }
        public string StoreName { get; private set; }
    }
}
