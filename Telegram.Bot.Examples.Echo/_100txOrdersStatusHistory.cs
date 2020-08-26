using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class _100txOrdersStatusHistory
    {
        public long Id { get; set; }
        public long SpecId { get; set; }
        public long ProvId { get; set; }
        public int StatusId { get; set; }
        public DateTime Date { get; set; }

        public virtual _100txOrdersStatuses Status { get; set; }
    }
}
