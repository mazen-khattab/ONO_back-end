using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONO.Core.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string? Description { get; set; }

        public ICollection<ProductCategories> ProductCategories { get; set; } = new List<ProductCategories>();
    }
}
