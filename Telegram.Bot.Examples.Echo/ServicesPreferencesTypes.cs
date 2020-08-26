using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class ServicesPreferencesTypes
    {
        public ServicesPreferencesTypes()
        {
            ServicesPreferencesHb = new HashSet<ServicesPreferencesHb>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ServicesPreferencesHb> ServicesPreferencesHb { get; set; }
    }
}
