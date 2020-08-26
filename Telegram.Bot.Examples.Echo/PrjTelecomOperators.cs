using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class PrjTelecomOperators
    {
        public PrjTelecomOperators()
        {
            PrjPhoneNumbers = new HashSet<PrjPhoneNumbers>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<PrjPhoneNumbers> PrjPhoneNumbers { get; set; }
    }
}
