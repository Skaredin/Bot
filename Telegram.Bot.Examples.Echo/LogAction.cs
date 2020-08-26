using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class LogAction
    {
        public LogAction()
        {
            LogPattern = new HashSet<LogPattern>();
            Logs = new HashSet<Logs>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string SqlName { get; set; }

        public virtual ICollection<LogPattern> LogPattern { get; set; }
        public virtual ICollection<Logs> Logs { get; set; }
    }
}
