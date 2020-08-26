using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class PrjPreferences
    {
        public PrjPreferences()
        {
            InverseParent = new HashSet<PrjPreferences>();
            PrjSettingsData = new HashSet<PrjSettingsData>();
            StatisticLeftMenu = new HashSet<StatisticLeftMenu>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? TypedataId { get; set; }
        public string Description { get; set; }
        public int? ParentId { get; set; }
        public int? PositionId { get; set; }
        public int? SettingId { get; set; }
        public int? DisplayOrder { get; set; }

        public virtual PrjPreferences Parent { get; set; }
        public virtual PrjSetPosition Position { get; set; }
        public virtual PrjSettings Setting { get; set; }
        public virtual PrjSetTypeData Typedata { get; set; }
        public virtual ICollection<PrjPreferences> InverseParent { get; set; }
        public virtual ICollection<PrjSettingsData> PrjSettingsData { get; set; }
        public virtual ICollection<StatisticLeftMenu> StatisticLeftMenu { get; set; }
    }
}
