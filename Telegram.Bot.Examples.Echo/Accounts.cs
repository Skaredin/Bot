using System;
using System.Collections.Generic;

namespace Telegram.Bot.Examples.Echo
{
    public partial class Accounts
    {
        public Accounts()
        {
            AccountMessages = new HashSet<AccountMessages>();
            AccountsCategories = new HashSet<AccountsCategories>();
            AccountsFiles = new HashSet<AccountsFiles>();
            AccountsModeration = new HashSet<AccountsModeration>();
            AccountsRoles = new HashSet<AccountsRoles>();
            AccountsUsers = new HashSet<AccountsUsers>();
            AleksDaspecsAccounts = new HashSet<AleksDaspecsAccounts>();
            DiaryPosts = new HashSet<DiaryPosts>();
            ErrorC100txOrders = new HashSet<ErrorC100txOrders>();
            Logs = new HashSet<Logs>();
            News = new HashSet<News>();
            Payments = new HashSet<Payments>();
            Projects = new HashSet<Projects>();
            StatusSign = new HashSet<StatusSign>();
            _100txOrders = new HashSet<_100txOrders>();
            _100txPlans = new HashSet<_100txPlans>();
        }

        public long Id { get; set; }
        public string ShortLegalName { get; set; }
        public string FullLegalName { get; set; }
        public string Inn { get; set; }
        public string DirectorFullName { get; set; }
        public string ContactName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Site { get; set; }
        public int? Industry { get; set; }
        public string ActualStreet { get; set; }
        public string LegalStreet { get; set; }
        public string BankBic { get; set; }
        public string BankName { get; set; }
        public string BankAccount { get; set; }
        public string BankKorrespondent { get; set; }
        public string Kpp { get; set; }
        public Guid? ClientGuid { get; set; }
        public string NumberContract { get; set; }
        public DateTime? DateContract { get; set; }
        public Guid? Guid { get; set; }
        public string Ogrn { get; set; }
        public string PostDirector { get; set; }
        public string PostContact { get; set; }
        public string Document { get; set; }
        public string Interaction { get; set; }
        public DateTime? Dateadd { get; set; }
        public bool? NdsYes { get; set; }
        public bool? NdsNo { get; set; }
        public bool? ZakupkiYes { get; set; }
        public bool? ZakupkiNo { get; set; }
        public string SkladAddress { get; set; }
        public string KptextBlock { get; set; }

        public virtual AccountIndustryHb IndustryNavigation { get; set; }
        public virtual ICollection<AccountMessages> AccountMessages { get; set; }
        public virtual ICollection<AccountsCategories> AccountsCategories { get; set; }
        public virtual ICollection<AccountsFiles> AccountsFiles { get; set; }
        public virtual ICollection<AccountsModeration> AccountsModeration { get; set; }
        public virtual ICollection<AccountsRoles> AccountsRoles { get; set; }
        public virtual ICollection<AccountsUsers> AccountsUsers { get; set; }
        public virtual ICollection<AleksDaspecsAccounts> AleksDaspecsAccounts { get; set; }
        public virtual ICollection<DiaryPosts> DiaryPosts { get; set; }
        public virtual ICollection<ErrorC100txOrders> ErrorC100txOrders { get; set; }
        public virtual ICollection<Logs> Logs { get; set; }
        public virtual ICollection<News> News { get; set; }
        public virtual ICollection<Payments> Payments { get; set; }
        public virtual ICollection<Projects> Projects { get; set; }
        public virtual ICollection<StatusSign> StatusSign { get; set; }
        public virtual ICollection<_100txOrders> _100txOrders { get; set; }
        public virtual ICollection<_100txPlans> _100txPlans { get; set; }
    }
}
