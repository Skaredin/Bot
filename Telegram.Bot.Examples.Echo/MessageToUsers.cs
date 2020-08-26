using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class MessageToUsers
    {
        public int Id { get; set; }
        public long? MessageId { get; set; }
        public string UserId { get; set; }
        public DateTime? See { get; set; }
        public DateTime? Verification { get; set; }

        public virtual Messages Message { get; set; }
        public virtual AspNetUsers User { get; set; }
    }
}
