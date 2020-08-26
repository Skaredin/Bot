using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class ChatsTypes
    {
        public ChatsTypes()
        {
            Chats = new HashSet<Chats>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Chats> Chats { get; set; }
    }
}
