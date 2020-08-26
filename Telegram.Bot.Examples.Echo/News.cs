using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class News
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public string UserId { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public long? SpecId { get; set; }

        public virtual Accounts Account { get; set; }
        public virtual AspNetUsers User { get; set; }
    }
}
