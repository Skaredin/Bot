using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class HelpCategories
    {
        public HelpCategories()
        {
            HelpContent = new HashSet<HelpContent>();
            HelpRoles = new HashSet<HelpRoles>();
        }

        public int IdCategories { get; set; }
        public string Title { get; set; }
        public int? ParentCategory { get; set; }

        public virtual ICollection<HelpContent> HelpContent { get; set; }
        public virtual ICollection<HelpRoles> HelpRoles { get; set; }
    }
}
