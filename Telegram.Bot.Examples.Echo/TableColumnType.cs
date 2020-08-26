using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class TableColumnType
    {
        public TableColumnType()
        {
            TableColumns = new HashSet<TableColumns>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string TypeId { get; set; }
        public int ColumnNumber { get; set; }

        public virtual TableType Type { get; set; }
        public virtual ICollection<TableColumns> TableColumns { get; set; }
    }
}
