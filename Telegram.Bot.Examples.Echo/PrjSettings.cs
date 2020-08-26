using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class PrjSettings
    {
        public PrjSettings()
        {
            PrjPreferences = new HashSet<PrjPreferences>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? DisplayOrder { get; set; }

        public virtual ICollection<PrjPreferences> PrjPreferences { get; set; }
    }
}
