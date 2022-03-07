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
                    config.Update(U => U.HasName("Update_PC"));
                    config.Delete(D => D.HasName("Delete_PC"));
                });
        }
    }
}