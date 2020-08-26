using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class PrjPhoneNumbers
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public int? SettingsDataId { get; set; }
        public string PhoneType { get; set; }
        public string Name { get; set; }
        public int? TelecomOperatorId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string IpAddress { get; set; }
        public string DomainName { get; set; }
        public int? LineCount { get; set; }
        public int? InLineCount { get; set; }
        public int? OutLineCount { get; set; }
        public int? ProjectsId { get; set; }

        public virtual Projects Projects { get; set; }
        public virtual PrjSettingsData SettingsData { get; set; }
        public virtual PrjTelecomOperators TelecomOperator { get; set; }
    }
}
