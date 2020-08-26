using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class ServicesPrices
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public int PriceTypesId { get; set; }
        public int? TarifId { get; set; }
        public int? PreferenceId { get; set; }
        public int? Value { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateStop { get; set; }
        public bool? IsActive { get; set; }

        public virtual ServicesPreferencesHb Preference { get; set; }
        public virtual PriceTypesHb PriceTypes { get; set; }
        public virtual Services Service { get; set; }
        public virtual Tarifs Tarif { get; set; }
    }
}
