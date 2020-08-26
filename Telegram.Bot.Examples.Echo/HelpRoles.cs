using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class HelpRoles
    {
        public string Id { get; set; }
        public int? IdCategories { get; set; }
        public int? IdContent { get; set; }
        public int? AccountsRoleId { get; set; }
        public string RoleId { get; set; }

        public virtual AccountsRolesHb AccountsRole { get; set; }
        public virtual HelpCategories IdCategoriesNavigation { get; set; }
        public virtual HelpContent IdContentNavigation { get; set; }
        public virtual AspNetRoles Role { get; set; }
    }
}
