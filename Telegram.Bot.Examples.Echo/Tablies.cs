using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class Tablies
    {
        public Tablies()
        {
            TableColumns = new HashSet<TableColumns>();
            TableRows = new HashSet<TableRows>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string TypeId { get; set; }

        public virtual TableType Type { get; set; }
        public virtual ICollection<TableColumns> TableColumns { get; set; }
        public virtual ICollection<TableRows> TableRows { get; set; }
    }
}
