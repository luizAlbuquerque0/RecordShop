using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordShop.Core.Entities
{
    public class RecordSale : BaseEntity
    {
        public RecordSale(int idOrder, int idDisc)
        {
            IdOrder = idOrder;
            IdDisc = idDisc;
        }

        public int IdOrder { get; private set; }
        public int IdDisc { get; private set; }
    }
}
