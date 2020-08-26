using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class StatusSign
    {
        public int Id { get; set; }
        public int? DocumentTemplatesId { get; set; }
        public DateTime? Date { get; set; }
        public long? AccountId { get; set; }
        public string UserId { get; set; }

        public virtual Accounts Account { get; set; }
        public virtual DocumentsTemplates DocumentTemplates { get; set; }
        public virtual AspNetUsers User { get; set; }
    }
}
