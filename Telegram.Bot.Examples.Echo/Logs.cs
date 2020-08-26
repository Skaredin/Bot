using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class Logs
    {
        public Logs()
        {
            LogsMessages = new HashSet<LogsMessages>();
        }

        public long Id { get; set; }
        public int LogType { get; set; }
        public long AccountId { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public string UserId { get; set; }
        public string Json { get; set; }
        public int? ActionId { get; set; }
        public int? Typetable { get; set; }
        public int? Idtable { get; set; }
        public DateTime? Datetime { get; set; }

        public virtual Accounts Account { get; set; }
        public virtual LogAction Action { get; set; }
        public virtual LogsTypes LogTypeNavigation { get; set; }
        public virtual AspNetUsers User { get; set; }
        public virtual ICollection<LogsMessages> LogsMessages { get; set; }
    }
}
