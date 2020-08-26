using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class Balance
    {
        public long Id { get; set; }
        public long? AccountId { get; set; }
        public decimal? Summ { get; set; }
        public int? TypeId { get; set; }
        public DateTime? Date { get; set; }
        public string UserId { get; set; }

        public virtual BalanceTypeHb Type { get; set; }
    }
}
