using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class MenuType
    {
        public MenuType()
        {
            MenuList = new HashSet<MenuList>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<MenuList> MenuList { get; set; }
    }
}
