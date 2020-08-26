using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class ServicesData
    {
        public int Id { get; set; }
        public int? ProjectServiceId { get; set; }
        public int? PreferenceId { get; set; }
        public string PreferenceValue { get; set; }

        public virtual ServicesPreferencesHb Preference { get; set; }
        public virtual ProjectsServices ProjectService { get; set; }
    }
}
