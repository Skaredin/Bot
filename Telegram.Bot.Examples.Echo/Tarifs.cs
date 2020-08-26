using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class Tarifs
    {
        public Tarifs()
        {
            ServicesPrices = new HashSet<ServicesPrices>();
            TarifsData = new HashSet<TarifsData>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? DateCreate { get; set; }

        public virtual ICollection<ServicesPrices> ServicesPrices { get; set; }
        public virtual ICollection<TarifsData> TarifsData { get; set; }
    }
}
