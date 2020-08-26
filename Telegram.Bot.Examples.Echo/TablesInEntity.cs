using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class TablesInEntity
    {
        public int Id { get; set; }
        public int? TypeTable { get; set; }
        public int? EntityId { get; set; }
        public int? TableId { get; set; }
    }
}
