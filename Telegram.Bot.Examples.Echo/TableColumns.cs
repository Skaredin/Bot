using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class TableColumns
    {
        public TableColumns()
        {
            TableData = new HashSet<TableData>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Type { get; set; }
        public int Tableid { get; set; }
        public int? Posx { get; set; }
        public int? Posy { get; set; }
        public int? Width { get; set; }
        public int? EnumId { get; set; }
        public string Description { get; set; }
        public int? ExcelId { get; set; }

        public virtual TableColumnType Enum { get; set; }
        public virtual Tablies Table { get; set; }
        public virtual ICollection<TableData> TableData { get; set; }
    }
}
