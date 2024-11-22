using Microsoft.EntityFrameworkCore;
using BECapstoneIronAssist.Models;
using BECapstoneIronAssist.Data;

namespace BECapstoneIronAssist
{
    public class BECapstoneIronAssistDbContext : DbContext
    {
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<Jobsite> Jobsites { get; set; } 
        public DbSet<Report> Reports { get; set; }
        public DbSet<User> Users { get; set; }

        public BECapstoneIronAssistDbContext(DbContextOptions<BECapstoneIronAssistDbContext> context) : base(context) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Equipment>().HasData(EquipmentData.Equipment);
            modelBuilder.Entity<Jobsite>().HasData(JobsiteData.Jobsites);
            modelBuilder.Entity<Report>().HasData(ReportData.Reports);
            modelBuilder.Entity<User>().HasData(UserData.Users);

            modelBuilder.Entity<Equipment>()
                .HasMany(e => e.Users)
                .WithMany(u => u.Equipment);

            modelBuilder.Entity<Jobsite>()
                .HasMany(j => j.Equipment)
                .WithOne(e => e.Jobsite)
                .HasForeignKey(e => e.JobsiteId);

            modelBuilder.Entity<Jobsite>()
                .HasMany(j => j.Reports)
                .WithOne(r => r.Jobsite)
                .HasForeignKey(r => r.JobsiteId)
                .IsRequired(false);

            modelBuilder.Entity<Jobsite>()
                .HasOne(j => j.User)
                .WithMany()
                .HasForeignKey(j => j.UserId);

            modelBuilder.Entity<Report>()
                .HasOne(r => r.Equipment)
                .WithMany()
                .HasForeignKey(r => r.EquipmentId);
            modelBuilder.Entity<Report>()
                .HasOne(r => r.Jobsite)
                .WithMany()
                .HasForeignKey(r => r.JobsiteId)
                .IsRequired(false);
        }
    }
}
