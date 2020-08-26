using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class AleksDaspecsBills
    {
        public long Id { get; set; }
        public long SpecId { get; set; }
        public long UserId { get; set; }
        public int Opdate { get; set; }
        public string BillCode { get; set; }
        public string LegalCode { get; set; }
        public string CustomerInn { get; set; }
        public long Vat { get; set; }
        public long Prepay { get; set; }
        public byte IsExport { get; set; }
        public string BillImage { get; set; }
        public string Status { get; set; }
        public string StatusDescription { get; set; }
        public byte Deleted { get; set; }
        public string TitleSource { get; set; }
    }
}
