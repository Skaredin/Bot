using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class PriceTypesHb
    {
        public PriceTypesHb()
        {
            ServicesPrices = new HashSet<ServicesPrices>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ServicesPrices> ServicesPrices { get; set; }
    }
}
