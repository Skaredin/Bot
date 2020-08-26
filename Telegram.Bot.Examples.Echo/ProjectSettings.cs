using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class ProjectSettings
    {
        public ProjectSettings()
        {
            ProjectTypeSetting = new HashSet<ProjectTypeSetting>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Settings { get; set; }

        public virtual ICollection<ProjectTypeSetting> ProjectTypeSetting { get; set; }
    }
}
