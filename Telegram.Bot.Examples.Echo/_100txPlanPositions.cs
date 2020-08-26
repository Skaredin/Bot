using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class _100txPlanPositions
    {
        public long Id { get; set; }
        public string Uid { get; set; }
        public int? Number { get; set; }
        public string Type { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Characteristic { get; set; }
        public bool? VolumeIs { get; set; }
        public int? VolumeCurrent { get; set; }
        public int? Volume1 { get; set; }
        public int? Volume2 { get; set; }
        public int? VolumeLast { get; set; }
        public int? VolumeAll { get; set; }
        public int? CostAverage { get; set; }
        public int? SummCurrent { get; set; }
        public int? Summ1 { get; set; }
        public int? Summ2 { get; set; }
        public int? SummLast { get; set; }
        public int? SummAll { get; set; }
        public int? CostStart { get; set; }
        public int? Account { get; set; }
        public int? Plan { get; set; }
        public string Revision { get; set; }
        public string File { get; set; }

        public virtual _100txPlans PlanNavigation { get; set; }
    }
}
