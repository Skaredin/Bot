using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class _100txOrdersStatuses
    {
        public _100txOrdersStatuses()
        {
            _100txOrdersStatusHistory = new HashSet<_100txOrdersStatusHistory>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public virtual ICollection<_100txOrdersStatusHistory> _100txOrdersStatusHistory { get; set; }
    }
}
