using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONO.Core.Entities
{
    public class Order : BaseEntity
    {
        public string Status { get; set; }
        public DateTimeOffset OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public long AddressId { get; set; }
        public long UserId { get; set; }

        public UserAddress Address { get; set; }
        public User User { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; } = new List<OrderDetails>();
        public ICollection<InventoryTransaction> InventoryTransactions { get; set; } = new List<InventoryTransaction>();
    }
}
