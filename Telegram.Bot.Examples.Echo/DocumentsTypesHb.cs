using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class DocumentsTypesHb
    {
        public DocumentsTypesHb()
        {
            DocumentsTemplates = new HashSet<DocumentsTemplates>();
        }

        public int Id { get; set; }
        public string NameType { get; set; }

        public virtual ICollection<DocumentsTemplates> DocumentsTemplates { get; set; }
    }
}
