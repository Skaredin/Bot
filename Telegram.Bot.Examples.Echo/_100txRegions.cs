using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class _100txRegions
    {
        public int Id { get; set; }
        public string OktmoId { get; set; }
        public string OktmoCode { get; set; }
        public string Name { get; set; }
        public int? Priority { get; set; }
        public int? HeaderId { get; set; }

        public virtual _100txRegionsHeaders Header { get; set; }
    }
}
