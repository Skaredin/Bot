using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class MessageFile
    {
        public int Id { get; set; }
        public long? MessageId { get; set; }
        public string FileId { get; set; }

        public virtual Files File { get; set; }
        public virtual Messages Message { get; set; }
    }
}
