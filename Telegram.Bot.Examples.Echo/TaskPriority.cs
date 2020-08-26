using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class TaskPriority
    {
        public TaskPriority()
        {
            Tasks = new HashSet<Tasks>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Tasks> Tasks { get; set; }
    }
}
