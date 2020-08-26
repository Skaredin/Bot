using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class PrjSettingsData
    {
        public PrjSettingsData()
        {
            PrjPhoneNumbers = new HashSet<PrjPhoneNumbers>();
        }

        public int Id { get; set; }
        public int? ProjectsId { get; set; }
        public int? PreferencesId { get; set; }
        public string Value { get; set; }

        public virtual PrjPreferences Preferences { get; set; }
        public virtual Projects Projects { get; set; }
        public virtual ICollection<PrjPhoneNumbers> PrjPhoneNumbers { get; set; }
    }
}
