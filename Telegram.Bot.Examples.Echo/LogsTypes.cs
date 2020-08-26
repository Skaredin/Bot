using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class LogsTypes
    {
        public LogsTypes()
        {
            Logs = new HashSet<Logs>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string Action { get; set; }

        public virtual ICollection<Logs> Logs { get; set; }
    }
}
