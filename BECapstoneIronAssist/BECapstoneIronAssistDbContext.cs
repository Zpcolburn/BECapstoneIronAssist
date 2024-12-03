using Microsoft.EntityFrameworkCore;
using BECapstoneIronAssist.Models;
using BECapstoneIronAssist.Data;
using System.IO;

namespace BECapstoneIronAssist
{
    public class BECapstoneIronAssistDbContext : DbContext
    {
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<Jobsite> Jobsites { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<EquipmentPart>EquipmentParts { get; set; }

        public BECapstoneIronAssistDbContext(DbContextOptions<BECapstoneIronAssistDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Equipment>().HasData(EquipmentData.Equipment);
            modelBuilder.Entity<Jobsite>().HasData(JobsiteData.Jobsites);
            modelBuilder.Entity<Report>().HasData(ReportData.Reports);
            modelBuilder.Entity<User>().HasData(UserData.Users);
            modelBuilder.Entity<Part>().HasData(PartData.Parts);

            // Many to Many Parts and Equipment
            modelBuilder.Entity<EquipmentPart>()
                .HasKey(pe => new { pe.PartId, pe.EquipmentId }); 

            modelBuilder.Entity<EquipmentPart>()
                .HasOne(pe => pe.Parts)
                .WithMany(p => p.EquipmentParts)
                .HasForeignKey(pe => pe.PartId);

            modelBuilder.Entity<EquipmentPart>()
                .HasOne(pe => pe.Equipment)
                .WithMany(e => e.EquipmentParts)
                .HasForeignKey(pe => pe.EquipmentId);

            // One to ManyJobsite and Equipment 
            modelBuilder.Entity<Jobsite>()
                .HasMany(j => j.Equipment)
                .WithOne(e => e.Jobsite)
                .HasForeignKey(e => e.JobsiteId)
                .OnDelete(DeleteBehavior.SetNull);

            // One to Many Jobsite and Reports
            modelBuilder.Entity<Jobsite>()
                .HasMany(j => j.Reports)
                .WithOne(r => r.Jobsite)
                .HasForeignKey(r => r.JobsiteId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.SetNull);

            // One To Many Equipment and Reports 
            modelBuilder.Entity<Report>()
                .HasOne(r => r.Equipment)
                .WithMany()
                .HasForeignKey(r => r.EquipmentId)
                .OnDelete(DeleteBehavior.Restrict);

            // One to Many User and Reports  
            modelBuilder.Entity<Report>()
                .HasOne(r => r.User)
                .WithMany(u => u.Reports)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
