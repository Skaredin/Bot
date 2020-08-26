using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class AleksDaspecsLinestbl
    {
        public AleksDaspecsLinestbl()
        {
            AleksDaspecsAccounts = new HashSet<AleksDaspecsAccounts>();
        }

        public long SpecId { get; set; }
        public long LineId { get; set; }
        public string Mark { get; set; }
        public string Number { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public long Count { get; set; }
        public decimal CompareCost { get; set; }
        public string Units { get; set; }
        public string Comment { get; set; }
        public string EmptyLineComment { get; set; }
        public string AdditionalInfo { get; set; }
        public byte IsWrong { get; set; }
        public byte IsInfoblock { get; set; }
        public long? PositionId { get; set; }
        public long Id { get; set; }

        public virtual ICollection<AleksDaspecsAccounts> AleksDaspecsAccounts { get; set; }
    }
}
