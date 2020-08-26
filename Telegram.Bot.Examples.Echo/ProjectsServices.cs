using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class ProjectsServices
    {
        public ProjectsServices()
        {
            ServicesData = new HashSet<ServicesData>();
        }

        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int ServiceId { get; set; }
        public int? Value { get; set; }

        public virtual Projects Project { get; set; }
        public virtual Services Service { get; set; }
        public virtual ICollection<ServicesData> ServicesData { get; set; }
    }
}
