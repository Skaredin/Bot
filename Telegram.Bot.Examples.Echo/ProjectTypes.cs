using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class ProjectTypes
    {
        public ProjectTypes()
        {
            ProjectTypeSetting = new HashSet<ProjectTypeSetting>();
            ProjectTypesUser = new HashSet<ProjectTypesUser>();
            Projects = new HashSet<Projects>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Userid { get; set; }

        public virtual AspNetUsers User { get; set; }
        public virtual ICollection<ProjectTypeSetting> ProjectTypeSetting { get; set; }
        public virtual ICollection<ProjectTypesUser> ProjectTypesUser { get; set; }
        public virtual ICollection<Projects> Projects { get; set; }
    }
}
