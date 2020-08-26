using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class CatalogGoods
    {
        public long Id { get; set; }
        public string Pagetitle { get; set; }
        public string Longtitle { get; set; }
        public string SourceLink { get; set; }
        public string Alias { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public int Parent { get; set; }
        public long Editedon { get; set; }
        public long Editedby { get; set; }
        public long Createdon { get; set; }
        public long Createdby { get; set; }
        public byte Deleted { get; set; }
        public string Sku { get; set; }
        public string SkuP { get; set; }
        public string SkuM { get; set; }
        public long Views { get; set; }
        public long Carts { get; set; }
        public long Units { get; set; }
        public byte IsNative { get; set; }
        public byte IsSuite { get; set; }
        public byte IsService { get; set; }
        public byte OnModerate { get; set; }
    }
}
