using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class DocumentsTemplates
    {
        public DocumentsTemplates()
        {
            StatusSign = new HashSet<StatusSign>();
        }

        public int Id { get; set; }
        public string NameTemplate { get; set; }
        public byte[] Bytestream { get; set; }
        public int? TypeTemplateId { get; set; }
        public int? AccountRoleId { get; set; }
        public bool? CurrentVersion { get; set; }

        public virtual AccountsRolesHb AccountRole { get; set; }
        public virtual DocumentsTypesHb TypeTemplate { get; set; }
        public virtual ICollection<StatusSign> StatusSign { get; set; }
    }
}
