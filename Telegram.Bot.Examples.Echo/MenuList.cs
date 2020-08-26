using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class MenuList
    {
        public MenuList()
        {
            AspNetRolesMenus = new HashSet<AspNetRolesMenus>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int? Type { get; set; }

        public virtual MenuType TypeNavigation { get; set; }
        public virtual ICollection<AspNetRolesMenus> AspNetRolesMenus { get; set; }
    }
}
