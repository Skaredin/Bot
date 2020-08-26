using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class Request
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
        public long AccountId { get; set; }
        public string UserId { get; set; }
        public int TypeId { get; set; }

        public virtual RequestTypesHb Type { get; set; }
        public virtual AspNetUsers User { get; set; }
    }
}
