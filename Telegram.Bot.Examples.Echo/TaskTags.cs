using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class TaskTags
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? TasksId { get; set; }

        public virtual Tasks Tasks { get; set; }
    }
}
