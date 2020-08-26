using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class Projects
    {
        public Projects()
        {
            PrjPhoneNumbers = new HashSet<PrjPhoneNumbers>();
            PrjSettingsData = new HashSet<PrjSettingsData>();
            ProjectTypesUser = new HashSet<ProjectTypesUser>();
            ProjectsServices = new HashSet<ProjectsServices>();
            ProjectsUsers = new HashSet<ProjectsUsers>();
            TaskProjectsStatuses = new HashSet<TaskProjectsStatuses>();
            Tasks = new HashSet<Tasks>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public long AccountId { get; set; }
        public string OktellCode { get; set; }
        public string Guid { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateLastEdit { get; set; }
        public Guid? TypeId { get; set; }
        public string CreatorId { get; set; }
        public string OwnerId { get; set; }
        public string Description { get; set; }
        public int StatusesId { get; set; }
        public bool? IsExternal { get; set; }
        public bool Deleted { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime StartDate { get; set; }
        public int Type { get; set; }

        public virtual Accounts Account { get; set; }
        public virtual AspNetUsers Creator { get; set; }
        public virtual AspNetUsers Owner { get; set; }
        public virtual ProjectStatuses Statuses { get; set; }
        public virtual ProjectTypes1 Type1 { get; set; }
        public virtual ProjectTypes TypeNavigation { get; set; }
        public virtual ICollection<PrjPhoneNumbers> PrjPhoneNumbers { get; set; }
        public virtual ICollection<PrjSettingsData> PrjSettingsData { get; set; }
        public virtual ICollection<ProjectTypesUser> ProjectTypesUser { get; set; }
        public virtual ICollection<ProjectsServices> ProjectsServices { get; set; }
        public virtual ICollection<ProjectsUsers> ProjectsUsers { get; set; }
        public virtual ICollection<TaskProjectsStatuses> TaskProjectsStatuses { get; set; }
        public virtual ICollection<Tasks> Tasks { get; set; }
    }
}
