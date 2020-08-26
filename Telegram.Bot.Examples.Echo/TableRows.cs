using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class TableRows
    {
        public TableRows()
        {
            TableData = new HashSet<TableData>();
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int TableId { get; set; }
        public bool? Deleted { get; set; }

        public virtual Tablies Table { get; set; }
        public virtual ICollection<TableData> TableData { get; set; }
    }
}
