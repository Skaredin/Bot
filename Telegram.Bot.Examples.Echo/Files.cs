using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class Files
    {
        public Files()
        {
            MessageFile = new HashSet<MessageFile>();
        }

        public string Id { get; set; }
        public int? Idtable { get; set; }
        public int? Typetable { get; set; }
        public string UserId { get; set; }
        public DateTime? Date { get; set; }
        public string Filename { get; set; }
        public byte[] Filedata { get; set; }

        public virtual AspNetUsers User { get; set; }
        public virtual ICollection<MessageFile> MessageFile { get; set; }
    }
}
