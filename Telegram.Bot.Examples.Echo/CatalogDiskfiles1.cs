using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class CatalogDiskfiles1
    {
        public long Id { get; set; }
        public string Module { get; set; }
        public string Submodule { get; set; }
        public long ItemId { get; set; }
        public long Createdon { get; set; }
        public long Createdby { get; set; }
        public string Filename { get; set; }
        public string Type { get; set; }
        public string Caption { get; set; }
        public string Description { get; set; }
        public string FullPath { get; set; }
        public byte IsDefault { get; set; }
    }
}
