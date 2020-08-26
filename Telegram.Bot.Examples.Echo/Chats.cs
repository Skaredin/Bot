using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class Chats
    {
        public Chats()
        {
            Messages = new HashSet<Messages>();
        }

        public long Id { get; set; }
        public long ProductId { get; set; }
        public int Type { get; set; }
        public int ProductType { get; set; }

        public virtual ChatProductTypes ProductTypeNavigation { get; set; }
        public virtual ChatsTypes TypeNavigation { get; set; }
        public virtual ICollection<Messages> Messages { get; set; }
    }
}
