using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class _100txTasksStatusesHb
    {
        public _100txTasksStatusesHb()
        {
            _100txZakupkiTasks = new HashSet<_100txZakupkiTasks>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<_100txZakupkiTasks> _100txZakupkiTasks { get; set; }
    }
}
