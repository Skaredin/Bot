using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class AccountsFiles
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public byte[] File { get; set; }
        public long AccountId { get; set; }

        public virtual Accounts Account { get; set; }
    }
}
