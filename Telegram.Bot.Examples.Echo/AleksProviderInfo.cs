using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class AleksProviderInfo
    {
        public long Id { get; set; }
        public string Pagetitle { get; set; }
        public string Longtitle { get; set; }
        public string Description { get; set; }
        public string Inn { get; set; }
        public string Img { get; set; }
        public string Site { get; set; }
        public int? Discount { get; set; }
        public string TaxSystem { get; set; }
        public long? MinPurchase { get; set; }
        public string MinPurchaseCurrency { get; set; }
        public long? DeliveryTimeFrom { get; set; }
        public long? DeliveryTimeTo { get; set; }
        public int? Prepay { get; set; }
        public long? PayDefermentFrom { get; set; }
        public long? PayDefermentTo { get; set; }
        public long? PriceUpdate { get; set; }
        public long? Rating { get; set; }
        public string AgreementType { get; set; }
        public long? AgreementDeferment { get; set; }
        public byte? OnModerate { get; set; }
    }
}
