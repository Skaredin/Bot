using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class AccountIndustryHb
    {
        public AccountIndustryHb()
        {
            Accounts = new HashSet<Accounts>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Accounts> Accounts { get; set; }
    }
}
