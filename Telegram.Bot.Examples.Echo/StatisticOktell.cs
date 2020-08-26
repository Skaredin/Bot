using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class StatisticOktell
    {
        public int Id { get; set; }
        public DateTime? TimeStart { get; set; }
        public DateTime? TimeAnswer { get; set; }
        public DateTime? TimeStop { get; set; }
        public int? TimeWaiting { get; set; }
        public int? TimeTalking { get; set; }
        public string LineNumber { get; set; }
        public string Operator { get; set; }
        public string SubscriberNumber { get; set; }
        public string Direction { get; set; }
        public string Project { get; set; }
    }
}
