using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONO.Core.Entities
{
    public class User : IdentityUser<int>
    {
        public string Fname { get; set; }
        public string? Lname { get; set; }
        public bool NoEmail { get; set; }
        public bool NormailzedUsername { get; set; }
        public string Access { get; set; } = null!; 

        public ICollection<UserAddress> Addresses { get; set; } = new List<UserAddress>();
        public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
        public ICollection<Order> Orders { get; set; } = new List<Order>();
        public ICollection<InventoryTransaction> InventoryTransactions { get; set; } = new List<InventoryTransaction>();
    }
}
