using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class CatalogGoodsOld
    {
        public int Id { get; set; }
        public string Pagetitle { get; set; }
        public string Longtitle { get; set; }
        public string SourceLink { get; set; }
        public string Alias { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public int Parent { get; set; }
        public int Editedon { get; set; }
        public int Editedby { get; set; }
        public int Createdon { get; set; }
        public int Createdby { get; set; }
        public byte Deleted { get; set; }
        public string Sku { get; set; }
        public string SkuP { get; set; }
        public string SkuM { get; set; }
        public int Views { get; set; }
        public int Carts { get; set; }
        public int Units { get; set; }
        public byte IsNative { get; set; }
        public byte IsSuite { get; set; }
        public byte IsService { get; set; }
        public byte OnModerate { get; set; }
    }
}
