using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class Messages
    {
        public Messages()
        {
            MessageFile = new HashSet<MessageFile>();
            MessageToUsers = new HashSet<MessageToUsers>();
        }

        public long Id { get; set; }
        public string Text { get; set; }
        public long ChatId { get; set; }
        public string UserId { get; set; }
        public DateTime Date { get; set; }
        public int Idtable { get; set; }
        public int Typetable { get; set; }
        public bool? Parametr { get; set; }

        public virtual Chats Chat { get; set; }
        public virtual AspNetUsers User { get; set; }
        public virtual ICollection<MessageFile> MessageFile { get; set; }
        public virtual ICollection<MessageToUsers> MessageToUsers { get; set; }
    }
}
