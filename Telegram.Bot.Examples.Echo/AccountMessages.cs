using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class AccountMessages
    {
        public long Id { get; set; }
        public string Message { get; set; }
        public int TypeId { get; set; }
        public string UserId { get; set; }
        public long AccountId { get; set; }
        public DateTime? Date { get; set; }
        public string Guid { get; set; }

        public virtual Accounts Account { get; set; }
        public virtual AccountMessagesTypesHb Type { get; set; }
        public virtual AspNetUsers User { get; set; }
    }
}
