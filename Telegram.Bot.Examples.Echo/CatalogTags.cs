using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class CatalogTags
    {
        public int ItemId { get; set; }
        public string ItemType { get; set; }
        public string TagWord { get; set; }
        public decimal Weight { get; set; }
        public string Source { get; set; }
    }
}
