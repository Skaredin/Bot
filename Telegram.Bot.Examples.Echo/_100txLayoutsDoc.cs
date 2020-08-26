using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class _100txLayoutsDoc
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public byte[] FileData { get; set; }
        public int LayoutType { get; set; }

        public virtual _100txLayoutsDocTypes LayoutTypeNavigation { get; set; }
    }
}
