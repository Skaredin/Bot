using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class AleksGoodsPrices
    {
        public long GoodId { get; set; }
        public long InPrice { get; set; }
        public string Currency { get; set; }
        public long Discount { get; set; }
        public long Markup { get; set; }
        public byte HasVat { get; set; }
        public long Vat { get; set; }
        public long CustomVatChanging { get; set; }
        public int DeploymentRate { get; set; }
        public int DeliveryWarehouseRate { get; set; }
        public int DeliveryClientRate { get; set; }
        public long Opdate { get; set; }
        public byte IsAutoRecount { get; set; }
    }
}
