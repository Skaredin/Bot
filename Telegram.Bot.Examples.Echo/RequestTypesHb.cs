using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class RequestTypesHb
    {
        public RequestTypesHb()
        {
            Request = new HashSet<Request>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Request> Request { get; set; }
    }
}
