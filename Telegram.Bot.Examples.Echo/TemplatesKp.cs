using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class TemplatesKp
    {
        public int Id { get; set; }
        public byte[] Bytestream { get; set; }
        public int? TypefileId { get; set; }
        public string NameTemplate { get; set; }
        public string Userid { get; set; }
        public bool? Standart { get; set; }

        public virtual TypeFileKp Typefile { get; set; }
    }
}
