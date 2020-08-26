using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class HelpComments
    {
        public int IdComments { get; set; }
        public string Text { get; set; }
        public int? IdContent { get; set; }
        public int? IdUser { get; set; }

        public virtual HelpContent IdContentNavigation { get; set; }
    }
}
