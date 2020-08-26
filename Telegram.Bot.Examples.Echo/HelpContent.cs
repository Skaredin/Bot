using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class HelpContent
    {
        public HelpContent()
        {
            HelpComments = new HashSet<HelpComments>();
            HelpRoles = new HashSet<HelpRoles>();
        }

        public int IdContent { get; set; }
        public string Header { get; set; }
        public string Information { get; set; }
        public int? IdCategories { get; set; }
        public string LinkToHelp { get; set; }

        public virtual HelpCategories IdCategoriesNavigation { get; set; }
        public virtual ICollection<HelpComments> HelpComments { get; set; }
        public virtual ICollection<HelpRoles> HelpRoles { get; set; }
    }
}
