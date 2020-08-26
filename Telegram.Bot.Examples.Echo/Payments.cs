using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class Payments
    {
        public Guid Id { get; set; }
        public long AccountId { get; set; }
        public int OperationType { get; set; }
        public decimal Sum { get; set; }
        public decimal Balance { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public virtual Accounts Account { get; set; }
    }
}
