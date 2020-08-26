using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class ProjectTypes1
    {
        public ProjectTypes1()
        {
            Projects = new HashSet<Projects>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Disciption { get; set; }

        public virtual ICollection<Projects> Projects { get; set; }
    }
}
