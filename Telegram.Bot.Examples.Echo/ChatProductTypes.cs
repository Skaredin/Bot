using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class ChatProductTypes
    {
        public ChatProductTypes()
        {
            Chats = new HashSet<Chats>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Chats> Chats { get; set; }
    }
}
