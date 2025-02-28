using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONO.Core.Entities
{
    public class Role : IdentityRole<int>
    {

        public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
    }
}
