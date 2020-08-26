using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class StatisticLeftMenu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? DisplayOrder { get; set; }
        public int? ProjectSettingId { get; set; }
        public string ActionName { get; set; }
        public string IconName { get; set; }

        public virtual PrjPreferences ProjectSetting { get; set; }
    }
}
