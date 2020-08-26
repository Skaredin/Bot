using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class LogPatternUserEntiity
    {
        public LogPatternUserEntiity()
        {
            LogPatternToUsers = new HashSet<LogPatternToUsers>();
        }

        public int Id { get; set; }
        public int? Tupetable { get; set; }
        public string Name { get; set; }
        public string NameFild { get; set; }

        public virtual ICollection<LogPatternToUsers> LogPatternToUsers { get; set; }
    }
}
