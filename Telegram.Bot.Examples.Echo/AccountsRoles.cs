using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class AccountsRoles
    {
        public int Id { get; set; }
        public long Account { get; set; }
        public int Role { get; set; }

        public virtual Accounts AccountNavigation { get; set; }
        public virtual AccountsRolesHb RoleNavigation { get; set; }
    }
}
