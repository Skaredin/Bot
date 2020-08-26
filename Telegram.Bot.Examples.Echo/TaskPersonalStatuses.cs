using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class TaskPersonalStatuses
    {
        public TaskPersonalStatuses()
        {
            TaskStatusHistory = new HashSet<TaskStatusHistory>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Ordering { get; set; }
        public string UserId { get; set; }
        public string Color { get; set; }
        public bool? Completed { get; set; }

        public virtual ICollection<TaskStatusHistory> TaskStatusHistory { get; set; }
    }
}
