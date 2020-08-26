using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class AccountsRolesHb
    {
        public AccountsRolesHb()
        {
            AccountsRoles = new HashSet<AccountsRoles>();
            DocumentsTemplates = new HashSet<DocumentsTemplates>();
            HelpRoles = new HashSet<HelpRoles>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AccountsRoles> AccountsRoles { get; set; }
        public virtual ICollection<DocumentsTemplates> DocumentsTemplates { get; set; }
        public virtual ICollection<HelpRoles> HelpRoles { get; set; }
    }
}
