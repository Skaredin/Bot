using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class AspNetUsers
    {
        public AspNetUsers()
        {
            AccountMessages = new HashSet<AccountMessages>();
            AccountsUsers = new HashSet<AccountsUsers>();
            AleksDaspecsMaintbl = new HashSet<AleksDaspecsMaintbl>();
            AspNetUserClaims = new HashSet<AspNetUserClaims>();
            AspNetUserLogins = new HashSet<AspNetUserLogins>();
            AspNetUserRoles = new HashSet<AspNetUserRoles>();
            DiaryPosts = new HashSet<DiaryPosts>();
            Files = new HashSet<Files>();
            LogPattern = new HashSet<LogPattern>();
            LogPatternToUsers = new HashSet<LogPatternToUsers>();
            Logs = new HashSet<Logs>();
            MessageToUsers = new HashSet<MessageToUsers>();
            Messages = new HashSet<Messages>();
            News = new HashSet<News>();
            ProjectTypes = new HashSet<ProjectTypes>();
            ProjectTypesUser = new HashSet<ProjectTypesUser>();
            ProjectsCreator = new HashSet<Projects>();
            ProjectsOwner = new HashSet<Projects>();
            ProjectsUsers = new HashSet<ProjectsUsers>();
            Request = new HashSet<Request>();
            StatusSign = new HashSet<StatusSign>();
            TaskCheckList = new HashSet<TaskCheckList>();
            TaskFollowers = new HashSet<TaskFollowers>();
            TaskStatusHistory = new HashSet<TaskStatusHistory>();
            TasksDoer = new HashSet<Tasks>();
            TasksOwner = new HashSet<Tasks>();
        }

        public string Id { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTime? LockoutEndDateUtc { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string UserName { get; set; }

        public virtual ICollection<AccountMessages> AccountMessages { get; set; }
        public virtual ICollection<AccountsUsers> AccountsUsers { get; set; }
        public virtual ICollection<AleksDaspecsMaintbl> AleksDaspecsMaintbl { get; set; }
        public virtual ICollection<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual ICollection<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual ICollection<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual ICollection<DiaryPosts> DiaryPosts { get; set; }
        public virtual ICollection<Files> Files { get; set; }
        public virtual ICollection<LogPattern> LogPattern { get; set; }
        public virtual ICollection<LogPatternToUsers> LogPatternToUsers { get; set; }
        public virtual ICollection<Logs> Logs { get; set; }
        public virtual ICollection<MessageToUsers> MessageToUsers { get; set; }
        public virtual ICollection<Messages> Messages { get; set; }
        public virtual ICollection<News> News { get; set; }
        public virtual ICollection<ProjectTypes> ProjectTypes { get; set; }
        public virtual ICollection<ProjectTypesUser> ProjectTypesUser { get; set; }
        public virtual ICollection<Projects> ProjectsCreator { get; set; }
        public virtual ICollection<Projects> ProjectsOwner { get; set; }
        public virtual ICollection<ProjectsUsers> ProjectsUsers { get; set; }
        public virtual ICollection<Request> Request { get; set; }
        public virtual ICollection<StatusSign> StatusSign { get; set; }
        public virtual ICollection<TaskCheckList> TaskCheckList { get; set; }
        public virtual ICollection<TaskFollowers> TaskFollowers { get; set; }
        public virtual ICollection<TaskStatusHistory> TaskStatusHistory { get; set; }
        public virtual ICollection<Tasks> TasksDoer { get; set; }
        public virtual ICollection<Tasks> TasksOwner { get; set; }
    }
}
