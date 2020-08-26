using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class AleksDaspecsGoodstbl
    {
        public long Id { get; set; }
        public long? SrcId { get; set; }
        public long Parent { get; set; }
        public long SpecId { get; set; }
        public long LineId { get; set; }
        public long GoodId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Provider { get; set; }
        public string Manufacturer { get; set; }
        public long Count { get; set; }
        public long Units { get; set; }
        public long Price { get; set; }
        public string Currency { get; set; }
        public string Params { get; set; }
        public string Comment { get; set; }
        public decimal? Markup { get; set; }
        public string MongoImageId { get; set; }
        public byte IsCheated { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Volume { get; set; }
        public long? ProviderId { get; set; }
        public int? ApprovedByProvider { get; set; }
        public int? GoodParentId { get; set; }
    }
}
