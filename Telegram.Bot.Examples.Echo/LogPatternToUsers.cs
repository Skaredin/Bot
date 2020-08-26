using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class LogPatternToUsers
    {
        public int Id { get; set; }
        public int? PaternId { get; set; }
        public string UserId { get; set; }
        public int? IdUserEntity { get; set; }

        public virtual LogPatternUserEntiity IdUserEntityNavigation { get; set; }
        public virtual LogPattern Patern { get; set; }
        public virtual AspNetUsers User { get; set; }
    }
}
