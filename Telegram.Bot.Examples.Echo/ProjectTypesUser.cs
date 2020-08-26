using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class ProjectTypesUser
    {
        public int Id { get; set; }
        public int? Typeid { get; set; }
        public string Userid { get; set; }
        public int? Projectid { get; set; }

        public virtual Projects Project { get; set; }
        public virtual ProjectTypes Type { get; set; }
        public virtual AspNetUsers User { get; set; }
    }
}
