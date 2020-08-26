using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class AccountsUsers
    {
        public long Id { get; set; }
        public string UserId { get; set; }
        public long AccountId { get; set; }

        public virtual Accounts Account { get; set; }
        public virtual AspNetUsers User { get; set; }
    }
}
