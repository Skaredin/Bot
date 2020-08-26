using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class AccountsCategories
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public int CategoryId { get; set; }

        public virtual Accounts Account { get; set; }
        public virtual CatalogCategories Category { get; set; }
    }
}
