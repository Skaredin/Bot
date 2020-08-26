using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class _100txStages
    {
        public _100txStages()
        {
            _100txOrders = new HashSet<_100txOrders>();
        }

        public string Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<_100txOrders> _100txOrders { get; set; }
    }
}
