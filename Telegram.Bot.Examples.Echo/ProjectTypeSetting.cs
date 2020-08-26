using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class ProjectTypeSetting
    {
        public int Id { get; set; }
        public int Typeid { get; set; }
        public int Settingid { get; set; }

        public virtual ProjectSettings Setting { get; set; }
        public virtual ProjectTypes Type { get; set; }
    }
}
