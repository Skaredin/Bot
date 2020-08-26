using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class TypeFileKp
    {
        public TypeFileKp()
        {
            TemplatesKp = new HashSet<TemplatesKp>();
        }

        public int Id { get; set; }
        public string Typefile { get; set; }

        public virtual ICollection<TemplatesKp> TemplatesKp { get; set; }
    }
}
