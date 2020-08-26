using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class _100txZakupkiTasks
    {
        public long Id { get; set; }
        public string Region { get; set; }
        public string Url { get; set; }
        public string TaskId { get; set; }
        public int Status { get; set; }

        public virtual _100txTasksStatusesHb StatusNavigation { get; set; }
    }
}
