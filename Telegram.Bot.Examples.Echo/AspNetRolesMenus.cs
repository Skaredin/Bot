using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class AspNetRolesMenus
    {
        public int Id { get; set; }
        public string RoleId { get; set; }
        public string MenuId { get; set; }

        public virtual MenuList Menu { get; set; }
        public virtual AspNetRoles Role { get; set; }
    }
}
