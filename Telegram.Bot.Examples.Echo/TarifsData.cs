using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class TarifsData
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public int Count { get; set; }
        public int TarifId { get; set; }

        public virtual Tarifs Tarif { get; set; }
    }
}
