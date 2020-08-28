using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Telegram.Bot.Examples.Echo.Models
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

        public virtual DbSet<DiaryPosts> DiaryPosts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=u436263.mssql.masterhost.ru;Database=u436263_100tztest;User ID=u436263_test; Password=pr7pitting;multisubnetfailover=false;Trusted_Connection=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DiaryPosts>(entity =>
            {
                entity.ToTable("Diary_Posts");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateCreate)
                    .HasColumnName("dateCreate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fiile).HasColumnName("fiile");

                entity.Property(e => e.Filedata).HasColumnName("filedata");

                entity.Property(e => e.Text).HasColumnName("text");

                entity.Property(e => e.Video).HasColumnName("video");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
