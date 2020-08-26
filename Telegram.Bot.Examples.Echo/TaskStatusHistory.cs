using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class TaskStatusHistory
    {
        public int Id { get; set; }
        public int TasksId { get; set; }
        public int? StatusId { get; set; }
        public DateTime? ChanageDate { get; set; }
        public string UserId { get; set; }
        public int? PersonalStatusId { get; set; }

        public virtual TaskPersonalStatuses PersonalStatus { get; set; }
        public virtual TaskProjectsStatuses Status { get; set; }
        public virtual Tasks Tasks { get; set; }
        public virtual AspNetUsers User { get; set; }
    }
}
