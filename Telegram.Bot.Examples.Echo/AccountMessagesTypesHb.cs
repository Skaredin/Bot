using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class AccountMessagesTypesHb
    {
        public AccountMessagesTypesHb()
        {
            AccountMessages = new HashSet<AccountMessages>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AccountMessages> AccountMessages { get; set; }
    }
}
