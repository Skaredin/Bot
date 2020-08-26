using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class Parse
    {
        public int Id { get; set; }
        public string PlanNumber { get; set; }
        public string PlanInfoId { get; set; }
        public string AgencyId { get; set; }
        public string Status { get; set; }
        public DateTime? Date { get; set; }
        public string Law { get; set; }
    }
}
