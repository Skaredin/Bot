using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class ErrorC100txOrders
    {
        public int Id { get; set; }
        public long Account { get; set; }
        public long? Specification { get; set; }
        public DateTime? Dateadd { get; set; }
        public string PlanPurchase { get; set; }
        public string Name { get; set; }
        public int? Markup { get; set; }
        public long? CreatorAccount { get; set; }
        public string Comment { get; set; }
        public long? Sum { get; set; }
        public string Stage { get; set; }
        public DateTime? TermStage { get; set; }

        public virtual Accounts AccountNavigation { get; set; }
    }
}
