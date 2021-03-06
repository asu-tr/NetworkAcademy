using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace W10_01_AutoStoredProcedure.Models
{
    public class DBContext : DbContext
    {
        public DbSet<Computer> Computers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Computer>().MapToStoredProcedures
                (config =>
                {
                    config.Insert(I => I.HasName("Add_PC"));

                    config.Update(U => {
                        U.HasName("Update_PC");
                        U.Parameter(C => C.Id, "pcId");
                    });

                    config.Delete(D => D.HasName("Delete_PC"));
                });
        }
    }
        
    public class DbInit : CreateDatabaseIfNotExists<DBContext>
    {
        protected override void Seed(DBContext context)
        {
            context.Database.ExecuteSqlCommand(@"CREATE PROC AddSomePC
                AS BEGIN
                INSERT INTO Computers VALUES ('MSI', 'RTX3050')
                INSERT INTO Computers VALUES ('ASUS', 'RTX3050')
                INSERT INTO Computers VALUES ('MSI', 'RTX3060')
                END");

            context.Database.ExecuteSqlCommand(@"CREATE PROC BrandFilter
                @brand NVARCHAR
                AS BEGIN
                SELECT Brand, COUNT(Brand) AS BrandCount
                FROM Computers WHERE Brand = @brand
                GROUP BY Brand
                END");
        }
    }
}