using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class EmailStatusLog
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string MessageId { get; set; }
        public string Event { get; set; }
        public byte[] Timestamp { get; set; }
    }
}
