using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class FeedbackRequests
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
        public DateTime? DateRequest { get; set; }
        public bool? IsSent { get; set; }
        public string Company { get; set; }
        public string File { get; set; }
    }
}
