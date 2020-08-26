using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class TaskCheckList
    {
        public int Id { get; set; }
        public int? TasksId { get; set; }
        public string Text { get; set; }
        public int Ordering { get; set; }
        public string Color { get; set; }
        public string UserId { get; set; }
        public DateTime? Date { get; set; }
        public bool Ischeck { get; set; }

        public virtual Tasks Tasks { get; set; }
        public virtual AspNetUsers User { get; set; }
    }
}
