using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class AccountsModeration
    {
        public int Id { get; set; }
        public long? AccountId { get; set; }
        public bool? IsActive { get; set; }
        public string GuId { get; set; }
        public int? ChatId { get; set; }

        public virtual Accounts Account { get; set; }
    }
}
