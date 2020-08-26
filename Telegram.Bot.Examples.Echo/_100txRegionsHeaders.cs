using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class _100txRegionsHeaders
    {
        public _100txRegionsHeaders()
        {
            _100txRegions = new HashSet<_100txRegions>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string OktmoId { get; set; }
        public string OktmoCode { get; set; }

        public virtual ICollection<_100txRegions> _100txRegions { get; set; }
    }
}
