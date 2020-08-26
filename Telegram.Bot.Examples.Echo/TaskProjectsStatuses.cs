using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class TaskProjectsStatuses
    {
        public TaskProjectsStatuses()
        {
            TaskStatusHistory = new HashSet<TaskStatusHistory>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Ordering { get; set; }
        public int ProgectId { get; set; }
        public string Color { get; set; }
        public bool? Completed { get; set; }

        public virtual Projects Progect { get; set; }
        public virtual ICollection<TaskStatusHistory> TaskStatusHistory { get; set; }
    }
}
