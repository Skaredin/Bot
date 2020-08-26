using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class AleksDaspecsAccounts
    {
        public long Id { get; set; }
        public long LinestblId { get; set; }
        public long LineId { get; set; }
        public long SpecId { get; set; }
        public long AccountId { get; set; }
        public long CategoryId { get; set; }

        public virtual Accounts Account { get; set; }
        public virtual AleksDaspecsLinestbl Linestbl { get; set; }
    }
}
