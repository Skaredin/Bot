using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class AspNetRoles
    {
        public AspNetRoles()
        {
            AspNetRolesMenus = new HashSet<AspNetRolesMenus>();
            AspNetUserRoles = new HashSet<AspNetUserRoles>();
            HelpRoles = new HashSet<HelpRoles>();
        }

        public string Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AspNetRolesMenus> AspNetRolesMenus { get; set; }
        public virtual ICollection<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual ICollection<HelpRoles> HelpRoles { get; set; }
    }
}
