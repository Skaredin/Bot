using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class _100txPlans
    {
        public _100txPlans()
        {
            _100txPlanPositions = new HashSet<_100txPlanPositions>();
        }

        public int Id { get; set; }
        public string PlanPurchase { get; set; }
        public string PlanShedule { get; set; }
        public string YearShedule { get; set; }
        public string DateApproval { get; set; }
        public string DateSheduleChange { get; set; }
        public string DateApprovalRationale { get; set; }
        public string DatePublic { get; set; }
        public string Status { get; set; }
        public long? Account { get; set; }
        public DateTime? Dateadd { get; set; }
        public int? Region { get; set; }

        public virtual Accounts AccountNavigation { get; set; }
        public virtual ICollection<_100txPlanPositions> _100txPlanPositions { get; set; }
    }
}
