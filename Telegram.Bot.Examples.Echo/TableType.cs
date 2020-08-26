using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class TableType
    {
        public TableType()
        {
            TableColumnType = new HashSet<TableColumnType>();
            Tablies = new HashSet<Tablies>();
        }

        public string TypeId { get; set; }
        public string Name { get; set; }
        public string PatchMethod { get; set; }

        public virtual ICollection<TableColumnType> TableColumnType { get; set; }
        public virtual ICollection<Tablies> Tablies { get; set; }
    }
}
