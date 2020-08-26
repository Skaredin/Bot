using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Telegram.Bot.Examples.Echo
{
    public partial class u436263_100tztestContext : DbContext
    {
        public u436263_100tztestContext()
        {
        }

        public u436263_100tztestContext(DbContextOptions<u436263_100tztestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountIndustryHb> AccountIndustryHb { get; set; }
        public virtual DbSet<AccountMessages> AccountMessages { get; set; }
        public virtual DbSet<AccountMessagesTypesHb> AccountMessagesTypesHb { get; set; }
        public virtual DbSet<Accounts> Accounts { get; set; }
        public virtual DbSet<AccountsCategories> AccountsCategories { get; set; }
        public virtual DbSet<AccountsFiles> AccountsFiles { get; set; }
        public virtual DbSet<AccountsModeration> AccountsModeration { get; set; }
        public virtual DbSet<AccountsRoles> AccountsRoles { get; set; }
        public virtual DbSet<AccountsRolesHb> AccountsRolesHb { get; set; }
        public virtual DbSet<AccountsUsers> AccountsUsers { get; set; }
        public virtual DbSet<Addresses> Addresses { get; set; }
        public virtual DbSet<AleksBrandRelat> AleksBrandRelat { get; set; }
        public virtual DbSet<AleksBrandTbl> AleksBrandTbl { get; set; }
        public virtual DbSet<AleksColors> AleksColors { get; set; }
        public virtual DbSet<AleksCurrencies> AleksCurrencies { get; set; }
        public virtual DbSet<AleksDaspecsAccessrules> AleksDaspecsAccessrules { get; set; }
        public virtual DbSet<AleksDaspecsAccounts> AleksDaspecsAccounts { get; set; }
        public virtual DbSet<AleksDaspecsBills> AleksDaspecsBills { get; set; }
        public virtual DbSet<AleksDaspecsGoodstbl> AleksDaspecsGoodstbl { get; set; }
        public virtual DbSet<AleksDaspecsGoodstblOld> AleksDaspecsGoodstblOld { get; set; }
        public virtual DbSet<AleksDaspecsLinestbl> AleksDaspecsLinestbl { get; set; }
        public virtual DbSet<AleksDaspecsLinestblOld> AleksDaspecsLinestblOld { get; set; }
        public virtual DbSet<AleksDaspecsMaintbl> AleksDaspecsMaintbl { get; set; }
        public virtual DbSet<AleksEnglishWords> AleksEnglishWords { get; set; }
        public virtual DbSet<AleksGoodsColors> AleksGoodsColors { get; set; }
        public virtual DbSet<AleksGoodsColors1> AleksGoodsColors1 { get; set; }
        public virtual DbSet<AleksGoodsColors2> AleksGoodsColors2 { get; set; }
        public virtual DbSet<AleksGoodsModerate> AleksGoodsModerate { get; set; }
        public virtual DbSet<AleksGoodsModerate1> AleksGoodsModerate1 { get; set; }
        public virtual DbSet<AleksGoodsParams> AleksGoodsParams { get; set; }
        public virtual DbSet<AleksGoodsParams1> AleksGoodsParams1 { get; set; }
        public virtual DbSet<AleksGoodsPrices> AleksGoodsPrices { get; set; }
        public virtual DbSet<AleksGoodsPricesLog> AleksGoodsPricesLog { get; set; }
        public virtual DbSet<AleksGoodsPricesOld> AleksGoodsPricesOld { get; set; }
        public virtual DbSet<AleksGoodsProviders> AleksGoodsProviders { get; set; }
        public virtual DbSet<AleksGoodsProvidersLog> AleksGoodsProvidersLog { get; set; }
        public virtual DbSet<AleksGoodsProvidersOld> AleksGoodsProvidersOld { get; set; }
        public virtual DbSet<AleksProviderInfo> AleksProviderInfo { get; set; }
        public virtual DbSet<AleksProviderInfoOld> AleksProviderInfoOld { get; set; }
        public virtual DbSet<AleksProviderStatus> AleksProviderStatus { get; set; }
        public virtual DbSet<AleksProviderStatus1> AleksProviderStatus1 { get; set; }
        public virtual DbSet<AleksUsersRelations> AleksUsersRelations { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetRolesMenus> AspNetRolesMenus { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Balance> Balance { get; set; }
        public virtual DbSet<BalanceTypeHb> BalanceTypeHb { get; set; }
        public virtual DbSet<BankDetails> BankDetails { get; set; }
        public virtual DbSet<CatalogCategories> CatalogCategories { get; set; }
        public virtual DbSet<CatalogCategories1> CatalogCategories1 { get; set; }
        public virtual DbSet<CatalogDiskfiles> CatalogDiskfiles { get; set; }
        public virtual DbSet<CatalogDiskfiles1> CatalogDiskfiles1 { get; set; }
        public virtual DbSet<CatalogGoods> CatalogGoods { get; set; }
        public virtual DbSet<CatalogGoodsOld> CatalogGoodsOld { get; set; }
        public virtual DbSet<CatalogGoodsSuites> CatalogGoodsSuites { get; set; }
        public virtual DbSet<CatalogTags> CatalogTags { get; set; }
        public virtual DbSet<CatalogTags1> CatalogTags1 { get; set; }
        public virtual DbSet<CatalogUnits> CatalogUnits { get; set; }
        public virtual DbSet<CatalogUnits1> CatalogUnits1 { get; set; }
        public virtual DbSet<CategoryUpdate> CategoryUpdate { get; set; }
        public virtual DbSet<ChatProductTypes> ChatProductTypes { get; set; }
        public virtual DbSet<Chats> Chats { get; set; }
        public virtual DbSet<ChatsTypes> ChatsTypes { get; set; }
        public virtual DbSet<CommentClientToRecord> CommentClientToRecord { get; set; }
        public virtual DbSet<CommentClientToRecords> CommentClientToRecords { get; set; }
        public virtual DbSet<DiaryPosts> DiaryPosts { get; set; }
        public virtual DbSet<DocumentsTemplates> DocumentsTemplates { get; set; }
        public virtual DbSet<DocumentsTypesHb> DocumentsTypesHb { get; set; }
        public virtual DbSet<EmailStatusLog> EmailStatusLog { get; set; }
        public virtual DbSet<ErrorC100txFindCategory> ErrorC100txFindCategory { get; set; }
        public virtual DbSet<ErrorC100txGoodLoaderProviderUrls> ErrorC100txGoodLoaderProviderUrls { get; set; }
        public virtual DbSet<ErrorC100txOrders> ErrorC100txOrders { get; set; }
        public virtual DbSet<ErrorC100txPlanPositions> ErrorC100txPlanPositions { get; set; }
        public virtual DbSet<ErrorC100txPlans> ErrorC100txPlans { get; set; }
        public virtual DbSet<ErrorC100txRegions> ErrorC100txRegions { get; set; }
        public virtual DbSet<ErrorC100txRegionsHeaders> ErrorC100txRegionsHeaders { get; set; }
        public virtual DbSet<ErrorC100txTasksStatusesHb> ErrorC100txTasksStatusesHb { get; set; }
        public virtual DbSet<ErrorC100txZakupkiTasks> ErrorC100txZakupkiTasks { get; set; }
        public virtual DbSet<FeedbackRequests> FeedbackRequests { get; set; }
        public virtual DbSet<Files> Files { get; set; }
        public virtual DbSet<Functions> Functions { get; set; }
        public virtual DbSet<HelpCategories> HelpCategories { get; set; }
        public virtual DbSet<HelpComments> HelpComments { get; set; }
        public virtual DbSet<HelpContent> HelpContent { get; set; }
        public virtual DbSet<HelpRoles> HelpRoles { get; set; }
        public virtual DbSet<Layouts> Layouts { get; set; }
        public virtual DbSet<LogAction> LogAction { get; set; }
        public virtual DbSet<LogPattern> LogPattern { get; set; }
        public virtual DbSet<LogPatternToUsers> LogPatternToUsers { get; set; }
        public virtual DbSet<LogPatternUserEntiity> LogPatternUserEntiity { get; set; }
        public virtual DbSet<LogPropertySaveTable> LogPropertySaveTable { get; set; }
        public virtual DbSet<Logs> Logs { get; set; }
        public virtual DbSet<LogsMessages> LogsMessages { get; set; }
        public virtual DbSet<LogsTypes> LogsTypes { get; set; }
        public virtual DbSet<MapRegion> MapRegion { get; set; }
        public virtual DbSet<MenuList> MenuList { get; set; }
        public virtual DbSet<MenuType> MenuType { get; set; }
        public virtual DbSet<MessageFile> MessageFile { get; set; }
        public virtual DbSet<MessageToUsers> MessageToUsers { get; set; }
        public virtual DbSet<Messages> Messages { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistory { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Offices> Offices { get; set; }
        public virtual DbSet<Okpd> Okpd { get; set; }
        public virtual DbSet<Okpd2> Okpd2 { get; set; }
        public virtual DbSet<Parse> Parse { get; set; }
        public virtual DbSet<Payments> Payments { get; set; }
        public virtual DbSet<PaymentsIncommingParams> PaymentsIncommingParams { get; set; }
        public virtual DbSet<PaymentsOutgoingParams> PaymentsOutgoingParams { get; set; }
        public virtual DbSet<PaymentsTypesHb> PaymentsTypesHb { get; set; }
        public virtual DbSet<PriceTypesHb> PriceTypesHb { get; set; }
        public virtual DbSet<PrjPhoneNumbers> PrjPhoneNumbers { get; set; }
        public virtual DbSet<PrjPreferences> PrjPreferences { get; set; }
        public virtual DbSet<PrjSetPosition> PrjSetPosition { get; set; }
        public virtual DbSet<PrjSetTypeData> PrjSetTypeData { get; set; }
        public virtual DbSet<PrjSettings> PrjSettings { get; set; }
        public virtual DbSet<PrjSettingsData> PrjSettingsData { get; set; }
        public virtual DbSet<PrjTelecomOperators> PrjTelecomOperators { get; set; }
        public virtual DbSet<ProjectSettings> ProjectSettings { get; set; }
        public virtual DbSet<ProjectStatuses> ProjectStatuses { get; set; }
        public virtual DbSet<ProjectTypeSetting> ProjectTypeSetting { get; set; }
        public virtual DbSet<ProjectTypes> ProjectTypes { get; set; }
        public virtual DbSet<ProjectTypes1> ProjectTypes1 { get; set; }
        public virtual DbSet<ProjectTypesUser> ProjectTypesUser { get; set; }
        public virtual DbSet<Projects> Projects { get; set; }
        public virtual DbSet<ProjectsServices> ProjectsServices { get; set; }
        public virtual DbSet<ProjectsUsers> ProjectsUsers { get; set; }
        public virtual DbSet<RecognitionSpecTable> RecognitionSpecTable { get; set; }
        public virtual DbSet<RecordOfTelegramsBott> RecordOfTelegramsBott { get; set; }
        public virtual DbSet<Request> Request { get; set; }
        public virtual DbSet<RequestTypesHb> RequestTypesHb { get; set; }
        public virtual DbSet<Services> Services { get; set; }
        public virtual DbSet<ServicesData> ServicesData { get; set; }
        public virtual DbSet<ServicesPreferences> ServicesPreferences { get; set; }
        public virtual DbSet<ServicesPreferencesHb> ServicesPreferencesHb { get; set; }
        public virtual DbSet<ServicesPreferencesTypes> ServicesPreferencesTypes { get; set; }
        public virtual DbSet<ServicesPrices> ServicesPrices { get; set; }
        public virtual DbSet<Sheet1> Sheet1 { get; set; }
        public virtual DbSet<Signatory> Signatory { get; set; }
        public virtual DbSet<Statistic> Statistic { get; set; }
        public virtual DbSet<StatisticLeftMenu> StatisticLeftMenu { get; set; }
        public virtual DbSet<StatisticLeftMenus> StatisticLeftMenus { get; set; }
        public virtual DbSet<StatisticOktell> StatisticOktell { get; set; }
        public virtual DbSet<StatisticPbx> StatisticPbx { get; set; }
        public virtual DbSet<StatisticPbxOld> StatisticPbxOld { get; set; }
        public virtual DbSet<StatusSign> StatusSign { get; set; }
        public virtual DbSet<TableColumnType> TableColumnType { get; set; }
        public virtual DbSet<TableColumns> TableColumns { get; set; }
        public virtual DbSet<TableData> TableData { get; set; }
        public virtual DbSet<TableRows> TableRows { get; set; }
        public virtual DbSet<TableType> TableType { get; set; }
        public virtual DbSet<Tables> Tables { get; set; }
        public virtual DbSet<TablesInEntity> TablesInEntity { get; set; }
        public virtual DbSet<TablesPatterns> TablesPatterns { get; set; }
        public virtual DbSet<Tablies> Tablies { get; set; }
        public virtual DbSet<Tarifs> Tarifs { get; set; }
        public virtual DbSet<TarifsData> TarifsData { get; set; }
        public virtual DbSet<TaskCheckList> TaskCheckList { get; set; }
        public virtual DbSet<TaskChecks> TaskChecks { get; set; }
        public virtual DbSet<TaskDoers> TaskDoers { get; set; }
        public virtual DbSet<TaskFollowers> TaskFollowers { get; set; }
        public virtual DbSet<TaskPersonalStatuses> TaskPersonalStatuses { get; set; }
        public virtual DbSet<TaskPriority> TaskPriority { get; set; }
        public virtual DbSet<TaskProjectsStatuses> TaskProjectsStatuses { get; set; }
        public virtual DbSet<TaskStatusHistory> TaskStatusHistory { get; set; }
        public virtual DbSet<TaskTags> TaskTags { get; set; }
        public virtual DbSet<Tasks> Tasks { get; set; }
        public virtual DbSet<TemplatesKp> TemplatesKp { get; set; }
        public virtual DbSet<TypeFileKp> TypeFileKp { get; set; }
        public virtual DbSet<UsersProviders> UsersProviders { get; set; }
        public virtual DbSet<_1> _1 { get; set; }
        public virtual DbSet<_100txFindCategory> _100txFindCategory { get; set; }
        public virtual DbSet<_100txGoodLoaderLoaderTypes> _100txGoodLoaderLoaderTypes { get; set; }
        public virtual DbSet<_100txGoodLoaderProviderUrls> _100txGoodLoaderProviderUrls { get; set; }
        public virtual DbSet<_100txLayoutsDoc> _100txLayoutsDoc { get; set; }
        public virtual DbSet<_100txLayoutsDocTypes> _100txLayoutsDocTypes { get; set; }
        public virtual DbSet<_100txOrders> _100txOrders { get; set; }
        public virtual DbSet<_100txOrdersStatusHistory> _100txOrdersStatusHistory { get; set; }
        public virtual DbSet<_100txOrdersStatuses> _100txOrdersStatuses { get; set; }
        public virtual DbSet<_100txPlanPositions> _100txPlanPositions { get; set; }
        public virtual DbSet<_100txPlans> _100txPlans { get; set; }
        public virtual DbSet<_100txPositionAlternates> _100txPositionAlternates { get; set; }
        public virtual DbSet<_100txPositionAlternatesCatalogs> _100txPositionAlternatesCatalogs { get; set; }
        public virtual DbSet<_100txRegions> _100txRegions { get; set; }
        public virtual DbSet<_100txRegionsHeaders> _100txRegionsHeaders { get; set; }
        public virtual DbSet<_100txRevisions> _100txRevisions { get; set; }
        public virtual DbSet<_100txStages> _100txStages { get; set; }
        public virtual DbSet<_100txTasksStatusesHb> _100txTasksStatusesHb { get; set; }
        public virtual DbSet<_100txZakupkiTasks> _100txZakupkiTasks { get; set; }
        public virtual DbSet<_30031> _30031 { get; set; }
        public virtual DbSet<Лист1> Лист1 { get; set; }
        public virtual DbSet<Окпд2> Окпд2 { get; set; }
        public virtual DbSet<Окпд22> Окпд22 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=u436263.mssql.masterhost.ru;Database=u436263_100tztest;User ID=u436263_test;Password=pr7pitting;multisubnetfailover=false;Trusted_Connection=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountIndustryHb>(entity =>
            {
                entity.ToTable("Account_IndustryHB");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AccountMessages>(entity =>
            {
                entity.ToTable("Account_Messages");

                entity.HasIndex(e => e.AccountId)
                    .HasName("IX_FK_Account_Messages_Accounts");

                entity.HasIndex(e => e.TypeId)
                    .HasName("IX_FK_Account_Messages_Account_MessagesTypesHB");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_FK_Account_Messages_AspNetUsers");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountId).HasColumnName("account_id");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasMaxLength(128)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnName("message");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasMaxLength(128);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AccountMessages)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Account_Messages_Accounts");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.AccountMessages)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Account_Messages_Account_MessagesTypesHB");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AccountMessages)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Account_Messages_AspNetUsers");
            });

            modelBuilder.Entity<AccountMessagesTypesHb>(entity =>
            {
                entity.ToTable("Account_MessagesTypesHB");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Accounts>(entity =>
            {
                entity.HasIndex(e => e.Industry)
                    .HasName("IX_FK_Accounts_Account_IndustryHB");

                entity.Property(e => e.ActualStreet)
                    .HasColumnName("Actual_Street")
                    .HasMaxLength(200);

                entity.Property(e => e.BankAccount)
                    .HasColumnName("Bank_Account")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.BankBic)
                    .HasColumnName("Bank_Bic")
                    .HasMaxLength(9)
                    .IsFixedLength();

                entity.Property(e => e.BankKorrespondent)
                    .HasColumnName("Bank_Korrespondent")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.BankName)
                    .HasColumnName("Bank_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.ContactName).HasMaxLength(200);

                entity.Property(e => e.DateContract).HasColumnType("date");

                entity.Property(e => e.Dateadd)
                    .HasColumnName("dateadd")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DirectorFullName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Document).HasMaxLength(128);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FullLegalName).IsRequired();

                entity.Property(e => e.Guid).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Inn)
                    .IsRequired()
                    .HasColumnName("INN")
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.Interaction).HasMaxLength(128);

                entity.Property(e => e.Kpp)
                    .HasColumnName("KPP")
                    .HasMaxLength(20);

                entity.Property(e => e.KptextBlock).HasColumnName("KPTextBlock");

                entity.Property(e => e.LegalStreet)
                    .HasColumnName("Legal_Street")
                    .HasMaxLength(200);

                entity.Property(e => e.NdsNo).HasColumnName("NDS_NO");

                entity.Property(e => e.NdsYes).HasColumnName("NDS_YES");

                entity.Property(e => e.Ogrn).HasMaxLength(15);

                entity.Property(e => e.Phone).HasMaxLength(15);

                entity.Property(e => e.PostContact).HasMaxLength(128);

                entity.Property(e => e.PostDirector).HasMaxLength(128);

                entity.Property(e => e.ShortLegalName)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.SkladAddress)
                    .HasColumnName("SKLAD_ADDRESS")
                    .HasMaxLength(1000);

                entity.Property(e => e.ZakupkiNo).HasColumnName("ZAKUPKI_NO");

                entity.Property(e => e.ZakupkiYes).HasColumnName("ZAKUPKI_YES");

                entity.HasOne(d => d.IndustryNavigation)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.Industry)
                    .HasConstraintName("FK_Accounts_Account_IndustryHB");
            });

            modelBuilder.Entity<AccountsCategories>(entity =>
            {
                entity.ToTable("Accounts_Categories");

                entity.HasIndex(e => e.AccountId)
                    .HasName("IX_FK_Accounts_Categories_Accounts");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("IX_FK_Accounts_Categories_catalog_categories");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountId).HasColumnName("account_id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AccountsCategories)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Accounts_Categories_Accounts");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.AccountsCategories)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Accounts_Categories_catalog_categories");
            });

            modelBuilder.Entity<AccountsFiles>(entity =>
            {
                entity.ToTable("Accounts_Files");

                entity.HasIndex(e => e.AccountId)
                    .HasName("IX_FK_Accounts_Files_Accounts");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountId).HasColumnName("accountId");

                entity.Property(e => e.File)
                    .IsRequired()
                    .HasColumnName("file");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasColumnName("fileName")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AccountsFiles)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Accounts_Files_Accounts");
            });

            modelBuilder.Entity<AccountsModeration>(entity =>
            {
                entity.ToTable("Accounts_Moderation");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountId).HasColumnName("account_id");

                entity.Property(e => e.GuId).HasMaxLength(128);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AccountsModeration)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_Accounts_Moderation_Accounts");
            });

            modelBuilder.Entity<AccountsRoles>(entity =>
            {
                entity.ToTable("Accounts_Roles");

                entity.HasIndex(e => e.Account)
                    .HasName("IX_FK_Accounts_Roles_Accounts");

                entity.HasIndex(e => e.Role)
                    .HasName("IX_FK_Accounts_Roles_Accounts_RolesHB");

                entity.HasOne(d => d.AccountNavigation)
                    .WithMany(p => p.AccountsRoles)
                    .HasForeignKey(d => d.Account)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Accounts_Roles_Accounts");

                entity.HasOne(d => d.RoleNavigation)
                    .WithMany(p => p.AccountsRoles)
                    .HasForeignKey(d => d.Role)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Accounts_Roles_Accounts_RolesHB");
            });

            modelBuilder.Entity<AccountsRolesHb>(entity =>
            {
                entity.ToTable("Accounts_RolesHB");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AccountsUsers>(entity =>
            {
                entity.ToTable("Accounts_Users");

                entity.HasIndex(e => e.AccountId)
                    .HasName("IX_FK_Accounts_Users_Accounts");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_FK_Accounts_Users_AspNetUsers");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountId).HasColumnName("accountId");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("userId")
                    .HasMaxLength(128);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AccountsUsers)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Accounts_Users_Accounts");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AccountsUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Accounts_Users_AspNetUsers");
            });

            modelBuilder.Entity<Addresses>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.City).HasMaxLength(200);

                entity.Property(e => e.Country).HasMaxLength(200);

                entity.Property(e => e.Postcode).HasMaxLength(20);

                entity.Property(e => e.Region).HasMaxLength(200);

                entity.Property(e => e.Street).HasMaxLength(400);
            });

            modelBuilder.Entity<AleksBrandRelat>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("aleks_brand_relat");

                entity.Property(e => e.Bid).HasColumnName("bid");

                entity.Property(e => e.Opdate).HasColumnName("opdate");

                entity.Property(e => e.Resid).HasColumnName("resid");
            });

            modelBuilder.Entity<AleksBrandTbl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("aleks_brand_tbl");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Opdate).HasColumnName("opdate");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AleksColors>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("aleks_colors");

                entity.Property(e => e.Colcode)
                    .IsRequired()
                    .HasColumnName("colcode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AleksCurrencies>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("aleks_currencies");

                entity.Property(e => e.Cost)
                    .HasColumnName("cost")
                    .HasColumnType("decimal(10, 4)");

                entity.Property(e => e.Currency)
                    .IsRequired()
                    .HasColumnName("currency")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Opdate).HasColumnName("opdate");
            });

            modelBuilder.Entity<AleksDaspecsAccessrules>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("aleks_daspecs_accessrules");

                entity.Property(e => e.Createdby).HasColumnName("createdby");

                entity.Property(e => e.Createdon).HasColumnName("createdon");

                entity.Property(e => e.Permission)
                    .IsRequired()
                    .HasColumnName("permission")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SpecId).HasColumnName("spec_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<AleksDaspecsAccounts>(entity =>
            {
                entity.ToTable("aleks_daspecs_accounts");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountId).HasColumnName("account_id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.LineId).HasColumnName("line_id");

                entity.Property(e => e.LinestblId).HasColumnName("linestbl_id");

                entity.Property(e => e.SpecId).HasColumnName("spec_id");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AleksDaspecsAccounts)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_aleks_daspecs_accounts_Accounts");

                entity.HasOne(d => d.Linestbl)
                    .WithMany(p => p.AleksDaspecsAccounts)
                    .HasForeignKey(d => d.LinestblId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_aleks_daspecs_accounts_aleks_daspecs_linestbl");
            });

            modelBuilder.Entity<AleksDaspecsBills>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("aleks_daspecs_bills");

                entity.Property(e => e.BillCode)
                    .IsRequired()
                    .HasColumnName("bill_code")
                    .HasMaxLength(255);

                entity.Property(e => e.BillImage)
                    .IsRequired()
                    .HasColumnName("bill_image");

                entity.Property(e => e.CustomerInn)
                    .IsRequired()
                    .HasColumnName("customer_inn")
                    .HasMaxLength(255);

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsExport).HasColumnName("is_export");

                entity.Property(e => e.LegalCode)
                    .IsRequired()
                    .HasColumnName("legal_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Opdate).HasColumnName("opdate");

                entity.Property(e => e.Prepay).HasColumnName("prepay");

                entity.Property(e => e.SpecId).HasColumnName("spec_id");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(255);

                entity.Property(e => e.StatusDescription)
                    .IsRequired()
                    .HasColumnName("status_description")
                    .HasMaxLength(255);

                entity.Property(e => e.TitleSource)
                    .IsRequired()
                    .HasColumnName("title_source")
                    .HasMaxLength(255);

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Vat).HasColumnName("vat");
            });

            modelBuilder.Entity<AleksDaspecsGoodstbl>(entity =>
            {
                entity.ToTable("aleks_daspecs_goodstbl");

                entity.HasIndex(e => new { e.SpecId, e.LineId })
                    .HasName("IX_aleks_daspecs_goodstbl");

                entity.HasIndex(e => new { e.SpecId, e.LineId, e.ApprovedByProvider })
                    .HasName("IX_aleks_daspecs_goodstbl_1");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApprovedByProvider).HasColumnName("approved_by_provider");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.Currency)
                    .IsRequired()
                    .HasColumnName("currency")
                    .HasMaxLength(10);

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.GoodId).HasColumnName("good_id");

                entity.Property(e => e.GoodParentId).HasColumnName("good_parent_id");

                entity.Property(e => e.IsCheated).HasColumnName("is_cheated");

                entity.Property(e => e.LineId).HasColumnName("line_id");

                entity.Property(e => e.Manufacturer)
                    .IsRequired()
                    .HasColumnName("manufacturer")
                    .HasMaxLength(255);

                entity.Property(e => e.Markup)
                    .HasColumnName("markup")
                    .HasColumnType("decimal(9, 5)");

                entity.Property(e => e.MongoImageId)
                    .HasColumnName("mongo_image_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Params)
                    .IsRequired()
                    .HasColumnName("params");

                entity.Property(e => e.Parent).HasColumnName("parent");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Provider)
                    .IsRequired()
                    .HasColumnName("provider")
                    .HasMaxLength(255);

                entity.Property(e => e.ProviderId).HasColumnName("provider_id");

                entity.Property(e => e.SpecId).HasColumnName("spec_id");

                entity.Property(e => e.SrcId).HasColumnName("src_id");

                entity.Property(e => e.Units).HasColumnName("units");

                entity.Property(e => e.Volume)
                    .HasColumnName("volume")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasColumnType("decimal(8, 2)");
            });

            modelBuilder.Entity<AleksDaspecsGoodstblOld>(entity =>
            {
                entity.ToTable("aleks_daspecs_goodstbl_old");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApprovedByProvider).HasColumnName("approved_by_provider");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasColumnType("text");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.Currency)
                    .IsRequired()
                    .HasColumnName("currency")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.GoodId).HasColumnName("good_id");

                entity.Property(e => e.GoodParentId).HasColumnName("good_parent_id");

                entity.Property(e => e.IsCheated).HasColumnName("is_cheated");

                entity.Property(e => e.LineId).HasColumnName("line_id");

                entity.Property(e => e.Manufacturer)
                    .IsRequired()
                    .HasColumnName("manufacturer")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MongoImageId)
                    .HasColumnName("mongo_image_id")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Params)
                    .IsRequired()
                    .HasColumnName("params")
                    .HasColumnType("text");

                entity.Property(e => e.Parent).HasColumnName("parent");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Provider)
                    .IsRequired()
                    .HasColumnName("provider")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderId).HasColumnName("provider_id");

                entity.Property(e => e.SpecId).HasColumnName("spec_id");

                entity.Property(e => e.SrcId).HasColumnName("src_id");

                entity.Property(e => e.Units).HasColumnName("units");

                entity.Property(e => e.Volume)
                    .HasColumnName("volume")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasColumnType("decimal(8, 2)");
            });

            modelBuilder.Entity<AleksDaspecsLinestbl>(entity =>
            {
                entity.ToTable("aleks_daspecs_linestbl");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AdditionalInfo).HasColumnName("additional_info");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CompareCost)
                    .HasColumnName("compare_cost")
                    .HasColumnType("decimal(11, 2)");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.EmptyLineComment).HasColumnName("empty_line_comment");

                entity.Property(e => e.IsInfoblock).HasColumnName("is_infoblock");

                entity.Property(e => e.IsWrong).HasColumnName("is_wrong");

                entity.Property(e => e.LineId).HasColumnName("line_id");

                entity.Property(e => e.Mark)
                    .HasColumnName("mark")
                    .HasMaxLength(255);

                entity.Property(e => e.Number)
                    .HasColumnName("number")
                    .HasMaxLength(255);

                entity.Property(e => e.PositionId).HasColumnName("position_id");

                entity.Property(e => e.SpecId).HasColumnName("spec_id");

                entity.Property(e => e.Title).HasColumnName("title");

                entity.Property(e => e.Units)
                    .IsRequired()
                    .HasColumnName("units")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<AleksDaspecsLinestblOld>(entity =>
            {
                entity.HasKey(e => new { e.SpecId, e.LineId })
                    .HasName("PK_aleks_daspecs_linestbl");

                entity.ToTable("aleks_daspecs_linestbl_old");

                entity.Property(e => e.SpecId).HasColumnName("spec_id");

                entity.Property(e => e.LineId).HasColumnName("line_id");

                entity.Property(e => e.AdditionalInfo)
                    .HasColumnName("additional_info")
                    .HasColumnType("text");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasColumnType("text");

                entity.Property(e => e.CompareCost)
                    .HasColumnName("compare_cost")
                    .HasColumnType("decimal(11, 2)");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.EmptyLineComment)
                    .HasColumnName("empty_line_comment")
                    .HasColumnType("text");

                entity.Property(e => e.IsInfoblock).HasColumnName("is_infoblock");

                entity.Property(e => e.IsWrong).HasColumnName("is_wrong");

                entity.Property(e => e.Mark)
                    .HasColumnName("mark")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Number)
                    .HasColumnName("number")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("text");

                entity.Property(e => e.Units)
                    .IsRequired()
                    .HasColumnName("units")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AleksDaspecsMaintbl>(entity =>
            {
                entity.ToTable("aleks_daspecs_maintbl");

                entity.HasIndex(e => e.User)
                    .HasName("IX_FK_aleks_daspecs_maintbl_AspNetUsers");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Alias)
                    .HasColumnName("alias")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BottomDescription)
                    .IsRequired()
                    .HasColumnName("bottom_description")
                    .HasColumnType("text");

                entity.Property(e => e.Chked).HasColumnName("chked");

                entity.Property(e => e.CustomerBid).HasColumnName("customer_bid");

                entity.Property(e => e.CustomerContacts)
                    .IsRequired()
                    .HasColumnName("customer_contacts")
                    .HasColumnType("text");

                entity.Property(e => e.CustomerInn)
                    .HasColumnName("customer_inn")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasColumnName("customer_name")
                    .HasColumnType("text");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.DealBid).HasColumnName("deal_bid");

                entity.Property(e => e.DealName)
                    .IsRequired()
                    .HasColumnName("deal_name")
                    .HasColumnType("text");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Delivery).HasColumnName("delivery");

                entity.Property(e => e.DeployObject)
                    .IsRequired()
                    .HasColumnName("deploy_object")
                    .HasColumnType("text");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.HeadMail)
                    .IsRequired()
                    .HasColumnName("head_mail")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsCart).HasColumnName("is_cart");

                entity.Property(e => e.IsExport).HasColumnName("is_export");

                entity.Property(e => e.IsOpenedToProvider).HasColumnName("is_opened_to_provider");

                entity.Property(e => e.IsPublic).HasColumnName("is_public");

                entity.Property(e => e.LegalCompany)
                    .IsRequired()
                    .HasColumnName("legal_company")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MrkMail)
                    .IsRequired()
                    .HasColumnName("mrk_mail")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("text");

                entity.Property(e => e.Parent).HasColumnName("parent");

                entity.Property(e => e.RealTitle)
                    .IsRequired()
                    .HasColumnName("real_title")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SellerMail)
                    .IsRequired()
                    .HasColumnName("seller_mail")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SerialSession)
                    .HasColumnName("serial_session")
                    .HasColumnType("text");

                entity.Property(e => e.ShopDate).HasColumnName("shop_date");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UniqTitle)
                    .IsRequired()
                    .HasColumnName("uniq_title")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.User)
                    .HasColumnName("user")
                    .HasMaxLength(128);

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.UserNavigation)
                    .WithMany(p => p.AleksDaspecsMaintbl)
                    .HasForeignKey(d => d.User)
                    .HasConstraintName("FK_aleks_daspecs_maintbl_AspNetUsers");
            });

            modelBuilder.Entity<AleksEnglishWords>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("aleks_english_words");

                entity.Property(e => e.Word)
                    .IsRequired()
                    .HasColumnName("word")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AleksGoodsColors>(entity =>
            {
                entity.HasKey(e => new { e.Cid, e.Resid, e.Opdate, e.Img, e.Price, e.IsDefault });

                entity.ToTable("aleks_goods_colors");

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.Resid).HasColumnName("resid");

                entity.Property(e => e.Opdate).HasColumnName("opdate");

                entity.Property(e => e.Img)
                    .HasColumnName("img")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsDefault).HasColumnName("is_default");
            });

            modelBuilder.Entity<AleksGoodsColors1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("aleks_goods-colors");

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.Img)
                    .IsRequired()
                    .HasColumnName("img")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsDefault).HasColumnName("is_default");

                entity.Property(e => e.Opdate).HasColumnName("opdate");

                entity.Property(e => e.Price)
                    .IsRequired()
                    .HasColumnName("price")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Resid).HasColumnName("resid");
            });

            modelBuilder.Entity<AleksGoodsColors2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("aleks_goods-colors", "inventory3");

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.Img)
                    .IsRequired()
                    .HasColumnName("img")
                    .HasMaxLength(255);

                entity.Property(e => e.IsDefault).HasColumnName("is_default");

                entity.Property(e => e.Opdate).HasColumnName("opdate");

                entity.Property(e => e.Price)
                    .IsRequired()
                    .HasColumnName("price")
                    .HasMaxLength(100);

                entity.Property(e => e.Resid).HasColumnName("resid");
            });

            modelBuilder.Entity<AleksGoodsModerate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("aleks_goods_moderate");

                entity.Property(e => e.Addedby).HasColumnName("addedby");

                entity.Property(e => e.Addedon).HasColumnName("addedon");

                entity.Property(e => e.BlockedBy).HasColumnName("blocked_by");

                entity.Property(e => e.BlockedTill).HasColumnName("blocked_till");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("comment")
                    .HasColumnType("text");

                entity.Property(e => e.CustomProvider)
                    .IsRequired()
                    .HasColumnName("custom_provider")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.GoodId).HasColumnName("good_id");

                entity.Property(e => e.GoodSrc)
                    .IsRequired()
                    .HasColumnName("good_src")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AleksGoodsModerate1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("aleks_goods_moderate", "inventory3");

                entity.Property(e => e.Addedby).HasColumnName("addedby");

                entity.Property(e => e.Addedon).HasColumnName("addedon");

                entity.Property(e => e.BlockedBy).HasColumnName("blocked_by");

                entity.Property(e => e.BlockedTill).HasColumnName("blocked_till");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("comment");

                entity.Property(e => e.CustomProvider)
                    .IsRequired()
                    .HasColumnName("custom_provider")
                    .HasMaxLength(255);

                entity.Property(e => e.GoodId).HasColumnName("good_id");

                entity.Property(e => e.GoodSrc)
                    .IsRequired()
                    .HasColumnName("good_src")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<AleksGoodsParams>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("aleks_goods_params");

                entity.Property(e => e.Cprice).HasColumnName("cprice");

                entity.Property(e => e.GoodId).HasColumnName("good_id");

                entity.Property(e => e.IsKit).HasColumnName("is_kit");

                entity.Property(e => e.Parametr)
                    .IsRequired()
                    .HasColumnName("parametr")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasColumnName("unit")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AleksGoodsParams1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("aleks_goods_params", "inventory3");

                entity.Property(e => e.Cprice).HasColumnName("cprice");

                entity.Property(e => e.GoodId).HasColumnName("good_id");

                entity.Property(e => e.IsKit).HasColumnName("is_kit");

                entity.Property(e => e.Parametr)
                    .IsRequired()
                    .HasColumnName("parametr")
                    .HasMaxLength(255);

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasColumnName("unit")
                    .HasMaxLength(255);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<AleksGoodsPrices>(entity =>
            {
                entity.HasKey(e => e.GoodId);

                entity.ToTable("aleks_goods_prices");

                entity.Property(e => e.GoodId)
                    .HasColumnName("good_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Currency)
                    .IsRequired()
                    .HasColumnName("currency")
                    .HasMaxLength(255);

                entity.Property(e => e.CustomVatChanging).HasColumnName("custom_vat_changing");

                entity.Property(e => e.DeliveryClientRate).HasColumnName("delivery_client_rate");

                entity.Property(e => e.DeliveryWarehouseRate).HasColumnName("delivery_warehouse_rate");

                entity.Property(e => e.DeploymentRate).HasColumnName("deployment_rate");

                entity.Property(e => e.Discount).HasColumnName("discount");

                entity.Property(e => e.HasVat).HasColumnName("has_vat");

                entity.Property(e => e.InPrice).HasColumnName("in_price");

                entity.Property(e => e.IsAutoRecount).HasColumnName("is_auto_recount");

                entity.Property(e => e.Markup).HasColumnName("markup");

                entity.Property(e => e.Opdate).HasColumnName("opdate");

                entity.Property(e => e.Vat).HasColumnName("vat");
            });

            modelBuilder.Entity<AleksGoodsPricesLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("aleks_goods_prices_log");

                entity.Property(e => e.Deletedon)
                    .HasColumnName("deletedon")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.GoodId).HasColumnName("good_id");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<AleksGoodsPricesOld>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("aleks_goods_prices_old");

                entity.Property(e => e.Currency)
                    .IsRequired()
                    .HasColumnName("currency")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CustomVatChanging).HasColumnName("custom_vat_changing");

                entity.Property(e => e.DeliveryClientRate).HasColumnName("delivery_client_rate");

                entity.Property(e => e.DeliveryWarehouseRate).HasColumnName("delivery_warehouse_rate");

                entity.Property(e => e.DeploymentRate).HasColumnName("deployment_rate");

                entity.Property(e => e.Discount).HasColumnName("discount");

                entity.Property(e => e.GoodId).HasColumnName("good_id");

                entity.Property(e => e.HasVat).HasColumnName("has_vat");

                entity.Property(e => e.InPrice).HasColumnName("in_price");

                entity.Property(e => e.IsAutoRecount).HasColumnName("is_auto_recount");

                entity.Property(e => e.Markup).HasColumnName("markup");

                entity.Property(e => e.Opdate).HasColumnName("opdate");

                entity.Property(e => e.Vat).HasColumnName("vat");
            });

            modelBuilder.Entity<AleksGoodsProviders>(entity =>
            {
                entity.HasKey(e => new { e.GoodId, e.ProvId, e.PType });

                entity.ToTable("aleks_goods_providers");

                entity.Property(e => e.GoodId).HasColumnName("good_id");

                entity.Property(e => e.ProvId).HasColumnName("prov_id");

                entity.Property(e => e.PType)
                    .HasColumnName("p_type")
                    .HasMaxLength(255);

                entity.Property(e => e.IsDefault).HasColumnName("is_default");
            });

            modelBuilder.Entity<AleksGoodsProvidersLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("aleks_goods_providers_log");

                entity.Property(e => e.Deletedon)
                    .HasColumnName("deletedon")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.GoodId).HasColumnName("good_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ProvId).HasColumnName("prov_id");
            });

            modelBuilder.Entity<AleksGoodsProvidersOld>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("aleks_goods_providers_old");

                entity.Property(e => e.GoodId).HasColumnName("good_id");

                entity.Property(e => e.IsDefault).HasColumnName("is_default");

                entity.Property(e => e.PType)
                    .IsRequired()
                    .HasColumnName("p_type")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProvId).HasColumnName("prov_id");
            });

            modelBuilder.Entity<AleksProviderInfo>(entity =>
            {
                entity.ToTable("aleks_provider_info");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AgreementDeferment).HasColumnName("agreement_deferment");

                entity.Property(e => e.AgreementType)
                    .HasColumnName("agreement_type")
                    .HasMaxLength(255);

                entity.Property(e => e.DeliveryTimeFrom).HasColumnName("delivery_time_from");

                entity.Property(e => e.DeliveryTimeTo).HasColumnName("delivery_time_to");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Discount).HasColumnName("discount");

                entity.Property(e => e.Img)
                    .HasColumnName("img")
                    .HasMaxLength(255);

                entity.Property(e => e.Inn)
                    .HasColumnName("inn")
                    .HasMaxLength(30);

                entity.Property(e => e.Longtitle).HasColumnName("longtitle");

                entity.Property(e => e.MinPurchase).HasColumnName("min_purchase");

                entity.Property(e => e.MinPurchaseCurrency)
                    .HasColumnName("min_purchase_currency")
                    .HasMaxLength(10);

                entity.Property(e => e.OnModerate).HasColumnName("on_moderate");

                entity.Property(e => e.Pagetitle).HasColumnName("pagetitle");

                entity.Property(e => e.PayDefermentFrom).HasColumnName("pay_deferment_from");

                entity.Property(e => e.PayDefermentTo).HasColumnName("pay_deferment_to");

                entity.Property(e => e.Prepay).HasColumnName("prepay");

                entity.Property(e => e.PriceUpdate).HasColumnName("price_update");

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.Property(e => e.Site)
                    .HasColumnName("site")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxSystem)
                    .HasColumnName("tax_system")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<AleksProviderInfoOld>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("aleks_provider_info_old");

                entity.Property(e => e.AgreementDeferment).HasColumnName("agreement_deferment");

                entity.Property(e => e.AgreementType)
                    .IsRequired()
                    .HasColumnName("agreement_type")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryTimeFrom).HasColumnName("delivery_time_from");

                entity.Property(e => e.DeliveryTimeTo).HasColumnName("delivery_time_to");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Discount).HasColumnName("discount");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Img)
                    .IsRequired()
                    .HasColumnName("img")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Inn)
                    .IsRequired()
                    .HasColumnName("inn")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Longtitle)
                    .IsRequired()
                    .HasColumnName("longtitle")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MinPurchase).HasColumnName("min_purchase");

                entity.Property(e => e.MinPurchaseCurrency)
                    .IsRequired()
                    .HasColumnName("min_purchase_currency")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OnModerate).HasColumnName("on_moderate");

                entity.Property(e => e.Pagetitle)
                    .IsRequired()
                    .HasColumnName("pagetitle")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PayDefermentFrom).HasColumnName("pay_deferment_from");

                entity.Property(e => e.PayDefermentTo).HasColumnName("pay_deferment_to");

                entity.Property(e => e.Prepay).HasColumnName("prepay");

                entity.Property(e => e.PriceUpdate).HasColumnName("price_update");

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.Property(e => e.Site)
                    .IsRequired()
                    .HasColumnName("site")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TaxSystem)
                    .IsRequired()
                    .HasColumnName("tax_system")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AleksProviderStatus>(entity =>
            {
                entity.HasKey(e => new { e.ProvId, e.Type });

                entity.ToTable("aleks_provider_status");

                entity.Property(e => e.ProvId).HasColumnName("prov_id");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AleksProviderStatus1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("aleks_provider_status", "inventory3");

                entity.Property(e => e.ProvId).HasColumnName("prov_id");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<AleksUsersRelations>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("aleks_users_relations", "inventory3");

                entity.Property(e => e.Master).HasColumnName("master");

                entity.Property(e => e.Slave).HasColumnName("slave");
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetRolesMenus>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.MenuId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.AspNetRolesMenus)
                    .HasForeignKey(d => d.MenuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AspNetRolesMenus_MenuList");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRolesMenus)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AspNetRolesMenus_AspNetRoles");
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId)
                    .HasName("IX_FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId })
                    .HasName("PK_dbo.AspNetUserLogins");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK_dbo.AspNetUserRoles");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.Property(e => e.RoleId).HasMaxLength(128);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(128)
                    .HasDefaultValueSql("(CONVERT([nvarchar](128),newid(),0))");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<Balance>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Summ).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Balance)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_Balance_BalanceTypeHB");
            });

            modelBuilder.Entity<BalanceTypeHb>(entity =>
            {
                entity.ToTable("BalanceTypeHB");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Type).HasMaxLength(25);
            });

            modelBuilder.Entity<BankDetails>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BenefeciaryBankName).IsRequired();

                entity.Property(e => e.Bic)
                    .IsRequired()
                    .HasColumnName("BIC")
                    .HasMaxLength(9)
                    .IsFixedLength();

                entity.Property(e => e.CheckingAccount)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.CorrespondingAccountOfBank)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Kbk)
                    .IsRequired()
                    .HasColumnName("KBK")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Kpp)
                    .IsRequired()
                    .HasColumnName("KPP")
                    .HasMaxLength(9)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CatalogCategories>(entity =>
            {
                entity.ToTable("catalog_categories");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Alias)
                    .HasColumnName("alias")
                    .IsUnicode(false);

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasColumnType("text");

                entity.Property(e => e.Createdby).HasColumnName("createdby");

                entity.Property(e => e.Createdon).HasColumnName("createdon");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.Editedby).HasColumnName("editedby");

                entity.Property(e => e.Editedon).HasColumnName("editedon");

                entity.Property(e => e.IsService).HasColumnName("is_service");

                entity.Property(e => e.Longtitle)
                    .IsRequired()
                    .HasColumnName("longtitle")
                    .IsUnicode(false);

                entity.Property(e => e.Okpd)
                    .HasColumnName("okpd")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Pagetitle)
                    .IsRequired()
                    .HasColumnName("pagetitle")
                    .IsUnicode(false);

                entity.Property(e => e.Parent).HasColumnName("parent");
            });

            modelBuilder.Entity<CatalogCategories1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("catalog_categories", "inventory3");

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasColumnName("alias")
                    .HasMaxLength(255);

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.Createdby).HasColumnName("createdby");

                entity.Property(e => e.Createdon).HasColumnName("createdon");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Editedby).HasColumnName("editedby");

                entity.Property(e => e.Editedon).HasColumnName("editedon");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsService).HasColumnName("is_service");

                entity.Property(e => e.Longtitle)
                    .IsRequired()
                    .HasColumnName("longtitle")
                    .HasMaxLength(255);

                entity.Property(e => e.Okpd)
                    .HasColumnName("okpd")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Pagetitle)
                    .IsRequired()
                    .HasColumnName("pagetitle")
                    .HasMaxLength(255);

                entity.Property(e => e.Parent).HasColumnName("parent");
            });

            modelBuilder.Entity<CatalogDiskfiles>(entity =>
            {
                entity.ToTable("catalog_diskfiles");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Caption)
                    .IsRequired()
                    .HasColumnName("caption")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Createdby).HasColumnName("createdby");

                entity.Property(e => e.Createdon).HasColumnName("createdon");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasColumnName("filename")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FullPath)
                    .IsRequired()
                    .HasColumnName("full_path")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsDefault).HasColumnName("is_default");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.Module)
                    .IsRequired()
                    .HasColumnName("module")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Submodule)
                    .IsRequired()
                    .HasColumnName("submodule")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CatalogDiskfiles1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("catalog_diskfiles", "inventory3");

                entity.Property(e => e.Caption)
                    .IsRequired()
                    .HasColumnName("caption")
                    .HasMaxLength(255);

                entity.Property(e => e.Createdby).HasColumnName("createdby");

                entity.Property(e => e.Createdon).HasColumnName("createdon");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasColumnName("filename")
                    .HasMaxLength(255);

                entity.Property(e => e.FullPath)
                    .IsRequired()
                    .HasColumnName("full_path")
                    .HasMaxLength(255);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsDefault).HasColumnName("is_default");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.Module)
                    .IsRequired()
                    .HasColumnName("module")
                    .HasMaxLength(255);

                entity.Property(e => e.Submodule)
                    .IsRequired()
                    .HasColumnName("submodule")
                    .HasMaxLength(255);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<CatalogGoods>(entity =>
            {
                entity.ToTable("catalog_goods");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasColumnName("alias")
                    .HasMaxLength(255);

                entity.Property(e => e.Carts).HasColumnName("carts");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.Createdby).HasColumnName("createdby");

                entity.Property(e => e.Createdon).HasColumnName("createdon");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.Editedby).HasColumnName("editedby");

                entity.Property(e => e.Editedon).HasColumnName("editedon");

                entity.Property(e => e.IsNative).HasColumnName("is_native");

                entity.Property(e => e.IsService).HasColumnName("is_service");

                entity.Property(e => e.IsSuite).HasColumnName("is_suite");

                entity.Property(e => e.Longtitle)
                    .IsRequired()
                    .HasColumnName("longtitle")
                    .HasMaxLength(255);

                entity.Property(e => e.OnModerate).HasColumnName("on_moderate");

                entity.Property(e => e.Pagetitle)
                    .IsRequired()
                    .HasColumnName("pagetitle")
                    .HasMaxLength(255);

                entity.Property(e => e.Parent).HasColumnName("parent");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("sku")
                    .HasMaxLength(255);

                entity.Property(e => e.SkuM)
                    .IsRequired()
                    .HasColumnName("sku_m")
                    .HasMaxLength(255);

                entity.Property(e => e.SkuP)
                    .IsRequired()
                    .HasColumnName("sku_p")
                    .HasMaxLength(255);

                entity.Property(e => e.SourceLink)
                    .IsRequired()
                    .HasColumnName("source_link");

                entity.Property(e => e.Units).HasColumnName("units");

                entity.Property(e => e.Views).HasColumnName("views");
            });

            modelBuilder.Entity<CatalogGoodsOld>(entity =>
            {
                entity.ToTable("catalog_goods_old");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasColumnName("alias")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Carts).HasColumnName("carts");

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasColumnType("text");

                entity.Property(e => e.Createdby).HasColumnName("createdby");

                entity.Property(e => e.Createdon).HasColumnName("createdon");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Editedby).HasColumnName("editedby");

                entity.Property(e => e.Editedon).HasColumnName("editedon");

                entity.Property(e => e.IsNative).HasColumnName("is_native");

                entity.Property(e => e.IsService).HasColumnName("is_service");

                entity.Property(e => e.IsSuite).HasColumnName("is_suite");

                entity.Property(e => e.Longtitle)
                    .IsRequired()
                    .HasColumnName("longtitle")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OnModerate).HasColumnName("on_moderate");

                entity.Property(e => e.Pagetitle)
                    .IsRequired()
                    .HasColumnName("pagetitle")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Parent).HasColumnName("parent");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("sku")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SkuM)
                    .IsRequired()
                    .HasColumnName("sku_m")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SkuP)
                    .IsRequired()
                    .HasColumnName("sku_p")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SourceLink)
                    .IsRequired()
                    .HasColumnName("source_link")
                    .HasColumnType("text");

                entity.Property(e => e.Units).HasColumnName("units");

                entity.Property(e => e.Views).HasColumnName("views");
            });

            modelBuilder.Entity<CatalogGoodsSuites>(entity =>
            {
                entity.HasKey(e => new { e.GoodId, e.PartId, e.Multiplier });

                entity.ToTable("catalog_goods_suites");

                entity.Property(e => e.GoodId).HasColumnName("good_id");

                entity.Property(e => e.PartId).HasColumnName("part_id");

                entity.Property(e => e.Multiplier).HasColumnName("multiplier");
            });

            modelBuilder.Entity<CatalogTags>(entity =>
            {
                entity.HasKey(e => new { e.ItemId, e.ItemType, e.TagWord, e.Weight, e.Source });

                entity.ToTable("catalog_tags");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .HasColumnName("item_type")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TagWord)
                    .HasColumnName("tag_word")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Source)
                    .HasColumnName("source")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CatalogTags1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("catalog_tags", "inventory3");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasColumnName("item_type")
                    .HasMaxLength(255);

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasColumnName("source")
                    .HasMaxLength(255);

                entity.Property(e => e.TagWord)
                    .IsRequired()
                    .HasColumnName("tag_word")
                    .HasMaxLength(255);

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasColumnType("decimal(5, 2)");
            });

            modelBuilder.Entity<CatalogUnits>(entity =>
            {
                entity.HasKey(e => new { e.Shorttitle, e.Longtitle });

                entity.ToTable("catalog_units");

                entity.Property(e => e.Shorttitle)
                    .HasColumnName("shorttitle")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Longtitle)
                    .HasColumnName("longtitle")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<CatalogUnits1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("catalog_units", "inventory3");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Longtitle)
                    .IsRequired()
                    .HasColumnName("longtitle")
                    .HasMaxLength(255);

                entity.Property(e => e.Shorttitle)
                    .IsRequired()
                    .HasColumnName("shorttitle")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<CategoryUpdate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("category_update");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Okpd)
                    .HasColumnName("okpd")
                    .HasMaxLength(255);

                entity.Property(e => e.Pagetitle).HasColumnName("pagetitle");
            });

            modelBuilder.Entity<ChatProductTypes>(entity =>
            {
                entity.ToTable("ChatProduct_Types");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Chats>(entity =>
            {
                entity.HasIndex(e => e.ProductType)
                    .HasName("IX_FK_Chats_ChatProduct_Types");

                entity.HasIndex(e => e.Type)
                    .HasName("IX_FK_Chats_Chats_Types");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.ProductType).HasColumnName("product_type");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.HasOne(d => d.ProductTypeNavigation)
                    .WithMany(p => p.Chats)
                    .HasForeignKey(d => d.ProductType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Chats_ChatProduct_Types");

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.Chats)
                    .HasForeignKey(d => d.Type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Chats_Chats_Types");
            });

            modelBuilder.Entity<ChatsTypes>(entity =>
            {
                entity.ToTable("Chats_Types");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CommentClientToRecord>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CallId).IsRequired();
            });

            modelBuilder.Entity<CommentClientToRecords>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CallId).IsRequired();
            });

            modelBuilder.Entity<DiaryPosts>(entity =>
            {
                entity.ToTable("Diary_Posts");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccauntsId).HasColumnName("accauntsId");

                entity.Property(e => e.DateCreate)
                    .HasColumnName("dateCreate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fiile).HasColumnName("fiile");

                entity.Property(e => e.Text).HasColumnName("text");

                entity.Property(e => e.UserId)
                    .HasColumnName("userId")
                    .HasMaxLength(128);

                entity.HasOne(d => d.Accaunts)
                    .WithMany(p => p.DiaryPosts)
                    .HasForeignKey(d => d.AccauntsId)
                    .HasConstraintName("FK_Diary_Posts_Accounts");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DiaryPosts)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Diary_Posts_AspNetUsers");
            });

            modelBuilder.Entity<DocumentsTemplates>(entity =>
            {
                entity.ToTable("Documents_Templates");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountRoleId).HasColumnName("account_role_id");

                entity.Property(e => e.Bytestream).HasColumnName("bytestream");

                entity.Property(e => e.CurrentVersion).HasColumnName("current_version");

                entity.Property(e => e.NameTemplate)
                    .HasColumnName("name_template")
                    .HasMaxLength(50);

                entity.Property(e => e.TypeTemplateId).HasColumnName("type_template_id");

                entity.HasOne(d => d.AccountRole)
                    .WithMany(p => p.DocumentsTemplates)
                    .HasForeignKey(d => d.AccountRoleId)
                    .HasConstraintName("FK_Documents_Templates_Accounts_RolesHB");

                entity.HasOne(d => d.TypeTemplate)
                    .WithMany(p => p.DocumentsTemplates)
                    .HasForeignKey(d => d.TypeTemplateId)
                    .HasConstraintName("FK_Documents_Templates_Documents_TypesHB");
            });

            modelBuilder.Entity<DocumentsTypesHb>(entity =>
            {
                entity.ToTable("Documents_TypesHB");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.NameType)
                    .HasColumnName("name_type")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<EmailStatusLog>(entity =>
            {
                entity.ToTable("Email_StatusLog");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(255);

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnName("event")
                    .HasMaxLength(255);

                entity.Property(e => e.MessageId)
                    .IsRequired()
                    .HasColumnName("message_id")
                    .HasMaxLength(255);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<ErrorC100txFindCategory>(entity =>
            {
                entity.ToTable("ErrorC100tx_FindCategory");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("IX_FK_100tx_FindCategory_catalog_categories");

                entity.HasIndex(e => e.SpecId)
                    .HasName("IX_FK_100tx_FindCategory_aleks_daspecs_maintbl");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.IsChecked).HasColumnName("is_checked");

                entity.Property(e => e.LineId).HasColumnName("line_id");

                entity.Property(e => e.SpecId).HasColumnName("spec_id");
            });

            modelBuilder.Entity<ErrorC100txGoodLoaderProviderUrls>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ErrorC100tx_GoodLoader_ProviderUrls");

                entity.Property(e => e.LoadType).HasColumnName("loadType");

                entity.Property(e => e.ProviderId).HasColumnName("provider_id");

                entity.Property(e => e.UrlList)
                    .IsRequired()
                    .HasColumnName("url_list")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ErrorC100txOrders>(entity =>
            {
                entity.ToTable("ErrorC100tx_Orders");

                entity.HasIndex(e => e.Account)
                    .HasName("IX_FK_100tx_Orders_Accounts");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Account).HasColumnName("account");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CreatorAccount).HasColumnName("creatorAccount");

                entity.Property(e => e.Dateadd)
                    .HasColumnName("dateadd")
                    .HasColumnType("datetime");

                entity.Property(e => e.Markup).HasColumnName("markup");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.PlanPurchase)
                    .HasColumnName("plan_purchase")
                    .HasMaxLength(50);

                entity.Property(e => e.Specification).HasColumnName("specification");

                entity.Property(e => e.Stage).HasColumnName("stage");

                entity.Property(e => e.Sum).HasColumnName("sum");

                entity.Property(e => e.TermStage)
                    .HasColumnName("term_stage")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.AccountNavigation)
                    .WithMany(p => p.ErrorC100txOrders)
                    .HasForeignKey(d => d.Account)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_C100tx_Orders_Accounts");
            });

            modelBuilder.Entity<ErrorC100txPlanPositions>(entity =>
            {
                entity.ToTable("ErrorC100tx_PlanPositions");

                entity.HasIndex(e => e.Plan)
                    .HasName("IX_FK_100tx_PlanPositions_100tx_plans");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Characteristic).HasColumnName("characteristic");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.CostAverage).HasColumnName("costAverage");

                entity.Property(e => e.CostStart).HasColumnName("costStart");

                entity.Property(e => e.File)
                    .HasColumnName("file")
                    .HasMaxLength(50);

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.Plan).HasColumnName("plan");

                entity.Property(e => e.Revision)
                    .HasColumnName("revision")
                    .HasMaxLength(50);

                entity.Property(e => e.Summ1).HasColumnName("summ1");

                entity.Property(e => e.Summ2).HasColumnName("summ2");

                entity.Property(e => e.SummAll).HasColumnName("summAll");

                entity.Property(e => e.SummCurrent).HasColumnName("summCurrent");

                entity.Property(e => e.SummLast).HasColumnName("summLast");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50);

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasMaxLength(50);

                entity.Property(e => e.Volume1).HasColumnName("volume1");

                entity.Property(e => e.Volume2).HasColumnName("volume2");

                entity.Property(e => e.VolumeAll).HasColumnName("volumeAll");

                entity.Property(e => e.VolumeCurrent).HasColumnName("volumeCurrent");

                entity.Property(e => e.VolumeIs).HasColumnName("volumeIs");

                entity.Property(e => e.VolumeLast).HasColumnName("volumeLast");
            });

            modelBuilder.Entity<ErrorC100txPlans>(entity =>
            {
                entity.ToTable("ErrorC100tx_plans");

                entity.HasIndex(e => e.Account)
                    .HasName("IX_FK_100tx_plans_Accounts");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Account).HasColumnName("account");

                entity.Property(e => e.DateApproval)
                    .HasColumnName("date_approval")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DateApprovalRationale)
                    .HasColumnName("date_approval_rationale")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DatePublic)
                    .HasColumnName("date_public")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DateSheduleChange)
                    .HasColumnName("date_shedule_change")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Dateadd)
                    .HasColumnName("dateadd")
                    .HasColumnType("datetime");

                entity.Property(e => e.PlanPurchase)
                    .HasColumnName("plan_purchase")
                    .HasMaxLength(50);

                entity.Property(e => e.PlanShedule)
                    .HasColumnName("plan_shedule")
                    .HasMaxLength(50);

                entity.Property(e => e.Region).HasColumnName("region");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50);

                entity.Property(e => e.YearShedule)
                    .HasColumnName("year_shedule")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ErrorC100txRegions>(entity =>
            {
                entity.ToTable("ErrorC100tx_Regions");

                entity.HasIndex(e => e.HeaderId)
                    .HasName("IX_FK_100tx_Regions_100tx_RegionsHeaders");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.HeaderId).HasColumnName("headerId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.OktmoCode)
                    .IsRequired()
                    .HasColumnName("oktmoCode")
                    .HasMaxLength(50);

                entity.Property(e => e.OktmoId)
                    .IsRequired()
                    .HasColumnName("oktmoId")
                    .HasMaxLength(50);

                entity.Property(e => e.Priority).HasColumnName("priority");
            });

            modelBuilder.Entity<ErrorC100txRegionsHeaders>(entity =>
            {
                entity.ToTable("ErrorC100tx_RegionsHeaders");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.OktmoCode)
                    .IsRequired()
                    .HasColumnName("oktmoCode")
                    .HasMaxLength(50);

                entity.Property(e => e.OktmoId)
                    .IsRequired()
                    .HasColumnName("oktmoId")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ErrorC100txTasksStatusesHb>(entity =>
            {
                entity.ToTable("ErrorC100tx_TasksStatusesHB");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<ErrorC100txZakupkiTasks>(entity =>
            {
                entity.ToTable("ErrorC100tx_ZakupkiTasks");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_FK_100tx_ZakupkiTasks_100tx_TasksStatusesHB");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasColumnName("region")
                    .HasMaxLength(255);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TaskId)
                    .IsRequired()
                    .HasColumnName("task_id")
                    .HasMaxLength(50);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url");
            });

            modelBuilder.Entity<FeedbackRequests>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Company).HasMaxLength(256);

                entity.Property(e => e.DateRequest)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.IsSent).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.Phone).HasMaxLength(32);
            });

            modelBuilder.Entity<Files>(entity =>
            {
                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Filedata)
                    .IsRequired()
                    .HasColumnName("filedata");

                entity.Property(e => e.Filename).HasColumnName("filename");

                entity.Property(e => e.Idtable).HasColumnName("idtable");

                entity.Property(e => e.Typetable).HasColumnName("typetable");

                entity.Property(e => e.UserId)
                    .HasColumnName("userId")
                    .HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Files)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Files_AspNetUsers");
            });

            modelBuilder.Entity<Functions>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.OfficeId).HasColumnName("officeId");
            });

            modelBuilder.Entity<HelpCategories>(entity =>
            {
                entity.HasKey(e => e.IdCategories)
                    .HasName("PK_dbo.Help_Categories");

                entity.ToTable("Help_Categories");

                entity.Property(e => e.IdCategories).HasColumnName("ID_Categories");

                entity.Property(e => e.ParentCategory).HasColumnName("Parent_category");

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            modelBuilder.Entity<HelpComments>(entity =>
            {
                entity.HasKey(e => e.IdComments)
                    .HasName("PK_dbo.Help_Comments");

                entity.ToTable("Help_Comments");

                entity.Property(e => e.IdComments).HasColumnName("ID_Comments");

                entity.Property(e => e.IdContent).HasColumnName("ID_Content");

                entity.Property(e => e.IdUser).HasColumnName("ID_User");

                entity.HasOne(d => d.IdContentNavigation)
                    .WithMany(p => p.HelpComments)
                    .HasForeignKey(d => d.IdContent)
                    .HasConstraintName("FK_Help_Comments_Help_Content");
            });

            modelBuilder.Entity<HelpContent>(entity =>
            {
                entity.HasKey(e => e.IdContent);

                entity.ToTable("Help_Content");

                entity.Property(e => e.IdContent).HasColumnName("ID_Content");

                entity.Property(e => e.Header).HasMaxLength(50);

                entity.Property(e => e.IdCategories).HasColumnName("ID_Categories");

                entity.Property(e => e.LinkToHelp)
                    .HasColumnName("Link_To_Help")
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCategoriesNavigation)
                    .WithMany(p => p.HelpContent)
                    .HasForeignKey(d => d.IdCategories)
                    .HasConstraintName("FK_Help_Content_Help_Categories");
            });

            modelBuilder.Entity<HelpRoles>(entity =>
            {
                entity.ToTable("Help_Roles");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(128)
                    .HasDefaultValueSql("(CONVERT([nvarchar](128),newid(),(0)))");

                entity.Property(e => e.AccountsRoleId).HasColumnName("Accounts_RoleId");

                entity.Property(e => e.IdCategories).HasColumnName("Id_categories");

                entity.Property(e => e.IdContent).HasColumnName("Id_content");

                entity.Property(e => e.RoleId).HasMaxLength(128);

                entity.HasOne(d => d.AccountsRole)
                    .WithMany(p => p.HelpRoles)
                    .HasForeignKey(d => d.AccountsRoleId)
                    .HasConstraintName("FK_Help_Roles_Accounts_RolesHB");

                entity.HasOne(d => d.IdCategoriesNavigation)
                    .WithMany(p => p.HelpRoles)
                    .HasForeignKey(d => d.IdCategories)
                    .HasConstraintName("FK_Help_Roles_Help_Categories");

                entity.HasOne(d => d.IdContentNavigation)
                    .WithMany(p => p.HelpRoles)
                    .HasForeignKey(d => d.IdContent)
                    .HasConstraintName("FK_Help_Roles_Help_Content");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.HelpRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_Help_Roles_AspNetRoles");
            });

            modelBuilder.Entity<Layouts>(entity =>
            {
                entity.Property(e => e.Colums).HasColumnName("colums");

                entity.Property(e => e.Ordering).HasColumnName("ordering");

                entity.Property(e => e.TableId).HasColumnName("tableId");
            });

            modelBuilder.Entity<LogAction>(entity =>
            {
                entity.ToTable("Log_Action");
            });

            modelBuilder.Entity<LogPattern>(entity =>
            {
                entity.ToTable("Log_Pattern");

                entity.Property(e => e.Actionid).HasColumnName("actionid");

                entity.Property(e => e.Idtable).HasColumnName("idtable");

                entity.Property(e => e.Notification).HasColumnName("notification");

                entity.Property(e => e.Text).HasColumnName("text");

                entity.Property(e => e.Typetable).HasColumnName("typetable");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(128);

                entity.Property(e => e.Verification).HasColumnName("verification");

                entity.HasOne(d => d.Action)
                    .WithMany(p => p.LogPattern)
                    .HasForeignKey(d => d.Actionid)
                    .HasConstraintName("FK_Log_Pattern_Log_Action");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.LogPattern)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("FK_Log_Pattern_AspNetUsers");
            });

            modelBuilder.Entity<LogPatternToUsers>(entity =>
            {
                entity.ToTable("Log_Pattern_To_Users");

                entity.Property(e => e.IdUserEntity).HasColumnName("idUserEntity");

                entity.Property(e => e.PaternId).HasColumnName("paternId");

                entity.Property(e => e.UserId)
                    .HasColumnName("userId")
                    .HasMaxLength(128);

                entity.HasOne(d => d.IdUserEntityNavigation)
                    .WithMany(p => p.LogPatternToUsers)
                    .HasForeignKey(d => d.IdUserEntity)
                    .HasConstraintName("FK_Log_Pattern_To_Users_Log_Pattern_User_Entiity");

                entity.HasOne(d => d.Patern)
                    .WithMany(p => p.LogPatternToUsers)
                    .HasForeignKey(d => d.PaternId)
                    .HasConstraintName("FK_Log_Pattern_To_Users_Log_Pattern");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.LogPatternToUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Log_Pattern_To_Users_AspNetUsers");
            });

            modelBuilder.Entity<LogPatternUserEntiity>(entity =>
            {
                entity.ToTable("Log_Pattern_User_Entiity");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.NameFild).HasColumnName("nameFild");

                entity.Property(e => e.Tupetable).HasColumnName("tupetable");
            });

            modelBuilder.Entity<LogPropertySaveTable>(entity =>
            {
                entity.ToTable("Log_PropertySaveTable");

                entity.Property(e => e.IdTypeTable).HasColumnName("idTypeTable");

                entity.Property(e => e.Name).HasColumnName("name");
            });

            modelBuilder.Entity<Logs>(entity =>
            {
                entity.HasIndex(e => e.AccountId)
                    .HasName("IX_FK_Logs_Accounts");

                entity.HasIndex(e => e.LogType)
                    .HasName("IX_FK_Logs_Logs_Types");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_FK_Logs_AspNetUsers");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountId).HasColumnName("accountId");

                entity.Property(e => e.ActionId).HasColumnName("actionId");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datetime)
                    .HasColumnName("datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Idtable).HasColumnName("idtable");

                entity.Property(e => e.Json).HasColumnName("json");

                entity.Property(e => e.LogType).HasColumnName("logType");

                entity.Property(e => e.Typetable).HasColumnName("typetable");

                entity.Property(e => e.UserId)
                    .HasColumnName("userId")
                    .HasMaxLength(128);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Logs)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Logs_Accounts");

                entity.HasOne(d => d.Action)
                    .WithMany(p => p.Logs)
                    .HasForeignKey(d => d.ActionId)
                    .HasConstraintName("FK_Logs_Log_Action");

                entity.HasOne(d => d.LogTypeNavigation)
                    .WithMany(p => p.Logs)
                    .HasForeignKey(d => d.LogType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Logs_Logs_Types");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Logs)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Logs_AspNetUsers");
            });

            modelBuilder.Entity<LogsMessages>(entity =>
            {
                entity.ToTable("Logs_Messages");

                entity.HasIndex(e => e.LogId)
                    .HasName("IX_FK_Logs_Messages_Logs");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.LogId).HasColumnName("logId");

                entity.Property(e => e.MessageId)
                    .IsRequired()
                    .HasColumnName("messageId")
                    .HasMaxLength(50);

                entity.Property(e => e.MessagesCount).HasColumnName("messagesCount");

                entity.HasOne(d => d.Log)
                    .WithMany(p => p.LogsMessages)
                    .HasForeignKey(d => d.LogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Logs_Messages_Logs");
            });

            modelBuilder.Entity<LogsTypes>(entity =>
            {
                entity.ToTable("Logs_Types");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Action)
                    .HasColumnName("action")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Text)
                    .HasColumnName("text")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<MapRegion>(entity =>
            {
                entity.ToTable("map_region");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.City)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Company).HasColumnName("company");

                entity.Property(e => e.Region)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MenuList>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.MenuList)
                    .HasForeignKey(d => d.Type)
                    .HasConstraintName("FK_MenuList_MenuType");
            });

            modelBuilder.Entity<MenuType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MessageFile>(entity =>
            {
                entity.ToTable("Message_File");

                entity.Property(e => e.FileId)
                    .HasColumnName("fileId")
                    .HasMaxLength(128);

                entity.Property(e => e.MessageId).HasColumnName("messageId");

                entity.HasOne(d => d.File)
                    .WithMany(p => p.MessageFile)
                    .HasForeignKey(d => d.FileId)
                    .HasConstraintName("FK_Message_File_Files");

                entity.HasOne(d => d.Message)
                    .WithMany(p => p.MessageFile)
                    .HasForeignKey(d => d.MessageId)
                    .HasConstraintName("FK_Message_File_Messages");
            });

            modelBuilder.Entity<MessageToUsers>(entity =>
            {
                entity.ToTable("Message_To_Users");

                entity.Property(e => e.MessageId).HasColumnName("messageId");

                entity.Property(e => e.See)
                    .HasColumnName("see")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasColumnName("userId")
                    .HasMaxLength(128);

                entity.Property(e => e.Verification)
                    .HasColumnName("verification")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Message)
                    .WithMany(p => p.MessageToUsers)
                    .HasForeignKey(d => d.MessageId)
                    .HasConstraintName("FK_Message_To_Users_Messages");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.MessageToUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Message_To_Users_AspNetUsers");
            });

            modelBuilder.Entity<Messages>(entity =>
            {
                entity.HasIndex(e => e.ChatId)
                    .HasName("IX_FK_Messages_Chats");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_FK_Messages_AspNetUsers");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ChatId).HasColumnName("chat_id");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Idtable).HasColumnName("idtable");

                entity.Property(e => e.Parametr).HasColumnName("parametr");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text");

                entity.Property(e => e.Typetable).HasColumnName("typetable");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("user_id")
                    .HasMaxLength(128);

                entity.HasOne(d => d.Chat)
                    .WithMany(p => p.Messages)
                    .HasForeignKey(d => d.ChatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Messages_Chats");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Messages)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Messages_AspNetUsers");
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.HasIndex(e => e.AccountId)
                    .HasName("IX_FK_News_Accounts");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_FK_News_AspNetUsers");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountId).HasColumnName("accountId");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SpecId).HasColumnName("spec_id");

                entity.Property(e => e.UserId)
                    .HasColumnName("userId")
                    .HasMaxLength(128);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.News)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_News_Accounts");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.News)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_News_AspNetUsers");
            });

            modelBuilder.Entity<Offices>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Okpd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("'okpd$'");

                entity.Property(e => e.Наименование).HasColumnName("наименование");

                entity.Property(e => e.Окпд)
                    .HasColumnName("окпд")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Okpd2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("'okpd2$'");

                entity.Property(e => e.Наименование).HasColumnName("наименование");

                entity.Property(e => e.Окпд)
                    .HasColumnName("окпд")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Parse>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AgencyId)
                    .HasColumnName("Agency_id")
                    .HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Law)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.PlanInfoId)
                    .HasColumnName("PlanInfo_id")
                    .HasMaxLength(50);

                entity.Property(e => e.PlanNumber).HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasMaxLength(15)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Payments>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.AccountId).HasColumnName("accountId");

                entity.Property(e => e.Balance)
                    .HasColumnName("balance")
                    .HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.OperationType).HasColumnName("operationType");

                entity.Property(e => e.Sum)
                    .HasColumnName("sum")
                    .HasColumnType("numeric(18, 4)");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Payments_Accounts");
            });

            modelBuilder.Entity<PaymentsIncommingParams>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Payments_Incomming_Params");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PaymentsOutgoingParams>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Payments_Outgoing_Params");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PaymentsTypesHb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Payments_TypesHB");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PriceTypesHb>(entity =>
            {
                entity.ToTable("Price_TypesHB");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PrjPhoneNumbers>(entity =>
            {
                entity.HasIndex(e => e.ProjectsId)
                    .HasName("IX_fk_PrjPhoneNum_to_Projects");

                entity.HasIndex(e => e.SettingsDataId)
                    .HasName("IX_fk_PrjPhoneNum_to_PrjSetData");

                entity.HasIndex(e => e.TelecomOperatorId)
                    .HasName("IX_fk_PrjPhoneNum_to_PrjTelOper");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DomainName).HasColumnName("domain_name");

                entity.Property(e => e.InLineCount).HasColumnName("in_line_count");

                entity.Property(e => e.IpAddress).HasColumnName("ip_address");

                entity.Property(e => e.LineCount).HasColumnName("line_count");

                entity.Property(e => e.Login).HasColumnName("login");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.OutLineCount).HasColumnName("out_line_count");

                entity.Property(e => e.Password).HasColumnName("password");

                entity.Property(e => e.PhoneNumber).HasColumnName("phone_number");

                entity.Property(e => e.PhoneType).HasColumnName("phone_type");

                entity.Property(e => e.ProjectsId).HasColumnName("projects_id");

                entity.Property(e => e.SettingsDataId).HasColumnName("settings_data_id");

                entity.Property(e => e.TelecomOperatorId).HasColumnName("telecom_operator_id");

                entity.HasOne(d => d.Projects)
                    .WithMany(p => p.PrjPhoneNumbers)
                    .HasForeignKey(d => d.ProjectsId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_PrjPhoneNum_to_Projects");

                entity.HasOne(d => d.SettingsData)
                    .WithMany(p => p.PrjPhoneNumbers)
                    .HasForeignKey(d => d.SettingsDataId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_PrjPhoneNum_to_PrjSetData");

                entity.HasOne(d => d.TelecomOperator)
                    .WithMany(p => p.PrjPhoneNumbers)
                    .HasForeignKey(d => d.TelecomOperatorId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_PrjPhoneNum_to_PrjTelOper");
            });

            modelBuilder.Entity<PrjPreferences>(entity =>
            {
                entity.HasIndex(e => e.ParentId)
                    .HasName("IX_fk_PrjPref_to_PrjPref");

                entity.HasIndex(e => e.PositionId)
                    .HasName("IX_fk_PrjPref_to_PrjSetPosition");

                entity.HasIndex(e => e.SettingId)
                    .HasName("IX_fk_PrjPref_to_PrjSett");

                entity.HasIndex(e => e.TypedataId)
                    .HasName("IX_fk_PrjPref_to_PrjSetTypeData");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DisplayOrder).HasColumnName("display_order");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.PositionId).HasColumnName("position_id");

                entity.Property(e => e.SettingId).HasColumnName("setting_id");

                entity.Property(e => e.TypedataId).HasColumnName("typedata_id");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("fk_PrjPref_to_PrjPref");

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.PrjPreferences)
                    .HasForeignKey(d => d.PositionId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_PrjPref_to_PrjSetPosition");

                entity.HasOne(d => d.Setting)
                    .WithMany(p => p.PrjPreferences)
                    .HasForeignKey(d => d.SettingId)
                    .HasConstraintName("fk_PrjPref_to_PrjSett");

                entity.HasOne(d => d.Typedata)
                    .WithMany(p => p.PrjPreferences)
                    .HasForeignKey(d => d.TypedataId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_PrjPref_to_PrjSetTypeData");
            });

            modelBuilder.Entity<PrjSetPosition>(entity =>
            {
                entity.ToTable("PrjSet_Position");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");
            });

            modelBuilder.Entity<PrjSetTypeData>(entity =>
            {
                entity.ToTable("PrjSet_TypeData");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");
            });

            modelBuilder.Entity<PrjSettings>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DisplayOrder).HasColumnName("display_order");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");
            });

            modelBuilder.Entity<PrjSettingsData>(entity =>
            {
                entity.ToTable("PrjSettings_Data");

                entity.HasIndex(e => e.PreferencesId)
                    .HasName("IX_fk_PrjSetData_to_PrjPref");

                entity.HasIndex(e => e.ProjectsId)
                    .HasName("IX_fk_PrjSetData_to_Projects");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PreferencesId).HasColumnName("preferences_id");

                entity.Property(e => e.ProjectsId).HasColumnName("projects_id");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.HasOne(d => d.Preferences)
                    .WithMany(p => p.PrjSettingsData)
                    .HasForeignKey(d => d.PreferencesId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_PrjSetData_to_PrjPref");

                entity.HasOne(d => d.Projects)
                    .WithMany(p => p.PrjSettingsData)
                    .HasForeignKey(d => d.ProjectsId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_PrjSetData_to_Projects");
            });

            modelBuilder.Entity<PrjTelecomOperators>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name).HasColumnName("name");
            });

            modelBuilder.Entity<ProjectSettings>(entity =>
            {
                entity.ToTable("Project_Settings");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.Settings)
                    .IsRequired()
                    .HasColumnName("settings");
            });

            modelBuilder.Entity<ProjectStatuses>(entity =>
            {
                entity.ToTable("Project_Statuses");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasColumnName("color")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(250);

                entity.Property(e => e.Position).HasColumnName("position");
            });

            modelBuilder.Entity<ProjectTypeSetting>(entity =>
            {
                entity.ToTable("Project_Type_Setting");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Settingid).HasColumnName("settingid");

                entity.Property(e => e.Typeid).HasColumnName("typeid");

                entity.HasOne(d => d.Setting)
                    .WithMany(p => p.ProjectTypeSetting)
                    .HasForeignKey(d => d.Settingid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Project_Type_Setting_Project_Settings");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.ProjectTypeSetting)
                    .HasForeignKey(d => d.Typeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Project_Type_Setting_Project_Types");
            });

            modelBuilder.Entity<ProjectTypes>(entity =>
            {
                entity.ToTable("Project_Types");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(CONVERT([nvarchar](128),newid(),(0)))");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("userid")
                    .HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ProjectTypes)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Project_Types_AspNetUsers");
            });

            modelBuilder.Entity<ProjectTypes1>(entity =>
            {
                entity.ToTable("ProjectTypes");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<ProjectTypesUser>(entity =>
            {
                entity.ToTable("Project_Types_User");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Projectid).HasColumnName("projectid");

                entity.Property(e => e.Typeid).HasColumnName("typeid");

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasColumnName("userid")
                    .HasMaxLength(128);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectTypesUser)
                    .HasForeignKey(d => d.Projectid)
                    .HasConstraintName("FK_Project_Types_User_Projects");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.ProjectTypesUser)
                    .HasForeignKey(d => d.Typeid)
                    .HasConstraintName("FK_Project_Types_User_Project_Types");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ProjectTypesUser)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Project_Types_User_AspNetUsers");
            });

            modelBuilder.Entity<Projects>(entity =>
            {
                entity.HasIndex(e => e.AccountId)
                    .HasName("IX_FK_Projects_Accounts");

                entity.HasIndex(e => e.TypeId)
                    .HasName("IX_FK_Projects_ProjectTypes");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountId).HasColumnName("accountId");

                entity.Property(e => e.CreatorId)
                    .HasColumnName("creatorId")
                    .HasMaxLength(128);

                entity.Property(e => e.DateCreate)
                    .HasColumnName("date_create")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateLastEdit)
                    .HasColumnName("date_last_edit")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.EndDate)
                    .HasColumnName("endDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.IsExternal).HasColumnName("isExternal");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.OktellCode)
                    .HasColumnName("oktellCode")
                    .HasMaxLength(50);

                entity.Property(e => e.OwnerId)
                    .HasColumnName("ownerId")
                    .HasMaxLength(128);

                entity.Property(e => e.StartDate)
                    .HasColumnName("startDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.StatusesId).HasColumnName("statusesId");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Projects_Accounts");

                entity.HasOne(d => d.Creator)
                    .WithMany(p => p.ProjectsCreator)
                    .HasForeignKey(d => d.CreatorId)
                    .HasConstraintName("FK_Projects_AspNetUsers1");

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.ProjectsOwner)
                    .HasForeignKey(d => d.OwnerId)
                    .HasConstraintName("FK_Projects_AspNetUsers");

                entity.HasOne(d => d.Statuses)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.StatusesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Projects_Project_Statuses");

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.Type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Projects_Project_Types");

                entity.HasOne(d => d.Type1)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_Projects_ProjectTypes");
            });

            modelBuilder.Entity<ProjectsServices>(entity =>
            {
                entity.ToTable("Projects_Services");

                entity.HasIndex(e => e.ProjectId)
                    .HasName("IX_FK_Projects_Services_Projects");

                entity.HasIndex(e => e.ServiceId)
                    .HasName("IX_FK_Projects_Services_Services");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ProjectId).HasColumnName("projectId");

                entity.Property(e => e.ServiceId).HasColumnName("serviceId");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectsServices)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_Projects_Services_Projects");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.ProjectsServices)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Projects_Services_Services");
            });

            modelBuilder.Entity<ProjectsUsers>(entity =>
            {
                entity.ToTable("Projects_Users");

                entity.HasIndex(e => e.IdProject)
                    .HasName("IX_FK_Projects_Users_Projects");

                entity.HasIndex(e => e.IdUser)
                    .HasName("IX_FK_Projects_Users_AspNetUsers");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdProject).HasColumnName("idProject");

                entity.Property(e => e.IdUser)
                    .IsRequired()
                    .HasColumnName("idUser")
                    .HasMaxLength(128);

                entity.HasOne(d => d.IdProjectNavigation)
                    .WithMany(p => p.ProjectsUsers)
                    .HasForeignKey(d => d.IdProject)
                    .HasConstraintName("FK_Projects_Users_Projects");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.ProjectsUsers)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Projects_Users_AspNetUsers");
            });

            modelBuilder.Entity<RecognitionSpecTable>(entity =>
            {
                entity.ToTable("RecognitionSpec_Table");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<RecordOfTelegramsBott>(entity =>
            {
                entity.ToTable("Record_of_telegrams_bott");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateCreate)
                    .HasColumnName("dateCreate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fiile)
                    .IsRequired()
                    .HasColumnName("fiile");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text");
            });

            modelBuilder.Entity<Request>(entity =>
            {
                entity.HasIndex(e => e.TypeId)
                    .HasName("IX_FK_Request_Request_Types_HB");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_FK_Request_AspNetUsers");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountId).HasColumnName("accountId");

                entity.Property(e => e.Body)
                    .IsRequired()
                    .HasColumnName("body")
                    .HasMaxLength(1000);

                entity.Property(e => e.Header)
                    .IsRequired()
                    .HasColumnName("header")
                    .HasMaxLength(50);

                entity.Property(e => e.TypeId).HasColumnName("typeId");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("userId")
                    .HasMaxLength(128);

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Request)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Request_Request_Types_HB");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Request)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Request_AspNetUsers");
            });

            modelBuilder.Entity<RequestTypesHb>(entity =>
            {
                entity.ToTable("Request_Types_HB");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Services>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ServicesData>(entity =>
            {
                entity.ToTable("Services_Data");

                entity.HasIndex(e => e.PreferenceId)
                    .HasName("IX_FK_Services_Data_Services_Preferences_HB");

                entity.HasIndex(e => e.ProjectServiceId)
                    .HasName("IX_FK_Services_Data_Projects_Services");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PreferenceId).HasColumnName("preferenceId");

                entity.Property(e => e.PreferenceValue).HasColumnName("preferenceValue");

                entity.Property(e => e.ProjectServiceId).HasColumnName("project_serviceId");

                entity.HasOne(d => d.Preference)
                    .WithMany(p => p.ServicesData)
                    .HasForeignKey(d => d.PreferenceId)
                    .HasConstraintName("FK_Services_Data_Services_Preferences_HB");

                entity.HasOne(d => d.ProjectService)
                    .WithMany(p => p.ServicesData)
                    .HasForeignKey(d => d.ProjectServiceId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Services_Data_Projects_Services");
            });

            modelBuilder.Entity<ServicesPreferences>(entity =>
            {
                entity.ToTable("Services_Preferences");

                entity.HasIndex(e => e.PreferenceId)
                    .HasName("IX_FK_Services_Preferences_Services_Preferences_HB");

                entity.HasIndex(e => e.Serviceid)
                    .HasName("IX_FK_Services_Preferences_Services");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PreferenceId).HasColumnName("preferenceId");

                entity.Property(e => e.Serviceid).HasColumnName("serviceid");

                entity.HasOne(d => d.Preference)
                    .WithMany(p => p.ServicesPreferences)
                    .HasForeignKey(d => d.PreferenceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Services_Preferences_Services_Preferences_HB");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.ServicesPreferences)
                    .HasForeignKey(d => d.Serviceid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Services_Preferences_Services");
            });

            modelBuilder.Entity<ServicesPreferencesHb>(entity =>
            {
                entity.ToTable("Services_Preferences_HB");

                entity.HasIndex(e => e.TypeId)
                    .HasName("IX_FK_Services_Preferences_HB_Services_Preferences_Types");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.ReadOnly).HasColumnName("readOnly");

                entity.Property(e => e.TypeId).HasColumnName("typeId");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.ServicesPreferencesHb)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Services_Preferences_HB_Services_Preferences_Types");
            });

            modelBuilder.Entity<ServicesPreferencesTypes>(entity =>
            {
                entity.ToTable("Services_Preferences_Types");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ServicesPrices>(entity =>
            {
                entity.ToTable("Services_Prices");

                entity.HasIndex(e => e.PreferenceId)
                    .HasName("IX_FK_Services_Prices_Services_Preferences_HB");

                entity.HasIndex(e => e.PriceTypesId)
                    .HasName("IX_FK_Services_Prices_Price_TypesHB");

                entity.HasIndex(e => e.ServiceId)
                    .HasName("IX_FK_Services_Prices_Services");

                entity.HasIndex(e => e.TarifId)
                    .HasName("IX_FK_Services_Prices_Tarifs");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateCreate)
                    .HasColumnName("date_create")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateStart)
                    .HasColumnName("date_start")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateStop)
                    .HasColumnName("date_stop")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.PreferenceId).HasColumnName("preferenceId");

                entity.Property(e => e.PriceTypesId).HasColumnName("priceTypesId");

                entity.Property(e => e.ServiceId).HasColumnName("serviceId");

                entity.Property(e => e.TarifId).HasColumnName("tarifId");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.HasOne(d => d.Preference)
                    .WithMany(p => p.ServicesPrices)
                    .HasForeignKey(d => d.PreferenceId)
                    .HasConstraintName("FK_Services_Prices_Services_Preferences_HB");

                entity.HasOne(d => d.PriceTypes)
                    .WithMany(p => p.ServicesPrices)
                    .HasForeignKey(d => d.PriceTypesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Services_Prices_Price_TypesHB");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.ServicesPrices)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Services_Prices_Services");

                entity.HasOne(d => d.Tarif)
                    .WithMany(p => p.ServicesPrices)
                    .HasForeignKey(d => d.TarifId)
                    .HasConstraintName("FK_Services_Prices_Tarifs");
            });

            modelBuilder.Entity<Sheet1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sheet1$");

                entity.Property(e => e.EMail)
                    .HasColumnName("e-mail")
                    .HasMaxLength(255);

                entity.Property(e => e.Адрес).HasMaxLength(255);

                entity.Property(e => e.ГлБухгалтер)
                    .HasColumnName("Гл#Бухгалтер")
                    .HasMaxLength(255);

                entity.Property(e => e.Директор).HasMaxLength(255);

                entity.Property(e => e.Инн)
                    .HasColumnName("ИНН")
                    .HasMaxLength(255);

                entity.Property(e => e.Магазин).HasMaxLength(255);

                entity.Property(e => e.Наименование).HasMaxLength(255);

                entity.Property(e => e.СправочникКлиенты).HasColumnName("Справочник \"Клиенты\"");

                entity.Property(e => e.Телефон).HasMaxLength(255);

                entity.Property(e => e.ФактАдрес).HasMaxLength(255);
            });

            modelBuilder.Entity<Signatory>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Document).HasMaxLength(128);

                entity.Property(e => e.Email).HasMaxLength(128);

                entity.Property(e => e.Fio).HasMaxLength(128);

                entity.Property(e => e.FioDat).HasMaxLength(128);

                entity.Property(e => e.FioRod).HasMaxLength(128);

                entity.Property(e => e.Phone).HasMaxLength(128);

                entity.Property(e => e.Post).HasMaxLength(128);
            });

            modelBuilder.Entity<Statistic>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Callid)
                    .IsRequired()
                    .HasColumnName("callid")
                    .HasMaxLength(50);

                entity.Property(e => e.Datetime)
                    .IsRequired()
                    .HasColumnName("datetime")
                    .HasMaxLength(50);

                entity.Property(e => e.Direction)
                    .IsRequired()
                    .HasColumnName("direction")
                    .HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnName("phone")
                    .HasMaxLength(50);

                entity.Property(e => e.Project)
                    .IsRequired()
                    .HasColumnName("project")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<StatisticLeftMenu>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActionName).HasColumnName("action_name");

                entity.Property(e => e.DisplayOrder).HasColumnName("display_order");

                entity.Property(e => e.IconName).HasColumnName("icon_name");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.ProjectSettingId).HasColumnName("project_setting_id");

                entity.HasOne(d => d.ProjectSetting)
                    .WithMany(p => p.StatisticLeftMenu)
                    .HasForeignKey(d => d.ProjectSettingId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_StatisticLeftMenu_to_PrjSettings");
            });

            modelBuilder.Entity<StatisticLeftMenus>(entity =>
            {
                entity.HasIndex(e => e.ProjectSettingId)
                    .HasName("IX_fk_StatisticLeftMenu_to_PrjSettings");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActionName).HasColumnName("action_name");

                entity.Property(e => e.DisplayOrder).HasColumnName("display_order");

                entity.Property(e => e.IconName).HasColumnName("icon_name");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.ProjectSettingId).HasColumnName("project_setting_id");
            });

            modelBuilder.Entity<StatisticOktell>(entity =>
            {
                entity.ToTable("Statistic_oktell");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Direction)
                    .HasColumnName("direction")
                    .HasMaxLength(50);

                entity.Property(e => e.LineNumber).HasMaxLength(50);

                entity.Property(e => e.Operator).HasMaxLength(50);

                entity.Property(e => e.Project)
                    .HasColumnName("project")
                    .HasMaxLength(50);

                entity.Property(e => e.SubscriberNumber).HasMaxLength(50);

                entity.Property(e => e.TimeAnswer).HasColumnType("datetime");

                entity.Property(e => e.TimeStart).HasColumnType("datetime");

                entity.Property(e => e.TimeStop).HasColumnType("datetime");
            });

            modelBuilder.Entity<StatisticPbx>(entity =>
            {
                entity.ToTable("Statistic_pbx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Answer)
                    .HasColumnName("answer")
                    .HasColumnType("datetime");

                entity.Property(e => e.Appname)
                    .HasColumnName("appname")
                    .HasMaxLength(250);

                entity.Property(e => e.Billsec).HasColumnName("billsec");

                entity.Property(e => e.Dialstatus)
                    .HasColumnName("dialstatus")
                    .HasMaxLength(250);

                entity.Property(e => e.Did)
                    .HasColumnName("did")
                    .HasMaxLength(250);

                entity.Property(e => e.Disposition)
                    .HasColumnName("disposition")
                    .HasMaxLength(250);

                entity.Property(e => e.DstChan)
                    .HasColumnName("dst_chan")
                    .HasMaxLength(250);

                entity.Property(e => e.DstNum)
                    .HasColumnName("dst_num")
                    .HasMaxLength(250);

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.Endtime)
                    .HasColumnName("endtime")
                    .HasColumnType("datetime");

                entity.Property(e => e.FromAccount)
                    .HasColumnName("from_account")
                    .HasMaxLength(250);

                entity.Property(e => e.IsApp)
                    .HasColumnName("is_app")
                    .HasMaxLength(250);

                entity.Property(e => e.Linkedid)
                    .HasColumnName("linkedid")
                    .HasMaxLength(250);

                entity.Property(e => e.Recordingfile)
                    .HasColumnName("recordingfile")
                    .HasMaxLength(250);

                entity.Property(e => e.SrcChan)
                    .HasColumnName("src_chan")
                    .HasMaxLength(250);

                entity.Property(e => e.SrcNum)
                    .HasColumnName("src_num")
                    .HasMaxLength(250);

                entity.Property(e => e.Start)
                    .HasColumnName("start")
                    .HasColumnType("datetime");

                entity.Property(e => e.ToAccount)
                    .HasColumnName("to_account")
                    .HasMaxLength(250);

                entity.Property(e => e.Transfer)
                    .HasColumnName("transfer")
                    .HasMaxLength(250);

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("UNIQUEID")
                    .HasMaxLength(250);

                entity.Property(e => e.WorkCompleted)
                    .HasColumnName("work_completed")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<StatisticPbxOld>(entity =>
            {
                entity.ToTable("Statistic_pbx_old");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Answer)
                    .HasColumnName("answer")
                    .HasColumnType("datetime");

                entity.Property(e => e.Appname)
                    .HasColumnName("appname")
                    .HasMaxLength(250);

                entity.Property(e => e.Billsec).HasColumnName("billsec");

                entity.Property(e => e.Dialstatus)
                    .HasColumnName("dialstatus")
                    .HasMaxLength(250);

                entity.Property(e => e.Did)
                    .HasColumnName("did")
                    .HasMaxLength(250);

                entity.Property(e => e.Disposition)
                    .HasColumnName("disposition")
                    .HasMaxLength(250);

                entity.Property(e => e.DstChan)
                    .HasColumnName("dst_chan")
                    .HasMaxLength(250);

                entity.Property(e => e.DstNum)
                    .HasColumnName("dst_num")
                    .HasMaxLength(250);

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.Endtime)
                    .HasColumnName("endtime")
                    .HasColumnType("datetime");

                entity.Property(e => e.FromAccount)
                    .HasColumnName("from_account")
                    .HasMaxLength(250);

                entity.Property(e => e.IsApp)
                    .HasColumnName("is_app")
                    .HasMaxLength(250);

                entity.Property(e => e.Linkedid)
                    .HasColumnName("linkedid")
                    .HasMaxLength(250);

                entity.Property(e => e.Recordingfile)
                    .HasColumnName("recordingfile")
                    .HasMaxLength(250);

                entity.Property(e => e.SrcChan)
                    .HasColumnName("src_chan")
                    .HasMaxLength(250);

                entity.Property(e => e.SrcNum)
                    .HasColumnName("src_num")
                    .HasMaxLength(250);

                entity.Property(e => e.Start)
                    .HasColumnName("start")
                    .HasColumnType("datetime");

                entity.Property(e => e.ToAccount)
                    .HasColumnName("to_account")
                    .HasMaxLength(250);

                entity.Property(e => e.Transfer)
                    .HasColumnName("transfer")
                    .HasMaxLength(250);

                entity.Property(e => e.Uniqueid)
                    .HasColumnName("UNIQUEID")
                    .HasMaxLength(250);

                entity.Property(e => e.WorkCompleted)
                    .HasColumnName("work_completed")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<StatusSign>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountId).HasColumnName("account_id");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.DocumentTemplatesId).HasColumnName("document_templates_id");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasMaxLength(128);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.StatusSign)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_StatusSign_Accounts");

                entity.HasOne(d => d.DocumentTemplates)
                    .WithMany(p => p.StatusSign)
                    .HasForeignKey(d => d.DocumentTemplatesId)
                    .HasConstraintName("FK_StatusSign_Documents_Templates");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.StatusSign)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_StatusSign_AspNetUsers");
            });

            modelBuilder.Entity<TableColumnType>(entity =>
            {
                entity.ToTable("Table_Column_Type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(250);

                entity.Property(e => e.TypeId)
                    .IsRequired()
                    .HasColumnName("typeId")
                    .HasMaxLength(128);

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.TableColumnType)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Table_Column_Type_Table_type");
            });

            modelBuilder.Entity<TableColumns>(entity =>
            {
                entity.ToTable("Table_Columns");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.EnumId).HasColumnName("enumId");

                entity.Property(e => e.ExcelId).HasColumnName("excelId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(250);

                entity.Property(e => e.Posx).HasColumnName("posx");

                entity.Property(e => e.Posy).HasColumnName("posy");

                entity.Property(e => e.Tableid).HasColumnName("tableid");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Width).HasColumnName("width");

                entity.HasOne(d => d.Enum)
                    .WithMany(p => p.TableColumns)
                    .HasForeignKey(d => d.EnumId)
                    .HasConstraintName("FK_Table_Columns_Table_Column_Type");

                entity.HasOne(d => d.Table)
                    .WithMany(p => p.TableColumns)
                    .HasForeignKey(d => d.Tableid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Table_Columns_Tablies_");
            });

            modelBuilder.Entity<TableData>(entity =>
            {
                entity.ToTable("Table_Data");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ColumnId).HasColumnName("columnId");

                entity.Property(e => e.RowId).HasColumnName("rowId");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.HasOne(d => d.Column)
                    .WithMany(p => p.TableData)
                    .HasForeignKey(d => d.ColumnId)
                    .HasConstraintName("FK_Table_Data_Table_Columns");

                entity.HasOne(d => d.Row)
                    .WithMany(p => p.TableData)
                    .HasForeignKey(d => d.RowId)
                    .HasConstraintName("FK_Table_Data_Table_Rows");
            });

            modelBuilder.Entity<TableRows>(entity =>
            {
                entity.ToTable("Table_Rows");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.TableId).HasColumnName("tableId");

                entity.HasOne(d => d.Table)
                    .WithMany(p => p.TableRows)
                    .HasForeignKey(d => d.TableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Table_Rows_Tablies_");
            });

            modelBuilder.Entity<TableType>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.ToTable("Table_type");

                entity.Property(e => e.TypeId)
                    .HasColumnName("typeId")
                    .HasMaxLength(128)
                    .HasDefaultValueSql("(CONVERT([nvarchar](128),newid(),(0)))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.PatchMethod)
                    .IsRequired()
                    .HasColumnName("patchMethod");
            });

            modelBuilder.Entity<Tables>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TablesInEntity>(entity =>
            {
                entity.ToTable("Tables_In_Entity");

                entity.Property(e => e.EntityId).HasColumnName("entityId");

                entity.Property(e => e.TableId).HasColumnName("tableId");

                entity.Property(e => e.TypeTable).HasColumnName("typeTable");
            });

            modelBuilder.Entity<TablesPatterns>(entity =>
            {
                entity.ToTable("Tables_Patterns");

                entity.Property(e => e.TableId).HasColumnName("tableId");

                entity.Property(e => e.TypeTable).HasColumnName("typeTable");
            });

            modelBuilder.Entity<Tablies>(entity =>
            {
                entity.ToTable("Tablies_");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(250);

                entity.Property(e => e.TypeId)
                    .HasColumnName("typeId")
                    .HasMaxLength(128);

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Tablies)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_Tablies__Table_type1");
            });

            modelBuilder.Entity<Tarifs>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateCreate)
                    .HasColumnName("date_create")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TarifsData>(entity =>
            {
                entity.ToTable("Tarifs_Data");

                entity.HasIndex(e => e.TarifId)
                    .HasName("IX_FK_Tarifs_Data_Tarifs");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.TarifId).HasColumnName("tarifId");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.HasOne(d => d.Tarif)
                    .WithMany(p => p.TarifsData)
                    .HasForeignKey(d => d.TarifId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tarifs_Data_Tarifs");
            });

            modelBuilder.Entity<TaskCheckList>(entity =>
            {
                entity.ToTable("Task_Check_List");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasColumnName("color");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.Ischeck).HasColumnName("ischeck");

                entity.Property(e => e.Ordering).HasColumnName("ordering");

                entity.Property(e => e.TasksId).HasColumnName("tasksId");

                entity.Property(e => e.Text).HasColumnName("text");

                entity.Property(e => e.UserId)
                    .HasColumnName("userId")
                    .HasMaxLength(128);

                entity.HasOne(d => d.Tasks)
                    .WithMany(p => p.TaskCheckList)
                    .HasForeignKey(d => d.TasksId)
                    .HasConstraintName("FK_Task_Check_List_Tasks");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TaskCheckList)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Task_Check_List_AspNetUsers");
            });

            modelBuilder.Entity<TaskChecks>(entity =>
            {
                entity.ToTable("Task_Checks");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(1000);

                entity.Property(e => e.Ordering).HasColumnName("ordering");

                entity.Property(e => e.TasksId).HasColumnName("tasksId");

                entity.HasOne(d => d.Tasks)
                    .WithMany(p => p.TaskChecks)
                    .HasForeignKey(d => d.TasksId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Task_Checks_Tasks");
            });

            modelBuilder.Entity<TaskDoers>(entity =>
            {
                entity.ToTable("Task_Doers");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.TasksId).HasColumnName("tasksId");

                entity.Property(e => e.UserId)
                    .HasColumnName("userId")
                    .HasMaxLength(128);

                entity.HasOne(d => d.Tasks)
                    .WithMany(p => p.TaskDoers)
                    .HasForeignKey(d => d.TasksId)
                    .HasConstraintName("FK_Task_Doers_Tasks");
            });

            modelBuilder.Entity<TaskFollowers>(entity =>
            {
                entity.ToTable("Task_Followers");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.TasksId).HasColumnName("tasksId");

                entity.Property(e => e.UserId)
                    .HasColumnName("userId")
                    .HasMaxLength(128);

                entity.HasOne(d => d.Tasks)
                    .WithMany(p => p.TaskFollowers)
                    .HasForeignKey(d => d.TasksId)
                    .HasConstraintName("FK_Task_Followers_Tasks");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TaskFollowers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Task_Followers_AspNetUsers");
            });

            modelBuilder.Entity<TaskPersonalStatuses>(entity =>
            {
                entity.ToTable("Task_Personal_Statuses");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Color)
                    .HasColumnName("color")
                    .HasMaxLength(50);

                entity.Property(e => e.Completed).HasColumnName("completed");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Ordering).HasColumnName("ordering");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("userId")
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<TaskPriority>(entity =>
            {
                entity.ToTable("Task_Priority");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name).HasColumnName("name");
            });

            modelBuilder.Entity<TaskProjectsStatuses>(entity =>
            {
                entity.ToTable("Task_Projects_Statuses");

                entity.Property(e => e.Color)
                    .HasColumnName("color")
                    .HasMaxLength(50);

                entity.Property(e => e.Completed).HasColumnName("completed");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Ordering).HasColumnName("ordering");

                entity.Property(e => e.ProgectId).HasColumnName("progectId");

                entity.HasOne(d => d.Progect)
                    .WithMany(p => p.TaskProjectsStatuses)
                    .HasForeignKey(d => d.ProgectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Task_Projects_Statuses_Projects");
            });

            modelBuilder.Entity<TaskStatusHistory>(entity =>
            {
                entity.ToTable("Task_Status_History");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ChanageDate)
                    .HasColumnName("chanageDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PersonalStatusId).HasColumnName("personalStatusId");

                entity.Property(e => e.StatusId).HasColumnName("statusId");

                entity.Property(e => e.TasksId).HasColumnName("tasksId");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("userId")
                    .HasMaxLength(128);

                entity.HasOne(d => d.PersonalStatus)
                    .WithMany(p => p.TaskStatusHistory)
                    .HasForeignKey(d => d.PersonalStatusId)
                    .HasConstraintName("FK_Task_Status_History_Task_Personal_Statuses");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TaskStatusHistory)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_Task_Status_History_Task_Projects_Statuses");

                entity.HasOne(d => d.Tasks)
                    .WithMany(p => p.TaskStatusHistory)
                    .HasForeignKey(d => d.TasksId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Task_Status_History_Tasks");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TaskStatusHistory)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Task_Status_History_AspNetUsers");
            });

            modelBuilder.Entity<TaskTags>(entity =>
            {
                entity.ToTable("Task_Tags");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.TasksId).HasColumnName("tasksId");

                entity.HasOne(d => d.Tasks)
                    .WithMany(p => p.TaskTags)
                    .HasForeignKey(d => d.TasksId)
                    .HasConstraintName("FK_Task_Tags_Tasks");
            });

            modelBuilder.Entity<Tasks>(entity =>
            {
                entity.Property(e => e.CreateDate)
                    .HasColumnName("createDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatorId)
                    .IsRequired()
                    .HasColumnName("creatorId")
                    .HasMaxLength(128);

                entity.Property(e => e.CriticalDate)
                    .HasColumnName("criticalDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.DoerId)
                    .IsRequired()
                    .HasColumnName("doerId")
                    .HasMaxLength(128);

                entity.Property(e => e.IsExternal).HasColumnName("isExternal");

                entity.Property(e => e.IsImportant).HasColumnName("isImportant");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.OwnerId)
                    .HasColumnName("ownerId")
                    .HasMaxLength(128);

                entity.Property(e => e.ParentTask).HasColumnName("parentTask");

                entity.Property(e => e.PriorityId).HasColumnName("priorityId");

                entity.Property(e => e.ProjectId).HasColumnName("projectId");

                entity.Property(e => e.StartDate)
                    .HasColumnName("startDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.StopDate)
                    .HasColumnName("stopDate")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Doer)
                    .WithMany(p => p.TasksDoer)
                    .HasForeignKey(d => d.DoerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tasks_AspNetUsers");

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.TasksOwner)
                    .HasForeignKey(d => d.OwnerId)
                    .HasConstraintName("FK_Tasks_AspNetUsers1");

                entity.HasOne(d => d.ParentTaskNavigation)
                    .WithMany(p => p.InverseParentTaskNavigation)
                    .HasForeignKey(d => d.ParentTask)
                    .HasConstraintName("FK_Tasks_Tasks");

                entity.HasOne(d => d.Priority)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.PriorityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tasks_Task_Priority");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_Tasks_Projects");
            });

            modelBuilder.Entity<TemplatesKp>(entity =>
            {
                entity.ToTable("TemplatesKP");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Bytestream).HasColumnName("bytestream");

                entity.Property(e => e.NameTemplate).HasMaxLength(50);

                entity.Property(e => e.Standart).HasColumnName("standart");

                entity.Property(e => e.TypefileId).HasColumnName("typefile_id");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.Typefile)
                    .WithMany(p => p.TemplatesKp)
                    .HasForeignKey(d => d.TypefileId)
                    .HasConstraintName("FK_TemplatesKP_TypeFileKP");
            });

            modelBuilder.Entity<TypeFileKp>(entity =>
            {
                entity.ToTable("TypeFileKP");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Typefile)
                    .HasColumnName("typefile")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<UsersProviders>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("users_providers", "inventory3");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ProviderId).HasColumnName("provider_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<_1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("'1$'");

                entity.Property(e => e.Наименование)
                    .HasColumnName("наименование")
                    .HasMaxLength(255);

                entity.Property(e => e.Окпд)
                    .HasColumnName("окпд")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<_100txFindCategory>(entity =>
            {
                entity.ToTable("100tx_FindCategory");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.IsChecked).HasColumnName("is_checked");

                entity.Property(e => e.LineId).HasColumnName("line_id");

                entity.Property(e => e.SpecId).HasColumnName("spec_id");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p._100txFindCategory)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_100tx_FindCategory_catalog_categories");

                entity.HasOne(d => d.Spec)
                    .WithMany(p => p._100txFindCategory)
                    .HasForeignKey(d => d.SpecId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_100tx_FindCategory_aleks_daspecs_maintbl");
            });

            modelBuilder.Entity<_100txGoodLoaderLoaderTypes>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("100tx_GoodLoader_LoaderTypes");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<_100txGoodLoaderProviderUrls>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("100tx_GoodLoader_ProviderUrls");

                entity.Property(e => e.LoadType).HasColumnName("loadType");

                entity.Property(e => e.ProviderId).HasColumnName("provider_id");

                entity.Property(e => e.UrlList)
                    .IsRequired()
                    .HasColumnName("url_list")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<_100txLayoutsDoc>(entity =>
            {
                entity.ToTable("100tx_LayoutsDoc");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(128)
                    .HasDefaultValueSql("(CONVERT([nvarchar](128),newid(),(0)))");

                entity.Property(e => e.FileData)
                    .IsRequired()
                    .HasColumnName("fileData");

                entity.Property(e => e.LayoutType).HasColumnName("layoutType");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.HasOne(d => d.LayoutTypeNavigation)
                    .WithMany(p => p._100txLayoutsDoc)
                    .HasForeignKey(d => d.LayoutType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_100tx_Layouts_100tx_Layouts_types");
            });

            modelBuilder.Entity<_100txLayoutsDocTypes>(entity =>
            {
                entity.ToTable("100tx_LayoutsDoc_types");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<_100txOrders>(entity =>
            {
                entity.ToTable("100tx_Orders");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Account).HasColumnName("account");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CreatorAccount).HasColumnName("creatorAccount");

                entity.Property(e => e.DateStage)
                    .HasColumnName("date_stage")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dateadd)
                    .HasColumnName("dateadd")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Markup).HasColumnName("markup");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.PlanPurchase)
                    .HasColumnName("plan_purchase")
                    .HasMaxLength(50);

                entity.Property(e => e.Specification).HasColumnName("specification");

                entity.Property(e => e.Stage)
                    .HasColumnName("stage")
                    .HasMaxLength(128);

                entity.Property(e => e.Sum).HasColumnName("sum");

                entity.Property(e => e.TermStage)
                    .HasColumnName("term_stage")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.AccountNavigation)
                    .WithMany(p => p._100txOrders)
                    .HasForeignKey(d => d.Account)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_100tx_Orders_Accounts");

                entity.HasOne(d => d.StageNavigation)
                    .WithMany(p => p._100txOrders)
                    .HasForeignKey(d => d.Stage)
                    .HasConstraintName("FK_100tx_Orders_100tx_Stages");
            });

            modelBuilder.Entity<_100txOrdersStatusHistory>(entity =>
            {
                entity.ToTable("100tx_OrdersStatusHistory");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProvId).HasColumnName("prov_id");

                entity.Property(e => e.SpecId).HasColumnName("spec_id");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p._100txOrdersStatusHistory)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_100tx_OrdersStatusHistory_100tx_OrdersStatuses");
            });

            modelBuilder.Entity<_100txOrdersStatuses>(entity =>
            {
                entity.ToTable("100tx_OrdersStatuses");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Color)
                    .HasColumnName("color")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<_100txPlanPositions>(entity =>
            {
                entity.ToTable("100tx_PlanPositions");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Characteristic).HasColumnName("characteristic");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.CostAverage).HasColumnName("costAverage");

                entity.Property(e => e.CostStart).HasColumnName("costStart");

                entity.Property(e => e.File)
                    .HasColumnName("file")
                    .HasMaxLength(50);

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.Plan).HasColumnName("plan");

                entity.Property(e => e.Revision)
                    .HasColumnName("revision")
                    .HasMaxLength(50);

                entity.Property(e => e.Summ1).HasColumnName("summ1");

                entity.Property(e => e.Summ2).HasColumnName("summ2");

                entity.Property(e => e.SummAll).HasColumnName("summAll");

                entity.Property(e => e.SummCurrent).HasColumnName("summCurrent");

                entity.Property(e => e.SummLast).HasColumnName("summLast");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50);

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasMaxLength(50);

                entity.Property(e => e.Volume1).HasColumnName("volume1");

                entity.Property(e => e.Volume2).HasColumnName("volume2");

                entity.Property(e => e.VolumeAll).HasColumnName("volumeAll");

                entity.Property(e => e.VolumeCurrent).HasColumnName("volumeCurrent");

                entity.Property(e => e.VolumeIs).HasColumnName("volumeIs");

                entity.Property(e => e.VolumeLast).HasColumnName("volumeLast");

                entity.HasOne(d => d.PlanNavigation)
                    .WithMany(p => p._100txPlanPositions)
                    .HasForeignKey(d => d.Plan)
                    .HasConstraintName("FK_100tx_PlanPositions_100tx_plans");
            });

            modelBuilder.Entity<_100txPlans>(entity =>
            {
                entity.ToTable("100tx_plans");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Account).HasColumnName("account");

                entity.Property(e => e.DateApproval)
                    .HasColumnName("date_approval")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DateApprovalRationale)
                    .HasColumnName("date_approval_rationale")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DatePublic)
                    .HasColumnName("date_public")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DateSheduleChange)
                    .HasColumnName("date_shedule_change")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Dateadd)
                    .HasColumnName("dateadd")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PlanPurchase)
                    .HasColumnName("plan_purchase")
                    .HasMaxLength(50);

                entity.Property(e => e.PlanShedule)
                    .HasColumnName("plan_shedule")
                    .HasMaxLength(50);

                entity.Property(e => e.Region).HasColumnName("region");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50);

                entity.Property(e => e.YearShedule)
                    .HasColumnName("year_shedule")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.AccountNavigation)
                    .WithMany(p => p._100txPlans)
                    .HasForeignKey(d => d.Account)
                    .HasConstraintName("FK_100tx_plans_Accounts");
            });

            modelBuilder.Entity<_100txPositionAlternates>(entity =>
            {
                entity.ToTable("100tx_position_alternates");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountId).HasColumnName("account_id");

                entity.Property(e => e.GoodstblId).HasColumnName("goodstbl_id");
            });

            modelBuilder.Entity<_100txPositionAlternatesCatalogs>(entity =>
            {
                entity.ToTable("100tx_position_alternates_catalogs");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<_100txRegions>(entity =>
            {
                entity.ToTable("100tx_Regions");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.HeaderId).HasColumnName("headerId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.OktmoCode)
                    .IsRequired()
                    .HasColumnName("oktmoCode")
                    .HasMaxLength(50);

                entity.Property(e => e.OktmoId)
                    .IsRequired()
                    .HasColumnName("oktmoId")
                    .HasMaxLength(50);

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.HasOne(d => d.Header)
                    .WithMany(p => p._100txRegions)
                    .HasForeignKey(d => d.HeaderId)
                    .HasConstraintName("FK_100tx_Regions_100tx_RegionsHeaders");
            });

            modelBuilder.Entity<_100txRegionsHeaders>(entity =>
            {
                entity.ToTable("100tx_RegionsHeaders");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.OktmoCode)
                    .IsRequired()
                    .HasColumnName("oktmoCode")
                    .HasMaxLength(50);

                entity.Property(e => e.OktmoId)
                    .IsRequired()
                    .HasColumnName("oktmoId")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<_100txRevisions>(entity =>
            {
                entity.HasKey(e => e.Revision);

                entity.ToTable("100tx_Revisions");

                entity.Property(e => e.Revision)
                    .HasColumnName("revision")
                    .HasMaxLength(50);

                entity.Property(e => e.IsLoaded).HasColumnName("isLoaded");
            });

            modelBuilder.Entity<_100txStages>(entity =>
            {
                entity.ToTable("100tx_Stages");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(128)
                    .HasDefaultValueSql("(CONVERT([nvarchar](128),newid(),(0)))");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<_100txTasksStatusesHb>(entity =>
            {
                entity.ToTable("100tx_TasksStatusesHB");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<_100txZakupkiTasks>(entity =>
            {
                entity.ToTable("100tx_ZakupkiTasks");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasColumnName("region")
                    .HasMaxLength(255);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TaskId)
                    .IsRequired()
                    .HasColumnName("task_id")
                    .HasMaxLength(50);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p._100txZakupkiTasks)
                    .HasForeignKey(d => d.Status)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_100tx_ZakupkiTasks_100tx_TasksStatusesHB");
            });

            modelBuilder.Entity<_30031>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("30031");

                entity.Property(e => e.Direction)
                    .HasColumnName("direction")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LineNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Operator)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubscriberNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeAnswer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStart)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStop)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeTalking)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeWaiting)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Лист1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Лист1$");

                entity.Property(e => e.Alias)
                    .HasColumnName("alias")
                    .HasMaxLength(255);

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasMaxLength(255);

                entity.Property(e => e.Createdby).HasColumnName("createdby");

                entity.Property(e => e.Createdon).HasColumnName("createdon");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Editedby).HasColumnName("editedby");

                entity.Property(e => e.Editedon).HasColumnName("editedon");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsService).HasColumnName("is_service");

                entity.Property(e => e.Longtitle)
                    .HasColumnName("longtitle")
                    .HasMaxLength(255);

                entity.Property(e => e.Okpd)
                    .HasColumnName("okpd")
                    .HasMaxLength(255);

                entity.Property(e => e.Pagetitle)
                    .HasColumnName("pagetitle")
                    .HasMaxLength(255);

                entity.Property(e => e.Parent).HasColumnName("parent");
            });

            modelBuilder.Entity<Окпд2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ОКПД2");

                entity.Property(e => e.Наименование)
                    .HasColumnName("наименование")
                    .IsUnicode(false);

                entity.Property(e => e.Окпд)
                    .HasColumnName("окпд")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Окпд22>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ОКПД22");

                entity.Property(e => e.Наименование)
                    .HasColumnName("наименование")
                    .IsUnicode(false);

                entity.Property(e => e.Окпд)
                    .HasColumnName("окпд")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
