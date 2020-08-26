using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class ServicesPreferencesHb
    {
        public ServicesPreferencesHb()
        {
            ServicesData = new HashSet<ServicesData>();
            ServicesPreferences = new HashSet<ServicesPreferences>();
            ServicesPrices = new HashSet<ServicesPrices>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int TypeId { get; set; }
        public bool? ReadOnly { get; set; }

        public virtual ServicesPreferencesTypes Type { get; set; }
        public virtual ICollection<ServicesData> ServicesData { get; set; }
        public virtual ICollection<ServicesPreferences> ServicesPreferences { get; set; }
        public virtual ICollection<ServicesPrices> ServicesPrices { get; set; }
    }
}
