using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class BalanceTypeHb
    {
        public BalanceTypeHb()
        {
            Balance = new HashSet<Balance>();
        }

        public int Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Balance> Balance { get; set; }
    }
}
