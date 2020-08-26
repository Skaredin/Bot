using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class TableData
    {
        public int Id { get; set; }
        public int? RowId { get; set; }
        public string Value { get; set; }
        public int? ColumnId { get; set; }

        public virtual TableColumns Column { get; set; }
        public virtual TableRows Row { get; set; }
    }
}
