using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class LogPattern
    {
        public LogPattern()
        {
            LogPatternToUsers = new HashSet<LogPatternToUsers>();
        }

        public int Id { get; set; }
        public int? Typetable { get; set; }
        public int? Idtable { get; set; }
        public int? Actionid { get; set; }
        public string Userid { get; set; }
        public string Text { get; set; }
        public string Verification { get; set; }
        public double? Notification { get; set; }

        public virtual LogAction Action { get; set; }
        public virtual AspNetUsers User { get; set; }
        public virtual ICollection<LogPatternToUsers> LogPatternToUsers { get; set; }
    }
}
