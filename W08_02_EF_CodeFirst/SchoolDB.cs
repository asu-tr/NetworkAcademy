using System;
using System.Data.Entity;
using System.Linq;

namespace W08_02_EF_CodeFirst
{
    public class SchoolDB : DbContext
    {
        public SchoolDB()
            : base("name=SchoolDB")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Lecture> Lectures { get; set; }
        public virtual DbSet<Parent> Parents { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}