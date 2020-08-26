using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class ProjectStatuses
    {
        public ProjectStatuses()
        {
            Projects = new HashSet<Projects>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public bool? IsUnsuccessful { get; set; }
        public int? Position { get; set; }

        public virtual ICollection<Projects> Projects { get; set; }
    }
}
