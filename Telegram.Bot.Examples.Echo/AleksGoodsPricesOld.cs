using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class AleksGoodsPricesOld
    {
        public int GoodId { get; set; }
        public long InPrice { get; set; }
        public string Currency { get; set; }
        public int Discount { get; set; }
        public int Markup { get; set; }
        public byte HasVat { get; set; }
        public int Vat { get; set; }
        public int CustomVatChanging { get; set; }
        public int DeploymentRate { get; set; }
        public int DeliveryWarehouseRate { get; set; }
        public int DeliveryClientRate { get; set; }
        public int Opdate { get; set; }
        public byte IsAutoRecount { get; set; }
    }
}
