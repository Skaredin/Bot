using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class _100txLayoutsDocTypes
    {
        public _100txLayoutsDocTypes()
        {
            _100txLayoutsDoc = new HashSet<_100txLayoutsDoc>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<_100txLayoutsDoc> _100txLayoutsDoc { get; set; }
    }
}
