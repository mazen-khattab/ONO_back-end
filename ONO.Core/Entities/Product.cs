using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONO.Core.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; } 
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        public int StockUnit { get; set; }
        public bool IsActive { get; set; }
        public int CatId { get; set; }

        public Category Category { get; set; } = null!;
        public ICollection<ProductImage> ProductImages { get; set; } = null!;
        public ICollection<Review> Reviews { get; set; } = null!;
        public ICollection<OrderDetails> OrderDetails { get; set; } = null!;
        public ICollection<InventoryTransaction> InventoryTransactions { get; set; } = null!;
    }
}
