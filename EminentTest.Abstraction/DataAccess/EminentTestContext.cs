using EminentTest.DB;
using EminentTest.DB.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EminentTest.Abstraction.DataAccess
{
    public class EminentTestContext: DbContext
    {
        public EminentTestContext(DbContextOptions<EminentTestContext> opt) : base(opt)
        {

        }
        public DbSet<Student> Students { get; set; }

        public DbSet<Lookup> Lookups { get; set; }
        public DbSet<Equipment> Equipments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lookup>().HasData(new Lookup
            {
               Id = Guid.NewGuid(),
               LookupName = "Gender",
               LookupType = "Gender",
               LookupDescription = "Male",
               LookupValue = 1
            }, new Lookup
            {
                Id = Guid.NewGuid(),
                LookupName = "Gender",
                LookupType = "Gender",
                LookupDescription = "Female",
                LookupValue = 0
            });
            modelBuilder.Entity<Lookup>().HasData(new Lookup
            {
                Id = Guid.NewGuid(),
                LookupName = "StatusName",
                LookupType = "Status",
                LookupDescription = "Active",
                LookupValue = 10
            }, new Lookup
            {
                Id = Guid.NewGuid(),
                LookupName = "StatusName",
                LookupType = "Status",
                LookupDescription = "Inactive",
                LookupValue = 20
            });
            modelBuilder.Entity<Lookup>().HasData(new Lookup
            {
                Id = Guid.NewGuid(),
                LookupName = "EquipmentTypeName",
                LookupType = "EquipmentType",
                LookupDescription = "Indoor",
                LookupValue = 30
            }, new Lookup
            {
                Id = Guid.NewGuid(),
                LookupName = "EquipmentTypeName",
                LookupType = "EquipmentType",
                LookupDescription = "Outdoor",
                LookupValue = 60
            });
        }

    }
}
