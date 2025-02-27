using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONO.Core.Entities
{
    public class User : BaseEntity
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string? Phone { get; set; }
        public bool PhoneConfirmed { get; set; }
        public bool TwoFactor { get; set; }
        public bool Lockout { get; set; }
        public string SecurityStamp { get; set; }
        public bool NoEmail { get; set; }
        public bool LockoutEnabled { get; set; }
        public bool NormailzedUsername { get; set; }
        public string Access { get; set; } = null!;

        public ICollection<UserAddress> Addresses { get; set; } = new List<UserAddress>();
        public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
        public ICollection<Order> Orders { get; set; } = new List<Order>();
        public ICollection<InventoryTransaction> InventoryTransactions { get; set; } = new List<InventoryTransaction>();
    }
}
