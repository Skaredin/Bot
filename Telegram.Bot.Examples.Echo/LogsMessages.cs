using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class LogsMessages
    {
        public Guid Id { get; set; }
        public long LogId { get; set; }
        public string MessageId { get; set; }
        public int MessagesCount { get; set; }

        public virtual Logs Log { get; set; }
    }
}
