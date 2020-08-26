using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class MapRegion
    {
        public int Id { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public int? Company { get; set; }
    }
}
