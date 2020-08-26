using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class Services
    {
        public Services()
        {
            ProjectsServices = new HashSet<ProjectsServices>();
            ServicesPreferences = new HashSet<ServicesPreferences>();
            ServicesPrices = new HashSet<ServicesPrices>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ProjectsServices> ProjectsServices { get; set; }
        public virtual ICollection<ServicesPreferences> ServicesPreferences { get; set; }
        public virtual ICollection<ServicesPrices> ServicesPrices { get; set; }
    }
}
