using System;
using System.Collections.Generic;
using System.Text;
using COVID19Alert.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace COVID19Alert.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>()
                .HasData(
                new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Name = "RegisteredUser",
                    NormalizedName = "REGISTEREDNAME"
                },
                new IdentityRole
                {
                    Name = "MedicalHotline",
                    NormalizedName = "MEDICALHOTLINE"
                }
            );
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Age> Ages { get; set; }
        public DbSet<HouseHold> HouseHolds { get; set; }
        public DbSet<MedicalHotline> MedicalHotlines { get; set; }
        public DbSet<RegisteredUser> RegisteredUsers { get; set; }


    }
}
