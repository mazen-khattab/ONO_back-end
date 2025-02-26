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
        public string Pass { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string Phone { get; set; } = null!;
        public bool PhoneConfirmed { get; set; }
        public bool TwoFactor { get; set; }
        public bool Lockout { get; set; }
        public string SecurityStamp { get; set; }
        public bool NoEmail { get; set; }
        public bool LockoutEnabled { get; set; }
        public bool NormailzedUsername { get; set; }
        public string Access { get; set; } = null!;

        public ICollection<UserAddress> Addresses { get; set; } = null!;
        public ICollection<UserRole> UserRoles { get; set; } = null!;
        public ICollection<Review> Reviews { get; set; } = null!;
        public ICollection<Order> Orders { get; set; } = null!;
        public ICollection<InventoryTransaction> InventoryTransactions { get; set; } = null!;
    }
}
