using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class Tasks
    {
        public Tasks()
        {
            InverseParentTaskNavigation = new HashSet<Tasks>();
            TaskCheckList = new HashSet<TaskCheckList>();
            TaskChecks = new HashSet<TaskChecks>();
            TaskDoers = new HashSet<TaskDoers>();
            TaskFollowers = new HashSet<TaskFollowers>();
            TaskStatusHistory = new HashSet<TaskStatusHistory>();
            TaskTags = new HashSet<TaskTags>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CreatorId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? StopDate { get; set; }
        public string DoerId { get; set; }
        public int? ProjectId { get; set; }
        public int? ParentTask { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsExternal { get; set; }
        public DateTime? CriticalDate { get; set; }
        public int PriorityId { get; set; }
        public double? IsImportant { get; set; }
        public bool Deleted { get; set; }
        public string OwnerId { get; set; }

        public virtual AspNetUsers Doer { get; set; }
        public virtual AspNetUsers Owner { get; set; }
        public virtual Tasks ParentTaskNavigation { get; set; }
        public virtual TaskPriority Priority { get; set; }
        public virtual Projects Project { get; set; }
        public virtual ICollection<Tasks> InverseParentTaskNavigation { get; set; }
        public virtual ICollection<TaskCheckList> TaskCheckList { get; set; }
        public virtual ICollection<TaskChecks> TaskChecks { get; set; }
        public virtual ICollection<TaskDoers> TaskDoers { get; set; }
        public virtual ICollection<TaskFollowers> TaskFollowers { get; set; }
        public virtual ICollection<TaskStatusHistory> TaskStatusHistory { get; set; }
        public virtual ICollection<TaskTags> TaskTags { get; set; }
    }
}
