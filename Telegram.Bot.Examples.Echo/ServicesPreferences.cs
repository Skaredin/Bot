using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class ServicesPreferences
    {
        public int Id { get; set; }
        public int Serviceid { get; set; }
        public int PreferenceId { get; set; }

        public virtual ServicesPreferencesHb Preference { get; set; }
        public virtual Services Service { get; set; }
    }
}
