using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class ProjectsUsers
    {
        public int Id { get; set; }
        public string IdUser { get; set; }
        public int IdProject { get; set; }

        public virtual Projects IdProjectNavigation { get; set; }
        public virtual AspNetUsers IdUserNavigation { get; set; }
    }
}
