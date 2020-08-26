using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class StatisticPbxOld
    {
        public int Id { get; set; }
        public string Uniqueid { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? Answer { get; set; }
        public DateTime? Endtime { get; set; }
        public string SrcChan { get; set; }
        public string SrcNum { get; set; }
        public string DstChan { get; set; }
        public string DstNum { get; set; }
        public string Linkedid { get; set; }
        public string Did { get; set; }
        public string Disposition { get; set; }
        public string Recordingfile { get; set; }
        public string FromAccount { get; set; }
        public string ToAccount { get; set; }
        public string Dialstatus { get; set; }
        public string Appname { get; set; }
        public string Transfer { get; set; }
        public string IsApp { get; set; }
        public int? Duration { get; set; }
        public int? Billsec { get; set; }
        public string WorkCompleted { get; set; }
    }
}
