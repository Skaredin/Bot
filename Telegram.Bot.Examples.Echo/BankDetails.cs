using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class BankDetails
    {
        public int Id { get; set; }
        public string CheckingAccount { get; set; }
        public string BenefeciaryBankName { get; set; }
        public string CorrespondingAccountOfBank { get; set; }
        public string Bic { get; set; }
        public string Kpp { get; set; }
        public string Kbk { get; set; }
    }
}
