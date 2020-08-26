using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class AleksProviderInfoOld
    {
        public int? Id { get; set; }
        public string Pagetitle { get; set; }
        public string Longtitle { get; set; }
        public string Description { get; set; }
        public string Inn { get; set; }
        public string Img { get; set; }
        public string Site { get; set; }
        public int Discount { get; set; }
        public string TaxSystem { get; set; }
        public int MinPurchase { get; set; }
        public string MinPurchaseCurrency { get; set; }
        public int DeliveryTimeFrom { get; set; }
        public int DeliveryTimeTo { get; set; }
        public int Prepay { get; set; }
        public int PayDefermentFrom { get; set; }
        public int PayDefermentTo { get; set; }
        public int PriceUpdate { get; set; }
        public int Rating { get; set; }
        public string AgreementType { get; set; }
        public int AgreementDeferment { get; set; }
        public byte OnModerate { get; set; }
    }
}
