using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONO.Core.Entities
{
    public class ProductCategories : BaseEntity
    {
        public int? ProductId { get; set; }
        public int? CategoryId { get; set; }
        public Category Category { get; set; } = null!;
        public Product Product { get; set; } = null!;
    }
}
